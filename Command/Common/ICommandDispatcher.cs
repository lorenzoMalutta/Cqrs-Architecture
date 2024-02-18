namespace Command.Common
{
    public interface ICommandDispatcher
    {
        Task<TCommandResult> Dispatch<TCommand, TCommandResult>(TCommand command,
            CancellationToken cancellationToken, string? userName);
    }
}
