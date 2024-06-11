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
    public partial class frmUsuarios : Form
    {
        BindingSource dados;
        public frmUsuarios()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridUsuario.DataSource = dados;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtGridUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UsuariosEntidade salas = new UsuariosEntidade();
            salas.Id = Convert.ToInt32(txtId.Text);
            salas.Nome = txtnome.Text;
            salas.Senha = txtSenha.Text;
            salas.Login = txtLogin.Text;
            salas.Ativo = ativo.Checked;
            dados.Add(salas);
        }
    }
}
