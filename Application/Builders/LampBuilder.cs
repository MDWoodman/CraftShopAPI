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
        
        public LampBuilder WithName(string name)
        {
            _name = name;
            return this;
        }
        public LampBuilder WithMaterial(string material)
        {
            _material = material;
            return this;
        }
        public LampBuilder WithColor(string color)
        {
            _color = color;
            return this;
        }
        public LampBuilder WithDimmer(bool hasDimmer)
        {
            _hasDimmer = hasDimmer;
            return this;
        }
        public LampBuilder WithBulbType(string bulbType)
        {
            _bulbType = bulbType;
            return this;
        }
        public LampBuilder WithShadeShape(string shadeShape)
        {
            _shadeShape = shadeShape;
            return this;
        }
        public Domain.Entities.Lamp Build()
        {
            return new Domain.Entities.Lamp();
        }
    }
}
