using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Pattern2
{
    public class YoutubeChanel: IObservable
    {
        public String chanelName;
        public String videoName;

        private readonly List<IObserver> subscribers  = new List<IObserver>();
        private List<String> videos = new List<string>();
        private object chanelName1;

        public YoutubeChanel(object chanelName)
        {
            this.chanelName1 = chanelName;
        }

        public void AddVideo(String observer)
        {
            this.videos.Add(videoName);
            notifyAllObservers();
        }

        public void AddObserver(IObserver observer)
        {
            this.subscribers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            this.subscribers.Remove(observer);
        }

        public void notifyAllObservers()
        {
            foreach (var sub in subscribers)
            {
                sub.subscribe("New video released ", this.chanelName);
            }
        }

    }
}
