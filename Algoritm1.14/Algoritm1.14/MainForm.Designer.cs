namespace Algoritm1._14
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
            this.lblEchoSurfArea = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.tbRCylinder = new System.Windows.Forms.TextBox();
            this.tbHCylinder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Радиус  основания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Высота";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Площадь поверхности цилиндра";
            // 
            // lblEchoSurfArea
            // 
            this.lblEchoSurfArea.AutoSize = true;
            this.lblEchoSurfArea.Location = new System.Drawing.Point(258, 123);
            this.lblEchoSurfArea.Name = "lblEchoSurfArea";
            this.lblEchoSurfArea.Size = new System.Drawing.Size(0, 13);
            this.lblEchoSurfArea.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(65, 164);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Решить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // tbRCylinder
            // 
            this.tbRCylinder.Location = new System.Drawing.Point(147, 38);
            this.tbRCylinder.Name = "tbRCylinder";
            this.tbRCylinder.Size = new System.Drawing.Size(100, 20);
            this.tbRCylinder.TabIndex = 5;
            // 
            // tbHCylinder
            // 
            this.tbHCylinder.Location = new System.Drawing.Point(147, 84);
            this.tbHCylinder.Name = "tbHCylinder";
            this.tbHCylinder.Size = new System.Drawing.Size(100, 20);
            this.tbHCylinder.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbHCylinder);
            this.Controls.Add(this.tbRCylinder);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblEchoSurfArea);
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
        private System.Windows.Forms.Label lblEchoSurfArea;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox tbRCylinder;
        private System.Windows.Forms.TextBox tbHCylinder;
    }
}