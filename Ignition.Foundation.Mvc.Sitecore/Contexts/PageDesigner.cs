namespace Ignition.Foundation.Sitecore
{
  public class PageDesigner : IPageDesigner
  {
    public bool IsDesigning
    {
      get
      {
        return Sitecore.Context.PageDesigner.IsDesigning;
      }
    }

    public bool IsLayouting
    {
      get
      {
        return Sitecore.Context.PageDesigner.IsLayouting;
      }
    }

    public bool IsLayoutViewing
    {
      get
      {
        return Sitecore.Context.PageDesigner.IsLayoutViewing;
      }
    }

    public string LayoutHandle
    {
      get
      {
        return Sitecore.Context.PageDesigner.LayoutHandle;
      }
    }

    public string PageDesignerHandle
    {
      get
      {
        return Sitecore.Context.PageDesigner.PageDesignerHandle;
      }
    }
  }
}
