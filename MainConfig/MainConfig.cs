namespace InfiniteRadioBatteryNW
{
    using System.ComponentModel;

    public class MainConfig
    {
        [Description("Whether the plugin is enabled")]
        public bool IsEnabled { get; set; } = true;
    }
}
