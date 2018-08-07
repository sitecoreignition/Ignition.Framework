namespace Ignition.Foundation.Sitecore
{
  public class PageMode : IPageMode
  {
    public bool IsDebugging
    {
      get
      {
        return Sitecore.Context.PageMode.IsDebugging;
      }
    }

    public bool IsExperienceEditor
    {
      get
      {
        return Sitecore.Context.PageMode.IsExperienceEditor;
      }
    }

    public bool IsExperienceEditorEditing
    {
      get
      {
        return Sitecore.Context.PageMode.IsExperienceEditorEditing;
      }
    }

    public bool IsNormal
    {
      get
      {
        return Sitecore.Context.PageMode.IsNormal;
      }
    }

    public bool IsPreview
    {
      get
      {
        return Sitecore.Context.PageMode.IsPreview;
      }
    }

    public bool IsSimulatedDevicePreviewing
    {
      get
      {
        return Sitecore.Context.PageMode.IsSimulatedDevicePreviewing;
      }
    }

    public bool IsProfiling
    {
      get
      {
        return Sitecore.Context.PageMode.IsProfiling;
      }
    }
  }
}
