namespace WindowsPrueba
{
    partial class Form1
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
            this.btnMostrarCom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarCom
            // 
            this.btnMostrarCom.Location = new System.Drawing.Point(194, 90);
            this.btnMostrarCom.Name = "btnMostrarCom";
            this.btnMostrarCom.Size = new System.Drawing.Size(144, 78);
            this.btnMostrarCom.TabIndex = 0;
            this.btnMostrarCom.Text = "Mostrar comision";
            this.btnMostrarCom.UseVisualStyleBackColor = true;
            this.btnMostrarCom.Click += new System.EventHandler(this.btnMostrarCom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 308);
            this.Controls.Add(this.btnMostrarCom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarCom;
    }
}

