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
        int Linhaselecionada;
        public frmProfessor()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(ProfessoresEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dados.Rows.Add(1, "Alexandre", "Galvani");
            dados.Rows.Add(1, "Lucilene", "Luci");
            dados.Rows.Add(1, "Fernando", "LoLzin");
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
            dados.Rows.Add(salas.Linha());
            LimparCampos();
        }

        private void dtGridProf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
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
            dtGridProf.Rows.RemoveAt(Linhaselecionada);
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            DataGridViewRow a = dtGridProf.Rows[Linhaselecionada];//fazer isso em todas
            a.Cells[0].Value = txtId.Text;
            a.Cells[1].Value = txtnome.Text;
            a.Cells[2].Value = txtApelido.Text;
          
        }
    }
}
