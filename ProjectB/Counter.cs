using System;

namespace ProjectB
{
    public class Counter
    {
        private int _count;
        private MyCountApp _myCountApp;

        public Counter(MyCountApp myCountApp)
        {
            _myCountApp = myCountApp;
        }

        public void Count()
        {
            _count++;
            if (_count % 10 == 0)
            {
                _myCountApp.Notify();
            }
        }
    }
}
