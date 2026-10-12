namespace Task2
{
    internal class Program
    {
        delegate void MyCallback(string msg);

        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }

        static void SyncTask(MyCallback callback)
        {
            Thread.Sleep(1000);
            callback("Sync");
        }

        static async Task AsyncTask(MyCallback callback)
        {
            await Task.Delay(1000);
            callback("Async");
        }

        static async Task Main(string[] args)
        {
            SyncTask(Print);
            await AsyncTask(Print);
        }
    }
}
