using DataBaseImplement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPrototype
{
    public partial class ComponentPrototype : Component
    {
        List<object> nodes = new List<object>();

        public ComponentPrototype()
        {
            InitializeComponent();
        }

        public ComponentPrototype(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void CloneProduct (string[] props)
        {
            Category categoryType = Category.Молочка;
            foreach (var item in Enum.GetValues(typeof(Category)))
            {
                if (item.ToString() == props[1])
                {
                    categoryType = (Category)item;
                }
            }
            Product obj = new Product
            {
                Name = props[0],
                Category = categoryType,
                Count = 3
            };
            obj.Clone();
            nodes.Add(obj.Clone());
            for (int i= 0; i < nodes.Count; i++)
            {
                Console.WriteLine("elem {0} = {1}",i, nodes[i].ToString());
            }
        }
    }
}
