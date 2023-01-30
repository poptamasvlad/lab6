using System;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Ex1());
            //Ex2();
        }

        static int Ex1()
        {
            /* Un dulap are trei caracteristici : lungime, latime, inaltime. Dulapul va avea o
            metoda care va calcula volumul acestuia.
            Folositi o clasa care va modela un dulap.
              -Clasa va avea trei campuri private intregi: lungime, latime, inaltime.
              -Cele trei campuri vor fi initializate cu ajutorul constructorului
              -Scrieti o metoda care va calcula volumul dulapului pe baza celor trei campuri.
            Instantiati un dulap in functia Main, apelati metoda de calcul a volumului si
            afisati rezultatul*/

            Dulap dulap = new Dulap();
            return dulap.VolumDulap();
        }

        static void Ex2()
        {
            /* Scrieti un program care va modela un autoturism. Un autoturism va avea o
            marca (string), un numar de inmatriculare (string), precum si o
            capacitate cilindrica(int).
            Autoturismul va avea:
            - Campurile corespunzatoare caracteristicilor autoturismului.
            - Un constructor care va initializa campurile acestuia
            - O metoda “Tiparire” care va afisa pe consola descrierea acestuia sub forma : “marca,
            numarDeInmatriculare, capacitateCilindrica”.
            Folositi: clase, campuri, metode, modificatorii de acces adecvati, comentarii
            xml pentru metodele publice.
            Creeati doua obiecte de tipul autoturism in functia “Main” si apelati-le
            metodele “Tipareste”*/

            Autoturism autoturism1 = new Autoturism();
            Autoturism autoturism2 = new Autoturism();

            autoturism1.Tiparire();
            autoturism2.Tiparire();

        }

        class Dulap
        {
            private readonly int lungime;
            private readonly int latime;
            private readonly int inaltime;

            public int VolumDulap()
            {
                int volum = lungime * latime * inaltime;
                return volum;
            }

            public Dulap()
            {
                lungime = int.Parse(Console.ReadLine());
                latime = int.Parse(Console.ReadLine());
                inaltime = int.Parse(Console.ReadLine());
            }
        }

        class Autoturism
        {
            private readonly string marca;
            private readonly string nrInmatriculare;
            private readonly int capCilindrica;

            public void Tiparire()
            {
                Console.WriteLine(marca + ", " + nrInmatriculare + ", " + capCilindrica);
            }

            public Autoturism()
            {
                marca = Console.ReadLine();
                nrInmatriculare = Console.ReadLine();
                capCilindrica = int.Parse(Console.ReadLine());
            }
        }
    }
}
