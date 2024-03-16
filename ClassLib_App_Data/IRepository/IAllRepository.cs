using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib_App_Data.IRepository
{
    public interface IAllRepository<T> where T : class
    {
        public ICollection<T> GetAll();
        public T GetByID(dynamic id); // Type - lay boi ID
        public bool CreateObj(T obj);// Tao moi va them vao trong Db
        public bool UpdateObj(T obj); // Sua va luu lai vao trong Db
        public bool  DeleteObj(dynamic id); //  Xoa doi tuong trong Db

    }

}
