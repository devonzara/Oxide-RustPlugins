namespace Oxide.Plugins
{
    [Info("PluginStarterTemplate", "AuthorName", "0.1.0", ResourceId = 0000)]
    [Description("A basic plugin template with some commonly used hooks.")]

    public class PluginStarterTemplate : RustPlugin
    {
        private void Init()
        {
            Puts("[INFO] Plugin initialized!");
        }

        private void Loaded()
        {
            Puts("[INFO] Plugin loaded!");
        }
    }
}