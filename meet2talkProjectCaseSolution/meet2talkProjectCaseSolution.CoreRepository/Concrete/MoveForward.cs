using meet2talkProjectCaseSolution.Data;

namespace meet2talkProjectCaseSolution.CoreRepository.Concrete
{
    public class MoveForward
    {
        public Positions GetMove( Positions positions, List<int> maxArea)
        {
            switch (positions.Direction)
            {
                case Directions.N:
                    if (positions.Y >= maxArea[1])
                        positions = RoverCantMove();
                    else
                        positions.Y += 1;
                    break;
                case Directions.E:
                    if (positions.X >= maxArea[0])
                        positions = RoverCantMove();
                    else
                        positions.X += 1;
                    break;
                case Directions.S:
                    if (positions.Y != 0)
                        positions.Y -= 1;
                    else
                        positions = RoverCantMove();
                    break;
                case Directions.W:
                    if (positions.X != 0)
                        positions.X -= 1;
                    else
                        positions = RoverCantMove();
                    break;
            }
            return positions;
        }



        private Positions RoverCantMove()
        {
            Console.WriteLine("Out of Area");
            return null;
        }


    }
}
