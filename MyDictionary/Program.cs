using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dict<int, string> mydict = new Dict<int, string>();
            mydict.Add(1, "elma");
            mydict.Add(2, "armut");
            Console.WriteLine(mydict.Numara[0] + " " + mydict.Deger[0]);
            Console.WriteLine(mydict.Numara[1] + " " + mydict.Deger[1]);

        }
    }


    class Dict<Tkey, Tvalue>
    {
        Tkey[] numara;
        Tvalue[] deger;

        public Dict()
        {
            numara = new Tkey[0];
            deger = new Tvalue[0];

        }


        public void Add(Tkey key, Tvalue val)
        {
            Tkey[] tempNumara;
            Tvalue[] tempDeger;

            tempNumara = numara;
            tempDeger = deger;


            numara = new Tkey[numara.Length + 1];
            deger = new Tvalue[deger.Length + 1];

            for (int i = 0; i < tempNumara.Length; i++)
            {
                numara[i] = tempNumara[i];
            }

            for (int j = 0; j < tempDeger.Length; j++)
            {
                deger[j] = tempDeger[j];
            }

            numara[tempNumara.Length] = key;
            deger[tempDeger.Length] = val;


        }

        public Tkey[] Numara
        {
            get { return numara; }
        }

        public Tvalue[] Deger
        {
            get { return deger; }
        }

    }


}

