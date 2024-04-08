using Newtonsoft.Json;

namespace DatatypesPractice
{
    public class JsonBaseClass
    {
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

}
