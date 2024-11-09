namespace Cadastro_Amivolta
{
    partial class Pesquisa
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_Pesquisar = new System.Windows.Forms.TextBox();
            this.Dgv_Pesquisa = new System.Windows.Forms.DataGridView();
            this.Btn_Cadastro = new System.Windows.Forms.Button();
            this.Btn_Excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Pesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Pesquisar
            // 
            this.Txt_Pesquisar.Location = new System.Drawing.Point(13, 13);
            this.Txt_Pesquisar.Name = "Txt_Pesquisar";
            this.Txt_Pesquisar.Size = new System.Drawing.Size(413, 20);
            this.Txt_Pesquisar.TabIndex = 0;
            this.Txt_Pesquisar.TextChanged += new System.EventHandler(this.Txt_Pesquisar_TextChanged);
            // 
            // Dgv_Pesquisa
            // 
            this.Dgv_Pesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Pesquisa.Location = new System.Drawing.Point(13, 39);
            this.Dgv_Pesquisa.Name = "Dgv_Pesquisa";
            this.Dgv_Pesquisa.ReadOnly = true;
            this.Dgv_Pesquisa.Size = new System.Drawing.Size(675, 333);
            this.Dgv_Pesquisa.TabIndex = 1;
            this.Dgv_Pesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Pesquisa_CellDoubleClick);
            // 
            // Btn_Cadastro
            // 
            this.Btn_Cadastro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cadastro.Location = new System.Drawing.Point(24, 402);
            this.Btn_Cadastro.Name = "Btn_Cadastro";
            this.Btn_Cadastro.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cadastro.TabIndex = 2;
            this.Btn_Cadastro.Text = "Cadastro";
            this.Btn_Cadastro.UseVisualStyleBackColor = true;
            this.Btn_Cadastro.Click += new System.EventHandler(this.Btn_Cadastro_Click);
            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Excluir.Location = new System.Drawing.Point(166, 402);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Size = new System.Drawing.Size(110, 23);
            this.Btn_Excluir.TabIndex = 3;
            this.Btn_Excluir.Text = "Excluir Criança";
            this.Btn_Excluir.UseVisualStyleBackColor = true;
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            // 
            // Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 440);
            this.Controls.Add(this.Btn_Excluir);
            this.Controls.Add(this.Btn_Cadastro);
            this.Controls.Add(this.Dgv_Pesquisa);
            this.Controls.Add(this.Txt_Pesquisar);
            this.Name = "Pesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Crianças Amivolta";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Pesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Pesquisar;
        private System.Windows.Forms.DataGridView Dgv_Pesquisa;
        private System.Windows.Forms.Button Btn_Cadastro;
        private System.Windows.Forms.Button Btn_Excluir;
    }
}

