using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContagemDeNumerosPares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarContagem_Click(object sender, EventArgs e)
        {

            int cont;
           // int vet[] = new int[]
            for (cont = 1; cont <= Convert.ToInt32(txtNumero.Text); cont++)
            {
                if (cont % 2 == 0)
                {
                    MessageBox.Show("A contagem dos numeros é" + (cont));
                }
            }
           






        }
    }
}
