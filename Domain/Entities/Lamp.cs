namespace CraftShopAPI.Domain.Entities
{
    public class Lamp : BaseProduct
    {
        public string Name { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public bool HasDimmer { get; set; }
        public string BulbType { get; set; }
        public string ShadeShape { get; set; }
      //  public int ProductId { get; set; }

        public override Lamp Clone() {
           
            return new Lamp
            {
               // ProductId = this.ProductId,
                
                Name = this.Name,
                Material = this.Material,
                Color = this.Color,
                HasDimmer = this.HasDimmer,
                BulbType = this.BulbType,
                ShadeShape = this.ShadeShape
            };
        }
    }
}
