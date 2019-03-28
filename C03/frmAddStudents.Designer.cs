namespace C03
{
    partial class frmAddStudents
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblMidterm = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtMidterm = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(29, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Student Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(29, 126);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(78, 17);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Student ID:";
            // 
            // lblMidterm
            // 
            this.lblMidterm.AutoSize = true;
            this.lblMidterm.Location = new System.Drawing.Point(282, 126);
            this.lblMidterm.Name = "lblMidterm";
            this.lblMidterm.Size = new System.Drawing.Size(62, 17);
            this.lblMidterm.TabIndex = 2;
            this.lblMidterm.Text = "Midterm:";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(406, 126);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(42, 17);
            this.lblFinal.TabIndex = 3;
            this.lblFinal.Text = "Final:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(32, 55);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(444, 22);
            this.txtStudentName.TabIndex = 1;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(32, 146);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 22);
            this.txtStudentID.TabIndex = 2;
            // 
            // txtMidterm
            // 
            this.txtMidterm.Location = new System.Drawing.Point(285, 146);
            this.txtMidterm.Name = "txtMidterm";
            this.txtMidterm.Size = new System.Drawing.Size(59, 22);
            this.txtMidterm.TabIndex = 3;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(409, 146);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(67, 22);
            this.txtFinal.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.AutoSize = true;
            this.btnOk.Location = new System.Drawing.Point(269, 198);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 27);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(401, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddStudents
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(510, 257);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtMidterm);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblMidterm);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Name = "frmAddStudents";
            this.Text = "Enter Student Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMidterm;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtMidterm;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}