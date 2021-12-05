using SolidTradeServer.Data.Entities.Common;

namespace SolidTradeServer.Data.Entities
{
    public class User : BaseEntity
    {
        public string DisplayName { get; set; }
        public string Username { get; set; }
    }
}