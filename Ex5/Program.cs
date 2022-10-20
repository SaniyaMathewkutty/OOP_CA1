using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade = 50;
            GradeIncrease(ref grade);
            Console.Write(grade);

        }
        static void GradeIncrease(ref int newGrade)
        {
            newGrade += newGrade / 15;
        }
    }
}
