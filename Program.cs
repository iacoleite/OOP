
namespace OOP;

public class Program {
    public static void Main(String[] args) {
        // Console.WriteLine("pqp");
        // ContoCorrente contoCorrente = new ContoCorrente();

        // Console.WriteLine(contoCorrente.Saldo());

        Obiettivo obiettivo= new Obiettivo();
        Microfono microfono= new Microfono();
        Lente lente= new Lente();

        // Camera camera= new Camera(lente, obiettivo, microfono);

        // Console.WriteLine(camera.microfono.TipoMicrofono.ToString());

        // Camera cameraAuto= new Camera();

        // Console.WriteLine(camera.lente.TipoLente.ToString());
        // Console.WriteLine(cameraAuto.lente.TipoLente.ToString());

        // camera.Registra();

        // camera.StopRegistra();

        // cameraAuto.Registra();
        // cameraAuto.StopRegistra();

        // ControlloRemotoVideoCamera controllo =  new ControlloRemotoVideoCamera(camera);

        CompactCamera compactCamera= new CompactCamera();

        ControlloRemotoVideoCamera controlloRemoto2 = new ControlloRemotoVideoCamera(compactCamera);

        

    }
}

