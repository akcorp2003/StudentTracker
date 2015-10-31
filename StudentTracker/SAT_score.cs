using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracker
{
    public class SAT_score
    {
        private DateTime m_date_taken;
        private int m_math_score;
        private int m_reading_score;
        private int m_writing_score;
        private int m_essay_score;

        public SAT_score(int math_score, int reading_score, int writing_score, int essay_score, DateTime date_taken)
        {
            m_math_score = math_score;
            m_reading_score = reading_score;
            m_writing_score = writing_score;
            m_essay_score = essay_score;
            m_date_taken = date_taken;
        }

        public int Math_Score
        {
            get
            {
                return m_math_score;
            }
            set
            {
                m_math_score = value;
            }
        }

        public int Reading_Score
        {
            get
            {
                return m_reading_score;
            }
            set
            {
                m_reading_score = value;
            }
        }

        public int Writing_Score
        {
            get
            {
                return m_writing_score;
            }
            set
            {
                m_writing_score = value;
            }
        }

        public int get_total_SAT_score()
        {
            return m_math_score + m_reading_score + m_writing_score;
        }
    }
}
