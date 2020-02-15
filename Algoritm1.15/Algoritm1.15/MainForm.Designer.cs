namespace Algoritm1._15
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
            this.lblEchoPerimetr = new System.Windows.Forms.Label();
            this.tbBase1 = new System.Windows.Forms.TextBox();
            this.tbBase2 = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Основание 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Основание 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Высота";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Периметр трапеции";
            // 
            // lblEchoPerimetr
            // 
            this.lblEchoPerimetr.AutoSize = true;
            this.lblEchoPerimetr.Location = new System.Drawing.Point(171, 165);
            this.lblEchoPerimetr.Name = "lblEchoPerimetr";
            this.lblEchoPerimetr.Size = new System.Drawing.Size(0, 13);
            this.lblEchoPerimetr.TabIndex = 4;
            // 
            // tbBase1
            // 
            this.tbBase1.Location = new System.Drawing.Point(130, 44);
            this.tbBase1.Name = "tbBase1";
            this.tbBase1.Size = new System.Drawing.Size(100, 20);
            this.tbBase1.TabIndex = 5;
            // 
            // tbBase2
            // 
            this.tbBase2.Location = new System.Drawing.Point(130, 79);
            this.tbBase2.Name = "tbBase2";
            this.tbBase2.Size = new System.Drawing.Size(100, 20);
            this.tbBase2.TabIndex = 6;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(130, 116);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(100, 20);
            this.tbHeight.TabIndex = 7;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(95, 207);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 8;
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
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbBase2);
            this.Controls.Add(this.tbBase1);
            this.Controls.Add(this.lblEchoPerimetr);
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
        private System.Windows.Forms.Label lblEchoPerimetr;
        private System.Windows.Forms.TextBox tbBase1;
        private System.Windows.Forms.TextBox tbBase2;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Button btnCalc;
    }
}