using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project.Repository
{
    public interface IRepository<T> where T : EnvironmentObject
    {
        List<T> GetAllObjectsByFilter(Func<T, bool> filter = null);
        void AddObject(T Entity);
        void ReplaceObjectWith(T Entity);
        void DeleteObject(T Entity);
        T GetObjectByFilter(Func<T, bool> filter);
        List<T> GetCopyOfObjects();
        void ReadAndWriteOperations<E, Q, R, W>(E obj1, Q obj2, R obj3, W obj4, params RepoImplementation<T>.Operation<E, Q, R, W>[] operations);
        void ReadingOperationsWithTable<E>(DataGridView table, int clear, E obj, params RepoImplementation<T>.TableOperation<E>[] operations);
        void ReadAndWriteOperationsWithTable<E>(DataGridView table, int clear, E obj, params RepoImplementation<T>.TableOperation<E>[] operations);
        void ReadingOperationsWithTable<E, Q>(DataGridView table, int clear, E obj1, Q obj2, params RepoImplementation<T>.TableOperation<E,Q>[] operations);
        void ReadAndWriteOperationsWithTable<E, Q>(DataGridView table, int clear, E obj1, Q obj2, params RepoImplementation<T>.TableOperation<E,Q>[] operations);

    }
}
