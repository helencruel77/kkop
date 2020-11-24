
namespace ClassLibraryDecorator
{
    partial class UserControlDecorator
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxStandard = new System.Windows.Forms.CheckBox();
            this.checkBoxPremium = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxStandard
            // 
            this.checkBoxStandard.AutoSize = true;
            this.checkBoxStandard.Location = new System.Drawing.Point(16, 18);
            this.checkBoxStandard.Name = "checkBoxStandard";
            this.checkBoxStandard.Size = new System.Drawing.Size(140, 17);
            this.checkBoxStandard.TabIndex = 0;
            this.checkBoxStandard.Text = "Стандартное качество";
            this.checkBoxStandard.UseVisualStyleBackColor = true;
            this.checkBoxStandard.CheckedChanged += new System.EventHandler(this.checkBoxStandard_CheckedChanged);
            // 
            // checkBoxPremium
            // 
            this.checkBoxPremium.AutoSize = true;
            this.checkBoxPremium.Location = new System.Drawing.Point(16, 56);
            this.checkBoxPremium.Name = "checkBoxPremium";
            this.checkBoxPremium.Size = new System.Drawing.Size(122, 17);
            this.checkBoxPremium.TabIndex = 1;
            this.checkBoxPremium.Text = "Премиум качество";
            this.checkBoxPremium.UseVisualStyleBackColor = true;
            this.checkBoxPremium.CheckedChanged += new System.EventHandler(this.checkBoxPremium_CheckedChanged);
            // 
            // UserControlDecorator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxPremium);
            this.Controls.Add(this.checkBoxStandard);
            this.Name = "UserControlDecorator";
            this.Size = new System.Drawing.Size(165, 89);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxStandard;
        private System.Windows.Forms.CheckBox checkBoxPremium;
    }
}
