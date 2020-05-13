using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
           var customerManager= CustomerManager.CreateAsSingleton();
            customerManager.Save();
            Console.ReadLine();

        }

        class CustomerManager
        {
            private static CustomerManager _CustomerManager;
            private static object _lockObject = new object();
            private  CustomerManager()
            {
                //Önce private bir constructor oluşturulur

            }
            public static CustomerManager CreateAsSingleton()
            {
                //Oluşturulmuş Nesne Var mı?Yoksa Yeni bir nesne oluştur

                //if (_CustomerManager == null)
                //{
                //    _CustomerManager = new CustomerManager();
                //}
                //return _CustomerManager;
                lock (_lockObject)
                {
                    //_lockObject once nesnenin varligi kontrol edilmek icin kitlenir iki kişi veya daha fazla kişinin aynı anda nesne oluşturmaya calıştıgını varsayarak boyle bir onlem alınır
                    if (_CustomerManager==null)
                    {
                        _CustomerManager = new CustomerManager();
                    }
                }
                return _CustomerManager;
                
            }
            public  void Save()
            {
                Console.WriteLine("Saved!!");
            }
        }
    }
}
