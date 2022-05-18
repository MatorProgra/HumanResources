namespace HumanResources_net6.Forms
{
	partial class DismissEmployee
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
			this.dtpDateOfDismiss = new System.Windows.Forms.DateTimePicker();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.lbDateOfDismiss = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tbId
			// 
			this.tbId.Enabled = false;
			this.tbId.Location = new System.Drawing.Point(134, 14);
			this.tbId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tbId.Name = "tbId";
			this.tbId.ReadOnly = true;
			this.tbId.Size = new System.Drawing.Size(262, 23);
			this.tbId.TabIndex = 34;
			this.tbId.TabStop = false;
			// 
			// tbFirstName
			// 
			this.tbFirstName.Enabled = false;
			this.tbFirstName.Location = new System.Drawing.Point(134, 44);
			this.tbFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.ReadOnly = true;
			this.tbFirstName.Size = new System.Drawing.Size(262, 23);
			this.tbFirstName.TabIndex = 32;
			this.tbFirstName.TabStop = false;
			// 
			// lbId
			// 
			this.lbId.Location = new System.Drawing.Point(2, 17);
			this.lbId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.lbId.Name = "lbId";
			this.lbId.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbId.Size = new System.Drawing.Size(122, 15);
			this.lbId.TabIndex = 35;
			this.lbId.Text = "Id:";
			this.lbId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbSurname
			// 
			this.lbSurname.Location = new System.Drawing.Point(2, 77);
			this.lbSurname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.lbSurname.Name = "lbSurname";
			this.lbSurname.Size = new System.Drawing.Size(122, 15);
			this.lbSurname.TabIndex = 37;
			this.lbSurname.Text = "Nazwisko:";
			this.lbSurname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbName
			// 
			this.lbName.Location = new System.Drawing.Point(2, 47);
			this.lbName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(122, 15);
			this.lbName.TabIndex = 36;
			this.lbName.Text = "Imie:";
			this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbLastName
			// 
			this.tbLastName.Enabled = false;
			this.tbLastName.Location = new System.Drawing.Point(134, 74);
			this.tbLastName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tbLastName.Name = "tbLastName";
			this.tbLastName.ReadOnly = true;
			this.tbLastName.Size = new System.Drawing.Size(262, 23);
			this.tbLastName.TabIndex = 33;
			this.tbLastName.TabStop = false;
			// 
			// dtpDateOfDismiss
			// 
			this.dtpDateOfDismiss.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDateOfDismiss.Location = new System.Drawing.Point(134, 104);
			this.dtpDateOfDismiss.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.dtpDateOfDismiss.Name = "dtpDateOfDismiss";
			this.dtpDateOfDismiss.Size = new System.Drawing.Size(262, 23);
			this.dtpDateOfDismiss.TabIndex = 0;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Tomato;
			this.btnCancel.Location = new System.Drawing.Point(280, 147);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(117, 46);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Anuluj";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// btnConfirm
			// 
			this.btnConfirm.BackColor = System.Drawing.Color.LimeGreen;
			this.btnConfirm.Location = new System.Drawing.Point(134, 147);
			this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(117, 46);
			this.btnConfirm.TabIndex = 1;
			this.btnConfirm.Text = "Zatwierdź";
			this.btnConfirm.UseVisualStyleBackColor = false;
			this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
			// 
			// lbDateOfDismiss
			// 
			this.lbDateOfDismiss.Location = new System.Drawing.Point(2, 107);
			this.lbDateOfDismiss.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.lbDateOfDismiss.Name = "lbDateOfDismiss";
			this.lbDateOfDismiss.Size = new System.Drawing.Size(122, 15);
			this.lbDateOfDismiss.TabIndex = 50;
			this.lbDateOfDismiss.Text = "Data zwolnienia:";
			this.lbDateOfDismiss.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// DismissEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(442, 215);
			this.Controls.Add(this.dtpDateOfDismiss);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnConfirm);
			this.Controls.Add(this.lbDateOfDismiss);
			this.Controls.Add(this.tbId);
			this.Controls.Add(this.tbFirstName);
			this.Controls.Add(this.lbId);
			this.Controls.Add(this.lbSurname);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.tbLastName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.Name = "DismissEmployee";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Zwolnij pracownika";
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
		private System.Windows.Forms.DateTimePicker dtpDateOfDismiss;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.Label lbDateOfDismiss;
	}
}