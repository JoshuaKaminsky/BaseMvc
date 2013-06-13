namespace BaseMvc.Model
{
    public class BaseModel
    {
        public BaseModel(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
