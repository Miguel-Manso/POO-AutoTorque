using AutoTorque.Controllers;
using AutoTorque.Models;
using System;
using System.Windows.Forms;

namespace AutoTorque.Views
{
    public partial class frmVisualizarServico : Form
    {
        ServicoController servicoController = new ServicoController();
        ServicoCollection servicoCollection = new ServicoCollection();
        PagamentoController pagamentoController = new PagamentoController();
        PagamentoCollection pagamentoCollection = new PagamentoCollection();
        FuncionarioController FuncionarioController = new FuncionarioController();
        private System.Windows.Forms.Timer timer; 
        private ToolStripLabel dateTimeLabel; 
        private MenuStrip menuStrip; // 

        public frmVisualizarServico(Servico servico, Pagamento pagamento)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeDateTimeDisplay(); 
            txtVisdtInicio.Text = servico.DtInicio.ToString();
            txtVisdtFim.Text = servico.DtFim.ToString();
            txtVisCategoria.Text = servico.Categoria;
            txtVisDescricao.Text = servico.Descricao;
            txtVisFuncionario.Text = servico.Funcionario.Nome;

            txtVisdtPagamento.Text = pagamento.DtPagamento.ToString();
            txtVisParcela.Text = pagamento.Parcela.ToString();
            txtVisValorTotal.Text = pagamento.VlrTotal.ToString();
            txtVisValorPago.Text = pagamento.VlrPago.ToString();
            txtVisTroco.Text = pagamento.Troco.ToString();
            txtVisObservacaoInterna.Text = pagamento.ObservacaoInterna;
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

            // Inicializa MenuStrip e ToolStripLabel
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
