using System;

namespace Pattern2
{
    class Program
    {
        public static void Main(string[] args)
        {

            YoutubeChanel chanel = new YoutubeChanel("Code Dojo");
            chanel.AddVideo("JS0");
            chanel.AddVideo("JS1");

            Subscriber subscriber1 = new Subscriber("Asselya");
            Subscriber subscriber2 = new Subscriber("Zhaniya");
            Subscriber subscriber3 = new Subscriber("Ayana");

            chanel.AddObserver(subscriber1);
            chanel.AddObserver(subscriber2);
            chanel.AddObserver(subscriber3);

            chanel.AddVideo("JS2");
            chanel.AddVideo("JS3");
            chanel.AddVideo("JS4");
        }
        }
    }

