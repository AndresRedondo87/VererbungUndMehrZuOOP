using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungUndMehrZuOOP
{
    class Post
    {
        private static int currentPostId;   // ID ist einzigartig nur einmal pro post, egal was für ein typ
                                            //Feld beinhaltet den current wert von ID, unabhängig von Objekten... deswegen Static


        // Eigenschaften/Properties
        //Protected heisst geschützt, nur zugänglich von vererbten Klassen von Post, andere drüber oder andere Klassen durfen sie nicht verwenden(wie Private für den anderen Klassen)
        protected int ID { get; set; }          //Identifikationsnummer
        protected string Title { get; set; }    //Titel des Posts
        protected string SendByUserName { get; set; }   //Gesendet von...
        protected bool IsPublic { get; set; }           // Public (öffentlich) oder nicht



        // Default Konstruktor Info
        //- wird implizit aufgerufen wenn wir keine Parameter übergeben (beim Post Objekt/Element) anlegen.
        // "wenn eine erbende Klasse den Base-Klasse-Konstruktor explizit nicht aufruft, dann wird der Default konstruktor implizit aufgerufen"

        // wenn eine "untere" klasse es nicht explizit aufruft, wird er dann (trotzdem) implizit aufgerufen,(wird später erklärt...hoffe ich)
        // beim explizit heisst es WIR haben es so FEST programmiert
        // beim implizit heisst es es wird "automatisch" aufgerufen bzw. abgefeuert.


        // Default Konstruktor 
        // (einfache gültige Werte initialisierung)
        public Post()
        {
            ID = 0; //ID ist eigentlich einzigartig, deswegen dies hier wird später angepasst, darf es nicht immer gleich null setzen!
            Title = "Mein erster Post";
            IsPublic = true;
            SendByUserName = "Denis Panjuta";
        }

        // Konstruktor mit alle Parameter gesetzt 
        // (ergibt mehr Sinn  Wertr selber eingeben als Default Konstruktor mit gültige aber doofe  und immer die gleiche Werte)
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();          //methode noch nicht angelegt.
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUserName = sendByUsername;
            //this.ImageURL ImageURL ist nur in der Unterklasse verfügbar, hier gar nicht erkannt!!
        }


        // Virtual Methoden können von erbenden Klassen überschrieben werden
        // nicht virtual methoden darf man nicht überschreiben!

        // WOW OVERRIDE HIER AUCH DAS IST ABER HILFREICH!!!!!!

        // hier wird der ToString Methode (aus der Objekt Klasse erstmal geerbt...
        // Diese Methode sind sichtbar beim ein Objekt anzulegen und dann ein Punkt danach schreiben.
        // Da sieht man die Equals, GetHashCode, GetType, ToString und Update Methoden.
        // wir sehen schon unsere eigene Update da weil wir es schon implementiert haben.
        // wir sehen da aber nicht der GetNextID Methode da es protected ist,
        // das heisst es ist nur unter Post und seine vererbten Klassen verfügbar!

        // so, wir bearbeiten unsere ToString um es zu unsere Günsten anzupassen:
        public override string ToString()
        {
            // return "haha, ich habe das  Überschrieben"

            // Text zu formatieren um es als String auszugeben
            // die this sind für klarheit und Struktur zu halten
            //return String.Format("{0} - {1} - von {2}", this.ID, this.Title, this.SendByUserName);
            //selber Formatierung verbessert
            return String.Format($"{this.ID} - {this.Title} - von {this.SendByUserName}");
        }


        //Etwas ändern, aber nur was man ändern darf.
        // Nur title und IsPublic dürfen geändert sein, ID und SendBy darf man gar nicht ändern (logisch)
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        //einfach immer ID inkrementieren um wiederholungen einfach zu vermeiden
        protected static int GetNextID()
        // private int GetNextID() um Zugriffsfehler in ImagePost zu provozieren
        {
            return ++currentPostId;
        }
    }
}
