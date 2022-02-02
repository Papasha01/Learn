
namespace Learn
{
    partial class FormListService
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serviceTableAdapter = new Learn.LearnDataSetTableAdapters.ServiceTableAdapter();
            this.listViewService = new System.Windows.Forms.ListView();
            this.imageListService = new System.Windows.Forms.ImageList(this.components);
            this.labelCountRecords = new System.Windows.Forms.Label();
            this.comboBoxSale = new System.Windows.Forms.ComboBox();
            this.textBoxSearchTitle = new System.Windows.Forms.TextBox();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // listViewService
            // 
            this.listViewService.HideSelection = false;
            this.listViewService.Location = new System.Drawing.Point(87, 104);
            this.listViewService.Name = "listViewService";
            this.listViewService.Size = new System.Drawing.Size(647, 293);
            this.listViewService.TabIndex = 0;
            this.listViewService.UseCompatibleStateImageBehavior = false;
            // 
            // imageListService
            // 
            this.imageListService.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListService.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListService.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelCountRecords
            // 
            this.labelCountRecords.AutoSize = true;
            this.labelCountRecords.Location = new System.Drawing.Point(356, 440);
            this.labelCountRecords.Name = "labelCountRecords";
            this.labelCountRecords.Size = new System.Drawing.Size(59, 13);
            this.labelCountRecords.TabIndex = 1;
            this.labelCountRecords.Text = "Записей...";
            // 
            // comboBoxSale
            // 
            this.comboBoxSale.FormattingEnabled = true;
            this.comboBoxSale.Items.AddRange(new object[] {
            "0,1",
            "0,15",
            "0,25"});
            this.comboBoxSale.Location = new System.Drawing.Point(587, 51);
            this.comboBoxSale.Name = "comboBoxSale";
            this.comboBoxSale.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSale.TabIndex = 2;
            this.comboBoxSale.SelectedIndexChanged += new System.EventHandler(this.comboBoxSale_SelectedIndexChanged);
            // 
            // textBoxSearchTitle
            // 
            this.textBoxSearchTitle.Location = new System.Drawing.Point(197, 59);
            this.textBoxSearchTitle.Name = "textBoxSearchTitle";
            this.textBoxSearchTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchTitle.TabIndex = 3;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(587, 451);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(198, 55);
            this.buttonAdmin.TabIndex = 4;
            this.buttonAdmin.Text = "Зайти как админ";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(247, 473);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(434, 473);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Размер скидки (%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Поиск по названию";
            // 
            // FormListService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.textBoxSearchTitle);
            this.Controls.Add(this.comboBoxSale);
            this.Controls.Add(this.labelCountRecords);
            this.Controls.Add(this.listViewService);
            this.Name = "FormListService";
            this.Text = "FormListService";
            this.Load += new System.EventHandler(this.FormListService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LearnDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.ListView listViewService;
        private System.Windows.Forms.ImageList imageListService;
        private System.Windows.Forms.Label labelCountRecords;
        private System.Windows.Forms.ComboBox comboBoxSale;
        private System.Windows.Forms.TextBox textBoxSearchTitle;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}