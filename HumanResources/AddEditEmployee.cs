using HumanResources.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HumanResources
{
	public partial class AddEditEmployee : Form
	{
		//private readonly FileSerializer<List<Employee>> _XmlFileSerializer = new FileSerializer<List<Employee>>(SerializeMode.XML, Environment.ExpandEnvironmentVariables(Settings.Default.PathToFileXml));
		//private readonly FileSerializer<List<Employee>> _JsonFileSerializer = new FileSerializer<List<Employee>>(SerializeMode.JSON, Environment.ExpandEnvironmentVariables(Settings.Default.PathToFileJson));

		private Employee _employee;

		public AddEditEmployee(Employee employee = null)
		{
			InitializeComponent();

			if (employee != null)
			{
				Text = "Edytuj dane pracownika";
				_employee = employee;
				FillTextBoxes();
			}
		}

		private void FillTextBoxes()
		{
			TBId.Text = _employee.Id.ToString();
			TBFirstName.Text = _employee.FirsName;
			TBLastName.Text = _employee.LastName;
			NumSalary.Value = _employee.Salary;
			DTPDateOfEmployment.Value = _employee.DateOfEmployment;
			RTBComments.Text = _employee.Comments;
		}

		private void SetEmployeeFields()
		{
			_employee.FirsName = TBFirstName.Text.Trim();
			_employee.LastName = TBLastName.Text.Trim();
			_employee.Salary = NumSalary.Value;
			_employee.DateOfEmployment = DTPDateOfEmployment.Value.Date;
			_employee.Comments = RTBComments.Text;
		}

		private bool IsProperlyFill()
		{
			if (string.IsNullOrWhiteSpace(TBFirstName.Text) || string.IsNullOrWhiteSpace(TBLastName.Text))
			{
				MessageBox.Show("Pola imię i nazwisko muszą być wypełnione!");
				return false;
			}

			return true;
		}

		private void BtnConfirm_Click(object sender, EventArgs e)
		{
			if (!IsProperlyFill())
				return;

			var employees = Program.SerializeToFile.Deserialize();

			if (_employee == null)
			{
				int id = employees.Count == 0 ? 1 : employees.Max(x => x.Id) + 1;
				_employee = new Employee() { Id = id, IsEmployed = true };
			}

			SetEmployeeFields();

			employees.RemoveAll(x => x.Id == _employee.Id);
			employees.Add(_employee);

			Program.SerializeToFile.Serialize(employees);

			Close();
		}

		private void BtnCancel_Click(object sender, EventArgs e) => Close();
	}
}
