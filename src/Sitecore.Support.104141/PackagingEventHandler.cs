using System;
using Sitecore.Configuration;

namespace Sitecore.Support
{
  public class PackagingEventHandler
  {
    static SettingsSwitcher customSwitcher;

    public void OnPackageInstallSettingSwitcher(object sender, EventArgs e)
    {
      var setting = Settings.AllowDuplicateItemNamesOnSameLevel;
      if (!setting)
      {
        customSwitcher = new SettingsSwitcher("AllowDuplicateItemNamesOnSameLevel", true.ToString());
      }
    }

    public void OnPackageInstallDisposeSwitcher(object sender, EventArgs e)
    {
      customSwitcher?.Dispose();
      customSwitcher = null;
    }
  }
}
