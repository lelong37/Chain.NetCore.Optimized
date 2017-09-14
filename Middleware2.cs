using System;

namespace Chain.NetCore.Optimized
{
    public class MiddleWare2 : Middleware
    {
        public override void MiddlewareHandler(object sender, MiddlewareEventArgs e)
        {
            Console.WriteLine(this.ToString());

            var middleWare2a = new MiddleWare2a();

            middleWare2a
                .Use(new MiddleWare2b())
                .Use(new MiddleWare2c());

            foreach (int request in e.Requests)
            {
                middleWare2a.Invoke(new MiddlewareEventArgs());
            }

            Successor?.MiddlewareHandler(this, e);
        }
    }
}