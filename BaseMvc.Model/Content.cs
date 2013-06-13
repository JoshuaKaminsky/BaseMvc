using System.Net.Mime;

namespace BaseMvc.Model
{
    public class Content : BaseModel
    {
        public Content(int id, string source, string description, ContentType contentType)
            : base(id)
        {
            Source = source;
            Description = description;
            ContentType = contentType;
        }

        public string Source { get; private set; }

        public string Description { get; private set; }

        public ContentType ContentType { get; private set; }
    }
}