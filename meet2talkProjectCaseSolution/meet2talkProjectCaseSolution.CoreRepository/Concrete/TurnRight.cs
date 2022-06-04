using meet2talkProjectCaseSolution.CoreRepository.Abstract;
using meet2talkProjectCaseSolution.Data;

namespace meet2talkProjectCaseSolution.CoreRepository.Concrete
{
    public class TurnRight : ICommand
    {
        public Positions GetPositions(Positions positions)
        {
            switch (positions.Direction)
            {
                case Directions.N:
                    positions.Direction = Directions.E;
                    break;

                case Directions.E:
                    positions.Direction = Directions.S;
                    break;

                case Directions.S:
                    positions.Direction = Directions.W;
                    break;

                case Directions.W:
                    positions.Direction = Directions.N;
                    break;
            }
            return positions;
        }
    
    }
}
