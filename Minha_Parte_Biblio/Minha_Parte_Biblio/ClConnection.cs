using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendendo_MVC
{
    public class ClConectection
    {

        static private String server = "localhost"; //localhost
        static private String DataBase = "Biblio_Sesi"; // Nome do Data Base
        static private String User = "root"; //root senha vazia
        static private String PassWord = ""; //senha do root é sempre vazia
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

                if (registro > 0)
                {
                    //se o codigo existir no registro, sera substituido aqui para execução
                    cmd.Parameters.AddWithValue(PK_Table, codigo);
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



    }
}
