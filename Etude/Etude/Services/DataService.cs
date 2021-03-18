using Etude.Helpers;
using Etude.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Etude.Services
{
    public class DataService
    {
        private const string BeersFileName = "Etude.beers.json";

        private static List<Beer> _beers;

        public List<Beer> GetBeers()
        {
            try
            {
                var assembly = IntrospectionExtensions.GetTypeInfo(typeof(DataService)).Assembly;
                var stream = assembly.GetManifestResourceStream(BeersFileName);

                if (stream == null)
                {
                    return _beers;
                }

                using (var reader = new StreamReader(stream))
                {
                    var json = reader.ReadToEnd();
                    _beers = JsonConvert.DeserializeObject<List<Beer>>(json);
                }
            }
            catch { }

            return _beers;
        }

        public ObservableCollection<Grouping<string, Beer>> GroupBeerList(IEnumerable<Beer> beers)
        {
            var sortedBeers = beers
                .OrderBy(a => a.Name)
                .GroupBy(b => b.Group)
                .Select(c => new Grouping<string, Beer>(c.Key, c));

            return new ObservableCollection<Grouping<string, Beer>>(sortedBeers);
        }
    }
}
