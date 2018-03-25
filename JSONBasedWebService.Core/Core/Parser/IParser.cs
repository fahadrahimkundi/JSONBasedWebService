using JSONBasedWebService.Core.Models;

namespace JSONBasedWebService.Core.Parser
{
    public interface IParser
    {
        Response FilterData(string data);
    }
}
