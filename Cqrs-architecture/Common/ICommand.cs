﻿namespace Cqrs_architecture.Common
{
    public interface ICommand : IBaseCommand { }

    public interface ICommand<TResponse> : IBaseCommand { }

    public interface IBaseCommand { }
}
