using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicDemo.Options
{
    public class EmailSettingsOptions
    {
        public bool EnableEmailSystem { get; set; }
        public int EmailTimeoutInSeconds { get; set; }
        public List<string> EmailServers { get; set; } = new List<string>();
        public AdminOptions EmailAdmin { get; set; } = new AdminOptions();
    }
}
