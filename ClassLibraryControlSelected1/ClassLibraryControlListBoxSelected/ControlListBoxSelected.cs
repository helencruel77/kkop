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
        public void setProperty<T>(string propName, T value, string prop)
        {
            Type type = value.GetType();
            PropertyInfo piInstance = type.GetProperty(propName);
            PropertyInfo[] props = type.GetProperties();
            switch (propName)
            {
                case "Id":
                    piInstance.SetValue(value, prop);
                    foreach (var propa in props)
                    {
                        _item = _item + " " + propa.GetValue(value).ToString();
                        
                    }
                    break;
                case "Number":
                    piInstance.SetValue(value, prop);
                    foreach (var propa in props)
                    {
                        _item = _item + " " + propa.GetValue(value).ToString();

                    }
                    break;
                case "TimeOfWay":
                    piInstance.SetValue(value, prop);
                    foreach (var propa in props)
                    {
                        _item = _item + " " + propa.GetValue(value).ToString();

                    }
                    
                    break;
            }
            listBox.Items.Add(_item);
            _item = "";
        }
    }
}
