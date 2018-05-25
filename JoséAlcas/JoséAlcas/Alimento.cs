using System;
using System.Collections.Generic;
using System.Text;

namespace JoséAlcas
{
    class Alimento
    {
        //Variables

        public float precio;
        public float cantidad;
    }

    class Fruta : Alimento
    {
        public string productoFruta { get; private set; }

        public void ProductoFruta()
        {
            Console.WriteLine();
            Console.WriteLine(productoFruta);
            Console.WriteLine("Elije uno");
            Console.WriteLine();
        }

        public Fruta()
        {
            Console.WriteLine("Sandia");
            Console.WriteLine("Platano");
            Console.WriteLine("Manzana");
        }
    }

    class Carne: Alimento
    {
        public string productoCarne { get; private set; }

        public void ProductoCarne()
        {
            Console.WriteLine();
            Console.WriteLine(productoCarne);
            Console.WriteLine("Elije uno y confirme con la tecla Enter");
            Console.WriteLine();
        }

        public Carne()
        {
            Console.WriteLine("Pollo");
        }

    }

    class Colesterol : Alimento
    {
        public string productoColesterol { get; private set; }

        public void ProductoColesterol()
        {
            Console.WriteLine();
            Console.WriteLine(productoColesterol);
            Console.WriteLine("Elije uno y confirme con la tecla Enter");
            Console.WriteLine();
        }

        public Colesterol()
        {
            Console.WriteLine("Huevo");
            Console.WriteLine("Mantequilla");
        }
    }

    class Energetico : Alimento
    {
        public string productoEnergetico { get; private set; }

        public void ProductoEnergetico()
        {
            Console.WriteLine();
            Console.WriteLine(productoEnergetico);
            Console.WriteLine("Elije uno y confirme con la tecla Enter");
            Console.WriteLine();
        }

        public Energetico()
        {
            Console.WriteLine("Pan");
            Console.WriteLine("Fideo");
        }
    }

    class Condimento : Alimento
    {
        public string productoCondimento { get; private set; }

        public void ProductoCondimento()
        {
            Console.WriteLine();
            Console.WriteLine(productoCondimento);
            Console.WriteLine("Elije uno y confirme con la tecla Enter");
            Console.WriteLine();
        }

        public Condimento()
        {
            Console.WriteLine("Sal");
            Console.WriteLine("Ajo");
            Console.WriteLine("Pimienta");
            Console.WriteLine("Ajinomoto");
        }
    }
}
