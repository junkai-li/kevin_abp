using kevin_abp.KevinDto;
using kevin_abp.KevinInterface;
using kevin_abp.kevinModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace kevin_abp.KevinService
{
    public class kevinItemService : ApplicationService, IkevinItemService
    {
        private readonly IRepository<kevinItem, Guid> _todoItemRepository;

        public kevinItemService(IRepository<kevinItem, Guid> todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }
        public async Task<List<KevinItemDto>> GetListAsync()
        {
            var items = await _todoItemRepository.GetListAsync();
            return items
                .Select(item => new KevinItemDto
                {
                    Id = item.Id,
                    Text = item.Text
                }).ToList();
        }
        public async Task<KevinItemDto> CreateAsync(string text)
        {
            var todoItem = await _todoItemRepository.InsertAsync(
                new kevinItem { Text = text }
            );

            return new KevinItemDto
            {
                Id = todoItem.Id,
                Text = todoItem.Text
            };
        }

        public async Task DeleteAsync(Guid id)
        {
            await _todoItemRepository.DeleteAsync(id);
        }
    }
}
