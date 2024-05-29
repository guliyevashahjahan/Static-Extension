using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_05_27
{
    public class Group
    {
        private byte _studentLimit;
        private Student[] _students = Array.Empty<Student>();
        public string GroupNo { get; set; }
        public byte StudentLimint
        {
            get => _studentLimit;
            set
            {
                if (value < 5) _studentLimit = 5;
                if (value > 18) _studentLimit = 18;
            }
        }
        public Group(string groupNo, byte studentLimit)
        {
            GroupNo = groupNo;
            StudentLimint = studentLimit;
        }
        public static bool CheckGroupNo(string groupNo)
        {
            bool flag = false;
            if (groupNo.Length != 5) return flag;
            else if (char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]))
            {
                groupNo = groupNo.Substring(2);
                if (int.TryParse(groupNo, out int result))
                {
                    flag = true;
                }
            }
            return flag;
        }
        public void AddStudent(Student student)
        {
            if (_students.Length < 17)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;
            }
        }
        public Student GetStudent(int id)
        {
            Student student = new Student("", 0);
            foreach (Student s in _students)
            {
                if (s.Id == id)
                {
                    student = s;
                }
            }
            return student;
        }
        public Student[] GetAllStudents()
        {
            return _students;
        }

    }
}
