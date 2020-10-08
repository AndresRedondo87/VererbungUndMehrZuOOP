using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VererbungUndMehrZuOOP
{

    // VideoPost erbt von Post und fügt eine Eigenschaft (VideoURL) und zwei Konstruktoren hinzu
    // VideoURL ist einfach der link zum Bild wo es auch immer gespeichert ist

    // die : Post sagt uns dass diese Klasse eine unterklasse von Post ist.
    // damit wird alles von Post in VideoPost vererbt
    class VideoPost : Post
    {
        // HERAUSFORDERUNG 
        // Füge eine erbende Klasse "VideoPost" hinzu, mit den Eigenschaften VideoURL und Length
        // Erstelle die benötigten Konstrutoren um ein VideoPost Objekt anzulegen
        // Passe die ToString Methode entsprechend an
        // Erstelle eine Instanz von VideoPost und verwende die ToString Methode darauf.

        // Für Fortgeschrittene:
        // Verwende einen Timer und eine Callback Methode in diesem Beispiel (google wie das geht) ;)
        // Erstelle die Felder die Benötigt werden
        // Füge die Member Methode "Play" hinzu, welche regelmäßig die aktuelle Laufzeit des Videos anzeigen soll
        // Füge eine "Stop" Methode hinzu, welche den "Timer" stoppt und auf die Konsole schreibt "Angehalten bei {0}s" 
        // Spiele das Video nach der Erstellung der Instanz ab und stoppe es, wenn der Benutzer irgendeine Taste drückt.


        // Member Feld - Für fortg.
        protected bool isPlaying = false;
        protected int currDuration = 0;     //aktuelle dauer des Videos, wo sind wir gerade
        Timer timer;                        // timers brauchen System.Threading... war schon da.

        //Eigenschaften
        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        //TimerCallback VideotimerCallback;#
        //Timer stateTimer = new Timer(timerCallback, VideoTimerState, VideoDuration.TotalMilliseconds(),);


        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublic, int length)
        {
            //von Post geerbt
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUsername;
            this.IsPublic = isPublic;
            // Eigenschaft VideoURL welche ein Member der VideoPost Klasse ist. Jedoch nicht von Post.
            this.VideoURL = videoURL;
            this.Length = length;
        }

        public override string ToString()
        {
            //return String.Format("{0} - {1} - von {2}, BILD: {3}", this.ID, this.Title, this.SendByUserName, this.VideoURL);
            //selber Formatierung verbessert
            return String.Format($"{this.ID} - {this.Title} - von {this.SendByUserName}, \n\tVIDEO: {this.VideoURL}\n\tLength: {this.Length}");
        }

        public void Play()
        {
            if (!isPlaying) //wenn video schon lauft, dann machen wir gar nichts.
            {
                isPlaying = true;
                Console.WriteLine("Spiele Video ab");
                timer = new Timer(MyTimerCallBack, null, 0, 1000);
                // TimerCallBack,Zustand(null)erstmal egal, starten ab 0 und periode 1000ms bzw. 1 Sekunde.
                // JEDE SEKUNDE NACH AUFRUF VON DIESE TIMER, WIRD DIE TimerCallBack AUFGERUFEN!!
                // das ist der Sinn von diese Timer bzw TimerCallback!
            }
        }

        // WTF TIMER CALLBACK MIT OBJEKT PARAMETER!!!!!!
        //SOWAS KENNT MAN BISHER GAR NICHT!!!
        private void MyTimerCallBack(Object o)
        {
            if (currDuration < Length)  // Video noch nicht fertig.
            {
                currDuration++;
                Console.WriteLine("Video ist bei {0}s", currDuration);
                GC.Collect();
                //GARBAGE COLLECTOR WAS SOLL DER SCHEISS HIER EHRLICH!!
                //GC.Collect() machtSpeicher frei "mull, overhead"
            }
            else                       //Video beendet (bis zum Ende gespielt)
            {
                Stop();
            }
        }

        // wenn zu Ende ist, Timer Löschen und current duration zurück zu 0 setzen
        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;  //es spielt nicht mehr
                Console.WriteLine("Angehalten bei {0}s", currDuration); // eigentlich immer das gleiche
                currDuration = 0;
                timer.Dispose();    // timer ins Müll wegwerfen.
            }
        }
    }
}
