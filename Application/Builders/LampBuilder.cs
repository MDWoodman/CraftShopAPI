
namespace CraftShopAPI.Application.Builders
{
    public class LampBuilder
    {
        // Implement lamp building logic here
        string _name;
        string _material;
        string _color;
        bool _hasDimmer;
        string _bulbType;
        string _shadeShape;

        public LampBuilder() { }
        
        public LampBuilder SetName(string name)
        {
            _name = name;
            return this;
        }
        public LampBuilder SetMaterial(string material)
        {
            _material = material;
            return this;
        }
        public LampBuilder SetColor(string color)
        {
            _color = color;
            return this;
        }
        public LampBuilder SetDimmer(bool hasDimmer)
        {
            _hasDimmer = hasDimmer;
            return this;
        }
        public LampBuilder SetBulbType(string bulbType)
        {
            _bulbType = bulbType;
            return this;
        }
        public LampBuilder SetShadeShape(string shadeShape)
        {
            _shadeShape = shadeShape;
            return this;
        }
        public Domain.Entities.Lamp Build()
        {
            return new Domain.Entities.Lamp
            {
                Name = _name,
                Material = _material,
                Color = _color,
                HasDimmer = _hasDimmer,
                BulbType = _bulbType,
                ShadeShape = _shadeShape
            };
        }

      
    }
}
