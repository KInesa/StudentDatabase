using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzamDatabase.Model
{
    public class Departament
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartamentID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Lecture> Lectures { get; set; }




    }
}
