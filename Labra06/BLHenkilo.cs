using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    /// <summary>
    /// This class contains person properties
    /// </summary>
    class Henkilo
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Hetu { get; set; }
        public override string ToString()
        {
            return base.ToString();
            {
                return Etunimi + " " + Sukunimi + " " + Hetu;
            }
        }
    }
    ///This class holds person information in a collection
    ///
    class Henkilot
    {
        private List<Henkilo> henkilot;
        public Henkilot()
        {
            henkilot = new List<Henkilo>();
        }
        public void LisaaHenkilo(Henkilo hlo)
        {
            henkilot.Add(hlo);
        }
        public Henkilo HaeHenkilo(int index)
        {
            if (index < henkilot.Count)
            {
                return henkilot.ElementAt(index);
            }
            else
            {
                return null;
            }
        }
    }
}
