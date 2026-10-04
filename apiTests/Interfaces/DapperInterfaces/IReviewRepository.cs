using apiTests.DTO.DapperDTOs;

namespace apiTests.Interfaces.DapperInterfaces;

public interface IReviewRepository
{
    Task<IEnumerable<ReviewDTO>> GetAllReviewsAsync();
}