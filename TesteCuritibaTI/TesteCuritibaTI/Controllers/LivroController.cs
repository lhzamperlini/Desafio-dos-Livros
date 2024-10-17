using Microsoft.AspNetCore.Mvc;
using TesteCuritibaTI.Interfaces;
using TesteCuritibaTI.Models;

namespace TesteCuritibaTI.Controllers;
public class LivroController : Controller
{
    private readonly ILivroService _livroService;
    public LivroController(ILivroService livroService)
    {
        _livroService = livroService;
    }

    public IActionResult Index()
    {
        return View(new Livro());
    }
    
    public async Task<IActionResult> Lista()
    {
        return View(await _livroService.ObterLista());
    }
    
    public async Task<IActionResult> Delete(long id)
    {
        return View(nameof(Lista), await _livroService.ObterLista());
    }

    [HttpPost]
    public async Task<IActionResult> Cadastrar(Livro livro)
    {
        TempData["Cadastrado"] = await _livroService.Cadastrar(livro);
        return View(nameof(Index), livro);
    }
}
