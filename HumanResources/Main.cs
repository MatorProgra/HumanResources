using HumanResources.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HumanResources
{
	public partial class Main : Form
	{
		//private readonly FileSerializer<List<Employee>> _XmlFileSerializer = new FileSerializer<List<Employee>>(SerializeMode.XML, Environment.ExpandEnvironmentVariables(Settings.Default.PathToFileXml));
		//private readonly FileSerializer<List<Employee>> _JsonFileSerializer = new FileSerializer<List<Employee>>(SerializeMode.JSON, Environment.ExpandEnvironmentVariables(Settings.Default.PathToFileJson));

		//private List<State> _states;

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
			//CBState.DataSource = _states;
			//CBState.DisplayMember = "Name";
			//CBState.ValueMember = "Id";

			CBState.DataSource = new string[] { "Wszyscy", "Zatrudnieni", "Zwolnieni" };
			CBState.SelectedIndexChanged += CBGroup_SelectedIndexChanged;
		}

		private void RefreshEmployees()
		{
			_employees = Program.SerializeToFile.Deserialize();

			if (CBState.SelectedValue.ToString() == "Zatrudnieni")
				_employees = _employees.Where(x => x.IsEmployed).ToList();
			if (CBState.SelectedValue.ToString() == "Zwolnieni")
				_employees = _employees.Where(x => !x.IsEmployed).ToList();

			_employees.Sort();
			DGVEmployees.DataSource = _employees;

			if (_employees.Count() != 0 && _selectedIndex < _employees.Count())
				DGVEmployees.Rows[_selectedIndex].Selected = true;
		}

		private void SetColumnsHeader()
		{
			DGVEmployees.Columns[nameof(Employee.Id)].HeaderText = "Id";
			DGVEmployees.Columns[nameof(Employee.FirsName)].HeaderText = "Imię";
			DGVEmployees.Columns[nameof(Employee.LastName)].HeaderText = "Nazwisko";
			DGVEmployees.Columns[nameof(Employee.Salary)].HeaderText = "Wynagrodzenie";
			DGVEmployees.Columns[nameof(Employee.Comments)].HeaderText = "Uwagi";
			DGVEmployees.Columns[nameof(Employee.IsEmployed)].HeaderText = "Zatrudniony";
			DGVEmployees.Columns[nameof(Employee.DateOfEmployment)].HeaderText = "Data zatrudnienia";
			DGVEmployees.Columns[nameof(Employee.DateOfDismiss)].HeaderText = "Data zwolnienia";
		}

		private bool CheckRowSelection(string message)
		{
			if (DGVEmployees.SelectedRows.Count == 0)
			{
				MessageBox.Show(message);
				return false;
			}
			return true;
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			AddEditEmployee addEditEmployee = new AddEditEmployee();
			addEditEmployee.ShowDialog();
			_selectedIndex = DGVEmployees.Rows.Count;
			RefreshEmployees();
		}

		private void BtnEdit_Click(object sender, EventArgs e)
		{
			if (!CheckRowSelection("Proszę zaznacz Pracownika, którego dane chcesz edytować."))
				return;

			var selectedEmployee = (Employee)DGVEmployees.SelectedRows[0].DataBoundItem;
			AddEditEmployee addEditEmployee = new AddEditEmployee(selectedEmployee);
			addEditEmployee.ShowDialog();
			RefreshEmployees();
		}

		private void BtnDismiss_Click(object sender, EventArgs e)
		{
			if (!CheckRowSelection("Proszę zaznacz pracownika, którego chcesz zwolnić."))
				return;

			var selectedEmployee = (Employee)DGVEmployees.SelectedRows[0].DataBoundItem;
			DismissEmployee dismissEmployee = new DismissEmployee(selectedEmployee);
			dismissEmployee.ShowDialog();
			RefreshEmployees();
		}

		private void BtnRefresh_Click(object sender, EventArgs e) => RefreshEmployees();

		private void CBGroup_SelectedIndexChanged(object sender, EventArgs e) => RefreshEmployees();

		private void DGVEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DGVEmployees.CellClick -= DGVEmployees_CellClick;
			_selectedIndex = DGVEmployees.SelectedCells[0].RowIndex;
			DGVEmployees.CellClick += DGVEmployees_CellClick;
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
