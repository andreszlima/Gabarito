using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gabarito
{
    public partial class Resposta : Form
    {
        public Resposta()
        {
            InitializeComponent();
        }

        double qOld;
        List<string> questoes = new List<string>();

        private void Resposta_Load(object sender, EventArgs e)
        {
            Nquest.Text = Iniciar.nQuestao.ToString();
        }

        private void Bproxima_Click(object sender, EventArgs e)
        {
            
            qOld = Convert.ToDouble(Nquest.Text);
            qOld = qOld + 1;
            Nquest.Text = qOld.ToString();
            questoes.Add(txtResposta.Text);
            

            txtResposta.Text = "";
            txtResposta.Focus();
            Bterminar.Enabled = true;

        }

        private void Bterminar_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(Nquest.Text) == 1)
            {
                MessageBox.Show("Resolva pelo menos mais uma questão antes de continuar");
            }
            else
            {

            Iniciar.total = Convert.ToInt32(qOld);
            
            Nquest.Text = qOld.ToString();
            questoes.Add(txtResposta.Text);

            Iniciar.qArray = questoes.ToArray();
            this.Hide();
            Gabarito f3 = new Gabarito();
            f3.ShowDialog();

            }
        }

        private void Resposta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            qOld = qOld - 1;
            Nquest.Text = qOld.ToString();

            questoes.RemoveAt(questoes.Count - 1);
            txtResposta.Focus();
        }
    }
}
