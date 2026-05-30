using ObserverImp.Repositiories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImp.Documents
{
    internal abstract class Document
    {
        private readonly List<Repository> _repositories = new();

        public abstract string? Title {get;set;}

        public abstract string? Abstract { get; set;}

        public abstract string? Author { get; set; }

        public abstract string? Text { get; set; }

        public void AddToRepository(Repository repository) {

            repository.Upload(this);

            _repositories.Add(repository);
        }

        public void RemoveFromRepository(Repository repository)
        {
            _repositories.Remove(repository);
        }


        public void NotifyRepositories(string info) {
            _repositories.ForEach(repo => repo?.Update(this, info));
        }
    }
}
