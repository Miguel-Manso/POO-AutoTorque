using AutoTorque.Controllers;
using AutoTorque.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTorque.Views
{
    public partial class frmCadastroFuncionario : Form
    {
        Thread t1;
        FuncionarioController funcionarioController = new FuncionarioController();
        FuncionarioCollection funcionarioCollection = new FuncionarioCollection();
        private System.Windows.Forms.Timer timer; 
        private ToolStripLabel dateTimeLabel; 
        private MenuStrip menuStrip; 
        public frmCadastroFuncionario()
        {
            funcionarioController = new FuncionarioController();
            funcionarioCollection = new FuncionarioCollection();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            FuncionarioLoad();
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
            // Validação dos campos
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCargo.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text) ||
                string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Interrompe a execução se algum campo estiver vazio
            }

            // Verifica se o salário é um número válido
            if (!decimal.TryParse(txtSalario.Text, out decimal salario))
            {
                MessageBox.Show("O salário deve ser um número válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Interrompe a execução se o salário não for válido
            }

            // Se todas as validações passarem, prossegue com a inserção
            Funcionario funcionario = new Funcionario
            {
                Nome = txtNome.Text,
                Cargo = txtCargo.Text,
                Salario = salario,
                Endereco = txtEndereco.Text
            };

            funcionarioController.Inserir(funcionario);
            funcionarioCollection.Add(funcionario);

            AtualizarLista();

            // Limpa os campos de texto
            txtNome.Clear();
            txtCargo.Clear();
            txtEndereco.Clear();
            txtSalario.Clear();
        }

        private void FuncionarioLoad()
        {
            List<Funcionario> funcionarios = funcionarioController.carregarFuncionario();

            funcionarioCollection.AddRange(funcionarios);

            AtualizarLista();
        }

        private void AtualizarLista()
        {
            lstFuncionario.DataSource = null;
            lstFuncionario.DataSource = funcionarioCollection.Listar();
            lstFuncionario.DisplayMember = "NomeCargoSalario";
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
            Funcionario funcionarioSelecionado = lstFuncionario.SelectedItem as Funcionario;

            if (funcionarioSelecionado != null)
            {
                frmVisualizarFuncionario frm = new frmVisualizarFuncionario(funcionarioSelecionado);
                frm.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Por favor, selecione um funcionário.");
            }
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            // Remove qualquer caractere que não seja dígito
            string salarioInput = txtSalario.Text;
            string salarioNumeros = new string(salarioInput.Where(char.IsDigit).ToArray());

            // Atualiza o campo de texto com os números válidos
            txtSalario.Text = salarioNumeros;

            // Define o cursor na posição correta
            txtSalario.SelectionStart = txtSalario.Text.Length;
        }
        
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            // Verifica se há um funcionário selecionado na lista
            Funcionario funcionarioSelecionado = lstFuncionario.SelectedItem as Funcionario;

            if (funcionarioSelecionado != null)
            {
                // Solicita confirmação do usuário
                var resultado = MessageBox.Show(
                    "Tem certeza que deseja deletar este funcionário?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Se o usuário confirmar a deleção
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Chama o método Apagar do FuncionarioController
                        funcionarioController.Apagar(funcionarioSelecionado.IdFuncionario);

                        // Remove o funcionário da coleção local
                        funcionarioCollection.Remove(funcionarioSelecionado);

                        // Atualiza a lista exibida
                        AtualizarLista();

                        MessageBox.Show("Funcionário deletado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao deletar funcionário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Caso nenhum funcionário esteja selecionado
                MessageBox.Show("Por favor, selecione um funcionário para deletar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Funcionario funcionarioSelecionado = lstFuncionario.SelectedItem as Funcionario;

            if (funcionarioSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um funcionário para alterar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCargo.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text) ||
                string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            funcionarioSelecionado.Nome = txtNome.Text;
            funcionarioSelecionado.Cargo = txtCargo.Text;
            funcionarioSelecionado.Salario = Convert.ToDecimal(txtSalario.Text);
            funcionarioSelecionado.Endereco = txtEndereco.Text;

            funcionarioController.Alterar(funcionarioSelecionado);

            AtualizarLista();

            txtNome.Clear();
            txtCargo.Clear();
            txtSalario.Clear();
            txtEndereco.Clear();
        }
    }
}
