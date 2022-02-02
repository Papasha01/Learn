
namespace Learn
{
    partial class FormEditService
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.TextBox();
            this.labelPathImage = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxDist = new System.Windows.Forms.TextBox();
            this.textBoxSale = new System.Windows.Forms.TextBox();
            this.pictureBoxService = new System.Windows.Forms.PictureBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.learnDataSet = new Learn.LearnDataSet();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new Learn.LearnDataSetTableAdapters.ServiceTableAdapter();
            this.tableAdapterManager = new Learn.LearnDataSetTableAdapters.TableAdapterManager();
            this.serviceTableAdapter1 = new Learn.LearnDataSetTableAdapters.ServiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(124, 82);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 0;
            // 
            // labelID
            // 
            this.labelID.Location = new System.Drawing.Point(124, 108);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(100, 20);
            this.labelID.TabIndex = 0;
            // 
            // labelPathImage
            // 
            this.labelPathImage.AutoSize = true;
            this.labelPathImage.Location = new System.Drawing.Point(104, 157);
            this.labelPathImage.Name = "labelPathImage";
            this.labelPathImage.Size = new System.Drawing.Size(35, 13);
            this.labelPathImage.TabIndex = 1;
            this.labelPathImage.Text = "label1";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(124, 216);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(124, 242);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 0;
            // 
            // textBoxDist
            // 
            this.textBoxDist.Location = new System.Drawing.Point(124, 268);
            this.textBoxDist.Name = "textBoxDist";
            this.textBoxDist.Size = new System.Drawing.Size(100, 20);
            this.textBoxDist.TabIndex = 0;
            // 
            // textBoxSale
            // 
            this.textBoxSale.Location = new System.Drawing.Point(124, 294);
            this.textBoxSale.Name = "textBoxSale";
            this.textBoxSale.Size = new System.Drawing.Size(100, 20);
            this.textBoxSale.TabIndex = 0;
            // 
            // pictureBoxService
            // 
            this.pictureBoxService.Location = new System.Drawing.Point(351, 133);
            this.pictureBoxService.Name = "pictureBoxService";
            this.pictureBoxService.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxService.TabIndex = 2;
            this.pictureBoxService.TabStop = false;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(124, 320);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescription.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // learnDataSet
            // 
            this.learnDataSet.DataSetName = "LearnDataSet";
            this.learnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.learnDataSet;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttachedProductTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientServiceTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DocumentByServiceTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.ProductPhotoTableAdapter = null;
            this.tableAdapterManager.ProductSaleTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ServicePhotoTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = this.serviceTableAdapter;
            this.tableAdapterManager.TagOfClientTableAdapter = null;
            this.tableAdapterManager.TagTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Learn.LearnDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // serviceTableAdapter1
            // 
            this.serviceTableAdapter1.ClearBeforeFill = true;
            // 
            // FormEditService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 821);
            this.Controls.Add(this.pictureBoxService);
            this.Controls.Add(this.labelPathImage);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxSale);
            this.Controls.Add(this.textBoxDist);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Name = "FormEditService";
            this.Text = "FormEditService";
            this.Load += new System.EventHandler(this.FormEditService_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox labelID;
        private System.Windows.Forms.Label labelPathImage;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxDist;
        private System.Windows.Forms.TextBox textBoxSale;
        private System.Windows.Forms.PictureBox pictureBoxService;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private LearnDataSet learnDataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private LearnDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private LearnDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LearnDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter1;
    }
}