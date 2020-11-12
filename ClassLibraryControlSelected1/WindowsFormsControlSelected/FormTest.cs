using ClassLibraryBackUpComponent;
using ClassLibraryExcelComponent;
using ClassLibraryControlListBoxSelected;
using MigraDoc.DocumentObjectModel.Shapes.Charts;
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
            string temp = "(Id) (TimeOfWay) (Number)";
            controlListBoxSelected1.setTemplate(temp);
            var set1 = new Bus { Id = 0, Mark = "Honda", Number = 56, TimeOfWay = 197 };
            var set2 = new Bus { Id = 1, Mark = "Mersedes", Number = 36, TimeOfWay = 148 };
            var set3 = new Bus { Id = 2, Mark = "Lada", Number = 59, TimeOfWay = 260 };
            var set4 = new Bus { Id = 3, Mark = "Gas", Number = 96, TimeOfWay = 115 };
            controlListBoxSelected1.setProperty(set1, "Number", 1);
            controlListBoxSelected1.setProperty(set2, "Id", 1);

            var list = new List<Bus>
            {
                set1,
                set2,
                set3,
                set4
            };

            set1.Id = 32;
            set1.Number = 5;
            set1.TimeOfWay = 67;

            var mer1 = new Merge {CellToName = 2, CellFromName = 3 };
            var list1 = new List<Merge>
            {
                mer1
            };
            componentBackUp1.saveData("C:/Users/helen/OneDrive/Desktop", list.ToArray());
            componentExcel1.CreateExcelReport("C:/Users/helen/OneDrive/Desktop/otch.xlsx", false, list.ToArray(), list1.ToArray());
            componentPDF1.createPdfDeiagram("C:/Users/helen/OneDrive/Desktop/otch.pdf", set1, DataLabelType.Value);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            controlComboBoxSelected1.SelectedIndex = 0;
        }

        private void controlListBoxSelected_ListBoxSelectedElementChange(object sender, EventArgs e)
        {
            MessageBox.Show(controlComboBoxSelected1.SelectedIndex.ToString() + " " + controlComboBoxSelected1.SelectedText);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlTextBox1.UserInput = DateTime.Today.ToString();
        }
    }
}
