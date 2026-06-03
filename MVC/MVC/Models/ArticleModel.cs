using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models
{
    internal class ArticleModel : IModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
    }
}
