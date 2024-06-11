using MapaSala.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
           
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalas s = new frmSalas();
            s.ShowDialog();
        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfessor s = new frmProfessor();
            s.ShowDialog();
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisciplina s = new frmDisciplina();
            s.ShowDialog();
        }

        private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcursos s = new frmcursos();
            s.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios s = new frmUsuarios();
            s.ShowDialog();
        }
    }
}
