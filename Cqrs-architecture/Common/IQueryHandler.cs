namespace Cqrs_architecture.Common
{
    public interface IQueryHandler<in TQuery, TQueryResult> where TQuery : IQuery
    {
        Task<TQueryResult> Handle(TQuery query, CancellationToken cancellationToken);
    }
}
