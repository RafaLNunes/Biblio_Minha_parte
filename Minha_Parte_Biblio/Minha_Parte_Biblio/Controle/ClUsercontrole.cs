using Aprendendo_MVC;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minha_Parte_Biblio.Controle
{
    internal class ClUsercontrole
    {
        ClConectection conexao = new ClConectection();

        public bool SignUp(ClUsercontrole Perfil)
        {
            bool Resultado = false;

            try
            {

                String SQL_Insert = "insert into Table_User(ID_Aluno, Nome_Completo, NameUser, Senha)values(@ID_Aluno, @Nome_Completo, @UserName, @Password)";

            }
            catch(Exception ex) 
            {
                throw new Exception(ex.ToString());
            }


            return Resultado;
        }
    }
}
