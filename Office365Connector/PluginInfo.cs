using FogCreek.Plugins;
using GoIT.FogBugzPlugins.Office365Connector;

[assembly: AssemblyFogCreekPluginId(PluginInfo.PluginId)]
[assembly: AssemblyFogCreekMajorVersion(3)]
[assembly: AssemblyFogCreekMinorVersionMin(5)]
[assembly: AssemblyFogCreekEmailAddress("jozef.izso@gmail.com")]
[assembly: AssemblyFogCreekWebsite("")]

namespace GoIT.FogBugzPlugins.Office365Connector
{
    public static class PluginInfo
    {
        public const string PluginId = "Office365Connector@goit.sk";
    }
}
