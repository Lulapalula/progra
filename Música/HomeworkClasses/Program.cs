using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClasses
{
    class Classes
    {
        static void Main(string[] args)
        {
            //viva aurora la amo
            //artistas y sus albums
            Album Aurora = new Album();
            Aurora.AlbumName1 = "Under stars";
            Aurora.AlbumName2 = "The gods we can touch";
            Aurora.AlbumName3 = "Infections of a diferent kind";
            Aurora.AlbumName4 = "Meeting my demons as my friends";
            Aurora.AlbumName5 = "Hunting shadows";

            //Taylor la industria de la música
            Album TaylorSwift = new Album();

            TaylorSwift.AlbumName1 = "Taylor swift";
            TaylorSwift.AlbumName2 = "fearless";
            TaylorSwift.AlbumName3 = "Speak now";
            TaylorSwift.AlbumName4 = "Red";
            TaylorSwift.AlbumName5 = "1989";

            Album TheWeeknd = new Album();

            TheWeeknd.AlbumName1 = "AftherHours";
            TheWeeknd.AlbumName2 = "StarBoy";
            TheWeeknd.AlbumName3 = "DawnFM";
            TheWeeknd.AlbumName4 = "LiveAtSoFiStadium";
            TheWeeknd.AlbumName5 = "MyDearMenlancholy";

            Album Enigma = new Album();

            Enigma.AlbumName1 = "The fall of a rebel angel";
            Enigma.AlbumName2 = "The screen behind the mirror";
            Enigma.AlbumName3 = "A posteriori";
            Enigma.AlbumName4 = "The cross of changes";
            Enigma.AlbumName5 = "Voyageur";

            Album TwentyOnePilots = new Album();

            TwentyOnePilots.AlbumName1 = "Self tittled";
            TwentyOnePilots.AlbumName2 = "Scaled and icy";
            TwentyOnePilots.AlbumName3 = "Trench";
            TwentyOnePilots.AlbumName4 = "Blurryface";
            TwentyOnePilots.AlbumName5 = "Vessel";

            //Artistas de distintas nacionalidades 


            Artista Japones = new Artista();

            Japones.Cantante1 = "Crusher p";
            Japones.Cantante2 = "Ado";
            Japones.Cantante3 = "Perfume";
            Japones.Cantante4 = "Mili";
            Japones.Cantante5 = "Belle";


            Artista Latino = new Artista();

            Latino.Cantante1 = "WOS";
            Latino.Cantante2 = "PabbloVittar";
            Latino.Cantante3 = "MalumaBaby";
            Latino.Cantante4 = "Lagos";
            Latino.Cantante5 = "Morat";

            Artista US = new Artista();

            US.Cantante1 = "OliviaRodrigo";
            US.Cantante2 = "TaylorSwift";
            US.Cantante3 = "Brenn";
            US.Cantante4 = "Ayesha";
            US.Cantante5 = "SamSmith";

            Artista Espaniol = new Artista();

            Espaniol.Cantante1 = "Rosalia";
            Espaniol.Cantante2 = "AlejandroSanz";
            Espaniol.Cantante3 = "PabloAlboran";
            Espaniol.Cantante4 = "Manuel Carrasco";
            Espaniol.Cantante5 = "CTangana";

            Artista Koreanos = new Artista();

            Koreanos.Cantante1 = "AgustD";
            Koreanos.Cantante2 = "Lalisa";
            Koreanos.Cantante3 = "JHope";
            Koreanos.Cantante4 = "JeonJunkook";
            Koreanos.Cantante5 = "Momo";

            //Canciones de algunos atistas

            Cancion Enigma1 = new Cancion();

            Enigma1.SongName1 = "circle eight";
            Enigma1.SongName2 = "TheOmegaPoint";
            Enigma1.SongName3 = "Diving";
            Enigma1.SongName4 = "TheDieIsCast";
            Enigma1.SongName5 = "AgnusDei";

            Cancion LanaDelRey = new Cancion();

            LanaDelRey.SongName1 = "TheBlackestDay";
            LanaDelRey.SongName2 = "Paris";
            LanaDelRey.SongName3 = "Peppers";
            LanaDelRey.SongName4 = "DoinTime";
            LanaDelRey.SongName5 = "StargirlInterlude";


            Cancion Ashnikko = new Cancion();

            Ashnikko.SongName1 = "Cheerleader";
            Ashnikko.SongName2 = "Toxic";
            Ashnikko.SongName3 = "DealWithIt";
            Ashnikko.SongName4 = "LittleBoy";
            Ashnikko.SongName5 = "Weedkiller";

            Cancion SirMixALot = new Cancion();

            SirMixALot.SongName1 = "BabyGotBack";
            SirMixALot.SongName2 = "Ride";
            SirMixALot.SongName3 = "BarkLikeYouWantIt";
            SirMixALot.SongName4 = "PosseOnBroadway";
            SirMixALot.SongName5 = "JumpOnIt";

            Cancion Kalandra = new Cancion();
            Kalandra.SongName1 = "VirkelighetensEtterklang";
            Kalandra.SongName2 = "Helheim";
            Kalandra.SongName3 = "Valkyrja";
            Kalandra.SongName4 = "Ensom";
            Kalandra.SongName5 = "Helvengen";
        }
    }
}
