﻿namespace Tarea18_ColasFIFO
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
            this.txtReporteCiclos = new System.Windows.Forms.TextBox();
            this.btnIniciarCiclos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtReporteCiclos
            // 
            this.txtReporteCiclos.Location = new System.Drawing.Point(93, 12);
            this.txtReporteCiclos.Multiline = true;
            this.txtReporteCiclos.Name = "txtReporteCiclos";
            this.txtReporteCiclos.Size = new System.Drawing.Size(197, 237);
            this.txtReporteCiclos.TabIndex = 0;
            // 
            // btnIniciarCiclos
            // 
            this.btnIniciarCiclos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarCiclos.Location = new System.Drawing.Point(12, 12);
            this.btnIniciarCiclos.Name = "btnIniciarCiclos";
            this.btnIniciarCiclos.Size = new System.Drawing.Size(75, 23);
            this.btnIniciarCiclos.TabIndex = 1;
            this.btnIniciarCiclos.Text = "Iniciar";
            this.btnIniciarCiclos.UseVisualStyleBackColor = true;
            this.btnIniciarCiclos.Click += new System.EventHandler(this.btnIniciarCiclos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 261);
            this.Controls.Add(this.btnIniciarCiclos);
            this.Controls.Add(this.txtReporteCiclos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReporteCiclos;
        private System.Windows.Forms.Button btnIniciarCiclos;
    }
}

