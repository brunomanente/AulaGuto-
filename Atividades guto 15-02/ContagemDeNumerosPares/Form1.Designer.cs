namespace ContagemDeNumerosPares
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnIniciarContagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labNumero
            // 
            this.labNumero.AutoSize = true;
            this.labNumero.Location = new System.Drawing.Point(69, 68);
            this.labNumero.Name = "labNumero";
            this.labNumero.Size = new System.Drawing.Size(96, 13);
            this.labNumero.TabIndex = 0;
            this.labNumero.Text = "NUMERO LIMITE:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(171, 65);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // btnIniciarContagem
            // 
            this.btnIniciarContagem.Location = new System.Drawing.Point(72, 114);
            this.btnIniciarContagem.Name = "btnIniciarContagem";
            this.btnIniciarContagem.Size = new System.Drawing.Size(199, 23);
            this.btnIniciarContagem.TabIndex = 2;
            this.btnIniciarContagem.Text = "INICIAR";
            this.btnIniciarContagem.UseVisualStyleBackColor = true;
            this.btnIniciarContagem.Click += new System.EventHandler(this.btnIniciarContagem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 200);
            this.Controls.Add(this.btnIniciarContagem);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.labNumero);
            this.Name = "Form1";
            this.Text = "CONTAGEM DE NUMEROS PARES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnIniciarContagem;
    }
}

