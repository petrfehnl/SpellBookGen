using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpellBookGen;

namespace SpellBookGen
{
    internal class HelperClass
    {
        public Random generator = new Random();

        public string[] PoleZTextu(string adresaSouboru)
        {
            string obsahTxt = File.ReadAllText(adresaSouboru);
            string[] pole = obsahTxt.Split(";");
            return pole;
        }
        public string VygenerujSpeelname(string[] poleForma, string[] poleTypy)
        {
            int index = generator.Next(0, poleForma.Length);
            int index2 = generator.Next(0, poleTypy.Length);
            string text1 = poleTypy[index2];
            string text2 = poleForma[index];
            return text1 + text2;
        }

        public int VygenerujCislo(int max)
        {
            int Cislo = generator.Next(0, max);
            return Cislo;
        }


    }
}