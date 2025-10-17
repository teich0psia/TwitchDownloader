using System;
using TwitchDownloaderCore;
using TwitchDownloaderCore.Models;
using Xunit;

namespace TwitchDownloaderCore.Tests
{
    public class VideoDownloaderTests
    {
        [Fact]
        public void ParseAndProcessPlaylist_PlaylistWithoutHeader_DoesNotThrowException()
        {
            // Arrange
            var playlistString = "#EXT-X-VERSION:3\n#EXT-X-TARGETDURATION:10\n#EXTINF:10.0,\nsegment1.ts";

            // Act
            var exception = Record.Exception(() => VideoDownloader.ParseAndProcessPlaylist(playlistString));

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void ParseAndProcessPlaylist_PlaylistWithHeader_DoesNotThrowException()
        {
            // Arrange
            var playlistString = "#EXTM3U\n#EXT-X-VERSION:3\n#EXT-X-TARGETDURATION:10\n#EXTINF:10.0,\nsegment1.ts";

            // Act
            var exception = Record.Exception(() => VideoDownloader.ParseAndProcessPlaylist(playlistString));

            // Assert
            Assert.Null(exception);
        }

    }
}
