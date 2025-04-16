using AutoTorque.Views;
using System;
using System.Windows.Forms;
using System.Threading;

namespace AutoTorque
{
    public partial class frmCadastrar : Form
    {  
        Thread t1;
        Thread t2;
        Thread t3;
        Thread t4;
        Thread t5;
        private System.Windows.Forms.Timer timer; 
        private ToolStripLabel dateTimeLabel;
        private MenuStrip menuStrip; 

        public frmCadastrar()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeDateTimeDisplay(); // Método para inicializar a data e hora
        }

        private void InitializeDateTimeDisplay()
        {
            // Cria um painel para a faixa vermelha (código hexadecimal #FF0000)
            Panel redPanel = new Panel
            {
                BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000"), // Vermelho
                Dock = DockStyle.Top, // Faz o painel ocupar a parte superior do formulário
                Height = this.Height / 80 // Altura da faixa como um terço do formulário
            };

            // Inicializa MenuStrip e ToolStripLabel
            menuStrip = new MenuStrip
            {
                BackColor = System.Drawing.ColorTranslator.FromHtml("#363636"), 
                ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF") 
            };

            dateTimeLabel = new ToolStripLabel
            {
                ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"), 
                AutoSize = false, // Permite definir largura e altura
                Width = 200 
            };

            // Configura o Timer
            timer = new System.Windows.Forms.Timer
            {
                Interval = 1000 // 1 segundo
            };
            timer.Tick += Timer_Tick;
            timer.Start();

            // Adiciona o ToolStripLabel ao MenuStrip
            menuStrip.Items.Add(dateTimeLabel);

            // Adiciona o MenuStrip ao Formulário
            Controls.Add(redPanel); 
            Controls.Add(menuStrip); 

            // Atualiza a data e hora na inicialização
            UpdateDateTime();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            dateTimeLabel.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            t1 = new Thread(() =>
            {
                frmCadastroCliente cadastroClienteForm = new frmCadastroCliente();

                cadastroClienteForm.StartPosition = FormStartPosition.Manual;
                cadastroClienteForm.Location = new System.Drawing.Point(
                    this.Location.X + (this.Width - cadastroClienteForm.Width) / 2,
                    this.Location.Y + (this.Height - cadastroClienteForm.Height) / 2
                );

                Application.Run(cadastroClienteForm);
            });
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

            this.Close(); 
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            t2 = new Thread(() =>
            {
                frmPrincipal principalForm = new frmPrincipal();

                // Define a posição inicial do novo formulário
                principalForm.StartPosition = FormStartPosition.Manual;
                principalForm.Location = new System.Drawing.Point(
                    this.Location.X + (this.Width - principalForm.Width) / 2,
                    this.Location.Y + (this.Height - principalForm.Height) / 2
                );

                Application.Run(principalForm);
            });
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();

            this.Close(); // Fecha o formulário atual
        }

        private void btnCadastroServico_Click(object sender, EventArgs e)
        {
            t3 = new Thread(() =>
            {
                frmCadastroServico cadastroServicoForm = new frmCadastroServico();

         
                cadastroServicoForm.StartPosition = FormStartPosition.Manual;
                cadastroServicoForm.Location = new System.Drawing.Point(
                    this.Location.X + (this.Width - cadastroServicoForm.Width) / 2,
                    this.Location.Y + (this.Height - cadastroServicoForm.Height) / 2
                );

                Application.Run(cadastroServicoForm);
            });
            t3.SetApartmentState(ApartmentState.STA);
            t3.Start();

            this.Close(); 
        }

        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            t4 = new Thread(() =>
            {
                frmCadastroFuncionario cadastroFuncionarioForm = new frmCadastroFuncionario();

              
                cadastroFuncionarioForm.StartPosition = FormStartPosition.Manual;
                cadastroFuncionarioForm.Location = new System.Drawing.Point(
                    this.Location.X + (this.Width - cadastroFuncionarioForm.Width) / 2,
                    this.Location.Y + (this.Height - cadastroFuncionarioForm.Height) / 2
                );

                Application.Run(cadastroFuncionarioForm);
            });
            t4.SetApartmentState(ApartmentState.STA);
            t4.Start();

            this.Close(); 
        }

        private void btnCadastroVeiculo_Click(object sender, EventArgs e)
        {
            t5 = new Thread(() =>
            {
                frmCadastroVeiculo cadastroVeiculoForm = new frmCadastroVeiculo();

                cadastroVeiculoForm.StartPosition = FormStartPosition.Manual;
                cadastroVeiculoForm.Location = new System.Drawing.Point(
                    this.Location.X + (this.Width - cadastroVeiculoForm.Width) / 2,
                    this.Location.Y + (this.Height - cadastroVeiculoForm.Height) / 2
                );

                Application.Run(cadastroVeiculoForm);
            });
            t5.SetApartmentState(ApartmentState.STA);
            t5.Start();

            this.Close(); 
        }
    }
}