using ObserverImp.Documents;

namespace ObserverImp.Repositiories
{
    internal class FileRepository : Repository
    {
        public override void Update(Document document, string info)
        {
            Console.WriteLine($"Dokument {document.Title} został zaktualizowany w repozytrium Plików");
            Console.WriteLine($"Zmiana: {info}");
        }

        public override void Upload(Document document)
        {
            Console.WriteLine($"Dokument {document.Title} został dodany do repozytrium plików");
        }
    }
}
