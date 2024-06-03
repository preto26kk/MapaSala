
namespace MapaSala.Formularios
{
    partial class frmSalas
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
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Islab = new System.Windows.Forms.CheckBox();
            this.Disponivel = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.numCom = new System.Windows.Forms.NumericUpDown();
            this.numCadeiras = new System.Windows.Forms.NumericUpDown();
            this.dtGridSalas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numCom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCadeiras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(62, 33);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome da sala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número de computadores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número de Cadeiras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(44, 20);
            this.txtId.TabIndex = 7;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // Islab
            // 
            this.Islab.AutoSize = true;
            this.Islab.Location = new System.Drawing.Point(436, 33);
            this.Islab.Name = "Islab";
            this.Islab.Size = new System.Drawing.Size(85, 17);
            this.Islab.TabIndex = 8;
            this.Islab.Text = "É laboratório";
            this.Islab.UseVisualStyleBackColor = true;
            // 
            // Disponivel
            // 
            this.Disponivel.AutoSize = true;
            this.Disponivel.Location = new System.Drawing.Point(527, 33);
            this.Disponivel.Name = "Disponivel";
            this.Disponivel.Size = new System.Drawing.Size(77, 17);
            this.Disponivel.TabIndex = 9;
            this.Disponivel.Text = "Disponível";
            this.Disponivel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Disponivel.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(610, 29);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // numCom
            // 
            this.numCom.Location = new System.Drawing.Point(168, 32);
            this.numCom.Name = "numCom";
            this.numCom.Size = new System.Drawing.Size(120, 20);
            this.numCom.TabIndex = 11;
            // 
            // numCadeiras
            // 
            this.numCadeiras.Location = new System.Drawing.Point(318, 32);
            this.numCadeiras.Name = "numCadeiras";
            this.numCadeiras.Size = new System.Drawing.Size(112, 20);
            this.numCadeiras.TabIndex = 12;
            // 
            // dtGridSalas
            // 
            this.dtGridSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridSalas.Location = new System.Drawing.Point(12, 77);
            this.dtGridSalas.Name = "dtGridSalas";
            this.dtGridSalas.Size = new System.Drawing.Size(673, 352);
            this.dtGridSalas.TabIndex = 13;
            // 
            // frmSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.dtGridSalas);
            this.Controls.Add(this.numCadeiras);
            this.Controls.Add(this.numCom);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.Disponivel);
            this.Controls.Add(this.Islab);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnome);
            this.Name = "frmSalas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSalas";
            this.Load += new System.EventHandler(this.frmSalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCadeiras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.CheckBox Islab;
        private System.Windows.Forms.CheckBox Disponivel;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.NumericUpDown numCom;
        private System.Windows.Forms.NumericUpDown numCadeiras;
        private System.Windows.Forms.DataGridView dtGridSalas;
    }
}