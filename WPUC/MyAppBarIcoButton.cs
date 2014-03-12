using Microsoft.Phone.Shell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPUC
{
    class MyAppBarIcoButton : ApplicationBarIconButton
    {
        public MyAppBarIcoButton()
        {
            this.IconUri = new Uri("/Assets/asc.png", UriKind.Relative);
            this.IsEnabled = true;
            this.Text = "texst";
        }
    }
}
