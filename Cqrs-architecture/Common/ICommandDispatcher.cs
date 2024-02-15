namespace Cqrs_architecture.Common
{
    public interface ICommandDispatcher
    {
        Task<TCommand> Dispatch<TCommand, TCommandResut>(TCommand command, 
            CancellationToken cancellationToken);
    }
}
