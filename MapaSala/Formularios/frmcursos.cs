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
        BindingSource dados;
        public frmcursos()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridCurso.DataSource = dados;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Cursoentidades salas = new Cursoentidades();
            salas.Id = Convert.ToInt32(txtId.Text);
            salas.Nome = txtnome.Text;
            salas.Turno = txtTurno.Text;
            salas.Ativo = ativo.Checked;

            dados.Add(salas);
        }
    }
}
