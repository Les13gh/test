namespace SessionFadeev
{
    partial class AutorizationForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorizationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.loginbutt = new System.Windows.Forms.Button();
            this.exitbutt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(115, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(119, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // emailbox
            // 
            this.emailbox.Location = new System.Drawing.Point(227, 255);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(333, 22);
            this.emailbox.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(227, 333);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(333, 22);
            this.pass.TabIndex = 3;
            // 
            // loginbutt
            // 
            this.loginbutt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.loginbutt.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.loginbutt.Location = new System.Drawing.Point(149, 426);
            this.loginbutt.Name = "loginbutt";
            this.loginbutt.Size = new System.Drawing.Size(110, 45);
            this.loginbutt.TabIndex = 4;
            this.loginbutt.Text = "Login";
            this.loginbutt.UseVisualStyleBackColor = false;
            this.loginbutt.Click += new System.EventHandler(this.loginbutt_Click);
            // 
            // exitbutt
            // 
            this.exitbutt.BackColor = System.Drawing.Color.Red;
            this.exitbutt.ForeColor = System.Drawing.Color.White;
            this.exitbutt.Location = new System.Drawing.Point(493, 426);
            this.exitbutt.Name = "exitbutt";
            this.exitbutt.Size = new System.Drawing.Size(111, 45);
            this.exitbutt.TabIndex = 5;
            this.exitbutt.Text = "Exit";
            this.exitbutt.UseVisualStyleBackColor = false;
            this.exitbutt.Click += new System.EventHandler(this.exitbutt_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(795, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 568);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitbutt);
            this.Controls.Add(this.loginbutt);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AutorizationForm";
            this.Text = "AutorizationForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button loginbutt;
        private System.Windows.Forms.Button exitbutt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}