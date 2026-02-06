namespace AkademiQMongoDb.Dtos.ProductDto
{
    public class CreateProductDto
    {
        public string ImageUrl { get; set; }
        public string ProductName { get; set; }
        public int Totaltime { get; set; }
        public decimal Price { get; set; }
        public decimal OldPrice { get; set; }
    }
}
