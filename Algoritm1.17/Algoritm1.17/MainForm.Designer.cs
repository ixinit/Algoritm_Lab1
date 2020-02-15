namespace Algoritm1._17
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEchoArea = new System.Windows.Forms.Label();
            this.tbSide1 = new System.Windows.Forms.TextBox();
            this.tbSide2 = new System.Windows.Forms.TextBox();
            this.tbAngle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сторона 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сторона 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Угол";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(115, 182);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Решить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Площадь треугольника";
            // 
            // lblEchoArea
            // 
            this.lblEchoArea.AutoSize = true;
            this.lblEchoArea.Location = new System.Drawing.Point(220, 153);
            this.lblEchoArea.Name = "lblEchoArea";
            this.lblEchoArea.Size = new System.Drawing.Size(0, 13);
            this.lblEchoArea.TabIndex = 5;
            // 
            // tbSide1
            // 
            this.tbSide1.Location = new System.Drawing.Point(129, 46);
            this.tbSide1.Name = "tbSide1";
            this.tbSide1.Size = new System.Drawing.Size(100, 20);
            this.tbSide1.TabIndex = 6;
            // 
            // tbSide2
            // 
            this.tbSide2.Location = new System.Drawing.Point(129, 82);
            this.tbSide2.Name = "tbSide2";
            this.tbSide2.Size = new System.Drawing.Size(100, 20);
            this.tbSide2.TabIndex = 7;
            // 
            // tbAngle
            // 
            this.tbAngle.Location = new System.Drawing.Point(129, 118);
            this.tbAngle.Name = "tbAngle";
            this.tbAngle.Size = new System.Drawing.Size(100, 20);
            this.tbAngle.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbAngle);
            this.Controls.Add(this.tbSide2);
            this.Controls.Add(this.tbSide1);
            this.Controls.Add(this.lblEchoArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalc);
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
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEchoArea;
        private System.Windows.Forms.TextBox tbSide1;
        private System.Windows.Forms.TextBox tbSide2;
        private System.Windows.Forms.TextBox tbAngle;
    }
}