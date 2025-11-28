using Demo.DAL.Data.Contexts;
using Demo.DAL.Models.DepartmentModel;
using Demo.DAL.Models.Shared;
using Demo.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Repositories.Classes
{
    public class GenericRepository<TEntity>(ApplicationDbContext _context) :IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        //CRUD
        #region CRUD Opreations

        #region Get By Id

        //Get TEntity By Id
        public TEntity? GetById(int id)
        {
            var entity = _context.Set<TEntity>().Find(id);
            return entity;
        }
        #endregion

        #region Get ALL

        //Get All Set<Entity>
        public IEnumerable<TEntity> GetAll(bool withTracking = false)
        {
            if (withTracking) return _context.Set<TEntity>().ToList();
            else return _context.Set<TEntity>().AsNoTracking().ToList();
        }

        public IEnumerable<TResult> GetAll<TResult>(System.Linq.Expressions.Expression<Func<TEntity, TResult>> selector)
        {
            return _context.Set<TEntity>()
                           .Where(entity => entity.IsDeleted == false)
                           .Select(selector).ToList();
        }

        IEnumerable<TEntity> IGenericRepository<TEntity>.GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>()
                           .Where(predicate).ToList();
                           
        }

        #endregion

        #region Add 

        //Add TEntity
        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);

            //Add In Order Table
            //Add In Order Items Table
            //Update Stock In Stores
        }
        #endregion

        #region Update 
        //Update TEntity
        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }
        #endregion


        #region Delete
        //Delete TEntity
        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        #endregion

        #region IEnumerable & IQueryable
        //IEnumerable<TEntity> IGenericRepository<TEntity>.GetIEnumerable()
        //{
        //     return _context.Set<TEntity>();

        //}

        //IQueryable<TEntity> IGenericRepository<TEntity>.GetIQueryable()
        //{
        //    return _context.Set<TEntity>();

        //}

        #endregion

        #endregion
    }
}
