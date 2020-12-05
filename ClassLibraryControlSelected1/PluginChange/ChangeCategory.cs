using ClassLibraryPlugins.Interfaces;
using ClassLibraryPlugins.Models;
using System;
using System.ComponentModel.Composition;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;

namespace PluginChange
{
    [Export(typeof(IChange<Product, Category>))]
    public class ChangeCategory : IChange<Product, Category>
    {
        public string Name => "Изменение категории продуктов";

        public void Change(Product obj, Category value)
        {
            obj.Category = value;
        }
    }
}
