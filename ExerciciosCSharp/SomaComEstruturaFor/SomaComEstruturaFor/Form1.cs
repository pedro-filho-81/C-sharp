using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomaComEstruturaFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // cria variável soma
            int soma = 0;
            int i = 0;

            for( i = 2; i <= 10; i += 2 )
            {
                soma += i;
                MessageBox.Show($"{i}", "Informação", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Information);
            }
            lblMensagem.Text = $"A soma dos números de 2 a 10 é {soma}\n";
        }
    }
}
