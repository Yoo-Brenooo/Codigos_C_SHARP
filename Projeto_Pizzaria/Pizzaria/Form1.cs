using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class frm_fundo : Form
    {
        public frm_fundo()
        {
            InitializeComponent();
        }


        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if(txt_Massa.Text != string.Empty && txt_Queijo.Text != string.Empty &&
                txt_Molho.Text != string.Empty && txt_QtdPizza.Text != string.Empty)
            {
                double vlr_queijo = Convert.ToDouble(txt_Queijo.Text);
                double vlr_molho = Convert.ToDouble(txt_Molho.Text);
                double vlr_massa = Convert.ToDouble(txt_Massa.Text);
                double qtd_pizza = Convert.ToDouble(txt_QtdPizza.Text);

                double vlr_total_queijo = vlr_queijo *0.200;
                double vlr_total_molho = vlr_molho * 0.150;

                double custo_final = (vlr_total_queijo + vlr_total_molho + vlr_massa) * qtd_pizza;

                lbl_Result_CustProd.Text = custo_final.ToString("C");

                double queijo_necessario = 200;
                double molho_necessario = 150;

                double qtd_molho = qtd_pizza * molho_necessario / 1000;
                double qtd_queijo = qtd_pizza * queijo_necessario / 1000;

                lbl_Resul_QtdMassa.Text = qtd_pizza.ToString() + " (UN)";
                lbl_Resul_QtdMolho.Text = qtd_molho.ToString("F2") + " (KG)";
                lbl_Resul_QtdQueijo.Text = qtd_queijo.ToString("F2" + " (KG)");
            }
            else
            {
                MessageBox.Show("Informe Valores para o cálculo!!", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {

            txt_Massa.Clear();
            txt_Queijo.Clear();
            txt_Molho.Clear();
            txt_QtdPizza.Clear();
            lbl_Resul_QtdMassa.Text = string.Empty;
            lbl_Resul_QtdQueijo.Text = string.Empty;
            lbl_Resul_QtdMolho.Text = string.Empty;
            lbl_Result_CustProd.Text = string.Empty;
            lbl_Queijo.Focus();
        }

        private void lbl_Result_CustProd_Click(object sender, EventArgs e)
        {

        }
    }
}
