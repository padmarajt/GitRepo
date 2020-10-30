using System.Collections.Generic;

namespace PromotionEngine.Model
{
    public class PromotionPackage
    {
        public int packageId { get; set; }
        public List<PromotionProduct> promoProducts { get; set; }
        public float promoPrize { get; set; }

        public PromotionPackage(int packageId, List<PromotionProduct> promoProducts, float promoPrize)
        {
            this.packageId = packageId;
            this.promoProducts = promoProducts;
            this.promoPrize = promoPrize;
        }
    }

    public class PromotionProduct
    {
        public string name { get; set; }
        public int productCount { get; set; }
        
        public PromotionProduct(string name, int productCount)
        {
            this.name = name;
            this.productCount = productCount;
        }
    }
}
