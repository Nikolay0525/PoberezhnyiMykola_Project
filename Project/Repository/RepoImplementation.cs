using Newtonsoft.Json;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Project.Repository
{
    public class RepoImplementation<T> : IRepository<T> where T : EnvironmentObject
    {
        private static RepoImplementation<T> _instance;
        private List<T> _objects;

        public delegate void Operation<E,Q,R,W>(List<T> objects, E obj1, Q obj2, R obj3,W obj4);
        public delegate void TableOperation<E>(DataGridView table, List<T> objects, E obj);
        public delegate void TableOperation<E,Q>(DataGridView table, List<T> objects, E obj1, Q obj2);
        public string FilePath { get; private set; }
        private RepoImplementation(string DBpath) 
        {
            FilePath = DBpath;
            if (!File.Exists(FilePath))
            {
                using (File.Create(FilePath)) { } ;
            }
            _objects = GetObjects();
        }

        public static RepoImplementation<T> GetRepo(string DBpath)
        {
            if (_instance == null) _instance = new RepoImplementation<T>(DBpath);
            return _instance;
        }

        private List<T> GetObjects()
        {
            try
            {
                string json = File.ReadAllText(FilePath);
                return JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading json: {ex.Message}");
                return new List<T>();
            }
        }

        private void SaveObjects(List<T> objects)
        {
            try
            {
                string updatedJson = JsonConvert.SerializeObject(objects, Formatting.Indented);
                File.WriteAllText(FilePath, updatedJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading json: {ex.Message}");
            }

        }
        public void AddObject(T obj)
        {
            _objects.Add(obj);
            SaveObjects(_objects);
        }

        public void ReplaceObjectWith(T obj)
        {
            var existingItemIndex = _objects.FindIndex(i => i.Id == obj.Id);
            if (existingItemIndex != -1)
            {
                _objects[existingItemIndex] = obj;
                SaveObjects(_objects);
            }
        }

        public void DeleteObject(T obj)
        {
            _objects.RemoveAll(i => i.Id == obj.Id);
            SaveObjects(_objects);
        }
        public T GetObjectByFilter(Func<T, bool> filter)
        {
            return _objects.FirstOrDefault(filter);
        }

        public List<T> GetAllObjectsByFilter(Func<T, bool> filter = null)
        {
            return filter != null ? _objects.Where(filter).ToList() : _objects;
        }

        public List<T> GetCopyOfObjects()
        {
            return _objects;
        }

        public void ReadAndWriteOperations<E,Q,R,W>(E obj1, Q obj2, R obj3, W obj4, params Operation<E, Q, R, W>[] operations)
        {
            if (operations != null)
            {
                foreach (var operation in operations)
                {
                    operation(_objects, obj1, obj2, obj3, obj4);
                }
            }

            SaveObjects(_objects);
        }

        public void ReadingOperationsWithTable<E> (DataGridView table, int clear, E obj, params TableOperation<E>[] operations)
        {
            switch (clear)
            {
                case 0:
                    break;
                case 1:
                    table.Rows.Clear();
                    break;
                case 2:
                    table.Rows.Clear();
                    table.Columns.Clear();
                    break;
                default:
                    break;
            }
            var objectsCopy = GetCopyOfObjects();
            if (operations != null)
            {
                foreach (var operation in operations)
                {
                    operation(table, objectsCopy, obj);
                }
            }

        }
        public void ReadAndWriteOperationsWithTable<E>(DataGridView table, int clear, E obj, params TableOperation<E>[] operations)
        {
            switch (clear)
            {
                case 0:
                    break;
                case 1:
                    table.Rows.Clear();
                    break;
                case 2:
                    table.Rows.Clear();
                    table.Columns.Clear();
                    break;
                default:
                    break;
            }

            if(operations != null)
            {
                foreach (var operation in operations)
                {
                    operation(table, _objects, obj);
                }
            }
            
            SaveObjects(_objects);
        }
        public void ReadingOperationsWithTable<E, Q> (DataGridView table, int clear, E obj1, Q obj2, params TableOperation<E, Q>[] operations)
        {
            switch (clear)
            {
                case 0:
                    break;
                case 1:
                    table.Rows.Clear();
                    break;
                case 2:
                    table.Rows.Clear();
                    table.Columns.Clear();
                    break;
                default:
                    break;
            }
            var objectsCopy = GetCopyOfObjects();
            foreach (var operation in operations)
            {
                operation(table, objectsCopy, obj1, obj2);
            }
        }
        public void ReadAndWriteOperationsWithTable<E, Q>(DataGridView table, int clear, E obj1, Q obj2, params TableOperation<E, Q>[] operations)
        {
            switch (clear)
            {
                case 0:
                    break;
                case 1:
                    table.Rows.Clear();
                    break;
                case 2:
                    table.Rows.Clear();
                    table.Columns.Clear();
                    break;
                default:
                    break;
            }

            foreach (var operation in operations)
            {
                operation(table, _objects, obj1, obj2);
            }

            SaveObjects(_objects);
        }
    }

}
