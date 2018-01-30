namespace ShopBase.Data.Interfaces
{
    public interface IHasSeoMetaData
    {
        string SeoPageTitle { set; get; }
        string SeoAlias { set; get; }
        string SeoKeyword { set; get; }
        string SeoDescription { set; get; }
    }
}