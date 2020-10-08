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
            Console.WriteLine("Vererbung Demo:");

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
            Console.WriteLine($"NORMAL POST ToString Methode: {post1.ToString()}");
            //


            // IMAGE POSTS
            // wie normaler Post aber mit + Image Link
            ImagePost bildPost1 = new ImagePost("Hier sind sie!", "Denis Panjuta", "https://bilder.de/meineschuhe", true);
            Console.WriteLine("IMAGE POST ToString Methode : {0}", bildPost1.ToString());    
            // hier funktioniert ToString auch wie beim normalerPost
            // ID ist schon nach 2 hochgezählt
            // nur wir sehen noch kein ImageURL

            //VIDEO POSTS



            Console.ReadKey();
        }
    }
}
