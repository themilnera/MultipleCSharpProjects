using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAssignment
{
    internal class Student
    {
        internal string name;
        internal string program;
        internal int id;
        private int grade = 100;
        private struct Assignment
        {
            internal string name;
            internal int score;
            internal Assignment(string name, int score)
            {
                this.name = name;
                this.score = score;
            }
        }
        private List<Assignment> assignments;
        internal Student(string name, string program, string id)
        {
            this.name = name;
            this.program = program;
            this.assignments = new List<Assignment>();
            this.id = Int32.Parse(id);
        }



        internal string GetGrade()
        {
            if(grade >= 90)
            {
                return "A"+"; Student ID: " + this.id + " Student Program: " +this.program;
            }
            else if(grade >= 80 && grade < 90)
            {
                return "B" + "; Student ID: " + this.id + " Student Program: " + this.program;
            }
            else if(grade >= 70 && grade < 80)
            {
                return "C" + "; Student ID: " + this.id + " Student Program: " + this.program;
            }
            else if(grade >= 60 && grade < 70)
            {
                return "D" + "; Student ID: " + this.id + " Student Program: " + this.program;
            }
            else
            {
                return "F" + "; Student ID: " + this.id + " Student Program: " + this.program;
            }
        }
        internal void GradeAssignment(string name, int grade)
        {
            assignments.Add(new Assignment(name, grade));
            int gradeSum = 0;
            int gradeCount = 0;
            foreach (Assignment assignment in assignments)
            {
                gradeSum += assignment.score;
                gradeCount++;
            }
            int gradeAvg = gradeSum / gradeCount;
            this.grade = gradeAvg;
        }
        
    }
}
