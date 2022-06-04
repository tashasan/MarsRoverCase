using meet2talkProjectCaseSolution.CoreRepository.Abstract;
using meet2talkProjectCaseSolution.Data;

namespace meet2talkProjectCaseSolution.CoreRepository.Concrete
{
    public class ExecuteActions
    {

        public Positions StartMoving(ICommand command, Positions positions)
        {
            return command.GetPositions(positions);
        }
    }
}
