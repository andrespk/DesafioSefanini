using System.Collections.Generic;

namespace service.Database
{
    public interface IDatabaseService
    {
        string GetDefaultConnectionString();

        string GetConnectionString(dynamic connectionId);

        IEnumerable<dynamic> GetConnectionStrings();
    }
}