namespace Snake_And_Ladder
{
    public class ladder
    {
        Dictionary<int, int> ladder_ = new Dictionary<int, int>();
        public ladder()
        {
            ladder_.Add(4, 14);
            ladder_.Add(9, 31);
            ladder_.Add(28, 84);
            ladder_.Add(20, 38);
            ladder_.Add(40, 59);
            ladder_.Add(51, 67);
            ladder_.Add(63, 81);
            ladder_.Add(71, 91);
        }

        public int Ladder_Position(int CurrentPosition)
        {
            if (ladder_.ContainsKey(CurrentPosition))
            {
                return ladder_[CurrentPosition];
            }
            else
            {
                return CurrentPosition;
            }
        }
    }

}

