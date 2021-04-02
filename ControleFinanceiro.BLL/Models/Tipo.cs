using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.BLL.Models
{
    public class Tipo
    {
        public int TipoId { get; set; }

        public string Nome { get; set; }

        //virtual é leitura de dados sobre demanda 
        public virtual ICollection<Categoria>Categorias { get; set; }
    }
}
