using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wsanches.produtostore.Data;
using wsanches.produtostore.Models;
using System.Data.Entity;

namespace wsanches.produtostore.Controllers
{
    public class ProdutoController:Controller
    {

        private ProdutoStoreDataContext _ctx;

        public ProdutoController()
        {
            _ctx = new ProdutoStoreDataContext();
        }

        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
        }

        [HttpGet]
        public ViewResult Index()
        {
            var data = _ctx.Produtos.Include(c => c.CategoriaProduto).ToList();

            return View(data);
        }

        [HttpPost]
        public ActionResult Create(Produto model)
        {
            _ctx.Produtos.Add(model);
            _ctx.SaveChanges();

            string message = "Created the record successfully";

            ViewBag.Message = message;

            return View();
        }

        [HttpPost]
        public ActionResult Edit(int Id, Produto model)
        {
             var data = _ctx.Produtos.FirstOrDefault(x => x.Id == Id);

             if (data != null)
             {
                 data.Nome = model.Nome;
                 data.Descricao = model.Descricao;
                 data.CategoriaProduto = model.CategoriaProduto;
                 data.Ativo = model.Ativo;
                 data.Perecivel = model.Perecivel;

                 _ctx.SaveChanges();

                 return RedirectToAction("Index");
             }
             else
                 return View();
        }

        public ActionResult Delete(int Id)
        {
            var data = _ctx.Produtos.FirstOrDefault(x => x.Id == Id);

            if (data != null)
            {
                _ctx.SaveChanges();

                return RedirectToAction("Index");
            }
            else
                return View();
        }

    }
}