using Polly;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace hygge_imaotai.Utils
{
    /// <summary>
    /// Polly重试策略定义的Handler
    /// </summary>
    public class PollyHandler : DelegatingHandler
    {
        private readonly IAsyncPolicy<HttpResponseMessage> _policy;

        public PollyHandler(IAsyncPolicy<HttpResponseMessage> policy)
        {
            _policy = policy;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return _policy.ExecuteAsync(ct => base.SendAsync(request, ct), cancellationToken);
        }
    }
}
