using AutoTorque.Controllers;
using AutoTorque.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace AutoTorque.Views
{
    public partial class frmCadastroServico : Form
    {
        Thread t1;
        private FuncionarioController funcionarioController;
        private ServicoController servicoController;
        private ServicoCollection servicoCollection;
        private PagamentoController pagamentoController;
        private PagamentoCollection pagamentoCollection;
        private System.Windows.Forms.Timer timer;
        private ToolStripLabel dateTimeLabel; 
        private MenuStrip menuStrip; 

        public frmCadastroServico()
        {
            funcionarioController = new FuncionarioController();
            servicoController = new ServicoController();
            servicoCollection = new ServicoCollection();
            pagamentoController = new PagamentoController();
            pagamentoCollection = new PagamentoCollection();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            funcionarioLoad();
            servicoLoad();
            pagamentoLoad();
            InitializeDateTimeDisplay(); 
        }
        private void InitializeDateTimeDisplay()
        {
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Criação do objeto Pagamento
            Pagamento pagamento = new Pagamento();

            // Validação dos campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtDescricao.Text) ||
                string.IsNullOrWhiteSpace(dtpInicio.Text) ||
                string.IsNullOrWhiteSpace(dtpFim.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                cmbFuncionario.SelectedItem == null ||
                string.IsNullOrWhiteSpace(dtpPagamento.Text) ||
                string.IsNullOrWhiteSpace(cmbParcela.Text) ||
                string.IsNullOrWhiteSpace(txtValorTotal.Text) ||
                string.IsNullOrWhiteSpace(txtValorPago.Text) ||
                string.IsNullOrWhiteSpace(txtTroco.Text))
            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preenchidos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Interrompe a execução se algum campo obrigatório estiver vazio
            }

            // Validação dos valores numéricos
            if (!decimal.TryParse(txtValorTotal.Text, out decimal valorTotal))
            {
                MessageBox.Show("O valor total deve ser um número válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtValorPago.Text, out decimal valorPago))
            {
                MessageBox.Show("O valor pago deve ser um número válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtTroco.Text, out decimal troco))
            {
                MessageBox.Show("O troco deve ser um número válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validação de datas
            if (!DateTime.TryParse(dtpInicio.Text, out DateTime dtInicio) || !DateTime.TryParse(dtpFim.Text, out DateTime dtFim))
            {
                MessageBox.Show("As datas devem ser válidas.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtInicio > dtFim)
            {
                MessageBox.Show("A data de início deve ser anterior à data de fim.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Criação do objeto Servico
            Servico servico = new Servico
            {
                Descricao = txtDescricao.Text,
                DtInicio = dtInicio,
                DtFim = dtFim,
                Categoria = txtCategoria.Text,
                Funcionario = (Funcionario)cmbFuncionario.SelectedItem,
                Pagamento = pagamento
            };

            // Preenchendo os dados do pagamento
            pagamento.DtPagamento = Convert.ToDateTime(dtpPagamento.Text);
            pagamento.Parcela = Convert.ToInt32(cmbParcela.Text);
            pagamento.VlrTotal = valorTotal;
            pagamento.VlrPago = valorPago;
            pagamento.Troco = troco;
            pagamento.ObservacaoInterna = txtObservacaoInterna.Text; // Este campo pode ser vazio

            // Inserção dos objetos nas coleções
            servicoController.Inserir(servico);
            servicoCollection.Add(servico);
            pagamentoController.Inserir(pagamento);
            pagamentoCollection.Add(pagamento);

            AtualizarLista();

            // Limpeza dos campos
            txtCategoria.Clear();
            txtDescricao.Clear();
            txtTroco.Clear();
            txtValorTotal.Clear();
            txtValorPago.Clear();
            txtObservacaoInterna.Clear();
        }
        private void AtualizarLista()
        {
            lstServico.DataSource = null;
            lstServico.DataSource = servicoCollection.Listar();
            lstServico.DisplayMember = "DtInicioCategoriaVlrTotalParcela";
        }

        private void servicoLoad()
        {
            List<Servico> servicos = servicoController.carregarServico();

            servicoCollection.AddRange(servicos);

            AtualizarLista();
        }

        private void pagamentoLoad()
        {
            List<Pagamento> pagamentos = pagamentoController.carregarPagamento();

            pagamentoCollection.AddRange(pagamentos);

            AtualizarLista();
        }

       
        private void funcionarioLoad()
        {
            FuncionarioCollection funcionarios = funcionarioController.carregarFuncionario();

            cmbFuncionario.DataSource = funcionarios;
            cmbFuncionario.DisplayMember = "Nome";
            cmbFuncionario.ValueMember = "IdFuncionario";
        }

        
        private void btnSair_Click(object sender, EventArgs e)
        {
           
            t1 = new Thread(() =>
            {
                frmCadastrar cadastrarForm = new frmCadastrar();

               
                cadastrarForm.StartPosition = FormStartPosition.Manual; 
                cadastrarForm.Location = new System.Drawing.Point(
                    this.Location.X + (this.Width - cadastrarForm.Width) / 2, 
                    this.Location.Y + (this.Height - cadastrarForm.Height) / 2 
                );

                Application.Run(cadastrarForm); 
            });

            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

            this.Close(); 
        }

        private void btnVisRegistros_Click(object sender, EventArgs e)
        {
            Servico servicoSelecionado = lstServico.SelectedItem as Servico;

            if (servicoSelecionado != null)
            {
                Pagamento pagamentoRelacionado = servicoSelecionado.Pagamento;

                frmVisualizarServico frm = new frmVisualizarServico(servicoSelecionado, pagamentoRelacionado);
                frm.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Por favor, selecione um Serviço.");
            }
        }

        private void Cadastro(object obj)
        {
            Application.Run(new frmCadastrar());
        }

        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {
            // Remove qualquer caractere que não seja dígito ou ponto decimal
            string input = txtValorTotal.Text;
            string numerosValidos = new string(input.Where(c => char.IsDigit(c) || c == '.').ToArray());

            // Atualiza o campo de texto com os números válidos
            txtValorTotal.Text = numerosValidos;

            // Define o cursor na posição correta
            txtValorTotal.SelectionStart = txtValorTotal.Text.Length;
        }

        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {
            // Remove qualquer caractere que não seja dígito ou ponto decimal
            string input = txtValorPago.Text;
            string numerosValidos = new string(input.Where(c => char.IsDigit(c) || c == '.').ToArray());

            // Atualiza o campo de texto com os números válidos
            txtValorPago.Text = numerosValidos;

            // Define o cursor na posição correta
            txtValorPago.SelectionStart = txtValorPago.Text.Length;
        }

        private void txtTroco_TextChanged(object sender, EventArgs e)
        {
            // Remove qualquer caractere que não seja dígito ou ponto decimal
            string input = txtTroco.Text;
            string numerosValidos = new string(input.Where(c => char.IsDigit(c) || c == '.').ToArray());

            // Atualiza o campo de texto com os números válidos
            txtTroco.Text = numerosValidos;

            // Define o cursor na posição correta
            txtTroco.SelectionStart = txtTroco.Text.Length;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            // Verifica se um serviço está selecionado na lista
            Servico servicoSelecionado = lstServico.SelectedItem as Servico;

            if (servicoSelecionado != null)
            {
                // Solicita confirmação do usuário
                var resultado = MessageBox.Show(
                    "Tem certeza que deseja deletar este serviço?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Se o usuário confirmar a deleção
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Chama o método para deletar no ServicoController
                        servicoController.Apagar(servicoSelecionado.IdServico);

                        // Remove o serviço da coleção local
                        servicoCollection.Remove(servicoSelecionado);

                        // Atualiza a lista exibida
                        AtualizarLista();

                        MessageBox.Show("Serviço deletado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao deletar serviço: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Caso nenhum serviço esteja selecionado
                MessageBox.Show("Por favor, selecione um serviço para deletar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Servico servicoSelecionado = lstServico.SelectedItem as Servico;
            Pagamento pagamento = new Pagamento();
            Funcionario funcionarioSelecionado = (Funcionario)cmbFuncionario.SelectedItem;

            if (servicoSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um serviço para alterar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescricao.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtValorTotal.Text) ||
                string.IsNullOrWhiteSpace(txtValorPago.Text) ||
                string.IsNullOrWhiteSpace(txtTroco.Text) ||
                string.IsNullOrWhiteSpace(cmbParcela.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtObservacaoInterna.Text))
            {
                servicoSelecionado.Pagamento.ObservacaoInterna = txtObservacaoInterna.Text;
            }

            servicoSelecionado.Descricao = txtDescricao.Text;
            servicoSelecionado.Categoria = txtCategoria.Text;
            servicoSelecionado.DtInicio = Convert.ToDateTime(dtpInicio.Text);
            servicoSelecionado.DtFim = Convert.ToDateTime(dtpFim.Text);
            servicoSelecionado.Funcionario = funcionarioSelecionado;

            servicoSelecionado.Pagamento.DtPagamento = Convert.ToDateTime(dtpPagamento.Text);
            servicoSelecionado.Pagamento.Parcela = Convert.ToInt32(cmbParcela.Text);
            servicoSelecionado.Pagamento.VlrTotal = Convert.ToDecimal(txtValorTotal.Text);
            servicoSelecionado.Pagamento.VlrPago = Convert.ToDecimal(txtValorPago.Text);
            servicoSelecionado.Pagamento.Troco = Convert.ToDecimal(txtTroco.Text);

            servicoController.Alterar(servicoSelecionado);

            AtualizarLista();

            txtDescricao.Clear();
            txtCategoria.Clear();
            txtValorPago.Clear();
            txtValorTotal.Clear();
            txtTroco.Clear();
            txtObservacaoInterna.Clear();
        }
    }
}
