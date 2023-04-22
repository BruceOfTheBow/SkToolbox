using BepInEx.Configuration;

using UnityEngine;

namespace ComfyToolbox {
  public class PluginConfig {
    public static ConfigEntry<KeyboardShortcut> WorldMenuToggle { get; private set; }
    public static void BindConfig(ConfigFile config) {
      WorldMenuToggle =
          config.Bind(
              "Hotkeys",
              "worldMenuToggle",
              new KeyboardShortcut(KeyCode.None),
              "Toggle the world menu.");
    }
  }
}
