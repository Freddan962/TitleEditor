namespace TitleEditor
{
    partial class Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application));
            this.MTitleField = new System.Windows.Forms.TextBox();
            this.FTitleField = new System.Windows.Forms.TextBox();
            this.AddTitleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.EntryField = new System.Windows.Forms.TextBox();
            this.OverrideField = new System.Windows.Forms.Label();
            this.LoadTitleButton = new System.Windows.Forms.Button();
            this.DeleteTitle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MTitleField
            // 
            this.MTitleField.AccessibleName = "MTitleField";
            this.MTitleField.Location = new System.Drawing.Point(125, 23);
            this.MTitleField.Name = "MTitleField";
            this.MTitleField.Size = new System.Drawing.Size(212, 20);
            this.MTitleField.TabIndex = 2;
            // 
            // FTitleField
            // 
            this.FTitleField.AccessibleName = "FTitleName";
            this.FTitleField.Location = new System.Drawing.Point(125, 62);
            this.FTitleField.Name = "FTitleField";
            this.FTitleField.Size = new System.Drawing.Size(212, 20);
            this.FTitleField.TabIndex = 3;
            // 
            // AddTitleButton
            // 
            this.AddTitleButton.Location = new System.Drawing.Point(102, 145);
            this.AddTitleButton.Name = "AddTitleButton";
            this.AddTitleButton.Size = new System.Drawing.Size(66, 23);
            this.AddTitleButton.TabIndex = 4;
            this.AddTitleButton.Text = "Add";
            this.AddTitleButton.UseVisualStyleBackColor = true;
            this.AddTitleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Male Title Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Female Title Name";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 204);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(349, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "Test";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // EntryField
            // 
            this.EntryField.AccessibleName = "FTitleName";
            this.EntryField.Location = new System.Drawing.Point(125, 103);
            this.EntryField.Name = "EntryField";
            this.EntryField.Size = new System.Drawing.Size(212, 20);
            this.EntryField.TabIndex = 10;
            // 
            // OverrideField
            // 
            this.OverrideField.AutoSize = true;
            this.OverrideField.Location = new System.Drawing.Point(12, 103);
            this.OverrideField.Name = "OverrideField";
            this.OverrideField.Size = new System.Drawing.Size(31, 13);
            this.OverrideField.TabIndex = 11;
            this.OverrideField.Text = "Entry";
            // 
            // LoadTitleButton
            // 
            this.LoadTitleButton.Location = new System.Drawing.Point(15, 145);
            this.LoadTitleButton.Name = "LoadTitleButton";
            this.LoadTitleButton.Size = new System.Drawing.Size(66, 23);
            this.LoadTitleButton.TabIndex = 12;
            this.LoadTitleButton.Text = "Load";
            this.LoadTitleButton.UseVisualStyleBackColor = true;
            this.LoadTitleButton.Click += new System.EventHandler(this.LoadTitleButton_Click);
            // 
            // DeleteTitle
            // 
            this.DeleteTitle.Location = new System.Drawing.Point(183, 145);
            this.DeleteTitle.Name = "DeleteTitle";
            this.DeleteTitle.Size = new System.Drawing.Size(66, 23);
            this.DeleteTitle.TabIndex = 13;
            this.DeleteTitle.Text = "Delete";
            this.DeleteTitle.UseVisualStyleBackColor = true;
            this.DeleteTitle.Click += new System.EventHandler(this.DeleteTitle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Developed by Fractional";
            // 
            // List
            // 
            this.List.Location = new System.Drawing.Point(271, 145);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(66, 23);
            this.List.TabIndex = 15;
            this.List.Text = "List";
            this.List.UseVisualStyleBackColor = true;
            this.List.Click += new System.EventHandler(this.List_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 226);
            this.Controls.Add(this.List);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteTitle);
            this.Controls.Add(this.LoadTitleButton);
            this.Controls.Add(this.OverrideField);
            this.Controls.Add(this.EntryField);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddTitleButton);
            this.Controls.Add(this.FTitleField);
            this.Controls.Add(this.MTitleField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Title Editor 1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MTitleField;
        private System.Windows.Forms.TextBox FTitleField;
        private System.Windows.Forms.Button AddTitleButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.TextBox EntryField;
        private System.Windows.Forms.Label OverrideField;
        private System.Windows.Forms.Button LoadTitleButton;
        private System.Windows.Forms.Button DeleteTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button List;
    }
}

