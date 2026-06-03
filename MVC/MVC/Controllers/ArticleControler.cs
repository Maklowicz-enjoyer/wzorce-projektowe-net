using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Models;
using MVC.Views;

namespace MVC.Controllers
{
    internal class ArticleControler : IControler
    {
        public string GetArticles()
        {
            var model = new ArticlesModel();

            model.Articles.Add(new ArticleModel
            {
                Id = 1,
                Author = "Joe Doe",
                Description = "test",
                Text = "test"
            });
            return new ArticlesView().RenderView(model);
        }
    }
}
