using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            picker.ItemsSource = new List<string>(itSpesiality);
        }

        int item;
        string[] itSpesiality = new string[] { "Тестировщик", "Мобильный разработчик", "Верстальщик", "Front-end", "Back-end" };
        string[] requrment = new string[] { "Занимается тестировкой проектов", "Разрабатывает программы для мобильных устройств",
             "Занимается ветсткой проектов", "Занимается фронтенд разработкой", "Занимается бекенд разработкой" };

        private void BtnChange_Clicked(object sender, EventArgs e)
        {
            lblChange.Text = requrment[item];
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            item = picker.SelectedIndex;
        }
    }
}
