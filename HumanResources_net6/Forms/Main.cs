using HumanResources_net6.Properties;

namespace HumanResources_net6.Forms
{
	public partial class Main : Form
	{
		private List<Employee> _employees;

		private int _selectedIndex;

		public Main()
		{
			InitializeComponent();
			SetWindowState();
			FillStatus();
			RefreshEmployees();
			SetColumnsHeader();
		}

		private void SetWindowState()
		{
			WindowState = Settings.Default.IsMaximize ? FormWindowState.Maximized : FormWindowState.Normal;
			Width = Settings.Default.MainWindowWidth;
			Height = Settings.Default.MainWindowHeight;
		}

		private void FillStatus()
		{
			//_states = StateHelper.GetStates("Wszyscy");
			//cbState.DataSource = _states;
			//cbState.DisplayMember = "Name";
			//cbState.ValueMember = "Id";

			cbState.DataSource = new string[] { "Wszyscy", "Zatrudnieni", "Zwolnieni" };
			cbState.SelectedIndexChanged += CBGroup_SelectedIndexChanged;
		}

		private void RefreshEmployees()
		{
			_employees = Program.SerializeToFile.Deserialize();

			if (cbState.SelectedValue.ToString() == "Zatrudnieni")
				_employees = _employees.Where(x => x.IsEmployed).ToList();
			if (cbState.SelectedValue.ToString() == "Zwolnieni")
				_employees = _employees.Where(x => !x.IsEmployed).ToList();

			_employees.Sort();
			dgvEmployees.DataSource = _employees;

			if (_employees.Count() != 0 && _selectedIndex < _employees.Count())
				dgvEmployees.Rows[_selectedIndex].Selected = true;
		}

		private void SetColumnsHeader()
		{
			dgvEmployees.Columns[nameof(Employee.Id)].HeaderText = "Id";
			dgvEmployees.Columns[nameof(Employee.FirsName)].HeaderText = "Imiê";
			dgvEmployees.Columns[nameof(Employee.LastName)].HeaderText = "Nazwisko";
			dgvEmployees.Columns[nameof(Employee.Salary)].HeaderText = "Wynagrodzenie";
			dgvEmployees.Columns[nameof(Employee.Comments)].HeaderText = "Uwagi";
			dgvEmployees.Columns[nameof(Employee.IsEmployed)].HeaderText = "Zatrudniony";
			dgvEmployees.Columns[nameof(Employee.DateOfEmployment)].HeaderText = "Data zatrudnienia";
			dgvEmployees.Columns[nameof(Employee.DateOfDismiss)].HeaderText = "Data zwolnienia";
		}

		private bool CheckRowSelection(string message)
		{
			if (dgvEmployees.SelectedRows.Count == 0)
			{
				MessageBox.Show(message);
				return false;
			}
			return true;
		}

		private void BtnAddClick(object sender, EventArgs e)
		{
			var addEditEmployee = new AddEditEmployee();
			addEditEmployee.ShowDialog();
			_selectedIndex = dgvEmployees.Rows.Count;
			RefreshEmployees();
		}

		private void BtnEditClick(object sender, EventArgs e)
		{
			if (!CheckRowSelection("Proszê zaznacz Pracownika, którego dane chcesz edytowaæ."))
				return;

			var selectedEmployee = (Employee)dgvEmployees.SelectedRows[0].DataBoundItem;
			var addEditEmployee = new AddEditEmployee(selectedEmployee);
			addEditEmployee.ShowDialog();
			RefreshEmployees();
		}

		private void BtnDismissClick(object sender, EventArgs e)
		{
			if (!CheckRowSelection("Proszê zaznacz pracownika, którego chcesz zwolniæ."))
				return;

			var selectedEmployee = (Employee)dgvEmployees.SelectedRows[0].DataBoundItem;
			var dismissEmployee = new DismissEmployee(selectedEmployee);
			dismissEmployee.ShowDialog();
			RefreshEmployees();
		}

		private void BtnRefreshClick(object sender, EventArgs e) => RefreshEmployees();

		private void CBGroup_SelectedIndexChanged(object sender, EventArgs e) => RefreshEmployees();

		private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			dgvEmployees.CellClick -= dgvEmployees_CellClick;
			_selectedIndex = dgvEmployees.SelectedCells[0].RowIndex;
			dgvEmployees.CellClick += dgvEmployees_CellClick;
		}

		private void Main_FormClosed(object sender, FormClosedEventArgs e)
		{
			Settings.Default.IsMaximize = WindowState == FormWindowState.Maximized;
			if (!(WindowState == FormWindowState.Maximized))
			{
				Settings.Default.MainWindowWidth = Width;
				Settings.Default.MainWindowHeight = Height;
			}
			Settings.Default.Save();
		}
	}
}