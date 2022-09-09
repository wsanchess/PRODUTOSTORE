using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using wsanches.produtostore.Models;

namespace wsanches.produtostore.Data
{
    public class ProdutoStoreDataContext:DbContext
    {
        public ProdutoStoreDataContext()
        : base("dbConnection")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<CategoriaProduto> CategoriaProdutos { get; set; }

    }
}