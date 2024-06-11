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
        DataTable dados;
        int LinhaSelecionada;
        public frmProfessor()
        {
            InitializeComponent();
            dados = new DataTable();
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

        private void dtGridProf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtnome.Text = "";
            txtId.Text = "";
            txtApelido.Text = "";
        }

        private void frmProfessor_Load(object sender, EventArgs e)
        {

        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            dtGridProf.Rows.RemoveAt(LinhaSelecionada);
        }
    }
}
