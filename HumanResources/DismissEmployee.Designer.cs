
namespace HumanResources
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
			this.TBId = new System.Windows.Forms.TextBox();
			this.TBFirstName = new System.Windows.Forms.TextBox();
			this.LbId = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.TBLastName = new System.Windows.Forms.TextBox();
			this.DTPDateOfDismiss = new System.Windows.Forms.DateTimePicker();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.BtnConfirm = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TBId
			// 
			this.TBId.Enabled = false;
			this.TBId.Location = new System.Drawing.Point(115, 12);
			this.TBId.Name = "TBId";
			this.TBId.ReadOnly = true;
			this.TBId.Size = new System.Drawing.Size(225, 20);
			this.TBId.TabIndex = 34;
			this.TBId.TabStop = false;
			// 
			// TBFirstName
			// 
			this.TBFirstName.Enabled = false;
			this.TBFirstName.Location = new System.Drawing.Point(115, 38);
			this.TBFirstName.Name = "TBFirstName";
			this.TBFirstName.ReadOnly = true;
			this.TBFirstName.Size = new System.Drawing.Size(225, 20);
			this.TBFirstName.TabIndex = 32;
			this.TBFirstName.TabStop = false;
			// 
			// LbId
			// 
			this.LbId.Location = new System.Drawing.Point(2, 15);
			this.LbId.Margin = new System.Windows.Forms.Padding(5);
			this.LbId.Name = "LbId";
			this.LbId.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.LbId.Size = new System.Drawing.Size(105, 13);
			this.LbId.TabIndex = 35;
			this.LbId.Text = "Id:";
			this.LbId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(2, 67);
			this.label3.Margin = new System.Windows.Forms.Padding(5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 13);
			this.label3.TabIndex = 37;
			this.label3.Text = "Nazwisko:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(2, 41);
			this.label1.Margin = new System.Windows.Forms.Padding(5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 13);
			this.label1.TabIndex = 36;
			this.label1.Text = "Imie:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TBLastName
			// 
			this.TBLastName.Enabled = false;
			this.TBLastName.Location = new System.Drawing.Point(115, 64);
			this.TBLastName.Name = "TBLastName";
			this.TBLastName.ReadOnly = true;
			this.TBLastName.Size = new System.Drawing.Size(225, 20);
			this.TBLastName.TabIndex = 33;
			this.TBLastName.TabStop = false;
			// 
			// DTPDateOfDismiss
			// 
			this.DTPDateOfDismiss.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DTPDateOfDismiss.Location = new System.Drawing.Point(115, 90);
			this.DTPDateOfDismiss.Name = "DTPDateOfDismiss";
			this.DTPDateOfDismiss.Size = new System.Drawing.Size(225, 20);
			this.DTPDateOfDismiss.TabIndex = 0;
			// 
			// BtnCancel
			// 
			this.BtnCancel.BackColor = System.Drawing.Color.Tomato;
			this.BtnCancel.Location = new System.Drawing.Point(240, 127);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(100, 40);
			this.BtnCancel.TabIndex = 2;
			this.BtnCancel.Text = "Anuluj";
			this.BtnCancel.UseVisualStyleBackColor = false;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// BtnConfirm
			// 
			this.BtnConfirm.BackColor = System.Drawing.Color.LimeGreen;
			this.BtnConfirm.Location = new System.Drawing.Point(115, 127);
			this.BtnConfirm.Name = "BtnConfirm";
			this.BtnConfirm.Size = new System.Drawing.Size(100, 40);
			this.BtnConfirm.TabIndex = 1;
			this.BtnConfirm.Text = "Zatwierdź";
			this.BtnConfirm.UseVisualStyleBackColor = false;
			this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(2, 93);
			this.label2.Margin = new System.Windows.Forms.Padding(5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 13);
			this.label2.TabIndex = 50;
			this.label2.Text = "Data zwolnienia:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// DIsmissEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 186);
			this.Controls.Add(this.DTPDateOfDismiss);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.BtnConfirm);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TBId);
			this.Controls.Add(this.TBFirstName);
			this.Controls.Add(this.LbId);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TBLastName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "DIsmissEmployee";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Zwolnij pracownika";
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
		private System.Windows.Forms.DateTimePicker DTPDateOfDismiss;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.Button BtnConfirm;
		private System.Windows.Forms.Label label2;
	}
}