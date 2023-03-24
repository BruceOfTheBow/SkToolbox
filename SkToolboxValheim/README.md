# ComfyToolbox

  * Toolbox for Comfy Valheim.

## Instructions

### SkToolbox Command List
  * /alt - Use alternate on-screen controls. Press HOME to toggle if active.
  * /coords - Show coords in corner of the screen
  * /console [0/1] - Toggle the console. No parameter to toggle. 1 = Open, 0 = Closed. Intended for use with hotkeys and aliases.
  * /clear - Clears the current console output
  * /clearinventory - Removes all items from your inventory. There is no confirmation, be careful.
  * /detect [Range=20] - Toggle enemy detection
  * /echo [Text] - Echo the text back to the console. This is intended for use with aliases and the autorun features.
  * /env [Weather Name] - Change the weather. No parameter provided will list all weather. -1 will allow the game to control the weather again.
  * /farinteract [Distance=50] - Toggles far interactions (building as well)
  * /findtomb - Pin nearby tombstones on the map if any currently exist
  * /fly - Toggle flying
  * /freecam - Toggle the freecam
  * /ghost - Toggle Ghostmode
  * /give [Item] [Qty=1], OR /give [Item] [Qty=1] [Player] [Level=1] - Gives item to player. If player has a space in name, only provide name before the space. Capital letters matter in item / player name!
  * /god - Toggle Godmode
  * /heal [Player=local] - Heal Player
  * /imacheater - Use the toolbox to force enable standard cheats on any server (some are non-functional still. Work in progress!)
  * /infstam - Toggles infinite stamina
  * /killall - Kills all nearby creatures
  */listitems [Name Contains] - List all items. Optionally include name contains. Ex. /listitems Woo returns any item that contains the letters 'Woo'
  */listprefabs [Name Contains] - Lists all prefabs - List all prefabs/creatures. Optionally include name starts with. Ex. /listprefabs Troll returns any prefab that starts with the letters 'Troll'
  */listskills - Lists all skills
  */nocost - Toggle no requirement building
  */nores - Toggle building restrictions (build anywhere except ward zones)
  */nosup - Toggle building support requirements  - WARNING! - If you rejoin and this is disabled, your structures may fall apart. I recommend using this with the autorun functionality.
  */optterrain - Optimize old terrain modifications. Added so this can be used from chat by default.
  */portals - List all portal tags
  */q - Exit the game quickly
  */removedrops - Removes items from the ground
  */repair - Repair your inventory
  */resetmap - Reset the map exploration
  */resetwind - If wind has been set, this will allow the game to take control of the wind again
  */revealmap - Reveals the entire minimap
  */seed - Reveals the current world seed
  */set cw [Weight] - Set your weight limit (default 300)
  */set difficulty [Player Count] - Set the difficulty (default is number of connected players)
  */set exploreradius [Radius] - Set the explore radius (default = 100)
  */set jumpforce [Force] - Set jump force (default 10). Careful if you fall too far!
  */set pickup [Radius] - Set your auto pickup radius (default 2)
  */set skill [Skill] [Level] - Set your skill level
  */set speed [Speed Type] [Speed] - Speed Types: crouch (def: 2), run (def: 7), swim (def: 2)
  */spawn [Creature Name] [Level=1] - Spawns a creature or prefab? in front of you. Capitals in name matter! (Use /give for items!) Use /listprefabs to search for creatures and prefabs!
    * Please note that as of Valheim version 0.151.1, the game only shows up to 2 stars for creatures, but there is currently a level cap of 10 with this command. Creatures higher than level 3 will show 0 stars, but are in fact the higher level.
  */spawntamed [Creature Name] [Level=1] - Spawns a tamed creature in front of you. Capitals in name matter! Use /listprefabs to search for creatures!
  */stopevent - Stops a current event
  * /tame - Tame all nearby creatures
  * /tod [0-1] - Set time of day (-1 to unlock time) - /tod 0.5
  * /tp [X,Z] - Teleport you to the coords
  * /wind [Angle] [Intensity] - Set the wind direction and intensity
  * /whois - List all players

### Terrain Modification
  Known not working properly as of the latest Valheim update. Previously modified terrain will not get flattened or updated by these commands. This is being worked on, sorry for any inconvenience.
  ?Please note that excessive terrain modification can eventually cause some lag in your world. This game was meant for some terrain modification, but this can enable a lot of modification. Use this as you would like, but be careful with large areas. Please backup your world before using the terrain modification commands.
  
  * /td [Radius=5] [Height=1] - Dig nearby terrain. Radius 30 max.
  * /tl [Radius=5] - Level nearby terrain. Radius 30 max.
  * /tr [Radius=5] [Height=1] - Raise nearby terrain. Radius 30 max.
  * /tu [Radius=5] - Undo/reset all terrain modifications within the radius. Radius 50 max.

### Manual

  * Un-zip `SkToolbox.dll` to your `/Valheim/BepInEx/plugins/` folder.

### Thunderstore (manual)

  2. Go to Settings > Import local mod > Select `RegenRadar_v1.2.3.zip`.
  3. Click "OK/Import local mod" on the pop-up for information.

## Changelog

### 1.0.0

  * Initial fix of SkToolbox v1.10.5 under new Comfy management for compatibility with Valheim patch `0.214.2`