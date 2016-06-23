namespace System
{
    /// <summary>
    /// The console concierge.
    /// </summary>
    public static class ConsoleConcierge
    {
        public static void PressAnyKeyToContinue()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
