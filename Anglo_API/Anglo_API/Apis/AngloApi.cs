using Anglo_API.Endpoints;

namespace Anglo_API.Apis
{
    internal class AngloApi : Api
    {
        internal AngloApi(string baseUrl) : base(baseUrl)
        {
        }

        public Cars Cars { get; private set; }
    }
}
