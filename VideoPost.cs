using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungUndMehrZuOOP
{

    // VideoPost erbt von Post und fügt eine Eigenschaft (VideoURL) und zwei Konstruktoren hinzu
    // VideoURL ist einfach der link zum Bild wo es auch immer gespeichert ist

    // die : Post sagt uns dass diese Klasse eine unterklasse von Post ist.
    // damit wird alles von Post in VideoPost vererbt
    class VideoPost : Post
    {
        public string VideoURL { get; set; }

        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUsername;
            this.IsPublic = isPublic;
            // Eigenschaft VideoURL welche ein Member der VideoPost Klasse ist. Jedoch nicht von Post.
            this.VideoURL = videoURL;
        }

        public override string ToString()
        {
            //return String.Format("{0} - {1} - von {2}, BILD: {3}", this.ID, this.Title, this.SendByUserName, this.VideoURL);
            //selber Formatierung verbessert
            return String.Format($"{this.ID} - {this.Title} - von {this.SendByUserName}, \n\tVIDEO: {this.VideoURL}");
        }
    }
}
