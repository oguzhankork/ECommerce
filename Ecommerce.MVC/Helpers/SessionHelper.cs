using Newtonsoft.Json;

namespace Ecommerce.MVC.Helpers
{
    public static class SessionHelper
    {
        //Set

        public static void SetJsonProduct(this ISession _session, string _key, object _value)
        {
            if(_key == null)
            {
                return;
            }

            var jsonValue = JsonConvert.SerializeObject(_value);

            _session.SetString(_key, jsonValue);
        }

        //Get
        public static T GetProductFromJson<T>(this ISession _session, string _key)
        {
            if (_key == null)
            {
                return default(T);
            }
            else
            {
                var result = _session.GetString(_key);

                if (result == null)
                {
                    return default(T);
                }
                else
                {
                    var deserialize = JsonConvert.DeserializeObject<T>(result);
                    return deserialize;
                }
            }
            

        }

    }
}
