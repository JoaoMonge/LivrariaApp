using LivrariaApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LivrariaApp.Pages;

public class CreateIdioma : PageModel
{
    public void OnPost()
    {
        LivrariaContext context = new LivrariaContext();
        context.criarIdioma(Request.Form["Nome"],Request.Form["Sigla"]);
        
    }
}