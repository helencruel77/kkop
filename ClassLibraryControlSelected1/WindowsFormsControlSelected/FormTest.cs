using ClassLibraryControlListBoxSelected;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlSelected
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
            controlComboBoxSelected1.LoadCombo(TestEnum.Значение1);
            controlComboBoxSelected1.LoadCombo(TestEnum.Значение2);
            controlTextBox1.ErrorColor = Color.Red;
            string temp = "Id TimeOfWay Number";
            controlListBoxSelected1.setTemplate(temp);
            var setOne = new Bus { Id = "id", Number = "Number", TimeOfWay = "TimeOfWay" };
            controlListBoxSelected1.setProperty("Id", setOne, "37");
            controlListBoxSelected1.setProperty("Number", setOne, "38");

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            controlComboBoxSelected1.SelectedIndex = 0;
        }

        private void controlListBoxSelected_ListBoxSelectedElementChange(object sender, EventArgs e)
        {
            MessageBox.Show(controlComboBoxSelected1.SelectedIndex.ToString() +" "+ controlComboBoxSelected1.SelectedText);
        }
    }
}
