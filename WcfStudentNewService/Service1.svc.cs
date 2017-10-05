using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfStudentNewService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentNewService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StudentNewService.svc or StudentNewService.svc.cs at the Solution Explorer and start debugging.
    public class StudentNewService : IStudentNewService
    {
        private readonly List<Student> studentlist = new List<Student>();
        public void DeleteStudent(int id)
        {
            foreach (Student s in studentlist)
            {
                if (s.Id == id)
                {
                    studentlist.Remove(s);
                    break;
                }
            }
        }

        public string FindStudent(int id)
        {
            string student = "";
            foreach (Student s in studentlist)
            {
                if (s.Id == id)
                {
                    student = s.Name;
                }
            }
            return student;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public void OpretStudent(int id, string name)
        {
            Student student = new Student(id, name);
            studentlist.Add(student);
        }
    }
}
