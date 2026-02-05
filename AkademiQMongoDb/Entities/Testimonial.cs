using System.Security.Principal;

namespace AkademiQMongoDb.Entities
{
    public class Testimonial
    {
        public string TestimonialId { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string NameSurname { get; set; }
        public string Pozition { get; set; }
    }
}
