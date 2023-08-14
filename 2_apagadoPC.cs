using System;

namespace TemporizadorApagado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temporizador de apagado de la computadora");

            // Pedir al usuario la cantidad de minutos
            Console.WriteLine("Ingresa la cantidad de minutos para el temporizador: ");
            int minutos;
            if (int.TryParse(Console.ReadLine(), out minutos))
            {
                // Calcular el tiempo en milisegundos
                int tiempoEnMilisegundos = minutos * 60000; // 1 minuto = 60000 milisegundos

                // Mostrar mensaje de confirmación
                Console.WriteLine($"La computadora se apagará en {minutos} minutos.");
                Console.WriteLine("Presiona cualquier tecla para cancelar el temporizador...");

                // Iniciar temporizador
                System.Threading.Thread.Sleep(tiempoEnMilisegundos);

                // Apagar la computadora
                Console.WriteLine("Apagando la computadora...");
                System.Diagnostics.Process.Start("shutdown", "/s /f /t 0");
            }
            else
            {
                Console.WriteLine("Cantidad de minutos inválida. El programa se cerrará.");
            }
        }
    }
}