using System;

namespace Etude.Models
{
    public class Example
    {
        public string Name { get; set; }
        public Action Act { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
