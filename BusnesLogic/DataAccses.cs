namespace StudentDatabase.Migrations
{
    using StudentDatabase.BusnesLogic;
    using EgzamDatabase.Model;
    using System;
    using System.Collections.Generic;

    using System.Linq;
    public class DataAccses
    { 


        protected override void Seed(StudentDatabase.DAL.StudyContext context)
        {
            var students = new List<Student>
            {
                new Student { FirstMidName = "Petras",   LastName = "Kazlauskas",
                    LectureDate = DateTime.Parse("2010-09-01") },
                new Student { FirstMidName = "Ona", LastName = "Petryte",
                    LectureDate = DateTime.Parse("2012-09-01") },
                new Student { FirstMidName = "Arturas",   LastName = "Lasauskas",
                    LectureDate = DateTime.Parse("2013-09-01") },
                new Student { FirstMidName = "Gytis",    LastName = "Barzdukas",
                    LectureDate = DateTime.Parse("2012-09-01") },
                new Student { FirstMidName = "Lina",      LastName = "Linkyte",
                    LectureDate = DateTime.Parse("2012-09-01") },
                new Student { FirstMidName = "Peta",    LastName = "Justinyte",
                    LectureDate = DateTime.Parse("2011-09-01") },
                new Student { FirstMidName = "Laura",    LastName = "Noreikaite",
                    LectureDate = DateTime.Parse("2013-09-01") },
                new Student { FirstMidName = "Nina",     LastName = "Olintyte",
                    LectureDate = DateTime.Parse("2005-08-11") }
            };
            students.ForEach(s => context.students.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();

            var departament = new List<Departament>
            {
                new Departament {DepartamentID = 1050, Title = "Chemistry",      Credits = 3, },
                new Departament {DepartamentID = 4022, Title = "Microeconomics", Credits = 3, },
                new Departament {DepartamentID = 4041, Title = "Macroeconomics", Credits = 3, },
                new Departament {DepartamentID = 1045, Title = "Calculus",       Credits = 4, },
                new Departament {DepartamentID = 3141, Title = "Trigonometry",   Credits = 4, },
                new Departament {DepartamentID = 2021, Title = "Composition",    Credits = 3, },
                new Departament {DepartamentID = 2042, Title = "Literature",     Credits = 4, }
            };
            departament.ForEach(s => context.Departament.AddOrUpdate(p => p.Title, s));
            context.SaveChanges();

            var lectures = new List<Lecture>
            {
                new Lecture {
                    StudentID = students.Single(s => s.LastName == "Kazlauskas").ID,
                    DepartamentID = departament.Single(c => c.Title == "Chemistry" ).DepartamentID,
                    Grade = Grade.A
                },
                 new Lecture {
                    StudentID = students.Single(s => s.LastName == "Kazlauskas").ID,
                    DepartamentID = departament.Single(c => c.Title == "Microeconomics" ).DepartamentID,
                    Grade = Grade.C
                 },
                 new Lecture {
                    StudentID = students.Single(s => s.LastName == "Petryte").ID,
                    DepartamentID = departament.Single(c => c.Title == "Macroeconomics" ).DepartamentID,
                    Grade = Grade.B
                 },
                 new Lecture {
                     StudentID = students.Single(s => s.LastName == "Lasauskas").ID,
                    DepartamentID = departament.Single(c => c.Title == "Calculus" ).DepartamentID,
                    Grade = Grade.B
                 },
                 new Lecture {
                     StudentID = students.Single(s => s.LastName == "Lasauskas").ID,
                    DepartamentID = departament.Single(c => c.Title == "Trigonometry" ).DepartamentID,
                    Grade = Grade.B
                 },
                 new Lecture {
                    StudentID = students.Single(s => s.LastName == "Barzdukas").ID,
                    DepartamentID = departament.Single(c => c.Title == "Composition" ).DepartamentID,
                    Grade = Grade.B
                 },
                 new Lecture {
                    StudentID = students.Single(s => s.LastName == "Linkyte").ID,
                    DepartamentID = departament.Single(c => c.Title == "Chemistry" ).DepartamentID
                 },
                 new Lecture {
                    StudentID = students.Single(s => s.LastName == "Justinyte").ID,
                    DepartamentID = departament.Single(c => c.Title == "Microeconomics").DepartamentID,
                    Grade = Grade.B
                 },
                new Lecture {
                    StudentID = students.Single(s => s.LastName == "Noreikaite").ID,
                    DepartamentID = departament.Single(c => c.Title == "Chemistry").DepartamentID,
                    Grade = Grade.B
                 },
                 new Lecture {
                    StudentID = students.Single(s => s.LastName == "Olintyte").ID,
                    DepartamentID = departament.Single(c => c.Title == "Composition").DepartamentID,
                    Grade = Grade.B
                 },
                 new Lecture {
                    StudentID = students.Single(s => s.LastName == "Olintyte").ID,
                    DepartamentID = departament.Single(c => c.Title == "Literature").DepartamentID,
                    Grade = Grade.B
                 }
            };

            foreach (Lecture e in lectures)
            {
                var lectureInDataBase = context.Lecture.Where(
                    s =>
                         s.Student.ID == e.StudentID &&
                         s.Departament.DepartamentID == e.DepartamentID).SingleOrDefault();
                if (lectureInDataBase == null)
                {
                    context.Lectures.Add(e);
                }
            }
            context.SaveChanges();
        }
    }
}

