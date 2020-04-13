using Celebrity;
using System;

namespace Celebrity.Context
{
    public interface IStartRoundView : IDismisable
    {
        Round Round { set; }
    }
}
