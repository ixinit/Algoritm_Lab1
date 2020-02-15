namespace Algoritm1._12
{
    partial class MainForm
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
            this.lblCatet1 = new System.Windows.Forms.Label();
            this.lblCatet2 = new System.Windows.Forms.Label();
            this.lblGipotenuza = new System.Windows.Forms.Label();
            this.lblEchoGipotenuza = new System.Windows.Forms.Label();
            this.tbCatet1 = new System.Windows.Forms.TextBox();
            this.tbCatet2 = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCatet1
            // 
            this.lblCatet1.AutoSize = true;
            this.lblCatet1.Location = new System.Drawing.Point(43, 59);
            this.lblCatet1.Name = "lblCatet1";
            this.lblCatet1.Size = new System.Drawing.Size(45, 13);
            this.lblCatet1.TabIndex = 0;
            this.lblCatet1.Text = "Катет 1";
            // 
            // lblCatet2
            // 
            this.lblCatet2.AutoSize = true;
            this.lblCatet2.Location = new System.Drawing.Point(43, 102);
            this.lblCatet2.Name = "lblCatet2";
            this.lblCatet2.Size = new System.Drawing.Size(45, 13);
            this.lblCatet2.TabIndex = 1;
            this.lblCatet2.Text = "Катет 2";
            // 
            // lblGipotenuza
            // 
            this.lblGipotenuza.AutoSize = true;
            this.lblGipotenuza.Location = new System.Drawing.Point(43, 139);
            this.lblGipotenuza.Name = "lblGipotenuza";
            this.lblGipotenuza.Size = new System.Drawing.Size(65, 13);
            this.lblGipotenuza.TabIndex = 2;
            this.lblGipotenuza.Text = "Гипотенуза";
            // 
            // lblEchoGipotenuza
            // 
            this.lblEchoGipotenuza.AutoSize = true;
            this.lblEchoGipotenuza.Location = new System.Drawing.Point(121, 139);
            this.lblEchoGipotenuza.Name = "lblEchoGipotenuza";
            this.lblEchoGipotenuza.Size = new System.Drawing.Size(0, 13);
            this.lblEchoGipotenuza.TabIndex = 3;
            // 
            // tbCatet1
            // 
            this.tbCatet1.Location = new System.Drawing.Point(124, 59);
            this.tbCatet1.Name = "tbCatet1";
            this.tbCatet1.Size = new System.Drawing.Size(100, 20);
            this.tbCatet1.TabIndex = 4;
            // 
            // tbCatet2
            // 
            this.tbCatet2.Location = new System.Drawing.Point(124, 102);
            this.tbCatet2.Name = "tbCatet2";
            this.tbCatet2.Size = new System.Drawing.Size(100, 20);
            this.tbCatet2.TabIndex = 5;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(124, 177);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Решить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tbCatet2);
            this.Controls.Add(this.tbCatet1);
            this.Controls.Add(this.lblEchoGipotenuza);
            this.Controls.Add(this.lblGipotenuza);
            this.Controls.Add(this.lblCatet2);
            this.Controls.Add(this.lblCatet1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCatet1;
        private System.Windows.Forms.Label lblCatet2;
        private System.Windows.Forms.Label lblGipotenuza;
        private System.Windows.Forms.Label lblEchoGipotenuza;
        private System.Windows.Forms.TextBox tbCatet1;
        private System.Windows.Forms.TextBox tbCatet2;
        private System.Windows.Forms.Button btnCalc;
    }
}