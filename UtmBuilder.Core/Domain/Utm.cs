using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Domain
{
    public class Utm
    {
        public Url Url { get; set; } = null!;

        public Campaign Campaign { get; set; } = null!;
    }
}
