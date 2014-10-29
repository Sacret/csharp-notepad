using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            //Добавляем блок для обработки исключений — по разным причинам 
            //пользователь может не получить доступа к ресурсу.
            try
            {
                //Вызываем метод VisitLink, определенный ниже
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Невозможно открыть страницу!");
            }
        }
        private void VisitLink()
        {
            // Изменяем цвет посещенной ссылки, программно 
            //обращаясь к свойству LinkVisited элемента LinkLabel 
            linkLabel1.LinkVisited = true;
            //Вызываем метод Process.Start method  для запуска браузера, 
            //установленного по умолчанию, и открытия ссылки
            System.Diagnostics.Process.Start("http://www.sacret.ru/");
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
