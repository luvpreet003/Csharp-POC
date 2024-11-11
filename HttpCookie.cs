namespace classes
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictCookies;
        public HttpCookie()
        {
            _dictCookies = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get 
            {
                return _dictCookies[key];
            }
            set
            {
                _dictCookies[key] = value;
            }
        }
    }
}