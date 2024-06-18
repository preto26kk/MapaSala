
namespace MapaSala.Formularios
{
    partial class frmProfessor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtGridProf = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProf)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(407, 26);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 0;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 2;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(150, 28);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(283, 28);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(100, 20);
            this.txtApelido.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apelido";
            // 
            // dtGridProf
            // 
            this.dtGridProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProf.Location = new System.Drawing.Point(15, 73);
            this.dtGridProf.Name = "dtGridProf";
            this.dtGridProf.Size = new System.Drawing.Size(673, 352);
            this.dtGridProf.TabIndex = 14;
            this.dtGridProf.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridProf_CellClick);
            this.dtGridProf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridProf_CellContentClick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(498, 25);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(589, 26);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(75, 23);
            this.Excluir.TabIndex = 16;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(670, 26);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(75, 23);
            this.Editar.TabIndex = 17;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // frmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dtGridProf);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salvar);
            this.Name = "frmProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfessor";
            this.Load += new System.EventHandler(this.frmProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtGridProf;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Editar;
    }
}