﻿namespace SyncVsAsyncBouncyBox
{
    partial class FormBouncyBox
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.butSync = new System.Windows.Forms.Button();
            this.butAsync = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butAsync);
            this.panel1.Controls.Add(this.butSync);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 451);
            this.panel1.TabIndex = 0;
            // 
            // butSync
            // 
            this.butSync.Location = new System.Drawing.Point(690, 14);
            this.butSync.Name = "butSync";
            this.butSync.Size = new System.Drawing.Size(91, 32);
            this.butSync.TabIndex = 0;
            this.butSync.Text = "Sync";
            this.butSync.UseVisualStyleBackColor = true;
            // 
            // butAsync
            // 
            this.butAsync.Location = new System.Drawing.Point(690, 63);
            this.butAsync.Name = "butAsync";
            this.butAsync.Size = new System.Drawing.Size(91, 32);
            this.butAsync.TabIndex = 1;
            this.butAsync.Text = "Async";
            this.butAsync.UseVisualStyleBackColor = true;
            // 
            // FormBouncyBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormBouncyBox";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button butAsync;
        private Button butSync;
    }
}