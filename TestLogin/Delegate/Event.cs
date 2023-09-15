using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace TestLogin
{

    public delegate void MyDelegate();
    public class MyClassEvent
    {

        public event MyDelegate MyDelegateEvent;
        public void MyEvent()
        {
            MyDelegateEvent.Invoke();
        }


    }

}
