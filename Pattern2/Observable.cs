using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Pattern2
{
    public interface IObservable
    {
        void AddVideo(String observer);
        void AddObserver(IObserver observer);
        void removeObserver(IObserver observer);
        void notifyAllObservers();


    }
}
