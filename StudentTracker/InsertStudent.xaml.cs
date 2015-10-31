using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StudentTracker
{
    /// <summary>
    /// Interaction logic for InsertStudent.xaml
    /// </summary>
    public partial class InsertStudent : Window
    {
        Tracker m_my_tracker;
        DateTime m_curr_date;
        public InsertStudent()
        {
            InitializeComponent();
            m_my_tracker = new Tracker();
            m_curr_date = DateTime.Now;
        }

        public InsertStudent(Tracker my_track)
        {
            InitializeComponent();
            m_my_tracker = my_track;
            m_curr_date = DateTime.Now;
        }

        public InsertStudent(DateTime current_time)
        {
            InitializeComponent();
            m_curr_date = current_time;
            m_my_tracker = new Tracker();
        }

        public InsertStudent(Tracker my_track, DateTime current_date)
        {
            InitializeComponent();
            m_my_tracker = my_track;
            m_curr_date = current_date;
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            Boolean is_returning = m_my_tracker.addStudent(student_name.Text, email_address.Text, m_curr_date);
            if(is_returning)
            {
                MessageBox.Show("Welcome back " + student_name.Text + "!", "Welcome Back!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Welcome to Bruin Initiative" + student_name.Text + "! We hop you will like our program.", "Welcome!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            
        }
    }
}
