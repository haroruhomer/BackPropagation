namespace BackPropagation
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_X0 = new System.Windows.Forms.TextBox();
            this.B_Resultado = new System.Windows.Forms.Button();
            this.TB_X1 = new System.Windows.Forms.TextBox();
            this.B_entrenar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_X0
            // 
            this.TB_X0.Location = new System.Drawing.Point(13, 104);
            this.TB_X0.Name = "TB_X0";
            this.TB_X0.Size = new System.Drawing.Size(100, 20);
            this.TB_X0.TabIndex = 0;
            // 
            // B_Resultado
            // 
            this.B_Resultado.Location = new System.Drawing.Point(153, 241);
            this.B_Resultado.Name = "B_Resultado";
            this.B_Resultado.Size = new System.Drawing.Size(75, 23);
            this.B_Resultado.TabIndex = 1;
            this.B_Resultado.Text = "Resultado";
            this.B_Resultado.UseVisualStyleBackColor = true;
            this.B_Resultado.Click += new System.EventHandler(this.B_Resultado_Click);
            // 
            // TB_X1
            // 
            this.TB_X1.Location = new System.Drawing.Point(153, 104);
            this.TB_X1.Name = "TB_X1";
            this.TB_X1.Size = new System.Drawing.Size(100, 20);
            this.TB_X1.TabIndex = 2;
            // 
            // B_entrenar
            // 
            this.B_entrenar.Location = new System.Drawing.Point(12, 12);
            this.B_entrenar.Name = "B_entrenar";
            this.B_entrenar.Size = new System.Drawing.Size(75, 23);
            this.B_entrenar.TabIndex = 3;
            this.B_entrenar.Text = "Entrenar";
            this.B_entrenar.UseVisualStyleBackColor = true;
            this.B_entrenar.Click += new System.EventHandler(this.B_entrenar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_entrenar);
            this.Controls.Add(this.TB_X1);
            this.Controls.Add(this.B_Resultado);
            this.Controls.Add(this.TB_X0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_X0;
        private System.Windows.Forms.Button B_Resultado;
        private System.Windows.Forms.TextBox TB_X1;
        private System.Windows.Forms.Button B_entrenar;
        private System.Windows.Forms.Label label1;
    }
}

