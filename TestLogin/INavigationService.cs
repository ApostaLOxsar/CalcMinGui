using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;

namespace TestLogin
{
    public interface INavigationService
    {
        event EventHandler<PageChangedEventArgs> PageChanged;
    }

    public class PageChangedEventArgs : EventArgs
    {
        public Page Page { get; private set; }

        public PageChangedEventArgs(Page page)
        {
            Page = page;
        }
    }

    public delegate void EventDeleg();
    public class MyClass
    {
        public event EventDeleg myEven = null;

        public void InvokeDelegate()
        {
            myEven.Invoke();
        }
    }
}
