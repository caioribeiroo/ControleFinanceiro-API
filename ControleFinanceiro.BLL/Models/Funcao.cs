using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.BLL.Models
{
    public class Funcao : IdentityRole<String>
    {
        public string Descricao { get; set; }
    }
}
