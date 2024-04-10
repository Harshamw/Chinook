using Chinook.ClientModels;
using Microsoft.EntityFrameworkCore;

namespace Chinook.Models
{
    public partial class PlaylistTracks
    {

        public long PlaylistId { get; set; }
        public long TrackId { get; set; }

        public virtual Playlist Playlists { get; set; }
        public virtual Track Track { get; set; }



    }
}