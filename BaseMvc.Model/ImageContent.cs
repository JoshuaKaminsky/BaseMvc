using System.Net.Mime;

namespace BaseMvc.Model
{
    public class ImageContent : Content
    {
        public ImageContent(int id, string source, string thumbnail, string description, ContentType contentType)
            : base(id, source, description, contentType)
        {
            Thumbnail = thumbnail;
        }

        public string Thumbnail { get; private set; }
    }
}
