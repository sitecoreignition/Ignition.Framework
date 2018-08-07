namespace Ignition.Foundation.Sitecore
{
  public interface IPageMode
  {
    bool IsDebugging { get; }

    bool IsExperienceEditor { get; }

    bool IsExperienceEditorEditing { get; }

    bool IsNormal { get; }

    bool IsPreview { get; }

    bool IsSimulatedDevicePreviewing { get; }

    bool IsProfiling { get; }
  }
}