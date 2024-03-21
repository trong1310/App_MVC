using ClassLib_App_Data.IRepository;
using ClassLib_App_Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib_App_Data.Repository
{
    public class Repository<T> : IAllRepository<T> where T : class
    {

         WebMvcContext context;
        DbSet<T> dbset; // CRUD tren db set vi noi dai dien cho bang
        // khi can goi lai va dung that thi lai can chinhs xac no la Dbset nào
        // Lúc đó ta sẽ gán dbset = DBset cần dùng
        public Repository()
        {
            context = new WebMvcContext();
        }
        public Repository(DbSet<T> dbset, WebMvcContext context)
        {
           this.dbset = dbset;// Gán lại khi dùng
            this.context = context;
        }
        public bool CreateObj(T obj)
        {
            try
            {
                dbset.Add(obj);
                context.SaveChanges();
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteObj(dynamic id)
        {
            try
            {
                var deleteObj = dbset.Find(id);
                dbset.Remove(deleteObj);
                context.SaveChanges();
                return true;    
            }catch (Exception ex)
            {
                return false;  
            }
        }

        public ICollection<T> GetAll()
        {
           return dbset.ToList();
        }
        public T GetByID(dynamic id)
        {
           return dbset.Find(id);
        }
        public bool UpdateObj(T obj)
        {
            try
            {
                dbset.Update(obj);
                context.SaveChanges();
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }
    }
}
