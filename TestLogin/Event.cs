using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace TestLogin
{
    public class MyClassEvent
    { 
        public delegate void MyDelegate();

        public event MyDelegate MyDelegateEvent;
        public void MyEvent()
        {
            MyDelegateEvent.Invoke();
        }

       
    }

}
