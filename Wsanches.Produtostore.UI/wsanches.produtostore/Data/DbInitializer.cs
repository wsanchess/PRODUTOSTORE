using System.Collections.Generic;
using System.Data.Entity;
using wsanches.produtostore.Models;

namespace wsanches.produtostore.Data
{
    class DbInitializer : CreateDatabaseIfNotExists<ProdutoStoreDataContext>
    {
        protected override void Seed(ProdutoStoreDataContext context)
        {
            var categorias = new List<CategoriaProduto>()
            {
                new CategoriaProduto() { Nome = "Moveis", Descricao="hahahhshdhhahahsd", Ativo=true },
                new CategoriaProduto() { Nome = "Eletrodomesticos", Descricao="hahahhshdhhahahsd", Ativo=true },
                
            };

            context.CategoriaProdutos.AddRange(categorias);

            var produtos = new List<Produto>()
            {
                new Produto() { Nome = "Celular", Ativo = true, Descricao="hahahhshdhhahahsd", Perecivel=true,CategoriaID = 2 },
                new Produto() { Nome = "TV", Ativo = true, Descricao="hahahhshdhhahahsd", Perecivel=true,CategoriaID = 2 },
                new Produto() { Nome = "Notebook", Ativo = true, Descricao="hahahhshdhhahahsd", Perecivel=true,CategoriaID = 2 },
                new Produto() { Nome = "Cama de Solteiro", Ativo = true, Descricao="hahahhshdhhahahsd", Perecivel=true,CategoriaID = 1 },
            };

            context.Produtos.AddRange(produtos);
            context.SaveChanges();
        }
    }
}