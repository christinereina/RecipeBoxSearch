using Microsoft.AspNetCore.Mvc;
using RecipeBox.Models;
using System.Collections.Generic;

namespace RecipeBox.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public IActionResult Index()
    {
      return View();
    }
    public IActionResult Details(string search)
    {
      List<Article> searchObject = new List<Article> {};
      var allArticles = Article.GetArticles(EnvironmentVariables.ApiKey);
      for (int i = 0; i < allArticles.Count; i++)
      {
        if (search != null && allArticles[i].Title.ToLower().Contains(search.ToLower()))
        {
          searchObject.Add(allArticles[i]);
        }
        else
        {
          searchObject.Add(allArticles[i]);
        }
      }
      return View(searchObject);
    }

  }
}