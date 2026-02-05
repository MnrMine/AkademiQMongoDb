namespace AkademiQMongoDb.Entities
{
    public class Product
    {
        public string ProductId { get; set; }

        public string ImageUrl { get; set; }
        public string ProductName { get; set; }
        public int Totaltime { get; set; }
        public decimal Price { get; set; }
    }
}
