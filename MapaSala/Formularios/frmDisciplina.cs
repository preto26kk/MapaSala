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
       DataTable dados;
        int Linhaselecionada;
        public frmDisciplina()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(Disciplinasentidades).GetProperties()) 
            {
                dados.Columns.Add(atributos.Name);
            }
            dados.Rows.Add(1, "Matematica", "Mat");
            dados.Rows.Add(1, "Português", "Port");
            dados.Rows.Add(1, "Fisica", "Fis");

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

            dados.Rows.Add(salas.Linha());
            LimparCampos();
        }

        private void txtApelido_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtGridDisciplina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Linhaselecionada = e.RowIndex;
            txtnome.Text = dtGridDisciplina.Rows[Linhaselecionada].Cells[1].Value.ToString();
            txtSigla.Text = dtGridDisciplina.Rows[Linhaselecionada].Cells[2].Value.ToString();
            txtId.Text = dtGridDisciplina.Rows[Linhaselecionada].Cells[0].Value.ToString();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            dtGridDisciplina.Rows.RemoveAt(Linhaselecionada);
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtnome.Text = "";
            txtId.Text = "";
            txtSigla.Text = "";
        }
    }
}
