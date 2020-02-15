namespace Algoritm111
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirstNum = new System.Windows.Forms.Label();
            this.lblSecondNum = new System.Windows.Forms.Label();
            this.lblEchoArifm = new System.Windows.Forms.Label();
            this.first = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblEchoGeometry = new System.Windows.Forms.Label();
            this.lblArifm = new System.Windows.Forms.Label();
            this.lblGeometry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstNum
            // 
            this.lblFirstNum.AutoSize = true;
            this.lblFirstNum.Location = new System.Drawing.Point(68, 116);
            this.lblFirstNum.Name = "lblFirstNum";
            this.lblFirstNum.Size = new System.Drawing.Size(77, 13);
            this.lblFirstNum.TabIndex = 0;
            this.lblFirstNum.Text = "Первое число";
            // 
            // lblSecondNum
            // 
            this.lblSecondNum.AutoSize = true;
            this.lblSecondNum.Location = new System.Drawing.Point(71, 161);
            this.lblSecondNum.Name = "lblSecondNum";
            this.lblSecondNum.Size = new System.Drawing.Size(75, 13);
            this.lblSecondNum.TabIndex = 1;
            this.lblSecondNum.Text = "Второе число";
            // 
            // lblEchoArifm
            // 
            this.lblEchoArifm.AutoSize = true;
            this.lblEchoArifm.Location = new System.Drawing.Point(199, 213);
            this.lblEchoArifm.Name = "lblEchoArifm";
            this.lblEchoArifm.Size = new System.Drawing.Size(0, 13);
            this.lblEchoArifm.TabIndex = 2;
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(178, 116);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(100, 20);
            this.first.TabIndex = 3;
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(178, 153);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(100, 20);
            this.second.TabIndex = 4;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(205, 296);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Решить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.calc_Click);
            // 
            // lblEchoGeometry
            // 
            this.lblEchoGeometry.AutoSize = true;
            this.lblEchoGeometry.Location = new System.Drawing.Point(199, 251);
            this.lblEchoGeometry.Name = "lblEchoGeometry";
            this.lblEchoGeometry.Size = new System.Drawing.Size(0, 13);
            this.lblEchoGeometry.TabIndex = 6;
            // 
            // lblArifm
            // 
            this.lblArifm.AutoSize = true;
            this.lblArifm.Location = new System.Drawing.Point(35, 213);
            this.lblArifm.Name = "lblArifm";
            this.lblArifm.Size = new System.Drawing.Size(139, 13);
            this.lblArifm.TabIndex = 7;
            this.lblArifm.Text = "Среднее арифметическое";
            // 
            // lblGeometry
            // 
            this.lblGeometry.AutoSize = true;
            this.lblGeometry.Location = new System.Drawing.Point(38, 251);
            this.lblGeometry.Name = "lblGeometry";
            this.lblGeometry.Size = new System.Drawing.Size(136, 13);
            this.lblGeometry.TabIndex = 8;
            this.lblGeometry.Text = "Среднее геометрическое";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGeometry);
            this.Controls.Add(this.lblArifm);
            this.Controls.Add(this.lblEchoGeometry);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Controls.Add(this.lblEchoArifm);
            this.Controls.Add(this.lblSecondNum);
            this.Controls.Add(this.lblFirstNum);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstNum;
        private System.Windows.Forms.Label lblSecondNum;
        private System.Windows.Forms.Label lblEchoArifm;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblEchoGeometry;
        private System.Windows.Forms.Label lblArifm;
        private System.Windows.Forms.Label lblGeometry;
    }
}

