using ObserverImp.Documents;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace ObserverImp.Repositiories
{
    internal abstract class Repository
    {
        public required string Type { get; set; }

        public required string Name { get; set; }

        public abstract void Update(Document document, string info);

        public abstract void Upload(Document document);
    }
}
