using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Text.RegularExpressions;

namespace ClassLibraryControlListBoxSelected
{
    public partial class ControlListBoxSelected : UserControl
    {
        private int _selectedIndex;
        private string _item;
        private string temp;
        public ControlListBoxSelected()
        {
            InitializeComponent();
        }

        [Category("Спецификация"), Description("Получение индекса")]
        public int SelectedIndex
        {
            get { return listBox.SelectedIndex; }
            set
            {
                if (value > -2 && value < listBox.Items.Count)
                {
                    _selectedIndex =
                    value; listBox.SelectedIndex = _selectedIndex;
                }
            }
        }
        [Category("Спецификация"), Description("Получение текста выбранной записи")]
        public string SelectedText
        {
            get { return listBox.Text; }
        }
        [Category("Спецификация"), Description("Установка шаблона")]
        public void setTemplate(string temp)
        {
            this.temp = temp;
        }
        [Category("Спецификация"), Description("Установка свойств")]
        public void setProperty<T>(T value, string propName, int line)
        {
            if (listBox.Items.Count < line)
            {
                for (int i = listBox.Items.Count + 1; i <= line + 1; i++)
                {
                    listBox.Items.Add(temp);
                }
            }
            Type type = value.GetType();
            string name = "(" + propName + ")";
            var s = type.GetProperty(propName).GetValue(value, null);
            listBox.Items[line] = listBox.Items[line].ToString().Replace(name, s?.ToString());

        }
    }
}
