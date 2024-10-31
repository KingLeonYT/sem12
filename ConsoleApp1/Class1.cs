namespace ejercicio
{
    internal class Estudiantes
    {
        byte[] edades = new byte[0];
        int posiciones = 0;
        Estudiantes en = new Estudiantes();

        public void insertar()
        {
            string seguir;
            byte ed;
            do
            {
                Console.WriteLine("Ingrese una edad");
                while (!byte.TryParse(Console.ReadLine(), out ed) || ed > 120 || ed < 14)
                {
                    Console.WriteLine("Error!!!!");
                    Console.WriteLine("Ingrése nuevamente el dato");
                }
                Array.Resize(ref edades, edades.Length + 1);
                edades[posiciones] = ed;
                posiciones++;
                Console.WriteLine("Edad registrada correctamente");
                Console.WriteLine("Desea registrar mas edades");
                seguir = Console.ReadLine().ToLower();

            } while (seguir == "si");
        }
        public void mostrar() 
        { 
            Console.SetCursorPosition(10, 13);
            Console.WriteLine("POSICIÓN");
            Console.SetCursorPosition(30, 12);
            Console.WriteLine("EDADES");
        }
    }
}
