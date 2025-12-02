using DomainLayer.Contracts;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Specifications
{
    public abstract class BaseSpecifications<TEnitiy, Tkey> : ISpecifications<TEnitiy, Tkey>
        where TEnitiy : BaseEntity<Tkey>
    {
        protected BaseSpecifications(Expression<Func<TEnitiy, bool>>? criteria)
        {
            Criteria = criteria;
        }
        #region Includes
        public Expression<Func<TEnitiy, bool>>? Criteria { get; private set; }

        public List<Expression<Func<TEnitiy, object>>> IncludeExpressions { get; } = [];
        protected void AddInclude(Expression<Func<TEnitiy, object>> includeExpression)
        {
            IncludeExpressions.Add(includeExpression);
        }
        #endregion

        #region Ordering
        public Expression<Func<TEnitiy, object>> OrderBy { get; private set; }

        public Expression<Func<TEnitiy, object>> OrderByDescending { get; private set; }
        protected void AddOrderBy(Expression<Func<TEnitiy, object>> orderByExpression)
        {

            OrderBy = orderByExpression;
        }
        protected void AddOrderByDescending(Expression<Func<TEnitiy, object>> orderByDescendingExpression)
        {
            OrderByDescending = orderByDescendingExpression;
        }
        #endregion

        #region Pagination

        public int Take { get; private set; }
        public int Skip { get; private set; }
        public bool IsPaginated { get; set; }
        protected void ApplyPagination(int pageSize, int pageIndex)
        {
           IsPaginated = true;
           Take = pageSize;
            Skip = (pageIndex - 1) * pageSize;
        }

        #endregion
    }


}






