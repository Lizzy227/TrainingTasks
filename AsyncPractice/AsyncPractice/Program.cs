//See https://aka.ms/new-console-template for more information



static async Task Main(string[] args)
{
    Console.WriteLine("Starting...");

    await DelayedPrint("Async operation completed.", 2000);

    Console.WriteLine("All done!");
}
static async Task DelayedPrint(string message, int millisecondsDelay)
{
    await Task.Delay(millisecondsDelay);
    Console.WriteLine(message);
}


