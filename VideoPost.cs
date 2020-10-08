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


        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        //TimerCallback VideotimerCallback;#
        //Timer stateTimer = new Timer(timerCallback, VideoTimerState, VideoDuration.TotalMilliseconds(),);


        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublic, int length)
        {
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
    }
}
