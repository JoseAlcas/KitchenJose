using System;

namespace JoséAlcas
{
    class Program

    {
        static void Main(string[] args)
        {
            //Texto de inicio

            Console.WriteLine("¡Bienvenido a la Cocina Chef!");
            Console.WriteLine("");
            Console.WriteLine("Cuando desee empezar pongase su sombrero y presione cualquier tecla");
            Console.WriteLine("");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("");
            Console.Clear();
            Console.WriteLine("¡Eso es!, Chef, Los clientes estan impacientes asi que dejeme mostrarle las opciones de frutas");
            Console.WriteLine("");
            Fruta fruta = new Fruta();
            fruta.ProductoFruta();
            string SeleccionarFruta = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Buena elección");
            Console.WriteLine("");
            Console.Clear();
            Console.WriteLine("Ahora dejeme mostrarle las opciones de carnes");
            Console.WriteLine("");
            Carne carne = new Carne();
            carne.ProductoCarne();
            string SeleccionarCarne = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Buena elección");
            Console.WriteLine("");
            Console.Clear();
            Console.WriteLine("Ahora dejeme mostrarle las opciones de colesterol");
            Console.WriteLine("");
            Colesterol colesterol = new Colesterol();
            colesterol.ProductoColesterol();
            string SeleccionarColesterol = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Buena elección");
            Console.WriteLine("");
            Console.Clear();
            Console.WriteLine("Ahora dejeme mostrarle las opciones de energetico");
            Console.WriteLine("");
            Energetico energetico = new Energetico();
            energetico.ProductoEnergetico();
            string SeleccionarEnergetico = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Buena elección");
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Ahora dejeme mostrarle las opciones de condimento");
            Console.WriteLine("");
            Condimento condimento = new Condimento();
            condimento.ProductoCondimento();
            string Seleccionarcondimento = Console.ReadLine();
            Console.WriteLine("Buena elección");
            Console.WriteLine("");
            Console.Clear();
            Console.WriteLine("Gracias los elementos seleccionados son los siguientes "+ SeleccionarFruta + "," +  SeleccionarCarne + "," + SeleccionarColesterol + "," +  SeleccionarEnergetico + "," + Seleccionarcondimento );
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para servir");
            Console.ReadKey();
           
            
        }
    }
}
