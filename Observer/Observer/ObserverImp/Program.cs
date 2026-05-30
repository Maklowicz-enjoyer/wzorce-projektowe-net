using ObserverImp.Documents;
using ObserverImp.Repositiories;

namespace ObserverImp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var report = new Report
            {
                Title = "Wyniki finansowe 2025",
                Abstract = "Wyniki finansowe 2025",
                Author = "Dyrektor finansowy",
                Text = ""
            };

            report.AddToRepository(new FileRepository { Name = "Pliki fimowe", Type = "Files" });

            report.AddToRepository(new LanRepository { Name = "Serwer w centrali", Type = "LAN" });

            report.AddToRepository(new WebRepository { Name = "Serwer w chmurze", Type = "WEB" });

            report.Author = "Dyrektor IT";
            report.Title = "Wyniki finansowe 2025 rev.2";
        }
    }
}

