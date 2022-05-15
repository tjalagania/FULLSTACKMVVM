﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.Domain.Services
{
    public interface IDataService<T>
    {
       IAsyncEnumerable<T> GetAll();
        Task<T>GetById(int id);
        Task<T> Create(T entity);

        Task<T>Update(int id,T entity);
        Task<bool> Delete(int id);
    }
}
