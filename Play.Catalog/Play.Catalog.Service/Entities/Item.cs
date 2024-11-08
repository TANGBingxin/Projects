using System.Reflection.Metadata;
using Play.Common.Entites;

namespace Play.Catalog.Service.Entites
{
    public class Item : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public DateTimeOffset CreateDate { get; set; }
    }
}