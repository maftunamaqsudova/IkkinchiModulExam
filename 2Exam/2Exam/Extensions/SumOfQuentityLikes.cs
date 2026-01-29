using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Exam.Extensions
{
    public class SumOfQuentityLikes
    {
        public static int SumOfLikes(int likes)
        {
            int counter = 0;
            if (likes > 0)
            {
                counter += likes;
            }
            return counter;
        }
    }
}
