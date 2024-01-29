using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp2
{
    internal class Saving 
    {
        List<LoginData> login = new List<LoginData>();
        

        static Saving instance;
        private Saving() { }
        static object locker = new object();
        public static Saving GetInstance()
        {
            lock (locker)
            {
                if (instance == null)
                    instance = new Saving();

                return instance;
            }

        }

        public void Save(LoginData data)
        {
            login.Add(data);
        }

        internal object CheckData(LoginData loginData)
        {
            var user = login.FirstOrDefault(s => s.Login == loginData.Login && s.Password == loginData.Password);
            return user != null;
        }
    }
}
