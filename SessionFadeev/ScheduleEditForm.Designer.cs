namespace SessionFadeev
{
    partial class ScheduleEditForm
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
            this.Update = new System.Windows.Forms.Button();
            this.cancelbutt = new System.Windows.Forms.Button();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.Airlabel = new System.Windows.Forms.Label();
            this.datebox = new System.Windows.Forms.TextBox();
            this.Timebox = new System.Windows.Forms.TextBox();
            this.Pricebox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Economy Price: $";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(186, 297);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(89, 34);
            this.Update.TabIndex = 3;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // cancelbutt
            // 
            this.cancelbutt.Location = new System.Drawing.Point(445, 297);
            this.cancelbutt.Name = "cancelbutt";
            this.cancelbutt.Size = new System.Drawing.Size(85, 34);
            this.cancelbutt.TabIndex = 4;
            this.cancelbutt.Text = "Cancel";
            this.cancelbutt.UseVisualStyleBackColor = true;
            this.cancelbutt.Click += new System.EventHandler(this.cancelbutt_Click);
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(69, 49);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(40, 17);
            this.FromLabel.TabIndex = 5;
            this.FromLabel.Text = "From";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(283, 49);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(25, 17);
            this.ToLabel.TabIndex = 6;
            this.ToLabel.Text = "To";
            // 
            // Airlabel
            // 
            this.Airlabel.AutoSize = true;
            this.Airlabel.Location = new System.Drawing.Point(495, 49);
            this.Airlabel.Name = "Airlabel";
            this.Airlabel.Size = new System.Drawing.Size(53, 17);
            this.Airlabel.TabIndex = 7;
            this.Airlabel.Text = "Aircraft";
            // 
            // datebox
            // 
            this.datebox.Location = new System.Drawing.Point(100, 180);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(149, 22);
            this.datebox.TabIndex = 8;
            // 
            // Timebox
            // 
            this.Timebox.Location = new System.Drawing.Point(386, 181);
            this.Timebox.Name = "Timebox";
            this.Timebox.Size = new System.Drawing.Size(100, 22);
            this.Timebox.TabIndex = 9;
            // 
            // Pricebox
            // 
            this.Pricebox.Location = new System.Drawing.Point(675, 180);
            this.Pricebox.Name = "Pricebox";
            this.Pricebox.Size = new System.Drawing.Size(76, 22);
            this.Pricebox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FromLabel);
            this.groupBox1.Controls.Add(this.ToLabel);
            this.groupBox1.Controls.Add(this.Airlabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 122);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flight route";
            // 
            // ScheduleEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 376);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Pricebox);
            this.Controls.Add(this.Timebox);
            this.Controls.Add(this.datebox);
            this.Controls.Add(this.cancelbutt);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ScheduleEditForm";
            this.Text = "ScheduleEditForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button cancelbutt;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label Airlabel;
        private System.Windows.Forms.TextBox datebox;
        private System.Windows.Forms.TextBox Timebox;
        private System.Windows.Forms.TextBox Pricebox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}