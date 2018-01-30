using ShopBase.Data.Enums;

namespace ShopBase.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}