namespace System
{
    /// <summary>
    /// Temporarily sets the console foreground color and changes it back to the previous value when disposed.
    /// </summary>
    public class ConsoleForegroundColor : IDisposable
    {
        /// <summary>
        /// The original color.
        /// </summary>
        private readonly ConsoleColor originalColor;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleForegroundColor"/> class.
        /// </summary>
        /// <param name="color">
        /// The temporary foreground color value.
        /// </param>
        public ConsoleForegroundColor(ConsoleColor color)
        {
            this.originalColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
        }

        /// <summary>
        /// The dispose.
        /// </summary>
        public void Dispose()
        {
            Console.ForegroundColor = this.originalColor;
        }
    }

}
