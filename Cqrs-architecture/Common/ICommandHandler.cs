namespace Cqrs_architecture.Common
{
    public interface ICommandHandler<in TCommand, TCommandResult> where TCommand : ICommand
    {
        Task<TCommandResult> Handle(TCommand comamd, CancellationToken cancellationToken);
    }
}
