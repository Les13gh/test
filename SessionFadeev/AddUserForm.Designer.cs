namespace SessionFadeev
{
    partial class AddUserForm
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
            this.Email = new System.Windows.Forms.TextBox();
            this.FirstNam = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Office = new System.Windows.Forms.ComboBox();
            this.pass = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Savebutt = new System.Windows.Forms.Button();
            this.Cancelbutt = new System.Windows.Forms.Button();
            this.BD = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(292, 105);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(200, 22);
            this.Email.TabIndex = 0;
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // FirstNam
            // 
            this.FirstNam.Location = new System.Drawing.Point(292, 172);
            this.FirstNam.Name = "FirstNam";
            this.FirstNam.Size = new System.Drawing.Size(200, 22);
            this.FirstNam.TabIndex = 1;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(292, 247);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(200, 22);
            this.LastName.TabIndex = 2;
            // 
            // Office
            // 
            this.Office.FormattingEnabled = true;
            this.Office.Location = new System.Drawing.Point(292, 312);
            this.Office.Name = "Office";
            this.Office.Size = new System.Drawing.Size(200, 24);
            this.Office.TabIndex = 3;
            this.Office.SelectedIndexChanged += new System.EventHandler(this.Office_SelectedIndexChanged);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(292, 430);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(200, 22);
            this.pass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(203, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "E-mail ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(170, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(203, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Office";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(180, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "BirthDay";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(175, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(172, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Last Name";
            // 
            // Savebutt
            // 
            this.Savebutt.Location = new System.Drawing.Point(176, 510);
            this.Savebutt.Name = "Savebutt";
            this.Savebutt.Size = new System.Drawing.Size(117, 55);
            this.Savebutt.TabIndex = 13;
            this.Savebutt.Text = "Save";
            this.Savebutt.UseVisualStyleBackColor = true;
            this.Savebutt.Click += new System.EventHandler(this.Savebutt_Click);
            // 
            // Cancelbutt
            // 
            this.Cancelbutt.Location = new System.Drawing.Point(441, 510);
            this.Cancelbutt.Name = "Cancelbutt";
            this.Cancelbutt.Size = new System.Drawing.Size(116, 55);
            this.Cancelbutt.TabIndex = 14;
            this.Cancelbutt.Text = "Cancel";
            this.Cancelbutt.UseVisualStyleBackColor = true;
            this.Cancelbutt.Click += new System.EventHandler(this.Cancelbutt_Click);
            // 
            // BD
            // 
            this.BD.Location = new System.Drawing.Point(292, 376);
            this.BD.Mask = "00/00/0000";
            this.BD.Name = "BD";
            this.BD.Size = new System.Drawing.Size(200, 22);
            this.BD.TabIndex = 16;
            this.BD.ValidatingType = typeof(System.DateTime);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 677);
            this.Controls.Add(this.BD);
            this.Controls.Add(this.Cancelbutt);
            this.Controls.Add(this.Savebutt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.Office);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstNam);
            this.Controls.Add(this.Email);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox FirstNam;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.ComboBox Office;
        private System.Windows.Forms.MaskedTextBox pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Savebutt;
        private System.Windows.Forms.Button Cancelbutt;
        private System.Windows.Forms.MaskedTextBox BD;
    }
}