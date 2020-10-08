using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungUndMehrZuOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vererbung Demo:\n\n");

            //// Kurzer test für Methoden für alle Objekte zu sehen
            ///// Da sieht man die Equals, GetHashCode, GetType, ToString und Update Methoden.
            //// wir sehen schon unsere eigene Update da weil wir es schon implementiert haben.
            //// wir sehen da aber nicht der GetNextID Methode da es protected ist,
            //// das heisst es ist nur unter Post und seine vererbten Klassen verfügbar!
            //Post post1 = new Post();
            //// Post() Konstruktor hat "+1 Überladung" das ist unsere verbessere Konstruktor mit den ganzen Parameter
            //post1.

            Post post1 = new Post("Meine neue Schuhe sind geil!", true, "Denis Panjuta");
            // 1 - Meine neue Schuhe sind geil! - von Denis Panjuta 
            // hier sieht man schon die Parameter übergabe funktioniert und die GetNextID Methode auch (und natürlich auch die angepasste ToString)

            // Testen das Default(normale) ToString: "VererbungUndMehrZuOOP.Post"
            // Testen das bearbeitete ToString: "0 - Mein erster Post - von Denis Panjuta"
            Console.WriteLine($"NORMAL POST ToString Methode: \n{post1.ToString()}\n");
            //


            // IMAGE POSTS
            // wie normaler Post aber mit + Image Link
            ImagePost bildPost1 = new ImagePost("Hier sind sie!", "Denis Panjuta", "https://bilder.de/meineschuhe", true);
            Console.WriteLine("IMAGE POST ToString Methode : \n{0}\n", bildPost1.ToString());
            // hier funktioniert ToString auch wie beim normalerPost
            // ID ist schon nach 2 hochgezählt
            // nur wir sehen noch kein ImageURL

            //VIDEO POSTS
            // wie normaler Post aber mit + Video Link
            VideoPost videoPost1 = new VideoPost("so renne ich schneller!", "Denis Panjuta", "https://videos.de/meineSprints", true, 95);
            Console.WriteLine("VIDEO POST ToString Methode : \n{0}\n", videoPost1.ToString());



            Console.ReadKey();
        }


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

    }
}
