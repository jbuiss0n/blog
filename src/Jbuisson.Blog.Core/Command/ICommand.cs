﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Jbuisson.Blog.Core.Command
{
    public interface ICommand<TResult>
        where TResult : CommandResult
    {
    }
}
