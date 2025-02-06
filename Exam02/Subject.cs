using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam Exam { get; set; }

        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void CreateExam()
        {
            int examType, time, numberOfQuestions;

            do
            {
                Console.WriteLine($"Please Enter The Type Of Exam (1 For Practical Or 2 For final)");
            } while (!(int.TryParse(Console.ReadLine(), out examType) && (examType is 1 or 2)));


            do
            {
                Console.WriteLine("Please Enter the time For Exam From (20 min to 150 min)");
            } while (!(int.TryParse(Console.ReadLine(), out time) && (time >= 20 && time <= 150)));

            do
            {
                Console.WriteLine("Please Enter the Number Of questions");
            } while (!(int.TryParse(Console.ReadLine(), out numberOfQuestions) && (numberOfQuestions > 0)));

            if (examType == 1)
                Exam = new PracticalExam(time, numberOfQuestions);
            else if (examType == 2)
                Exam = new FinalExam(time, numberOfQuestions);

            Console.Clear();
            Exam.CreateListOfQuestions();
        }
    }

}
