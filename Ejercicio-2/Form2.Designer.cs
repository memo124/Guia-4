namespace ejemplo_3
{
    partial class Form2
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
            this.txtNotaPeriodo1 = new System.Windows.Forms.TextBox();
            this.txtNotaPeriodo2 = new System.Windows.Forms.TextBox();
            this.txtNotaPeriodo3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.txtNotaPeriodo4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 3";
            // 
            // txtNotaPeriodo1
            // 
            this.txtNotaPeriodo1.Location = new System.Drawing.Point(61, 18);
            this.txtNotaPeriodo1.Name = "txtNotaPeriodo1";
            this.txtNotaPeriodo1.Size = new System.Drawing.Size(100, 20);
            this.txtNotaPeriodo1.TabIndex = 4;
            // 
            // txtNotaPeriodo2
            // 
            this.txtNotaPeriodo2.Location = new System.Drawing.Point(61, 51);
            this.txtNotaPeriodo2.Name = "txtNotaPeriodo2";
            this.txtNotaPeriodo2.Size = new System.Drawing.Size(100, 20);
            this.txtNotaPeriodo2.TabIndex = 5;
            // 
            // txtNotaPeriodo3
            // 
            this.txtNotaPeriodo3.Location = new System.Drawing.Point(61, 84);
            this.txtNotaPeriodo3.Name = "txtNotaPeriodo3";
            this.txtNotaPeriodo3.Size = new System.Drawing.Size(100, 20);
            this.txtNotaPeriodo3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular promedio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Location = new System.Drawing.Point(193, 21);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(0, 13);
            this.lblEstudiante.TabIndex = 8;
            // 
            // txtNotaPeriodo4
            // 
            this.txtNotaPeriodo4.Location = new System.Drawing.Point(61, 117);
            this.txtNotaPeriodo4.Name = "txtNotaPeriodo4";
            this.txtNotaPeriodo4.Size = new System.Drawing.Size(100, 20);
            this.txtNotaPeriodo4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nota 4";
            // 
            // txtPromedio
            // 
            this.txtPromedio.AutoSize = true;
            this.txtPromedio.Location = new System.Drawing.Point(205, 86);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(0, 13);
            this.txtPromedio.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 212);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.txtNotaPeriodo4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEstudiante);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNotaPeriodo3);
            this.Controls.Add(this.txtNotaPeriodo2);
            this.Controls.Add(this.txtNotaPeriodo1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNotaPeriodo1;
        private System.Windows.Forms.TextBox txtNotaPeriodo2;
        private System.Windows.Forms.TextBox txtNotaPeriodo3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.TextBox txtNotaPeriodo4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtPromedio;
    }
}