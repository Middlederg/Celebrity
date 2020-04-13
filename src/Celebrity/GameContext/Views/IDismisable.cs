using System;

namespace Celebrity.Context
{
    public interface IDismisable
    {
        event EventHandler OnClosing;
    }
}
