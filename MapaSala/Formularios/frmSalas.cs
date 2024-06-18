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
    public partial class frmSalas : Form
    {
        DataTable dados;
        int Linhaselecionada;
        public frmSalas()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(SalasEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dados.Rows.Add(1, "Sala7", "20", "20");
            dados.Rows.Add(2, "Sala8", "20", "20");
            dados.Rows.Add(3, "Sala5", "20","20");
            dtGridSalas.DataSource = dados;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalasEntidade salas = new SalasEntidade();
            salas.Id = Convert .ToInt32(txtId.Text);
            salas.Nome = txtnome.Text;
            salas.IsLab = Islab.Checked;
            salas.NumeroCadeiras = Convert.ToInt32(numCadeiras.Value);
            salas.NumeroComputadores = Convert.ToInt32(numCom.Value);
            salas.Disponivel = Disponivel.Checked;


            dados.Rows.Add(salas.Linha());
            LimparCampos();

        }

        private void frmSalas_Load(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
        private void LimparCampos()
        {
           
                txtnome.Text = "";
                txtId.Text = "";
                numCom.Text = "";
                numCadeiras.Text = "";
                Islab.Checked = false;
                Disponivel.Checked = false;
            
        }
        private void Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void Excuir_Click(object sender, EventArgs e)
        {
            dtGridSalas.Rows.RemoveAt(Linhaselecionada);
        }

        private void Editar_Click(object sender, EventArgs e)
        {
                DataGridViewRow a = dtGridSalas.Rows[Linhaselecionada];//fazer isso em todas
                a.Cells[0].Value = txtnome.Text;
                a.Cells[1].Value = txtId.Text;
                a.Cells[2].Value = numCom.Value;
                a.Cells[3].Value = numCadeiras.Value;
                a.Cells[4].Value = Islab.Checked;
                a.Cells[5].Value = Disponivel.Checked;
        
        }
    }
}
