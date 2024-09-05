using ECommerce.Web.Model;
using ECommerce.Web.Models;

namespace ECommerce.Web.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestDto, bool withBearer = true);
    }
}
