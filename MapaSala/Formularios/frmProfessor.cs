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
    public partial class frmProfessor : Form
    {
        BindingSource dados;
        public frmProfessor()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridProf.DataSource = dados;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            ProfessoresEntidade salas = new ProfessoresEntidade();
            salas.Id = Convert.ToInt32(txtId.Text);
            salas.Nome = txtnome.Text;
            salas.Apelido = txtApelido.Text;
            dados.Add(salas);
        }
    }
}
