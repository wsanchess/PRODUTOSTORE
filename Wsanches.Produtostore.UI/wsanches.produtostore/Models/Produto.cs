using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace wsanches.produtostore.Models
{
    [Table("tblProduto")]
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        public bool Perecivel { get; set; }

        public int CategoriaID { get; set; }

        [ForeignKey("CategoriaID")]
        public virtual CategoriaProduto CategoriaProduto { get; set; }

    }
}