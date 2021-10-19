using System;
using System.Windows.Forms;

namespace HumanResources
{
	public partial class DismissEmployee : Form
	{
		//private readonly FileSerializer<List<Employee>> _fileSerializer = new FileSerializer<List<Employee>>(SerializeMode.XML, Environment.ExpandEnvironmentVariables(Settings.Default.PathToFileXml));
		//private readonly FileSerializer<List<Employee>> _fileSerializer = new FileSerializer<List<Employee>>(SerializeMode.JSON, Environment.ExpandEnvironmentVariables(Settings.Default.PathToFileJson));

		private readonly Employee _employee;

		public DismissEmployee(Employee employee)
		{
			InitializeComponent();
			_employee = employee;
			FillTextBoxes();
		}

		private void FillTextBoxes()
		{
			TBId.Text = _employee.Id.ToString();
			TBFirstName.Text = _employee.FirsName;
			TBLastName.Text = _employee.LastName;
			DTPDateOfDismiss.Value = _employee.DateOfDismiss ?? DateTime.Now;
		}

		private void SetEmployeeFields()
		{
			_employee.DateOfDismiss = DTPDateOfDismiss.Value.Date;
			_employee.IsEmployed = false;
		}

		private void BtnConfirm_Click(object sender, EventArgs e)
		{
			var employees = Program.SerializeToFile.Deserialize();

			SetEmployeeFields();

			employees.RemoveAll(x => x.Id == _employee.Id);
			employees.Add(_employee);

			Program.SerializeToFile.Serialize(employees);

			Close();
		}

		private void BtnCancel_Click(object sender, EventArgs e) => Close();
	}
}
