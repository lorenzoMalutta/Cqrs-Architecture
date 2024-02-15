namespace Cqrs_architecture.Common
{
    public interface IQuery : IBaseCommand { }

    public interface IQuery<TResponse> : IBaseCommand { }

    public interface IBaseQuery { }
}
