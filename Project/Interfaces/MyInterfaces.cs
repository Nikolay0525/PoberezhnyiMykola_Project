using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Models;

namespace Project.Interfaces
{
    public class MyInterfaces
    {
        public interface IManualWritingToFile
        {
            string GetJson();
        }

        public interface IPersonFeatures
        {
            Guid Id { get; set; }
            void ShowProfile();
        }

        public interface IStudentFeatures : IPersonFeatures
        {
            int Mark { get; set; }
            void UnsignFromCourse();
        }
        public interface ITeacherFeatures : IPersonFeatures
        {
            string ScienceDegree { get; set; }
            void SendMessage();
        }
        public interface IObjectManager<T>
        {
            List<T> AddObject(T obj);
            List<T> RemoveObject(T obj);
        }
        public interface IIndexerGet<T>
        {
            T this[int index] { get; }
        }
        public interface IIndexerGetSet<T>
        {
            T this[int index] { get; set; }
        }

    }
}
