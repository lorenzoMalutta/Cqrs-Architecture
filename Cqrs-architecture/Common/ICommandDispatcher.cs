namespace Cqrs_architecture.Common
{
    public interface ICommandDispatcher
    {
        Task<TCommandResult> Dispatch<TCommand, TCommandResult>(TCommand command, 
            CancellationToken cancellationToken);
    }
}
