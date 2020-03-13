using Etude.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

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
    }
}
