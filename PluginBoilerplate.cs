/**
 * Note: This is a boilerplate meant for educational and jump-start
 * purposes. For best performance, it is suggested to remove all  
 * hooks, use statements, and other features you don't require.
 */

namespace Oxide.Plugins
{
    /**
     * The `Info` attribute should contain the plugin's name,
     * author's name, plugin's version, and a resource id
     * which can be obtained when submit to oxide.org.
     *
     * Plugin Name: Should be description, unique, and avoid
     * redundant words like "plugin", "mod", "admin", etc.
     *
     * Plugin Version: This should follow SemVer (semver.org).
     * The developmental builds ought to be 0.X.X and your
     * initial release will usually increment to 1.0.0.
     * 
     * Resource ID: The Resource ID can be found after publishing
     * your plugin to oxide.org. Your plugin's URL will end in
     * a number. For example: "plugin-starter-template.0000"
     * 
     * The `Description` attribute should contain a brief
     * description or summary about what the plugin is
     * designed to do. Don't get too lengthy on it.
     */
    [Info("PluginBoilerplate", "AuthorName", "0.1.0", ResourceId = 0000)]
    [Description("A boilerplate with a little bit of everything to get you started.")]
    public class PluginBoilerplate : RustPlugin
    {
        #region PluginBody

        /// <summary>
        /// Instance of our <see cref="Logger"/> for later.
        /// </summary>
        private LogHelper _logger;

        /// <summary>
        /// This is called when a plugin is being initialized.
        /// Other plugins may or may not be present just yet
        /// dependant on the order in which they're loaded.
        /// </summary>
        private void Init()
        {
            _logger = new LogHelper(Title, LogHelper.LogLevel.Info);
            _logger.Info("Plugin initialized!");
        }

        /// <summary>
        /// This is called when a plugin has finished loading.
        /// Other plugins may or may not be present just yet
        /// dependant on the order in which they're loaded.
        /// </summary>
        private void Loaded()
        {
            _logger.Info("Plugin loaded!");
        }

        /// <summary>
        /// This is called when a plugin is being unloaded.
        /// </summary>
        private void Unload()
        {
            _logger.Info("Plugin unloaded!");
        }

        /// <summary>
        /// This is called when the player is being initialized,
        /// they have already connected but have not woken up
        /// yet. Great place to take notice of new players.
        /// </summary>
        /// <param name="player">The player that is being initialized.</param>
        private void OnPlayerInit(BasePlayer player)
        {
            _logger.Info($"Player {player.displayName} initialized!");
        }

        /// <summary>
        /// This is called when a player wakes up. This is a great
        /// place to attach your custom UI elements that should
        /// appear quickly or when the player enters the game.
        /// </summary>
        /// <param name="player">The player that has woken up.</param>
        private void OnPlayerSleepEnded(BasePlayer player)
        {
            _logger.Info($"Player {player.displayName} has woken!");
        }

        /// <summary>
        /// This is called when a player is about to go to sleep. Returning a
        /// non-null value overrides the default behavior. This is a great
        /// place to destroy custom UIs to hide while they're sleeping.
        /// </summary>
        /// <param name="player">The player that has fallen asleep.</param>
        private void OnPlayerSleep(BasePlayer player)
        {
            _logger.Info($"Player {player.displayName} has fallen asleep!");
        }

        /// <summary>
        /// This is called after a player has been disconnected.
        /// </summary>
        /// <param name="player">The player that has disconnected.</param>
        private void OnPlayerDisconnected(BasePlayer player)
        {
            _logger.Info($"Player {player.displayName} has disconnected!");
        }

        #endregion

        /// <summary>
        /// Simple multi-level logger class to easily enable/disable console logging.
        /// </summary>
        public class LogHelper
        {
            /// <summary>
            /// The name of the current plugin.
            /// </summary>
            private readonly string _pluginName;

            /// <summary>
            /// The severity level of log messages to show.
            /// </summary>
            public LogLevel Level { get; set; }

            /// <summary>
            /// The possible severity levels.
            /// </summary>
            public enum LogLevel { Trace, Info, Debug, Warning, Error, Fatal, Disabled }

            /// <summary>
            /// Constructor.
            /// </summary>
            /// <param name="pluginName">An instance of the plugin.</param>
            /// <param name="level">The severity level of log messages to show.</param>
            public LogHelper(string pluginName, LogLevel level = LogLevel.Warning)
            {
                _pluginName = pluginName;
                Level = level;
            }

            #region LogLevelMethods

            /// <summary>
            /// Log a TRACE level message to the console.
            /// </summary>
            /// <param name="text">The text content of the log entry.</param>
            public void Trace(string text)
            {
                LogMessage(LogLevel.Trace, text);
            }

            /// <summary>
            /// Log an INFO level message to the console.
            /// </summary>
            /// <param name="text">The text content of the log entry.</param>
            public void Info(string text)
            {
                LogMessage(LogLevel.Info, text);
            }

            /// <summary>
            /// Log a DEBUG level message to the console.
            /// </summary>
            /// <param name="text">The text content of the log entry.</param>
            public void Debug(string text)
            {
                LogMessage(LogLevel.Debug, text);
            }

            /// <summary>
            /// Log a WARNING level message to the console.
            /// </summary>
            /// <param name="text">The text content of the log entry.</param>
            public void Warning(string text)
            {
                LogMessage(LogLevel.Warning, text);
            }

            /// <summary>
            /// Log an ERROR level message to the console.
            /// </summary>
            /// <param name="text">The text content of the log entry.</param>
            public void Error(string text)
            {
                LogMessage(LogLevel.Error, text);
            }

            /// <summary>
            /// Log a FATAL level message to the console.
            /// </summary>
            /// <param name="text">The text content of the log entry.</param>
            public void Fatal(string text)
            {
                LogMessage(LogLevel.Fatal, text);
            }

            #endregion

            /// <summary>
            /// Writes the log entry to the console if necessary.
            /// </summary>
            /// <param name="level">The severity level of the log entry.</param>
            /// <param name="text">The text content of the log entry.</param>
            private void LogMessage(LogLevel level, string text)
            {
                if (level >= Level)
                {
                    UnityEngine.Debug.Log($"[{_pluginName}] [{level}] {text}");
                }
            }
        }
    }
}
