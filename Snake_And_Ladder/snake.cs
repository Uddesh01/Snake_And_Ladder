using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder
{
    public class snake

    {
        Dictionary<int, int> snake_= new Dictionary<int, int>();
        public snake() 
        {
            snake_.Add(17, 7);
            snake_.Add(54, 34);
            snake_.Add(62, 19);
            snake_.Add(64, 60);
            snake_.Add(87, 24);
            snake_.Add(93, 73);
            snake_.Add(95, 75);
            snake_.Add(99, 78);
        }

        public int Snake_Position(int CurrentPosition) 
        {
            if(snake_.ContainsKey(CurrentPosition))
            {
                return snake_[CurrentPosition];
            }
            else
            {
                return CurrentPosition;
            }
        }
    }
}
