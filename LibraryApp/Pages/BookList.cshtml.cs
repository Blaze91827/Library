using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using Packt.Shared;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Pages
{
  public class BookListModel : PageModel
  {
    private Library db;

    public BookListModel(Library injectedContext)
    {
      db = injectedContext;
    }

    public IEnumerable<string> booklist {get; set;}

    public void OnGet()
    {
      ViewData["Title"] = "Library of Babel Website - Checked Books";

      booklist = db.BookList.Select(s => s.title);
    }

    [BindProperty]
    public BookList Book {get; set;}

    public IActionResult OnPost()
    {
      if (ModelState.IsValid)
      {
        db.BookList.Add(Book);
        db.SaveChanges();
        return RedirectToPage("/BookList");
      }
      return Page();
    }
  }
}