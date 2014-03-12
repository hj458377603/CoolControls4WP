using GalaSoft.MvvmLight.Command;
using Microsoft.Phone.Controls;
using System.Collections.ObjectModel;
using System.Windows;

namespace WPUC
{
    public partial class MainPage : PhoneApplicationPage
    {
        // 构造函数
        public MainPage()
        {
            InitializeComponent();

            var btns = new ObservableCollection<NotifyButton>();
            NotifyButton btn1 = new NotifyButton("/Assets/asc.png");
            btn1.NotifyText = "1";
            btn1.Text = "this is btn1";
            btn1.ClickCommand = new RelayCommand(() =>
            {
                MessageBox.Show("haha,this is btn1");
            });

            NotifyButton btn2 = new NotifyButton("/Assets/asc.png");
            btn2.NotifyText = "2";
            btn2.Text = "this is btn1";
            btn2.ClickCommand = new RelayCommand(() =>
            {
                MessageBox.Show("haha,this is btn2");
            });

            NotifyButton btn3 = new NotifyButton("/Assets/asc.png");
            btn3.NotifyText = "3";
            btn3.Text = "this is btn1";
            btn3.ClickCommand = new RelayCommand(() =>
            {
                MessageBox.Show("haha,this is btn3");
            });

            btns.Add(btn1);
            btns.Add(btn2);
            btns.Add(btn3);
            this.appbar.NotifyButtonList = btns;

            var menuItemBtns = new ObservableCollection<MenuItemButton>();
            MenuItemButton menuItembtn1 = new MenuItemButton();
            menuItembtn1.Text = "menuItembtn1";
            menuItembtn1.ClickCommand = new RelayCommand(() =>
            {
                MessageBox.Show("haha,this is menuItembtn1");
            });

            MenuItemButton menuItembtn2 = new MenuItemButton();
            menuItembtn2.Text = "menuItembtn2";
            menuItembtn2.ClickCommand = new RelayCommand(() =>
            {
                MessageBox.Show("haha,this is menuItembtn2");
            });

            MenuItemButton menuItembtn3 = new MenuItemButton();
            menuItembtn3.Text = "menuItembtn3";
            menuItembtn3.ClickCommand = new RelayCommand(() =>
            {
                MessageBox.Show("haha,this is menuItembtn3");
            });

            menuItemBtns.Add(menuItembtn1);
            menuItemBtns.Add(menuItembtn2);
            menuItemBtns.Add(menuItembtn3);
            this.appbar.MenuItemButtonList = menuItemBtns;
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            if (this.appbar.IsOpen)
            {
                this.appbar.IsOpen = false;
                e.Cancel = true;
            }
        }
    }
}