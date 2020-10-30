namespace PromotionEngine.Model
{
    public class Product
    {
        public string name { get; set; }
        public float prize { get; set; }
        
        public Product(string name)
        {
            this.name = name;

            switch (this.name)
            {
                case "A":
                    this.prize = 50f;

                    break;
                case "B":
                    this.prize = 30f;

                    break;
                case "C":
                    this.prize = 20f;

                    break;
                case "D":
                    this.prize = 15f;
                    break;
            }
        }
    }
}
