using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungUndMehrZuOOP
{

    // ImagePost erbt von Post und fügt eine Eigenschaft (ImageURL) und zwei Konstruktoren hinzu
    // ImageURL ist einfach der link zum Bild wo es auch immer gespeichert ist

    // die : Post sagt uns dass diese Klasse eine unterklasse von Post ist.
    // damit wird alles von Post in ImagePost vererbt
    class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            //wir setzen wieder die ganze Eigenschaften  die von Post vererbt sind
            this.ID = GetNextID();
            // das funktioniert weil GetNextID aus der Post Klasse kommt, es ist Protected, das heisst Unterklassen dürfen es benutzen! 
            // wenn es Private wäre dann hatte es gar nicht geklappt, macht Fehler: 
            // "Fehler  CS0122  'Der Zugriff auf "Post.GetNextID()" ist aufgrund des Schutzgrads nicht möglich.	

            this.Title = title;
            this.SendByUserName = sendByUsername;
            this.IsPublic = isPublic;

            // und setzen auch unsere EIGENE Eigenschaften von ImagePost (gar nicht von Post!!)
            // Eigenschaft ImageURL welche ein Member der ImagePost Klasse ist. Jedoch nicht von Post.
            this.ImageURL = imageURL;
        }

        // Herausforderung ToString anpassen um die URL auch anzuzeigen!! gut geklappt und soar besser formatiert!
        // Virtual Methoden können von erbenden Klassen überschrieben werden
        public override string ToString()
        {
            //return String.Format("{0} - {1} - von {2}, BILD: {3}", this.ID, this.Title, this.SendByUserName, this.ImageURL);
            //selber Formatierung verbessert
            return String.Format($"{this.ID} - {this.Title} - von {this.SendByUserName}, \n\tBILD: {this.ImageURL}");
        }
    }
}
