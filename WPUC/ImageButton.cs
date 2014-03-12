using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace WPUC
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

        private ICommand command;

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

        #endregion

        #region 事件

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region 命令

        public ICommand ClickCommand
        {
            get
            {
                return command;
            }
            set
            {
                command = value;
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
