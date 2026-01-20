using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CraftShopAPI.Domain.Entities
{
    public abstract class BaseProduct  
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        public virtual BaseProduct Clone() 
        {
            return (BaseProduct)this.MemberwiseClone();
        }




    }
}
