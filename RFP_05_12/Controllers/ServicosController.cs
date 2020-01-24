using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RFP_05_12.Models.Services;

namespace RFP_05_12.Controllers
{
    public class ServicosController : Controller
    {
        private ProdutoService _produtoService;

        public ServicosController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }


        public IActionResult Index()
        {
            var list = _produtoService.FindAll();
            return View(list);
        }
    }
}