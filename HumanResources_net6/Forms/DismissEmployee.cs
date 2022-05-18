namespace HumanResources_net6.Forms
{
	public partial class DismissEmployee : Form
	{
		private readonly Employee _employee;

		public DismissEmployee(Employee employee)
		{
			InitializeComponent();
			_employee = employee;
			FillTextBoxes();
		}

		private void FillTextBoxes()
		{
			tbId.Text = _employee.Id.ToString();
			tbFirstName.Text = _employee.FirsName;
			tbLastName.Text = _employee.LastName;
			dtpDateOfDismiss.Value = _employee.DateOfDismiss ?? DateTime.Now;
		}

		private void SetEmployeeFields()
		{
			_employee.DateOfDismiss = dtpDateOfDismiss.Value.Date;
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
