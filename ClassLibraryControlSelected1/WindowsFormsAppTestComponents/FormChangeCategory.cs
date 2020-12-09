using BusinessLogic.BindingModel;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModel;
using ClassLibraryPlugins;
using ClassLibraryPlugins.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace WindowsFormsAppTestComponents
{
    public partial class FormChangeCategory : Form
    {
        private string cng;
        private ProductViewModel product;
        private readonly PluginManager manager;
        private readonly IProductLogic logic;
        public FormChangeCategory(string inputCng, ProductViewModel inputProduct, PluginManager inputManager, IProductLogic inputLogic)
        {
            InitializeComponent();
            cng = inputCng;
            product = inputProduct;
            manager = inputManager;
            logic = inputLogic;
            controlSelectedComboBoxEnum.LoadEnum(typeof(Category));
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            Category categoryType = (Category)controlSelectedComboBoxEnum.SelectedItem;
           
            Product obj = new Product
            {
                Id = product.Id,
                Name = product.Name,
                KindOFProduct = product.KindOFProduct,
                Category = product.Category,
                Count = product.Count
            };

            manager.ChangersDict[cng](obj, categoryType);
            try
            {
                logic.CreateOrUpdate(new ProductBindingModel
                {
                    Id = obj.Id,
                    Name = obj.Name,
                    Category = obj.Category,
                    Count = obj.Count,
                    KindOFProduct = obj.KindOFProduct,
                    Price = obj.Price
                });
                MessageBox.Show("Категория изменена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
