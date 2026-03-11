namespace Pizzaria
{
    partial class frm_fundo
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
            this.grp_Entrada = new System.Windows.Forms.GroupBox();
            this.txt_QtdPizza = new System.Windows.Forms.TextBox();
            this.txt_Massa = new System.Windows.Forms.TextBox();
            this.txt_Molho = new System.Windows.Forms.TextBox();
            this.txt_Queijo = new System.Windows.Forms.TextBox();
            this.lbl_QtdPizza = new System.Windows.Forms.Label();
            this.lbl_Massa = new System.Windows.Forms.Label();
            this.lbl_Molho = new System.Windows.Forms.Label();
            this.lbl_Queijo = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grp_Botoes = new System.Windows.Forms.GroupBox();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.grp_Saida = new System.Windows.Forms.GroupBox();
            this.lbl_Resul_QtdMolho = new System.Windows.Forms.Label();
            this.lbl_Resul_QtdQueijo = new System.Windows.Forms.Label();
            this.lbl_Result_CustProd = new System.Windows.Forms.Label();
            this.lbl_Resul_QtdMassa = new System.Windows.Forms.Label();
            this.lbl_CustoTotal = new System.Windows.Forms.Label();
            this.lbl_QtdTotal = new System.Windows.Forms.Label();
            this.lbl_qtdMassa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_qtdQueijo = new System.Windows.Forms.Label();
            this.grp_Entrada.SuspendLayout();
            this.grp_Botoes.SuspendLayout();
            this.grp_Saida.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Entrada
            // 
            this.grp_Entrada.Controls.Add(this.txt_QtdPizza);
            this.grp_Entrada.Controls.Add(this.txt_Massa);
            this.grp_Entrada.Controls.Add(this.txt_Molho);
            this.grp_Entrada.Controls.Add(this.txt_Queijo);
            this.grp_Entrada.Controls.Add(this.lbl_QtdPizza);
            this.grp_Entrada.Controls.Add(this.lbl_Massa);
            this.grp_Entrada.Controls.Add(this.lbl_Molho);
            this.grp_Entrada.Controls.Add(this.lbl_Queijo);
            this.grp_Entrada.Location = new System.Drawing.Point(12, 12);
            this.grp_Entrada.Name = "grp_Entrada";
            this.grp_Entrada.Size = new System.Drawing.Size(459, 286);
            this.grp_Entrada.TabIndex = 0;
            this.grp_Entrada.TabStop = false;
            this.grp_Entrada.Text = "Entrada";
            // 
            // txt_QtdPizza
            // 
            this.txt_QtdPizza.Location = new System.Drawing.Point(347, 219);
            this.txt_QtdPizza.Name = "txt_QtdPizza";
            this.txt_QtdPizza.Size = new System.Drawing.Size(100, 20);
            this.txt_QtdPizza.TabIndex = 7;
            // 
            // txt_Massa
            // 
            this.txt_Massa.Location = new System.Drawing.Point(214, 158);
            this.txt_Massa.Name = "txt_Massa";
            this.txt_Massa.Size = new System.Drawing.Size(100, 20);
            this.txt_Massa.TabIndex = 6;
            // 
            // txt_Molho
            // 
            this.txt_Molho.Location = new System.Drawing.Point(214, 98);
            this.txt_Molho.Name = "txt_Molho";
            this.txt_Molho.Size = new System.Drawing.Size(100, 20);
            this.txt_Molho.TabIndex = 5;
            // 
            // txt_Queijo
            // 
            this.txt_Queijo.Location = new System.Drawing.Point(214, 45);
            this.txt_Queijo.Name = "txt_Queijo";
            this.txt_Queijo.Size = new System.Drawing.Size(100, 20);
            this.txt_Queijo.TabIndex = 4;
            // 
            // lbl_QtdPizza
            // 
            this.lbl_QtdPizza.AutoSize = true;
            this.lbl_QtdPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QtdPizza.Location = new System.Drawing.Point(6, 219);
            this.lbl_QtdPizza.Name = "lbl_QtdPizza";
            this.lbl_QtdPizza.Size = new System.Drawing.Size(335, 20);
            this.lbl_QtdPizza.TabIndex = 3;
            this.lbl_QtdPizza.Text = "Quantidade de pizzas produzidas no dia:";
            // 
            // lbl_Massa
            // 
            this.lbl_Massa.AutoSize = true;
            this.lbl_Massa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Massa.Location = new System.Drawing.Point(6, 158);
            this.lbl_Massa.Name = "lbl_Massa";
            this.lbl_Massa.Size = new System.Drawing.Size(203, 20);
            this.lbl_Massa.TabIndex = 2;
            this.lbl_Massa.Text = "Valor unitário do massa:";
            // 
            // lbl_Molho
            // 
            this.lbl_Molho.AutoSize = true;
            this.lbl_Molho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Molho.Location = new System.Drawing.Point(6, 99);
            this.lbl_Molho.Name = "lbl_Molho";
            this.lbl_Molho.Size = new System.Drawing.Size(202, 20);
            this.lbl_Molho.TabIndex = 1;
            this.lbl_Molho.Text = "Valor do quilo do molho:";
            // 
            // lbl_Queijo
            // 
            this.lbl_Queijo.AutoSize = true;
            this.lbl_Queijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Queijo.Location = new System.Drawing.Point(6, 43);
            this.lbl_Queijo.Name = "lbl_Queijo";
            this.lbl_Queijo.Size = new System.Drawing.Size(202, 20);
            this.lbl_Queijo.TabIndex = 0;
            this.lbl_Queijo.Text = "Valor do quilo do queijo:";
            // 
            // grp_Botoes
            // 
            this.grp_Botoes.Controls.Add(this.lbl_qtdQueijo);
            this.grp_Botoes.Controls.Add(this.label1);
            this.grp_Botoes.Controls.Add(this.lbl_qtdMassa);
            this.grp_Botoes.Controls.Add(this.lbl_Result_CustProd);
            this.grp_Botoes.Controls.Add(this.lbl_CustoTotal);
            this.grp_Botoes.Controls.Add(this.lbl_Resul_QtdMolho);
            this.grp_Botoes.Controls.Add(this.lbl_Resul_QtdQueijo);
            this.grp_Botoes.Controls.Add(this.lbl_QtdTotal);
            this.grp_Botoes.Controls.Add(this.lbl_Resul_QtdMassa);
            this.grp_Botoes.Location = new System.Drawing.Point(482, 12);
            this.grp_Botoes.Name = "grp_Botoes";
            this.grp_Botoes.Size = new System.Drawing.Size(306, 286);
            this.grp_Botoes.TabIndex = 1;
            this.grp_Botoes.TabStop = false;
            this.grp_Botoes.Text = "Saída";
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.Image = global::Pizzaria.Properties.Resources.fechar;
            this.btn_Fechar.Location = new System.Drawing.Point(352, 19);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(165, 99);
            this.btn_Fechar.TabIndex = 2;
            this.btn_Fechar.Text = "Fechar Aplicativo";
            this.btn_Fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Image = global::Pizzaria.Properties.Resources.calculator;
            this.btn_Calcular.Location = new System.Drawing.Point(10, 19);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(165, 99);
            this.btn_Calcular.TabIndex = 0;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.Image = global::Pizzaria.Properties.Resources.clean;
            this.btn_Limpar.Location = new System.Drawing.Point(181, 19);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(165, 99);
            this.btn_Limpar.TabIndex = 1;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // grp_Saida
            // 
            this.grp_Saida.Controls.Add(this.btn_Fechar);
            this.grp_Saida.Controls.Add(this.btn_Calcular);
            this.grp_Saida.Controls.Add(this.btn_Limpar);
            this.grp_Saida.Location = new System.Drawing.Point(144, 304);
            this.grp_Saida.Name = "grp_Saida";
            this.grp_Saida.Size = new System.Drawing.Size(529, 134);
            this.grp_Saida.TabIndex = 2;
            this.grp_Saida.TabStop = false;
            this.grp_Saida.Text = "Botões";
            // 
            // lbl_Resul_QtdMolho
            // 
            this.lbl_Resul_QtdMolho.AutoSize = true;
            this.lbl_Resul_QtdMolho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resul_QtdMolho.Location = new System.Drawing.Point(174, 133);
            this.lbl_Resul_QtdMolho.Name = "lbl_Resul_QtdMolho";
            this.lbl_Resul_QtdMolho.Size = new System.Drawing.Size(29, 20);
            this.lbl_Resul_QtdMolho.TabIndex = 6;
            this.lbl_Resul_QtdMolho.Text = "__";
            // 
            // lbl_Resul_QtdQueijo
            // 
            this.lbl_Resul_QtdQueijo.AutoSize = true;
            this.lbl_Resul_QtdQueijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resul_QtdQueijo.Location = new System.Drawing.Point(174, 105);
            this.lbl_Resul_QtdQueijo.Name = "lbl_Resul_QtdQueijo";
            this.lbl_Resul_QtdQueijo.Size = new System.Drawing.Size(29, 20);
            this.lbl_Resul_QtdQueijo.TabIndex = 5;
            this.lbl_Resul_QtdQueijo.Text = "__";
            // 
            // lbl_Result_CustProd
            // 
            this.lbl_Result_CustProd.AutoSize = true;
            this.lbl_Result_CustProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Result_CustProd.Location = new System.Drawing.Point(210, 173);
            this.lbl_Result_CustProd.Name = "lbl_Result_CustProd";
            this.lbl_Result_CustProd.Size = new System.Drawing.Size(29, 20);
            this.lbl_Result_CustProd.TabIndex = 4;
            this.lbl_Result_CustProd.Text = "__";
            this.lbl_Result_CustProd.Click += new System.EventHandler(this.lbl_Result_CustProd_Click);
            // 
            // lbl_Resul_QtdMassa
            // 
            this.lbl_Resul_QtdMassa.AutoSize = true;
            this.lbl_Resul_QtdMassa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resul_QtdMassa.Location = new System.Drawing.Point(174, 76);
            this.lbl_Resul_QtdMassa.Name = "lbl_Resul_QtdMassa";
            this.lbl_Resul_QtdMassa.Size = new System.Drawing.Size(29, 20);
            this.lbl_Resul_QtdMassa.TabIndex = 3;
            this.lbl_Resul_QtdMassa.Text = "__";
            // 
            // lbl_CustoTotal
            // 
            this.lbl_CustoTotal.AutoSize = true;
            this.lbl_CustoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustoTotal.Location = new System.Drawing.Point(6, 173);
            this.lbl_CustoTotal.Name = "lbl_CustoTotal";
            this.lbl_CustoTotal.Size = new System.Drawing.Size(207, 20);
            this.lbl_CustoTotal.TabIndex = 1;
            this.lbl_CustoTotal.Text = "Custo total da produção:";
            // 
            // lbl_QtdTotal
            // 
            this.lbl_QtdTotal.AutoSize = true;
            this.lbl_QtdTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QtdTotal.Location = new System.Drawing.Point(6, 43);
            this.lbl_QtdTotal.Name = "lbl_QtdTotal";
            this.lbl_QtdTotal.Size = new System.Drawing.Size(282, 20);
            this.lbl_QtdTotal.TabIndex = 0;
            this.lbl_QtdTotal.Text = "Quantidade total de ingredientes: ";
            // 
            // lbl_qtdMassa
            // 
            this.lbl_qtdMassa.AutoSize = true;
            this.lbl_qtdMassa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtdMassa.Location = new System.Drawing.Point(9, 80);
            this.lbl_qtdMassa.Name = "lbl_qtdMassa";
            this.lbl_qtdMassa.Size = new System.Drawing.Size(163, 16);
            this.lbl_qtdMassa.TabIndex = 7;
            this.lbl_qtdMassa.Text = "Quantidade de Massa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quantidade de Molho:";
            // 
            // lbl_qtdQueijo
            // 
            this.lbl_qtdQueijo.AutoSize = true;
            this.lbl_qtdQueijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtdQueijo.Location = new System.Drawing.Point(9, 109);
            this.lbl_qtdQueijo.Name = "lbl_qtdQueijo";
            this.lbl_qtdQueijo.Size = new System.Drawing.Size(162, 16);
            this.lbl_qtdQueijo.TabIndex = 9;
            this.lbl_qtdQueijo.Text = "Quantidade de Queijo:";
            // 
            // frm_fundo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grp_Saida);
            this.Controls.Add(this.grp_Botoes);
            this.Controls.Add(this.grp_Entrada);
            this.Name = "frm_fundo";
            this.Text = "Form1";
            this.grp_Entrada.ResumeLayout(false);
            this.grp_Entrada.PerformLayout();
            this.grp_Botoes.ResumeLayout(false);
            this.grp_Botoes.PerformLayout();
            this.grp_Saida.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Entrada;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grp_Botoes;
        private System.Windows.Forms.GroupBox grp_Saida;
        private System.Windows.Forms.Label lbl_Queijo;
        private System.Windows.Forms.Label lbl_QtdPizza;
        private System.Windows.Forms.Label lbl_Massa;
        private System.Windows.Forms.Label lbl_Molho;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.TextBox txt_QtdPizza;
        private System.Windows.Forms.TextBox txt_Massa;
        private System.Windows.Forms.TextBox txt_Molho;
        private System.Windows.Forms.TextBox txt_Queijo;
        private System.Windows.Forms.Label lbl_QtdTotal;
        private System.Windows.Forms.Label lbl_CustoTotal;
        private System.Windows.Forms.Label lbl_Resul_QtdMassa;
        private System.Windows.Forms.Label lbl_Result_CustProd;
        private System.Windows.Forms.Label lbl_Resul_QtdMolho;
        private System.Windows.Forms.Label lbl_Resul_QtdQueijo;
        private System.Windows.Forms.Label lbl_qtdQueijo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_qtdMassa;
    }
}

