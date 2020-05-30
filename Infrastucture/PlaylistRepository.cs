﻿using System.Collections.Generic;
using System.Linq;
using Entities;
using Infrastucture;

namespace Infrustucture
{
    public class PlaylistRepository : AuditableEntityRepository<Playlist>, IPlaylistRepository
    {
        private readonly AppDbContext _dbContext;

        public PlaylistRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IReadOnlyList<Playlist> GetPlaylistByOwner(int ownerId)
        {
            return _dbContext.Playlists.Where(x => x.OwnerId.Equals(ownerId)).ToList();
        }

        public IReadOnlyList<Playlist> GetPlaylists()
        {
            return _dbContext.Playlists.ToList();
        }

        public IReadOnlyList<Playlist> GetPlaylistsByTitle(string title)
        {
            return _dbContext.Playlists.Where(x => x.Title.Contains(title)).ToList();
        }
    }
}