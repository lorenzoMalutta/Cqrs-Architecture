using Cqrs_architecture.Common;

namespace Cqrs_architecture.Dispatcher
{
    public class CommandDispatcher : ICommandDispatcher
    {
        public Task<TCommand> Dispatch<TCommand, TCommandResut>(TCommand command, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
