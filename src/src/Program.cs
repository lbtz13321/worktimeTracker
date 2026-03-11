namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CurrentWorkDay workDay = new CurrentWorkDay();

            ConsoleUI consoleUI = new ConsoleUI();
            consoleUI.StartUI(workDay);
        }
    }
}
