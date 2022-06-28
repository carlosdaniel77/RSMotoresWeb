using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RsMotores.WEB.Models
{
    public class ErrorMessage
    {
        public string msg;

        /// <summary>
        /// Coloca uma mesagem de erro na variavel msg
        /// 1 - Erro de login,
        /// 2 - Erro de Cpf,
        /// 3 - Erro de campos em branco
        /// </summary>
        /// <param name="tipo"></param>
        public ErrorMessage(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    msg = "Login inválido. Email e senha não encontrados";
                    break;
                case 2:
                    msg = "Cpf inválido. O cpf informado está inválido";
                    break;
                case 3:
                    msg = "Campos: email e senha não podem ser vazios.";
                    break;
                default:
                    msg = "Erro não reconhecido. Entrar em contato com suporte@admin.com";
                    break;
            }
        }
    }
}
