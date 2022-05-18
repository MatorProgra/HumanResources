namespace HumanResources_net6.Forms
{
	partial class Main
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDismiss = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.cbState = new System.Windows.Forms.ComboBox();
			this.dgvEmployees = new System.Windows.Forms.DataGridView();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.flowLayoutPanel1.Controls.Add(this.btnAdd);
			this.flowLayoutPanel1.Controls.Add(this.btnEdit);
			this.flowLayoutPanel1.Controls.Add(this.btnDismiss);
			this.flowLayoutPanel1.Controls.Add(this.btnRefresh);
			this.flowLayoutPanel1.Controls.Add(this.cbState);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 65);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
			this.btnAdd.Location = new System.Drawing.Point(8, 13);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 40);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Dodaj";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.Goldenrod;
			this.btnEdit.Location = new System.Drawing.Point(89, 13);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 40);
			this.btnEdit.TabIndex = 1;
			this.btnEdit.Text = "Edytuj";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.BtnEditClick);
			// 
			// btnDismiss
			// 
			this.btnDismiss.BackColor = System.Drawing.Color.Tomato;
			this.btnDismiss.Location = new System.Drawing.Point(170, 13);
			this.btnDismiss.Name = "btnDismiss";
			this.btnDismiss.Size = new System.Drawing.Size(75, 40);
			this.btnDismiss.TabIndex = 2;
			this.btnDismiss.Text = "Zwolnij";
			this.btnDismiss.UseVisualStyleBackColor = false;
			this.btnDismiss.Click += new System.EventHandler(this.BtnDismissClick);
			// 
			// btnRefresh
			// 
			this.btnRefresh.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnRefresh.Location = new System.Drawing.Point(251, 13);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(75, 40);
			this.btnRefresh.TabIndex = 3;
			this.btnRefresh.Text = "Odśwież";
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.BtnRefreshClick);
			// 
			// cbState
			// 
			this.cbState.FormattingEnabled = true;
			this.cbState.Location = new System.Drawing.Point(338, 22);
			this.cbState.Margin = new System.Windows.Forms.Padding(9, 12, 3, 3);
			this.cbState.Name = "cbState";
			this.cbState.Size = new System.Drawing.Size(121, 23);
			this.cbState.TabIndex = 4;
			// 
			// dgvEmployees
			// 
			this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
			this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvEmployees.Location = new System.Drawing.Point(0, 65);
			this.dgvEmployees.MultiSelect = false;
			this.dgvEmployees.Name = "dgvEmployees";
			this.dgvEmployees.ReadOnly = true;
			this.dgvEmployees.RowTemplate.Height = 25;
			this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvEmployees.Size = new System.Drawing.Size(800, 385);
			this.dgvEmployees.TabIndex = 1;
			this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellClick);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvEmployees);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "Main";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private FlowLayoutPanel flowLayoutPanel1;
		private DataGridView dgvEmployees;
		private Button btnAdd;
		private Button btnEdit;
		private Button btnDismiss;
		private Button btnRefresh;
		private ComboBox cbState;
	}
}