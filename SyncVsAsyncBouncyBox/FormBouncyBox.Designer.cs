namespace SyncVsAsyncBouncyBox
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
            this.bouncyBox = new SyncVsAsyncBouncyBox.BouncyBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dbDelay = new System.Windows.Forms.NumericUpDown();
            this.butAsync = new System.Windows.Forms.Button();
            this.butSync = new System.Windows.Forms.Button();
            this.dbInterval = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.bouncyBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dbDelay);
            this.panel1.Controls.Add(this.butAsync);
            this.panel1.Controls.Add(this.butSync);
            this.panel1.Controls.Add(this.dbInterval);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 451);
            this.panel1.TabIndex = 0;
            // 
            // bouncyBox
            // 
            this.bouncyBox.BackColor = System.Drawing.Color.White;
            this.bouncyBox.CustomText = "";
            this.bouncyBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bouncyBox.Interval = 2000;
            this.bouncyBox.Location = new System.Drawing.Point(8, 7);
            this.bouncyBox.Multiline = true;
            this.bouncyBox.Name = "bouncyBox";
            this.bouncyBox.ReadOnly = true;
            this.bouncyBox.Size = new System.Drawing.Size(100, 88);
            this.bouncyBox.TabIndex = 2;
            this.bouncyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(691, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Db Call Time";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(691, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Call Db";
            // 
            // dbDelay
            // 
            this.dbDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dbDelay.BackColor = System.Drawing.Color.Red;
            this.dbDelay.Location = new System.Drawing.Point(691, 168);
            this.dbDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.dbDelay.Name = "dbDelay";
            this.dbDelay.Size = new System.Drawing.Size(90, 23);
            this.dbDelay.TabIndex = 4;
            this.dbDelay.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.dbDelay.ValueChanged += new System.EventHandler(this.dbDelay_ValueChanged);
            // 
            // butAsync
            // 
            this.butAsync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butAsync.Location = new System.Drawing.Point(690, 63);
            this.butAsync.Name = "butAsync";
            this.butAsync.Size = new System.Drawing.Size(91, 32);
            this.butAsync.TabIndex = 1;
            this.butAsync.Text = "Async";
            this.butAsync.UseVisualStyleBackColor = true;
            this.butAsync.Click += new System.EventHandler(this.butAsync_Click);
            // 
            // butSync
            // 
            this.butSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSync.Location = new System.Drawing.Point(690, 14);
            this.butSync.Name = "butSync";
            this.butSync.Size = new System.Drawing.Size(91, 32);
            this.butSync.TabIndex = 0;
            this.butSync.Text = "Sync";
            this.butSync.UseVisualStyleBackColor = true;
            this.butSync.Click += new System.EventHandler(this.butSync_Click);
            // 
            // dbInterval
            // 
            this.dbInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dbInterval.Location = new System.Drawing.Point(691, 122);
            this.dbInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.dbInterval.Name = "dbInterval";
            this.dbInterval.Size = new System.Drawing.Size(90, 23);
            this.dbInterval.TabIndex = 3;
            this.dbInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.dbInterval.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // FormBouncyBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormBouncyBox";
            this.Text = "Sync vs Async";
            this.Shown += new System.EventHandler(this.FormBouncyBox_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button butAsync;
        private Button butSync;
        private BouncyBox bouncyBox;
        private NumericUpDown dbInterval;
        private NumericUpDown dbDelay;
        private Label label2;
        private Label label1;
    }
}