using System.Configuration;

namespace Learning
{
    partial class Window
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.darkMode = new System.Windows.Forms.Button();
            this.darkModeCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // darkMode
            // 
            this.darkMode.Location = new System.Drawing.Point(373, 219);
            this.darkMode.Name = "darkMode";
            this.darkMode.Size = new System.Drawing.Size(75, 23);
            this.darkMode.TabIndex = 0;
            this.darkMode.Text = "Dark Mode";
            this.darkMode.UseVisualStyleBackColor = true;
            this.darkMode.Click += new System.EventHandler(this.darkMode_onClick);
            // 
            // darkModeCB
            // 
            this.darkModeCB.AutoSize = true;
            this.darkModeCB.Location = new System.Drawing.Point(181, 152);
            this.darkModeCB.Name = "darkModeCB";
            this.darkModeCB.Size = new System.Drawing.Size(95, 20);
            this.darkModeCB.TabIndex = 2;
            this.darkModeCB.Text = "Dark Mode";
            this.darkModeCB.UseVisualStyleBackColor = true;
            this.darkModeCB.CheckedChanged += new System.EventHandler(this.darkModeCB_CheckedChanged);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.darkModeCB);
            this.Controls.Add(this.darkMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Window";
            this.Text = "Windows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button darkMode;
        private System.Windows.Forms.CheckBox darkModeCB;
    }
}

