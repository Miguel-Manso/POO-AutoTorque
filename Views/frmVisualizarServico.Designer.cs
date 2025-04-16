namespace AutoTorque.Views
{
    partial class frmVisualizarServico
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizarServico));
            this.btnSair = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtVisDescricao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtVisTroco = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVisValorPago = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVisValorTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVisObservacaoInterna = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVisCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVisdtInicio = new System.Windows.Forms.TextBox();
            this.txtVisdtFim = new System.Windows.Forms.TextBox();
            this.txtVisFuncionario = new System.Windows.Forms.TextBox();
            this.txtVisdtPagamento = new System.Windows.Forms.TextBox();
            this.txtVisParcela = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(26, 405);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 58;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(283, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 29);
            this.label7.TabIndex = 55;
            this.label7.Text = "Visualizar Serviços";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 81;
            this.label13.Text = "Descrição:";
            // 
            // txtVisDescricao
            // 
            this.txtVisDescricao.Location = new System.Drawing.Point(96, 188);
            this.txtVisDescricao.Name = "txtVisDescricao";
            this.txtVisDescricao.ReadOnly = true;
            this.txtVisDescricao.Size = new System.Drawing.Size(105, 20);
            this.txtVisDescricao.TabIndex = 80;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 79;
            this.label12.Text = "Troco:";
            // 
            // txtVisTroco
            // 
            this.txtVisTroco.Location = new System.Drawing.Point(120, 358);
            this.txtVisTroco.Name = "txtVisTroco";
            this.txtVisTroco.ReadOnly = true;
            this.txtVisTroco.Size = new System.Drawing.Size(105, 20);
            this.txtVisTroco.TabIndex = 78;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 77;
            this.label11.Text = "Valor Pago:";
            // 
            // txtVisValorPago
            // 
            this.txtVisValorPago.Location = new System.Drawing.Point(120, 333);
            this.txtVisValorPago.Name = "txtVisValorPago";
            this.txtVisValorPago.ReadOnly = true;
            this.txtVisValorPago.Size = new System.Drawing.Size(105, 20);
            this.txtVisValorPago.TabIndex = 76;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 75;
            this.label10.Text = "Valor Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 73;
            this.label9.Text = "Parcela:";
            // 
            // txtVisValorTotal
            // 
            this.txtVisValorTotal.Location = new System.Drawing.Point(120, 308);
            this.txtVisValorTotal.Name = "txtVisValorTotal";
            this.txtVisValorTotal.ReadOnly = true;
            this.txtVisValorTotal.Size = new System.Drawing.Size(105, 20);
            this.txtVisValorTotal.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Data Pagamento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Pagamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Observação Interna:";
            // 
            // txtVisObservacaoInterna
            // 
            this.txtVisObservacaoInterna.Location = new System.Drawing.Point(252, 258);
            this.txtVisObservacaoInterna.Multiline = true;
            this.txtVisObservacaoInterna.Name = "txtVisObservacaoInterna";
            this.txtVisObservacaoInterna.ReadOnly = true;
            this.txtVisObservacaoInterna.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVisObservacaoInterna.Size = new System.Drawing.Size(528, 116);
            this.txtVisObservacaoInterna.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(230, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Data Fim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Categoria:";
            // 
            // txtVisCategoria
            // 
            this.txtVisCategoria.Location = new System.Drawing.Point(288, 161);
            this.txtVisCategoria.Name = "txtVisCategoria";
            this.txtVisCategoria.ReadOnly = true;
            this.txtVisCategoria.Size = new System.Drawing.Size(105, 20);
            this.txtVisCategoria.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Funcionário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Data Início:";
            // 
            // txtVisdtInicio
            // 
            this.txtVisdtInicio.BackColor = System.Drawing.SystemColors.Control;
            this.txtVisdtInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtVisdtInicio.Location = new System.Drawing.Point(96, 136);
            this.txtVisdtInicio.Multiline = true;
            this.txtVisdtInicio.Name = "txtVisdtInicio";
            this.txtVisdtInicio.ReadOnly = true;
            this.txtVisdtInicio.Size = new System.Drawing.Size(105, 20);
            this.txtVisdtInicio.TabIndex = 82;
            // 
            // txtVisdtFim
            // 
            this.txtVisdtFim.Location = new System.Drawing.Point(288, 135);
            this.txtVisdtFim.Multiline = true;
            this.txtVisdtFim.Name = "txtVisdtFim";
            this.txtVisdtFim.ReadOnly = true;
            this.txtVisdtFim.Size = new System.Drawing.Size(105, 20);
            this.txtVisdtFim.TabIndex = 83;
            // 
            // txtVisFuncionario
            // 
            this.txtVisFuncionario.Location = new System.Drawing.Point(96, 162);
            this.txtVisFuncionario.Name = "txtVisFuncionario";
            this.txtVisFuncionario.ReadOnly = true;
            this.txtVisFuncionario.Size = new System.Drawing.Size(105, 20);
            this.txtVisFuncionario.TabIndex = 84;
            // 
            // txtVisdtPagamento
            // 
            this.txtVisdtPagamento.Location = new System.Drawing.Point(120, 258);
            this.txtVisdtPagamento.Multiline = true;
            this.txtVisdtPagamento.Name = "txtVisdtPagamento";
            this.txtVisdtPagamento.ReadOnly = true;
            this.txtVisdtPagamento.Size = new System.Drawing.Size(105, 20);
            this.txtVisdtPagamento.TabIndex = 85;
            // 
            // txtVisParcela
            // 
            this.txtVisParcela.Location = new System.Drawing.Point(120, 283);
            this.txtVisParcela.Name = "txtVisParcela";
            this.txtVisParcela.ReadOnly = true;
            this.txtVisParcela.Size = new System.Drawing.Size(105, 20);
            this.txtVisParcela.TabIndex = 86;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(521, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 131);
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(26, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 20);
            this.label15.TabIndex = 89;
            this.label15.Text = "Serviço";
            // 
            // frmVisualizarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(808, 449);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVisParcela);
            this.Controls.Add(this.txtVisdtPagamento);
            this.Controls.Add(this.txtVisFuncionario);
            this.Controls.Add(this.txtVisdtFim);
            this.Controls.Add(this.txtVisdtInicio);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtVisDescricao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtVisTroco);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtVisValorPago);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtVisValorTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVisObservacaoInterna);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVisCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVisualizarServico";
            this.Text = "Visualizar de Servico";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtVisDescricao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtVisTroco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVisValorPago;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVisValorTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVisObservacaoInterna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVisCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVisdtInicio;
        private System.Windows.Forms.TextBox txtVisdtFim;
        private System.Windows.Forms.TextBox txtVisFuncionario;
        private System.Windows.Forms.TextBox txtVisdtPagamento;
        private System.Windows.Forms.TextBox txtVisParcela;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
    }
}