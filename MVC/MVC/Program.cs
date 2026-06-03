using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Controllers;

namespace MVC
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
                var controler = new ArticleControler();
                Console.WriteLine(controler.GetArticles());



            
        }
    }
}
