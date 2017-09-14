using System;

namespace Chain.NetCore.Optimized
{
    public class MiddleWare1 : Middleware
    {
        public override void MiddlewareHandler(object sender, MiddlewareEventArgs e)
        {
            Console.WriteLine(this.ToString());
            Successor?.MiddlewareHandler(this, e);
        }
    }
}