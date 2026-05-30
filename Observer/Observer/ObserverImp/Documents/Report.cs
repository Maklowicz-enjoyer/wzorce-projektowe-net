using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImp.Documents
{
    internal class Report : Document
    {
        private string? title;
        private string? abs;
        private string? author;
        private string? text;

        public override string? Title { get => title; set { title = value ?? ""; this.NotifyRepositories("Zmieniono tytuł"); }  }
        public override string? Abstract { get => abs; set { abs = value ?? ""; this.NotifyRepositories("Zmieniono abstrakt"); } }
        public override string? Author { get => author; set { author = value ?? ""; this.NotifyRepositories("Zmieniono Autora"); } }
        public override string? Text { get => text; set { text = value ?? ""; this.NotifyRepositories("Zmieniono treść"); } }
    }
}
