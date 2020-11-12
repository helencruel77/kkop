namespace WindowsFormsAppTestComponents
{
    partial class FormMain
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
            this.controlDataTreeTable = new WindowsFormsControlLibrary.Data.ControlDataTreeTable();
            this.SuspendLayout();
            // 
            // controlDataTreeTable
            // 
            this.controlDataTreeTable.Location = new System.Drawing.Point(3, 12);
            this.controlDataTreeTable.Name = "controlDataTreeTable";
            this.controlDataTreeTable.Size = new System.Drawing.Size(473, 237);
            this.controlDataTreeTable.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 258);
            this.Controls.Add(this.controlDataTreeTable);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion
        private WindowsFormsControlLibrary.Data.ControlDataTreeTable controlDataTreeTable;
    }
}

