using AutoMapper;
using Livros.Aplicacao.Interface;
using Livros.Dominio.Entidades;
using Livros.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LivroMVC.Controllers
{
    public class LivrosController : Controller
    {
        private readonly ILivroAppService _livroApp;

        public LivrosController(ILivroAppService livroApp)
        {
            _livroApp = livroApp;
        }
        // GET: Livros
        public ActionResult Index()
        {
            var livro = _livroApp.RetonaLista();
            var livroVO = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroVO>>(livro);
            return View(livroVO);
        }

        public ActionResult BuscaPoTitulo(string titulo)
        {
            var livroVO = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroVO>>(_livroApp.BuscarPorTitulo(titulo));
            return View(livroVO);
        }

        public ActionResult BuscarPorGenero(string genero)
        {
            var livroVO = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroVO>>(_livroApp.BuscarPorGenero(genero));
            return View(livroVO);
        }

        public ActionResult BuscarPorAutor(string autor)
        {
            var livroVO = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroVO>>(_livroApp.BuscarPorAutor(autor));
            return View(livroVO);
        }


        public ActionResult BuscarPorGenero(int anoDePublicacao)
        {
            var livroVO = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroVO>>(_livroApp.BuscarPorAnoDePublicacao(anoDePublicacao));
            return View(livroVO);
        }



        // GET: Livros/Details/5
        public ActionResult Details(int id)
        {

            var livro =_livroApp.RetornaPorId(id);
            var livroDominio = Mapper.Map<Livro, LivroVO>(livro);

            return View(livroDominio);
        }

        // GET: Livros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Livros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LivroVO livro)
        {

            if (ModelState.IsValid)
            {
                var livroDominio = Mapper.Map<LivroVO, Livro>(livro);
                _livroApp.Adicionar(livroDominio);
                return RedirectToAction("Index");

            }
            return View(livro);
        }


        // GET: Livros/Edit/5
        public ActionResult Edit(int id)
        {
            var livro = _livroApp.RetornaPorId(id);
            var livroDominio = Mapper.Map<Livro, LivroVO>(livro);

            return View(livroDominio);
        }

        // POST: Livros/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LivroVO livro)
        {

            if (ModelState.IsValid)
            {
                var livroDominio = Mapper.Map<LivroVO, Livro>(livro);
                _livroApp.Atualizar(livroDominio);
                return RedirectToAction("Index");

            }
            return View(livro);
        }

        // GET: Livros/Delete/5
        public ActionResult Delete(int id)
        {
            var livro = _livroApp.RetornaPorId(id);
            var livroDominio = Mapper.Map<Livro, LivroVO>(livro);

            return View(livroDominio);
        }

        // POST: Livros/Delete/5
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
                var livro = _livroApp.RetornaPorId(id);
                _livroApp.Remove(livro);

                return RedirectToAction("Index");
          
        }
    }
}
