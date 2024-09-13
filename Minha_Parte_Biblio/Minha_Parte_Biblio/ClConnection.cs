using Minha_Parte_Biblio.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendendo_MVC
{
    public class ClConectection
    {
        //Server: sql10.freemysqlhosting.net
        //Name: sql10731271
        //Username: sql10731271
        //Password: HdPjE6jscM
        //Port number: 3306



        static private String server = "sql10.freemysqlhosting.net"; //localhost
        static private String DataBase = "sql10731271"; // Nome do Data Base
        static private String User = "sql10731271"; //root senha vazia
        static private String PassWord = "HdPjE6jscM"; //senha do root é sempre vazia
        public MySqlConnection Conect = null; // garantia de que eesta aberta e vazia
        static private String strConect = $"server={server};database={DataBase};user id={User};password={PassWord};";

        public MySqlConnection GetConectection()
        {
            Conect = new MySqlConnection(strConect);

            return Conect;
        }



        public int cadastrar(int codigo, string[] campos, object[] valores, string SQL, String PK_Table)
        {

            //VALIDACAO DO SCRIPT
            int registro = 0;


            try
            {
                //atribuir a conexao obtida

                Conect = GetConectection();
                //Abre a conexao
                Conect.Open();
                //Prepara a execução do SQL
                MySqlCommand cmd = new MySqlCommand(SQL, Conect);
                //monto o script sql
                //pegar os campos do vetor
                for (int i = 0; i < valores.Length; i++)
                {
                    //monta a lista de parametros juntando os campos e valores
                    //pega os valores do formulario com os campos do bd
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);
                }

                if (codigo > 0)
                {
                    //se o codigo existir no registro, sera substituido aqui para execução
                    cmd.Parameters.AddWithValue(PK_Table , codigo);
                }

                //executa o script sql
                registro = cmd.ExecuteNonQuery();
                Conect.Close();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return registro;

        }

        public DataTable obterdados(string sql)
        {
            //crio uma tabela de dados
            DataTable dt = new DataTable();
            Conect = GetConectection();//obtenho a conexao
            Conect.Open();//abro o banco
            MySqlCommand cmd = new MySqlCommand(sql, Conect);
            //monto a estrutura das informações obtidas
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            //adiciona a datatable os valores 
            adapter.Fill(dt);

            return dt;
        }


        public DataTable LogIn(ClUserModelo Modelo_User)
        {
            DataTable reg = new DataTable();

            try
            {
                //User Name
                String nameuser = Modelo_User.UserName;
                //password
                String password = Modelo_User.Password;

                String sql = "select * from Table_User where NameUser=@nameuser and Senha=@password";

                MySqlConnection com = GetConectection();

                MySqlCommand cmd = new MySqlCommand(sql, Conect);

                cmd.Parameters.AddWithValue("@nameuser", nameuser);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(reg);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }


            return reg;
        }

        public int editar(string sql, string[] campos, object[] valores, int codigo, String PK_Table)
        {
            int resultado = 0;
            try
            {
                Conect = GetConectection();
                Conect.Open();
                MySqlCommand cmd = new MySqlCommand(sql, Conect);

                for (int i = 0; i < valores.Length; i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);
                }

                if (codigo != 0)
                {
                    cmd.Parameters.AddWithValue(PK_Table, codigo.ToString());
                }

                resultado = Convert.ToInt32(cmd.ExecuteNonQuery());
                Conect.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return resultado;
        }
        public int excluir(int codigo, string sql, string PK_Table)
        {
            int registro = 0;
            try
            {
                Conect = GetConectection();
                Conect.Open();
                MySqlCommand cmd = new MySqlCommand(sql, Conect);
                if (codigo > 0)
                    cmd.Parameters.AddWithValue(PK_Table, codigo);
                registro = cmd.ExecuteNonQuery();
                Conect.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return registro;
        }

    }

}

