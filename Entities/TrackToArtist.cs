﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class TrackToArtist
    {
        public int Id { get; set; }
        public Track Track { get; set; }
        public ArtistData Artist { get; set; }

        public TrackToArtist(Track track, ArtistData artist)
        {
            Track = track;
            Artist = artist;
        }

        public TrackToArtist()
        {
        }
    }
}