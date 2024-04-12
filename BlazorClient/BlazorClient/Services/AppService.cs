namespace BlazorClient.Services
{
    public interface IIdService
    {
        string Id { get; set; }
        string AccessToken { get; set; }
        string Username { get; set; }

        void SetId(string id);
        string GetId();

        void SetAccessToken(string token);
        string GetAccessToken();

        void SetUsername(string username);
        string GetUsername();
    }

    public class IdService : IIdService
    {
        private string _id;
        private string _accessToken;
        private string _username;

        public string Id
        {
            get => _id;
            set => _id = value;
        }

        public string AccessToken
        {
            get => _accessToken;
            set => _accessToken = value;
        }

        public string Username
        {
            get => _username;
            set => _username = value;
        }

        public void SetId(string id)
        {
            _id = id;
        }

        public string GetId()
        {
            return _id;
        }

        public void SetAccessToken(string token)
        {
            _accessToken = token;
        }

        public string GetAccessToken()
        {
            return _accessToken;
        }

        public void SetUsername(string username)
        {
            _username = username;
        }

        public string GetUsername()
        {
            return _username;
        }
    }
}
