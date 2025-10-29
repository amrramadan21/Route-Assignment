using Demo.DAL.Data.Contexts;
using Demo.DAL.Models.DepartmentModel;
using Demo.DAL.Models.Shared;
using Demo.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            if (withTracking) return _context.Set<TEntity>().Where(entity=>entity.IsDeleted==false).ToList();
            else return _context.Set<TEntity>().Where(entity => entity.IsDeleted == false).AsNoTracking().ToList();
        }
        #endregion

        #region Add 

        //Add TEntity
        public int Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            return _context.SaveChanges();
        }
        #endregion

        #region Update 
        //Update TEntity
        public int Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            return _context.SaveChanges();
        }
        #endregion


        #region Delete
        //Delete TEntity
        public int Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            return _context.SaveChanges();
        }  
        #endregion
        #endregion
    }
}
