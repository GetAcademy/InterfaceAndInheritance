using System;
using ProjectB;

namespace ProjectA
{
    public class MyCountApp : ICounterUser
    {
        private Counter _counter;

        public MyCountApp()
        {
            _counter = new Counter(this);
        }

        public void Play()
        {
            _counter.Count();
        }

        public void Notify()
        {

        }
    }
}
