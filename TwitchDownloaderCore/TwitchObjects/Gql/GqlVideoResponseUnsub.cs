
namespace TwitchDownloaderCore.TwitchObjects.Gql
{
    public class GqlVideoOwnerUnsub
    {
        public string login { get; set; }
    }

    public class GqlVideoUnsub
    {
        public string broadcastType { get; set; }
        public System.DateTime createdAt { get; set; }
        public string seekPreviewsURL { get; set; }
        public GqlVideoOwnerUnsub owner { get; set; }
    }

    public class GqlVideoDataUnsub
    {
        public GqlVideoUnsub video { get; set; }
    }

    public class GqlVideoResponseUnsub
    {
        public GqlVideoDataUnsub data { get; set; }
        public Extensions extensions { get; set; }
    }
}
