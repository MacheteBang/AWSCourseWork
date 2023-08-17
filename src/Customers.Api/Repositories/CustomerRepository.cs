using Customers.Api.Contracts.Data;
using Customers.Api.Database;
using Dapper;

namespace Customers.Api.Repositories;

public class CustomerRepository : ICustomerRepository
{
    public Task<bool> CreateAsync(CustomerDto customer)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CustomerDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CustomerDto?> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(CustomerDto customer)
    {
        throw new NotImplementedException();
    }
}
