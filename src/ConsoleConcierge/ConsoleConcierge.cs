namespace System
{
    using System.Text;

    /// <summary>
    /// The console concierge.
    /// </summary>
    public static class ConsoleConcierge
    {
        /// <summary>
        /// Displays a press any key to continue... prompt and waits for a key press.
        /// </summary>
        public static void PressAnyKeyToContinue()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        /// <summary>
        /// Displays an exception message and details
        /// </summary>
        /// <param name="exception">
        /// The exception
        /// </param>
        /// <param name="foregroundColor">
        /// The error message foreground color (optional).
        /// </param>
        public static void DisplayError(Exception exception, ConsoleColor foregroundColor = ConsoleColor.Red)
        {
            using (new ConsoleForegroundColor(foregroundColor))
            {
                var output = new StringBuilder();
                output.AppendLine("\n\n!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n");
                output.AppendLine($"ERROR: {exception.Message}\n\n{exception}");
                output.AppendLine("\n!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n\n");

                Console.WriteLine(output.ToString());
            }
        }
    }
}
