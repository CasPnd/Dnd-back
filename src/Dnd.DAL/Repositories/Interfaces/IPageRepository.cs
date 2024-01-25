using Dnd.DAL.Models;

namespace Dnd.DAL.Repositories.Interfaces;

public interface IPageRepository
{
    public Task CreateAsync(PageDto page);
}