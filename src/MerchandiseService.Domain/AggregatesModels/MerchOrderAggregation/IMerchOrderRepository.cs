﻿using MerchandiseService.Domain.SeedWork;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MerchandiseService.Domain.MerchOrderAggregation
{
    public interface IMerchOrderRepository : IRepository<MerchOrder>
    {
        Task<int> Add(MerchOrder merchOrder,CancellationToken cancellationToken = default);
        Task<MerchOrder> FindByIdAsync(int id, CancellationToken cancellationToken = default);

        Task<List<MerchOrder>> FindByEmployeeIdAsync(long id, CancellationToken cancellationToken = default);
    }
}