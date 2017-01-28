using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.T1Henkilorekisteri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tehtävä1
            //TestaaHenkiloRekisteri();
            //Tehtävä2
            //LevytJärjestykseen();
            //Tehtävä3
            KortitSekaisin();

        }
        static void TestaaHenkiloRekisteri()
        {
            //luodaan muutama testi henkilö
            Henkilot poppoo = new Henkilot();
            Henkilo hlo = new Henkilo { Etunimi = "Jack", Sukunimi = "Sparrow", Hetu = "311270-123A" };
            Henkilo hlo1 = new Henkilo { Etunimi = "Kirsi", Sukunimi = "Kernell", Hetu = "121270-234B" };
            Henkilo hlo2 = new Henkilo { Etunimi = "Mat", Sukunimi = "Mickelson", Hetu = "011280-456C" };
            //lisätään henkilöt poppooseen
            poppoo.LisaaHenkilo(hlo);
            poppoo.LisaaHenkilo(hlo1);
            poppoo.LisaaHenkilo(hlo2);

            //tulostetaan poppoo näytölle
            foreach (Henkilo h in poppoo.Henkilolista)
            {
                Console.WriteLine("Henkilö {0}", h.ToString());
            }
            //TODO kysy käyttäjältä  hetu ja haetaan sitä vastaava  henkilö näytölle

        }
        static void LevytJärjestykseen()
        {
            CD levy = new CD();
            levy.Title = "In Times";
            levy.Artist = "Enslaved";
            levy.Year = 2015;
            Song sng = new Song { Name = "Thurisaz Dreaming", Duration = "8:14" };
            Song sng1 = new Song { Name = "Building with Fire", Duration = "8:50" };
            Song sng2 = new Song { Name = "One Thousand Years of Rain", Duration = "8:14" };
            Song sng3 = new Song { Name = "Nauthir Bleeding", Duration = "8:11" };
            Song sng4 = new Song { Name = "In Times", Duration = "10:45" };
            Song sng5 = new Song { Name = "Daylight", Duration = "8:56" };

            levy.AddTrack(sng);
            levy.AddTrack(sng1);
            levy.AddTrack(sng2);
            levy.AddTrack(sng3);
            levy.AddTrack(sng4);
            levy.AddTrack(sng5);
            
            foreach (Song s in levy.Tracklist)
            {
                Console.WriteLine("Kappale {0}", s.ToString());
            }

            Console.ReadKey();
        }
        static void KortitSekaisin()
        {
            string[] korttipakka = new string[52];
            int x;
            for(int i = 0; i < 52; i++)
            {
                if(i < 13)
                {
                    x = i + 1;
                    korttipakka[i] = "Pata #" + x;
                }
                if(i > 12 && i < 26)
                {
                    x = i - 12;
                    korttipakka[i] = "Hertta #" + x;
                }
                if (i > 25 && i < 39)
                {
                    x = i - 25;
                    korttipakka[i] = "Risti #" + x;
                }
                if (i > 38 && i < 52)
                {
                    x = i - 38;
                    korttipakka[i] = "Ruutu #" + x;
                }
            }
            for (int i = 0; i < 52; i++)
            {
                x = i + 1;
                Console.WriteLine(x + " kortti on " + korttipakka[i]);
            }
            Console.ReadKey();
        }
    }
}
