using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2_Guide
{
    internal class StudentUniversity:StudentCollege
    {
        protected double score4;
        public StudentUniversity(string name, int year, double score1, double score2, double score3, double score4) : base(name, year, score1, score2, score3)
        {
            this.score4 = score4;
        }
        public override double TinhDiem()
        {
            return (score1 + score2 + score3 + score4) / 4;
        }
        public new void HienThi()
        {
            base.HienThi();
            Console.WriteLine("Score4: " + score4);
            Console.WriteLine("Average Score: " + TinhDiem());
        }
    }
}
