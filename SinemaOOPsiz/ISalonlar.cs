using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOOPsiz
{
    interface ISalonlar
    {
        void BosKoltukOgren();
        double BakiyeOgren();
        void Ekle();
        void Iptal();
    }
    public class SalonA : ISalonlar
    {
        public SalonA(int kap)
        {
            ToplamKoltuk = kap;
            BosKoltuk = ToplamKoltuk;
        }

        public int ToplamKoltuk;
        public int BosKoltuk;
        public double Bakiye = 0;
        public double Fiyat = 20.0;
        public void BosKoltukOgren()
        {
            Console.WriteLine("A Salonunda Boş Koltuk Sayısı="+BosKoltuk);
        }
        public double BakiyeOgren()
        {
            return Bakiye;

        }
        public void Ekle()
        {
            
            Bakiye += Fiyat;
            BosKoltuk--;

        }

        public void Iptal()
        {
            Console.WriteLine("Film Başarıyla İptal Edildi");
            Bakiye -= Fiyat;
            BosKoltuk++;
        }
    }
    public class SalonB : ISalonlar
    {
        public SalonB(int kap)
        {
            ToplamKoltuk = kap;
            BosKoltuk = ToplamKoltuk;
        }

        public int ToplamKoltuk;
        public int BosKoltuk;
        public double Bakiye = 0;
        public double Fiyat = 20.0;
        public void BosKoltukOgren()
        {
            Console.WriteLine("A Salonunda Boş Koltuk Sayısı=" + BosKoltuk);
        }

        public void Ekle()
        {

            Bakiye += Fiyat;
            BosKoltuk--;

        }

        public void Iptal()
        {
            Console.WriteLine("Film Başarıyla İptal Edildi");
            Bakiye -= Fiyat;
            BosKoltuk++;
        }

        public double  BakiyeOgren()
        {
            return Bakiye;
        }
    }
    public class SalonC : ISalonlar
    {
        public void BosKoltukOgren()
        {
            Console.WriteLine("A Salonunda Boş Koltuk Sayısı=" + BosKoltuk);
        }
        public SalonC(int kap)
        {
            ToplamKoltuk = kap;
            BosKoltuk = ToplamKoltuk;
        }

        public int ToplamKoltuk;
        public int BosKoltuk;
        public double Bakiye = 0;
        public double Fiyat = 20.0;


        public void Ekle()
        {

            Bakiye += Fiyat;
            BosKoltuk--;

        }

        public void Iptal()
        {
            Console.WriteLine("Film Başarıyla İptal Edildi");
            Bakiye -= Fiyat;
            BosKoltuk++;
        }

        public double BakiyeOgren()
        {
            return Bakiye;
        }
    }
    public class SalonD : ISalonlar
    {
        public void BosKoltukOgren()
        {
            Console.WriteLine("A Salonunda Boş Koltuk Sayısı=" + BosKoltuk);
        }
        public SalonD(int kap)
        {
            ToplamKoltuk = kap;
            BosKoltuk = ToplamKoltuk;
        }

        public int ToplamKoltuk;
        public int BosKoltuk;
        public double Bakiye = 0;
        public double Fiyat = 20.0;


        public void Ekle()
        {

            Bakiye += Fiyat;
            BosKoltuk--;

        }

        public void Iptal()
        {
            Console.WriteLine("Film Başarıyla İptal Edildi");
            Bakiye -= Fiyat;
            BosKoltuk++;
        }

        public double BakiyeOgren()
        {
            return Bakiye;
        }
    }

}
