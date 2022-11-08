using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArthmaticProblem
{
    public  class Mood
    {
        //string mood = "Happy";


        //public void Happy()
        //{
        //    if (mood == null)
        //    {
        //        throw new MoodIsNullException("Mood is Happy" + mood);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Mood is " + mood);
        //    }
        //}

        string mood1 = "Empty";

        public void Emtpy()
        {
            if(mood1==null)
            {
                throw new MoodIsEmptyException("Mood is empty" + Emtpy);
            }
            else
            {
                Console.WriteLine("Mood is " + mood1);
            }
        }
        


    }
}
