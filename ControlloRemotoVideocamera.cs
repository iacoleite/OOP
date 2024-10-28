
using OOP;

namespace OOP
{
    public interface ICamera 
    {
        void Registra();
        void StopRegistra();
    }
    public class ControlloRemotoVideoCamera
    {
      
        public ICamera camera { get; set; }
        public ControlloRemotoVideoCamera(ICamera camera)
        {
            this.camera=camera;
            Console.WriteLine("Premi 'r' per avviare la registrazione, 's' per fermarla, 'q' per uscire.");

            bool running = true;
            while (running)
            {
                // Legge l'input dell'utente
                var input = Console.ReadKey(intercept: true).Key;

                switch (input)
                {
                    case ConsoleKey.R:
                        this.camera.Registra();
                        break;

                    case ConsoleKey.S:
                        this.camera.StopRegistra();
                        break;

                    case ConsoleKey.Q:
                        running = false; // Esce dal ciclo
                        break;

                    default:
                        Console.WriteLine("Comando non riconosciuto.");
                        break;
                }
            }
        }
        
    }
}