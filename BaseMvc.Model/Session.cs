using System;

namespace BaseMvc.Model
{
    public class Session : BaseModel
    {
        public Session(int id, Guid sessionId, User user)
            : base(id)
        {
            SessionId = sessionId;
            User = user;
        }

        public Guid SessionId { get; private set; }

        public User User { get; private set; }
    }
}
