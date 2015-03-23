using Interfaces;
using Newtonsoft.Json.Linq;

namespace Services
{
    public class JObjectAddapter : IJObject
    {
        public JObjectAddapter()
        {
        }

        public JObjectAddapter(string trans)
        {
            Jobject = JObject.Parse(trans);
        }

        public JObject Jobject { get; set; }

        public T GetValue<T>(string property)
        {
            return Jobject.Value<T>(property);
        }
    }
}