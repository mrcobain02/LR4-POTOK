namespace калькулятор_квадратных_урвнений
{
    partial class Form1
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.startload = new System.Windows.Forms.Button();
            this.stopload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(34, 24);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(343, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // startload
            // 
            this.startload.Location = new System.Drawing.Point(202, 72);
            this.startload.Name = "startload";
            this.startload.Size = new System.Drawing.Size(75, 23);
            this.startload.TabIndex = 1;
            this.startload.Text = "Старт";
            this.startload.UseVisualStyleBackColor = true;
            this.startload.Click += new System.EventHandler(this.startload_Click);
            // 
            // stopload
            // 
            this.stopload.Location = new System.Drawing.Point(302, 72);
            this.stopload.Name = "stopload";
            this.stopload.Size = new System.Drawing.Size(75, 23);
            this.stopload.TabIndex = 2;
            this.stopload.Text = "Стоп";
            this.stopload.UseVisualStyleBackColor = true;
            this.stopload.Click += new System.EventHandler(this.stopload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Идет запуск ....";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopload);
            this.Controls.Add(this.startload);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button startload;
        private System.Windows.Forms.Button stopload;
        private System.Windows.Forms.Label label1;
    }
}