﻿namespace Session07.UI
{
    partial class FormPermission
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
            this.listBoxForms = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forms";
            // 
            // listBoxForms
            // 
            this.listBoxForms.FormattingEnabled = true;
            this.listBoxForms.ItemHeight = 15;
            this.listBoxForms.Location = new System.Drawing.Point(12, 75);
            this.listBoxForms.Name = "listBoxForms";
            this.listBoxForms.Size = new System.Drawing.Size(256, 364);
            this.listBoxForms.TabIndex = 2;
            // 
            // FormPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxForms);
            this.Controls.Add(this.label1);
            this.Name = "FormPermission";
            this.Text = "FormPermission";
            this.Load += new System.EventHandler(this.FormPermission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox listBoxForms;
    }
}