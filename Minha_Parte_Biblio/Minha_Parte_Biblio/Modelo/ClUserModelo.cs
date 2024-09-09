﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minha_Parte_Biblio.Modelo
{
    public class ClUserModelo
    {
        public String ID_Aluno;
        public String NomeComp;
        public String UserName;
        public String Password;
        public String Caminho_FT;
        public int Index_Cargo; // 1, 2, 3, 4, 5
        public int Index_Ano; // 1° EF, 2° EF, 3° EF, 4° EF, 5° EF, 6° EF, 7° EF, 8° EF, 9° EF, 1° EM, 2° EM, 3° EM, Diretoria
        public int Index_Unidade;
        public int CD_User;

        public ClUserModelo()
        {
            ID_Aluno = "";
            NomeComp = "";
            UserName = "";
            Password = "";
            Caminho_FT = "";
            Index_Cargo = 0;
            Index_Ano = 0;
            Index_Unidade = 0;
            CD_User = 0;
        }
    }
}
