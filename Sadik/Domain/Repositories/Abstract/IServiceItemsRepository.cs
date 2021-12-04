using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sadik.Domain.Entities;

namespace Sadik.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItemById(Guid id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid id);
    }
}
