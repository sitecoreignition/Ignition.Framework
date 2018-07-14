using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignition.Framework.Configuration
{
    public interface ISettingsProvider
    {
        object GetSetting(ISettingKey settingKey);
        TItem GetSetting<TItem>(ISettingKey settingKey) where TItem : ISettingsItem;
        TItem GetSetting<TItem>(string settingKey) where TItem : ISettingsItem;
        IEnumerable<TItem> GetAllSettingsOfType<TItem>() where TItem : ISettingsItem;
    }
}
