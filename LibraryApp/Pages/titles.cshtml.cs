using Microsoft.AspNetCore.Mvc.RazorPages; // PageModel
using Packt.Shared;                        // Title
using System.Linq;                         // ToArray()
using System.Collections.Generic;          // IEnumerable<T>

namespace PacktFeatures.Pages
{
  public class TitlePageModel : PageModel
  {
    private Library db;

    public TitlePageModel(Library injectedContext)
    {
      db = injectedContext;
    }

    public IEnumerable<Title> Title {get; set;}

    public void OnGet()
    {
      Title = db.Title.ToArray();
    }
  }
}