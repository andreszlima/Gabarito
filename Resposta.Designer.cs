namespace Gabarito
{
    partial class Resposta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resposta));
            this.Lquestao = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.Bproxima = new System.Windows.Forms.Button();
            this.Bterminar = new System.Windows.Forms.Button();
            this.Nquest = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lquestao
            // 
            this.Lquestao.AutoSize = true;
            this.Lquestao.Location = new System.Drawing.Point(52, 28);
            this.Lquestao.Name = "Lquestao";
            this.Lquestao.Size = new System.Drawing.Size(50, 13);
            this.Lquestao.TabIndex = 0;
            this.Lquestao.Text = "Questão ";
            // 
            // txtResposta
            // 
            this.txtResposta.Location = new System.Drawing.Point(129, 25);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(41, 20);
            this.txtResposta.TabIndex = 1;
            this.txtResposta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResposta_KeyPress);
            // 
            // Bproxima
            // 
            this.Bproxima.Location = new System.Drawing.Point(155, 59);
            this.Bproxima.Name = "Bproxima";
            this.Bproxima.Size = new System.Drawing.Size(75, 23);
            this.Bproxima.TabIndex = 2;
            this.Bproxima.Text = "Próxima";
            this.Bproxima.UseVisualStyleBackColor = true;
            this.Bproxima.Click += new System.EventHandler(this.Bproxima_Click);
            // 
            // Bterminar
            // 
            this.Bterminar.Location = new System.Drawing.Point(44, 108);
            this.Bterminar.Name = "Bterminar";
            this.Bterminar.Size = new System.Drawing.Size(186, 23);
            this.Bterminar.TabIndex = 2;
            this.Bterminar.Text = "Esta é a última questão. Terminar";
            this.Bterminar.UseVisualStyleBackColor = true;
            this.Bterminar.Click += new System.EventHandler(this.Bterminar_Click);
            // 
            // Nquest
            // 
            this.Nquest.AutoSize = true;
            this.Nquest.Location = new System.Drawing.Point(98, 28);
            this.Nquest.Name = "Nquest";
            this.Nquest.Size = new System.Drawing.Size(0, 13);
            this.Nquest.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Resposta
            // 
            this.AcceptButton = this.Bproxima;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 143);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Nquest);
            this.Controls.Add(this.Bterminar);
            this.Controls.Add(this.Bproxima);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.Lquestao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Resposta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resposta";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Resposta_FormClosing);
            this.Load += new System.EventHandler(this.Resposta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lquestao;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Button Bproxima;
        private System.Windows.Forms.Button Bterminar;
        private System.Windows.Forms.Label Nquest;
        private System.Windows.Forms.Button button2;
    }
}