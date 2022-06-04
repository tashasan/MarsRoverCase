using meet2talkProjectCaseSolution.Data;

namespace meet2talkProjectCaseSolution.CoreRepository.Abstract
{
    public interface ICommand
    {
        public Positions GetPositions(Positions positions);
    }
}
