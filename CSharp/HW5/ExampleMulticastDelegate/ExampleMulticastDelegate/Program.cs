using System;
using System.Threading;

namespace ExampleMulticastDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket ticker = new Ticket();
            ticker.TickEvent += new TickEventHandler(ticker_TickEvent);

            TickerFilter tf = new TickerFilter(ticker);

            ticker.IsEnabled = true;
            Thread thr = new Thread(new System.Threading.ThreadStart(ticker.RunTiker));
            thr.Start();

            Thread.Sleep(150);
            ticker.IsEnabled = false;
        }

        static void ticker_TickEvent(object sender, TickerArgs args)
        {
            Console.WriteLine("ticker_TickEvent = "+ args.Tick.ToString());
        }
    }

    public class TickerFilter
    {
        private Ticket ticker;
        public TickerFilter (Ticket ticker)
        {
            this.ticker = ticker;
            this.ticker.TickEvent += new TickEventHandler(ticker_TickEvent);
        }

        void ticker_TickEvent (Object sender, TickerArgs args)
        {
            if (args.Tick % 5 == 0)
                Console.WriteLine("Reay args.Tick = " + args.Tick.ToString());
        }
    }

    //___________________________//

    public class Ticket
    {
        public event TickEventHandler TickEvent;

        private Boolean isEnabled = false;
        public Boolean IsEnabled
        {
            get { return isEnabled; }
            set { isEnabled = value; }
        }

        private Int32 ticks = 0;

        public void RunTiker()
        {
            while (isEnabled && TickEvent != null)
            {
                ticks++;
                TickEvent(this, new TickerArgs(ticks));
                Thread.Sleep(10);
            }
        }
    }

    public delegate void TickEventHandler(Object sender, TickerArgs args);

    public class TickerArgs : EventArgs
    {
        public Int32 Tick;
        public  TickerArgs (Int32 tick) { this.Tick = tick; }
    }


}
