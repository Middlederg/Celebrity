using System;

namespace Celebrity.Context
{
    public interface ICrono
    {
        event EventHandler TimesUp;

        bool Active { get; }
        int Duracion { get; set; }
        int Segundos { get; }
        void Start();
        void Stop();
    }
}
