namespace Algoritm1._13
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEchoDistance = new System.Windows.Forms.Label();
            this.tbX1Dot = new System.Windows.Forms.TextBox();
            this.tbY1Dot = new System.Windows.Forms.TextBox();
            this.tbY2Dot = new System.Windows.Forms.TextBox();
            this.tbX2Dot = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Первая точка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "X1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вторая точка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "X2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Y2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Расстояние";
            // 
            // lblEchoDistance
            // 
            this.lblEchoDistance.AutoSize = true;
            this.lblEchoDistance.Location = new System.Drawing.Point(168, 181);
            this.lblEchoDistance.Name = "lblEchoDistance";
            this.lblEchoDistance.Size = new System.Drawing.Size(0, 13);
            this.lblEchoDistance.TabIndex = 7;
            // 
            // tbX1Dot
            // 
            this.tbX1Dot.Location = new System.Drawing.Point(68, 54);
            this.tbX1Dot.Name = "tbX1Dot";
            this.tbX1Dot.Size = new System.Drawing.Size(100, 20);
            this.tbX1Dot.TabIndex = 8;
            // 
            // tbY1Dot
            // 
            this.tbY1Dot.Location = new System.Drawing.Point(244, 54);
            this.tbY1Dot.Name = "tbY1Dot";
            this.tbY1Dot.Size = new System.Drawing.Size(100, 20);
            this.tbY1Dot.TabIndex = 9;
            // 
            // tbY2Dot
            // 
            this.tbY2Dot.Location = new System.Drawing.Point(244, 129);
            this.tbY2Dot.Name = "tbY2Dot";
            this.tbY2Dot.Size = new System.Drawing.Size(100, 20);
            this.tbY2Dot.TabIndex = 10;
            // 
            // tbX2Dot
            // 
            this.tbX2Dot.Location = new System.Drawing.Point(68, 129);
            this.tbX2Dot.Name = "tbX2Dot";
            this.tbX2Dot.Size = new System.Drawing.Size(100, 20);
            this.tbX2Dot.TabIndex = 11;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(93, 227);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 12;
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
            this.Controls.Add(this.tbX2Dot);
            this.Controls.Add(this.tbY2Dot);
            this.Controls.Add(this.tbY1Dot);
            this.Controls.Add(this.tbX1Dot);
            this.Controls.Add(this.lblEchoDistance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEchoDistance;
        private System.Windows.Forms.TextBox tbX1Dot;
        private System.Windows.Forms.TextBox tbY1Dot;
        private System.Windows.Forms.TextBox tbY2Dot;
        private System.Windows.Forms.TextBox tbX2Dot;
        private System.Windows.Forms.Button btnCalc;
    }
}