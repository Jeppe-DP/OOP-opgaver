int current_month = 4;

switch (current_month)
{
    case 10:
        Console.WriteLine("Autumn Holiday");
        break;
    case 12:
        Console.WriteLine("Christmas Holiday");
        break;
    case 4:
        Console.WriteLine("Spring Holiday");
        break;
    case 7:
    case 8:
        Console.WriteLine("Summer Holiday");
        break;
    case 1:
    case 2:
    case 3:
    case 5:
    case 6:
    case 9:
    case 11:
        Console.WriteLine("Hard work");
        break;
    default:
        Console.WriteLine("Invalid Month");
        return;
}
