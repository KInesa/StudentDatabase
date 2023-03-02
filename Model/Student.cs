using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzamDatabase.Model
{
    public class Student
    {
  
        
            public int ID { get; set; }
            public string LastName { get; set; }
            public string FirstMidName { get; set; }
            public DateTime LectureDate { get; set; }

            public virtual ICollection<Lecture> Lectures { get; set; }
        }
    }


