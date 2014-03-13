using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace WPUC
{
    public partial class WindowsPhoneControl1 : UserControl
    {
        #region 字段

        #endregion

        #region 属性

        public ObservableCollection<NotifyButton> NotifyButtonList
        {
            get { return (ObservableCollection<NotifyButton>)GetValue(NotifyButtonListProperty); }
            set { SetValue(NotifyButtonListProperty, value); }
        }

        public static readonly DependencyProperty NotifyButtonListProperty =
            DependencyProperty.Register("NotifyButtonList", typeof(ObservableCollection<NotifyButton>), typeof(WindowsPhoneControl1), new PropertyMetadata(null));

        public ObservableCollection<MenuItemButton> MenuItemButtonList
        {
            get { return (ObservableCollection<MenuItemButton>)GetValue(MenuItemButtonListProperty); }
            set { SetValue(MenuItemButtonListProperty, value); }
        }

        public static readonly DependencyProperty MenuItemButtonListProperty =
            DependencyProperty.Register("MenuItemButtonList", typeof(ObservableCollection<MenuItemButton>), typeof(WindowsPhoneControl1), new PropertyMetadata(null));

        /// <summary>
        /// appbar是否展开
        /// </summary>
        public bool IsOpen
        {
            get
            {
                return (bool)GetValue(IsOpenProperty);
            }
            set
            {
                SetValue(IsOpenProperty, value);
                if (value)
                {
                    Open();
                }
                else
                {
                    Close();
                }
            }
        }

        public static readonly DependencyProperty IsOpenProperty =
            DependencyProperty.Register("IsOpen", typeof(bool), typeof(WindowsPhoneControl1), new PropertyMetadata(false));

        #endregion

        #region 构造方法

        public WindowsPhoneControl1()
        {
            InitializeComponent();
        }

        #endregion

        #region 重写方法

        #endregion

        #region 方法

        /// <summary>
        /// 点击...
        /// </summary>
        private void TextBlock_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            IsOpen = !IsOpen;
        }

        /// <summary>
        /// loaded事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LayoutRoot_Loaded_1(object sender, RoutedEventArgs e)
        {
            // 在构造函数中设置无效
            this.btnList.ItemsSource = NotifyButtonList;
            this.menuItemBtnList.ItemsSource = MenuItemButtonList;

            // 加载完成后根据有没有提示按钮控制Appbar显示的高度
            if (NotifyButtonList == null || NotifyButtonList.Count == 0)
            {
                this.MinHeight = 30;
            }
            else
            {
                this.MinHeight = 70;
            }
        }

        /// <summary>
        /// 打开
        /// </summary>
        private void Open()
        {
            Storyboard sb = new Storyboard();
            DoubleAnimation animation = new DoubleAnimation();
            animation.To = -this.root.ActualHeight + this.MinHeight;
            // 动画
            animation.Duration = new Duration(TimeSpan.FromSeconds(0.05));
            Storyboard.SetTarget(animation, LayoutRoot);
            Storyboard.SetTargetProperty(animation, new PropertyPath("(UIElement.RenderTransform).(CompositeTransform.TranslateY)"));
            sb.Children.Add(animation);
            sb.Begin();
        }

        /// <summary>
        /// 关闭
        /// </summary>
        private void Close()
        {
            Storyboard sb = new Storyboard();
            DoubleAnimation animation = new DoubleAnimation();
            animation.By = this.root.ActualHeight - this.MinHeight;

            // 动画
            animation.Duration = new Duration(TimeSpan.FromSeconds(0.1));
            Storyboard.SetTarget(animation, LayoutRoot);
            Storyboard.SetTargetProperty(animation, new PropertyPath("(UIElement.RenderTransform).(CompositeTransform.TranslateY)"));
            sb.Children.Add(animation);
            sb.Begin();
        }
        #endregion
    }
}
