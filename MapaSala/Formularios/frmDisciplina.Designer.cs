
namespace MapaSala.Formularios
{
    partial class frmDisciplina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_salvar = new System.Windows.Forms.Button();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ativo = new System.Windows.Forms.CheckBox();
            this.dtGridDisciplina = new System.Windows.Forms.DataGridView();
            this.Limpar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(480, 35);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 0;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(299, 39);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(100, 20);
            this.txtSigla.TabIndex = 13;
            this.txtSigla.TextChanged += new System.EventHandler(this.txtApelido_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sigla";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(166, 39);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(28, 39);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id";
            // 
            // ativo
            // 
            this.ativo.AutoSize = true;
            this.ativo.Location = new System.Drawing.Point(425, 41);
            this.ativo.Name = "ativo";
            this.ativo.Size = new System.Drawing.Size(49, 17);
            this.ativo.TabIndex = 14;
            this.ativo.Text = "ativo";
            this.ativo.UseVisualStyleBackColor = true;
            // 
            // dtGridDisciplina
            // 
            this.dtGridDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridDisciplina.Location = new System.Drawing.Point(42, 74);
            this.dtGridDisciplina.Name = "dtGridDisciplina";
            this.dtGridDisciplina.Size = new System.Drawing.Size(673, 352);
            this.dtGridDisciplina.TabIndex = 15;
            this.dtGridDisciplina.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridDisciplina_CellClick);
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(561, 35);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(75, 23);
            this.Limpar.TabIndex = 16;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(640, 35);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(75, 23);
            this.Excluir.TabIndex = 17;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(721, 35);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(75, 23);
            this.Editar.TabIndex = 18;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // frmDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.dtGridDisciplina);
            this.Controls.Add(this.ativo);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salvar);
            this.Name = "frmDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDisciplina";
            this.Load += new System.EventHandler(this.frmDisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ativo;
        private System.Windows.Forms.DataGridView dtGridDisciplina;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Editar;
    }
}