namespace HumanResources_net6.Forms
{
	public partial class AddEditEmployee : Form
	{
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
			tbId.Text = _employee.Id.ToString();
			tbFirstName.Text = _employee.FirsName;
			tbLastName.Text = _employee.LastName;
			numSalary.Value = _employee.Salary;
			dtpDateOfEmployment.Value = _employee.DateOfEmployment;
			rtbComments.Text = _employee.Comments;
		}

		private void SetEmployeeFields()
		{
			_employee.FirsName = tbFirstName.Text.Trim();
			_employee.LastName = tbLastName.Text.Trim();
			_employee.Salary = numSalary.Value;
			_employee.DateOfEmployment = dtpDateOfEmployment.Value.Date;
			_employee.Comments = rtbComments.Text;
		}

		private bool IsProperlyFill()
		{
			if (string.IsNullOrWhiteSpace(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbLastName.Text))
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
