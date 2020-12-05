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
            this.components = new System.ComponentModel.Container();
            this.controlTree = new ClassLibraryControlSelected.ControlTreeView();
            this.componentSaveDataBinary = new WindowsFormsComponentLibrary.Data.ComponentSaveDataBinary(this.components);
            this.componentWordChart = new KOP_laba2.ComponentWord(this.components);
            this.wordReportComponent = new ClassLibraryWordComponent.WordReportComponent(this.components);
            this.buttonBackup = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonChart = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonClone = new System.Windows.Forms.Button();
            this.comboBoxPlugins = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.componentPrototype1 = new ClassLibraryPrototype.ComponentPrototype(this.components);
            this.buttonCreateWaybill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // controlTree
            // 
            this.controlTree.Location = new System.Drawing.Point(12, 12);
            this.controlTree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.controlTree.Name = "controlTree";
            this.controlTree.SelectedNode = null;
            this.controlTree.Size = new System.Drawing.Size(511, 237);
            this.controlTree.TabIndex = 0;
            // 
            // buttonBackup
            // 
            this.buttonBackup.Location = new System.Drawing.Point(12, 292);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(93, 26);
            this.buttonBackup.TabIndex = 1;
            this.buttonBackup.Text = "Бекап";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(430, 292);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(93, 26);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonChart
            // 
            this.buttonChart.Location = new System.Drawing.Point(151, 292);
            this.buttonChart.Name = "buttonChart";
            this.buttonChart.Size = new System.Drawing.Size(110, 26);
            this.buttonChart.TabIndex = 4;
            this.buttonChart.Text = "Диаграмма";
            this.buttonChart.UseVisualStyleBackColor = true;
            this.buttonChart.Click += new System.EventHandler(this.buttonChart_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(302, 292);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(93, 26);
            this.buttonReport.TabIndex = 5;
            this.buttonReport.Text = "Отчет";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonClone
            // 
            this.buttonClone.Location = new System.Drawing.Point(551, 292);
            this.buttonClone.Name = "buttonClone";
            this.buttonClone.Size = new System.Drawing.Size(109, 26);
            this.buttonClone.TabIndex = 6;
            this.buttonClone.Text = "Клонировать";
            this.buttonClone.UseVisualStyleBackColor = true;
            this.buttonClone.Click += new System.EventHandler(this.buttonClone_Click);
            // 
            // comboBoxPlugins
            // 
            this.comboBoxPlugins.FormattingEnabled = true;
            this.comboBoxPlugins.Location = new System.Drawing.Point(528, 39);
            this.comboBoxPlugins.Name = "comboBoxPlugins";
            this.comboBoxPlugins.Size = new System.Drawing.Size(319, 21);
            this.comboBoxPlugins.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Плагины:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Категория:";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(528, 114);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(144, 20);
            this.textBoxCategory.TabIndex = 10;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(528, 165);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(144, 23);
            this.buttonChange.TabIndex = 11;
            this.buttonChange.Text = "Изменить категорию";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(700, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Пополнить склад:";
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(703, 114);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(144, 20);
            this.textBoxAdd.TabIndex = 13;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(703, 165);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(144, 23);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Пополнить склад";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCreateWaybill
            // 
            this.buttonCreateWaybill.Location = new System.Drawing.Point(528, 213);
            this.buttonCreateWaybill.Name = "buttonCreateWaybill";
            this.buttonCreateWaybill.Size = new System.Drawing.Size(319, 23);
            this.buttonCreateWaybill.TabIndex = 15;
            this.buttonCreateWaybill.Text = "Сформировтаь накладную";
            this.buttonCreateWaybill.UseVisualStyleBackColor = true;
            this.buttonCreateWaybill.Click += new System.EventHandler(this.buttonCreateWaybill_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 330);
            this.Controls.Add(this.buttonCreateWaybill);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPlugins);
            this.Controls.Add(this.buttonClone);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonChart);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonBackup);
            this.Controls.Add(this.controlTree);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WindowsFormsComponentLibrary.Data.ComponentSaveDataBinary componentSaveDataBinary;
        private ClassLibraryControlSelected.ControlTreeView controlTree;
        private KOP_laba2.ComponentWord componentWordChart;
        private ClassLibraryWordComponent.WordReportComponent wordReportComponent;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonChart;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonClone;
        private ClassLibraryPrototype.ComponentPrototype componentPrototype1;
        private System.Windows.Forms.ComboBox comboBoxPlugins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCreateWaybill;
    }
}

