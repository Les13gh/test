namespace SessionFadeev
{
    partial class ManageFlightSchedulesForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CancelFbutt = new System.Windows.Forms.Button();
            this.EditFbutt = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Applybutt = new System.Windows.Forms.Button();
            this.Frombox = new System.Windows.Forms.ComboBox();
            this.FNum = new System.Windows.Forms.TextBox();
            this.Tobox = new System.Windows.Forms.ComboBox();
            this.Sortby = new System.Windows.Forms.ComboBox();
            this.datebox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 204);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(884, 294);
            this.dataGridView1.TabIndex = 0;
            // 
            // CancelFbutt
            // 
            this.CancelFbutt.Location = new System.Drawing.Point(69, 504);
            this.CancelFbutt.Name = "CancelFbutt";
            this.CancelFbutt.Size = new System.Drawing.Size(108, 42);
            this.CancelFbutt.TabIndex = 1;
            this.CancelFbutt.Text = "Cancel Flight";
            this.CancelFbutt.UseVisualStyleBackColor = true;
            this.CancelFbutt.Click += new System.EventHandler(this.CancelFbutt_Click);
            // 
            // EditFbutt
            // 
            this.EditFbutt.Location = new System.Drawing.Point(299, 504);
            this.EditFbutt.Name = "EditFbutt";
            this.EditFbutt.Size = new System.Drawing.Size(110, 42);
            this.EditFbutt.TabIndex = 2;
            this.EditFbutt.Text = "Edit Flight";
            this.EditFbutt.UseVisualStyleBackColor = true;
            this.EditFbutt.Click += new System.EventHandler(this.EditFbutt_Click);
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(697, 504);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(122, 42);
            this.Import.TabIndex = 3;
            this.Import.Text = "Import Changes";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Outbound";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Flight number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(639, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sort by";
            // 
            // Applybutt
            // 
            this.Applybutt.Location = new System.Drawing.Point(714, 129);
            this.Applybutt.Name = "Applybutt";
            this.Applybutt.Size = new System.Drawing.Size(105, 38);
            this.Applybutt.TabIndex = 9;
            this.Applybutt.Text = "Apply";
            this.Applybutt.UseVisualStyleBackColor = true;
            this.Applybutt.Click += new System.EventHandler(this.Applybutt_Click);
            // 
            // Frombox
            // 
            this.Frombox.FormattingEnabled = true;
            this.Frombox.Location = new System.Drawing.Point(162, 78);
            this.Frombox.Name = "Frombox";
            this.Frombox.Size = new System.Drawing.Size(121, 24);
            this.Frombox.TabIndex = 10;
            // 
            // FNum
            // 
            this.FNum.Location = new System.Drawing.Point(480, 134);
            this.FNum.Name = "FNum";
            this.FNum.Size = new System.Drawing.Size(100, 22);
            this.FNum.TabIndex = 12;
            // 
            // Tobox
            // 
            this.Tobox.FormattingEnabled = true;
            this.Tobox.Location = new System.Drawing.Point(459, 75);
            this.Tobox.Name = "Tobox";
            this.Tobox.Size = new System.Drawing.Size(121, 24);
            this.Tobox.TabIndex = 13;
            // 
            // Sortby
            // 
            this.Sortby.FormattingEnabled = true;
            this.Sortby.Items.AddRange(new object[] {
            "Date",
            "Price",
            "Confirm"});
            this.Sortby.Location = new System.Drawing.Point(714, 75);
            this.Sortby.Name = "Sortby";
            this.Sortby.Size = new System.Drawing.Size(121, 24);
            this.Sortby.TabIndex = 14;
            // 
            // datebox
            // 
            this.datebox.Location = new System.Drawing.Point(162, 137);
            this.datebox.Mask = "00/00/0000";
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(121, 22);
            this.datebox.TabIndex = 15;
            this.datebox.ValidatingType = typeof(System.DateTime);
            // 
            // ManageFlightSchedulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 558);
            this.Controls.Add(this.datebox);
            this.Controls.Add(this.Sortby);
            this.Controls.Add(this.Tobox);
            this.Controls.Add(this.FNum);
            this.Controls.Add(this.Frombox);
            this.Controls.Add(this.Applybutt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.EditFbutt);
            this.Controls.Add(this.CancelFbutt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageFlightSchedulesForm";
            this.Text = "ManageFlightSchedulesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CancelFbutt;
        private System.Windows.Forms.Button EditFbutt;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Applybutt;
        private System.Windows.Forms.ComboBox Frombox;
        private System.Windows.Forms.TextBox FNum;
        private System.Windows.Forms.ComboBox Tobox;
        private System.Windows.Forms.ComboBox Sortby;
        private System.Windows.Forms.MaskedTextBox datebox;
    }
}