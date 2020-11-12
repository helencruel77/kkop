using BusinessLogic.Interfaces;
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
using WindowsFormsControlLibrary.Models;

namespace WindowsFormsAppTestComponents
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IProductLogic logic;
        public FormMain()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            var products = logic.Read(null);
            var tree = new DataTreeNodeConfig();
            var prop = new Queue<string>();
            prop.Enqueue("Название");
            prop.Enqueue("Категория");
            prop.Enqueue("Количество");
            tree.NodeNames = prop;
            controlDataTreeTable.LoadTreeInfo(tree);
            controlDataTreeTable.AddTable(products);
        }
    }
}
