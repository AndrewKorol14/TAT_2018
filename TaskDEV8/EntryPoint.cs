using System;

namespace TaskDEV8
{
    /// <summary>
    /// Create necessary commands, set the receiver and react on events
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                InvokerClient client = new InvokerClient();
                InputDataCreator userData = new InputDataCreator();
                DataInformationCreator dataInfo = new DataInformationCreator();
                userData.OutputNamesakes += WriteAndOutputNamesakes;
                Console.WriteLine("Press 'Enter' for adding users or any other button for exit...");
                while (Console.ReadKey(true).KeyChar == '\r')
                {
                    userData.AddUsers();
                    client.SetCommand(new InformationOnCommand(dataInfo, userData));
                    client.PerformAverageAge();
                    client.PerformOldestUser();
                    client.PerformPopularWomanName();
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }        
        }

        static void WriteAndOutputNamesakes(object sender, NamesakesEventArgs e)
        {
            Console.WriteLine("Namesakes:");
            foreach (User namesake in e.Namesakes)
            {
                Console.WriteLine(namesake);
            }
            JsonFileWriter writer = new JsonFileWriter();
            writer.SerializeJson(e.Namesakes, "C:\\Users\\Король Андрей\\Documents\\GitHub\\TAT_2018\\TaskDEV8\\namesakes.json");
        }
    }
}