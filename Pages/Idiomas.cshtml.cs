using LivrariaApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Org.BouncyCastle.Utilities;

namespace LivrariaApp.Pages;

public class Idiomas : PageModel
{
    public IEnumerable<Idioma> IdiomaList { get; set; }
 
    //É chamado sempre que alguém consulta a página
    public void OnGet()
    {
        LivrariaContext context = new LivrariaContext();
        IdiomaList = context.getAllIdioma();
    }

    //Recebe o formulário HTML e executa o código 
    public void OnPost()
    {
        if (Request.Form["Operacao"].Equals("Actualizar"))
        {
            Idioma idioma = new Idioma()
            {
                Id = Int32.Parse(Request.Form["id"]),
                Nome = Request.Form["nome"],
                Sigla = Request.Form["sigla"]
            };

            LivrariaContext context = new LivrariaContext();
            context.updateIdioma(idioma);

           
        }
        else
        {
            LivrariaContext context = new LivrariaContext();
            context.deleteIdioma(Int32.Parse(Request.Form["id"]));
        }
        OnGet();
        
    }
}