namespace meet2talkProjectCaseSolution.Data
{
    public class Positions
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Directions Direction { get; set; }
        public Positions()
        {
            X = 0;
            Y = 0;
            Direction = Directions.N;
        }
    }
}
