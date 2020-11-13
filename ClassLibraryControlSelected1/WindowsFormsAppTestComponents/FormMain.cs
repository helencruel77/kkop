using BusinessLogic.Interfaces;
using BusinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Unity;

namespace WindowsFormsAppTestComponents
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IProductLogic logic;

        public FormMain(IProductLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Название");
            queue.Enqueue("Категория");
            queue.Enqueue("Количество");
            controlTree.Order("Name", "Category", "Count");
        }

        private void LoadData()
        {
            List<ProductViewModel> list = new List<ProductViewModel>();
            var products = logic.Read(null);
            if (products != null)
            {
                foreach (var product in products)
                {
                    list.Add(product);
                }
                controlTree.BuildTree(list);
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCreate>();
            form.ShowDialog();
            LoadData();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            var products = logic.Read(null);
            using (var dialog = new SaveFileDialog { })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        componentSaveDataBinary.SaveData(dialog.FileName, products.ToList());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
