namespace HumanResources_net6.Forms
{
	partial class AddEditEmployee
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tbId = new System.Windows.Forms.TextBox();
			this.tbFirstName = new System.Windows.Forms.TextBox();
			this.lbId = new System.Windows.Forms.Label();
			this.lbSurname = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.tbLastName = new System.Windows.Forms.TextBox();
			this.lbDateOfEmployment = new System.Windows.Forms.Label();
			this.lbSalary = new System.Windows.Forms.Label();
			this.lbComments = new System.Windows.Forms.Label();
			this.rtbComments = new System.Windows.Forms.RichTextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.dtpDateOfEmployment = new System.Windows.Forms.DateTimePicker();
			this.numSalary = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numSalary)).BeginInit();
			this.SuspendLayout();
			// 
			// tbId
			// 
			this.tbId.Enabled = false;
			this.tbId.Location = new System.Drawing.Point(128, 16);
			this.tbId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tbId.Name = "tbId";
			this.tbId.ReadOnly = true;
			this.tbId.Size = new System.Drawing.Size(262, 23);
			this.tbId.TabIndex = 28;
			this.tbId.TabStop = false;
			// 
			// tbFirstName
			// 
			this.tbFirstName.Location = new System.Drawing.Point(128, 46);
			this.tbFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.Size = new System.Drawing.Size(262, 23);
			this.tbFirstName.TabIndex = 0;
			// 
			// lbId
			// 
			this.lbId.Location = new System.Drawing.Point(-4, 20);
			this.lbId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.lbId.Name = "lbId";
			this.lbId.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbId.Size = new System.Drawing.Size(122, 15);
			this.lbId.TabIndex = 29;
			this.lbId.Text = "Id:";
			this.lbId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbSurname
			// 
			this.lbSurname.Location = new System.Drawing.Point(-4, 80);
			this.lbSurname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.lbSurname.Name = "lbSurname";
			this.lbSurname.Size = new System.Drawing.Size(122, 15);
			this.lbSurname.TabIndex = 31;
			this.lbSurname.Text = "Nazwisko:";
			this.lbSurname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbName
			// 
			this.lbName.Location = new System.Drawing.Point(-4, 50);
			this.lbName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(122, 15);
			this.lbName.TabIndex = 30;
			this.lbName.Text = "Imie:";
			this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbLastName
			// 
			this.tbLastName.Location = new System.Drawing.Point(128, 76);
			this.tbLastName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tbLastName.Name = "tbLastName";
			this.tbLastName.Size = new System.Drawing.Size(262, 23);
			this.tbLastName.TabIndex = 1;
			// 
			// lbDateOfEmployment
			// 
			this.lbDateOfEmployment.Location = new System.Drawing.Point(-4, 140);
			this.lbDateOfEmployment.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.lbDateOfEmployment.Name = "lbDateOfEmployment";
			this.lbDateOfEmployment.Size = new System.Drawing.Size(122, 15);
			this.lbDateOfEmployment.TabIndex = 41;
			this.lbDateOfEmployment.Text = "Data zatrudnienia:";
			this.lbDateOfEmployment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbSalary
			// 
			this.lbSalary.Location = new System.Drawing.Point(-4, 108);
			this.lbSalary.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.lbSalary.Name = "lbSalary";
			this.lbSalary.Size = new System.Drawing.Size(122, 15);
			this.lbSalary.TabIndex = 43;
			this.lbSalary.Text = "Wynagrodzenie:";
			this.lbSalary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbComments
			// 
			this.lbComments.Location = new System.Drawing.Point(-4, 170);
			this.lbComments.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.lbComments.Name = "lbComments";
			this.lbComments.Size = new System.Drawing.Size(122, 15);
			this.lbComments.TabIndex = 45;
			this.lbComments.Text = "Uwagi:";
			this.lbComments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// rtbComments
			// 
			this.rtbComments.Location = new System.Drawing.Point(128, 166);
			this.rtbComments.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.rtbComments.Name = "rtbComments";
			this.rtbComments.Size = new System.Drawing.Size(262, 130);
			this.rtbComments.TabIndex = 4;
			this.rtbComments.Text = "";
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Tomato;
			this.btnCancel.Location = new System.Drawing.Point(274, 313);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(117, 46);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Anuluj";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// btnConfirm
			// 
			this.btnConfirm.BackColor = System.Drawing.Color.LimeGreen;
			this.btnConfirm.Location = new System.Drawing.Point(128, 313);
			this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(117, 46);
			this.btnConfirm.TabIndex = 5;
			this.btnConfirm.Text = "Zatwierdź";
			this.btnConfirm.UseVisualStyleBackColor = false;
			this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
			// 
			// dtpDateOfEmployment
			// 
			this.dtpDateOfEmployment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDateOfEmployment.Location = new System.Drawing.Point(128, 136);
			this.dtpDateOfEmployment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.dtpDateOfEmployment.Name = "dtpDateOfEmployment";
			this.dtpDateOfEmployment.Size = new System.Drawing.Size(262, 23);
			this.dtpDateOfEmployment.TabIndex = 3;
			// 
			// numSalary
			// 
			this.numSalary.DecimalPlaces = 2;
			this.numSalary.Location = new System.Drawing.Point(128, 106);
			this.numSalary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.numSalary.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.numSalary.Name = "numSalary";
			this.numSalary.Size = new System.Drawing.Size(262, 23);
			this.numSalary.TabIndex = 2;
			// 
			// AddEditEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(411, 377);
			this.Controls.Add(this.numSalary);
			this.Controls.Add(this.dtpDateOfEmployment);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnConfirm);
			this.Controls.Add(this.rtbComments);
			this.Controls.Add(this.lbDateOfEmployment);
			this.Controls.Add(this.lbSalary);
			this.Controls.Add(this.lbComments);
			this.Controls.Add(this.tbId);
			this.Controls.Add(this.tbFirstName);
			this.Controls.Add(this.lbId);
			this.Controls.Add(this.lbSurname);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.tbLastName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.Name = "AddEditEmployee";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Dodaj nowego pracownika";
			((System.ComponentModel.ISupportInitialize)(this.numSalary)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbId;
		private System.Windows.Forms.TextBox tbFirstName;
		private System.Windows.Forms.Label lbId;
		private System.Windows.Forms.Label lbSurname;
		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.TextBox tbLastName;
		private System.Windows.Forms.Label lbDateOfEmployment;
		private System.Windows.Forms.Label lbSalary;
		private System.Windows.Forms.Label lbComments;
		private System.Windows.Forms.RichTextBox rtbComments;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.DateTimePicker dtpDateOfEmployment;
		private System.Windows.Forms.NumericUpDown numSalary;
	}
}