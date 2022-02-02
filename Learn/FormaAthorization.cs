using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn
{
    public partial class FormaAthorization : Form
    {
        public FormaAthorization()
        {
            InitializeComponent();
        }
        /// Возврат назад
        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormListService.access = false;		//Доступ к переменной главной формы
            this.Close();
        }
        /// Проверка правильности пароля
        private void buttonIn_Click(object sender, EventArgs e)
        {
            string log = "0000";				//Заданный пароль
            string pas = "0000";
            string logInput = this.textBoxLogin.Text;	//Введенный пароль
            string pasInput = this.textBoxPass.Text;
            if (logInput == log && pasInput == pas)
            {
                FormListService.access = true;		//Успешно
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
        /// Кнопка закрытия окна
        private void buttonEsc_Click(object sender, EventArgs e)
        {
            FormListService.access = false;
            this.Close();
        }

        private void FormaAthorization_Load(object sender, EventArgs e)
        {

        }
    }
}
