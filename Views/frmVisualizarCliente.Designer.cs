﻿namespace AutoTorque.Views
{
    partial class frmVisualizarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizarCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVisNome = new System.Windows.Forms.TextBox();
            this.txtVisCpf = new System.Windows.Forms.TextBox();
            this.txtVisEndereco = new System.Windows.Forms.TextBox();
            this.txtVisTelefone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Visualizar Clientes";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(12, 462);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 42;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nome:";
            // 
            // txtVisNome
            // 
            this.txtVisNome.Location = new System.Drawing.Point(109, 338);
            this.txtVisNome.Name = "txtVisNome";
            this.txtVisNome.ReadOnly = true;
            this.txtVisNome.Size = new System.Drawing.Size(633, 20);
            this.txtVisNome.TabIndex = 46;
            // 
            // txtVisCpf
            // 
            this.txtVisCpf.Location = new System.Drawing.Point(109, 364);
            this.txtVisCpf.Name = "txtVisCpf";
            this.txtVisCpf.ReadOnly = true;
            this.txtVisCpf.Size = new System.Drawing.Size(633, 20);
            this.txtVisCpf.TabIndex = 47;
            // 
            // txtVisEndereco
            // 
            this.txtVisEndereco.Location = new System.Drawing.Point(109, 390);
            this.txtVisEndereco.Name = "txtVisEndereco";
            this.txtVisEndereco.ReadOnly = true;
            this.txtVisEndereco.Size = new System.Drawing.Size(633, 20);
            this.txtVisEndereco.TabIndex = 48;
            // 
            // txtVisTelefone
            // 
            this.txtVisTelefone.Location = new System.Drawing.Point(109, 416);
            this.txtVisTelefone.Name = "txtVisTelefone";
            this.txtVisTelefone.ReadOnly = true;
            this.txtVisTelefone.Size = new System.Drawing.Size(633, 20);
            this.txtVisTelefone.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Telefone:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoTorque.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(194, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 297);
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // frmVisualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVisTelefone);
            this.Controls.Add(this.txtVisEndereco);
            this.Controls.Add(this.txtVisCpf);
            this.Controls.Add(this.txtVisNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVisualizarCliente";
            this.Text = "Visualização de Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVisNome;
        private System.Windows.Forms.TextBox txtVisCpf;
        private System.Windows.Forms.TextBox txtVisEndereco;
        private System.Windows.Forms.TextBox txtVisTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}