﻿using Aprendendo_MVC;
using Library_Project.controle;
using Library_Project.modelo;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Minha_Parte_Biblio
{
    public partial class FrmVerReserva : Form
    {
        //PROBLEMA COM REFAZER RESERVA - DATA TIME

        ClConectection conexao = new ClConectection(); // responsavel pela conexao com a dt
        Model_Livro Model_Livro = new Model_Livro(); // responsavel por importar info dos livros
        ModeloReservas Model_Reservas = new ModeloReservas(); // resposavel por importar info das reservas

        ControleLivro Controle_Livro = new ControleLivro();
        ControleReservas Controle_Reserv = new ControleReservas();
        DataTable data = new DataTable();
        int index = 0;
        int codigo1 = 0;
        string codi = "";


        public FrmVerReserva(Model_Livro livro, ModeloReservas reservas)
        {
            codigo1 = reservas.CD_Reservas;
            codi = livro.CD_Livro;
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

            int exclude = conexao.excluir(0, $"DELETE FROM Table_reservas WHERE CD_Reservas = {codigo1} ", "@CD_Resevas");
            if (exclude > 0)
            {
                MessageBox.Show("Reserva Excluída");

                data = conexao.obterdados("SELECT Table_Reservas.CD_Reservas, Table_Livro.Nome_Livro, Table_reservas.DT_reserva, Table_reservas.DT_previsao_devolucao FROM Table_reservas INNER JOIN Table_Livro ON Table_Reservas.CFK_Livro = Table_Livro.Order_Livro");
                dataGridView.DataSource = data;
            }
            else
            {
                MessageBox.Show("Nenhuma reserva foi encontrada para excluir.");
            }
        }

        private void FrmVerReserva_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtendo os dados da consulta
                data = conexao.obterdados("SELECT Table_Reservas.CD_Reservas, Table_Livro.Nome_Livro, Table_reservas.DT_reserva, Table_reservas.DT_previsao_devolucao FROM Table_reservas INNER JOIN Table_Livro ON Table_Reservas.CFK_Livro = Table_Livro.Order_Livro");

                // Definindo a fonte de dados do DataGridView
                dataGridView.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }

            StyleDataGridView();
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            DataGridView dvg = (DataGridView)sender;

            // Verifica se o DataGridView possui dados e se a linha selecionada é válida
            if (dvg.Rows.Count > 0 && dvg.CurrentCell.RowIndex >= 0)
            {
                index = dvg.CurrentCell.RowIndex;
                DataGridViewRow row = dvg.Rows[index];

                // Acessando os valores das células pelo índice da coluna
                codigo1 = Convert.ToInt32(row.Cells[0].Value.ToString()); // CD_Reservas
                                                                          // Você pode acessar outros valores assim:
                string nomeLivro = row.Cells[1].Value.ToString(); // Nome_Livro
                DateTime dtReserva = Convert.ToDateTime(row.Cells[2].Value); // DT_reserva
                DateTime dtPrevisaoDevolucao = Convert.ToDateTime(row.Cells[3].Value); // DT_previsao_devolucao
                LbNome_Obra.Text = nomeLivro;
                TimeSpan Diferenca 
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        void StyleDataGridView()
        {
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.RowHeadersVisible = false;
            //dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(9, 90, 162);
            //dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 207, 0);
            dataGridView.ForeColor = Color.Black;
            //dataGridView.BackgroundColor = Color.FromArgb(122, 193, 255); 
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            //dataGridView.EnableHeadersVisualStyles = false;
            //dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            //dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(39, 101, 155);
            //dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void BntRefazer_Click(object sender, EventArgs e)
        {
            
           


            // Obtendo a data atual
            DateTime hoje = DateTime.Now;

            // Adicionando 28 dias
            DateTime dataFutura = hoje.AddDays(28);

            // Formatando a data no formato desejado (AAAA-MM-DD)
            string dataFuturaFormatada = dataFutura.ToString("yyyy-MM-dd HH:mm:ss");

          
            

            string SQL_Update = "UPDATE Table_Reservas set DT_previsao_devolucao = @devolucao_data where CD_Reservas = @datagridIndex";
            string[] campos = {"@devolucao_data", "@datagridIndex"};

            bool Resultado = false;

            int indexROW_Current = (int)dataGridView.CurrentCell.RowIndex;
            indexROW_Current ++;

            //monto o vetor com os valores do formulario
            string[] valores = { dataFuturaFormatada, indexROW_Current.ToString()};
            if (conexao.cadastrar(0, campos, valores, SQL_Update, "@CD_Reservas") >= 1)
            {
                Resultado = true;
            } else
            {
                Resultado = false;
            }


            if(Resultado == true)
            {
                // messagebox que diz alongado periodo com sucesso
                MessageBox.Show("Período de devolução reagendado para: " + dataFuturaFormatada + ".");
                data = conexao.obterdados("SELECT Table_Reservas.CD_Reservas, Table_Livro.Nome_Livro, Table_reservas.DT_reserva, Table_reservas.DT_previsao_devolucao FROM Table_reservas INNER JOIN Table_Livro ON Table_Reservas.CFK_Livro = Table_Livro.Order_Livro");
                dataGridView.DataSource = data;
            } else
            {
                MessageBox.Show("Não foi possível reagendar a data de devolução");
            }
            

        }
    }
}


