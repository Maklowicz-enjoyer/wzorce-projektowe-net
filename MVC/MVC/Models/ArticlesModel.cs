using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models
{
    internal class ArticlesModel : IModel
    {
        public List<ArticleModel> Articles { get; } = new();
    }
}
