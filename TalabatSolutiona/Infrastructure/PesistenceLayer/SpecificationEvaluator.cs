using DomainLayer.Contracts;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceLayer
{
    internal static class SpecificationEvaluator
    {
        public static IQueryable<TEnitiy> CreateQuery<TEnitiy, TKey>(IQueryable<TEnitiy> inputQuery, ISpecifications<TEnitiy, TKey> specifications)
                                                                                                    where TEnitiy : BaseEntity<TKey>
        {
            var query = inputQuery;
            // Apply criteria
            if (specifications.Criteria is not null)
            {
                query = query.Where(specifications.Criteria);
            }

            // Apply ordering
            if (specifications.OrderBy is not null)
            {
                query = query.OrderBy(specifications.OrderBy);
            }
            if (specifications.OrderByDescending is not null)
            {
                query = query.OrderByDescending(specifications.OrderByDescending);
            }

            // Apply includes
            if (specifications.IncludeExpressions is not null && specifications.IncludeExpressions.Count > 0)
            {
                query = specifications.IncludeExpressions.Aggregate(query, (current, IncludeExpressions) => current.Include(IncludeExpressions));
            }

            // Apply pagination
            if (specifications.IsPaginated)
            {
                query = query.Skip(specifications.Skip).Take(specifications.Take);
            }
            return query;
        }
    }
}
