using Model.Entitidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala.Formularios
{
    public partial class frmDisciplina : Form
    {
        BindingSource dados;
        public frmDisciplina()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridDisciplina.DataSource = dados;
        }

        private void frmDisciplina_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Disciplinasentidades salas = new Disciplinasentidades();
            salas.Id = Convert.ToInt32(txtId.Text);
            salas.Nome = txtnome.Text;
            salas.Sigla = txtSigla.Text;
            salas.Ativo = ativo.Checked;

            dados.Add(salas);
        }

        private void txtApelido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
