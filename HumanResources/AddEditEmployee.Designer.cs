
namespace HumanResources
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
			this.TBId = new System.Windows.Forms.TextBox();
			this.TBFirstName = new System.Windows.Forms.TextBox();
			this.LbId = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.TBLastName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.RTBComments = new System.Windows.Forms.RichTextBox();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.BtnConfirm = new System.Windows.Forms.Button();
			this.DTPDateOfEmployment = new System.Windows.Forms.DateTimePicker();
			this.NumSalary = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.NumSalary)).BeginInit();
			this.SuspendLayout();
			// 
			// TBId
			// 
			this.TBId.Enabled = false;
			this.TBId.Location = new System.Drawing.Point(110, 14);
			this.TBId.Name = "TBId";
			this.TBId.ReadOnly = true;
			this.TBId.Size = new System.Drawing.Size(225, 20);
			this.TBId.TabIndex = 28;
			this.TBId.TabStop = false;
			// 
			// TBFirstName
			// 
			this.TBFirstName.Location = new System.Drawing.Point(110, 40);
			this.TBFirstName.Name = "TBFirstName";
			this.TBFirstName.Size = new System.Drawing.Size(225, 20);
			this.TBFirstName.TabIndex = 0;
			// 
			// LbId
			// 
			this.LbId.Location = new System.Drawing.Point(-3, 17);
			this.LbId.Margin = new System.Windows.Forms.Padding(5);
			this.LbId.Name = "LbId";
			this.LbId.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.LbId.Size = new System.Drawing.Size(105, 13);
			this.LbId.TabIndex = 29;
			this.LbId.Text = "Id:";
			this.LbId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(-3, 69);
			this.label3.Margin = new System.Windows.Forms.Padding(5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 13);
			this.label3.TabIndex = 31;
			this.label3.Text = "Nazwisko:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(-3, 43);
			this.label1.Margin = new System.Windows.Forms.Padding(5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 13);
			this.label1.TabIndex = 30;
			this.label1.Text = "Imie:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TBLastName
			// 
			this.TBLastName.Location = new System.Drawing.Point(110, 66);
			this.TBLastName.Name = "TBLastName";
			this.TBLastName.Size = new System.Drawing.Size(225, 20);
			this.TBLastName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(-3, 121);
			this.label2.Margin = new System.Windows.Forms.Padding(5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 13);
			this.label2.TabIndex = 41;
			this.label2.Text = "Data zatrudnienia:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(-3, 94);
			this.label6.Margin = new System.Windows.Forms.Padding(5);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(105, 13);
			this.label6.TabIndex = 43;
			this.label6.Text = "Wynagrodzenie:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(-3, 147);
			this.label4.Margin = new System.Windows.Forms.Padding(5);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 13);
			this.label4.TabIndex = 45;
			this.label4.Text = "Uwagi:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// RTBComments
			// 
			this.RTBComments.Location = new System.Drawing.Point(110, 144);
			this.RTBComments.Name = "RTBComments";
			this.RTBComments.Size = new System.Drawing.Size(225, 113);
			this.RTBComments.TabIndex = 4;
			this.RTBComments.Text = "";
			// 
			// BtnCancel
			// 
			this.BtnCancel.BackColor = System.Drawing.Color.Tomato;
			this.BtnCancel.Location = new System.Drawing.Point(235, 271);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(100, 40);
			this.BtnCancel.TabIndex = 6;
			this.BtnCancel.Text = "Anuluj";
			this.BtnCancel.UseVisualStyleBackColor = false;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// BtnConfirm
			// 
			this.BtnConfirm.BackColor = System.Drawing.Color.LimeGreen;
			this.BtnConfirm.Location = new System.Drawing.Point(110, 271);
			this.BtnConfirm.Name = "BtnConfirm";
			this.BtnConfirm.Size = new System.Drawing.Size(100, 40);
			this.BtnConfirm.TabIndex = 5;
			this.BtnConfirm.Text = "Zatwierdź";
			this.BtnConfirm.UseVisualStyleBackColor = false;
			this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
			// 
			// DTPDateOfEmployment
			// 
			this.DTPDateOfEmployment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DTPDateOfEmployment.Location = new System.Drawing.Point(110, 118);
			this.DTPDateOfEmployment.Name = "DTPDateOfEmployment";
			this.DTPDateOfEmployment.Size = new System.Drawing.Size(225, 20);
			this.DTPDateOfEmployment.TabIndex = 3;
			// 
			// NumSalary
			// 
			this.NumSalary.DecimalPlaces = 2;
			this.NumSalary.Location = new System.Drawing.Point(110, 92);
			this.NumSalary.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.NumSalary.Name = "NumSalary";
			this.NumSalary.Size = new System.Drawing.Size(225, 20);
			this.NumSalary.TabIndex = 2;
			// 
			// AddEditEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(352, 327);
			this.Controls.Add(this.NumSalary);
			this.Controls.Add(this.DTPDateOfEmployment);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.BtnConfirm);
			this.Controls.Add(this.RTBComments);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.TBId);
			this.Controls.Add(this.TBFirstName);
			this.Controls.Add(this.LbId);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TBLastName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "AddEditEmployee";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Dodaj nowego pracownika";
			((System.ComponentModel.ISupportInitialize)(this.NumSalary)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TBId;
		private System.Windows.Forms.TextBox TBFirstName;
		private System.Windows.Forms.Label LbId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TBLastName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox RTBComments;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.Button BtnConfirm;
		private System.Windows.Forms.DateTimePicker DTPDateOfEmployment;
		private System.Windows.Forms.NumericUpDown NumSalary;
	}
}