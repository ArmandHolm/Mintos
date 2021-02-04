using System;

namespace Mintos.Tests
{
    class Configuration
    {
        public static readonly TimeSpan DefaultDriverTimeout = TimeSpan.FromSeconds(120);

        public static TimeSpan DefaultElementStatusCheckTimeout = TimeSpan.FromSeconds(10);

        public static readonly TimeSpan DefaultPageLoadCheckStabilizationTimeout = TimeSpan.FromSeconds(2);
    }
}
