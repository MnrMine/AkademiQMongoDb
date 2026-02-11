using AkademiQMongoDb.Dtos.TestimonialDto;

namespace AkademiQMongoDb.Services.TestimonialServices
{
    public interface ITestimonialService
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
        Task CreateTestimonialAsync(CreateTestimonialDto testimonialDto);
        Task UpdateTestimonialAsync(UpdateTestimonialDto testimonialDto);
        Task DeleteTestimonialAsync(string id);
        Task<GetTestimonialByIdDto> GetTestimonialByIdAsync(string id);
    }
}
