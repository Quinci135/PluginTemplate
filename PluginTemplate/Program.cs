using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TShockAPI;
using Terraria;
using TerrariaApi.Server;

namespace TestPlugin
{
    [ApiVersion(2, 1)]
    public class TestPlugin : TerrariaPlugin
    {
        public override string Author => "Quinci";

        public override string Description => "A sample test plugin";

        public override string Name => "Test Plugin";

        public override Version Version => new Version(1, 0, 0, 0);

        public TestPlugin(Main game) : base(game)
        {

        }

        public override void Initialize()
        {

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Deregister hooks here
            }
            base.Dispose(disposing);
        }
    }
}