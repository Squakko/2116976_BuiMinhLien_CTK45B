namespace _2116976_LyThuyetBuoi2
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "GroupBox";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(86, 184);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(174, 73);
            this.bt2.TabIndex = 0;
            this.bt2.Text = "Pannel";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(86, 309);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(174, 73);
            this.bt3.TabIndex = 0;
            this.bt3.Text = "MenuStrip";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(300, 76);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(174, 73);
            this.bt4.TabIndex = 0;
            this.bt4.Text = "Status Strip";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(300, 184);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(174, 73);
            this.bt5.TabIndex = 0;
            this.bt5.Text = "Context Menu";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(300, 309);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(174, 73);
            this.bt6.TabIndex = 0;
            this.bt6.Text = "Image List";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button bt2;
        private Button bt3;
        private Button bt4;
        private Button bt5;
        private Button bt6;
    }
}