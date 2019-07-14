using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using StudentApp.Model.Model;
using StudentRepository.Repository;

namespace StudentMnager.Manager
{
    public class SManager
    {
        Student student = new Student();
        SRepository sRepository = new SRepository();

        public int Save(Student student)
        {
            return sRepository.Save(student);
        }
        public DataTable Show()
        {
            return sRepository.Show();
        }
        public int Delete(string roll)
        {
            return sRepository.Delete(roll);
        }
        public int Update(Student student,string roll)
        {
            return sRepository.Update(student,roll);
        }
        public DataTable Search(string roll)
        {
            return sRepository.Search(roll);
        }
    }
}
