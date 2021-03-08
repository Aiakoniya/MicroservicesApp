using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.Core.Entitites.Base
{
    public interface IEntityBase<TId>
    {
        TId Id { get; }
    }
}
