

namespace Learn.Api.Domain.Entities.Dtos;

public class ResponseDto<T>
{
    public IEnumerable<T> Items { get; set; }
}