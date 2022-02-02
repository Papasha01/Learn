using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn
{
    public partial class FormEditService : Form
    {
        string titleService = "";			//Название услуги
        int mode = -1;				//0 - добавление, 1 - редактирование
        LearnDataSet.ServiceDataTable dataServices;	//Все записи из таблицы
        LearnDataSet.ServiceRow rowService;		//Отдельная строка таблицы
        string pathExe = Application.StartupPath;		//Папка до exe
        string sourcePath;		//Полный путь от источника картинки
        string oldPath;			//Полный путь старого местонахождения файла
        string destPath;			//Полный путь к приемнику картинки

        public FormEditService()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Конструктор для случая редактирования услуги
        /// </summary>
        /// <param name="titleService"></param>
        public FormEditService(int mode, string titleService)
        {
            InitializeComponent();
            this.mode = mode;
            this.titleService = titleService;
        }
        /// <summary>
        /// Возврат назад
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// При загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEditService_Load(object sender, EventArgs e)
        {
            switch (mode)			//Режим: добавление/редактирование
            {
                case 0:			//Добавление
                    textBoxID.Visible = false;
                    labelID.Visible = false;
                    labelPathImage.Text = "";
                    break;
                case 1:			//Редактирование
                    //Получить все данные из таблицы
                    dataServices = this.serviceTableAdapter1.GetData();
                    //Выбрать запись по названию услуги
                    rowService = dataServices.Where(x => x.Title == titleService).ToList().First();
                    //Отобразить данные из выбранной записи
                    textBoxID.Text = rowService.ID.ToString();
                    textBoxID.Enabled = false;
                    textBoxTitle.Text = rowService.Title;
                    textBoxPrice.Text = rowService.Cost.ToString();
                    textBoxDist.Text = rowService.DurationInSeconds.ToString();
                    textBoxSale.Text = (rowService.Discount * 100).ToString();
                    labelPathImage.Text = rowService.MainImagePath;
                    oldPath = pathExe + @"\" + rowService.MainImagePath;
                    if (File.Exists(oldPath))		//Проверка изображения
                    {
                        this.pictureBoxService.Load(oldPath);
                    }
                    else
                    {
                        this.pictureBoxService.Image = Properties.Resources.NotImage;    //Нет
                    }
                    if (String.IsNullOrEmpty(rowService.Description))
                    {
                        textBoxDescription.Clear();
                    }
                    else
                    {
                        textBoxDescription.Text = rowService.Description;
                    }
                    break;
            }
        }
        /// <summary>
        /// Отменить изменения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Фиксировать изменения в таблице БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFixed_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            decimal cost = decimal.Parse(textBoxPrice.Text);
            int sec = int.Parse(textBoxDist.Text) * 60;
            string desc = textBoxDescription.Text;
            double? disc = (double.Parse(textBoxSale.Text)) / 100.0;
            string mainPath = labelPathImage.Text;
            destPath = pathExe + @"\" + mainPath;
            try
            {
                File.Copy(sourcePath, destPath, true);
                MessageBox.Show("Файл с новым изображением перенесен в папку");
            }
            catch
            {
                MessageBox.Show("Ошибка переносе файла с изображением");
            }
            switch (mode)
            {
                case 0:		//Добавить новую запись
                    try
                    {
                        this.serviceTableAdapter1.Insert(title, cost, sec, desc, disc, mainPath);
                        MessageBox.Show("Ваша услуга добавлена в системе");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка при добавлении услуги");
                    }
                    break;
                case 1:		//Редактировать запись
                    try
                    {
                        rowService.Title = title;
                        rowService.Cost = cost;
                        rowService.DurationInSeconds = sec;
                        rowService.Description = desc;
                        rowService.Discount = (double)disc;
                        rowService.MainImagePath = mainPath;
                        this.serviceTableAdapter1.Update(rowService);
                        MessageBox.Show("Ваша услуга обновлена в системе");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка при обновлении услуги");
                    }
                    break;
            }
        }
        /// <summary>
        /// Выбрать фото
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            string fileService;
            string newMainImagePath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sourcePath = openFileDialog1.FileName; 	//Полное имя файла
                fileService = openFileDialog1.SafeFileName;	//Только имя и расширение файла
                newMainImagePath = "Услуги школы" + @"\" + fileService;
                labelPathImage.Text = newMainImagePath;
                pictureBoxService.Load(sourcePath);
            }
        }

        private void serviceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.serviceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.learnDataSet);

        }

        private void FormEditService_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learnDataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.learnDataSet.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learnDataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter1.Fill(this.learnDataSet.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learnDataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter1.Fill(this.learnDataSet.Service);

        }

        private void serviceBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.serviceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.learnDataSet);

        }

        private void serviceBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.serviceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.learnDataSet);

        }
    }
}
