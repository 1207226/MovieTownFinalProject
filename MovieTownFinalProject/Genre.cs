using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTownFinalProject
{
    internal class Genre
    {
        public Genre(int genreId, string genreName)
        {
            this.GenreId = genreId;
            this.GenreName = genreName;
        }
        public int GenreId { get; }

        public string GenreName { get; }
    }
}
