
namespace Ejercicio_1
{
    partial class txtMensaje1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMensaje1 = new System.Windows.Forms.Button();
            this.txtMensaje2 = new System.Windows.Forms.TextBox();
            this.btnMensaje2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnMensaje1
            // 
            this.btnMensaje1.Location = new System.Drawing.Point(12, 109);
            this.btnMensaje1.Name = "btnMensaje1";
            this.btnMensaje1.Size = new System.Drawing.Size(151, 23);
            this.btnMensaje1.TabIndex = 1;
            this.btnMensaje1.Text = "Enviar mensaje 1";
            this.btnMensaje1.UseVisualStyleBackColor = true;
            this.btnMensaje1.Click += new System.EventHandler(this.btnMensaje1_Click);
            // 
            // txtMensaje2
            // 
            this.txtMensaje2.Location = new System.Drawing.Point(289, 56);
            this.txtMensaje2.Name = "txtMensaje2";
            this.txtMensaje2.Size = new System.Drawing.Size(151, 20);
            this.txtMensaje2.TabIndex = 2;
            // 
            // btnMensaje2
            // 
            this.btnMensaje2.Location = new System.Drawing.Point(289, 109);
            this.btnMensaje2.Name = "btnMensaje2";
            this.btnMensaje2.Size = new System.Drawing.Size(151, 23);
            this.btnMensaje2.TabIndex = 3;
            this.btnMensaje2.Text = "Enviar mensaje 2";
            this.btnMensaje2.UseVisualStyleBackColor = true;
            this.btnMensaje2.Click += new System.EventHandler(this.btnMensaje2_Click);
            // 
            // txtMensaje1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMensaje2);
            this.Controls.Add(this.txtMensaje2);
            this.Controls.Add(this.btnMensaje1);
            this.Controls.Add(this.textBox1);
            this.Name = "txtMensaje1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnMensaje1;
        private System.Windows.Forms.TextBox txtMensaje2;
        private System.Windows.Forms.Button btnMensaje2;
    }
}

