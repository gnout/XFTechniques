using System.Collections.Generic;

namespace Etude.Models
{
    public class Band
    {
        public string Name { get; set; }
        public IEnumerable<string> Musicians { get; set; }
    }
}
