using Microsoft.AspNetCore.Mvc;
using Pokedex.Data;
using Pokedex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.Controllers
{
    public class PokemonesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PokemonesController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            IEnumerable<Pokemon> listPokemones = _context.Pokemon;


            return View(listPokemones);
        }

        //Http Get Create
        public IActionResult Create(Pokemon pokemon)
        {
            if (ModelState.IsValid) {
                _context.Pokemon.Add(pokemon);
                _context.SaveChanges();
            }

            return View();

        }
    }
}
