using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Models;

namespace MVC.Views
{
    internal class ArticlesView : IView
    {
        public string RenderView(IModel model)
        {
            if (model is ArticlesModel articlesModel)
            {
                var builder = new StringBuilder();

                articlesModel.Articles.ForEach(article =>
                {
                    builder.AppendLine($"----{article.Id}----");
                    builder.AppendLine($"----{article.Author}----");
                    builder.AppendLine($"----{article.Description}----");
                    builder.AppendLine($"----{article.Text}----");
                });
                return builder.ToString();
            }
            else
            {
                return "błąd renderowania";
            }
        }
    }
}
