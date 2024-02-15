using Cqrs_architecture.Common;

namespace Cqrs_architecture.Dispatcher
{
    public class QueryDispatcher : IQueryDispatcher
    {
        public Task<TQueryResult> Dispatch<TQuery, TQueryResult>(TQuery query, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }
    }
}
