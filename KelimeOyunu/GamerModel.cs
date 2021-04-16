using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOyunu
{
    public class GamerModel
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Time { get; set; }

        public GamerModel(string name, int score, int time)
        {
            this.Name = name;
            this.Score = score;
            this.Time = time;
        }
    }
}
