using System.Collections.Generic;

namespace Api.Options
{
    public class ApplicationOptions
    {
        public string ApplicationName { get; set; }
        public IReadOnlyList<int> SupportedVersion { get; set; }
        public int DefaultVersion { get; set; }
    }
}
