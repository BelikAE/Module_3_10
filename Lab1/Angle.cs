using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Angle
    {
        int gradus;
        int min;
        int sec;
        public bool isCorrect = true;
        public int Gradus 
        {
            get 
            { 
                return gradus;
            }
            set 
            {
                if (value < 0) 
                    isCorrect = false; 
                else
                    gradus = value%360;
            } 
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value < 0 || value > 60) 
                {
                    Console.WriteLine("Диапазон минут от 0...60");
                    isCorrect = false;
                    
                    
                }   
                else
                    Gradus += value / 60;
                    min = value % 60;

            }
        }
        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                if (value < 0 || value > 60)
                {
                    Console.WriteLine("Диапазон секунд от 0...60");
                    isCorrect = false;
                    
                }
                else
                    sec = value;


            }
        }

        public Angle(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }

        public double ToRadians()
        {
            return (gradus + (min + (double)sec / 60) / 60) * Math.PI / 180;
        }


    }
}
