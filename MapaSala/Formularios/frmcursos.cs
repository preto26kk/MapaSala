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
    public partial class frmcursos : Form
    {
        DataTable dados;
        int Linhaselecionada;
        public frmcursos()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(Cursoentidades).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dados.Rows.Add(1, "Intinerario Formativo", "IF");
            dados.Rows.Add(2, "Adiministração", "ADM");
            dados.Rows.Add(3, "Desenvolvimento de sistemas", "DS");
            dtGridCurso.DataSource = dados;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Cursoentidades salas = new Cursoentidades();
            salas.Id = Convert.ToInt32(txtId.Text);
            salas.Nome = txtnome.Text;
            salas.Turno = txtTurno.Text;
            salas.Ativo = ativo.Checked;

            dados.Rows.Add(salas.Linha());
            LimparCampos();
        }

        private void dtGridCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void frmcursos_Load(object sender, EventArgs e)
        {

        }
        private void LimparCampos()
        {
            txtnome.Text = "";
            txtId.Text = "";
            txtTurno.Text = "";
            ativo.Checked = false;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            dtGridCurso.Rows.RemoveAt(Linhaselecionada);
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            DataGridViewRow a = dtGridCurso.Rows[Linhaselecionada];//fazer isso em todas
            a.Cells[0].Value = txtId.Text;
            a.Cells[1].Value = txtnome.Text;
            a.Cells[2].Value = txtTurno.Text;
            a.Cells[3].Value = ativo.Checked;
        }
    }
}
