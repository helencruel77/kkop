using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDecorator
{
    public class StandardProduct : KindOfProductDecorator
    {
        public override string getKindOfProduct()
        {
            return "Стандарт продукт" + (kindOfProduct != null ? (" + " + kindOfProduct.getKindOfProduct()) : "");
        }
    }
}
