namespace Gabarito
{
    partial class Iniciar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Iniciar));
            this.Bcomecar = new System.Windows.Forms.Button();
            this.Bfechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nPrimeira = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nPrimeira)).BeginInit();
            this.SuspendLayout();
            // 
            // Bcomecar
            // 
            this.Bcomecar.Location = new System.Drawing.Point(146, 57);
            this.Bcomecar.Name = "Bcomecar";
            this.Bcomecar.Size = new System.Drawing.Size(75, 23);
            this.Bcomecar.TabIndex = 0;
            this.Bcomecar.Text = "Começar";
            this.Bcomecar.UseVisualStyleBackColor = true;
            this.Bcomecar.Click += new System.EventHandler(this.Bcomecar_Click);
            // 
            // Bfechar
            // 
            this.Bfechar.Location = new System.Drawing.Point(13, 56);
            this.Bfechar.Name = "Bfechar";
            this.Bfechar.Size = new System.Drawing.Size(75, 23);
            this.Bfechar.TabIndex = 1;
            this.Bfechar.Text = "Fechar";
            this.Bfechar.UseVisualStyleBackColor = true;
            this.Bfechar.Click += new System.EventHandler(this.Bfechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resolver questões";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Primeira questão:";
            // 
            // nPrimeira
            // 
            this.nPrimeira.Location = new System.Drawing.Point(139, 103);
            this.nPrimeira.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nPrimeira.Name = "nPrimeira";
            this.nPrimeira.Size = new System.Drawing.Size(52, 20);
            this.nPrimeira.TabIndex = 4;
            this.nPrimeira.ThousandsSeparator = true;
            this.nPrimeira.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Iniciar
            // 
            this.AcceptButton = this.Bcomecar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 145);
            this.Controls.Add(this.nPrimeira);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bfechar);
            this.Controls.Add(this.Bcomecar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Iniciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Início";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Iniciar_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nPrimeira)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bcomecar;
        private System.Windows.Forms.Button Bfechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nPrimeira;
    }
}

