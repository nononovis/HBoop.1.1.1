namespace HBoop.Model.Bson.Entities
{
    public class Role:Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Code { get; set; }

        public int? Status { get; set; }
    }
}