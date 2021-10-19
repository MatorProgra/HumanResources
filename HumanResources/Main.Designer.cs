
namespace HumanResources
{
	partial class Main
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.BtnAdd = new System.Windows.Forms.Button();
			this.BtnEdit = new System.Windows.Forms.Button();
			this.BtnDismiss = new System.Windows.Forms.Button();
			this.BtnRefresh = new System.Windows.Forms.Button();
			this.CBState = new System.Windows.Forms.ComboBox();
			this.DGVEmployees = new System.Windows.Forms.DataGridView();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGVEmployees)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.flowLayoutPanel1.Controls.Add(this.BtnAdd);
			this.flowLayoutPanel1.Controls.Add(this.BtnEdit);
			this.flowLayoutPanel1.Controls.Add(this.BtnDismiss);
			this.flowLayoutPanel1.Controls.Add(this.BtnRefresh);
			this.flowLayoutPanel1.Controls.Add(this.CBState);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 65);
			this.flowLayoutPanel1.TabIndex = 3;
			// 
			// BtnAdd
			// 
			this.BtnAdd.BackColor = System.Drawing.Color.LimeGreen;
			this.BtnAdd.Location = new System.Drawing.Point(8, 13);
			this.BtnAdd.Name = "BtnAdd";
			this.BtnAdd.Size = new System.Drawing.Size(75, 40);
			this.BtnAdd.TabIndex = 0;
			this.BtnAdd.Text = "Dodaj";
			this.BtnAdd.UseVisualStyleBackColor = false;
			this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// BtnEdit
			// 
			this.BtnEdit.BackColor = System.Drawing.Color.Goldenrod;
			this.BtnEdit.Location = new System.Drawing.Point(89, 13);
			this.BtnEdit.Name = "BtnEdit";
			this.BtnEdit.Size = new System.Drawing.Size(75, 40);
			this.BtnEdit.TabIndex = 1;
			this.BtnEdit.Text = "Edytuj";
			this.BtnEdit.UseVisualStyleBackColor = false;
			this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
			// 
			// BtnDismiss
			// 
			this.BtnDismiss.BackColor = System.Drawing.Color.Tomato;
			this.BtnDismiss.Location = new System.Drawing.Point(170, 13);
			this.BtnDismiss.Name = "BtnDismiss";
			this.BtnDismiss.Size = new System.Drawing.Size(75, 40);
			this.BtnDismiss.TabIndex = 2;
			this.BtnDismiss.Text = "Zwolnij";
			this.BtnDismiss.UseVisualStyleBackColor = false;
			this.BtnDismiss.Click += new System.EventHandler(this.BtnDismiss_Click);
			// 
			// BtnRefresh
			// 
			this.BtnRefresh.BackColor = System.Drawing.Color.CornflowerBlue;
			this.BtnRefresh.Location = new System.Drawing.Point(251, 13);
			this.BtnRefresh.Name = "BtnRefresh";
			this.BtnRefresh.Size = new System.Drawing.Size(75, 40);
			this.BtnRefresh.TabIndex = 3;
			this.BtnRefresh.Text = "Odśwież";
			this.BtnRefresh.UseVisualStyleBackColor = false;
			this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
			// 
			// CBState
			// 
			this.CBState.FormattingEnabled = true;
			this.CBState.Location = new System.Drawing.Point(338, 22);
			this.CBState.Margin = new System.Windows.Forms.Padding(9, 12, 3, 3);
			this.CBState.Name = "CBState";
			this.CBState.Size = new System.Drawing.Size(121, 21);
			this.CBState.TabIndex = 4;
			// 
			// DGVEmployees
			// 
			this.DGVEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DGVEmployees.BackgroundColor = System.Drawing.Color.White;
			this.DGVEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DGVEmployees.Location = new System.Drawing.Point(0, 65);
			this.DGVEmployees.MultiSelect = false;
			this.DGVEmployees.Name = "DGVEmployees";
			this.DGVEmployees.ReadOnly = true;
			this.DGVEmployees.RowHeadersVisible = false;
			this.DGVEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGVEmployees.Size = new System.Drawing.Size(800, 385);
			this.DGVEmployees.TabIndex = 4;
			this.DGVEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVEmployees_CellClick);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.DGVEmployees);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Program kadrowy";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DGVEmployees)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button BtnAdd;
		private System.Windows.Forms.Button BtnEdit;
		private System.Windows.Forms.Button BtnDismiss;
		private System.Windows.Forms.Button BtnRefresh;
		private System.Windows.Forms.ComboBox CBState;
		private System.Windows.Forms.DataGridView DGVEmployees;
	}
}

