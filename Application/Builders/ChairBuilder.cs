using CraftShopAPI.Domain.Entities;

namespace CraftShopAPI.Application.Builders
{
    public class ChairBuilder
    {
        public ChairBuilder() { }
        private Chair _chair = new Chair();
        public ChairBuilder SetName(string name)
        {
            _chair.Name = name;
            return this;
        }
        public ChairBuilder SetMaterial(string material)
        {
            _chair.Material = material;
            return this;
        }
        public ChairBuilder SetColor(string color)
        {
            _chair.Color = color;
            return this;
        }
        public ChairBuilder SetHasCushion(bool hasCushion)
        {
            _chair.HasCushion = hasCushion;
            return this;
        }
        public ChairBuilder SetStyle(string style)
        {
            _chair.Style = style;
            return this;
        }
        public ChairBuilder SetNumberOfLegs(int numberOfLegs)
        {
            _chair.NumberOfLegs = numberOfLegs;
            return this;
        }
        public Chair Build()
        {
            return _chair;
        }
    }
}
