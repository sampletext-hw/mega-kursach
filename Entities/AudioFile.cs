﻿using System.Collections.Generic;

namespace Entities
{
    public class AudioFile : TitledEntity
    {
        public List<string> Artists { get; set; }
        public int GenreId { get; set; }
        public int ArtId { get; set; }

        public AudioFile(int id, string title, List<string> artists, int genreId, int artId) : base(id, title)
        {
            Artists = artists;
            GenreId = genreId;
            ArtId = artId;
        }
    }
}