using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern2
{
    class Subscriber:IObserver
    {
        private String username;

        public Subscriber(String username)
        {
            this.username = username;
        }

        public void subscribe(String mag, String chanelName)
        {
            Console.WriteLine(username + " " + mag);
        }
    }
}
