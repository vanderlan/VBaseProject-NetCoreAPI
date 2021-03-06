using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using VBaseProject.Data.Context;
using VBaseProject.Data.Repository.Generic;
using VBaseProject.Data.Repository.Interfaces;
using VBaseProject.Entities.Domain;
using VBaseProject.Entities.Filter;
using VBaseProject.Entities.ValueObjects.Pagination;

namespace VBaseProject.Data.Repository.Implementations
{
    internal class CustomerRepository : BaseEntityRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DataContext context) : base(context)
        {

        }

        public async Task<PagedList<Customer>> ListPaginate(CustomerFilter filter)
        {
            var pagination = (filter.Page * filter.Quantity) - filter.Quantity;

            IQueryable<Customer> listQuerable = DataContext.Customers;

            if (!string.IsNullOrWhiteSpace(filter.Query))
            {
                listQuerable = listQuerable.Where(x => x.Name.Contains(filter.Query));
            }

            var customerList = await listQuerable.OrderBy(x => x.Name).Skip(pagination).Take(filter.Quantity).ToListAsync();

            return new PagedList<Customer>(customerList, listQuerable.Count());
        }
    }
}

