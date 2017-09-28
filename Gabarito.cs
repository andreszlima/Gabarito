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
    public partial class Gabarito : Form
    {
        public Gabarito()
        {
            InitializeComponent();
        }

        double gOld;
        List<string> gabarito = new List<string>();

        private void Bproxima_Click(object sender, EventArgs e)
        {
            

            Bterminar.Enabled = true;

            gOld = Convert.ToDouble(Ngabar.Text);

            if (Iniciar.total - 1 < Convert.ToInt32(gOld))
            {
                Bproxima.Enabled = false;
                Bterminar.Enabled = true;
            }
            else
            {
            
            Bproxima.Enabled = true;

            gOld = gOld + 1;
            Ngabar.Text = gOld.ToString();
            gabarito.Add(txtGabarito.Text);


            txtGabarito.Text = "";
            txtGabarito.Focus();

            nt.Text = string.Concat(Ngabar.Text, "/", Iniciar.total.ToString());

            }
        }

        private void Gabarito_Load(object sender, EventArgs e)
        {
            Ngabar.Text = Iniciar.nQuestao.ToString();

            txtGabarito.CharacterCasing = CharacterCasing.Upper;

            nt.Text = string.Concat(Ngabar.Text, "/", Iniciar.total.ToString());
        }

        private void Bterminar_Click(object sender, EventArgs e)
        {

            gOld = Convert.ToDouble(Ngabar.Text);

            if (Iniciar.total != Convert.ToInt32(gOld))
            {
                Bterminar.Enabled = false;
                Bproxima.Enabled = true;
            }
            else
            {
                Bterminar.Enabled = true;
                
            gOld = gOld + 1;
            Ngabar.Text = gOld.ToString();
            gabarito.Add(txtGabarito.Text);

            Iniciar.gArray = gabarito.ToArray();
            this.Hide();
            Resultado f4 = new Resultado();
            f4.ShowDialog();

            }

        }

        private void Gabarito_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void Vgabarito_Click(object sender, EventArgs e)
        {
            gOld = gOld - 1;
            Ngabar.Text = gOld.ToString();

            gabarito.RemoveAt(gabarito.Count - 1);
            txtGabarito.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gOld = gOld - 1;
            Ngabar.Text = gOld.ToString();

            gabarito.RemoveAt(gabarito.Count - 1);
            txtGabarito.Focus();
        }

        private void txtGabarito_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
    }
}
