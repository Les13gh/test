namespace SessionFadeev
{
    partial class ApplyScheduleForm
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
            this.importbutton = new System.Windows.Forms.Button();
            this.importbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select the text file the changes";
            // 
            // importbutton
            // 
            this.importbutton.Location = new System.Drawing.Point(494, 120);
            this.importbutton.Name = "importbutton";
            this.importbutton.Size = new System.Drawing.Size(105, 34);
            this.importbutton.TabIndex = 1;
            this.importbutton.Text = "Import";
            this.importbutton.UseVisualStyleBackColor = true;
            this.importbutton.Click += new System.EventHandler(this.importbutton_Click);
            // 
            // importbox
            // 
            this.importbox.Location = new System.Drawing.Point(119, 126);
            this.importbox.Name = "importbox";
            this.importbox.Size = new System.Drawing.Size(341, 22);
            this.importbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Successful Changes Applied";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Duplicate Records Discarded:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Record with missing flieds discarded:";
            // 
            // ApplyScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.importbox);
            this.Controls.Add(this.importbutton);
            this.Controls.Add(this.label1);
            this.Name = "ApplyScheduleForm";
            this.Text = "ApplyScheduleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button importbutton;
        private System.Windows.Forms.TextBox importbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}