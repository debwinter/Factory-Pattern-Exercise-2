namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database do you want to use? (List, SQL, or Mongo):");
            string userInput = Console.ReadLine();

            IDataAccess dataAccessType = DataAccessFactory.GetDataAccessType(userInput);

            Console.WriteLine();
            dataAccessType.LoadData();
            Console.WriteLine();
            dataAccessType.SaveData();
        }
    }
}
