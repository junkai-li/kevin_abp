using kevin_abp.KevinDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace kevin_abp.KevinInterface
{
    public interface IkevinItemService : IApplicationService
    {
        Task<List<KevinItemDto>> GetListAsync();
        Task<KevinItemDto> CreateAsync(string text);
        Task DeleteAsync(Guid id);
    } 
}
