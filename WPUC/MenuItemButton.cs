using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPUC
{
    public class MenuItemButton : INotifyPropertyChanged
    {
        #region 字段

        // 按钮文本
        private string text;

        private ICommand command;

        #endregion

        #region 属性
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

        public MenuItemButton()
        {
        }

        #endregion

        #region 重写方法

        #endregion

        #region 方法

        #endregion
    }
}
