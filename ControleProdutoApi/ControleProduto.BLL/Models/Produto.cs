using System;
using System.Collections.Generic;
using System.Text;

namespace ControleProduto.BLL.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }
        public decimal PrecoPromocao { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
}
