using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Episode
    {
        
        public double Scores;
        public int Views = 0;
        public double SumScore;
        public double AvgScore;

        
        public Episode()
        {

        }
        public Episode(double Views, double SumScore, double AvgScore)
        {

        }

        public double RandViewerScore()
        {

            Random rnd = new Random();
            double MIN_VALUE = 0.0;
            double MAX_VALUE = 10.0;

            double random_num = rnd.NextDouble() * (MAX_VALUE - MIN_VALUE) + MIN_VALUE;
             
            return random_num;
        }

        public void AddView (double score)
        {
            Views++;

            SumScore += score;
        }

        public double MaxScore()
        {
            return SumScore;
        }

        public double AverageScore()
        {
            AvgScore = SumScore / Views;

            return AvgScore;
        }

        public int ViewerCount()
        {
            return Views;
        }
       


    }


}
