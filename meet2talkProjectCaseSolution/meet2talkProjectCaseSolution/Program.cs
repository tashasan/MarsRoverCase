using meet2talkProjectCaseSolution.CoreRepository.Concrete;

var maxArea = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
var standPosition = Console.ReadLine().Split(' ');
var movements = Console.ReadLine().ToUpper();

var positions = RunMyRover.RunMyRovers(maxArea, standPosition, movements);
if (positions != null)
    Console.WriteLine(positions.X + " " + positions.Y + " " + positions.Direction);
else
    Console.WriteLine("Bad Request");
