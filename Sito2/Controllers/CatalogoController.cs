using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sito2.Models;
using Sito2.Models.Services.Application;

namespace Sito2.Controllers
{
    public class CatalogoController : Controller
    {
        private readonly ICatalogoService _catalogoService;

        public CatalogoController(ICatalogoService catalogoService)
        {
            this._catalogoService = catalogoService;
        }

        public IActionResult Index()
        {
            var Cata = _catalogoService.GetCatalogo();
            return View(Cata);
        }
        public IActionResult Info()
        {
            var Info = _catalogoService.GetInfo();
            return View(Info);
        }
    }
}