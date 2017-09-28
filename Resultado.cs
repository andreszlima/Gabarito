using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Gabarito
{
    public partial class Resultado : Form
    {
        public Resultado()
        {
            InitializeComponent();
        }


        int acertos = 0;
        int numero = Iniciar.qArray.Length;
        double aproveitamento;
        int[] nQuest = new int[Iniciar.qArray.Length];
        string[] correta = new string[Iniciar.qArray.Length];

        private void Resultado_Load(object sender, EventArgs e)
        {
            //string output = string.Join(", ", Iniciar.qArray);
            //MessageBox.Show(output);

            for (int i = 0; i < Iniciar.qArray.Length; i++)
            {
                //if (Iniciar.qArray[i] == Iniciar.gArray[i])
                if (string.Equals(Iniciar.qArray[i],Iniciar.gArray[i], StringComparison.OrdinalIgnoreCase))
                {
                    acertos = acertos + 1;
                    correta[i] = "CERTA";
                }
                else
                {
                    correta[i] = "ERRADA";
                }
            }

            

            for (int j = 0; j < Iniciar.qArray.Length; j++)
            {
                nQuest[j] = Iniciar.nQuestao + j;
            }



            string[] result = nQuest.Select(x => x.ToString()).ToArray();

            for (var i = 0; i < Iniciar.qArray.Count(); i++)
            {
                listView1.Items.Add(new ListViewItem(new[] {result[i], Iniciar.qArray[i], Iniciar.gArray[i], correta[i] }));
            }
            
            

            nAcertos.Text = acertos.ToString();
            nErros.Text = (numero - acertos).ToString();

            aproveitamento = 100*acertos / numero;

            nAproveitamento.Text = string.Concat(aproveitamento.ToString()," %");

            nAcertos.ReadOnly = true;
            nErros.ReadOnly = true;
            nAproveitamento.ReadOnly = true;

            comboBox1.Text = "Excel (*.xlsx)";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;


            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 200;
            toolTip1.ReshowDelay = 500;

            toolTip1.SetToolTip(this.button1, "O arquivo será salvo na mesma pasta de onde este programa está sendo executado");

        }

        private void Resultado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();

            xla.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);

            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;

            int i = 1;

            int j = 1;

            foreach (ListViewItem comp in listView1.Items)

            {

                ws.Cells[i, j] = comp.Text.ToString();

                foreach (ListViewItem.ListViewSubItem drv in comp.SubItems)

                {

                    ws.Cells[i, j] = drv.Text.ToString();

                    j++;

                }

                j = 1;

                i++;

            }
            xla.DisplayAlerts = false;
            xla.ScreenUpdating = false;

            if (string.IsNullOrWhiteSpace(txtNomeExport.Text))
            {
                txtNomeExport.Text = "Resultado";
            }

            try
            {
                if (comboBox1.Text == "Excel (*.xlsx)")
                {
                    if (File.Exists(@Environment.CurrentDirectory + "\\" + txtNomeExport.Text + ".xlsx"))
                    {
                        txtNomeExport.Text = txtNomeExport.Text + "1";
                    }

                    wb.SaveAs(@Environment.CurrentDirectory + "\\" + txtNomeExport.Text, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault);
                }
                else if (comboBox1.Text == "CSV (*.csv)")
                {
                    if (File.Exists(@Environment.CurrentDirectory + "\\" + txtNomeExport.Text + ".csv"))
                    {
                        txtNomeExport.Text = txtNomeExport.Text + "1";
                    }

                    wb.SaveAs(@Environment.CurrentDirectory + "\\" + txtNomeExport.Text, Microsoft.Office.Interop.Excel.XlFileFormat.xlCSV);
                }
                else
                {
                    wb.SaveAs(@Environment.CurrentDirectory + "\\" + txtNomeExport.Text, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault);
                    MessageBox.Show("Como o formato selecionado não está disponível, o arquivo foi salvo no formato de Excel comum (*.xlsx)");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("O nome do arquivo é inválido. Não use caracteres especiais e tente novamente.");
                
            }

            

            

            wb.Close(false);

            xla.DisplayAlerts = true;
            xla.ScreenUpdating = true;

            xla.Quit();

        }
    }
}
