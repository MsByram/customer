using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer
{
     class musterimanajer
    {
        public void add(Customer customers)
        {
            Console.WriteLine("Tebrikler Yeni Kişi eklediniz." + customers.id);
        }
        public void delete(Customer customers)
        {
            Console.WriteLine("Kişi Silindi." + customers.id);
        }
        public void list(Customer customers)
        {
            Console.WriteLine("Kişi Listeye Alındı." + customers.id);
        }
    }
}
