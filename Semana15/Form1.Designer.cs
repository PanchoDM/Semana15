namespace Semana15
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
            this.btnMatrizCosto = new System.Windows.Forms.Button();
            this.btnPrim = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnMatrizCosto
            // 
            this.btnMatrizCosto.Location = new System.Drawing.Point(104, 12);
            this.btnMatrizCosto.Name = "btnMatrizCosto";
            this.btnMatrizCosto.Size = new System.Drawing.Size(468, 49);
            this.btnMatrizCosto.TabIndex = 0;
            this.btnMatrizCosto.Text = "Matriz de Costo";
            this.btnMatrizCosto.UseVisualStyleBackColor = true;
            // 
            // btnPrim
            // 
            this.btnPrim.Location = new System.Drawing.Point(87, 290);
            this.btnPrim.Name = "btnPrim";
            this.btnPrim.Size = new System.Drawing.Size(485, 57);
            this.btnPrim.TabIndex = 1;
            this.btnPrim.Text = "Prim";
            this.btnPrim.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(90, 362);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(481, 159);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnPrim);
            this.Controls.Add(this.btnMatrizCosto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMatrizCosto;
        private System.Windows.Forms.Button btnPrim;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

