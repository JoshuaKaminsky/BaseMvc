namespace BaseMvc.Model
{
    public class Permission : BaseModel
    {
        private readonly string _name;

        public Permission(int id, string name)
            : base(id)
        {
            _name = name;
        }

        public string Name { get { return _name; } }
    }
}