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
    public partial class Iniciar : Form
    {

        public static string[] qArray;
        public static string[] gArray;
        public static int nQuestao;

        public static int total;

        public Iniciar()
        {
            InitializeComponent();
        }
        
        private void Bcomecar_Click(object sender, EventArgs e)
        {

            nQuestao = decimal.ToInt32(nPrimeira.Value);

            this.Hide();
            Resposta f2 = new Resposta();
            f2.ShowDialog();
        }

        private void Iniciar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void Bfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
