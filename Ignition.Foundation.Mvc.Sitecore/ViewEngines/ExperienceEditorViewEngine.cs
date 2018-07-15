using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace Ignition.Foundation.Mvc.Sitecore.ViewEngines
{
	public class ExperienceEditorViewEngine : IViewEngine
	{
	    private RazorViewEngine ViewEngine { get; }

	    public ExperienceEditorViewEngine(RazorViewEngine viewEngine)
		{
			ViewEngine = viewEngine;
		}

		public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
		{
			return !IsExperienceEditorMode() ? NullViewEngineResult() :
			  ViewEngine.FindPartialView(controllerContext, GetExperienceEditorViewName(partialViewName), false);
		}

		public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
		{
			return !IsExperienceEditorMode() ? NullViewEngineResult() :
			  ViewEngine.FindView(controllerContext, GetExperienceEditorViewName(viewName), masterName, false);
		}

		public void ReleaseView(ControllerContext controllerContext, IView view)
		{
			ViewEngine.ReleaseView(controllerContext, view);
		}

		private static bool IsExperienceEditorMode()
		{
			return Sitecore.Context.PageMode.IsExperienceEditor;
		}

		private static ViewEngineResult NullViewEngineResult()
		{
			return new ViewEngineResult(Enumerable.Empty<string>());
		}

		private static string GetExperienceEditorViewName(string viewName)
		{
			return IsApplicationRelativePath(viewName) ? Regex.Replace(viewName, @"^(.*)\.(cshtml)$", "$1.EE.$2") : $"{viewName}.EE";
		}

		private static bool IsApplicationRelativePath(string viewName)
		{
			return viewName[0] == '~' || viewName[0] == '/';
		}
	}
}
