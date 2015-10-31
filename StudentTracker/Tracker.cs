using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracker
{
    public class Tracker
    {
        private Dictionary<string, SAT_Student> m_dictof_students;
        private Dictionary<DateTime, List<SAT_Student>> m_dailyattendance;

        public Tracker()
        {
            m_dictof_students = new Dictionary<string, SAT_Student>();
            m_dailyattendance = new Dictionary<DateTime, List<SAT_Student>>();
        }

        public Tracker(Dictionary<string, SAT_Student> ListofStudents, Dictionary<DateTime, List<SAT_Student>> attendance_record)
        {
            m_dictof_students = ListofStudents;
            m_dailyattendance = attendance_record;
        }

        public Boolean addStudent(string name, string email, DateTime attendeddate)
        {
            string fresh_name;
            Boolean returning = false;

            SAT_Student student;
            if(string.IsNullOrEmpty(name))
            {
                return returning;
            }
            else
            {
                char[] a = name.ToCharArray();
                a[0] = char.ToUpper(a[0]);
                fresh_name = new string(a);
            } 


            if (m_dictof_students.ContainsKey(fresh_name))
            {
                student = m_dictof_students[fresh_name];
                student.signin_attendance(attendeddate);
                returning = true;
            }
            else
            {
                student = new SAT_Student(name, email);
                student.signin_attendance(attendeddate);
            }
            
            //add student to current attendance list
            if(m_dailyattendance.ContainsKey(attendeddate))
            {
                List<SAT_Student> temp_list = m_dailyattendance[attendeddate];
                temp_list.Add(student);
            }
            else
            {
                //we need to create a new datetime
                List<SAT_Student> listof_students = new List<SAT_Student>();
                listof_students.Add(student);
                m_dailyattendance.Add(attendeddate, listof_students);
            }

            return returning;
        }//end void
    }
}
