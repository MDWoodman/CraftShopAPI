using System.ComponentModel.DataAnnotations;

namespace CraftShopAPI.Domain.Entities
{
    public abstract class BaseProduct  
    {
        public int Width;
        public int Height;
        public int ProductId;

        public virtual BaseProduct Clone() 
        {
            return (BaseProduct)this.MemberwiseClone();
        }




    }
}
