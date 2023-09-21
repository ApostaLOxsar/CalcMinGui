using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLogin.Logic.DateBase;

namespace TestLogin.Logic
{
    public class DataDB : OnPropertyChangedClass
    {
        private ApplicationContext db;

        public ApplicationContext Db
        {
            get => db;
            set => SetProperty(ref db, value);
        }
    }


    public class LocatorStatic
    {
        public DataDB Data { get; } = new DataDB();
    }
}
