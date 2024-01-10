namespace DataApp;

public class Program
{
    private static int threadsCompleted = 0;

    public static void Main(string[] args)
    {
        var manager = new DataManager();
        for (int i = 0; i <= 10; i++)
        {
            _ = ConsolidateDSourceAsync(i, manager);
         // Console.WriteLine($"Consolidated dataId {i}. Result=" + manager.ConsolidateDataFromSources(i));
        }
       
       // _ = ConsolidateDSourceAsync(-1,manager);
       
         _ = ConsolidateDSourceAsync(27, manager);
        //Console.WriteLine("Consolidated dataId 27. Result=" + manager.ConsolidateDataFromSources(27));
        
        Console.WriteLine("Completed");
    }


  public static async Task ConsolidateDSourceAsync(int i, DataManager manager)
    {
        await Task.Run(() =>
        {
           Console.WriteLine($"Consolidated dataId {i}. Result=" + manager.ConsolidateDataFromSources(i));
           threadsCompleted++;
           //there could've been two interpretations of #2 
           // call complete after all are done or each is done 
           // uncomment to indicate each is complete 
           //Console.WriteLine("Completed");
           
           // comment if #2 req complete on each task
           if (threadsCompleted == 12)
           {
               Console.WriteLine("Completed");
           }
        });
    }
}