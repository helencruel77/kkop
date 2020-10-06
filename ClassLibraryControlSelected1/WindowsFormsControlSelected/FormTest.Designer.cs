namespace WindowsFormsControlSelected
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
            this.controlComboBoxSelected1 = new ClassLibraryControlSelected1.ControlComboBoxSelected();
            this.controlTextBox1 = new ClassLibraryControlSelected2.ControlTextBox();
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
            // controlComboBoxSelected1
            // 
            this.controlComboBoxSelected1.Location = new System.Drawing.Point(12, 12);
            this.controlComboBoxSelected1.Name = "controlComboBoxSelected1";
            this.controlComboBoxSelected1.SelectedIndex = -1;
            this.controlComboBoxSelected1.Size = new System.Drawing.Size(166, 81);
            this.controlComboBoxSelected1.TabIndex = 2;
            this.controlComboBoxSelected1.LComboBoxSelectedElementChange += new System.EventHandler(this.controlListBoxSelected_ListBoxSelectedElementChange);
            // 
            // controlTextBox1
            // 
            this.controlTextBox1.ErrorColor = System.Drawing.Color.Empty;
            this.controlTextBox1.Location = new System.Drawing.Point(231, 12);
            this.controlTextBox1.Name = "controlTextBox1";
            this.controlTextBox1.Size = new System.Drawing.Size(230, 119);
            this.controlTextBox1.TabIndex = 3;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 195);
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
    }
}

