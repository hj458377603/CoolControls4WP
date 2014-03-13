using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace WPUC.Appbar
{
    public class NotifyButton : INotifyPropertyChanged
    {
        #region 字段

        // 按钮的图片地址
        private string imageUri;

        // 提示文本的可见性
        private Visibility notifyTextVisibility;

        // 提示文本
        private string notifyText;

        // 按钮文本
        private string text;

        // 点击命令
        private ICommand clickCommand;

        // 是否可以使用
        private bool isEnabled = true;

        // 透明度
        private float opacity = 1.0f;

        // 提示文本背景颜色
        private Brush notifyTextBackground = new SolidColorBrush(Colors.Red);

        #endregion

        #region 属性

        /// <summary>
        /// 提示文本的可见性
        /// </summary>
        public Visibility NotifyTextVisibility
        {
            get
            {
                return notifyTextVisibility;
            }
            set
            {
                notifyTextVisibility = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("NotifyTextVisibility"));
                }
            }
        }

        /// <summary>
        /// 提示文本
        /// </summary>
        public string NotifyText
        {
            get
            {
                return notifyText;
            }
            set
            {
                notifyText = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("NotifyText"));
                }

                // 设置提示文本是否可见
                if (!string.IsNullOrEmpty(notifyText))
                {
                    NotifyTextVisibility = Visibility.Visible;
                }
                else
                {
                    NotifyTextVisibility = Visibility.Collapsed;
                }
            }
        }

        /// <summary>
        /// 按钮文本
        /// </summary>
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Text"));
                }
            }
        }

        /// <summary>
        /// 按钮的图片地址
        /// </summary>
        public string ImageUri
        {
            get
            {
                return imageUri;
            }
            set
            {
                imageUri = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ImageUri"));
                }
            }
        }

        /// <summary>
        /// 是否可以使用
        /// </summary>
        public bool IsEnabled
        {
            get
            {
                return isEnabled;
            }
            set
            {
                isEnabled = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("IsEnabled"));
                }
                if (value == false)
                {
                    Opacity = 0.3f;
                }
            }
        }

        /// <summary>
        /// 透明度
        /// </summary>
        public float Opacity
        {
            get
            {
                return opacity;
            }
            private set
            {
                opacity = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Opacity"));
                }
            }
        }

        /// <summary>
        /// 提示文本背景颜色
        /// </summary>
        public Brush NotifyTextBackgroundColor
        {
            get
            {
                return notifyTextBackground;
            }
            set
            {
                notifyTextBackground = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("NotifyTextBackgroundColor"));
                }
            }
        }
        #endregion

        #region 事件

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region 命令

        public ICommand ClickCommand
        {
            get
            {
                return clickCommand;
            }
            set
            {
                clickCommand = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ClickCommand"));
                }
            }
        }

        #endregion

        #region 构造方法

        public NotifyButton(string imageUri)
        {
            this.notifyTextVisibility = Visibility.Collapsed;
            this.ImageUri = imageUri;
        }

        #endregion

        #region 重写方法

        #endregion

        #region 方法

        #endregion
    }
}
