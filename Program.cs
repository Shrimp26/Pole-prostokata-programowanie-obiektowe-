// Proszę napisać zgodnie z zasadami paradygmatu obiektowego program w języku C#, który oblicza pole prostokąta. Klasa powinna zawierać trzy metody:
// read_data() — umożliwia wprowadzenie do programu wartości boków a i b z klawiatury. W programie należy przyjąć, że boki a i b oraz zmienna surface_area są typu double (typu rzeczywistego)
// process_data() — oblicza pole prostokąta według wzoru: surface_area = a * b
// show_results() — wyświetla wartości boków a i b oraz wartość zmiennej surface_area w określonym formacie. Dla zmiennych a i b oraz surface_area należy przyjąć format wyświetlania tych zmiennych na ekranie z dwoma miejscami po przecinku

using System;

namespace PoleProstokąta
{
    class Prostokąt
    {
        private double a;
        private double b;
        private double polePowierzchni;

        // Pobieranie danych od użytkownika
        public void ReadData()
        {
            Console.Write("Wprowadź długość boku a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Wprowadź długość boku b: ");
            b = Convert.ToDouble(Console.ReadLine());
        }

        // Obliczanie powierzchni na podstawie podanych przez użytkownika danych 
        public void ProcessData()
        {
            polePowierzchni = a * b;
        }

        // Method to show results
        public void ShowResults()
        {
            Console.WriteLine("Długość boku a: {0:F2}", a);
            Console.WriteLine("Długość boku b: {0:F2}", b);
            Console.WriteLine("Pole powierzchni prostokąta: {0:F2}", polePowierzchni);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Prostokąt rectangle = new Prostokąt();

            rectangle.ReadData();
            rectangle.ProcessData();
            rectangle.ShowResults();
        }
    }
}
