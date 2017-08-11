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

        private void Unload() {
            Puts("[INFO] Plugin unloaded!");
        }

        private void OnPlayerInit(BasePlayer player)
        {
            Puts($"[INFO] Player {player.displayName} initialized!");
        }

        private void OnPlayerSleepEnded(BasePlayer player)
        {
            Puts($"[INFO] Player {player.displayName} has woken!");
        }

        private void OnPlayerSleep(BasePlayer player)
        {
            Puts($"[INFO] Player {player.displayName} has fallen asleep!");
        }

        private void OnPlayerDisconnected(BasePlayer player)
        {
            Puts($"[INFO] Player {player.displayName} has disconnected!");
        }
    }
}