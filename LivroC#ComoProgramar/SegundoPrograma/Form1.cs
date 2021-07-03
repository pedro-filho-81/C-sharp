using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoPrograma
{
    public partial class FormPrincipal : Form
    {
        private string nome;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnOla_Click(object sender, EventArgs e)
        {
            nome = textNome.Text;
            MessageBox.Show($"Olá, {nome}! Bem vindo ao C#.", "Olá", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } // fim btn click

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textNome.Text = "";
        } // fim bte limpar
    } // fim classe
} // fim namespace
