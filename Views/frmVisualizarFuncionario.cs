using AutoTorque.Controllers;
using AutoTorque.Models;
using System;
using System.Threading;
using System.Windows.Forms;

namespace AutoTorque.Views
{
    public partial class frmVisualizarFuncionario : Form
    {
        ClienteController clienteController = new ClienteController();
        ClienteCollection clienteCollection = new ClienteCollection();
        private System.Windows.Forms.Timer timer; 
        private ToolStripLabel dateTimeLabel; 
        private MenuStrip menuStrip; 

        public frmVisualizarFuncionario(Funcionario funcionario)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            txtVisNome.Text = funcionario.Nome;
            txtVisCargo.Text = funcionario.Cargo;
            txtVisSalario.Text = funcionario.Salario.ToString();
            txtVisEndereco.Text = funcionario.Endereco;
            InitializeDateTimeDisplay(); 
        }

        private void InitializeDateTimeDisplay()
        {
            // Cria um painel para a faixa vermelha (código hexadecimal #FF0000)
            Panel redPanel = new Panel
            {
                BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000"), 
                Dock = DockStyle.Top, 
                Height = this.Height / 80 
            };
            
            menuStrip = new MenuStrip
            {
                BackColor = System.Drawing.ColorTranslator.FromHtml("#363636"), 
                ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF") 
            };

            dateTimeLabel = new ToolStripLabel
            {
                ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"), 
                AutoSize = false, 
                Width = 200 
            };
            
            timer = new System.Windows.Forms.Timer
            {
                Interval = 1000 
            };
            timer.Tick += Timer_Tick;
            timer.Start();

            menuStrip.Items.Add(dateTimeLabel);
            
            Controls.Add(redPanel); 
            Controls.Add(menuStrip); 
            
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
        private void btnSair_Click(object sender, EventArgs e)
        {

            this.Close(); 
        }
    }
}
