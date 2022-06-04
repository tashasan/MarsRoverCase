using meet2talkProjectCaseSolution.CoreRepository.Abstract;
using meet2talkProjectCaseSolution.Data;

namespace meet2talkProjectCaseSolution.CoreRepository.Concrete
{
    public static class RunMyRover
    {
        public static Positions RunMyRovers(List<int> maxArea, string[] standPosition, string movements)
        {
            var execute = new ExecuteActions();
            var positions = new Positions();
            positions.X = Convert.ToInt32(standPosition[0]);
            positions.Y = Convert.ToInt32(standPosition[1]);
            positions.Direction = (Directions)Enum.Parse(typeof(Directions), standPosition[2]);
            ICommand command = null;
            foreach (var action in movements)
            {
                switch (action)
                {
                    case 'L':
                        command = new TurnLeft();
                        break;

                    case 'R':
                        command = new TurnRight();
                        break;

                    case 'M':
                        command = null;
                        break;
                    default:
                        return null;
                }

                var clonePosition = new Positions();
                if (command == null)
                    clonePosition = new MoveForward().GetMove(positions, maxArea);
                else if (command != null)
                    clonePosition = execute.StartMoving(command, positions);

                if (clonePosition == null)
                    return null;
                positions.Direction = clonePosition.Direction;
                positions.X = clonePosition.X;
                positions.Y = clonePosition.Y;

            }
            return positions;
        }

    }
}
