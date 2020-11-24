using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryDecorator
{
    public partial class UserControlDecorator : UserControl
    {
        private KindOfProduct kindOfProduct;

        public string KindOfProduct
        {
            get
            {
                return kindOfProduct != null ? kindOfProduct.getKindOfProduct() : "Не указано";
            }
        }
        public UserControlDecorator()
        {
            InitializeComponent();
        }

        private void checkBoxStandard_CheckedChanged(object sender, EventArgs e)
        {
            KindOfProductDecorator decorator = new StandardProduct();
            kindOfProduct = decorator;

        }

        private void checkBoxPremium_CheckedChanged(object sender, EventArgs e)
        {
            KindOfProductDecorator decorator = new PremiumProduct();
            kindOfProduct = decorator;
        }
    }
}
