using HarmonyLib;

using UnityEngine;

namespace ComfyToolbox.Patches {
  [HarmonyPatch(typeof(Terminal))]
  public class TerminalPatch {
    [HarmonyPrefix]
    [HarmonyPatch(nameof(Terminal.TryRunCommand))]
    public static bool TerminalTryRunCommandPrefix(Terminal __instance, string text, bool silentFail, bool skipAllowedCheck) {
      string[] array = text.Split(new char[] { ' ' });
      if (array[0].ToLower() != "/goto".ToLower() && array[0].ToLower() != "goto".ToLower()) {
        return true;
      }

      array[0] = "gotoxyz";
      text = string.Join(" ", array);
      __instance.TryRunCommand(text, silentFail, skipAllowedCheck);
      return false;
    }
  }
}
