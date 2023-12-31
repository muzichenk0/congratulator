﻿
namespace WebApplication5LVL.AppData.Contexts.User
{
    public interface IUserRepository
    {
        public Task<Domain.Models.User> FindByIdAsync(Guid id, CancellationToken token = default);
        public Task<IQueryable<Domain.Models.User>> GetAllAsync();
        public Task AddAsync(Domain.Models.User user, CancellationToken token = default);
        public Task DeleteAsync(Domain.Models.User user, CancellationToken token = default);
        public Task UpdateAsync(Domain.Models.User user, CancellationToken token = default);
    }
}
