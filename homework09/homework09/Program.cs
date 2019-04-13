using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework09
{
    class Program
    {
        static void Main(string[] args)
        {
            var song = new Song();
            Console.WriteLine(song.GetSongData(song)); 
            Console.Read();
        }
    }

    class Song
    {
        private string _title;
        private int _minutes;
        private string _author;
        private int _year;
        private Genre _genre;

        

        public dynamic GetSongData(Song song)
        {
            Console.Write("Enter the name of the song: ");
            _title = Console.ReadLine();
            Console.Write("Enter diration in minutes: ");
            _minutes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the author: ");
            _author = Console.ReadLine();
            Console.Write("Enter the year of song release: ");
            _year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose a genre from the list (enter a number):");
            var genres = Enum.GetValues(typeof(Genre));
            int i = 1;
            foreach(var genre in genres)
            {
                Console.Write(i + ". ");
                Console.WriteLine(genre);
                i++;
            }
            int genreNumber = Convert.ToInt32(Console.ReadLine());
            switch (genreNumber)
            {
                case 1:
                    _genre = Genre.Classical;
                    break;
                case 2:
                    _genre = Genre.Juzz;
                    break;
                case 3:
                    _genre = Genre.Rock;
                    break;
                case 4:
                    _genre = Genre.Pop;
                    break;
                case 5:
                    _genre = Genre.Blues;
                    break;
                case 6:
                    _genre = Genre.Electronic;
                    break;
                default:
                    _genre = Genre.Classical;
                    break;
            }
            Console.WriteLine();
            return new
            {
                SongTitle = _title,
                Minutes = _minutes,
                Author = _author,
                Year = _year,
                Genre = _genre
            };
        }
    }

    public enum Genre
    {
        Classical,
        Juzz,
        Rock,
        Pop,
        Blues,
        Electronic
    }
}
