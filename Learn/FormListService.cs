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
    public partial class FormListService : Form
    {
        public FormListService()
        {
            InitializeComponent();
        }

        LearnDataSet.ServiceDataTable services;
        string path = Application.StartupPath;
        //Переменная как способ передачи информации между формами
        public static bool access = false;		//Доступность режима администратора

        /// <summary>
        /// Вход для редактирования записей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            if (buttonAdmin.Text == "Зайти как администратор")
            {
                FormaAthorization fa = new FormaAthorization();
                this.Hide();
                fa.ShowDialog();
                this.Show();
                buttonAdmin.Text = "Выйти из администратора";
            }
            else
            {
                access = false;		//Запретить доступ
                buttonAdmin.Text = "Зайти как администратор";
            }
            //Доступность кнопок для добавления и редактирования
            this.buttonAdd.Visible = this.buttonEdit.Visible = access;
        }

        /// <summary>
        /// Перейти на форму для редактирования услуги
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string titleService = "";
            int countSelect = listViewService.SelectedItems.Count;	//Число выбранных услуг
            if (countSelect == 0)
            {
                MessageBox.Show("Вы не выбрали ни один элемент для редактирования");
                return;
            }
            //Просмотреть все выбранные услуги
            foreach (ListViewItem item in listViewService.SelectedItems)
            {
                titleService = item.Text;		//Получить название выбранной услуги
            }
            //Открыть форму с дополнительным конструктором:
            // режим открытия и название выбранной услуги
            FormEditService fes = new FormEditService(1, titleService);
            this.Hide();
            fes.ShowDialog();
            this.Show();
        }
        //Добавление новой услуги
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Конструктор с режимом 0 и пустой строкой
            FormEditService fes = new FormEditService(0, "");
            this.Hide();
            fes.ShowDialog();
            this.Show();
        }

        //private void comboBoxSale_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    comboBoxSale_SelectedIndexChanged(null, null);
        //}

        private void FormListService_Load(object sender, EventArgs e)
        {
            //Настроить список
            this.listViewService.CheckBoxes = true;	//Будут флажки для элементов
            this.listViewService.LabelWrap = true;	//С переносом
            this.listViewService.MultiSelect = true;	//Можно выделять несколько элементов
            this.listViewService.FullRowSelect = true;	//Выделять все при выборе элемента
            this.listViewService.RightToLeftLayout = false;	//Слева направо
            this.listViewService.Scrollable = true;	//Полосы прокрутки
            //Разновидность списка - Большие картинки
            this.listViewService.View = View.LargeIcon;
            //Связь список с массивом картинок
            this.listViewService.LargeImageList = imageListService;
            comboBoxSale.SelectedIndex = 0;			//Изначально - все, без скидки
            comboBoxSale_SelectedIndexChanged(null, null);	//Получить параметры фильтрации
        }

        private void ShowResvice(double a, double b, string searchTitle)
        {
            //Получить все данные из таблицы БД Service
            services = this.serviceTableAdapter.GetData();
            //Вспомогательные величины
            int i = 0;
            double proc;
            string filePath;
            //Настроить список элементов и картинок
            this.listViewService.Items.Clear();		//Очистить список
            this.imageListService.Images.Clear();
            // Вывод числа записей
            int countRecord = services.Count;		//Всех записей
            //Фильтр записей по интервалу скидок и по заголовку
            var filter = services.Where(x => x.Title.Contains(searchTitle) &&
                                      (double)x.Discount >= a && (double)x.Discount < b);
            //Список записей фильтра
            var listFilter = filter.ToList();
            int countFilter = listFilter.Count();	//Количество отфильтрованный записей
            this.labelCountRecords.Text = "Записей " + countFilter + " из " + countRecord;
            //Отображение отфильтрованных записей в ListView
            i = 0;						//Индекс для картинок
            //Просмотр все отфильтрованных записей
            foreach (var item in listFilter)
            {
                ListViewItem lvi = new ListViewItem();	//Отдельный элемент списка
                proc = item.Discount * 100;		//Процент скидки по типу БД
                //Для выделения цветом
                if (proc != 0)				//Есть скидка
                {
                    lvi.BackColor = Color.FromArgb(231, 250, 191);
                }
                else						//Нет скидки
                {
                    lvi.BackColor = Color.FromArgb(255, 255, 255);
                }
                //Заполнения массива изображений
                filePath = path + @"\" + item.MainImagePath;	//Путь к изображению
                if (File.Exists(filePath))			//Проверка наличия изображения
                {
                    this.imageListService.Images.Add(Image.FromFile(filePath)); 	//Есть
                }
                else
                {
                    this.imageListService.Images.Add(Properties.Resources.NotImage);	//Нет
                }
                //Заголовок элемента списка
                lvi.Text = item.Title + Environment.NewLine + item.Cost;	//Заголовок+цена
                lvi.ImageIndex = i;			//Номер изображения из массива картинок
                listViewService.Items.Add(lvi);	//Добавить созданный элемент в список
                i++;					//Следующий номер картинки
            }
        }


        /// <summary>
        /// Выбор размера скидки и строки поиска - разделяемое событие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxSale.SelectedIndex;		//Индекс элемента в списке
            double[] sale = { 0, 0.05, 0.15, 0.30, 0.70, 1 };	//Границы скидок
            double a, b;						//Для диапазона скидок
            if (index == 0)			//Все, без скидок – максимальный диапазон
            {
                a = 0;
                b = 1;
            }
            else					//Выбран диапазон
            {
                a = sale[index - 1];			//Из массива диапазонов
                b = sale[index];
            }
            string searchTitle = textBoxSearchTitle.Text;	//Заголовок для поиска
            ShowResvice(a, b, searchTitle);		//Метод фильтрации и отображения
        }

    }
}

