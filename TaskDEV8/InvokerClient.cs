namespace TaskDEV8
{
    /// <summary>
    /// Create invoker of commands
    /// </summary>
    class InvokerClient
    {
        ICommand command;

        /// <summary>
        /// Initialize command
        /// </summary>
        /// <param name="command">Necessary command</param>
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        /// <summary>
        /// Call command for finding average age
        /// </summary>
        public void PerformAverageAge()
        {
            command.ExecuteAverageAge();
        }

        /// <summary>
        /// Call command for finding the oldest user
        /// </summary>
        public void PerformOldestUser()
        {
            command.ExecuteOldestUser();
        }

        /// <summary>
        /// Call command for finding the most popular woman name
        /// </summary>
        public void PerformPopularWomanName()
        {
            command.ExecutePopularWomanName();
        }
    }
}