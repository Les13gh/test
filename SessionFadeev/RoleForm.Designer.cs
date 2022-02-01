namespace SessionFadeev
{
    partial class RoleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.FNbox = new System.Windows.Forms.TextBox();
            this.LNbox = new System.Windows.Forms.TextBox();
            this.ofbox = new System.Windows.Forms.ComboBox();
            this.userbox = new System.Windows.Forms.RadioButton();
            this.Admbox = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(164, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(192, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(194, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(227, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Office ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(246, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Role";
            // 
            // emailbox
            // 
            this.emailbox.Location = new System.Drawing.Point(328, 77);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(167, 22);
            this.emailbox.TabIndex = 5;
            // 
            // FNbox
            // 
            this.FNbox.Location = new System.Drawing.Point(328, 141);
            this.FNbox.Name = "FNbox";
            this.FNbox.Size = new System.Drawing.Size(167, 22);
            this.FNbox.TabIndex = 6;
            // 
            // LNbox
            // 
            this.LNbox.Location = new System.Drawing.Point(328, 215);
            this.LNbox.Name = "LNbox";
            this.LNbox.Size = new System.Drawing.Size(167, 22);
            this.LNbox.TabIndex = 7;
            // 
            // ofbox
            // 
            this.ofbox.FormattingEnabled = true;
            this.ofbox.Location = new System.Drawing.Point(328, 283);
            this.ofbox.Name = "ofbox";
            this.ofbox.Size = new System.Drawing.Size(167, 24);
            this.ofbox.TabIndex = 8;
            // 
            // userbox
            // 
            this.userbox.AutoSize = true;
            this.userbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userbox.Location = new System.Drawing.Point(328, 359);
            this.userbox.Name = "userbox";
            this.userbox.Size = new System.Drawing.Size(62, 23);
            this.userbox.TabIndex = 9;
            this.userbox.TabStop = true;
            this.userbox.Text = "User";
            this.userbox.UseVisualStyleBackColor = true;
            this.userbox.CheckedChanged += new System.EventHandler(this.userbox_CheckedChanged);
            // 
            // Admbox
            // 
            this.Admbox.AutoSize = true;
            this.Admbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.Admbox.Location = new System.Drawing.Point(328, 402);
            this.Admbox.Name = "Admbox";
            this.Admbox.Size = new System.Drawing.Size(77, 23);
            this.Admbox.TabIndex = 10;
            this.Admbox.TabStop = true;
            this.Admbox.Text = "Admin";
            this.Admbox.UseVisualStyleBackColor = true;
            this.Admbox.CheckedChanged += new System.EventHandler(this.Admbox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 44);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Admbox);
            this.Controls.Add(this.userbox);
            this.Controls.Add(this.ofbox);
            this.Controls.Add(this.LNbox);
            this.Controls.Add(this.FNbox);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RoleForm";
            this.Text = "RoleForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RoleForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.TextBox FNbox;
        private System.Windows.Forms.TextBox LNbox;
        private System.Windows.Forms.ComboBox ofbox;
        private System.Windows.Forms.RadioButton userbox;
        private System.Windows.Forms.RadioButton Admbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}