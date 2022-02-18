using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationRSS.Providers.Abstractions
{
    public interface IFeedService
    {
        Task<string> GetFeedDocument(string host);
    }
}
