using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern2
{
    public interface IObserver
    {
        void subscribe(String mag, string chanelName);
    }
}
