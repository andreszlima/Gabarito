namespace Gabarito
{
    partial class Gabarito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gabarito));
            this.Bterminar = new System.Windows.Forms.Button();
            this.Bproxima = new System.Windows.Forms.Button();
            this.txtGabarito = new System.Windows.Forms.TextBox();
            this.Lquestao = new System.Windows.Forms.Label();
            this.Ngabar = new System.Windows.Forms.Label();
            this.nt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bterminar
            // 
            this.Bterminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bterminar.Location = new System.Drawing.Point(43, 108);
            this.Bterminar.Name = "Bterminar";
            this.Bterminar.Size = new System.Drawing.Size(186, 23);
            this.Bterminar.TabIndex = 5;
            this.Bterminar.Text = "Esta é a última questão. Terminar";
            this.Bterminar.UseVisualStyleBackColor = true;
            this.Bterminar.Click += new System.EventHandler(this.Bterminar_Click);
            // 
            // Bproxima
            // 
            this.Bproxima.Location = new System.Drawing.Point(154, 59);
            this.Bproxima.Name = "Bproxima";
            this.Bproxima.Size = new System.Drawing.Size(75, 23);
            this.Bproxima.TabIndex = 6;
            this.Bproxima.Text = "Próxima";
            this.Bproxima.UseVisualStyleBackColor = true;
            this.Bproxima.Click += new System.EventHandler(this.Bproxima_Click);
            // 
            // txtGabarito
            // 
            this.txtGabarito.Location = new System.Drawing.Point(128, 25);
            this.txtGabarito.Name = "txtGabarito";
            this.txtGabarito.Size = new System.Drawing.Size(41, 20);
            this.txtGabarito.TabIndex = 4;
            this.txtGabarito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGabarito_KeyPress);
            // 
            // Lquestao
            // 
            this.Lquestao.AutoSize = true;
            this.Lquestao.Location = new System.Drawing.Point(51, 28);
            this.Lquestao.Name = "Lquestao";
            this.Lquestao.Size = new System.Drawing.Size(50, 13);
            this.Lquestao.TabIndex = 3;
            this.Lquestao.Text = "Questão ";
            // 
            // Ngabar
            // 
            this.Ngabar.AutoSize = true;
            this.Ngabar.Location = new System.Drawing.Point(101, 28);
            this.Ngabar.Name = "Ngabar";
            this.Ngabar.Size = new System.Drawing.Size(0, 13);
            this.Ngabar.TabIndex = 7;
            // 
            // nt
            // 
            this.nt.AutoSize = true;
            this.nt.Location = new System.Drawing.Point(217, 9);
            this.nt.Name = "nt";
            this.nt.Size = new System.Drawing.Size(12, 13);
            this.nt.TabIndex = 9;
            this.nt.Text = "/";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gabarito
            // 
            this.AcceptButton = this.Bproxima;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 143);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nt);
            this.Controls.Add(this.Ngabar);
            this.Controls.Add(this.Bterminar);
            this.Controls.Add(this.Bproxima);
            this.Controls.Add(this.txtGabarito);
            this.Controls.Add(this.Lquestao);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Gabarito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gabarito";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gabarito_FormClosing);
            this.Load += new System.EventHandler(this.Gabarito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bterminar;
        private System.Windows.Forms.Button Bproxima;
        private System.Windows.Forms.TextBox txtGabarito;
        private System.Windows.Forms.Label Lquestao;
        private System.Windows.Forms.Label Ngabar;
        private System.Windows.Forms.Label nt;
        private System.Windows.Forms.Button button1;
    }
}