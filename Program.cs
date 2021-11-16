using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {



            ArithProgression arProg = new ArithProgression(5,9);

            arProg.getNext();
            arProg.SetStart(5);
            for (int i = 0; i < 9; i++)
            {
                Console.Write("{0,4}", arProg.getNext());
                
            }
            Console.WriteLine();
            arProg.reset();

            GeomProgression gProg = new GeomProgression(2, 3);
            gProg.getNext();
            gProg.SetStart(2);
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0,4}", gProg.getNext());
            }
            gProg.reset();

            Console.ReadKey();
        }
    }
    interface ISeries
    {
       
        void SetStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        int Start { get; set; } 
        int Step { get; set; }
        int a;

        public ArithProgression(int start, int step)
        {
            Step = step;
            a = start;

        }
        public int getNext()
        {
            a+=Step;

            return a;
        }

        public void reset()
        {
            a = Start;
        }

        public void SetStart(int x)
        {
            Start = x;
            a = x;
        }
    }
    class GeomProgression : ISeries
    {
        int Start { get; set; }
        int D { get; set; }
        int a;
        public GeomProgression(int start, int d)
        {
            a = start;
            D = d;
        }
        public int getNext()
        {
            a *= D;
            return a;
        }
        public void reset()
        {
            a = Start;
        }
        public void SetStart(int x)
        {
            a = x;
            Start = x;
        }
    }
}