using BusinessLogic.Interfaces;
using BusinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
                        MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonChart_Click(object sender, EventArgs e)
        {
            var products = logic.Read(null);
            DataTable table = new DataTable();
            DataColumn firstColumn = new DataColumn("Продукты");
            table.Columns.Add(firstColumn);
            List<string> names = new List<string>();
            foreach (var product in products)
            {
                table.Rows.Add(product.Count);
                names.Add(product.Name);
            }
            componentWordReport.Categories = names.ToArray();
            componentWordReport.DiagramName = "Гистограмма по продуктам";
            componentWordReport.SetData(table);
            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    componentWordReport.Path = dialog.FileName;
                    componentWordReport.CreateDoc();
                }
            }
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {

        }
    }
}
