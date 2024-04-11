using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Models;

namespace Project.Repository
{
    public static class RepositoryManager
    {
        public static IRepository<T> GetRepo<T>(string path) where T : EnvironmentObject
        {
            return RepoImplementation<T>.GetRepo(path);
        }
    }
}
