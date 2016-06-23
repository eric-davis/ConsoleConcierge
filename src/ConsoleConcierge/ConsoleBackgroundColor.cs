namespace System
{
    /// <summary>
    /// Temporarily sets the console background color and changes it back to the previous value when disposed.
    /// </summary>
    public class ConsoleBackgroundColor : IDisposable
    {
        /// <summary>
        /// The original color.
        /// </summary>
        private readonly ConsoleColor originalColor;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleBackgroundColor"/> class.
        /// </summary>
        /// <param name="color">
        /// The temporary background color value.
        /// </param>
        public ConsoleBackgroundColor(ConsoleColor color)
        {
            this.originalColor = Console.BackgroundColor;
            Console.BackgroundColor = color;
        }

        /// <summary>
        /// The dispose.
        /// </summary>
        public void Dispose()
        {
            Console.BackgroundColor = this.originalColor;
        }
    }

}
