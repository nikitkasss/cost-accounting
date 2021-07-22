﻿using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Category> Categories { get; }
        DbSet<Role> Roles { get; }
        DbSet<User> Users { get; }
        DbSet<Expense> Expenses { get; }
        DbSet<Income> Incomes { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}