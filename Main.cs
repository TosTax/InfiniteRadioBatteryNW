namespace InfiniteRadioBatteryNW
{
    using InventorySystem.Items.Radio;
    using PluginAPI.Core;
    using PluginAPI.Core.Attributes;
    using PluginAPI.Enums;
    using PluginAPI.Events;

    public class Plugin
    {
        [PluginConfig]
        public MainConfig MainConfig;

        public static Plugin Instance { get; private set; }
        [PluginEntryPoint("InfiniteRadioBatteryNW", "1.0.0", "Simple lightweight plugin to have infinite radio battery using NW Api.", "TosTa")]

        public void OnEnabled()
        {
            if (!MainConfig.IsEnabled) return;
            Instance = this;
            EventManager.RegisterEvents(this);
            Log.Info("InfiniteRadioBattery loaded successfully!");
        }
        public void OnDisabled()
        {
            EventManager.UnregisterEvents(this);
            Log.Info("InfiniteRadioBattery unloaded");
        }

        [PluginEvent(ServerEventType.PlayerUsingRadio)]
        public void OnPlayerUsingRadio(Player player, RadioItem radio, float drain)
        {
            if (player != null && radio != null)
            {
                radio.BatteryPercent = 100;
            }
        }
    }
}
