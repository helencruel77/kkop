using ClassLibraryPlugins.Interfaces;
using ClassLibraryPlugins.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPlugins
{
    public class PluginManager
    {
        [ImportMany(typeof(IChange<Product, Category>))]
        IEnumerable<IChange<Product, Category>> Plugins { get; set; }

        public readonly Dictionary<string, Action<Product, Category>> Changers = new Dictionary<string, Action<Product, Category>>();

        public List<string> Headers { get; set; } = new List<string>();

        public PluginManager()
        {
            AggregateCatalog catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins")));

            CompositionContainer container = new CompositionContainer(catalog);
            container.ComposeParts(this);

            if (Plugins.Count() != 0)
            {
                Plugins.ToList().ForEach(p =>
                {
                    Changers.Add(p.Name, p.Change);
                    Headers.Add(p.Name);
                });
            }
            
        }
    }
}
