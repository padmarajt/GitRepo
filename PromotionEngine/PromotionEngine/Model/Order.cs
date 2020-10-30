using System.Collections.Generic;

namespace PromotionEngine.Model
{
    public class Order
    {
        public List<Product> Products;

        public Order(List<Product> list)
        {
            this.Products = list;
        }
    }

    public class CheckOutPromotionProduct
    {
        public int PackageId;
        public List<Product> Products;
        public float prize;
        public bool PromoApplied;
    }
}
