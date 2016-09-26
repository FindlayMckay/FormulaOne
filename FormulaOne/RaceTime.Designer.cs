namespace FormulaOne
{
    partial class RaceTime
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblDriver = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnTime = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(548, 22);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "C:\\Users\\Findlay\\Documents\\Visual Studio 2015\\Projects\\FormulaOne\\Drivers.csv";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 40);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(548, 22);
            this.txtOutput.TabIndex = 1;
            this.txtOutput.Text = "C:\\Users\\Findlay\\Documents\\Visual Studio 2015\\Projects\\FormulaOne\\DriverResults.c" +
    "sv";
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Location = new System.Drawing.Point(12, 81);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(0, 17);
            this.lblDriver.TabIndex = 2;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(362, 78);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 22);
            this.txtTime.TabIndex = 3;
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(468, 78);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(92, 23);
            this.btnTime.TabIndex = 4;
            this.btnTime.Text = "Time!";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(566, 12);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // RaceTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 433);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblDriver);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "RaceTime";
            this.Text = "Formula One!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Button btnGo;
    }
}

