using System.ComponentModel.DataAnnotations;


namespace OOP 
{
    
    public class Lente {
        public string TipoLente { get; set; } = "Statica";
        // public Lente(){
        //     // custom constructor
        //     this.TipoLente = "";
        // }
        public override string ToString() {
        return TipoLente;
        }
    }
    
    public class Obiettivo {
        public string TipoObiettivo { get; set; } = "Zoom x2";
        public override string ToString() {
            return TipoObiettivo;
        }
    }

    public class Microfono {
        public string TipoMicrofono { get; set; } = "Dinamico";

        public override string ToString() {
        return TipoMicrofono;
        }
    }
    public class Camera : ICamera{

        public virtual bool RichiestoStop { get; set; } = false;
        public virtual bool StaRegistrando { get; set; } = false;
        public Lente lente { get; set; }
        public Obiettivo obiettivo { get; set; }
        public Microfono microfono { get; set; }
         
        // overloaded constructor
        public Camera(Lente l, Obiettivo o, Microfono m) {
            this.lente = l;
            this.obiettivo = o;
            this.microfono = m;
        }

        //default constructor
        public Camera() {
            this.obiettivo = new Obiettivo();
            this.lente = new Lente();
            this.microfono = new Microfono();
            this.lente.TipoLente = "Special";
        }
        public Camera(Camera cam) {
            this.obiettivo = cam.obiettivo;
            this.lente = cam.lente;
            this.microfono = cam.microfono;
            this.lente.TipoLente = "Special";
        }

        public override string ToString() {
            string teste =  "Camera con la lente " + this.lente;
            return teste;
        }


        public virtual void Registra() {
            //toDo
            // Console.WriteLine("Sto registrando con la lente " + this.lente);

            RichiestoStop = false;
            if (StaRegistrando) {
                Console.WriteLine("Videcamera già in registrazione!" + this.lente);
                return;
            } 
            StaRegistrando = true;
            Console.WriteLine("Inizio reegistrazione ... (premi 's' per fermare)");
            Random rn = new Random();
            while(!RichiestoStop) {
                var i = rn.Next(0, 1000) % 2;
                Console.Write(i == 0 ? "@" : "*");
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.S) {
                    this.StopRegistra();
                    Console.WriteLine(" ||||||||||||||| STOP |||||||||||||||");
                }
            }
        }


        public virtual void StopRegistra() {
            if (!StaRegistrando) {
                Console.WriteLine("La videocamera non è in registrazione.");
                return;
            }
            this.RichiestoStop = true;
            this.StaRegistrando = false;
        }
    }








// CompactCamera (classe filha) extends Camera (em java ha)
    public class CompactCamera : Camera {
        
        string display {get; set;} = "LCD";

        public override void Registra()
        {
            Console.WriteLine("REGISTRO DELLA CAMERA COMPATTA |||||");

            // base eh super em Java, referencia a classe mae
            base.Registra();
        }
    }
}