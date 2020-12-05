﻿using System;

namespace SoundCloudClone.Models.App
{
    public class SearchResult
    {
        public object Data { get; private set; }

        public SearchResult(Playlist playlist)
        {
            Data = playlist;
        }
    }
}
