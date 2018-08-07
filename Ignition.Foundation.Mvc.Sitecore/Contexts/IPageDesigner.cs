namespace Ignition.Foundation.Sitecore
{
  public interface IPageDesigner
  {
    bool IsDesigning { get; }

    bool IsLayouting { get; }

    bool IsLayoutViewing { get; }

    string LayoutHandle { get; }

    string PageDesignerHandle { get; }
  }
}
