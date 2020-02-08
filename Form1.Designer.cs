namespace bd_csharp
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
            this.btncadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(131, 202);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(75, 23);
            this.btncadastrar.TabIndex = 0;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.Btncadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(131, 88);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 3;
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(162, 140);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(100, 20);
            this.txttelefone.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 296);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncadastrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txttelefone;
    }
}

