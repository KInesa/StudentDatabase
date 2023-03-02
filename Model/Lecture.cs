using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzamDatabase.Model
{
  
        public enum Grade
        {
            A, B, C, D, F
        }

        public class Lecture
        {
            public int LectureID { get; set; }
            public int DepartamentID { get; set; }
            public int StudentID { get; set; }
            public Grade? Grade { get; set; }

            public virtual Departament Departament { get; set; }
            public virtual Student Student { get; set; }
        }


    }

