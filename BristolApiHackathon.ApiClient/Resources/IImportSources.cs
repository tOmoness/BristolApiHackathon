using System.Collections.Generic;
using BristolApiHackathon.Models;

namespace BristolApiHackathon.ApiClient.Resources
{
    public interface IImportSources
    {
        IEnumerable<ImportSource> Get();
    }
}