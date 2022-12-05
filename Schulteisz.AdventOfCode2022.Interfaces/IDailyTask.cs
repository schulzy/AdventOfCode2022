namespace Schulteisz.AdventOfCode2022.Interfaces
{
    /// <summary>
    /// Interface for the daily tasks
    /// </summary>
    public interface IDailyTask<T>
    {
        /// <summary>
        /// Run daily task
        /// </summary>
        /// <returns>return value</returns>
        T Run();

        /// <summary>
        /// Name of the task
        /// </summary>
        string Name { get; }
    }
}
