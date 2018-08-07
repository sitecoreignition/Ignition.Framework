using Sitecore.Access;
using Sitecore.Caching;
using Sitecore.Configuration;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Events;
using Sitecore.Globalization;
using Sitecore.Jobs;
using Sitecore.Layouts;
using Sitecore.Resources;
using Sitecore.Security.Accounts;
using Sitecore.Security.Domains;
using Sitecore.SecurityModel;
using Sitecore.Sites;
using Sitecore.Tasks;
using Sitecore.Web.UI.Sheer;
using Sitecore.Workflows;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ignition.Foundation.Sitecore
{
  public class Context : IContext
  {
    public AccessContext Access
    {
      get
      {
        return Sitecore.Context.Access;
      }
    }

    public ClientDataStore ClientData
    {
      get
      {
        return Sitecore.Context.ClientData;
      }
    }

    public ClientPage ClientPage
    {
      get
      {
        return Sitecore.Context.ClientPage;
      }
      set
      {
        Sitecore.Context.ClientPage = value;
      }
    }

    public Database ContentDatabase
    {
      get
      {
        return Sitecore.Context.ContentDatabase;
      }
    }

    public Language ContentLanguage
    {
      get
      {
        return Sitecore.Context.ContentLanguage;
      }
    }

    public CultureInfo Culture
    {
      get
      {
        return Sitecore.Context.Culture;
      }
    }

    public Sitecore.Context.ContextData Data
    {
      get
      {
        return Sitecore.Context.Data;
      }
    }

    public Database Database
    {
      get
      {
        return Sitecore.Context.Database;
      }
      set
      {
        Sitecore.Context.Database = value;
      }
    }

    public DeviceItem Device
    {
      get
      {
        return Sitecore.Context.Device;
      }
      set
      {
        Sitecore.Context.Device = value;
      }
    }

    public DiagnosticContext Diagnostics
    {
      get
      {
        return Sitecore.Context.Diagnostics;
      }
    }

    public Domain Domain
    {
      get
      {
        return Sitecore.Context.Domain;
      }
    }

    public bool IsAdministrator
    {
      get
      {
        return Sitecore.Context.IsAdministrator;
      }
    }

    public bool IsBackgroundThread
    {
      get
      {
        return Sitecore.Context.IsBackgroundThread;
      }
    }

    public bool IsLoggedIn
    {
      get
      {
        return Sitecore.Context.IsLoggedIn;
      }
    }

    public bool IsUnitTesting
    {
      get
      {
        return Sitecore.Context.IsUnitTesting;
      }
      set
      {
        Sitecore.Context.IsUnitTesting = value;
      }
    }

    public bool SkipSecurityInUnitTests
    {
      get
      {
        return Sitecore.Context.SkipSecurityInUnitTests;
      }
      set
      {
        Sitecore.Context.SkipSecurityInUnitTests = value;
      }
    }

    public Item Item
    {
      get
      {
        return Sitecore.Context.Item;
      }
      set
      {
        Sitecore.Context.Item = value;
      }
    }

    public ItemsContext Items
    {
      get
      {
        return Sitecore.Context.Items;
      }
    }

    public Job Job
    {
      get
      {
        return Sitecore.Context.Job;
      }
      set
      {
        Sitecore.Context.Job = value;
      }
    }

    public Language Language
    {
      get
      {
        return Sitecore.Context.Language;
      }
      set
      {
        Sitecore.Context.Language = value;
      }
    }

    public NotificationContext Notifications
    {
      get
      {
        return Sitecore.Context.Notifications;
      }
    }

    public PageContext Page
    {
      get
      {
        return Sitecore.Context.Page;
      }
    }

    public string RawUrl
    {
      get
      {
        return Sitecore.Context.RawUrl;
      }
    }

    public SiteRequest Request
    {
      get
      {
        return Sitecore.Context.Request;
      }
    }

    public string RequestID
    {
      get
      {
        return Sitecore.Context.RequestID;
      }
    }

    public ResourceContext Resources
    {
      get
      {
        return Sitecore.Context.Resources;
      }
    }

    public SecurityContext Security
    {
      get
      {
        return Sitecore.Context.Security;
      }
    }

    public SiteContext Site
    {
      get
      {
        return Sitecore.Context.Site;
      }
      set
      {
        Sitecore.Context.Site = value;
      }
    }

    public StateContext State
    {
      get
      {
        return Sitecore.Context.State;
      }
    }

    public TaskContext Task
    {
      get
      {
        return Sitecore.Context.Task;
      }
    }

    public User User
    {
      get
      {
        return Sitecore.Context.User;
      }
    }

    public WorkflowContext Workflow
    {
      get
      {
        return Sitecore.Context.Workflow;
      }
    }

    public string PreviewSiteName
    {
      get
      {
        return Sitecore.Context.PreviewSiteName;
      }
      set
      {
        Sitecore.Context.PreviewSiteName = value;
      }
    }

    public string GetDeviceName()
    {
      return Sitecore.Context.GetDeviceName();
    }

    public string GetSiteName()
    {
      return Sitecore.Context.GetSiteName();
    }

    public Stack<TaskContext> GetTaskStack()
    {
      return Sitecore.Context.GetTaskStack();
    }

    public string GetUserName()
    {
      return Sitecore.Context.GetUserName();
    }

    public void Logout()
    {
      Sitecore.Context.Logout();
    }

    public void SetActiveSite(string siteName)
    {
      Sitecore.Context.SetActiveSite(siteName);
    }

    public void SetLanguage(Language language, bool persistent)
    {
      Sitecore.Context.SetLanguage(language, persistent);
    }

    public void SetLanguage(Language language, bool persistent, SiteContext site, DateTime? expiryDate = null)
    {
      Sitecore.Context.SetLanguage(language, persistent, site, expiryDate);
    }

    public void SetTraceBuffer(StringBuilder buffer)
    {
      Sitecore.Context.SetTraceBuffer(buffer);
    }

    public void Trace(string message, params object[] parameters)
    {
      Sitecore.Context.Trace(message, parameters);
    }
  }
}
