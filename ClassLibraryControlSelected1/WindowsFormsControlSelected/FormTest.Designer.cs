﻿namespace WindowsFormsControlSelected
{
	partial class FormTest
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.buttonChange = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.controlListBoxSelected1 = new ClassLibraryControlListBoxSelected.ControlListBoxSelected();
            this.controlTextBox1 = new ClassLibraryControlSelected2.ControlTextBox();
            this.controlComboBoxSelected1 = new ClassLibraryControlSelected1.ControlComboBoxSelected();
            this.componentBackUp1 = new ClassLibraryBackUpComponent.ComponentBackUp();
            this.componentExcel1 = new ClassLibraryExcelComponent.ComponentExcel();
            this.componentPDF1 = new ClassLibraryPDFComponent.ComponentPDF();
            this.SuspendLayout();
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(12, 99);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(166, 23);
            this.buttonChange.TabIndex = 1;
            this.buttonChange.Text = "Сменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // controlListBoxSelected1
            // 
            this.controlListBoxSelected1.Location = new System.Drawing.Point(464, 21);
            this.controlListBoxSelected1.Name = "controlListBoxSelected1";
            this.controlListBoxSelected1.SelectedIndex = -1;
            this.controlListBoxSelected1.Size = new System.Drawing.Size(303, 139);
            this.controlListBoxSelected1.TabIndex = 4;
            // 
            // controlTextBox1
            // 
            this.controlTextBox1.ErrorColor = System.Drawing.Color.Empty;
            this.controlTextBox1.Location = new System.Drawing.Point(228, 21);
            this.controlTextBox1.Name = "controlTextBox1";
            this.controlTextBox1.Size = new System.Drawing.Size(230, 119);
            this.controlTextBox1.TabIndex = 3;
            this.controlTextBox1.UserInput = "19.07.1945";
            // 
            // controlComboBoxSelected1
            // 
            this.controlComboBoxSelected1.Location = new System.Drawing.Point(12, 12);
            this.controlComboBoxSelected1.Name = "controlComboBoxSelected1";
            this.controlComboBoxSelected1.SelectedIndex = -1;
            this.controlComboBoxSelected1.Size = new System.Drawing.Size(166, 81);
            this.controlComboBoxSelected1.TabIndex = 2;
            this.controlComboBoxSelected1.LComboBoxSelectedElementChange += new System.EventHandler(this.controlListBoxSelected_ListBoxSelectedElementChange);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 195);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.controlListBoxSelected1);
            this.Controls.Add(this.controlTextBox1);
            this.Controls.Add(this.controlComboBoxSelected1);
            this.Controls.Add(this.buttonChange);
            this.Name = "FormTest";
            this.Text = "Form1";
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button buttonChange;
		private ClassLibraryControlSelected1.ControlComboBoxSelected controlComboBoxSelected1;
		private ClassLibraryControlSelected2.ControlTextBox controlTextBox1;
		private ClassLibraryControlListBoxSelected.ControlListBoxSelected controlListBoxSelected1;
		private System.Windows.Forms.Button button1;
        private ClassLibraryBackUpComponent.ComponentBackUp componentBackUp1;
        private ClassLibraryExcelComponent.ComponentExcel componentExcel1;
        private ClassLibraryPDFComponent.ComponentPDF componentPDF1;
    }
}

