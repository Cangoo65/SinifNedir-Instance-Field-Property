using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifNedir_Instance_Field_Property
{
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı :" +  Ad);
            Console.WriteLine("Çalışanın Soyadı :" +  Soyad);
            Console.WriteLine("Çalışanın Numarası :" + No);
            Console.WriteLine("çalışanın Departmanı :" + Departman);
        }
    }
}
