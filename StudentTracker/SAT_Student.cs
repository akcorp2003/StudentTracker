using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracker
{
    public class SAT_Student : IStudent
    {
        private string m_name;
        private string m_email;
        private List<DateTime> m_attendance_list;
        private List<SAT_score> m_listof_scores;

        public SAT_Student(string name, string email)
        {
            m_name = name;
            m_email = email;
            m_attendance_list = new List<DateTime>();
            m_listof_scores = new List<SAT_score>();
        }
        public List<DateTime> getattendance()
        {
            return m_attendance_list;
        }

        public void signin_attendance(DateTime date_attended)
        {
            m_attendance_list.Add(date_attended);
        }
    }
}
