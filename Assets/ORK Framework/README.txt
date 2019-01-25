
ORK Framework
http://orkframework.com


-------------------------------------------------------------------------------------------------------------------------------------------------------
Content
-------------------------------------------------------------------------------------------------------------------------------------------------------

- General Information
- Editor and Scene Wizard
- Tutorials
- Support
- Documentation
- Demo
- Package Description
- iOS Hints
- ORK Version Changelog



-------------------------------------------------------------------------------------------------------------------------------------------------------
General Information
-------------------------------------------------------------------------------------------------------------------------------------------------------

- DLL information
ORK Framework is included in your Unity project using DLLs.
This will dramatically increase your project's compile time if you change any of your own scripts.
The source code for gameplay related code is included - see the 'Package Description' section for details.

- ORK Project asset
When you first open the ORK Framework editor, a new ORK Project asset will be created.
This asset will contain all your ORK Framework settings made in the editor.
It's located at 'Assets/ORK Framework/ORKProject.asset'.

- Event assets
When you create events (e.g. game events, battle events, etc.), each event is stored in a separate file.
You can save the event assets anywhere in your Unity project.
To keep things organized, it's recommended to create a folder structure mirroring the purpose of the events.
E.g. separating game events by location.



-------------------------------------------------------------------------------------------------------------------------------------------------------
Editor and Scene Wizard
-------------------------------------------------------------------------------------------------------------------------------------------------------

- ORK Framework editor
In ORK Framework you'll create your game's data in the ORK Framework editor.
You can open the editor using Unity's menu: Window > ORK Framework.
You can also open the editor using the hot-key 'CTRL + ALT + O'.

The editor is separated into different sections, each section contains multiple sub-sections.
When saving, the editor will display what will change and, depending on what's been changed, offers to update events, scenes and prefabs.
When scenes are updated, please make sure to save your current scene first.

- ORK Scene Wizard
The ORK Scene Wizard is used to add your data to your scenes to create gameplay.
You can open the scene wizard using Unity's menu: Window > Scene Wizard.
You can also open the scene wizard using the hot-key 'CTRL + ALT + W'.



-------------------------------------------------------------------------------------------------------------------------------------------------------
Tutorials
-------------------------------------------------------------------------------------------------------------------------------------------------------

You can find different types of tutorials here:
http://orkframework.com/tutorials/

It's recommended to start with the Game Tutorials to learn using ORK Framework.
This series of tutorials covers creating a game with ORK Framework from start to finish.
You can find them here:
http://orkframework.com/tutorials/game/

If you're seeking information/help with a specific feature, take a look at the how-tos:
http://orkframework.com/tutorials/howto/

If you have any tutorial requests, don't hesitate and contact me:
contact@orkframework.com



-------------------------------------------------------------------------------------------------------------------------------------------------------
Support
-------------------------------------------------------------------------------------------------------------------------------------------------------

Need help or found a bug?

Please search for a solution in the ORK Community forum:
http://forum.orkframework.com/

Didn't find anything? Contact me:
contact@orkframework.com



-------------------------------------------------------------------------------------------------------------------------------------------------------
Documentation
-------------------------------------------------------------------------------------------------------------------------------------------------------

The documentation is built into the ORK Framework editor.
All settings are explained in the help window in the ORK Framework editor.

Information and help texts will be displayed if you hover with the mouse over a setting or foldout.
You can change this behaviour in the editor settings (Editor > Editor Settings).

There currently is no separate documentation available.



-------------------------------------------------------------------------------------------------------------------------------------------------------
Demo Project
-------------------------------------------------------------------------------------------------------------------------------------------------------

- Downloading the demo
You can download a complete Unity demo project here:
http://orkframework.com/showcase/

Unzip the file after download, the folder contains a Unity project, i.e. don't import it into an existing project - open it as a Unity project.

- Starting the demo
To start the demo, open the main menu scene (0 Main Menu) and press play.

- Controls
Use the 'Arrow' keys to move your player and change menu selections.
The 'Escape' key opens the menu. Use 'Enter' to accept and 'Right-Ctrl' to cancel.
In real time combat, use 'Space' to attack and 'Left-Ctrl' to open the battle menu.

- Game Tutorials
The demo project is the result of the game tutorial series.
I'd highly recommend to go through the tutorials to learn the basic workflow and settings you'll need when working with ORK Framework:
http://orkframework.com/tutorials/game/



-------------------------------------------------------------------------------------------------------------------------------------------------------
Package Description
-------------------------------------------------------------------------------------------------------------------------------------------------------

- Gizmos (folder)
Contains the gizmo icons (32x32) used by ORK Framework.

- DLL (folder)
3 DLLs containing ORKFramework.

- gameplay_source_code.zip
Contains the gameplay related source code and a plugin template as MonoDevelop projects.
Please read the included README.txt for details.
There currently is no separate documentation available.



-------------------------------------------------------------------------------------------------------------------------------------------------------
iOS Hints
-------------------------------------------------------------------------------------------------------------------------------------------------------

If you're building your project for iOS, you may run into some problems:

- Crash after splash screen: "You are using Unity iPhone Basic. You are not allowed to remove the Unity splash screen from your game"
To fix this, change in XCode's build settings the 'Compress PNG files' setting to NO and build the project again.

- Crash after splash screen: "Ran out of trampolines of type 2"
This is caused by use of generics, you have to tell the AOT compiler allocate more trampolines.
To fix this, change in Unity's Player Settings > Other Settings the 'AOT Compiler Options' to nimt-trampolines=512.
If you're still receiving a trampoline error, increase the number, e.g. 1024.

- Crash/stop after or before splash screen: 'EXC_BAD_ACCESS'
This can be caused by Unity engine code being stripped when using 'IL2CPP' scripting backend.
To fix this, disable 'Strip Engine Code' in Unity's PlayerSettings > Other Settings in your iOS player settings.

- Using the new UI (Unity 4.6+) and content is displayed outside of masks (e.g. text extends outside of GUI box).
Go to 'Edit > Project Settings > Player' and enable 'Use 24-bit Depth Buffer' in the iOS 'Resolution and Presentation' settings.


You can find more detailed instructions on the Unity trouble shooting page:

http://docs.unity3d.com/Manual/TroubleShootingIPhone.html



-------------------------------------------------------------------------------------------------------------------------------------------------------
ORK Version Changelog
-------------------------------------------------------------------------------------------------------------------------------------------------------

Version 2.21.0:
- new: Flying Texts: Position Settings: 'Reset Order' settings available when using 'Use In Order' setting. Optionally reset the order after a defined amout of time. E.g. use this to have changes of an ability use different positions, resetting shortly after to reuse them from the first position in the next use.
- new: Battle Settings: Flying Texts: 'Default Position Settings' available. Define the default position settings for all flying texts, each flying text setting can optionally override the default positions. All flying texts using the default positions share the position order (when using 'Use In Order'), i.e. each different flying text will progress using the next position.
- new: Grid Settings: Grid Move: 'Limit Height Movement' settings available. Optionally define a maximum height difference for upward/downward movement between grid cells. E.g. use this to prevent combatants from moving on cells that are too high to move to from lower cells. Can be overridden by each combatant.
- new: Combatants: Grid Settings: 'Limit Height Movement' settings available. Optionally override the default settings defined in the grid move command. E.g. use this to create flying enemies that shouldn't take height limits into account.
- new: Battle Settings: Target Information Dialogue: 'HUD Placement' setting available. Define where the HUD elements will be placed in relation to the dialogue's content, either as defined by the elements, before the content (moving the content downward) or after the content.
- new: Battle End: 'Combatant Gain Notification' settings available. Optionally display a dialogue displaying a combatant's victory gains (experience and status value gains, not coming from level ups). Can optionally be combined with level up texts.
- new: Battle End: Level Up Notification: 'Combine Level Ups' settings available. Optionally combine all level ups and class level ups of a combatant using separator texts instead of displaying them as separate dialogues.
- new: Battle End: Level Up Notification: New text codes available in all status value related texts. Use '%old' and '%new' to display the old and new value of the status value, 'Normal' type status values can also use '%oldb' and '%newb' to display the old/new base values (without bonuses).
- new: Menu Settings: Status Preview Settings: 'Overrule Selection Previews' setting available. Selection previews (e.g. during target selection or grid move selection) can be overruled by other previews (e.g. from a tooltip when hovering over a shortcut bar).
- new: Menu Settings: Status Preview Settings: 'UI Hides Selection Previews' setting available. Selection previews (e.g. during target selection or grid move selection) are hidden while the cursor is over a GUI box (e.g. a HUD).
- new: Save Game Menu: 'Delete File' settings available. Optionally use an input key to delete the currently selected save file (choice) in 'Save Game Menu' and 'Load Game Menu' dialogues.
- new: Save Game Menu: 'Use Delete Key' setting available in 'Save Game Menu' and 'Load Game Menu' dialogues. Optionally use the delete input key defind in the 'Delete File' settings.
- new: GUI Boxes: Choice Settings: 'Use Fixed Offset' settings available for 'Circle' type choice mode. Optionally define a fixed offset in degrees between choices. If disabled, the offset is calculated based on the number of choices and the 'Circle Degree' setting.
- new: HUDs: Tooltip: 'Type Tooltip' settings available. Optionally display the tooltip HUD for type content (e.g. item types, ability trees, areas, area types, etc.).
- new: HUDs: Console: 'Enable Tooltip' setting available. Optionally add tooltips to the console type tabs of the HUD.
- new: Menu Screens: Ability, Ability Tree, Equipment, Inventory, Inventory Exchange, Research: 'HUD Placement' setting available. Define where the HUD elements will be placed in relation to the dialogue's content, either as defined by the elements, before the content (moving the content downward) or after the content.
- new: Menu Screens: Ability, Ability Tree, AI Behaviour, AI Ruleset, Bestiary Area/Type, Crafting, Inventory, Inventory Exchange, Log, Quest, Research: 'Enable Tooltip' settings available for type settings. Optionally display a tooltip for menu items representing a type/tree/area.
- new: Menu Screens: Information, Combatant, Group Combatant: 'Unfocused Control' setting available. Optionally allow using the page change keys when the menu part isn't focused.
- new: Shop Layouts: Type Box: 'Enable Tooltip' setting available. Optionally display a tooltip for menu items representing an item type.
- new: Event System: Join Active Group: Advanced level and class level settings available. Previous settings will be updated automatically.
- new: Event System: Is Item Collected: 'Is Item Collected' node available in 'Game > Scene' nodes. Checks if an item in a scene (identified via scene ID) has been collected.
- new: Event System: Is Battle Finished: 'Is Battle Finished' node available in 'Game > Scene' nodes. Checks if a battle in a scene (identified via scene ID) has been finished.
- new: Event System: Is Menu Open: 'Is Menu Open' node available in 'Game > Menu' nodes. Checks if a defined menu screen or any menu screen is opened.
- new: Event System: Is Shop Open: 'Is Shop Open' node available in 'Game > Shop' nodes. Checks if a defined shop or any shop is opened.
- new: Event System: Store Combatant Cell: 'Store Combatant Cell' node available in 'Battle > Grid' nodes. Stores or loads the combatant's cell coordinates and direction. Use this to remember the combatant's placement on the grid between battles.
- new: Item Collectors: 'Collected Game Event' setting available for 'Single' and 'Random' item collectors not using 'Destroy Collected Object'. Optionally use a game event for already collected items when loading the scene. E.g. use this to open already collected chests.
- change: Battle End: The 'GUI Box' settings are now found in 'Victory Gains Notification', 'Combatant Gains Notification' and 'Level Up Notification' settings. Previous settings will be updated automatically.
- change: Flying Texts: All text notifications (e.g. damage/refresh texts of status values or status effect apply/remove texts) have been renamed to flying texts to more appropriately state what they are. This includes various settings throughout the framework (e.g. options to enable/disable showing a flying text for status changes).
- change: Flying Texts: Using positions in order ('Use In Order' setting) is now individual for each combatant.
- change: Event System: The 'Show Notification' node has been renamed to 'Show Flying Text'.
- change: Event System: Dialogue Nodes: Stopping an event (e.g. using 'Stop On Destroy' in an event interaction) will now close a currently displayed dialogue.
- change: Scripting: Save Games: You can now access the last save game index that was saved or loaded through 'ORK.SaveGame.LastIndex'.
- change: GUI Boxes: Tabs: The selected tab is now highlighted when using the new UI.
- change: Grid Highlights: Move Range: The move range is no longer highlighted when no cells are available. E.g. using a line renderer highlight with 'Enclosed Cells' enabled previously added a highlight around the player's cell.
- fix: Menu Screens: Group: Fixed an issue where using drag and drop options didn't add HUD elements to the combatant choices.
- fix: Grid Settings: Grid Move: Selecting a the cell of a combatant you can move over no longer previews move/AP costs.
- fix: Status Previews: Fixed an issue where 'Normal' type status values with 'Combined Value' enabled didn't calculate the correct preview value.
- fix: Grid Settings: Grid Move: Using 'Diagonal Move' without 'Diagonal Distance One' could lead to paths being dismissed when using the grid move action.
- fix: HUDs, Input Keys: Fixed an issue where 'Control' HUD inputs could be received a frame after being released, causing double input in some cases.
- fix: GUI Boxes: Fixed an issue where the text alignment of tabs wasn't used correctly.


Version 2.20.0:
- new: Content Layouts: New text codes available in all content layouts throughout the framework. You can now specifically show the quantity ('%q'), buy price ('%bp'), total buy price ('%tbp'), sell price ('%sp') and total sell price ('%tsp') of displayed content instead of using the context specific info text code ('%').
- new: Camera Controls: Mouse, Top Down Border: 'Audio Clip' settings available for non-axis input keys. Optionally play an audio clip when using the input keys.
- new: Game Settings: Area Notifications: 'Close On Scene Change' setting available. Optionally close area notifications immediately and drop all queued notifications when changing scenes.
- new: Console Settings: 'Auto Remove Lines' settings available. Optionally remove console lines after a defined amount of time.
- new: Shops: 'Inventory Exchange Menu' settings available. Optionally use an 'Inventory Exchange' menu screen instead of a shop layout.
- new: Ability Types, AI Types, Crafting Types, Combatant Types: 'Item Type' setting available. Defines the corresponding item type of the various types. The item type will be used for type separation of abilities, AI rulesets/behaviours, crafting recipes and combatants in shops and inventory menus.
- new: Formulas: Selected Data Count: 'Selected Data Count' node vailable in 'Selected Data' nodes. Checks how many data is stored in a selected data list.
- new: Formulas: Select Combatant: 'Select Combatant' node available in 'Selected Data' nodes. Uses combatants as selected data.
- new: Formulas: Select Item: 'Add AI Behaviours', 'Add AI Rulesets' and 'Add Crafting Recipes' settings available in 'Item Box Settings'. Optionally add AI behaviours/rulesets and crafting recipes to selected data.
- new: Inventory Settings: Mark New Content: 'Shop Settings' available. Optionally use different settings for shops. Currently only using an 'Inventory Exchange' menu as a shop layout allows marking new content.
- new: Inventory Settings: Item Box: 'Inventory Exchange Menu' settings available. Optionally use an 'Inventory Exchange' menu screen instead of the item box dialogue.
- new: Battle AI: Variables, Selected Data: Battle AIs now support local variables and selected data.
- new: Battle AI: Selected Data Nodes: 'Selected Data' nodes available. Store and check selected data, e.g. combatants, items or abilities. Selected data can be used as variable origin, e.g. to check ability variables.
- new: Battle AI: Change Game Variables: 'Change Game Variables' node available. Allows changing game variables from different sources, e.g. local, global or object variables. This node replaces the previous 'Change Object Variables' node.
- new: Battle AI: Check Game Variables: 'Variable Origin' settings available. Now supports checking game variables from different sources, e.g. local, global or object variables.
- new: Grid Settings: Examine Grid: Combatant Info Box: 'Call Key' settings available. Optionally use a defined input key to open a combatant info box. This can also be limited to only be available while the cursor is over the combatant, e.g. for right-click examining.
- new: Grid Settings: Examine Grid: Combatant Info Box: 'Open Audio' and 'Close Audio' settings available. Optionally play an audio clip when opening or closing a combatant info box.
- new: Grid Highlights: Move Command: 'Blocked Highlight Occupied' setting available. Highlighting cells occupied by combatants as blocked or passable is now optional. By default enabled (using blocked/passable highlights).
- new: Grid Cell Types: 'Use Position Offset' settings available. Optionally adds an offset to the cell's original placement position. Combatants are placed at the cell's position, e.g. use this to create elevated cells without having elevated terrain.
- new: Grid Cell Types, Grid Highlights: Prefabs: 'Use Original Position' setting available. Optionally place prefabs at the original placement position of a grid cell. Only used by cells that use position offsets.
- new: GUI Boxes: Input Field Settings: 'Number Input Type" settings available. Define how number value inputs are displayed, either as a 'Slider' or as 'Horizontal Buttons'.
- new: GUI Boxes: Choice Settings: 'Drag Only Selected' setting available. Optionally only allow dragging selected choices.
- new: HUDs: Console, Control, Information, Tooltip: 'Game Running' game state condition available. Optionally also display HUDs when the game is not running (e.g. in the main menu scene or after game over).
- new: HUDs: Toggle Key: 'Audio Clip' settings available. Optionally play an audio clip when using the toggle key.
- new: HUDs: Control: 'Audio Clip' settings available for 'Positive Button' and 'Negative Button' control types. Optionally play an audio clip when using the button.
- new: HUDs: Click Action: You can now add multiple click actions to HUD elements.
- new: HUDs: Click Action: 'Toggle HUD' click action available. Toggles defined HUDs on or off.
- new: HUDs: Click Action: 'Released After' setting available. Defines the time in seconds the player must hold the click/touch to start the click action. E.g. open a menu screen when releasing the mouse button after 2 seconds.
- new: HUDs: Click Action: 'Consume Click' setting available. The click will be consumed by the click action. E.g. a click on a shortcut slot can't trigger using the shortcut.
- new: Main Menu, Menu Screens: Options: 'Number Input' settings available. Number value inputs can optionally override the setting of the used GUI box and use a different number input type.
- new: Main Menu, Menu Screens: Options: 'Accept' and 'Cancel' option types available. Add button inputs to accept or cancel the changes. Using button inputs will hide the ok/cancel buttons of the GUI box.
- new: Menu Screens: 'Fail Audio' settings available. Optionally play an audio clip when opening the menu screen fails due to requirements.
- new: Menu Screens: Status Value Distribution: 'Status Value Distribution' menu part available. Allows distributing points to change status values. Define where the points come from (e.g. experience points), which status values are available and how much they change per point.
- new: Menu Screens: Inventory Exchange: 'Inventory Exchange' menu part available. Similar to the 'Inventory' menu part, this menu part allows exchanging content between 2 sources, e.g. 2 combatants, a combatant and an item box or a combatant and a shop. Displays both sources alongside each other, optionally separated by item type.
- new: Menu Screens: Inventory, Ability, Ability Tree: 'Start Focused' setting available in 'Item Box Settings' and 'Ability Box Settings'. Optionally focus the item/ability box instead of the type box when opening the menu screen.
- new: Menu Screens: Inventory: 'Add AI Behaviours', 'Add AI Rulesets' and 'Add Crafting Recipes' settings available in 'Item Box Settings'. Optionally show AI behaviours/rulesets and crafting recipes in the inventory menu.
- new: Menu Screens: 'No Hidden User' setting available. Optionally block hidden group members from being the menu screen user when opening the menu screen.
- new: Event System: Value Input Dialogue: 'Option Type' setting available. You can now display a 'Variable' (as previous) or an 'Accept' or 'Cancel' button input. Using button inputs will hide the ok/cancel buttons of the GUI box.
- new: Event System: Value Input Dialogue: 'Number Input' settings available. Number value inputs can optionally override the setting of the used GUI box and use a different number input type.
- new: Event System: Select Item: 'Add AI Behaviours', 'Add AI Rulesets' and 'Add Crafting Recipes' settings available in 'Item Box Settings'. Optionally add AI behaviours/rulesets and crafting recipes to selected data.
- new: Event System: Call Menu Screen: 'Inventory Exchange' settings available. Optionally define the inventory sources when calling a menu screen with an 'Inventory Exchange' menu part. Combatants and item boxes can be used as inventory sources.
- new: Event System: Distance To Variable: 'Distance To Variable' node available in 'Movement > Movement' nodes. Stores the distance or grid distance between 2 game objects into a float game variable.
- new: Battle Events: Learn Action Ability: 'Learn Action Ability' node available in 'Battle > Action' nodes. Learns the ability of the used battle action. Only used if the used battle action is an ability action.
- change: Battle AI: The 'Change Object Variables' node has been replaced with the new 'Change Game Variables' node. Previous nodes will be updated automatically.
- change: Grid Settings: Examine Grid: Combatant Info Box: The 'Auto Show' setting is now available for each combatant info box instead of for all of them combined.
- change: Shops: Sell to Shop: 'AI Types' and 'Crafting Types' settings have been removed. Limiting sellable AI behaviorus/rulesets and crafting recipes is now handled through their type's item type.
- change: Shop Layouts: Type Box: 'Combined Sorting' setting has been removed due to no longer displaying different types (e.g. item types and ability types) in shops.
- change: Shop Layouts: Using the 'All' buy quantity selection now prevents buying items if the player doesn't have enough currency to buy all available items.
- change: Event System: Start Item Collection: The 'Start Item Collection' node is now available in all event types.
- change: Event System: Menu nodes are now available in all event types.
- change: GUI Boxes: Having 'Select First' enabled and clicking on a not selected choice button will now play the 'Cursor Move' audio clip.
- change: Scripting: Combatants: All class related functions and properties of a combatant are now accessed via the 'Class' property, e.g. the class level via 'combatant.Class.Level' instead of 'combatant.ClassLevel'.
- change: Scripting: Combatants: All game object and component references of a combatant are now accessed via the 'Object' property, e.g. the move AI component via 'combatant.Object.MoveAI' instead of 'combatant.MoveAI'.
- change: Scripting: Combatants: All UI related functions and properties of a combatant are now accessed via the 'UI' property, e.g. the current HUD effect index via 'combatant.UI.EffectIndex' instead of 'combatant.HUDEffectIndex'.
- change: Scripting: Combatants: All battle menu related functions and properties of a combatant are now accessed via the 'Battle' property, e.g. the battle menu via 'combatant.Battle.BattleMenu' instead of 'combatant.BattleMenu'.
- change: Scripting: Combatants: All level and level up related functions and properties of a combatant are now accessed via the 'Status' property, e.g. the current level via 'combatant.Status.Level' instead of 'combatant.Level'.
- change: Scripting: Combatants: All status effect related functions and properties of a combatant are now accessed via the 'Effects' property, e.g. blocking items state via 'combatant.Status.Effects.BlockItems' instead of 'combatant.Status.BlockItems'.
- change: Status Effects: 'Stop Move' setting has been renamed to 'Block All Actions'.
- fix: Screen Fader: Fixed an issue where the screen fader didn't occupy the full screen when using the new UI and high differences between default screen size and actual screen size (e.g. 1080x1920 and 1920x1080).
- fix: Shops: Buying abilities with quantity limits didn't reduce quantity or remove the ability from the shop.
- fix: Shop Layouts: The buy/sell price is now displayed correctly for the total available quantity when using 'All' buy/sell quantity selections. Previously it displayed the price for a quantity of 1, regardless of the available amount.
- fix: GUI Boxes: New UI: Fixed an issue where clicking on inactive choices didn't select the choice when using the new UI.
- fix: Combatants: Conditional Prefabs: Fixed an issue where certain conditions didn't automatically change the prefab, e.g. 'In Battle'.
- fix: Notifications: Fixed an issue where notifications where still queued when exiting to the main menu.
- fix: HUDs: Toggle Key: Fixed an issue where 'Use While Key' actually reversed the state.
- fix: HUDs: Information: Click Action: Fixed an issue where using a 'Menu Screen' click action could lead to an error in 'Information' type HUDs.
- fix: Menu Screens: Fixed an issue where using an open game event with 'Wait' enabled that has wait times (e.g. 'Wait' node or waiting for a camera transition) could prevent the menu screen from being opened.
- fix: Save Games: Fixed an issue where loading a save game could result in doubling the dropped items (dropped from inventory).


Version 2.19.0:
- new: Abilities, Items, Weapons, Armors: Variables: 'Use In Description' setting available. Optionally replace variable text codes in the description with the ability/item/equipment variables instead of global variables.
- new: Combatants: Battle Animations: 'Battle Animations' are now defind in the combatant's 'Battle Settings > Override Settings'. The default battle animations for actions like defend, escape or death are now defined in 'Battle System > Battle Settings' for all combatants. Each combatant can override individual battle animations for abilities, items and default actions (defend, etc.). Previous settings will automatically update and add overrides for all default actions.
- new: Battle Settings: Battle Animations: 'Battle Animations' settings available. Define battle animations for default actions (e.g. defend, escape or death) for all combatants. Combatants can optionally override the default battle animations.
- new: Battle Settings, Abilities, Items: Cast Time: 'Game Event Settings' available. Optionally execute game events when a combatant starts casting or cancels casting an action. The combatant is used as starting object of the game event, the casted action is available as selected data via the key 'action'.
- new: Battle Settings: 'Base Counter Chance', 'Base Block Chance' and 'Base Experience Factor' settings available. You can now define default counter/block chances and experience factor for all combatants. Each combatant can individually override these settings. Previous settings will automatically update to override the default settings.
- new: Battle Menu: Shortcut Slot: 'Shortcut Slot' battle menu item type available. Displays a shortcut assigned to a defined shortcut slot. Supports ability, item, equipment, defend, escape, none (end battle), grid move, grid examine and grid orientation shortcuts. The battle menu item isn't displayed if the shortcut slot is empty or occupied by an unsupported shortcut.
- new: Battle Menu: Ability: 'Single Ability' settings available. Optionally display a single, defined ability instead of a list of abilities. If the ability isn't available for the combatant, the battle menu item isn't displayed.
- new: Battle Menu: Item: 'Single Item' settings available. Optionally display a single, defined item instead of a list of items. If the item isn't in the combatant's inventory, the battle menu item isn't displayed.
- new: Battle Grid Settings: Move Command: 'Move To Own Cells' setting available. Optionally allow a combatant to move to cells it currently occupies itself (due to the combatant's grid cell size).
- new: Battle AI: 'Ignore Size Cells' setting available in all nodes checking grid distances. Checking a combatant's size cells is optional. By default disabled (checking size cells).
- new: Formulas: Check Grid Distance: 'Ignore Size Cells' setting available. Checking a combatant's size cells is optional. By default disabled (checking size cells).
- new: Combatants: Grid Cell Size: 'Grid Cell Size' settings available. Optionally allow a combatant to occupy more than 1 grid cell in grid battles.
- new: Combatants: 'Base Escape Chance' setting available. Combatants can now optionally override the default escape chance defined in the battle settings.
- new: Menu Screens: Ability Tree, Research, Status Value Upgrades: New preview values available. E.g. selecting a status value upgrade will show the status value changes as a preview (including the learn costs). Also, unlearned passive abilities will preview their bonuses. You need a HUD (e.g. in a 'Combatant' menu part) to display the preview values by using one of the 'Preview' value origins in 'Status Value' HUD elements.
- new: Event System: Store Grid Path: 'Store Combatants' settings available. Optionally store the combatants placed on the grid path cells instead of the cells.
- new: Event System: Check Grid Distance: 'Check Cell Combatant' settings available. Optionally use the combatant placed on a cell for the distance check, taking the combatant's size cells into account.
- new: Combatant Spawners: 'Spawn At Position' setting available when using colliders for area spawning. Optionally spawns the combatants at the position of the game object (or defined game objects) instead of randomly spawning within the collider's area. Use this setting to use trigger start types for the spawner but still spawn at defined positions.
- new: Editor: Color Fields: Added support for HDR color picker.
- change: Battle System: Performance improvements throughout the battle system, especially in battle grid operations that cause a lot of things per frame (e.g. calculating the move range cells).
- change: Event System: Grid Nodes: All nodes related to grid paths have been moved from 'Battle > Grid' to 'Battle > Grid Path'.
- change: Item Collectors: Item collectors now show the 'Inventory Full' notification if an item can't be collected due to the limited space in the player's inventory.
- change: Battle Components: Using 'Own Spots' will automatically fall back to the defined standard spot if an advantage spot isn't selected (player/enemy advantage battle).
- change: Combatants: The 'Turn Start Events' and 'Turn End Events' settings can now be found in the combatant's 'Base Settings > Game Event Settings'.
- change: Status Development: Experience: 'Experience' type status values can now also use formulas instead of being limited to using curves.
- fix: HUDs: Fixed an issue where background images of empty HUD elements where still displayed when not using 'Display Empty Elements'.
- fix: Battle AI: Check Height Differences: 'Check Height Differences now also works in non-grid battles.
- fix: Battle AI: Grid Move: Fixed an issue where 'Avoid Allies' used the 'Avoid Enemies' range.
- fix: Combatant Spanwers: Fixed an issue where failing a combatant's requirement stops spawning the following combatants.
- fix: Game States: Changing Scene: The 'Changing Scene' state wasn't valid during a load game scene change.
- fix: Battle Grids: Grid Cell Events: Fixed an issue where grid cell events could prevent a combatant from finishing the turn.
- fix: HUDs: Fixed an issue where percent values (e.g. 'Status Value' HUD elements) resultet in 'NaN' when having a maximum value of 0.
- fix: Status Values: Consumable: Fixed an issue where setting the start value in 'Percent' wasn't correct if the value's minimum value wasn't 0.


Version 2.18.0:
- new: Camera Controls: Top Down Border: 'Remember Rotation', 'Remember Panning' and 'Remember Zoom' settings available. Optionally remember the current rotation, panning or zoom of the camera between scenes.
- new: Camera Controls: Mouse: 'Remember Rotation' and 'Remember Zoom' settings available. Optionally remember the current rotation and zoom of the camera between scenes.
- new: Abilities, Items: 'Target Range Toggle' setting available when using 'Single' or 'Group' target range. Optionally allow the player to toggle between 'Single' and 'Group' target range during target selection.
- new: Abilities: User Changes: 'Target Hit Only' setting available. Optionally only use user changes (including critical changes) if at least 1 target was hit.
- new: Abilities: Cast Time: 'Own Cast Time' setting available. Abilities can override the (new) default ability cast time setting (defined in the battle settings). Settings will automatically be udpated to use own cast times if they previously used a cast time.
- new: Abilities: Cast Time: 'Play Sound' settings available. Optionally play an audio clip or sound type on the user when starting to cast an ability.
- new: Abilities, Items, Weapons, Armors: Variables: Initializing the variables of a new instance will now allow using the instance itself as selected data with the 'action' key. This can be e.g. used in formulas to use other variables for another variable's calculation (must be set up before the one with the formula calculation).
- new: Abilities, Items: 'Allow Dead User' setting available. Optionally allow action calculation if the user is dead. E.g. if the user fired a projectile (using a 'Damage Dealer' component to do damage), the projectile can still cause damage if the user was killed.
- new: Items: Cast Time: 'Cast Time' settings available. Like abilities, items can now use cast times before actually using the item.
- new: Battle Settings: 'Target Range Key' setting available. Use this key to toggle between 'Single' and 'Group' target ranges for abilities/items that allow toggling the target range. Can be used during target selection, e.g. in battle menus or menu screens.
- new: Battle Settings: Cast Time: 'Cast Time Settings' available. Optionally use cast times for abilities, items, defend, escape, none and grid move commands.
- new: HUDs: Timebar: 'Timebar' HUD type available. Displays a timebar image and places combatant HUDs on the timebar based on their current timebar value. Optionally also includes cast time placement on the bar.
- new: HUDs: Combatant: Cast Time: New text codes available to display the cast action's description ('%d') and icon ('%i).
- new: Event System: Nav Mesh Warp: 'Nav Mesh Warp' node available in 'Movement > Movement' nodes. Warps a NavMesh agent to a new position.
- new: Event System: Despawn Combatant Spawner: 'Despawn Combatant Spawner' node available in 'Combatant > Combatant' nodes. Despawns all combatants of a combatant spawner, i.e. removes them and makes them available for spawning at a later time (no automatic respawn).
- new: Event System: Is Casting Item: 'Is Casting Item' node available in 'Combatant > Inventory' nodes. Checks if a combatant is currently casting an item.
- new: Event System: Get Combatant Gains: 'Get Combatant Gains' node available in 'Battle > Gains' nodes. Collects the loot and status value rewards (including experience) from a combatant. The loot/gains can only be collected once per combatant, e.g. use this node if you want to drop a combatant's loot early in its death event instead of after the event finished.
- change: Battle Grids: Performance improvements on various grid operations, especially calculating move range cells.
- change: Formulas, Event System: Change Game Variables: Formulas and events now pass on the local variables and selected data to variable changes. I.e. you can now use them in formulas used to calculate a variable change.
- change: Active Time Battles: Cast Time: Changes how cast time is handled in 'Active Time' battles without dynamic combat. Previously, casting would block other actions from being performed (or start casting). Now, actions can be performed while another combatant is casting an action and casting can start while a combatant performs an action.
- fix: Dragging: Fixed an issue that caused an error when using click drag.
- fix: Level Up: Fixed an issue where 'Fully Recover' didn't take status value bonuses into account.
- fix: Active Time Battles: Fixed an issue where AI controlled combatants didn't perform actions if the 'Menu Border' was below the 'Action Border'.


Version 2.17.1:
- new: Inventory Settings, Items, Weapons, Armors: Stack Limit: 'Stack Limit' settings available. Optionally limit the quantity of items that can be stored in a single stack. Items exceeding the stack limit will be stored in a new/other stack.
- new: Items, Weapons, Armors: 'Per Stack' setting available. Optionally use the 'Inventory Space' per item stack instead of per item.
- new: Battle Settings: Battle Camera: 'Look At Selecting User' settings available. Optionally have the battle camera look at the combatant that last started selecting an action. This is used for all combatants, unlike 'Look At Menu User', which only looks at player controlled combatants. E.g. use this if you're using AI decision time to look at the combatant before it performs an action.
- new: Phase Battles: Player Combatant Selection: 'Force AI Combatants' setting available. Optionally force AI controlled members of the player group to perform their turn before the other combatants. If disabled, AI controlled combatants perform their turn when selected by the player. If the combatant selection isn't used, the AI controlled combatants will perform their turn in order as all other combatants.
- new: Grid Highlights: Line Renderer: 'Line Renderer Settings' available for grid highlights. Optionally use a prefab with a line renderer to create an outline around the highlighted cells. Can be used in addition to prefab and blink highlights.
- new: Grid Cell Types: 'Line Position Offset' setting available. Defines the offset a line renderer highlight will have from the cell.
- new: Event System: Store Grid Cells: 'Use Separate User' setting available. Optionally use a separate combatant as the user of the used grid shape. Otherwise the origin cell's combatant will be used.
- new: Event System: Grid Cell To Variable: 'Grid Cell To Variable' node available in 'Battle > Grid' nodes. Stores a cell's coordinates in the grid into a Vector 3 game variable.
- new: Event System: Grid Cell From Coordinate: 'Grid Cell From Coordinate' node available in 'Battle > Grid' nodes. Stores a cell into a found/global objects list based on the cell's coordinates in the grid.
- change: Battle Camera: 'Look At Menu User' will now also look at player combatants that start choosing actions when the battle menu isn't opened automatically.
- change: Research Trees: Finishing a research item will now update its duration.
- fix: Event System: Check Status: Fixed an issue where 'Store Combatants' stored combatants with invalid conditions instead of valid conditions.
- fix: Menu Screens: Changing the menu user via input keys didn't play the 'Change User' audio clip.
- fix: Battle Range Templates: Grid Shape: Fixed an issue where disabling 'Add Occupied Cells' resulted in only occupied cells being used for use ranges.
- fix: Camera Controls, Input Keys: Fixed an issue where some camera controls using custom input key origins where not recognized when not defining a button function in addition to the axis function.
- fix: Weapons, Armors: Equipment Abilities: Fixed an issue where equipping the same equipment twice (on different equipment parts) and removing one of them removed the equipment ability, although it should still be there from the other equipment.


Version 2.17.0:
- new: Game Controls: Top Down Border Camera: 'Use Axis' settings available for rotating and zooming the camera. Optionally use a single axis key instead of two separate input keys.
- new: Formulas: Status Origin: 'Selected' status origin available. Use a combatant stored in selected data as status origin.
- new: Battle AI: Change Move AI: 'Change Move AI' node available in 'Move AI' nodes. Changes the move AI of the user.
- new: Battle AI: Change Move AI Mode: 'Change Move AI Mode' node available in 'Move AI' nodes. Changes the use mode of the user's move AI.
- new: Abilities, Items: Change Class: 'Unequip All' setting available. Unequipping all weapons/armors before a class change is now optional (but recommended). By default enabled.
- new: Status Requirements: Action Bar: 'Action Bar' requirement selection available. Checks a combatant's action bar or used action bar. In turn based and phase battles, the action bar represents the actions per turn. In active time battles, the action bar represents the timebar.
- new: Status Requirements: Is Researching: 'Is Researching' requirement selection available. Checks if a combatant is currently researching any research items.
- new: Inventory Settings: Space Limit: 'Only Leader (Group)' setting available when using 'Group' inventory. Optionally calculate the inventory space using only the leader of the group instead of summing up the value for each group member.
- new: Combatant Groups, Battle Components: 'Formula' level and class level initialization available. Optionally use a formula to determine a combatant's level or class level.
- new: Combatant Groups, Battle Components: 'Requirements' settings available for combatants. Optionally use difficulty and variable conditions to determine if a combatant is used or not.
- new: Battle Settings: Group/Individual Targets: 'Target Requirements' settings available. Optionally use status requirements and variable conditions to only allow selecting specific targets.
- new: Battle Range Templates: Grid Shape: 'In User Space' setting available when using a 'Mask' shape type in local space. Optionally use the user of the range instead of the used cell's combatant for the local space rotation of the shape. E.g. when used in affect ranges, it'll rotate the shape based on the user's orientation instead of the targets.
- new: Grid Settings: Examine Grid: Combatant Info Box: 'Show For Player', 'Show For Ally' and 'Show For Enemy' settings available. Showing a combatant info box can now be separated for player, ally and enemy combatants.
- new: Grid Highlights: Combatant Cell: 'Use Turn Ended Cells' settings available. Optionally use a different grid highlight for player, ally or enemy combatants that finished their turn.
- new: Grid Cell Types: Random Cell Type: 'Random Cell Type' settings available. Optionally set up a grid cell type to use a random cell type out of a defined list of cell types. The random cell type is used when the grid is created in-game.
- new: Grid Cell Types: 'Random Prefab' settings available. Optionally add additional prefabs for cells of a cell type, one of the defined prefabs will be used randomly when creating the cell in-game.
- new: Grid Cell Types: 'Highlight Position Offset' and 'Highlight Rotation Offset' settings available. Adds position and rotation offsets to all highlight prefabs.
- new: Grid Cell Types: Deployment: 'Preferred Member Index' setting available. Optionally define the group member index that is preferred for a deployment cell to allow automatic combatant placement to adjust to the member index.
- new: Menu Settings: Drag/Drop Settings: 'Block Tooltips' setting available. Optionally block tooltips while dragging something.
- new: Menu Settings: Status Preview Settings: 'Action Cost' and 'Move Cost' settings available. Optionally preview action costs for abilities, items and other actions. Optionally preview move costs for grid move cell selections. All action cost previews can be enabled separately.
- new: Main Menu: Custom: 'Keep Open' setting available for 'Custom' main menu options. Optionally keep the main menu opened when using a custom choice.
- new: Main Menu, Menu Screens: Options: 'Is PlayerPrefs' setting available for 'Custom' options. Optionally store the values in PlayerPrefs instead of game variables.
- new: HUDs: Combatant, Turn Order, Latest Turn: 'Research Item' HUD element type available. Lists a combatant's research items. E.g. use this to show all items currently in research.
- new: HUDs: Combatant, Turn Order, Latest Turn: 'Value Origin' settings available in 'Actions Per Turn' and 'Grid Move Range' HUD elements. Optionally use preview values for actions per turn or grid move range.
- new: HUDs: Combatant, Turn Order, Latest Turn: 'No Time Cycle' setting available for 'Status Effect' HUD elements. Optionally ignore the 'HUD Effect Time' and display status effects starting with the 1st applied effect.
- new: HUDs: Combatant: 'Cursor Over Cell' setting available when using 'Cursor Over'. Optionally also count the combatant's cell in grid battles as the cursor being over the combatant.
- new: Menu Screens: Combatant: 'Allow Drag Sort' setting available for 'Battle' and 'Group' combatant scopes. Optionally allow rearringing combatants using drag and drop controls. The changed sorting will be stored and only affects the visual presentation in other menu screens, not the actual group positions.
- new: Menu Screens: Group: 'Allow Drag Sort' setting available in 'Battle Group Box' and 'Non-Battle Group Box' settings. Optionally allow rearringing combatants using drag and drop controls. This will change the actual group positions.
- new: Menu Screens: Crafting: 'Create Box Mode' setting available in 'Create Box Settings'. Defines how the create box is used, 'None' doesn't show details (crafting through recipe box), 'Use' shows details and allows using the recipes, 'Info' only shows details (no crafting allowed) and 'HUD' only shows details (crafting through recipe box).
- new: Menu Screens: Research: 'Details Box Mode' setting available in 'Details Box Settings'. Defines how the details box is used, 'None' doesn't show details (research through research item box), 'Use' shows details and allows starting/stopping research, 'Info' only shows details (no research allowed) and 'HUD' only shows details (research through research item box).
- new: Menu Screens: Description: New text codes available to add content type information (e.g. item type of a selected item). Use '%ctn' for the content type name, '%ctd' for the content type description and '%cti' for the content type icon.
- new: Event System: Change Class: 'Unequip All' setting available. Unequipping all weapons/armors before a class change is now optional (but recommended). By default enabled.
- new: Event System: Initialize To Level: 'Formula' level and class level initialization available. Optionally use a formula to determine a combatant's level or class level.
- new: Event System: In Camera Transition: 'In Camera Transition' node available in 'Game Object > Camera' nodes. Checks if the camera control is currently in transition (between targets).
- new: Event System: Show Dialogue: 'Not Controlable' setting available for 'Message' type dialogues when not using 'Wait'. Optionally prevent the player from closing a dialogue when not using the 'Wait' option to continue the event while showing the dialogue. The dialogue has to be closed using a 'Close All Dialogues' node before the event ends.
- new: Music Player: 'From Current Time' setting available. Optionally play music from the currently playing music's time. This is used per music channel, i.e. you can only play music from the time of the same channel's current music.
- change: Scripting: Interaction Controller: The 'InteractionController' class has been adjusted to have all functions available for overrides.
- change: Battle Systems: Using 'End Immediately' without 'Death Immediately' will now wait for death events to finish.
- change: Menu Screens: Quest: 'Add Cancel Button' is now available without using the activation choice ('Info Box Settings'). You can now add just a back button without showing a choice to activate/inactivate a quest.
- change: Menu Screens: Information: Changing the menu user no longer resets the page of the information content.
- change: Save Games: Attack/Defence Attributes: Added safeguards to make sure loaded attack/defence attributes match the number of attributes and sub-attributes from the settings. This will make sure that loaded save games will remain compatible when adding or removing sub-attributes.
- fix: Shop Layouts: Fixed an issue where using 'Show Title' in the list box without showing a type box caused an error.
- fix: Event System: Add Console Line: Fixed an issue where actor text codes wheren't replaced correctly.
- fix: Battle End: Fixed an issue where the battle gains text only displayed one of the collected currencies.
- fix: UI: Game Options: The value of float and int options now use the correct font settings.
- fix: Event System: Exit Game: Fixed an issue where errors occured when using an 'Exit Game' node during battles.
- fix: Grid Battles: Ranges: Fixed an issue where 'Range' grid shapes in hexagonal grids calculated wrong distances when checking target use rangees.
- fix: Editor: Formulas: Fixed an issue where test calculating a formula in the editor results in an error when a combatant's start equipment uses equip events.
- fix: Main Menu, Menu Screens: Game Options: Fixed an issue where changing volumes as integers could result in decreasing volumes when opening the options menu.
- fix: Status Effects: Fixed an issue where auto applying an effect caused by status changes of another effect could lead to double status changes of that effect when using priorities.
- fix: Event System: Change Equipment: Fixed an issue where disabling 'From Inventory' and enabling 'Keep Unequipped' didn't store the unequipped equipment in the combatant's inventory.
- fix: Grid Battles: Fixed an issue where a combatant's conditional prefabs removes the cell-combatant connection upon changing the spawned prefab, halting the battle for that combatant.
- fix: Dialogues, Audio: Fixed an issue where dialogue audio clips could change the audio source settings (like pitch) of the main ORK audio player (e.g. for ok/cancel clips).
- fix: GUI Boxes: Choices: Fixed an issue where choice buttons where not shown in their proper normal state when opening a GUI box using the new UI.
- fix: Battles: Target Selection: Fixed an issue where a target wasn't selected when using 'Cursor Over' target selection with the cursor already over a target when starting the target selection.
- fix: HUDs: Combatant: Fixed an issue where individual combatant HUDs could be displayed at the wrong position for a frame when showing them again after being closed (e.g. due to game state conditions or cursor over).


Version 2.16.0:
- new: Unity 2018.1: ORK Framework now supports Unity 2018.1.
- new: Game Controls: Move To Interaction: 'Interaction Distance' setting available. Defines the distance the player must at least have to the destination position to start the interaction after moving toward it. Defaults to 0.1 world units.
- new: Status Effects, Battle Texts: 'Miss Status Effect Notification' settings available. Optionally show a text notification when failing to apply a status effect (e.g. due to hit chance or immunity).
- new: Status Effects, Console Settings: 'Miss Effect Text' settings available. Optionally show a console text when failing to apply a status effect (e.g. due to hit chance or immunity).
- new: Inventory Settings: Item Drop Settings: 'Use Drop Rotation' setting available. Optionally use the rotation of the combatant (or game object) that drops the item.
- new: Inventory Settings: Item Drop Settings: 'Save Updated Position' setting available. Optionally save the latest position/rotation of the item drop instead of the drop position/rotation.
- new: AI Rulesets: Target: 'Is Use Requirement' setting available in 'Target' rule types when using target requirements. Optionally use the target requirements as use requirements for 'Action' and 'Battle AI' rules in the same ruleset, i.e. actions will only be used if the 'Target' rule finds valid targets.
- new: Battle AI: Reassign Formation Position: 'Reassign Formation Position' node available in 'Grid Formation' nodes. Reassigns a combatant's formation position to a new combatant and assigns the combatant to a new position afterwards.
- new: Battle AI: Grid Rotate To Target: 'Block Diagonal Rotation' setting available. Optionally block rotating to a diagonal cell when using square grids and 'Diagonal Distance 1'.
- new: Battle AI: Grid Move: 'Same Cell Type' setting available for 'Consider Formation' settings. Optionally check if all formation position cells have the same cell type.
- new: Battle AI: Grid Move: 'Direct Move Only' setting available. Only moves if the target cell can be reached directly. By default disabled.
- new: Battle AI: Grid Move: 'Mark Target Cell' setting available. Mark the target cell to prevent other AI controlled combatants from moving on it. By default disabled.
- new: Battle AI: Grid Move: 'Distance To Enemy' settings available. Optionally block target cells that are within a defined distance to enemy combatants from being used.
- new: Battle Range Templates: Grid Shape: 'Minimum Distance' setting available for 'Range' shape types. Defines the minimum distance around the origin cell that will be used. Also available in all custom grid shapes.
- new: Grid Battles: Performance improvements for grid shapes, e.g. when getting the use range cells.
- new: Grid Settings: Orientation Selection: 'Block Diagonal Rotation' setting available. Optionally block rotating to a diagonal cell when using square grids and 'Diagonal Distance 1'.
- new: Grid Highlights: 'Hide Unused Prefabs' setting available. Optionally hide prefabs instead of disabling them (e.g. when replacing the cell prefab or stopping a grid highlight that uses prefabs). Hiding will disable all renderers and projectors on the spawned prefab and its child objects. This can lead to performance improvements for grid highlights using prefabs. By default enabled.
- new: Grid Highlights: 'Combatant Cells' settings available. Optionally highlight the cells of player group members, allies and enemies permanently. The cell highlights will be overruled by all other highlights (e.g. combatant selection).
- new: Grid Cell Types: 'Cell Type Costs' settings available. Optionally define different move/action costs for movement when coming from defined grid cell types, or block movement completely. Can be used to e.g. increase move costs when moving to higher cells (based on cell types).
- new: Menu Screens: Sub-Menus: 'Use Key' settings available in 'Assign Shortcut' sub-menu items. Optionally use an input key to assign a defined shortcut slot.
- new: Event System: Grid Rotate To Target: 'Block Diagonal Rotation' setting available. Optionally block rotating to a diagonal cell when using square grids and 'Diagonal Distance 1'.
- new: Event System: Grid Direction Rotation: 'Block Diagonal Rotation' setting available. Optionally block rotating to a diagonal cell when using square grids and 'Diagonal Distance 1'.
- change: Battle End: 'Split Experience Rewards' will now result in at least 1 experience point if the split result is 0 (coming from a non 0 value).
- change: Menu Screens: Group: The 'Content Layout' settings can now also show level and class level information of the combatants.
- change: Status Effects: Hidden status effects no longer show notifications or console texts.
- change: Music Players: 'Play', 'Fade In' and 'Fade To' using the already playing music clip will now change the playing clip's target volume instead of doing nothing.
- change: Battle AI: Grid Move: The 'Grid Cell Type' move type now defines the used distance in minimum and maximum distance.
- change: Battle AI: Grid Move: The 'Distance' range type of 'Avoid Enemies', 'Avoid Allies' and 'Target Cells' now defines the used distance in minimum and maximum distance.
- change: Battle AI: Grid Move: Combatants will now mark their target cell to make it unavailable for other AI controlled combatants for movement.
- change: Event System: Mecanim Animation: 'Use Play' has been replaced with 'Play Mode' selection, adding support for cross fading animations.
- change: Phase Battles: 'Auto Use Turns' setting has been replaced by the new 'Auto Start Turn' selection. Turns can now also automatically start at the start of a phase.
- fix: Abilities, Items: Status Value Changes: Fixed an issue where changing in percent could use the wrong status value for percent calculations.
- fix: Battle Events: No Time Consume: Not consuming the time/action points of an action will now correctly reduce the used action bar to allow new actions.
- fix: Battle Events: Calculate: The optional 'Next' slots could be triggered if calculation didn't have any target calculations, e.g. resulting in the 'Critical' slot being used although no critical hit occured.
- fix: GUI: Using 'Use Pointer Over' (new UI) or forcing cursor over is now also used by mouse/touch input.
- fix: Grid Formations: Fixed an issue where dead combatants where reassigned to their formation positions after freeing them on death.
- fix: Grid Formations: Fixed an issue where 'From Positions' also used combatants from formation positions with the same priority.
- fix: Grid Formations: Fixed an issue where status effect changes could cause an error when killing the last member of a formation.
- fix: Combatant Spawners: Fixed an issue where respawning could lead to spawning multiple combatant groups when more than 1 combatant died at the same time.
- fix: Item Drops: Fixed an issue where loading a save game could lead to dropping item drops twice.
- fix: Battle AI: Check Grid Distance: 'Check Formation' will now work for all checks.
- fix: Combatant Groups: Group Battle Gains: Fixed an issue where money wasn't added to the loot.
- fix: Battle AI: Grid Move: Fixed an issue where 'Consider Formation' didn't use the correct rotation when checking the formation positions.
- fix: HUDs: Quest: Fixed an error that prevented the quest HUD from being displayed.
- fix: Battles: Fixed an issue where groups didn't select a new battle leader after the current leader left the battle and was destroyed.


Version 2.15.1:
- new: Formulas: In Grid Formation: 'In Grid Formation' node available in 'Grid Formation' nodes. Checks if a combatant's group currently is in any or a defined grid formation, or checks if a combatant is part of a formation.
- new: Formulas: Is Grid Formation Leader: 'Is Grid Formation Leader' node available in 'Grid Formation' nodes. Checks if a combatant is the leader of a grid formation.
- new: Formulas: In Grid Formation Position: 'In Grid Formation Position' node available in 'Grid Formation' nodes. Checks if a combatant is on the assigned grid formation position cell.
- new: Formulas: Grid Formation Finished: 'Grid Formation Finished' node available in 'Grid Formation' nodes. Checks if a combatant group's grid formation is finished (i.e. all positions reached).
- new: Formulas: Grid Formation Possible: 'Grid Formation Possible' node available in 'Grid Formation' nodes. Checks if a combatant group's formation is possible or a defined grid formation is possible at a combatant's cell.
- new: Abilities: Hit Chance: 'For User Change' setting available when using a hit chance. Optionally only use the user changes when passing a hit chance test. If disabled, the user changes will always be used (current behaviour). By default disabled.
- new: Abilities, Items: Status Value Changes: 'Change In' setting available for all status value change settings (e.g. in target changes). Optionally change the status value in percent instead of the defined value (or formula result).
- new: Battle Texts: Remove Status Effect Notification: 'Show End With Battle' and 'Show End On Death' settings available. Showing remove notifications for status effects that end with the battle or the combatant's death are now optional. By default enabled (showing the notifications).
- new: Battle Range Templates: Grid Shape: 'Add Occupied Cells' setting available. Adding occupied cells (i.e. with a combatant on them) is now optional. Also available in all custom ranges and grid shapes. E.g. use this for an ability targeting a grid cell to only allow selecting empty cells.
- new: Menu Settings: New UI: 'Use Pointer Over' setting available when using the new UI. Optionally use the 'IsPointerOverGameObject' function from the UI 'EventSystem' in addition to ORK's GUI box checks when checking if the cursor is over a UI part. Use this to have custom UI game objects also be considered for the cursor over checks.
- new: Event System: Compare Status Value: 'Compare Status Value' node available in 'Combatant > Status' nodes. Checks the status value of combatants against each other. E.g. check if a combatant has less HP than another.
- new: Battle Events: No Use Costs: 'No Use Costs' node available in 'Battle > Action' nodes. Sets the action's use costs to already be consumed.
- new: Battle Events: Set Attacked By: 'Change Type' setting available. You can now also remove, set or clear the attacked by list of the combatant.
- new: Scripting: GUI Handler: 'ForceCursorOver' bool attribute available to optionally force the cursor over UI state.
- change: Battle AI, Event System: In Grid Formation Position: The formation leader is now always in formation position instead of resulting in a failed check.
- change: Status Effects: 'Set Every (s)' setting is now a float value selection, e.g. allowing formulas for time calculations.
- change: Status Previews: The critical chance of a previewed ability will be 0 if the hit chance has no chance of hitting.
- fix: Battles: Fixed an issue where killing or removing a combatant from battle in a grid cell event or turn start event (i.e. while starting a combatant's turn) still opened the combatant's battle menu.
- fix: Status Effects: Fixed an issue where removing a status effect due to duration could lead to effects being skipped when updating durations.
- fix: Shops: Buy/sell price modifiers are now updated when changing the shop's user.
- fix: Status Effects: Fixed an issue where 'Attack Allies' in some cases didn't work correctly, attacking the last targets instead of allies.


Version 2.15.0:
- new: Combatant Triggers: 'Combatant Trigger' component available. Combatant triggers detect combatants that walk into them and keep track of the time they're within the trigger. Add tags to check for different triggers. Can be used in the battle AI, move AI and the event system. E.g. use triggers on a combatant to react if an enemy is at the back for at least 3 seconds.
- new: Grid Formations: 'Grid Formations' feature available ('Battle System > Grid Formations') to bring AI controlled combatants into formation in grid battles. Define the formation in a grid mask. Each position can be assigned with a combatant based on status requirements and variable conditions.
- new: Game Settings: Unity Wrapper: 'Random Number Generation' settings available. Optionally replace standard Unity random number generation (Random.Range) with custom functions.
- new: Status Requirements: 'Check Equipment Part' settings available for 'Weapon', 'Armor', 'Weapon Item Type' and 'Armor Item Type' checks. Optionally check a defined equipment part for the equipment/type. Available in all status requirement checks, e.g. 'Check Status' nodes.
- new: Formulas: Is Player: 'Is Player' node available in 'Combatant' nodes. Checks if a combatant is the player combatant or a member of the active player group.
- new: Formulas: Check Grid Cell Type: 'Check Grid Cell Type' node available in 'Position' nodes. Checks if a combatant is on a defined grid cell type.
- new: Formulas: Check Height Differences: 'Check Height Differences' node available in 'Position' nodes. Checks if the target is above or below the user.
- new: Shop Layouts: 'Buy Without Items' setting available. Handles if the 'Buy' button is enabled or disabled when no items are available to be bought. By default disabled (disabling the button without items).
- new: Shop Layouts: 'Auto Close Buy' setting available. Optionally close the shop after buying the last item. By default enabled.
- new: Shops: 'Pause Notifications' setting available. Optionally pause displaying notifications while the shop is opened.
- new: Status Effects: 'Save Game' setting available. Saving an applied status effect with a combatant's status is now optional. By default enabled (saving the effect).
- new: Status Effects: 'End Stack On Duration' setting available for stacked status effects. Optionally end all stacked status effects when one effect's duration runs out.
- new: Status Effects: 'Recast On Stack' setting available for stacked status effects. Optionally reapply all stacked status effects when adding a new status effect to the stack or reapplying an existing stacked status effect.
- new: Inventory Settings: Item Collection: 'Before Collection', 'After Collection (Ok)' and 'After Collection (Cancel)' settings available. Optionally play an animation or audio clip on the player before or after collecting an item. This replaces the previous animation settings (updated to 'After Collection (Ok)').
- new: Inventory Settings: Item Box: 'Before Collection' and 'After Collection' settings available. Optionally play an animation or audio clip on the player before or after interacting with an item box. This replaces the previous animation settings (updated to 'Before Collection').
- new: Weapons, Armors: Random Bonuses: 'Add Count' setting available for 'Random' and 'First' add bonus ranges. Defines the number of bonuses that will be added/checked.
- new: GUI Boxes: Choice Settings: 'No Click Accept' setting available. Optionally disable accepting choices by clicking on them, i.e. only allow accepting via the 'Accept' input key.
- new: GUI Boxes: Choice Settings: 'Highlight Unfocused' setting available. Showing the selected choice skin is now optional for unfocused GUI boxes (only for legacy GUI).
- new: Menu Screens: 'Pause Notifications' setting available. Optionally pause displaying notifications while the menu screen is opened.
- new: Menu Screens: Research: 'Enable Tooltip' setting available in 'Research Item Box Settings'. Optionally show tooltips when hovering the cursor over a research item choice.
- new: HUDs: Tooltip: 'Research Item' setting available. Optionally show the 'Tooltip' HUD when hovering the cursor over a research item.
- new: HUDs: Tooltip: New text codes available for research item information in 'Tooltip' HUD elements. Also, displaying value bars supports showing the progress ('Level Points') and research count ('Durability') of a research item.
- new: HUDs: Combatant, Turn Order, Latest Turn: 'Check Value' settings available in 'Status Value' HUD elements. Optionally only display a status value if its value matches a defined check (e.g. > 100).
- new: HUDs: Combatant, Turn Order, Latest Turn: 'Keep List Position' setting available in 'Status Value' HUD elements. Optionally keep the list positions of not displayed status values, keeping an empty space between listed values.
- new: Turn Based, Active Time, Phase Battles: 'Cancel Closes' setting available when not using 'Auto Call Menu'. Optionally allow closing the called battle menu with the cancel key. By default disabled.
- new: Turn Based, Phase Battles: 'Group Leaders First' setting available. Optionally prioritize group leaders in turn orders. Not available for 'Multi Turns' turn based battles.
- new: Phase Battles: 'Auto Use Turns' setting available. Automatically progress turns of unused combatants (e.g. not selected by the player). This will use the turn events and grid cell events of the combatant and progress any status effects using turn duration/changes. If disabled, a combatant's turn doesn't progress. By default enabled.
- new: Battle Range Templates: 'Check Height Differences' settings available in 'Battle Range' and 'Grid Shape' settings. Optionally check if the target is above or below the user, including a minimum and optional maximum height difference check. Also available in all custom ranges and grid shapes. E.g. have an ability only allow targets that are below the user.
- new: Battle AI: Settings: 'Clear Found Targets' setting available in the 'Battle AI Settings' node. Optionally clear the found targets at the start of the battle AI to remove all targets found by previous battle AIs that executed before.
- new: Battle AI: 'Don't Add Targets' setting available in most check nodes. Optionally only perform a check without adding new combatants to the found targets.
- new: Battle AI: Grid Move: 'Grid Formation' move type available. Moves to the user's assigned grid formation cell. Only used when the user is part of a formation and not yet in position.
- new: Battle AI: Grid Move: 'Grid Cell Type' move type available. Moves to a cell of a defined grid cell type.
- new: Battle AI: Check Grid Cell Type: 'Check Grid Cell Type' node available in 'Position' nodes. Checks if a combatant is on a defined grid cell type.
- new: Battle AI: Use Grid Formation: 'Use Grid Formation' node available in 'Grid Formation' nodes. Initiates a defined grid formation for the user's group or the found targets.
- new: Battle AI: Break Grid Formation: 'Break Grid Formation' node available in 'Grid Formation' nodes. Ends the current or only a defined grid formation of the user's group.
- new: Battle AI: Update Grid Formation: 'Update Grid Formation' node available in 'Grid Formation' nodes. Updates the user group's grid formation (formation positions, filling empty positions).
- new: Battle AI: Use Grid Formation Rotations: 'Use Grid Formation Rotations' node available in 'Grid Formation' nodes. Uses the rotations on the grid formation positions (e.g. using leader's rotation). Changes the rotation of combatants that are on their formation position cells.
- new: Battle AI: In Grid Formation: 'In Grid Formation' node available in 'Grid Formation' nodes. Checks if the user's group currently is in any or a defined grid formation, or checks if a combatant is part of a formation.
- new: Battle AI: Is Grid Formation Leader: 'Is Grid Formation Leader' node available in 'Grid Formation' nodes. Checks if a combatant is the leader of a grid formation.
- new: Battle AI: In Grid Formation Position: 'In Grid Formation Position' node available in 'Grid Formation' nodes. Checks if a combatant is on the assigned grid formation position cell.
- new: Battle AI: Grid Formation Possible: 'Grid Formation Possible' node available in 'Grid Formation' nodes. Checks if a combatant group's formation is possible or a defined grid formation is possible at a combatant's cell.
- new: Battle AI: Has Combatant Trigger: 'Has Combatant Trigger' node available in 'Combatant' nodes. Checks if a combatant has combatant triggers.
- new: Battle AI: In Combatant Trigger: 'In Combatant Trigger' node available in 'Combatant' nodes. Checks if a combatant is within one of the user's combatant triggers (or the user in another combatant's trigger).
- new: Battle AI: Combatant Trigger Time: 'Combatant Trigger Time' node available in 'Combatant' nodes. Checks if a combatant is within one of the user's combatant triggers for a defined amount of time (or the user in another combatant's trigger).
- new: Battle AI: Get Weighted Group: 'Get Weighted Group' node available in 'Position' nodes. Uses combatants as targets based on their physical proximity to each other.
- new: Battle AI: Store Targets: 'Store Targets' node available in 'Target' nodes. Stores the currently found targets list using a 'target key'. Targets can be stored for the whole group or only the user (individual combatant). Stored targets can be loaded at a later time, e.g. to focus attacks on a group of combatants over multiple turns.
- new: Battle AI: Load Targets: 'Load Targets' node available in 'Target' nodes. Loads previously stored targets into the found targets list.
- new: Battle AI: Has Stored Targets: 'Has Stored Targets' node available in 'Target' nodes. Checks if stored targets of a defined 'target key' exist, optionally also checking for status requirements (e.g. not being dead). Can also remove combatants from the stored targets that don't match the requirements.
- new: Battle AI: Check Height Differences: 'Check Height Differences' node available in 'Position' nodes. Checks if a combatant is above or below the user.
- new: Grid Battles: Move Command: 'Use Only Once' setting can now be defind for player, ally and enemy combatants separately.
- new: Move AI: Enemy Detection: 'Combatant Trigger' detection type available. Optionally use combatant triggers on the user to detect enemies.
- new: Event System: Check Grid Cell Type: 'Check Grid Cell Type' node available in 'Battle > Grid' nodes. Checks if a cell matches a defined grid cell type.
- new: Event System: Use Grid Formation: 'Use Grid Formation' node available in 'Battle > Grid Formation' nodes. Initiates a defined grid formation for a combatant's group.
- new: Event System: Break Grid Formation: 'Break Grid Formation' node available in 'Battle > Grid Formation' nodes. Ends the current or only a defined grid formation of a combatant's group.
- new: Event System: Update Grid Formation: 'Update Grid Formation' node available in 'Battle > Grid Formation' nodes. Updates a combatant group's grid formation (formation positions, filling empty positions).
- new: Event System: Use Grid Formation Rotations: 'Use Grid Formation Rotations' node available in 'Battle > Grid Formation' nodes. Uses the rotations on the grid formation positions (e.g. using leader's rotation). Changes the rotation of combatants that are on their formation position cells.
- new: Event System: In Grid Formation: 'In Grid Formation' node available in 'Battle > Grid Formation' nodes. Checks if a combatant's group currently is in any or a defined grid formation, or checks if the combatant is part of a formation.
- new: Event System: Is Grid Formation Leader: 'Is Grid Formation Leader' node available in 'Battle > Grid Formation' nodes. Checks if a combatant is the leader of a grid formation.
- new: Event System: In Grid Formation Position: 'In Grid Formation Position' node available in 'Battle > Grid Formation' nodes. Checks if a combatant is on the assigned grid formation position cell.
- new: Event System: Grid Formation Possible: 'Grid Formation Possible' node available in 'Battle > Grid Formation' nodes. Checks if a combatant group's formation is possible or a defined grid formation is possible at a combatant's cell.
- new: Event System: Selected Data Count: 'Selected Data Count' node available in 'Event > Selected Data' nodes. Checks the count of data stored in a selected data list.
- new: Event System: Has Combatant Trigger: 'Has Combatant Trigger' node available in 'Combatant > Trigger' nodes. Checks if a game object has combatant triggers.
- new: Event System: In Combatant Trigger: 'In Combatant Trigger' node available in 'Combatant > Trigger' nodes. Checks if a combatant is within a combatant triggers.
- new: Event System: Combatant Trigger Time: 'Combatant Trigger Time' node available in 'Combatant > Trigger' nodes. Checks if a combatant is within a combatant triggers for a defined amount of time.
- new: Event System: Select Game Object, Select Equipment, Select Item: 'Filter' settings available. Optionally use only game objects, equipment or items that match defined object/equipment/item variable conditions.
- new: Event System: Change Music: 'Target Volume' setting available. Define the volume a music clip should be played at. This doesn't change the overall music volume or the channel's volume, only at which volume the music clip itself is played at.
- new: Event System: Check Height Differences: 'Check Height Differences' node available in 'Movement > Movement' nodes. Checks if a game object is above or below another game object.
- new: Music Players: 'Target Volume' setting available. Define the volume a music clip should be played at. This doesn't change the overall music volume or the channel's volume, only at which volume the music clip itself is played at.
- new: Combatant Spawners: 'Destroy Spawned' setting available. Optionally destroy all spawned combatants of the spawner when the spawner is destroyed.
- change: Menu Screens: Group, Group Combatant: The 'Group Combatant' menu part is now also updated when changing focus between battle and non-battle group boxes.
- change: Menu Screens: Group, Group Combatant: The 'Group Combatant' menu part is now also updated when changing focus between battle and non-battle group boxes.
- change: Event System: Join Battle, Leave Battle: The 'Join Battle' and 'Leave Battle' nodes are now also available in game events.
- change: Event System: Activate Object, Add Component, Remove Component, Enable Component: These nodes will now be executed when an event is stopped (e.g. battle event ending due to the user being dead).
- change: Event System: Show Dialogue: The 'Queued Notification' type has been changed to the general 'Notification' type. You can queue the notification using the new 'Queue Notification' setting. Old settings are updated automatically.
- change: Battle AI: Found targets are now shared between battle AI calls of a combatant.
- change: Battle AI: Grid Move: 'Block Diagonal Distance 1', 'In Move Range', 'Avoid Enemies' and 'Avoid Allies' settings are now available for all move types.
- change: Battle AI: 'Clear Found Targets', 'Check Target Count', 'Use Last Targets' and 'Use Attacked By' nodes have been moved to the 'Target' nodes.
- change: Grid Battles: Move Command: If an AI controlled combatant uses a grid move toward a target, the target is available as 'Target' actor in the grid move's battle events.
- change: Scene Changers: The player is only spawned when the target scene is in the list of loaded scenes.
- change: Formulas: Random Value: Changed how the 'As Int' setting generates a random integer number. 'Value 2' setting is now used exclusive.
- change: HUDs: Drag and drop no longer calls click actions on HUD elements.
- change: New UI: If an 'Event System' component is already present, ORK will no longer create its own.
- change: Move AI, Damage Dealers, Damage Zones: Changed initialization of these components to make them compatible with custom pooling solutions.
- change: Items, Weapons, Armors: 'Buy Price' and 'Sell Price' settings are now float value selections, e.g. allowing formulas for price calculations. The item is available as selected data with the 'action' key.
- change: Combatants, Abilities: 'Buy Price' setting is now a float value selection, e.g. allowing formulas for price calculations. The combatant/ability is available as selected data with the 'action' key.
- change: NavMesh Agents: Addes safeguards to only call NavMesh functionality on agents when they're on a NavMesh to prevent error messages.
- change: Editor: The editor will now check data consistancy of data array when loading a project, e.g. adding missing languages. This is only done in the editor, not when playing the game. Save the project in the ORK editor to save the updated settings.
- change: Shortcut Slots: Assigning an item or equipment shortcut will now try to keep the same shortcut instance for the assigned shortcut. If the shortcut instance can't be found in the inventory, it'll use a matching item/equipment.
- fix: Save Games: Inventory: Fixed an issue where weapons and armors where not loaded if their ID exceeded the number of items addedin the ORK editor.
- fix: Save Games: Shops: Fixed an issue when loading the content of a shop that sells combatants.
- fix: Menu Settings: Drag and Drop: Fixed an issue where using a cancel drag key could intercept canceling out of a menu screen.
- fix: Battle System: Fixed an issue where using the 'None' action in silent mode or without consuming the remaining action points (turn based, phase battles) could lead to the combatant's turn not ending, potentially stalling the battle.
- fix: Battle Events: Fixed an issue where using the 'All Enemies' actor didn't include the player group (when they are an enemy of the user).
- fix: Research Trees: Fixed an issue where researching items or status values could lead to errors or double items when using research durations.
- fix: Editor: Fixed an issue where name fields lost focus when typing in them. This is a workaround for a bug on Unity's side since Unity 2017.2.
- fix: Editor: Fixed an issue where adding a new language didn't add it to all language fields, e.g. in the quest settings.
- fix: Battle Menu: New UI: Fixed an issue where updating the target list lead to the selected choice button losing the highlighted state.
- fix: Shops: Fixed an issue where a paused shop's quantity selection wasn't useable.


Version 2.14.4:
- fix: Combatants, Components: Fixed an issue related to spawning a combatant's game object that leads to some components on the combatant not working properly (e.g. damage zones, mouse player controls, etc.).


Version 2.14.3:
- new: Game Settings: Unity Wrapper: 'Unity Wrapper' settings available. Optionally replace standard Unity functionality with custom function calls. Currently supports instantiating game objects, destroying game objects and loading scenes.
- new: Formulas: Status Value, Random Status Value: 'Whole Group' settings available. Optionally use the status value from the members of the combatant's group instead of only the combatant. The values of the individual combatants can be used in different ways, e.g. using the average value or adding them all together.
- new: Status Values, HUDs: Value Bars: 'Images Per Icon' setting available when displaying a value bar as icons. Optionally use the defined images per icon, i.e. the 'Percent' setting is used based on the icon value of each individual icon.
- new: Combatants: Game Event Settings: Set up game events that are automatically started upon certain conditions, e.g. when first initializing the combatant.
- new: Combatants: '%n' text code available in the combatant's description. Displays the combatant's current name (e.g. after changing it using a 'Set Combatant Name' node.
- new: Battle Settings: Target Information Dialogue: You can now add multiple target information dialogues.
- new: Battle End: 'Use Level Up Box' settings available. Optionally use a different GUI box for displaying level up texts.
- new: Battle AI: Grid Move: 'Avoid Enemies' and 'Avoid Allies' settings available. Optionally block cells around enemy or ally combatants when searching for a path to the target. The cells can be defined as distance, battle range template or a custom grid shape.
- new: Battle AI: Grid Move: 'Target Cells' settings available. Define which cells around a target combatant are available as move target cell. The cells can be defined as distance, battle range template or custom grid shape. This replaces the previous 'Stop Distance' setting.
- new: Battle AI: Grid Move: 'In Move Range' setting available. Optionally limit movement to targets within move range.
- new: Battle AI: Get Status Value, Get Attack Attribute, Get Defence Attribute: 'Get All Matching' setting available. Optionally use all combatants that match the highest/lowest found value. Otherwise only the first combatant is used.
- new: Battle Range Templates: Grid Shape: 'Block Diagonal Distance 1' setting available for 'Range' and 'Ring' shape types. Optionally use a diagonal distance of 2 in square grids using 'Diagonal Distance 1'.
- new: Grid Battles: Move Command: 'Mark Target Cell' setting available. Marking the selected target cell for the move command user is now optional. A marked cell isn't available for other combatants to move on. By default enabled.
- new: Grid Battles: Examine Grid: 'Only Player Phase' setting available when using 'Always Active' examine. Optionally only use always active grid examination during the player's phase in 'Phase' battles.
- new: Grid Battles: Examine Grid: 'Use User' setting available in the 'Combatant Info Box' settings. Optionally use the user of the grid examination when showing a combatant info box instead of the combatant of a selected cell.
- new: Grid Battles: Examine Grid: 'Hide For User' setting available in the 'Combatant Info Box' settings. Optionally hide the combatant info box when examining the user of the grid examination.
- new: Grid Battles: Examine Grid: 'Toggle Key' settings available in 'Cell Info Text' settings. Optionally use an input key to toggle cell info boxes on and off.
- new: Grid Cell Types: 'Editor Prefab' setting available. Optionally use a different prefab when displaying a grid cell type in the editor (not while playing).
- new: Grid Cell Types, Battle Grid Components: Deployment: 'Deploy Requirements' settings available in grid cell types and individual battle grid cells (in the scene). Optionally use status requirements and variable conditions to determine if a combatant can be deployed on a grid cell.
- new: HUDs: Combatant, Turn Order, Latest Turn: New text codes available in 'Action Time', 'Cast Time', 'Delay Time', 'Grid Move Range', 'Inventory Limit', 'Timebar' and 'Status Value' HUD element types. Use '%p' to display the current value in percent. The format can be defined in the new 'Percent Format' setting (e.g. '0.0' for a number with 1 decimal).
- new: Menu Screens, Shop Layouts: Combatant: 'Show Choice Icon' setting available in the 'Combatant' menu part and 'User Info Box' in shop layouts. Optionally show the choice icon on the button of the current menu/shop user.
- new: Event System: Select Combatant: 'Requirements' settings available. Optionally use status requirements and variable conditions to determine if a combatant will be selected (e.g. only select dead combatants).
- new: Battle Events: Stop Battle Actions: 'Stop All' setting available. Stopping all performing actions is now optional, i.e. you can define which combatant will stop performing an action.
- change: Menu Screens: Open/Close Game Events: The menu user is now used as the 'Starting Object'. If the menu user isn't set, the leader of the player group (usually the player) will be used.
- change: Control Maps: Action: Items or abilities with a 'None' target range will no longer be blocked when using 'No Target Selection' in a control key.
- change: Battle End: Hidden abilities will no longer be displayed in battle end and level up texts when being learned.
- change: Battle End: Hidden status values will no longer be displayed in battle end and level up texts.
- change: Battle End: Hidden items will no longer be displayed in battle end texts.
- change: Controls: Resetting controls (e.g. when returning to the main menu scene) will now also forward control block changes to event listeners (e.g. the ORK-Makinom Connection plugin).
- change: Battle AI: Grid Move: The 'Stop Distance' setting has been replaced by the 'Target Cells' settings. A stop distance greather than 1 is now handled by a 'Ring' grid shape with the same range. Previous settings will be updated accordingly.
- change: Grid Battles: Examine Grid: 'Always Active' grid examination is no longer active during phase change events in 'Phase' battles.
- change: Grid Battles: Improved performance during cell selections, especially in larger grids.
- change: Real Time Battles: AI controlled combatants will no longer progress their turns when out of AI range.
- change: Battle Grid: Painting on a battle grid is now blocked while holding down 'ALT' or 'Shift'.
- change: Menus: Combatant: HUD elements in 'Combatant' menu parts can now receive drag and drop (e.g. to assign shortcuts in a 'Shortcut' element).
- change: New UI: Buttons: Accepting/canceling a choice or dialogue will now fire the 'OnClick' event of the used prefab's 'Button' component on the selected choice or the ok/cancel buttons. This only happens when accepting/canceling via input keys, not via click/touch (as that already fires 'OnClick').
- fix: GUI Boxes: Ok/Cancel Buttons: Fixed an issue where using a custom skin for the ok/cancel buttons wasn't used when using the legacy GUI.
- fix: GUI Boxes: Fixed an issue that could lead to the name box having the wrong size when using the new UI and the same prefab for content box and name box.
- fix: Editor: Fixed an issue where only the default ORK project could be loaded.
- fix: Event System: Equipment Fork: Fixed an issue that caused errors when displaying the settings of an 'Equipment Fork' node in the editor.
- fix: Save Games: Logs: Fixed an issue while loading logs.
- fix: Save Games: Equipment: Fixed an issue where equipment blocking other equipment viewers where shown after loading the game.
- fix: Battle AI: Grid Move: Fixed an issue where the 'Stop Distance' ignored the 'Block Diagonal Distance 1' setting.
- fix: Camera Controls: Having one of the built-in camera control components manually attached to a scene's camera didn't register them with ORK's control blocks.
- fix: Shop Layouts: List Box: Fixed an issue where 'Auto Select Item' wasn't used when 'Auto Select Type' wasn't enabled.
- fix: Menu Screens, Battle Menus: Dragging: Fixed a general issue with dragging (without enabling click-drag) that could result in a drag not stopping when releasing the mouse button.
- fix: Collision Camera: Fixed an issue where the collision camera resets to a wrong position after a camera change.
- fix: Defence Attributes, Combatants: Fixed an issue where removing a defence attribute could lead to not removing a defence attribute selection in the combatant's settings.
- fix: HUDs: Combatant, Turn Order, Latest Turn: Fixed an issue where toggling the HUD off and on resulted in the HUD no longer being udpated.
- fix: Phase Battles: Fixed an issue where ending the phase after selecting a combatant without choosing an action could result in the combatant not being able to perform actions in future phases.
- fix: Global Events: Fixed an issue where global events ignored the 'Blocking Event' setting of the used game event.
- fix: Abilities, Items: Target Requirements: Fixed an issue where object variable requirements of a combatant didn't work when the object variables where added as an 'Object Variables' component instead of set up in the combatant's settings.
- fix: Save Games: Dead player group members are now spawned when loading the game.
- fix: Main Menu: Fixed an issue where the main menu isn't automatically called when using 'Additive' scene loading.
- fix: Status Values: Normal: Fixed an issue where using the 'Combined Value' setting for the maximum status value of a 'Consumable' type status value (e.g. 'Max HP') would lead to instant death of a combatant.


Version 2.14.2:
- new: Global Volume: The global volume is used to scale both the music and sound volumes.
- new: Plugins: Plugins can now also be provided as scripts instead of DLLs.
- new: Player Controls: Mouse: 'Sample Distance' and 'Area Mask' settings available when using 'NavMesh Agent' move type. Handles finding the nearest point on the NavMesh to the clicked position.
- new: Control Maps: 'While Auto Attacking' setting available. Optionally allow using a control map while a combatant is using an auto attack.
- new: Control Maps: Action: 'No Target Selection' setting available. Optionally block a control map key from bringing up any target selection in case auto targeting or cursor targeting fails.
- new: Game Settings: 'Global Volume' start volume setting available. Defines the global volume when initializing Makinom.
- new: Formulas: Action Time: 'Action Time' node available in 'Combatant' nodes. Uses the action time of a combatant in the formula calculation.
- new: Formulas: Check Action Time: 'Check Action Time' node available in 'Combatant' nodes. Checks the action time of a combatant.
- new: Shop Layouts: 'Close Shop Input Key' settings available. Optionally use an input key to directly close the shop.
- new: Shop Layouts: Type Box: 'Auto Select Type' setting available when adding a back button. Optionally automatically select a type choice when the back button is selected when opening the type box.
- new: Shop Layouts: List Box: 'Auto Select Item' setting available when adding a back button. Optionally automatically select an item choice when the back button is selected when opening the list box.
- new: Shops: 'Pause Settings' available. A shop can optionally pause the game or change the time scale while being opened.
- new: Weapons, Armors: 'Equip Game Event' and 'Unequip Game Event' settings available. Optionally perform a game event when equipping or unequipping a weapon or armor. Uses the combatant that equips/unequips the equipment as 'Starting Object' and the equipment as selected data with the key 'action'.
- new: Weapons, Armors: 'Prefab View Prefab' settings available. Optionally use a different prefab when showing a weapon or armor in a prefab view portrait. You can define different prefabs for showing the equipment itself, or showing it as part of a combatant (using an 'Equipment Viewer').
- new: Weapons, Armors: Durability: 'Auto Init' setting available in the 'Durability Settings'. Optionally automatically initialize the durability when an instance of the equipment is initialized (e.g. added to an inventory). Otherwise, the durability is only initialized when it's equipped by a combatant.
- new: Weapons, Armors: 'Random Attack Attribute Bonuses' settings available. Optionally add random bonuses to attack attributes.
- new: Weapons, Armors: 'Random Defence Attribute Bonuses' settings available. Optionally add random bonuses to defence attributes.
- new: Battle Menus, Menu Screens: 'Set ORK Scale' setting available. Optionally set the ORK time scale instead of the Unity time scale when changing the time scale.
- new: Battle AI: Status Value Sort Targets: 'Status Value Sort Targets' node available in 'Combatant' nodes. Sorts the found targets based on a defined status value.
- new: Battle AI: Grid Move: 'Block Diagonal Distance 1' setting available in 'Grid Move' nodes. Optionally block diagonal cells around the target, forcing movement to a non-diagonal cell (if available).
- new: Phase Battles: Player Combatant Selection: 'Keep Open' setting available. Optionally keep the player selection dialogue open after selecting a combatant.
- new: Battle Range Templates: Range Settings: 'Raycast Line of Sight' settings available. Optionally use a raycast to check if any object is blocking the sight between user and target.
- new: Grid Highlights: Marked Cell: 'Marked Cell' grid highlight settings available. Optionally highlight cells that are marked for a combatant, e.g. being the target of a grid move command.
- new: Menu Settings: Drag/Drop Settings: 'Drag Set Selection' setting available. Dragging a choice button can optionally select it.
- new: Menu Settings: Drag/Drop Settings: 'Drop Set Selection' setting available. Dropping a drag on a choice button can optionally select it.
- new: Main Menu, Menu Screens: 'Global Volume' game option type available. Changes the global volume.
- new: Save Game Menu: 'Global Volume' store game option setting available. Optionally stores the global volume outside of save games in the PlayerPrefs.
- new: GUI Boxes: Open/Close Box Behaviour: 'Audio Clip' settings available. Optionally play an audio clip when opening or closing a GUI box.
- new: Menu Screens: 'All Closed Reset' setting available when using 'Remember Selection'. Optionally resets the selection when all opened menu screens are closed.
- new: Menu Screens: 'Battle Group User' setting available. Optionally use a battle group member as the menu screen's user when opening it. This is usually the default case, but can be needed to enforce when using a hidden, non-battle group member as the player.
- new: Menu Screens: Group: 'Drag and Drop' settings available. Optionally change the battle group using drag and drop.
- new: Menu Screens: Group Combatant: 'Group Combatant' menu part available. Special 'Combatant' menu part to show the currently selected battle group or non-battle group member of a 'Group' menu part.
- new: HUDs: Combatants, Turn Order, Latest Turn: 'Hit Chance' HUD element type available. Displays a text or value bar for the hit chance of a previewed ability on the combatant. Only available when the combatant has a preview of an ability targeting it available.
- new: HUDs: Combatants, Turn Order, Latest Turn: 'Critical Chance' HUD element type available. Displays a text or value bar for the critical chance of a previewed ability on the combatant. Only available when the combatant has a preview of an ability targeting it available.
- new: Event System: Close Shop: 'Close Shop' node available in 'Game > Shop' nodes. Closes a defined shop or all open shops.
- new: Event System: Remove AI Behaviour: 'Remove All' and 'Remove All Quantity' settings available. Optionally remove all AI behaviours or all available behaviours of the defined AI behaviour from the inventory.
- new: Event System: Remove AI Ruleset: 'Remove All' and 'Remove All Quantity' settings available. Optionally remove all AI rulesets or all available rulesets of the defined AI ruleset from the inventory.
- new: Event System: Change Global Volume: 'Change Global Volume' node available in 'Audio + Animation > Audio' nodes. Sets or fades the global volume. 
- new: Event System: Close Item Collection: 'Close Item Collection' node available in 'UI > Dialogue' nodes. Closes the item collection or item box dialogue (if opened).
- new: Event System: Check Equipment, Equipment Fork: 'Check Blocking Part' setting available. Optionally check the equipment part that's blocking the selected equipment part.
- new: Damage Dealers: 'Custom' type available. Optionally use custom solutions when using damage dealers. Call the new 'CustomDamage' function of an activated 'DamageDealer' component to do damage.
- new: Interaction Components: Move To Interaction: 'Override Speed' settings available. Optionally override the speed used to move to the interaction for each individual interaction.
- change: Save Games: Variable keys with spaces (e.g. 'variable key') are now supported by save games.
- change: Event System: End Phase, End Battle: 'End Phase' and 'End Battle' nodes are now available in all event types.
- change: Item Collectors: 'Block Control' now also blocks control maps.
- change: Move To Interaction: Moving to an interaction will now remove the cursor of the 'Mouse' player controls.
- change: Editor: Menu Screens: Menu screen parts can now be copied.
- change: Menu Screens: The 'Close Key' will now be checked before the 'Call Key' in an opened menu screen. This will prioritize closing the menu screen when using the same input key for both.
- change: Text Notifications: You can now define multiple positions (with random offsets) to use randomly or iterate through. This is available for all text notifications (e.g. status value damage/refresh notifications).
- fix: Phase Battles: Player Combatant Selection: Fixed an issue where player combatant's couldn't be changed with click or input keys after the first action has been performed in a multi-action setup (when the same combatant is auto-selected again).
- fix: HUDs: Latest Turn: Fixed an issue where toggling a 'Latest Turn' type HUD on and off (e.g. using a toggle key or variable conditions) would result in the HUD being empty.
- fix: GUI Boxes: Choice Icon: Fixed an issue where the choice selection icon was placed at the wrong position when tabs where displayed at the top.
- fix: GUI Boxes: New UI: Fixed an issue that could lead to flickers when showing 2 dialogues in sequence without a pause when using the new UI.
- fix: Combatants: Prefab View Portraits: Fixed an issue where combatants without conditional prefabs didn't display equipment in prefab view portraits.
- fix: Shops: Fixed an issue where the 'Sell' button could be inactive when not having certain items in the inventory.
- fix: Shops: Items with a buy price of 0 will no longer cost 1 currency.
- fix: HUDs: Portraits: Fixed an issue where portrait HUD elements didn't use a provided alpha mask material.
- fix: Event System: Rotation Nodes: Fixed issues when rotating a game object on the X-axis at 90 and -270 degrees.
- fix: Event System: Check Equipment, Equipment Fork: Fixed an issue where checking a 'Multi' equip type equipment wasn't recognized as equipped on all equipment parts it is equipped on.
- fix: Formulas: Store Formula Value: Fixed an issue where the operator was ignored and always used 'Set'.
- fix: Abilities, Items: User/Target Changes: Fixed an issue where disabling the 'Use Attribute Changes' setting could lead to errors when calculating the changes.
- fix: Battle Events: Cancel Death: Fixed an issue where the battle ended even tough a 'Cancel Death' node prevented a combatant's death.
- fix: Item Collectors: Box: Fixed an issue when using loot tables in an item box in the first scene of the game (i.e. where the player isn't yet set when loading the scene).
- fix: Weapons, Armors, Items: Variables: Fixed an issue where creating a copy of a shortcut (e.g. when equipping a weapon) didn't copy the variables when 'Save Variables' wasn't enabled in the equipment's or item's variable settings.
- fix: Menu Screens: Status Value Upgrade: Fixed an issue where a combatant without status development would cause an error.
- fix: Active Time Battles: Fixed an issue when a combatant is killed while choosing an action when using 'Pause On Choosing'.


Version 2.14.1:
- new: Control Maps: 'Only In Range' setting available when using 'Only Cursor Over Target' setting. Optionally only allow using the control map key when the cursor is over a valid target in use range of the action.
- new: Status Values, HUDs: Value Bars: 'From Zero' setting available when using icons to display value bars. Optionally start the icon display from 0 instead of the minimum value. E.g. a current value of 4 would display 4 icons from zero, but 3 from a minimum value of 1.
- new: Formula: Check Grid Distance: 'Block Diagonal Distance 1' setting available in 'Check Grid Distance' nodes. Optionally block diagonal distance of 1 for square grids in the distance checks.
- new: Combatants: Portraits: 'Ignore Viewer Conditions' setting available in portraits using prefab view. Optionally ignore the display conditions of equipment viewers on the portrait prefab.
- new: Battle AI: Check Grid Distance, Get Nearest, Distance Sort Targets: 'Block Diagonal Distance 1' setting available in 'Check Grid Distance', 'Get Nearest' and 'Distance Sort Targets' nodes. Optionally block diagonal distance of 1 for square grids in the distance checks.
- new: Grid Battles: Examine: 'Show For Cells' settings available in 'Cell Info Box' settings. Define if the info box will be displayed for empty cells, occupied cells, marked cells (e.g. target of a grid move) or cells with guest combatants.
- new: Grid Highlights, Grid Cell Types: Prefabs: 'Auto Add Blinker' setting available. Optionally add and initialize the blinker component used by grid highlights to blink the cell's prefab when the prefab is instantiated.
- new: Menu Settings, GUI Boxes: GUI Skins: 'Limit To Scrollbar' setting available when using the new UI. Optionally disable scrolling by dragging and mouse wheel.
- new: Event System: Check Grid Distance: 'Block Diagonal Distance 1' setting available in 'Check Grid Distance' nodes. Optionally block diagonal distance of 1 for square grids in the distance checks.
- new: Event System: Remove Component, Enable Component: 'All Components' setting available. Optionally use all components on the game object and all of its child objects.
- change: HUDs: Anchoring HUD elements to the previous element will now ignore empty HUD elements (unless using empty elements is enabled for the HUD).
- change: Grid Battles: Performance improvements for player and AI grid move range/path calculations and blinking grid highlights.
- fix: Event System: Move AI Start Position: Fixed an issue where the editor freezes and throws errors when disabling 'Use Current Position'.
- fix: Status Values: Fixed an issue where 'Consumable' type status values using 'Real Value Count' that can cause the death of a combatant could kill the combatant again upon revive due to the counting value still being at the minimum/maximum that caused the death.
- fix: Phase Battles: Player Combatant Selection: Fixed an issue where player combatant's couldn't be changed with click or input keys after the first action has been performed.
- fix: Phase Battles: Player Combatant Selection: Fixed an issue where clicking on non-player group combatants while having a combatant selected would close the battle menu and open the combatant selection.
- fix: Phase Battles: Fixed an issue where ending the phase with combatants still being available would lead to the combatant selection coming up again after the selected actions have been performed when not using active command.
- fix: Phase Battles: Fixed an issue where combatants not having performed actions didn't receive any actions per turn or action time in the next round.
- fix: Status Effects: Fixed an issue where blocking specific ability types, abilities, item types or items didn't work.
- fix: Formulas: Equipment Durability: Fixed an issue where an equipment with durability of 0 had a maximum durability of 0 as well.
- fix: GUI Box: Name Box: Fixed an issue where the name box could remain in the scene after closing the GUI box when using the new UI.


Version 2.14.0:
- new: Action Combos: 'Action Combos' sub-section available in 'Battle System > Action Combos'. Action combos define a sequence of battle actions (e.g. base attack, abilities or items), where each stage of the combo can optionally replace the used action with another. E.g. using ability A 3 times in a row will replace the 3rd use with ability B, i.e. A > A > A will become A > A > B.
- new: Control Maps, AI Rulesets, Status Effects: 'Ability Level' settings available when using an ability action. Optionally define the level of the ability that should be used. By default uses the highest available level.
- new: Animations: 'Random First Start Time' setting available. Optionally starts the first played animation at a random time. Only used by 'Legacy' and 'Mecanim' animations.
- new: Editor Settings: 'Language Selection' settings available. Handles how settings for different languages are displayed and selected in the editor. Either 'List' all settings, select the language with a 'Popup' or 'Buttons' and only show the selected language's settings.
- new: Game Settings: 'Initial Music Channels' setting available. Defines the number of music channels that will be initialized at the start of the game.
- new: Formulas: Equipment Durability: 'Equipment Durability' node available in 'Combatant' nodes. Uses the durability or maximum durability of equipment stored in selected data to change the value of the formula.
- new: Console Settings: 'Combatant Consoles' settings available. Optionally have separate consoles per combatant. Enabling this will automatically add console texts that concern a combatant to their console, e.g. an action text if the combatant is the user or target of the action.
- new: Console Settings: Action Texts: 'Add Action Text' settings available. Optionally add console texts for actions when they're selected by a combatant.
- new: Console Settings: Action Texts: 'User Per Combatant' setting available for ability/item action texts. Optionally display a console line for each user-target combination.
- new: Console Settings: Action Texts: New text code available for ability/item action texts. Use '%tsv' to display the status value changes of an individual combatant. Only available when the action text is displayed per combatant.
- new: Console Settings: Action Texts: 'Status Value Changes' settings available. Defines how status value changes of targets will be displayed when using the '%tsv' text code.
- new: Status Effects: 'Force AI Controlled' setting available. Optionally force a combatant to be AI controlled while the status effect is applied.
- new: Status Effects: 'Use Attribute Changes' settings available in 'Status Conditions' settings. Optionally use attack/defence attributes to influence the change value of the status condition. E.g. use this to give a poison effect's damage a poison attack attribute.
- new: Inventory Settings: Quantity Texts: 'Quantity Texts' settings available. Defines how the quantity in info texts will be displayed. You can define different texts for quantities of 1 and larger than 1 (e.g. to not display quantities of 1). Optionally use different texts for items, equipment, currencies and others.
- new: Battle Settings: Default Events: 'Turn Start Events' settings available. Combatants can perform game events at the start of their turn (after the grid cell events).
- new: Battle Settings: Default Events: 'Turn End Events' settings available. Combatants can perform game events at the end of their turn (before the grid cell events).
- new: Battle Settings: Default Action Combos: 'Default Action Combos' settings available. Defines the default action combos that are added to each combatant. Combatants can optionally override or add action combos.
- new: Battle Settings: Target Selection: Mouse/Touch Control: 'Accept Only Selected' setting available. Optionally only allow accepting a target through click/touch on the combatant when the combatant is already selected.
- new: Battle Systems: AI Decision Time: 'AI Decision Time' settings available in all battle system types. Defines the time an AI controlled combatant needs to decide an action.
- new: Turn Based Battles, Active Time Battles, Phase Battles: Action Time: 'Action Time' settings available in 'Turn Based', 'Active Time' and 'Phase' battle system types. Optionally limit the time a combatant can select actions to a defined amount of time.
- new: Turn Based Battles: Multi Turns: 'Invert Turn Order' setting is now also available for 'Multi Turns' type turn based battles. The combatant's turn value will be increased after the combatant's turn. The other combatants turn values will not be increased, the combatant with the lowest turn value will have the next turn.
- new: Phase Battles: Player Combatant Selection: 'Allow Clicking' settings available. Clicking on combatants to select them for the player's combatant selection is now optional. You can also allow selecting a different combatant by clicking while a combatant is already selected. Clicking is allowed by default.
- new: Phase Battles: Player Combatant Selection: 'Show Selection Box' setting available. Showing a combatant selection GUI box to select the combatants is now optional. By default enabled.
- new: Phase Battles: Player Combatant Selection: 'Auto Select' setting available when now showing a selection box. Automatically selects the first combatant in the list to always have a combatant selected during the phase. You can change combatants by enabling click selection or using input keys.
- new: Phase Battles: Player Combatant Selection: 'Input Key Settings' available. Optionally use input keys to cycle through available combatants or end the player phase.
- new: Active Time Battles: 'Pause On Choosing' setting available for active time battles. Pauses timebar progression while any combatant chooses an action (e.g. AI decision timeout, turn start events, etc.).
- new: Battle Systems: Control Block Settings: 'Allow In Turn' setting available in all battle system types when using blocking player/camera controls for the whole battle. Optionally allow using player or camera control during the turn of a player controlled combatant.
- new: Battle Systems: Control Block Settings: 'Transfer Player Control' setting available in all battle system types. Optionally transfer the player control to non-AI controlled player group members during their turn.
- new: Battle Systems: Move AI: 'Allow In Turn' setting available in all battle system types when blocking the move AI for combatants in battle. Optionally allow combatants to use the move AI while performing their turn.
- new: Battle Menus: 'Time Scale' settings available. Optionally change the time scale while the battle menu is opened. Set time scale to 0 to completely freeze everything while the battle menu is opened. This replaces the 'Freeze Action' and 'Time Scale' settings in real time battles.
- new: Grid Battles: 'Diagonal Distance 1' setting available when using 'Square' type grids. Optionally set the distance for diagonal cells in 'Square' type grids to 1 instead of 2. This will affect battle ranges.
- new: Grid Battles: Move Command: 'Diagonal Move' settings available when using 'Square' type grids. Optionally allow diagonal movement in 'Square' type grids.
- new: Grid Battles: Examine: You can now add multiple 'Cell Info Text' boxes. Display different information about the selected cell in multiple GUI boxes.
- new: Grid Battles: Examine: You can now add multiple 'Combatant Info' boxes. Display different information about the selected cell's combatant in multiple GUI boxes.
- new: Grid Battles: Examine: New text codes available for 'Info Text' and 'Cell Info Text' boxes. Display the name, description and icon of a combatant occupying the selected cell.
- new: Grid Highlights: Move Command: 'Move Range (Blocked)' and 'Move Range (Passable)' settings grid highlights available. Optionally highlight blocked and passable (blocked) cells in move range.
- new: Grid Cell Types: 'Block Diagonal Move' setting available in 'Blocked' grid cell types for 'Square' type grids. Optionally block diagonal movement in 'Square' type grids when the cell is a neighbour of both cells of the diagonal move, i.e. forces the mover to move around it (going 2 cells instead of 1 diagonal).
- new: Grid Cell Types: 'Object Variables' settings available. Optionally add an 'Object Variables' component to cells of a grid cell type and initialize them with defined values.
- new: Combatants: Turn Start Events: 'Turn Start Events' settings available. Combatants can optionally override the default turn start events.
- new: Combatants: Turn End Events: 'Turn End Events' settings available. Combatants can optionally override the default turn end events.
- new: Combatants: AI Decision Time: 'AI Decision Time' settings available. Combatants can optionally override the default AI decision time.
- new: Combatants: Action Time: 'Action Time' settings available. Combatants can optionally override the default action time.
- new: Combatants: Action Combos: 'Action Combos' settings available. Combatants can optionally override the default action combos or add additional action combos.
- new: Battle AI: 'Exclude Found Targets' setting available for 'Ally', 'Enemy' and 'All' target ranges. Excludes the already found targets from the targets that will be used/checked by the nodes.
- new: Battle AI: None: 'Is Silent' setting available. Optionally perform the 'None' action silently, i.e. no battle info will be displayed and no battle events will be used.
- new: Battle AI: Get Nearest: 'Nearest Offset Index' setting available. Defines which nearest combatant will be used, e.g. 0 is the nearest combatant, 1 the 2nd nearest combatant. Defaults to 0 (i.e. using the nearest combatant).
- new: Battle AI: Get Nearest: 'Use Grid Distance' setting available. Uses the distance on the battle grid when used in battles with a battle grid.
- new: Battle AI: Distance Sort Targets: 'Distance Sort Targets' node available in 'Position' nodes. Sort the found targets based on their distance to the user.
- new: Save Game Menu: Store Game Options: 'Store Game Options' settings available. Optionally store the language, sound volume and music volume outside of save games. Changes to these settings will be stored in PlayerPrefs and loaded when starting the application. The settings are still also saved/loaded with save games.
- new: GUI Boxes: 'Reset Unity Input' setting available. Resetting Unity inputs when accepting/canceling a GUI box is now optional per GUI box. Disable this setting when you want to use a 'Hold' input key to skip through dialogues. By default enabled.
- new: GUI Boxes: 'Own Key Scroll Speed' settings available. Optionally override the default key scroll speed defined in the menu settings for a GUI box.
- new: GUI Boxes, Game Controls: 'Use Scroll Axis' settings available. Optionally define an input key that is used to scroll the content of a GUI box.
- new: GUI Boxes: Choice Settings: 'Offset To Text' setting available. Defines the offset between the text and choices. Only used if there is content before the choices.
- new: Menu Screens: Ability, Inventory: 'None' default action available. Doesn't do anything when accepting an ability or item in the menu screen, the choice buttons will be displayed as useable. Use this when you only want to list items or abilities in the menu screen.
- new: HUDs: Element Bounds: 'Element Bounds' settings updated in all HUDs except 'Control' and 'Navigation'. The new element bounds settings allow anchoring an element based on the previous element and automatic scaling based on the available content space (e.g. scale width to 100% of the space).
- new: HUDs: Combatant, Turn Order, Latest Turn: 'No Time Text' setting available in 'Status Effect' HUD elements. Define the text that will be displayed for remaining time/turns text codes for status effects without time/turn duration. Defaults to an empty text.
- new: HUDs: Combatant, Turn Order, Latest Turn: 'Preview Hide Change' selection available in 'Value Origin' settings of 'Status Value', 'Attack Attribute', 'Defence Attribute' and 'Defence Attribute ID' HUD elements. Hidden if the displayed preview of the displayed status has a change.
- new: HUDs: Combatant, Turn Order, Latest Turn: 'Console' HUD element type available. Displays the combatant's console, can optionally be limited to selected console types.
- new: HUDs: Tooltip: 'Use Tooltip Variables' setting available in 'Tooltip' HUD elements. Optionally use variables of the displayed tooltip (e.g. ability variables of a displayed ability) instead of global variables for variable text codes.
- new: HUDs: Tooltip: 'Display Requirements' settings available in 'Tooltip' HUD elements. Optionally limit displaying a HUD element to defined variable conditions (either global variables or using variables of the displayed tooltip).
- new: HUDs: Tooltip: New text codes available in 'Tooltip' HUDs. Display the remaining time/turns and stack count of status effects in tooltips.
- new: HUDs: Information: 'Display Requirements' settings available in 'Information' HUD elements. Optionally limit displaying a HUD element to defined variable conditions.
- new: Text Display Settings: 'Combatant Name List' settings available. Defines how displaying multiple combatant's are displayed. This is e.g. used in console texts when displaying multiple targets or when using the '#equipped' text code for abilities to display the names of combatants that know an ability..
- new: Event System: Transfer Player Control: 'Transfer Player Control' node available in 'Input' nodes. Transfers player control from the currently controlled game object to a new game object.
- new: Event System: Has Player Control: 'Has Player Control' node available in 'Input' nodes. Checks if a game object is currently controlled by the player.
- new: Event System: Add Action Combo: 'Add Action Combo' node available in 'Combatant > Action Combo' nodes. Adds an action combo to a combatant.
- new: Event System: Remove Action Combo: 'Remove Action Combo' node available in 'Combatant > Action Combo' nodes. Removes an action combo from a combatant.
- new: Event System: Has Action Combo: 'Has Action Combo' node available in 'Combatant > Action Combo' nodes. Checks if a combatant has a defined action combo.
- new: Event System: Reset Action Combos: 'Reset Action Combos' node available in 'Combatant > Action Combo' nodes. Resets all action combos of a combatant to the first stage.
- new: Event System: Grid Rotate To Target: 'Grid Rotate To Target' node available in 'Battle > Grid' nodes. Changes a combatant's orientation on the grid to look at a target (e.g. cell or combatant).
- new: Event System: Use Battle Action: 'Use Failed Next' setting available. Optionally use a 'Failed' next slot if not at least one action is used or tried to be used.
- new: Event System: Change Selected Durability: 'Change Selected Durability' node available in 'Combatant > Equipment' nodes. Changes the durability of weapons and armors stored in selected data.
- new: Event System: Check Selected Durability: 'Check Selected Durability' node available in 'Combatant > Equipment' nodes. Checks the durability of weapons and armors stored in selected data.
- new: Event System: Add Console Line, Clear Console: 'Use Combatant Consoles' settings available. Optionally use the console of a defined combatant when adding a console line or clearing the console.
- new: Event System: Move AI Start Position: 'Use AI Start Position' node available in 'Combatant > Move AI' nodes. Changes the start position of a combatant's move AI. This can influence range checks of the move AI, e.g. the hunting range.
- new: Event System: Shake Object: 'Shake Object' node available in 'Movement > Movement' nodes. Shakes a game object.
- new: Battle Events: Change Action Time: 'Change Action Time' node available in 'Battle > Combatant' nodes. Changes the action time of a combatant.
- new: Battle Events: Check Action Time: 'Check Action Time' node available in 'Battle > Combatant' nodes. Checks the action time of a combatant.
- new: Battle Events: Change Action Time Running: 'Change Action Time Running' node available in 'Battle > Combatant' nodes. Changes if a combatant's action time is running or not.
- new: Battle Events: Is Action Time Running: 'Is Action Time Running' node available in 'Battle > Combatant' nodes. Checks if a combatant's action time is running.
- change: Real Time Battles: 'Freeze Action' and 'Time Scale' settings have been removed. Use the 'Time Scale' settings in battle menus for the same functionality. For using 'Freeze Action', set the time scale to 0. Old settings will not be updated, you have to set them up in the battle menu.
- change: Status Requirements: Turn State: The 'Turn Ended' status requirement has been changed to 'Turn State'. You can now check if a combatant is 'Before Turn', 'In Turn' or 'After Turn' (i.e. the previously used 'Turn Ended' state). Defaults to 'After Turn', old settings are updated accordingly.
- change: Text Codes: '#inventory' text code now displays the number of combatants that know the selected ability.
- change: Text Codes: '#equipped' text code now displays the list of combatants that know the selected ability. Uses the 'Combatant Name List' settings defined in 'Menus > Text Display Settings' to display the combatants.
- change: Event System: Check Grid Distance, Grid Cell Event: The cell objects now also support cells coming from combatants.
- change: HUDs: Value Bars: The 'Bar Bounds' settings for HUD elements displaying value bars have been removed. The value bar is now defined by the HUD element's bounds. Previous settings will be updated automatically to change the element bounds based on the bar bounds.
- change: Abilities, Items: Value Changes: Using attack/defence attributes to influence the change value is now optional. By default disabled. Old settings will enable it when updating to mimic the previous behaviour.
- change: Combatants: Prefab Portraits: Prefab view portraits now display the equipment of a combatant.
- fix: GUI Boxes: New UI: Fixed issues where choice buttons could flash when fading in/out a GUI box.
- fix: GUI Boxes: Legacy GUI: Fixed an issue where clicking and dragging on a scrollbar of an unfocused GUI box could scroll the wrong GUI box.
- fix: Save Games: Load: Fixed an issue where item drops wheren't loaded when loading the scene from a save game.
- fix: Save Games: Load: Fixed an issue where remembered combatants from a 'Combatant Spawner' combatant didn't use the move AI settings from the spawner.
- fix: Save Games: Load: Fixed an issue where loading a save game while the move AI was blocked didn't reset the block.
- fix: Status Values: Fixed an issue where very high 'Consumable' type status values (coming from their maximum status value) where initialized to wrong values.
- fix: Grid Battles: Placement: Fixed an issue where placing a combatant while selecting a placement cell didn't destroy the combatant's game object when cancelling the placement selection.
- fix: Event System: Check Game Variables: Fixed an issue where checking 'Object' variables using game objects without object variables resulted in 'Success'.
- fix: Combatants: Death Settings: Fixed an issue where keeping the prefab wasn't used when combatants also left their group on death.
- fix: GUI Boxes: Fixed an issue where text codes could be ignored when they where moved to a new line due to space limitations.
- fix: GUI Boxes: Name Box: Fixed an issue where the name box wasn't placed correctly when not using 'Relative Bounds' and the new UI.


Version 2.13.2:
- new: Unity 2017.1: ORK Framework now supports and requires Unity 2017.1.


Version 2.13.1:
- new: Grid Highlights: Combatant Selections: 'UI Hides Selections' setting available in 'Combatant Selections' grid highlights. Optionally hide combatant selection highlights when the cursor is over a GUI box (e.g. a HUD).
- new: Shortcut Settings: 'Keep Unavailable' setting available. Keep shortcuts that are currently unavailable.
 A shortcut becomes unavailable if the underlying item or action is no longer available, e.g. after equipping a weapon or using the last item of that kind.
If disabled, these shortcuts will be overridden or removed.
- new: HUDs: Combatant: 'Reverse Cursor Over' setting available for 'Individual' combatant HUDs with 'Cursor Over' enabled. Only displays the HUD when the cursor is not over the combatant's game object.
- new: Target Information Display: The title now supports text codes for hit chance ('%hit') and critical chance ('%crit').
- new: Event System: Add Console Line: 'Variable Origin' settings available. Select the origin of variables that will be used in the console text.
- change: Portrait Positions: 'Vertical Scale' setting has been replaced by 'Portrait Scale' selection. Now supports 'None' scale, 'Horizontal' scale (scaling based on screen width) and 'Vertical' scale (scaling based on screen height).
- change: Combatants: Individual HUDs: If a combatant's renderer is disabled or removed, the individual HUD will try to find a new renderer for checking if the combatant is visible. E.g. used when using UMA for your combatant's prefab.
- change: Loot: Loot tables can now have overlapping level ranges.
- fix: Weapons: Fixed an issue where loading a save game didn't use the weapon's attack/counter overrides.
- fix: Shortcuts: Fixed an issue where save games didn't save 'Attack' and 'Counter Attack' shortcuts not using the ability shortcut.
- fix: Shortcuts: Fixed an issue where default shortcut assignments didn't work correctly.


Version 2.13.0:
- new: Portraits: 'Portrait Type' setting available in portraits for areas, AI behaviours/rulesets, research trees, crafting recipes, weapons, armors, currency, items, abilities, quests, logs and log texts. Optionally add multiple portraits for different portrait types.
- new: Portraits: 'Use Prefab View' settings available in portraits for everything with a prefab (e.g. combatants, items, equipment). Displays the prefab as a portrait using render textures and a spawned camera prefab. General prefab view settings are defined in 'Menus > Menu Settings'.
- new: Battle Menus, Menu Screens, Notifications: 'Portrait Type' settings available for data that now supports portrait types (e.g. abilities, items). Select the portrait type that will be shown when (optionally) showing portraits in a menu or notification.
- new: Inventory Settings: 'Mark New Content' settings available. New content (e.g. items added to the inventory, new bestiary entries or newly learned abilities) can be marked as new. Menu screens can optionally use different content layouts to display new content differently.
- new: Input Keys: 'UI Blocks Input' setting available. Optionally block input for an input key while the cursor is over a GUI box.
- new: Camera Controls: Top Down Border: 'Block On Target Change' settings available in 'Rotation', 'Panning' and 'Zooming' settings. Optionally block changing the rotation, panning or zooming during camera target change transitions.
- new: Camera Controls: Mouse: 'Block On Target Change' settings available in 'Rotation' and 'Zooming' settings. Optionally block changing the rotation or zooming during camera target change transitions.
- new: Control Maps: Action: 'Block Battle Camera' setting available. Optionally block battle camera changes for the used action.
- new: Control Maps: Action: 'Only Cursor Over Target' setting available. Optionally only allow using a control map key when the cursor is over a valid target for the used action.
- new: Control Maps: Action: 'Use Cursor Over Target' setting available. Automatically use the action on the combatant the cursor is currently over. If the cursor isn't over a valid target, the auto target or target selection will be used.
- new: Status Effects: End Action: 'Block Battle Camera' setting available. Optionally block battle camera changes for the used action.
- new: Ability Trees, Research Trees, Status Developments: Learn Requirements: 'Variable Condition' settings available. Optionally use variable conditions (both global variables and object variables of the user) as requirements for learning/upgrading.
- new: Ability Trees, Status Developments: 'Finish Variable Changes' settings available. Optionally change variables (both global variables and object variables of the user) when learning/upgrading.
- new: Combatants: Notifications: New settings to block individual notifications (flying texts) for a combatant. E.g. block status value notifications (damage/refresh).
- new: AI Rulesets: Action: 'Block Battle Camera' setting available. Optionally block battle camera changes for the used action.
- new: Battle AI: Compare Status Value: 'Use Failed Next' setting available in 'Compare Status Value' nodes. Optionally use a different next node when the check fails. Also uses the combatants who failed the check as found targets.
- new: Battle AI: Compare Status Value: 'Check In' setting available in 'Compare Status Value' nodes. Optionally compare the values in percent instead of actual values.
- new: Battle AI: Use Last Targets: 'Target Origin' setting available. Optionally use the last targets of other combatants (e.g. the user's group leader).
- new: Battle AI: Use Attacked By: 'Use Attacked By' node available in 'Base' nodes. Adds the combatants that attached the user (or other combatants) to the found targets list.
- new: Battle AI: Action Nodes: 'Block Battle Camera' setting available. Optionally block battle camera changes for the used action.
- new: Battle AI: 'Check Keep' selection available in all 'Found Targets' settings. Checks the found targets, but also keeps those that didn't match the requirement of the node (e.g. 'Check Status' nodes).
- new: Battle Ranges: Range Settings: 'Only AI Controlled' setting available in all battle range settings. Optionally only use the minimum/maximum range for AI controlled combatants, i.e. the player isn't bound to ranges. By default disabled.
- new: Menu Settings: Prefab View Settings: 'Prefab View Settings' available. Defines how prefab view portraits are handled. Prefab view portraits require a prefab for the camera and a render texture.
- new: Menu Settings: Cursor Settings: 'Attack Range Cursors' settings available. Optionally use an 'In Range' and 'Out Of Range' cursor during a combatant's turn to show if targets are within range of the combatant's base attack.
- new: Menu Settings: Tooltip Settings: 'No Counter Tooltips' setting available when displaying action tooltips. Optionally block tooltips from being displayed for counter attacks.
- new: Menu Screens: Ability, Ability Tree, AI Behaviour, AI Ruleset, Bestiary (Area), Bestiary (Type), Crafting, Equipment, Inventory, Log, Quest, Research: 'Mark New' settings available. Optionally use a different content layout for displaying content marked as new (e.g. ability types with new abilities, new abilities, etc.).
- new: Menu Screens: Ability, AI Behaviour, AI Ruleset, Bestiary (Area), Bestiary (Type), Crafting, Inventory, Log, Quest, Research: 'Merge Sub-Types' setting available. Optionally merge sub-types together, i.e. instead of selecting a sub-type, all data from the selected type will be displayed.
- new: HUDs: Console: 'Always Auto Scroll Down' setting available. Optionally always scroll down to new console entries, regardless of the current scroll position.
- new: Shortcut Assignments: 'User Attack Ability' and 'Use Counter Ability' settings available. Using the actual ability of base/counter attacks is now optional, you can instead link to a general base/counter attack that will update automatically when the attack changes. By default enabled (using the ability).
- new: Editor Settings: 'Text Area Color' setting available. Defines the text color of text areas.
- new: Event System: Vector3 Values: 'Game Object Position', 'Game Object Rotation' and 'Game Object Scale' selections available in Vector3 value fields. Uses the global/local position, rotation or scale of a game object as value.
- new: Event System: Use Battle Action: 'Block Battle Camera' setting available. Optionally block battle camera changes for the used action.
- new: Battle Events: Set Grid Cell Combatant: 'Remove' selection available. Removes the combatant from the defined cell.
- change: Game Settings: The 'Quest Settings' have been moved to a new sub-section in 'Game > Quest Settings'. Your previous data will be updated automatically.
- change: Tooltips: Forced tooltips (e.g. from control maps showing tooltips or action tooltips) will no longer be reset when the regular tooltip form cursor over changes.
- change: Control Maps: Action: Group/individual targets are now only used when in use range of the ability or item.
- change: Combatant: Object Variables: Variables are now also available when not using object variables and initialized without a spawned game object.
- fix: Status Previews: Fixed an issue when previewing an ability without user and target changes.
- fix: Event System: Fixed an issue where disabled nodes could stop running events instead of being skipped.
- fix: HUDs: GUI Editor: Fixed an issue where typing text codes in the HUD GUI editor could result in errors.
- fix: Item Collectors: Fixed an issue where item collectors/boxes could add inventory space when the item wasn't collected.


Version 2.12.0:
- new: Menu Settings: 'Default Icon Size' settings available. Define the default icon size for all UI. By default using the original size of icons.
- new: GUI Boxes: 'Icon Size' settings available. Optionally override the default icon size defined in the menu settings for each GUI box individually.
- new: Text Codes: New text codes available to define icon sizes. Use the '#iconsize#' text code to define the size for all following icons ('#iconsize#' resets to the original size, '#iconsize#wX#' sets to width X and scales the height, '#iconsize#hX#' sets to height X and scales the width, '#iconsize#wX#hY# sets to width X and height Y).
- new: Text Codes: New text codes available to append to icon text codes to change the icon size of a single icon. '#wX#' sets to width X and scales the height (e.g. '#ability.icon2#w100#'), '#hX#' sets to height X and scales the width (e.g. 'ability.icon2#h50#'), '#wX#hY# sets to width X and height Y (e.g. '#ability.icon2#w100#h50#').
- new: Custom Choice Skins: Define a custom GUISkin (or prefab when using the new UI) for choices/buttons and content layouts throughout the framework. This can be used to highlight choices with a special button (e.g. 'Cancel' buttons with a yellow button). Also allows changing the icon size. Available wherever buttons are used, e.g. menu screens, battle menu, main menu, save game menu, etc.
- new: Shortcut Slots: 'Shortcut List Index' is now available in all settings related to shortcut slots (e.g. in 'Shortcut' HUD elements and control maps). You can now use different shortcut lists everywhere, use index '-1' to use the currently active shortcut list (default setting).
- new: Game Controls: Player: 'SC Destroy Player' setting available. Optionally destroy the player's game object before changing scenes. Enabling this option can help with some custom player controls setting the player to don't destroy on load.
- new: Game Controls: Camera: 'Control Target Transition' settings available. Optionally use a transition when changing the camera control target. The default transition can be overridden by each camera control target change setting (e.g. grid cell selections).
- new: Camera Controls: Top Down Border: 'Reset On Target Change' settings available in 'Rotation', 'Panning' and 'Zooming' settings. Optionally reset the rotation, panning or zooming of the camera when changing the camera control target.
- new: Camera Controls: Mouse: 'Reset On Target Change' settings available in 'Rotation' and 'Zoom' settings. Optionally reset the rotation or zooming of the camera when changing the camera control target.
- new: Control Maps: 'Audio Settings' available in control maps and control map keys. Optionally use an audio clip when successfully using a control map key (i.e. using the defined action) or failing to do so (i.e. not being able to use the assigned action). Control map keys can optionally override the success clip of the control map.
- new: Control Maps: Action: 'Class Ability' action selection available. Uses the combatant's class ability.
- new: Control Maps: 'During Target Selection' setting available in control map keys. Defines if a control map key can be used during target selection, disable to block the control map key during target selections. By default enabled (previous behaviour).
- new: Status Values: Block Notification: 'Block Notification' settings available. Optionally override the default block notification text defined in the battle texts for each status value individually.
- new: Status Values, Attack Attributes, Defence Attributes: 'Preview Settings' available. Optionally override the default 'No Change' preview texts defined in the preview settings in 'Menus > Menu Settings'.
- new: Abilities, Items: Raycast Targeting: 'Rotate To Raycast' setting available. Optionally rotate the user to the raycast position during raycast targeting.
- new: Abilities, Items: Status Changes: 'Cancel Casting' setting available. Optionally cancel casting without using status value changes that cancel casting.
- new: Abilities, Items: Status Changes: 'Blockable' setting available. Optionally block all status value and status effect changes of an ability or item with a single check of the combatant's block chance.
- new: Factions: Faction Texts: 'Faction Texts' available. These texts can be used elsewhere using text codes (e.g. '%ft0%' to display faction text 0 in a 'Combatant' HUD). You can e.g. use faction texts to define individual text styles per faction and use them in HUDs.
- new: Battle Settings: Target Selection: 'Rotate To Target' settings available. Optionally rotate the user to the selected targets during target selections. Can also be limited to grid rotations during grid battles.
- new: Battle Settings: Battle Camera: 'Battle Camera Type' selection available. The battle camera now allows 3 different types/modes - 'None' (not using the battle camera), 'Block Events' (the previous battle camera mode) and 'Allow Events' (a new mode allowing look at actions and event camera changes).
- new: Battle Settings: Battle Camera: 'Toggle Key' settings available. Optionally use an input key to toggle the battle camera functionality on and off in-game.
- new: Battle Settings: Battle Camera: 'Camera Control Target' settings available. Optionally set the default camera control target during battles to the currently selecting player group member, the battle arena or the player.
- new: Battle Settings: Battle Camera: Look At: 'Camera Control Target' look at type available. Uses the target (e.g. user of the latest action) as the new camera control target.
- new: Battle Settings: Battle Camera: Look At: 'Chance (%)' setting available. Look at actions are now used based on chance. By default set to 100 % chance.
- new: Battle Settings: 'Use Battle Range', 'Use AI Range' and 'Use Move AI Range' settings available. Using the battle range, AI range and move AI range to limit battle participation and AI actions and movement is now optional. By default enabled.
- new: Battle Settings: 'Target Bestiary Information' settings available in 'Target Information Dialogue' and 'Target Confirmation Dialogue' settings. Optionally use bestiary information when displaying status values.
- new: Battle Settings: Target Confirmation Dialogue: 'Cursor Move Only' settings available in 'User Changes' and 'Target Changes' settings. Optionally show/hide the information box only when actually moving the cursor (when using 'Cursor Over').
- new: Battle Systems: Move AI: 'Use Move AI Range' setting available in all battle system types. Using the move AI range to limit AI movement is now optional. By default enabled.
- new: Battle Ranges: Grid Shape: 'Visible Cell Area' setting available for battle ranges that have 'Use Line Of Sight' enabled. Defines a cell radius (value from 0 to 0.5) which will be checked for visibility when calculating line of sight. A value of 0 will only check the cell's center, while 0.5 will check the whole cell.
- new: Turn Based Battles: 'Turn Order Counter' settings available. Define how the turn order counter will be displayed in HUDs when using the '%to' text code.
- new: Grid Battles: Move Command, Target Cell Selection: 'Start From User' setting available. Starts the target cell selection from the user's cell - if disabled, a previously selected cell (also from other cell selections) will be used. By default enabled.
- new: Grid Battles: 'Control Target Transition' settings available in all cell selections. Optionally override the default control target transition with a custom transition.
- new: Grid Battles: Move Command, Target Cell Selection: 'Rotate To Cell' settings available. Optionally rotate the user to the selected cell during cell selections. Can also be limited to grid rotations.
- new: Grid Highlights: 'UI Hides Highlights' settings available. Optionally hide various grid cell highlights when the cursor is over a GUI box (e.g. a HUD).
- new: Grid Highlights: Combatant Selection: 'Combatant Selection' settings available. Optionally use different selection highlights when a cell with a combatant is selected. These highlights will override other selection highlights (e.g. fore move command or examine grid) when a cell with a combatant is selected.
- new: Grid Highlights: Available Target: 'Available Target' settings available. Optionally highlight the grid cells of avaialble targets during action/target selection. Different highlights can be defind for player group members, allies and enemies.
- new: Grid Highlights: Examine: 'Examine (Blocked Cell)' settings available. Use a different cell highlight for a selected blocked cell during the grid examine cell selection.
- new: Grid Highlights: Examine: 'Combatant Is Blocked' setting available. Optionally use the blocked selection cursor for combatants.
- new: Grid Highlights: Selecting Combatant: 'Selecting Combatant' settings available. Optionally highlight the grid cell of an action selecting combatant. Different highlights can be defind for player group members, allies and enemies.
- new: Battle AI: Compare Status Value: 'Check Other' settings available. Optionally check against a different status value on the targets, e.g. comparing the user's HP against the target's MP.
- new: Battle AI: In Use Range: 'In Use Range' node available in 'Position' nodes. Checks if targets are within use range of a defined action or battle range. Adds valid targets to the found targets list.
- new: AI Rulesets: Action: 'Shortcut' action type available in 'Action' AI rules. Uses a shortcut of a defined shortcut slot.
- new: Menu Settings: Tooltip Settings: 'Tooltip Settings' available. These settings handle displaying tooltips. New settings available to e.g. display tooltips for current player actions.
- new: Menu Settings: Preview Settings: 'Preview Blink' settings available. Optionally blink between the preview value and the actual value when displaying status previews. This can be turned on/off for each individual HUD element displaying preview values.
- new: Menu Settings: Preview Settings: 'Min/Max Range Text' setting available. This text defines how preview values representing a range (e.g. an ability with random status value changes) are displayed (e.g. '35 ~ 52'). This text is e.g. used by 'Combatant' HUDs when displaying status value previews as text.
- new: Menu Settings: Preview Settings: 'Status Value', 'Attack Attribute' and 'Defence Attribute' settings. Optionally define texts for replacing current value ('%') and change value ('%c') of status previews in HUDs. Status values, attack attributes and defence attributes can override these texts.
- new: GUI Boxes: Menu Controls: 'Menu Controls' settings available. GUI boxes can optionally override the default menu controls (accept, cancel, horizontal and vertical input).
- new: GUI Box: Choice Settings: 'Block Mouse Over Selection' setting available. Optionally block mouse over choice selections for individual GUI boxes. Mouse over selection can be enabled in the menu settings.
- new: Menu Screens: Button List: 'Use Combatant Part' setting available when using combatant selection in a menu item. Optionally use a 'Combatant' menu part as the combatant selection. If no 'Combatant' menu part is available or it only displays the current user (i.e. no battle group or group display), a combatant selection is used (as defined).
- new: Menu Screens: Research: 'Close After Start' and 'Close After Stop' settings available. Optionally close the menu screen after starting or stopping research of a research item.
- new: Menu Screens: Equipment: 'Empty Part Tooltip' setting available. Optionally display tooltips for empty equipment parts.
- new: Menu Screens: Quests: Custom content layout settings available for different quest states. E.g. use different layouts for active and inactive quests.
- new: Text Display Settings: Use Costs: 'Min/Max Range Text' settings available. Optionally replace the '%' text code for use cost changes with a text representing the minimum and maximum value for use costs that represent a range (e.g. random costs or formulas with min/max display formula defined).
- new: Game States: 'Target Selection' and 'Performing Action' state checks available when using 'Ignore' or 'Yes' for the 'In Battle' state. Checks if a player group member is currently selecting a target for an action or if any action is currently being performed.
- new: Save Game Menu: 'Max Battle Group' setting available. Optionally save the maximum battle group size of player groups in save games.
- new: HUDs: Combatant, Turn Order, Latest Turn: 'Check Game States' settings available in HUD element requirements. Optionally check game states as a requirement for displaying a HUD element.
- new: HUDs: Combatant, Turn Order, Latest Turn: New text code available in 'Information' HUD elements. Use '%to' to display the turn order counter of the combatant. How the counter is replaced is defined in the turn based battle settings. This text code is only used in turn based battles.
- new: HUDs: Combatant, Turn Order, Latest Turn: Status Value: 'Own Min/Max Current Text' and 'Own Min/Max Change Text' settings available in 'Status Value' HUD elements in 'Combatant' type HUDs. Optionally override the default min/max range text with custom texts to replace the '%' (current value) and '%c' (change value) text codes when displaying a preview with a range.
- new: HUDs: Combatant, Turn Order, Latest Turn: 'Use Preview Blink' setting available when displaying preview values. Optionally blink between the preview value and the actual value based on the 'Preview Blink' settings defined in 'Menus > Menu Settings'. By default enabled.
- new: HUDs, Status Values: Value Bars: 'Positive Range' and 'Negative Range' value bar settings available when displaying positive or negative changes. Optionally use a different image/color for displaying positive and negative range changes. This is e.g. used when displaying the preview for an ability with random status value changes.
- new: HUDs: Combatant, Turn Order, Latest Turn: 'Format' settings available in 'Attack Attribute' and 'Defence Attribute' HUD elements. Define the format for the current value ('%') and change value ('%c'), e.g. use 0 to not display decimals, 0.0 to display 1 decimal, etc.
- new: HUDs: Combatant, Turn Order, Latest Turn: 'Preview' settings available in 'Status Value', 'Attack Attribute' and 'Defence Attribute' HUD elements. Optionally enable/disable displaying no change preview texts or override min/max preview texts for status values.
- new: HUDs: Combatant: 'Use Range Limit' settings available when using 'Individual' combatant type. Optionally limit the range to the player an individual HUD will be displayed.
- new: HUDs: Combatant: Attack Attribute, Defence Attribute, Defence Attribute ID, Equipment, Faction, Status Value: 'Enable Tooltip' setting available. Optionally show tooltips when the cursor is over a HUD element.
- new: HUDs: Tooltip: 'Status Value' and 'Status Value Upgrade' settings available. Optionally show tooltips when the cursor is over a HUD element representing a status value or a choice representing a status value upgrade.
- new: HUDs: Tooltip: 'Equipment Parts' setting available. Optionally show tooltips when the cursor is over a HUD element or choice representing an equipment part.
- new: HUDs: Tooltip: 'Attack Attribute' and 'Defence Attribute' settings available. Optionally show tooltips when the cursor is over a HUD element representing an attack attribute or a defence attribute.
- new: HUDs: Tooltip: 'Faction' and 'Faction Benefit' settings available. Optionally show tooltips when the cursor is over a HUD element representing a faction or faction benefit.
- new: Combatant Selections: 'Auto Accept One' setting available. Optionally automatically accept a combatant without showing the combatant selection if only one combatant is available.
- new: Event System: Camera Control Target: 'Control Target Transition' settings available. Optionally override the default control target transition with a custom transition.
- new: Event System: Is Enemy: 'Is Enemy' node available in 'Combatant > Faction' nodes. Checks if a combatant is an enemy of another combatant.
- new: Event System: In Use Range: 'In Use Range' node available in 'Battle > Action' nodes. Checks if a combatant is within use range of an ability, item, shortcut slot's ability/item, battle range template or custom battle range from another combatant.
- new: Event System: Use Battle Action: 'Class Ability' action type available in 'Use Battle Action' nodes. Uses the combatant's class ability.
- new: Event System: Use Battle Action: 'Shortcut' action type available in 'Use Battle Action' nodes. Uses a shortcut of a defined shortcut slot.
- new: Event System: Use Battle Action: 'Add Action' setting available to define how an action will be added/used. Either tries to use the action immediately, adds it as the combatant's next action (i.e. used in the next turn of the combatant), or uses it as a sub action of the action the event is used by. Sub actions allow waiting for an action to perform before resuming the event.
- new: Event System: Change Found Objects: 'Chance Filter' settings available. Optionally filter the used game objects by chance.
- new: Event System: Call Global Event, Call Move Event, Call Battle Event: 'Share Variables',  'Share Selected Data' and 'Share Found Objects' settings available. Optionally share the local variables, selected data and found objects with the called events.
- new: Event System: Combatant Selection Dialogue: 'Combatant Selection Dialogue' node available in 'UI > Dialogue' nodes. Displays a combatant selection and stores the seleced combatant into a selected data list. Allows various ranges of combatant groups to be selected (e.g. battle group, inactive group, etc.).
- new: Event System: Active Group Nodes: 'Group Origin' setting available in all active group nodes ('Combatant > Active Group'). Select which group will be used, the active player group, a defined player group (by group ID) or the group of a defined combatant. By default set to the active player group (previous behaviour).
- new: Event System: Change Max Battle Group: 'Change Max Battle Group' node available in 'Combatant > Player Group' nodes. Changes or resets the maximum battle group size of player groups.
- new: Event System: Check Max Battle Group: 'Check Max Battle Group' node available in 'Combatant > Player Group' nodes. Checks the current maximum battle group size of player groups.
- new: Event System: Show Dialogue: 'Custom Skin' settings available for choices. Optionally use a different GUI skin (or prefab when using the new UI) for individual choice buttons.
- new: Game Events: 'Clear Found Objects' setting available. Removes all stored found objects at the start of the event. By default enabled.
- new: Battle Events: 'Clear Found Objects' setting available. Removes all stored found objects at the start of the event. By default disabled.
- new: Battle Events: Set Grid Path: 'Set Grid Path' node available in 'Battle > Grid' nodes. Sets the grid path of an action.
- new: Battle Events: Store Grid Cells: 'Store Grid Cells' node available in 'Battle > Grid' nodes. Store grid cell game objects into a found/global object lists.
- new: Battle Events: Clear Grid Path: 'Clear Grid Path' node available in 'Battle > Grid' nodes. Removes the grid path from the action.
- new: Battle Events: Consume Grid Path Cost: 'Consume Grid Path Cost' node available in 'Battle > Grid' nodes. Consumes the move costs of a grid path. The move costs will be set to 0 after consumption, i.e. the costs can't be consumed a 2nd time.
- new: Battle Events: Grid Move Out Of Range: 'Grid Move Out Of Range' node available in 'Battle > Grid' nodes. Checks if the grid path will move the user out of use range of other combatants (e.g. of a defined ability), i.e. the user is currently within use range but the next/last cell of the path will be out of use range. Can optionally also be reversed, i.e. checking if user moves into use range.
- new: Combatant Spawner: 'Respawn Random' setting available when having 'Spawn Random' enabled. Optionally also respawns a random group/combatant instead of respawning the same (random) group/combatant.
- change: Menu Settings: The 'Text Display Settings' ('Use Cost Display', 'Bonus Display', 'Target Information Display') and 'Default Combatant Choice Layout' settings have been moved to a new sub-section in 'Menus > Text Display Settings'. Your previous data will be updated automatically.
- change: Abilities, Items: Raycast Targeting: Canceling raycast targeting now plays the 'Cancel' audio clip.
- change: Target Information Display, Status Previews: Status value changes now take barriers into account.
- change: Grid Battles: Grid Highlights: The 'Grid Highlight' settings have been moved to a new sub-section in 'Battle System > Battle Grid Highlights'. Your previous data will be updated automatically.
- change: Control Maps: The 'Shortcut' key type is now part of the 'Action' key type. Previous settings will be updated automatically. Shortcuts also support different shortcut lists instead of only the currently active list.
- change: Battle Actions: The battle events of a battle action will now also share the found objects with each other.
- change: Save Games: Addes safeguards when loading a save game with references to data that was deleted in the ORK project (e.g. an item in the inventory that exceeds the available item IDs).
- change: Game Settings: The 'Default Screen Size' is now set to 1920*1080 in new projects.
- change: UI: Icons in text now cause less distance between lines.
- change: Editor: GUI Boxes: The settings to override default GUI box settings have been bundled and moved to the bottom of the GUI box settings.
- change: Battle Components: 'Look At Enemies' is now disabled on newly created battle components.
- change: Menu Screens: 'Merged' type displays only show the types defined in the menu screen part instead of all types.
- fix: Event System: Enable Auto Attack: Fixed an issue that always enabled auto attacks, regardless of the node's setup.
- fix: GUI Boxes: New UI: Fixed an issue where the ok/cancel buttons wheren't removed from a content box when not using a button prefab.
- fix: GUI Boxes: New UI: Fixed an issue where the choice icon cursor could flash shortly on GUI boxes it wasn't displayed when updating the UI (e.g. when changing the selected choice in menu screens).
- fix: GUI Boxes: Fixed an issue where displaying tabs at the top interfered with mouse over and drag locations of choices.
- fix: Editor: GUI Editor: Fixed an issue that caused errors when opening a 'Combatant' type HUD in the GUI editor.
- fix: Grid Battles: Fixed an issue where hover selection could select grid cells of battle grids that are not used in the current battle.
- fix: HUDs: Combatant, Turn Order: Fixed an issue where using 'Hide Empty HUD' didn't display HUDs that where not empty.
- fix: Target Information Display: Fixed an issue where showing the 'No Value Change' text used the 'Negative Change' text instead.
- fix: Save Game: Inventory: Fixed an issue where loading a save game could add the start inventory to loaded combatants.
- fix: New UI: Text Notifications: Fixed an issue where text notifications didn't scale when using the new UI.
- fix: Event System: Fixed an issue where stopping events with a node-loop could result in never ending the event (e.g. a battle event stopped due to the action's user dying).
- fix: Menu Screens: Inventory: Fixed an issue where empty inventories without a type box wheren't updated correctly.


Version 2.11.2:
- change: New UI: Changed how inactive box/button colors work when used together. Instead of forcing inactive box color on inactive buttons, they'll now blend together.
- fix: Inventory: Individual: Fixed an issue that leads to errors/crashes when using 'Individual' inventory.
- fix: New UI: Fixed some issues where choice buttons where flashing when updating the content of GUI boxes (e.g. menu screens).


Version 2.11.1:
- new: Unity 5.6: ORK Framework now supports and requires Unity 5.6.


Version 2.11.0:
- new: Shortcut Settings: New sub-section available in 'Menus > Shortcut Settings'. General and default shortcut slot related settings are defined here.
- new: Shortcut Settings: '2nd Call Deactivate' setting available. Optionally deactivates an active shortcut (i.e. during target selection) when using it a 2nd time. This is available possible through control maps and click use in shortcut HUDs.
- new: Shortcut Settings: Default Shortcut Assignments: Define default shortcut assignments for combatants/classes. Combatants and classes can optionally replace the default assignments, otherwise the default assignments and those defined by the combatant/class will be used together.
- new: Shortcut Settings: Default Auto Add Slots: Define a range of shortcut slots that will be automatically assigned when a combatant gets new shortcuts (e.g. learns a new ability). The first free slot will be assigned with the new shortcut. Shortcuts can be limited to active/passive abilities, useable/unusable items, weapons, armors or currency, and further limited to defined ability/item types.
- new: Shortcut Settings: Default Auto Arrange Slots: Define a range of shortcut slots that will be automatically arranged when a shortcut is removed. Shortcuts within the defined range will be moved up/down to fill the empty slot. Shortcuts can be limited to active/passive abilities, useable/unusable items, weapons, armors or currency, and further limited to defined ability/item types.
- new: Shortcut Settings: Default Slot Layouts: Define the default layout for displaying shortcut slots. HUDs can use the default layout or override it with a custom layout. Layouts can be defined for empty and assigned slots. Assigned slots can optionally use different layouts depending on the assigned shortcut (ability, item, equipment and currency).
- new: Shortcut Settings, HUDs: Shortcut Slot Layouts: Define different colors and background images for inactive (unusable), active (in use, e.g. target selection or action use) and highlighted (cursor over) shortcut slots.
- new: Camera Controls: Top Down Border: 'UI Blocks Panning' setting available when using 'Screen Edge Panning' in the 'Top Down Border' camera controls. Optionally blocks panning when the mouse is over a GUI box.
- new: Camera Controls: Top Down Border: 'UI Blocks Zooming' setting available in the 'Top Down Border' camera controls. Optionally blocks zooming when the mouse is over a GUI box.
- new: Control Maps: Control Keys: 'Global Event' type selection available. Calls a global event using the combatant as starting object when pressing the control key.
- new: Weapons, Armors: 'One Time Equip' setting available. Equipment can optionally be equipped only once, i.e. it'll be destroyed when unequipping it, instead of returning it to the inventory.
- new: Combatants, Classes: Shortcut Assignments: 'Replace Default' settings available in 'Shortcut Assignments'. Optionally replace the default shortcut assignments defined in 'Menus > Shortcut Settings' with the shortcuts defined by the combatant/class. If disabled, the defined shortcuts will be used in addition to the default assigments.
- new: Combatants, Classes: Shortcut Assignments: 'Defend', 'Escape', 'None', 'Grid Move', 'Grid Orientation' and 'Grid Examine' shortcuts available. You can now assign these special battle actions as shortcuts to a shortcut slot.
- new: Combatants, Classes: Shortcut Settings: 'Auto Add Slots' settings available. Optionally add or replace the default auto add slots defined in 'Menus > Shortcut Settings'.
- new: Combatants, Classes: Shortcut Settings: 'Auto Arrange Slots' settings available. Optionally add or replace the default auto arrange slots defined in 'Menus > Shortcut Settings'.
- new: HUDs: Background/Foreground Images: You can now add multiple background and foreground images per HUD. Previous settings will automatically be updated.
- new: HUDs: Combatant: 'Own Slot Layouts' setting available in 'Shortcut' HUD elements. Optionally override the default slot layouts defined in 'Menus > Shortcut Settings'. Old settings will automatically update to use custom layouts.
- new: HUDs: Combatant: Custom slot layouts available in 'Shortcut' HUD elements. Optionally use a different layout for shortcut slots assigned with ability, item, equipment and currency shortcuts.
- new: Battle Settings: Target Selection: 'Cursor Over Selection' setting available in 'Mouse/Touch Control' target selection settings. Optionally select a combatant by hovering the cursor over the combatant's game object.
- new: Battle Settings: Target Selection: 'Use Grid Cell' setting available in 'Mouse/Touch Control' target selection stetings. Optionally allow using the grid cell of a combatant for target selection (click/touch and cursor over).
- new: Battle Settings: Target Information Dialogue: 'Cursor Over' settings available in the 'User Changes' and 'Target Changes' settings. Optionally only show the user/target changes when hovering the cursor over the combatant's game object.
- new: Battle Settings: Target Information Dialogue: 'Use HUD' settings available in the 'User Changes' and 'Target Changes' settings. Optionally use HUD elements defined in a 'Combatant' HUD to show additional information.
- new: Battle Settings: Target Change Keys: 'Target Change Keys' settings available in 'Target Selection' settings. Optionally use input keys to cycle through available targets.
- new: Battle System: 'Battle Menu Settings' available in turn based, active time and phase battles. Automatically calling the battle menu at the start of a player controlled combatant's turn is now optional. When disabled, the battle menu can be called using a defined input key. Automatically calling the battle menu is by default enabled.
- new: Battle System: 'Selecting Control Map' setting available in turn based, active time and phase battles. Optionally use the control maps of the currently selecting player group member instead of the actual player combatant.
- new: Battle System: 'Player Auto Grid Move' setting available in all battle system types. Optionally starts the grid move cell selection when a player controlled combatant starts a new turn or whenever the action selection is prompted.
- new: Battle Menus: 'Use Action Info' setting available in 'Defend', 'Escape', 'End', 'Grid Move', 'Grid Orientation' and 'Grid Examine' battle menu items. Uses the default content information of the command defined in 'Battle System > Battle Texts' for the button.
- new: Battle Ranges: Grid Shape: 'Ring' grid shape type selection available for battle ranges. All cells on a ring with a defined range (radius) around the origin cell will be used as grid shape.
- new: Battle Ranges: Grid Shape: 'Add Not Passable Cells' setting available for battle ranges that have 'Add Blocked Cells' enabled. If enabled, blocked cells that aren't passable will be selected by the shape. If disabled, only blocked cells that are passable will be selected.
- new: Battle Ranges: Grid Shape: 'LOS Passable Cells' setting available for battle ranges that have 'LOS Blocked Cells' enabled. Optionally have blocked passable cells block the line of sight. If disabled, only blocked cells that aren't passable will block the line of sight.
- new: Battle AI: Grid Move: 'Target Cell' setting available in 'Grid Move' nodes. Defines which cell around the target will be used, e.g. the nearest cell (to the moving combatant), a cell north (global) or in front (local) of the target.
- new: Grid Battles: Examine Grid, Move Command, Orientation, Target Cell Selection: 'Block Action Use' setting available. Optionally block the combatant's use of actions during grid cell selections.
- new: Grid Battles: Combatant Placement, Move Command, Orientation, Target Cell Selection: 'Examine Cell' and 'Examine Cell Combatant' settings available. Optionally show the cell info or combatant info dialogues ('Examine Grid' settings) of a selected cell during placement, move, orientation or target cell selections. This will only display information boxes, not cell highlights like the move range.
- new: Grid Battles: Cell Selections: 'UI Blocks Selection' setting available in 'Mouse/Touch Control' settings when having 'Hover Select' enabled. Optionally blocks hover selection when the cursor is over a GUI box (e.g. a HUD).
- new: Grid Battles: Examine Grid: 'Cell Info Text' settings available. Optionally display an information box for the selected cell, e.g. displaying the cell type's name or move cost.
- new: Grid Battles: Examine Grid: 'Max Move Range (Enemy)' and 'Max Move Range (Ally)' settings available when having 'Show Move Range' enabled. Optionally uses the maximum move range for enemy or ally combatants when highlighting the move range cells. If disabled, the current move range will be used. By default enabled (i.e. max move range).
- new: Grid Battles: Examine Grid: 'Use Bestiary Information' setting available. Using the status information of a combatant based on what the player learned in the bestiary is now optional. By default enabled (i.e. using bestiary information).
- new: Grid Battles: Examine Grid: 'Always Active' settings available. Optionally have grid examine always active during grid battles (as long as no other cell selection is active, e.g. move cell selection).
- new: Grid Battles: Examine Grid: 'Target Selection Examine' settings available. Optionally show cell and combatant information of the currently selected target during target selections.
- new: Grid Cell Types: 'Content' settings available. Define name, description and icon of battle grid cell types (per language). Previous settings (only internally used name) will be updated automatically. There are new text codes available to add battle grid cell type information to texts.
- new: Grid Cell Types: 'Passable' setting available for cell types that have 'Blocked' enabled. Optionally make a blocked cells passable, i.e. combatants can move over them, but not stop on them.
- new: GUI Boxes: 'Cursor Over' setting available. Determines if a GUI box is recognized by cursor over checks. This is e.g. used by UI blocks in camera controls or grid cell hover selections. By default enabled.
- new: GUI Boxes, Menu Settings: New UI: 'Inactive Color' settings available for button prefab settings when using the new UI. Optionally define a color used to fade the child objects of a button when it's inactive. If disabled, the button's color will be used.
- new: Menu Settings: 'Selection Tooltip' setting available. Optionally display tooltips for the currently selected choice instead of only the content the cursor is hovering over. Cursor over always takes priority.
- new: Menu Settings: 'Status Preview Settings' available. Various settings for handling status previews for combatants.
- new: Menu Screens: Button: 'Close Screen' setting available for 'Save' and 'Load' buttons. Optionally closes the menu screen before opening the save/load menu. The save menu can also optionally not return to the menu screen after saving.
- new: UI: Target Information Display: 'Use Min Chance' and 'Use Max Chance' settings available. Optionally limit the displayed chance value (e.g. hit chance) of target information displays to a defined range (e.g. between 0 and 100 %).
- new: Save Game Menu: 'Custom' save functionality available. Saving to 'Custom' save type allows defining 4 static functions to handle your custom save game functionality.
- new: Save Game Menu: Save Point: 'Close After Save' setting available. Optionally closes the save point after saving the game.
- new: Event System: Auto Arrange Shortcuts: 'Auto Arrange Shortcuts' node available in 'Combatant > Shortcut' nodes. Auto arranges the shortcuts of a combatant or group according to the auto arrange slot settings of the combatant or default settings.
- new: Event System: Change Equipment: 'Use Selected Data' settings available in 'Change Equipment' nodes. Optionally use equipment stored in selected data to change equipment of a combatant.
- new: Event System: Change Shortcut: 'Defend', 'Escape', 'None', 'Grid Move', 'Grid Orientation' and 'Grid Examine' shortcuts available. You can now assign these special battle actions as shortcuts to a shortcut slot.
- new: Event System: Check Shortcut: 'Defend', 'Escape', 'None', 'Grid Move', 'Grid Orientation' and 'Grid Examine' shortcuts available. You can now check for these special battle actions in shortcut slots.
- new: Event System: Change Time Scale: 'Reset' setting available. Optionally reset the time scale to the previous value. Time scales now keep track of their changes.
- new: Event System: Swap Grid Cell Combatants: 'Swap Grid Cell Combatants' node available in 'Battle > Grid' nodes. Exchanges the combatants of two grid cells. If one cell is empty, the combatant will be moved to the empty cell (if it's not blocked).
- new: Event System: Block Active Time: 'Block Active Time' node available in 'Battle > Battle' nodes. Blocks or unblocks the progress of active time bars. When blocked, the timebars of all combatants will not increase.
- new: Event System: Change AI Controlled: 'Change AI Controlled' node available in 'Battle > Combatant' nodes. Changes if a combatant is AI controlled or not - only used by combatants of the player group.
- new: Event System: Is AI Controlled: 'Is AI Controlled' node available in 'Battle > Combatant' nodes. Checks if a combatant is AI controlled or not. Combatants that are not part of the player group are always AI controlled.
- change: Event System: Shortcut Nodes: The shortcut nodes are now available in all event types.
- change: Grid Battles: Cell Selections: 'Hover Select' will no longer change the camera control target (if enabled). Otherwise hover selection would be unusable. Also, hover selection now only works upon mouse move.
- change: Equipment Shortcuts: Using weapon or armor shortcuts will now first try to find a free equipment part (used by the equipment) before using the first matching part.
- fix: Move AI: Fixed an issue where the move AI caused an error when targeting a combatant with an already destroyed game object.
- fix: Battle System: Fixed an issue where the battle end revive bonus wasn't used.
- fix: Weapons, Armors, Equipment Viewers: Fixed an issue where the 'Blocked Equipment Viewer' options blocked the wrong equipment viewers.
- fix: New UI: Fixed an issue where disabled 'Show Button' settings still showed the buttons.
- fix: New UI: Fixed an issue where fading in a GUI box could prevent buttons from changing the color of child objects (e.g. text, image).


Version 2.10.1:
- new: Status Values: Experience: 'Max Value Type' setting available for 'None' experience types. Defines which value will be used as max value, either the 'Next Level' value, the 'Current Level' value (both as defined in the status development) or the actual 'Max Value' of the status value.
- new: Battle Settings: 'Play Victory Animation' setting available. The combatants that won the battle will play the victory animation type. By default enabled.
- new: Battle System: Real Time Battles: 'Set Time Scale' settings available. Optionally change the time scale while displaying a battle menu (available when not using 'Pause Menu').
- new: Abilities, Items: Damage Dealer Settings: 'Mount Prefab' setting available. Optionally mount the spawned prefab to the combatant that was hit.
- new: Status Requirements: AI Behaviour Slot Count: 'AI Behaviour Slot Count' requirement selection available. Compares the number of AI behaviour slots of a combatant with a defined value.
- new: Status Requirements: AI Ruleset Slot Count: 'AI Ruleset Slot Count' requirement selection available. Compares the number of AI ruleset slots of a combatant with a defined value.
- new: GUI Layers: 'GUI Settings' available. Optionally override the default GUI scale and anchor for a GUI layer. Allows using GUI scaling per GUI layer.
- new: Menu Settings: 'Drag Mouse Over' setting available. Using mouse over selection while dragging is now optional. By default enabled.
- new: Menu Screens: 'Set Time Scale' settings available. Optionally change the time scale while displaying the menu screen (available when not using 'Pause Game').
- new: Menu Screens: Bestiary (Area): 'Close Type Box' setting available in the 'Bestiary Box' settings when using 'Same' or 'One' display type. Optionally close the type box when area and bestiary box aren't displayed at the same type. Use this option to have the bestiary box separated from the previous boxes.
- new: Menu Screens: Bestiary (Area): 'Close Type Box' and 'Close Area Box' settings available in 'Entry Box' settings when using 'Same' or 'One' display type. Optionally close the type and area box when bestiary and entry box aren't displayed at the same type. Use this option to have the entry box separated from the previous boxes.
- new: Menu Screens: Bestiary (Type): 'Close Type Box' setting available in the 'Entry Box' settings when using 'Same' or 'One' display type. Optionally close the type box when list and entry box aren't displayed at the same type. Use this option to have the entry box separated from the previous boxes.
- new: Menu Screens: Crafting: 'Close Type Box' setting available in the 'Create Box' settings when using 'Same' or 'One' display type. Optionally close the type box when recipe and create box aren't displayed at the same type. Use this option to have the create box separated from the previous boxes.
- new: Menu Screens: Group: 'Close Action Box' setting available in the 'Non-Battle Group Box' settings when using 'Same' or 'One' display type. Optionally close the action box when battle group and non-battle group box aren't displayed at the same type. Use this option to have the non-battle group box separated from the previous boxes.
- new: Menu Screens: Log: 'Close Type Box' setting available in the 'Text Box' settings when using 'Same' or 'One' display type. Optionally close the type box when log and text box aren't displayed at the same type. Use this option to have the text box separated from the previous boxes.
- new: Menu Screens: Quest: 'Close Type Box' setting available in the 'Info Box' settings when using 'Same' or 'One' display type. Optionally close the type box when quest and info box aren't displayed at the same type. Use this option to have the info box separated from the previous boxes.
- new: Menu Screens: Research: 'Close Type Box' setting available in the 'Item Box' settings when using 'Same' or 'One' display type. Optionally close the type box when tree and item box aren't displayed at the same type. Use this option to have the item box separated from the previous boxes.
- new: Menu Screens: Research: 'Close Type Box' and 'Close Tree Box' settings available in 'Details Box' settings when using 'Same' or 'One' display type. Optionally close the type and tree box when items and details box aren't displayed at the same type. Use this option to have the details box separated from the previous boxes.
- new: Menu Screens: Sub Menus: 'Block Tooltips' setting available. Optionally block tooltips while a sub menu is opened.
- new: Menu Screens: Sub Menus: 'Close Out Of Box Click' setting available. Optionally close the sub menu when clicking outside of the GUI box.
- new: HUDs: Combatant, Turn Order: 'Global Event' click type selection available. Starts a global event using the combatant as starting object.
- new: HUDs: Combatant, Turn Order: 'Combine Stacked' setting available. Optionally combine stacked status effect to only display one of the effects.
- new: HUDs: Combatant, Turn Order: New text codes available for 'Status Effect' HUD elements. Use '%sc' to display the number of times a status effect is stacked. Use '%sc2' to display the stack count only if it's greater than 1.
- new: HUDs: Console: 'Auto Scroll Down' setting available in 'Console' type HUDs. Automatically scroll down to new entries when already fully scrolled down.
- new: Text Codes: Date: '#date.local' and '#date.utc' text codes available to display the current real date and time in a defined format. The format is defined using C# date and time format options, e.g. '#date.localyyyy-MM-dd H:mm:ss#' formats to '2017-01-22 17:05:01'.
- new: Battle AIs: Compare Status Value: 'Compare Status Value' node available in 'Combatant' nodes. Checks the status value of targets against the user's value and adds those that match to the target list. E.g. select all enemies that have less HP than the user.
- new: Battle AIs: Rotate To Target: 'Rotate To Target' node available in 'Position' nodes. Rotates the user to the found targets.
- new: Battle AIs: Get Nearest: 'Get Nearest' node available in 'Position' nodes. Adds the nearest combatant to the found targets.
- new: Battle Events: Activate Damage Dealer: 'Mount Prefab' setting available. Optionally mount the spawned prefab to the combatant that was hit.
- new: Event System: Change Item Box ID: 'Change Item Box ID' node available in 'Game > Scene' nodes. Changes the box ID of a 'Box' item collector on a game object.
- new: Event System: Progress Research: 'Reset Progress' setting available in 'Progress Research' nodes. Optionally reset the progress of research items to being unresearched.
- new: Event System: Show Dialogue: 'Show Inactive' setting available for choices. Optionally show choices that are inactive due to their defined conditions as inactive buttons instead of hiding them. Setting available per choice.
- new: Event System: End Turn: 'End Turn' node available in 'Battle > Action' nodes. Ends the turn of a combatant.
- new: Event System: Set Move AI Waypoints: 'Set Move AI Waypoints' node available in 'Combatant > Move AI' nodes. Sets or clears waypoints of a combatant's move AI.
- new: Event System: Use Battle Action: 'Use Battle Action' node is now available in all event types.
- new: Event System: Join Active Group: 'Use Inactive' setting available. Use an inactive member of the active player group to join the group. Only available when using a defined combatant not coming from another group.
- new: Move AI Areas: 'Used In Field' and 'Used In Battle' settings available. Optionally enable/disable the move AI area to be used in the field or in battles. By default enabled for both field and battle.
- new: Interaction Controller: 'Interact With Nearest' settings available. Optionally interact with the interaction nearest to the interaction controller's position (and a defined offset).
- change: Status Values: Experience: 'From Minimum' setting is now also available for 'None' type experiences. Will use the difference to the minimum value when increasing the status value on level up.
- change: Global Events: Calling a global event from items and abilities now use the user as the starting object.
- change: Global Events: Calling a global event from a menu screen item (button menu part) now uses the user of the menu as starting object.
- change: Game Settings: Horizontal Plane: The 'Horizontal Plane' setting now also affects battle rotations (look at) and movement nodes (face direction).
- change: Menu Settings: 'Unfocused Mouse Over' is blocked when the focus is locked to a GUI box (e.g. confirmation dialogues).
- fix: Event System: Progress Research: Fixed an issue where using 'Research Type' scope in 'Progress Research' nodes didn't work correctly.
- fix: GUI Boxes: Choices: Fixed an issue where the initially selected choice wasn't highlighted when using the new UI.
- fix: Move AI: Fixed an issue where changing the group leader while following it could result in still following the old leader.
- fix: New UI: Fixed an issue where not using a prefab for the content box could result in mouse over selection not working correctly.
- fix: Menu Screens: Group: Fixed an issue where using input keys to use the action buttons allowed using an action that otherwise would be prevented (e.g. removing the last member of the battle group).
- fix: Status Effects: Fixed an issue where removing the effect prefabs could cause an error.
- fix: Move AI Areas: Fixed an issue where using multiple 'Allow Move AI' areas could lead to using a wrong position.
- fix: Combatants: Fixed an issue when using text codes in combatant names.
- fix: Combatants: Fixed an issue where the 'Steal Item' settings displayed an empty list for the item selection.
- fix: Object Variables: Fixed an issue where 'Vector 3' variables wheren't saved in the 'Object Variables' component and caused an error in-game.
- fix: Abilities, Items: Raycast: Fixed an issue where the raycast cursor prefab isn't displayed at the mouse position and some settings where hidden.
- fix: Battle AIs: Fixed an issue where disabled nodes where still used.
- fix: Battle AIs: Fixed an issue where 'Force Found Targets' didn't consider out of range targets.
- fix: Grid Battles: Fixed an issue where grid battles could be halted due to no targets being in range of an action.
- fix: Save Games: Fixed an issue where the used text codes where saved as a save game's file info instead of the values they represent. This could lead to save game files displaying wrong information when viewed in a different game run.


Version 2.10.0:
- new: AI Types: 'AI Types' sub-section available in 'Combatants' section. AI types are used to separate AI behaviours and AI rulesets.
- new: AI Behaviours: 'AI Behaviours' sub-section available in 'Combatants' section. AI behaviours are a collection of defined battle AIs, that can be equipped on AI behaviour slots on combatants.
- new: AI Rulesets: 'AI Rulesets' sub-section available in 'Combatants' section. AI rulesets define requirements and rules for a combatant's AI to follow, like using or blocking defined actions or targets (e.g. stop ability use when MP is below 30 %). AI rulesets can be equipped on AI ruleset slots on combatants.
- new: Menu Screens: AI Behaviour: 'AI Behaviour' menu part available. Displays the AI behaviour slots of a combatant and allows changing the equipped AI behaviours (similar to the 'Equipment' menu part).
- new: Menu Screens: AI Ruleset: 'AI Ruleset' menu part available. Displays the AI ruleset slots of a combatant and allows changing the equipped AI rulesets (similar to the 'Equipment' menu part).
- new: Combatants: 'AI Behaviour Slots' and 'AI Ruleset Slots' settings available. Define the AI behaviour and AI ruleset slots of a combatant and optionally equip defined AI behaviours/rulesets. Slots can also be added and removed using the event system.
- new: Combatants: Battle AI: 'Chance' and 'Requirements' settings available for the added battle AIs. Using a battle AI can optionally depend on chance, status requirements and variable conditions.
- new: Combatants: 'Battle Move AI' settings available. Optionally uses a different move AI while a combatant is in battle.
- new: Status Requirements: AI Type: 'AI Type' requirement selection available. Checks if the a combatant has an AI behaviour or AI ruleset of a defined AI type equipped.
- new: Status Requirements: AI Behaviour: 'AI Behaviour' requirement selection available. Checks if the a combatant has a defined AI behaviour equipped.
- new: Status Requirements: AI Ruleset: 'AI Ruleset' requirement selection available. Checks if the a combatant has a defined AI ruleset equipped.
- new: Crafting Recipes: 'Consume Recipe' setting available. Optionally consume a crafting recipe upon using it. If enabled, the recipe will be treated like an item and can be collected multiple times. If disabled, the recipe is treated like knowledge and can only be collected once.
- new: Item Selections: 'AI Behaviour', 'AI Ruleset' and 'Crafting Recipe' type selections available in all item selections (e.g. loot, item collectors). Uses the defined AI behaviour, AI ruleset or crafting recipe to change or check the inventory of a combatant.
- new: Shops: 'AI Behaviour', 'AI Ruleset' and 'Crafting Recipe' settings available. Add the AI behaviours, AI rulesets and crafting recipes that should be sold by a shop.
- new: Game Statistics, Event System: Creating AI behaviours/rulesets and crafting recipes using crafting recipes will be logged by the game statistics. The statistics can be accessed using the event system and text codes.
- new: HUDs: Tooltip: 'AI Behaviour', 'AI Ruleset' and 'Crafting Recipe' settings available in 'Tooltip' type HUDs. Optionally displays the tooltip HUD for AI behaviours and AI rulesets.
- new: Battle System: 'Drop AI' and 'Drop Recipes' settings available in the different battle system settings. AI behaviours/rulesets and crafting recipes gained from defeated enemies can optionally be dropped into the game world instead of collected into the inventory.
- new: Move AI Areas: 'Move AI Area' component available. Optionally declare an area in the scene (using a collider attached to the same game object) as either allowed or not allowed by the move AI. Not allowed areas will block positions within them, while, allowed areas will block positions outside of them. Both will change the targeted position to the nearest allowed position.
- new: Move AIs: Caution: 'Caution Settings' available. A mixture between hunting and fleeing, the combatant will hunt a target until reaching a defined range and flees from the target when being too close.
- new: Move AIs: 'Use Mode' setting available. Defines the default mode of the move AI, either automatically selecting the mode ('Auto'), forcing idle mode (only waypoints), forcing hunting, forcing fleeing or forcing being cautious.
- new: Move AIs: 'Move Range' settings available. Optionally limit movement to a defind range within the start position of the combatant. This overrules other ranges (e.g. hunting range).
- new: Move AIs: Hunting: 'Stop Angle' settings available when using 'Stop Range'. Optionally define an angle at which the target position will be placed relative to the target. E.g. use 90 to move toward the east of the target (world space) or to the right side of the target (local space).
- new: Move AIs: Flee: 'Prevent Cornered' setting available. Optionally try to prevent being cornered or backed up against a wall when fleeing. The combatant will try to move into different directions when it can't move any further.
- new: Move AIs: Flee: 'Flee Range' settings available. Optionally limit fleeing to a defined range within the start position of the combatant.
- new: Move AIs: Flee: 'Stop Range' settings available. Optionally stop fleeing when leaving a defined range around the target the combatant is fleeing from.
- new: Move AIs: Component: Selecting a combatant's game object in the editor while playing will display additional information gizmos. All detected targets will be marked by a yellow wire cube, the used target by a red wire cube. The target position for the movement will be highlighted by a white line from the combatant to the position.
- new: Move AIs, Move To Interaction: 'Poly|Nav 2D' button available when using a 'Custom' component type. Automatically sets up the required component settings for using the 'ORK Poly|Nav 2D' wrapper component.
- new: Battle AIs: Check Move AI Caution: 'Check Move AI Caution' node available in 'Move AI' nodes. Checks if combatants are valid targets for the combatant's move AI caution conditions.
- new: Grid Battles: Cell Selections: 'Camera Direction Offset' setting available when using the camera direction. Define the angle in degrees that will be added to the camera direction. 
E.g. use 45 to shift the selection 45 degrees to the camera view.
- new: Abilities, Items: Raycast Settings: 'Camera Direction Offset' setting available when using the camera direction. Define the angle in degrees that will be added to the camera direction. 
E.g. use 45 to shift the cursor change 45 degrees to the camera view.
- new: Inventory Settings, Abilities: Ability Notifications: 'Ability Notifications' settings available. Learning and forgetting abilities and group abilities can optionally display notifications. The default notifications (set up in the inventory settings) can be overridden by each ability individually.
- new: Game Settings: 'Horizontal Plane' setting available. Defines the general horizontal plane used for the game, e.g. used when spawning members of a group around the leader.
- new: Battle Events: Cancel Death: 'Cancel Death' node available in 'Battle > Combatant' nodes. Cancels the death of the combatant. Only used during battle events of a death action.
- new: Event System: Add AI Behaviour Slot: 'Add AI Behaviour Slot' node available in 'Combatant > AI Behaviour' nodes. Adds AI behaviour slots to a combatant.
- new: Event System: Change AI Behaviour Slot: 'Change AI Behaviour Slot' node available in 'Combatant > AI Behaviour' nodes. Changes the currently equipped AI behaviour of a combatant's AI behaviour slot.
- new: Event System: Remove AI Behaviour Slot: 'Remove AI Behaviour Slot' node available in 'Combatant > AI Behaviour' nodes. Removes AI behaviour slots from a combatant.
- new: Event System: Block AI Behaviour Slot: 'Block AI Behaviour Slot' node available in 'Combatant > AI Behaviour' nodes. Blocks AI behaviour slots of a combatant.
- new: Event System: Add AI Behaviour: 'Add AI Behaviour' node available in 'Combatant > AI Behaviour' nodes. Adds an AI behaviour to a combatant's inventory.
- new: Event System: Remove AI Behaviour: 'Remove AI Behaviour' node available in 'Combatant > AI Behaviour' nodes. Removes an AI behaviour from a combatant's inventory.
- new: Event System: Unequip AI Behaviour: 'Unequip AI Behaviour' node available in 'Combatant > AI Behaviour' nodes. Unequips an AI behaviour from a combatant.
- new: Event System: Add AI Ruleset Slot: 'Add AI Ruleset Slot' node available in 'Combatant > AI Ruleset' nodes. Adds AI ruleset slots to a combatant.
- new: Event System: Change AI Ruleset Slot: 'Change AI Ruleset Slot' node available in 'Combatant > AI Ruleset' nodes. Changes the currently equipped AI ruleset of a combatant's AI ruleset slot.
- new: Event System: Remove AI Ruleset Slot: 'Remove AI Ruleset Slot' node available in 'Combatant > AI Ruleset' nodes. Removes AI ruleset slots from a combatant.
- new: Event System: Block AI Ruleset Slot: 'Block AI Ruleset Slot' node available in 'Combatant > AI Ruleset' nodes. Blocks AI ruleset slots of a combatant.
- new: Event System: Add AI Ruleset: 'Add AI Ruleset' node available in 'Combatant > AI Ruleset' nodes. Adds an AI ruleset to a combatant's inventory.
- new: Event System: Remove AI Ruleset: 'Remove AI Ruleset' node available in 'Combatant > AI Ruleset' nodes. Removes an AI ruleset from a combatant's inventory.
- new: Event System: Unequip AI Ruleset: 'Unequip AI Ruleset' node available in 'Combatant > AI Ruleset' nodes. Unequips an AI ruleset from a combatant.
- new: Event System: Change Move AI: 'Change Move AI' node available in 'Combatant > Move AI' nodes. Changes the move AI used by a combatant.
- new: Event System: Change Move AI Mode: 'Change Move AI Mode' node available in 'Combatant > Move AI' nodes. Changes the use mode of a combatant's move AI.
- new: Event System: Check Move AI Caution: 'Check Move AI Caution' node available in 'Combatant > Move AI' nodes. Checks if combatants are valid targets for the combatant's move AI caution conditions.
- new: Scene Object Components: 'Quest Conditions' settings available. Optionally use quest conditions to determine if a 'Scene Object' component is used.
- new: Battle Grid Components: 'Keep Old Cells' setting available in the grid generation settings. Optionally keeps the cell settings (e.g. cell type) when generating a new grid.
- new: Battle Grid Components: 'Show Unselected' setting available in grid setup. Optionally always show the cell prefabs in the scene view, even when the battle grid isn't selected.
- change: Event System: Crafting: 'Learn Recipe' node has been renamed to 'Add Recipe'. Additional settings for the quantity that will be added (by default 1).
- change: Event System: Crafting: 'Forget Recipe' node has been renamed to 'Remove Recipe'. Additional settings for the quantity that will be removed (by default 1).
- change: Event System: Crafting: 'Knows Recipe' node has been renamed to 'Has Recipe'. Additional settings for the quantity that will be checked for (by default 1).
- change: Event System: Initial Camera Position: The initial camera position will now also restore the initial parent object of the camera.
- change: Move AI: The 'Target Lost Interval' and 'Lost Position Check' settings have been moved from the hunting settings to the target position check settings.
- change: Editor: All 'Ignore Y Distance' fields have been renamed to 'Ignore Height Distance'. Depending on the 'Horizontal Plane' defined in 'Game > Game Settings', either ignores the Y-axis (XZ plane, 3D) or the Z-axis (XY plane, 2D).
- fix: Active Time Battles: Fixed an issue where increasing the timebar (action bar) beyond the maximum timebar value (e.g. using the event system) blocked actions in the next turn of the combatant.
- fix: HUDs: Combatant: Fixed an issue when using icon value bars with limited bar display.
- fix: HUDs: Navigation: Fixed an issue where HUD elements other than separators or cardinal directions wheren't displayed when using the new UI.
- fix: Target Selection: Fixed an issue where clicking on combatants outside of battle wasn't available for target selection (e.g. when using an ability from a 'Shortcut' HUD).
- fix: Battles: Change Member: Fixed an issue where changing the group leader using a 'Change Member' action during teleport battles caused an error message when returning to the previous scene after battle.
- fix: Shops, HUDs: Tooltip: Fixed an issue where selling combatants in a shop could stop 'Tooltip' type HUDs from being displayed in the shop.
- fix: Editor, Menu Screens: Fixed an issue where opening the ORK Framework editor caused errors when stopping a previous play test while displaying a menu screen.
- fix: Player Controls: Fixed an issue where using the camera direction for player movement could result in changed diagonal movement angles when using close camera distances.
- fix: Combatant Spawners: Fixed an issue where variable conditions and quest requirements wheren't checked upon respawning combatants.
- fix: Quests: Fixed an issue where auto finishing a quest task after activating a quest didn't auto activate other tasks depending on it.
- fix: Event System: Can Use Recipe: Fixed an issue where the 'Can Use Recipe' node's results where inversed.


Version 2.9.1:
- new: Unity 5.5: ORK Framework now supports and requires Unity 5.5.
- new: Move AIs: Waypoint Settings: 'Horizontal Plane' setting available when using 'Random Patrol'. Defines the axes that will be used as horizontal plane (i.e. horizontal movement of the game objects), either XZ (default 3D behaviour) or XY (default 2D behaviour).
- fix: Status Effects: Fixed an issue when reapplying a status effect using end after 'None'.
- fix: Move AI: Fixed an issue that lost the target when using raycast enemy detection.
- fix: HUDs: GUI Editor: Fixed an issue when editing 'Combatant' type HUDs using element requirements in the GUI editor.


Version 2.9.0:
- new: Research Types: 'Research Types' sub-section available in 'Combatants' section. Research types are used to separate research trees.
- new: Research Trees: 'Research Trees' sub-section available in 'Combatants' section. Like ability trees, research trees allow adding 'Research Items' to them. They can teach new abilities, upgrade status values, create new items, equipment or currency, or be used as requirements. Beside immediately finishing research, it can also take a defined amount of time or manually progress using the event system.
- new: Menu Screens: Research: 'Research' menu part available. Displays the research trees of a combatant, optionally separated by research types.
- new: Menu Screens: Group: 'Own Button Content' settings available in the 'Action Box' buttons in 'Group' menu parts. Optionally override the default button content (text, description, icon) of default buttons (e.g. 'Back' button).
- new: Menu Screens: Game Event Settings: 'After Fading' setting available in the 'Close Game Event' settings. Defines if the close game event is started after fading out the menu screen or with fading out. By default enabled.
- new: Status Requirements: Research Tree: 'Research Tree' requirement selection available. Checks if a combatant knows a research tree or if it's completed (i.e. fully researched).
- new: Status Requirements: Research Item: 'Research Item' requirement selection available. Checks the state of a combatant's research item or the number of times it has been researched.
- new: Status Requirements: Weapon, Armor: 'Level' setting available for 'Weapon' and 'Armor' status checks. The equipped weapon/armor must at least have the defined level. By default set to 1.
- new: Camera Controls: Top Down Border: 'Rotation' settings available. Optionally rotate the camera by using input keys or mouse/touch controls. Can be enabled separately for field and battle.
- new: Camera Controls: Top Down Border: 'Panning' settings available. Optionally pan the camera from the player using input keys or by moving the mouse cursor to screen edges. Can be limited to a defined distance to the player.  Can be enabled separately for field and battle.
- new: Camera Controls: Top Down Border: 'Zoom' settings available. Optionally zoom the camera by using input keys.  Can be enabled separately for field and battle.
- new: Player Controls: Button: 'Camera Direction Offset' setting available. Define the angle in degrees that will be added to the camera direction. 
E.g. use 45 to shift the movement 45 degrees to the camera view.
- new: Game Settings: Player Group Notifications: 'Player Group Notifications' settings available. Optionally display notifications when a combatant joins or leaves the player group. Can be overridden by each combatant individually.
- new: Control Maps: Attack: 'Use Current Attack' setting available. Uses the current base attack (index) of the combatant.
- new: Console: 'Research Texts' settings available. Display console texts for adding/removing research trees and starting, canceling or finishing research of a research item. Can optionally be overridden by each research tree individually.
- new: Console: New text codes in learn texts, forget texts and quest texts. Use '%ud' to display the user's description, '%ui' to display the user's icon and '%d' to display the content's description (e.g. of a learnt ability).
- new: Console, Combatants: 'Player Group Texts' settings available. Display console texts for combatants joining/leaving the player group. Can optionally be overridden by each combatant individually.
- new: Console: 'Enabled' setting available in all console texts. The different console texts can now be enabled/disabled individually.
- new: Inventory Settings: Notifications: 'Research Notifications' settings available. Optionally display notifications for adding/removing research trees and starting, canceling or finishing research of a research item. Can optionally be overridden by each research tree individually.
- new: Inventory Settings: Item Box: 'Take All Button' settings available. Optionally add a button to collect everything from an item box.
- new: Inventory Settings: Item Box: 'Item List Text' settings available. Optionally display the items of the item box as a text list instead of buttons for each item. The item box dialogue will be similar to the item collection dialogue, using the ok/cancel buttons (or optionally 2 choice buttons) to collect all items.
- new: HUDs: Information: 'Click Action' settings available for HUD elements of 'Information' type HUDs. Optionally call a global event or menu screen when clicking a HUD element.
- new: HUDs: Combatant, Turn Order: 'Is Menu User' and 'Is Shop User' settings available when using HUD element requirements. Optionally only displays a HUD element when the displayed combatant is the user of an open menu or shop.
- new: Save Game Menu: Save Settings: 'Save Battle Gains' setting available. Defines if uncollected battle gains will be saved in save games.
- new: Save Game Menu: Save Settings: 'Save Camera Position' setting available when saving 'Group' and 'Group Positions'. Optionally saves the camera position, rotation and field of view in save games. By default enabled.
- new: Abilities, Items: Raycast Settings: 'Control Block' settings available. Optionally block the player or camera control while selecting a raycast target.
- new: Abilities, Items: Raycast Settings: 'Cursor Object' settings available. Optionally display a cursor at the raycast position.
- new: Abilities, Items. Raycast Settings: 'Input Key' settings available when using a cursor object. Optionally move the raycast cursor using input keys, using the current cursor position with the 'Accept' key.
- new: Abilities, Items: Raycast Settings: 'User Highlight' settings available. Optionally highlight the user of the ability/item during raycast target selection. The user can be highlighted by a cursor (e.g. showing the use range of the ability), blinking the game object and blinking the HUD.
- new: Menu Settings: Drag/Drop Settings: 'Raycast Settings' available. Defines the raycast's distance and layer mask used for dropping content into the game world.
- new: Menu Settings: 'Unfocused Mouse Over' setting available when using 'Mouse Over Selection'. Optionally also uses mouse over selection for unfocused GUI boxes.
- new: Battle Settings: Target Selection: 'Raycast Settings' available in the 'Mouse/Touch Control' target selection. Defines the raycast's distance and layer mask used for finding combatants on the clicked/touched position.
- new: Battle Range Templates: Grid Shape: 'Line of Sight' settings available. Optionally use line of sight between the origin and target cell to determine if they're used. Line of sight can be blocked by blocked cells, defined battle grid cell types, allied or enemy combatants.
- new: Battle Menus: User Highlight: 'User Highlight' settings available in battle menus. Optionally highlight the user of the battle menu while it's opened. The user can be highlighted by a cursor, blinking the game object and blinking the HUD.
- new: Battle System: Battle Gains: 'Collect Loot' and 'Collect Experience' settings available when using 'Collect Immediately'. Collects the loot and experience gains when collecting battle gains immediately after defeating an enemy. The disabled gains will be kept for later collection. By default enabled.
- new: Battle System: Real Time Battles: 'Leave Area Settings' available in real time battle settings. Define what happens when the player leaves a real time battle area. Currently only contains settings for battle gains collection.
- new: Battle Grid Settings: Combatant Placement: 'Select Battle Group' setting available. Optionally use the 'Combatant Placement' selection for placing the player's battle group on the grid to select the members of the battle group. If enabled, you'll be able to select the battle group members out of all members of the active player group. Otherwise you can only place the members of the battle group as is.
- new: Battle Animations: 'Requirements' settings available. Performing a battle event in a battle action (e.g. using an ability, grid move command, etc.) can optionally depend on status requirements and variable conditions.
- new: Status Effects: Effect End: 'Turn Start' and 'Turn End' selections available in the 'End After' setting. 'Turn Start' replaces the previous 'Turn' selection, ending the effect at the start of the turn. The new 'Turn End' selection will end the effect at the end of a combatant's turn.
- new: Status Effects: Status Conditions: 'Apply', 'Remove', 'Turn Start' and 'Turn End' selections available in the 'Set On' setting. 'Apply' replaces the previous 'Cast' selection, using the condition when applying the effect. 'Remove' uses the condition when removing the effect. 'Turn Start' replaces the previous 'Turn' selection, using the condition at the start of a turn. 'Turn End' uses the condition at the end of a combatant's turn.
- new: Combatant Selections: 'Show Hidden Members' setting available. Optionally display hidden group members in a combatant selection.
- new: Combatants: 'Buy Price' setting available. Defines the default price a combatant is sold for in shops. Shops can override this price.
- new: Combatants: Animation Settings: 'Use Speed Change Delay' settings available. Optionally delay animation changes caused by speed changes exceeding a defined value. Use this to prevent unwanted animation changes due to short speed changes (e.g. when an idle animation is played between two movement nodes due to the short stop).
- new: Loot: 'Use First Found Table' setting available. Uses the first found loot table matching the combatant's level. If disabled, every matching loot table will be used. By default enabled.
- new: Shops: Combatants: Shops now allow selling combatants to the player. Combatants added to a shop will join the player's group when being bought.
- new: Shops: Loot: 'Loot' settings available in shops. Use loot tables to fill a shop's stock. Only loot tables matching the player's level will be used. Only items, weapons and armors will be added to the shop, currency will be ignored.
- new: Shops: Currency Settings: Define all currency/price related settings. New settings for custom buy/sell price modifiers and price rounding.
- new: Shop Layouts: List Box: 'Combatant Content Layout' settings available in the 'List Box' settings. Optionally use a different content layout for buttons representing combatants. Allows either using the default combatant choice layout or overriding it with a custom layout - both support displaying complex information using HUD elements.
- new: Shop Layouts: 'Buy Combatant Info' settings available. Optionally display a detailed information box about a combatant that can be bought in a shop. Can either be used as a HUD (only displaying the info while a combatant is selected) or as a details dialogue (being shown after accepting a selected combatant).
- new: Shop Layouts: 'Buy Question' settings available. Optionally display a question dialogue to confirm buying items. The question dialogue will be displayed after the quantity selection.
- new: Shop Layouts: 'Sell Question' settings available. Optionally display a question dialogue to confirm selling items. The question dialogue will be displayed after the quantity selection.
- new: GUI Boxes: Choice Settings: 'Info Separation' settings available. Optionally separate content and info of the choice (which would otherwise overlap each other).
- new: Event System: Add Research Tree: 'Add Research Tree' node available in 'Combatant > Research' nodes. Adds research trees to a combatant.
- new: Event System: Remove Research Tree: 'Remove Research Tree' node available in 'Combatant > Research' nodes. Removes research trees from a combatant.
- new: Event System: Progress Research: 'Progress Research' node available in 'Combatant > Research' nodes. Progresses the research of research items of a combatant. Optionally limits the progress to 'Manual' or 'Time' research durations.
- new: Event System: Has Research: 'Has Research' node available in 'Combatant > Research' nodes. Checks if a combatant has available research based on research item states. E.g. use this to check if a combatant has research items currently in research. Can optionally be limited to defined research types.
- new: Event System: Collect Battle Gains: 'Collect Loot' and 'Collect Experience' settings available. Define if the loot (items, equipment, currency) and status value rewards (experience, normal SV gains) will be collected. The disabled gains will be kept for later collection. By default enabled.
- new: Event System: Call Menu Screen: 'Select Combatant' settings available in 'Call Menu Screen' nodes. Optionally call a combatant selection to select the menu user before calling the menu screen.
- new: Event System: Add Experience Reward: 'Split Experience' setting available in 'Add Experience Reward' nodes. Optionally split the experience reward through the number of group members (either battle group or wohle group, based on the 'Whole Group' setting in 'Battle System > Battle End').
- new: Event System: Add To Shop: 'Add To Shop' node available in 'Game > Shop' nodes. Adds items, weapons, armors, abilities or combatants to a shop (using the shop's 'Scene ID'). Only used by shops that have 'Save Shop' enabled in their settings.
- new: Event System: Check Shop Stock: 'Check Shop Stock' node available in 'Game > Shop' nodes. Checks the number of different items in a shop. Only used by shops that have 'Save Shop' enabled in their settings.
- new: Event System: Clear Shop Data: 'Clear Shop Data' node available in 'Game > Shop' nodes. Either removes all all content from a stored shop (making the shop empty) or removes the stored shop (resetting it). Only used by shops that have 'Save Shop' enabled in their settings.
- new: Event System: Enable Auto Attack: 'Enable Auto Attack' node available in 'Battle > Action' nodes. Enables, disables or toggles the auto attack state of a combatant.
- new: Battle Events: End Battle Action: 'End Battle Action' node available in 'Battle > Action' nodes. Ends the battle action after the running event. All battle events of the action that would run after this event will be removed.
- change: Spawn Points: A random spawn point with the used 'Spawn ID' will be used when multiple spawn points with the same 'Spawn ID' are in a scene. Until now, the first found spawn point with the same 'Spawn ID' has been used.
- change: Event System: Call Global Event: The 'Call Global Event' step is now available in all event types.
- change: Event System: Battle Gains: All 'Battle Gains' nodes are now available in all event types.
- change: Battle System: The battle gains are no longer automatically collected at the end of arena battles (using the 'Battle' component). If the battle gains aren't collected in the battle end event, they'll be kept until they're collected or cleared out later.
- change: Abilities, Items: Raycast Settings: Selecting a raycast target is no longer possible outside of the defined use range of the ability/item.
- change: Combatant Choice Layout: 'Add HUD Elements' setting replaced the 'Complex HUD Display' setting. You can now use the content layout and HUD elements at the same time. Previously you could only use either content layout or HUD elements.
- change: Battle Grids: Editor: Improved performance when editing larger battle grids in the scene view.
- fix: Battle Bonuses: End Battle Bonus: The 'Battle End Bonus' will now only be applied after a battle, not on combatants that leave the battle.
- fix: Battle Bonuses: Revive After Battle: The 'Revive After Battle' bonus will now only be applied to the player group.
- fix: HUDs: Combatant: Fixed an issue where the title (using the combatant's name) didn't get updated after the combatant's name changed (e.g. receiving a number/letter from the 'Enemy Counter' setting).
- fix: Combatants: Loot: Fixed an issue where the currency from the start inventory was always added in addition to any other loot (loot tables or start inventory).
- fix: Sound Volume: Fixed an issue where some audio clips didn't consider the sound volume (e.g. notification sounds).
- fix: Battle System: Active Time: Fixed an issue where 'Pause On Menu' didn't pause the timebar progress when 2 or more combatants had their battle menu open at the same time.
- fix: Abilities, Equipment: Variables: Fixed an issue where upgrading to a new ability/equipment level didn't use the defined variable changes.
- fix: GUI Boxes: Fixed an issue where some content box anchor selections could initially place the GUI box at the wrong position when using the new UI.


Version 2.8.0:
- new: Unity 5.4: ORK Framework now supports Unity 5.4. This will be the last version supporting Unity 5.3.
- new: Grid Battles: Battles in all battle system types can be fought on a 'Battle Grid'. Only available in arena battles (i.e. when a 'Battle' component is involved, not in 'Real Time Battle Areas').
- new: Battle Grid Component: 'Battle Grid' component available. This component is used to set up grids in your scenes to be used by grid battles.
- new: Battle Component: 'Grid Use Type' setting available. Defines if and which battle grid the battle will use. Uses the nearest grid by default.
- new: Battle System: Battle Grid Settings: New sub-section to define general battle grid settings. Defines the grid type, cell selections, grid commands and grid highlights.
- new: Battle System: Grid Cell Types: New sub-section for creating grid cell types. Grid cell types are used by the 'Battle Grid' component to define how the individual cells of the grid will look and work (e.g. blocked cells, move costs, etc.).
- new: Battle System: Battle Range Templates: Define range templates to be used by abilities and items for use/affect ranges. You can define a min and max range and grid shapes for grid battles.
- new: Game Controls: Interaction Settings: 'Interact Key' setting available. Defines the input key used to start interactions. The 'Accept Key' no longer starts interactions. Automatically updates previous settings to use the same input key.
- new: Status Values: Experience: 'Class Development' setting available for 'Experience' type status values using the 'None' experience type. Optionally binds the 'None' experience's max value to the class development, i.e. it'll increase upon class level up instead of base level up.
- new: Abilities, Items, Battle Settings: Use/Affect Range: The use/affect ranges of abilities and items have been replaced by new settings. You can now either use 'None' to not use a range, 'Template' to use a battle range template or 'Custom' to define a custom range. Old settings will be automatically updated to 'Custom' ranges and can be converted to templates through a button.
- new: Abilities, Items, Battle Settings: Use Range: 'Default Range' settings available. Use ranges per battle system type are now optional. If the use range for individual battle system types isn't defined, a default range will be used.
- new: Abilities, Items: Affect Range: The affect range can now be set up for individual battle system types like the use range.
- new: Abilities, Items, Control Maps, Game States, Target Selections: 'Grid Battles' state condition available. Defines if a battle grid is required, e.g. using a battle event only when in a grid battle. By default set to 'Ignore' (i.e. available in both with and without a grid).
- new: Turn Based Battles, Phase Battles, Abilities, Items: 'Use Remaining' setting available in action cost settigns. Optionally use the remaining actions per turn of a combatant - the defined cost will be used as a minimum cost.
- new: Animation Types: 'Turn Ended Idle Type' animation type available. Select an animation type that will be used for the idle animation when a combatant's turn ended (i.e. when the combatant finished all actions). By default uses animation type ID 0.
- new: Battle Menu: 'Grid Move' menu item type available. Adds a button for the grid move command to the battle menu. Selecting it in the battle menu will start the target cell selection.
- new: Battle Texts: 'Grid Move Info' settings available. Optionally display a battle info text when a combatant performs a grid move action.
- new: Console Settings, Combatants: 'Grid Move Text' settings available. Define texts that will be added to the console when a combatant performs a grid move action. Combatants can optionally override the default text.
- new: Combatants: 'Base Grid Move Range' setting available. Combatants can optionally override the default grid move range defined in the 'Battle Grid Settings'. The grid move range defines how far a combatant can move on the grid using the move command.
- new: Combatants: Battle Animations: 'Own Grid Move Animation' settings available. Combatants can optionally override the default grid move animation (battle event) defined in the 'Battle Grid Settings'. The grid move animation defines how a combatant will be animated when moving on the grid to a target cell.
- new: Status Bonuses: 'Grid Move Range Bonus' setting available. Defines a bonus added to a combatant's grid move range.
- new: Status Values: Experience: 'Rounding' setting available in 'Level Difference Factor' settings. Define how the experience will be rounded after being multiplied by the level difference factor.
- new: Status Requirements: 'Turn Ended' requirement selection available. Checks if a combatant's turn has ended or not (i.e. finished all actions). This can be used to e.g. have an ability only target combatants that haven't yet finished their turn.
- new: Control Maps, HUDs: 'Auto Target Only' setting available in control map keys and 'Shortcut' HUD elements ('Combatant' type HUDs). Optionally only use auto targets for abilities/items that have 'Use Auto Target' enabled in their settings.
- new: Formulas: Check Grid Distance: 'Check Grid Distance' step available in 'Position' steps. Checks the distance on the grid between the user and target.
- new: Battle AI: Ability: 'Use Random Ability' settings available in the 'Ability' battle AI step. Optionally use a random ability known by the combatant instead of a defined ability. Can also be limited to a defined ability type.
- new: Battle AI: Item: 'Use Random Item' settings available in the 'Item' battle AI step. Optionally use a random item in the combatant's inventory instead of a defined item. Can also be limited to a defined item type.
- new: Battle AI: 'Exclude Self' setting available for 'Ally' and 'All' target ranges. Excludes the user combatant from the targets.
- new: Battle AI: Grid Move: 'Grid Move' step available in 'Action' steps. Uses the 'Grid Move' command to move the user on the grid, e.g. toward a target.
- new: Battle AI: Check Grid Distance: 'Check Grid Distance' step available in 'Position' steps. Checks the distance on the grid between the user and targets.
- new: Battle AI: Grid Rotate To Target: 'Grid Rotate To Target' step available in 'Position' steps. Rotates the user to face a target on the grid.
- new: Battle AI: Attack, Ability, Class Ability, Item: 'Need Targets' setting available. Valid targets within use range of the action must be found, otherwise the action will not be used.
- new: Event System: Start Battle: You can optionally add additional combatants (from game objects) to join the battle that is started.
- new: Event System: Change Equipment: 'Keep Unequipped' setting available in the 'Change Equipment' step. Handles if unequipped weapons or armors will be returned to the combatant's inventory or lost. By default enabled (i.e. returning equipment to inventory).
- new: Event System: Change Position: 'Stop At Target' setting available when moving by speed. Optionally stops the movement when reaching the target, i.e. it can't move past it (e.g. overshooting due to high speed). By default disabled.
- new: Event System: Call Menu Screen: 'Menu Screen User' settings available. Optionally set the combatant that will be the user of the called menu screen.
- new: Event System: Equipment Viewer Combatant: 'Equipment Viewer Combatant' step available in 'Combatant > Equipment' steps. All 'Equipment Viewer' components of a game object will check for a combatant (through a 'Combatant Component').
- new: Event System: Set Battle Grid: 'Set Battle Grid' step available in 'Battle > Grid' steps. Sets the grid for a running battle.
- new: Event System: Show Battle Grid: 'Show Battle Grid' step available in 'Battle > Grid' steps. Shows or hides the current battle's grid or a grid on a defined game object.
- new: Event System: Is Grid Battle: 'Is Grid Battle' step available in 'Battle > Grid' steps. Checks if the current battle is a grid battle (i.e. using a 'Battle Grid' component).
- new: Event System: Player Grid Placement: 'Player Grid Placement' step available in 'Battle > Grid' steps. Starts the grid placement selection for player combatants.

- new: Event System: Place On Grid: 'Place On Grid' step available in 'Battle > Grid' steps. Place combatants participating in this battle at the nearest free grid cell. Only combatants that aren't yet placed on the grid will be used.
- new: Event System: Check Grid Path Length: 'Check Grid Path Length' step available in 'Battle > Grid' steps. Checks the remaining length of a move action's grid path.

- new: Event System: Store Grid Path: 'Store Grid Path' step available in 'Battle > Grid' steps. Stores the next (or all) cell's game object of a move action's grid path into a found/global object.
- new: Event System: Remove Grid Path: 'Remove Grid Path' step available in 'Battle > Grid' steps. Removes the next (or all) cell of a move action's grid path.
- new: Event System: Is Grid Cell Empty: 'Is Grid Cell Empty' step available in 'Battle > Grid' steps. Checks if a battle grid cell on a game object is empty (i.e. no combatant is occupying it).
- new: Event System: Check Grid Distance: 'Check Grid Distance' step available in 'Battle > Grid' steps. The distance between two grid cells is checked against a value.
- new: Event System: Is Grid Cell Blocked: 'Is Grid Cell Blocked' step available in 'Battle > Grid' steps. Checks if a battle grid cell on a game object is blocked (i.e. 'Blocked' enabled in the settings of the grid cell type).
- new: Event System: Set Grid Cell Combatant: 'Set Grid Cell Combatant' step available in 'Battle > Grid' steps. Set's a combatant to occupy a battle grid cell. Only possible if the combatant is spawned and the cell is not blocked and currently not occupied by another combatant.
- new: Event System: Grid Direction Rotation: 'Grid Direction Rotation' step available in 'Battle > Grid' steps. Sets or fades a game object using grid directions. The directions depend on the used battle grid type, e.g. the 'Square' type has 4 directions.
- new: Event System: Grid Orientation Selection: 'Grid Orientation Selection' step available in 'Battle > Grid' steps. Calls the orientation selection for a combatant. AI controlled combatants (e.g. enemies) will automatically select an orientation based on their AI settings.
- new: Event System: Grid Cell Event: 'Grid Cell Event' step available in 'Battle > Grid' steps. Performs grid cell events on a grid cell.
- new: Event System: Change Grid Move Range: 'Change Grid Move Range' step available in 'Battle > Grid' steps. Changes the grid move range of a combatant.
- change: Event System: Actors: Actors now use the game object's name in dialogues if no other name (scene object, setting name, etc.) is found.
- change: Combatants: Code: Most battle functionality (e.g. turns, turn values, etc.) have been moved from the 'Combatant' class to the new 'CombatantBattle' class for better organization. The functionality can be accessed through the 'Battle' property of a combatant in case you need it in your custom scripts.
- change: Abilities, Items: 'Affect Range' toggle has been replaced by a popup selection. Select 'None' for not using affect range, 'Calculation' to select affected targets each time the outcome is calculated, or 'Execution' to select affected targets when the action is started. 'None' is selected by default, previous settings using affect range will be set to 'Calculation'.
- fix: Menu Screens: Fixed an issue where calling a sub-menu using the same input key as the 'Accept' key could cause an error message.
- fix: Battle Events: Prefabs: Fixed an issue where setting a battle event's prefabs in ability/item animation settings could result in weird behaviour with spawned prefabs.
- fix: Animations: Fixed an issue where animations could freeze when changing equipment in a menu screen that paused the game using 'Freeze Pause'.
- fix: Battle System: The game object with the 'Battle' component attached will now be destroyed after teleport battles (i.e. battles in a different scene).
- fix: Combatants, Ability Developments: Fixed an issue where using an ability development didn't add the abilities to the combatant.
- fix: Event System: End Battle: Fixed an issue where using 'Escape' in the 'Battle End' step didn't work when not using 'End Immediately' in the battle system.
- fix: Save Games: Group Shortcuts: Fixed an issue where group shortcuts where not loaded correctly.
- fix: Battle Menus: Fixed an issue where the battle menu could be shown at the wrong position when using the new UI.
- fix: HUDs: Combatant: Fixed an issue where 'Shortcut' elements hidden by display requirements could be assigned through drag and drop and display tooltips.


Version 2.7.2:
- new: Game Settings: 'Start Volume Settings' available in the game settings. Define the music volume and sound volume that will be used when ORK is initialized.
- new: Formulas: Inventory Quantity: 'Inventory Quantity' step available in 'Combatant' steps. Uses the quantity of an item, equipment or currency in a combatant's inventory to change the formula's value.
- new: Status Values: Console Texts: 'Ignore 0 Damage' setting available. Console texts optionally wont be displayed when a damage of 0 (i.e. no real damage) was made.
- new: Event System: Spawn Combatant: 'Spawn Combatant' step available in 'Combatant > Combatant' nodes. Spawns a combatant or combatant group at a defined position.
- new: Event System: Call Menu Screen: 'Wait' setting available in 'Call Menu Screen' nodes. Waiting for the menu screen to be closed before the event continues is now optional. By default enabled.
- new: Battle AI: Use Last Targets: 'Use Last Targets' step available in 'Base' nodes. Adds the last targets of the user to the found targets list.
- change: Status Effects: Auto effects now only stack once per source, e.g. an auto effect applied from an equipped armor will now only stack once per equipped piece.
- change: Status Effects: Stacked effects not coming from auto effects will now be removed when their time/turns run out even when the same status effect is applied as an auto effect.
- fix: Status Effects: Fixed an issue where 'Auto Remove' didn't remove (or prevent applying) status effects that where added from auto effects.
- fix: GUI: New UI: Fixed an issue where mixing shadow and outline could result in text flickering.
- fix: Menu Screens: Ability: Fixed an issue where learning a new ability through a different menu screen/part didn't update the ability list.
- fix: Editor: Abilities: Fixed the name of the 'Phase Action Cost' settings, it was previously also named 'Turn Action Cost'.
- fix: Move AIs: Fixed an issue where combatants joining a battle could shortly be moved by the move AI, although it should be blocked for combatants in battle.
- fix: Editor: Text Editor: Fixed an issue where the resource icon selection in the text editor wasn't displayed.
- fix: Editor: Inspectors: Fixed an issue where some settings of the 'Key Press' start type of interactions wheren't displayed correctly.
- fix: Editor: Fixed an issue with the test calculation foldouts in formulas.
- fix: Menu Screens: Fixed an issue where an error occured when using certain default menu actions (e.g. 'Crafting List' in inventory menu parts).
- fix: Menu Screens: Fixed an issue where some selections could interupt the 'One' and 'Sequence' box handling (e.g. equipment part).
- fix: Menu Screens: Ability, Inventory: Fixed an issue where removing a reuse block (e.g. after time) didn't refresh the displayed content.
- fix: New UI: Fixed an issue where mixing portrait with not-portrait choices could result in images being removed in different GUI boxes afterwards.
- fix: New UI: Fixed an issue where GUI boxes could be displayed with wrong bounds for a frame when opened.


Version 2.7.1:
- new: HUDs: Interaction: New text codes for 'Interaction' type HUDs available. Display the type's name ('%tn'), description ('%td') or icon ('%ti') - the type can be the scene object type or class of a combatant.
- new: HUDs: Combatant: 'Use Equipment Variables' setting available in 'Equipment' HUD elements of 'Combatant' type HUDs. Optionally uses variables attached to the displayed equipment for game variable text codes.
- new: HUDs: Combatant: Level points and durability text codes available in 'Equipment' type HUD elements of 'Combatant' type HUDs. Display an equipment's level points and durability information in text using various new text codes.
- new: HUDs: Combatant: 'Use Bar' settings available in 'Equipment' type HUD elements of 'Combatant type HUDs. Optionally display a bar for the equipments level points or durability instead of a text.
- new: UI: Content Layout: 'Hide Empty Info' setting available. Optionally hide the info text of choice buttons if the actual info is empty, i.e. if the content displayed through the '%', '%l' or '%lvl' text codes is empty.
- new: Menu Screens: Bestiary (Area), Bestiary (Type): 'Entry Navigation Keys' settings available. Optionally navigate the bestiary entry using input keys while displaying a bestiary entry.
- new: Menu Screens, Shops: 'Play Audio' setting available for type/page change keys. Defines which audio clip of the GUI box will be played when using the input keys to change the type of page. Defaults to 'Cursor' for type and 'Accept' for page changes.
- new: Menu Screens: 'Allow Non-Player' setting available. Optionally allow non-player combatants to be displayed by a menu screen, e.g. through a click on their HUD or custom scripts.
- new: Event System: Set Battle Scene ID: 'Remove ID' setting available. Removes/unsets the scene ID of the 'Battle' component the battle is using. This can be used in battle end events to make the battle available again.
- new: Event System: Change Scene ID: 'Change Scene ID' step available in 'Game > Scene' steps. Changes scene ID state for items or battles in a defined scene.
- new: Battle Events: The 'Calculate' step will now use the optional 'Miss' next slot when an escape action failed.
- change: Menu Screens: Closing a menu screen without returning to the screen that called it (e.g. using 'Close After Use' and 'Don't Return' in 'Inventory' parts) will now notify events that originally called the menu screen (i.e. using the 'Call Menu Screen' part).
- fix: GUI Boxes: Portraits: Fixed an issue where portraits could cause flickering/disappearing images.
- fix: GUI Editor, Variables: Fixed an issue where changing global variables in formulas of a combatant could throw errors in the GUI editor when the combatant is used to display a HUD.
- fix: Scene Loading: Fixed an issue when using 'Additive' scene load mode.
- fix: Save Game Menu: Fixed an issue where the settings for loading a defined scene in save games when not saving the player group's position wasn't displayed.
- fix: UI: Value Bars: Fixed an issue where displaying a bar with 0 value range (e.g. a status value of a combatant with a max value of 0) resulted in wrongly displayed value bars.
- fix: Scene Objects: Fixed an issue where the cursor was displayed outside a scene object when it was parented on something else.
- fix: Real Time Battles: Fixed an issue where actions fired while being in action could lead to them only be started when the next action was added to the battle system (i.e. unwanted delays).
- fix: HUDs: Tooltip: Fixed an issue where tooltips of game objects wheren't removed when moving the cursor out of the game object when no other game object was hit by the raycast (e.g. due to not being on a layer checked by the 'HUD Layer Mask').


Version 2.7.0:
- new: Event System: Selected Data: 'Selected Data' feature available in the event system. You can set any kind of information as selected data (e.g. game objects, combatants, items, abilities, etc.) and use them elsewhere, e.g. to change variables or use game objects that are selected. Different selected data can be set by using different 'Selected Key' to identify them. Selected data is shared with formulas that are called by the event.
- new: Event System: Variables: 'Selected' variable origin available. Uses variables possibly attached to the selected data of the running event. Selected data can e.g. be a combatant, game object, ability or item. In battle events of ability/item actions, the used ability/item will automatically be set as selected data.
- new: Event System: Objects: 'Selected Data' object selection available in all game object selections. Uses game objects that are stored as selected data.
- new: Abilities: 'Ability Variables' settings available. Ability variables are attached to abilities of combatants or groups. They can be used in events and formulas by using the 'Selected' variable origin if they are set as selected data of the event. Battle events of the ability automatically set it as selected data.
- new: Items: 'Item Variables' settings available. Item variables are attached to individual items. They can be used in events and formulas by using the 'Selected' variable origin if they are set as selected data of the event. Battle events of the item automatically set it as selected data.
- new: Weapons, Armors: 'Equipment Variables' settings available. Equipment variables are attached to individual weapons and armors. They can be used in events and formulas by using the 'Selected' variable origin if they are set as selected data of the event.
- new: Formulas: Variables: 'Local' variable origin available. Formulas can now use local variables. Local variables are only available while the formula is calculating - once the formula finished calculating, the variables will be gone. If a formula was called by an event, it'll share the local variables with the event.
- new: Formulas: Variables: 'Selected' variable origin available. Uses variables possibly attached to the selected data of the running event that called the formula. When used by abilities or items without being animated by battle events, the ability/item will be the selected data.
- new: Formulas: Float Values: 'Current Value' float value type available. Uses the current value of the formula as value.
- new: Ability Developments: 'Ability Developments' sub-section now available in the 'Status' section. Ability developments define when a class/combatant will learn an ability at what level or class level. Classes/combatants can select which ability developments they'll use, and add additional abilities (like until now).
- new: Input Keys: 'Axis Factor' setting available. Defines a factor used to multiply the axis value with. By default set to 1.
- new. Input Keys: 'Limit Axis' settings available. Optionally limits the value of an axis. E.g. use this to only use the positive or negative value of an axis. By default disabled.
- new: Game Controls: Move To Interaction: 'Move To Interaction' settings available in 'Base/Control > Game Controls' in the 'Interaction Settings'. Optionally moves the player to an interaction before starting the interaction. Supports simple movement, NavMesh agents and custom move components. Movement can optionally be cancelled.
- new: Interaction Components: 'Move To Interaction' settings available. Optionally disable 'Move To Interaction' for an interaction, or override the default interaction radius and stop distance. Also allows defining a game object as movement destination for the player to move to.
- new: Item Collectors: 'Game Event Settings' available. Optionally execute a game event before and/or after item collection. The 'Start Game Event' will be used before starting the collection. The 'End Game Event' will be used after the collection, but before changing variables or destroying the game object.
- new: Scene Objects, Scene Object Types: 'Cursor Change' settings available. Scene objects can optionally change the cursor when the mouse is over the game object with a 'Scene Object' component attached (requires a collider). Scene objects can override the cursor defined in scene object types.
- new: Scene Objects, Scene Object Types: 'Use Object Variable Text Codes' setting available. Optionally uses object variables instead of global variables for game variable text codes in the name and description of scene objects and scene object types.
- new: Scehe Object Components: 'Custom Text Codes' settings available. Optionally define custom text codes and the values used to replace them in 'Scene Object' components. They can be used in the names and descriptions of scene objects and scene object types.
- new: Phase Battles: 'Combatant Order' settings available. Defines the order in which members of a faction will perform their actions in their phase. Either uses a formula to calculate a value for sorting or sorts by name or ID of the combatants. 'None' sorting is used by default.
- new: Phase Battles: Combatant Choice: 'Use Combatant Choice' setting available. Displaying the combatant choice for player controlled combatants is now optional. If disabled, the combatants will get their turn based on the 'Combatant Order' settings. By default enabled.
- new: Status Requirements: 'Is Choosing' requirement selection available. Checks if a combatant is or isn't choosing actions (e.g. when displaying the battle menu). This can be used to e.g. only display a 'Combatant' HUD for the player combatant who is currently selecting actions in the battle menu.
- new: HUDs: Tooltip: 'Scene Object Type' settings available when displaying the HUD for scene objects. Optionally only displays the HUD for defined scene object types instead of all scene objects. This can be used to have different tooltips for different types of scene objects (e.g. for opening item boxes or talking to NPCs).
- new: Main Menu: 'Load Scene Mode' and 'Load Async' settings available for the 'Main Menu Scene' and 'New Game Scene'. Defines how the scene will be loaded - either 'Single' or 'Additive', optionally loads the scene asynchronously.
- new: Save Game Menu: 'Load Scene Mode' and 'Load Async' settings available. Defines how the scene of a save game will be loaded - either 'Single' or 'Additive', optionally loads the scene asynchronously.
- new: Scene Changers, Game Over Settings: 'Load Scene Mode' and 'Load Async' settings available. Defines how the scene (game over scene, scene changer) will be loaded - either 'Single' or 'Additive', optionally loads the scene asynchronously.
- new: GUI Boxes: Name Box: 'Name Vertical Alignment' setting available when not using 'Adjust Height' in the 'Name Box' settings. Display the name content at the 'Top', 'Middle' or 'Bottom' of the content area of the name box.
- new: GUI Boxes: Choice Settings: 'Title Vertical Alignment', 'Content Vertical Alignment' and 'Info Vertical Alignment' settings available in the 'Choice Settings'. Display the title, content and info of choices at the 'Top', 'Middle' or 'Bottom' of the content area of the choice button.
- new: GUI Boxes: Tabs Settings: 'Content Vertical Alignment' and 'Info Vertical Alignment' settings available in the 'Tabs Settings'. Display the tab content at the 'Top', 'Middle' or 'Bottom' of the content area of the tab button.
- new: Menu Settings, GUI Boxes: OK/Cancel Buttons: 'Content Vertical Alignment' and 'Info Vertical Alignment' settings available in the 'Tabs Settings'. Display the button content at the 'Top', 'Middle' or 'Bottom' of the content area of the button.
- new: Event System: Clear Selected Data: 'Clear Selected Data' step available in 'Event > Selected Data' steps. Clears selected data, i.e. either all or the selected data of the defined key will be removed.
- new: Event System: Select Game Object: 'Select Game Object' step available in 'Event > Selected Data' steps. Uses game objects as selected data.
- new: Event System: Select Combatant: 'Select Combatant' step available in 'Event > Selected Data' steps. Uses combatants as selected data.
- new: Event System: Select Ability: 'Select Ability' step available in 'Event > Selected Data' steps. Uses a abilities of combatants or a newly created ability as selected data.
- new: Event System: Select Base Attack: 'Select Base Attack' step available in 'Event > Selected Data' steps. Uses base attacks of combatants as selected data.
- new: Event System: Select Counter Attack: 'Select Counter Attack' step available in 'Event > Selected Data' steps. Uses counter attacks of combatants as selected data.
- new: Event System: Select Equipment: 'Select Equipment' step available in 'Event > Selected Data' steps. Uses the equipment currently equipped on combatants as selected data.
- new: Event System: Select Item: 'Select Item: step available in 'Event > Selected Data' steps. Uses items from the inventory of combatants or newly created items as selected data.
- new: Event System: Change Equip Status Value: 'Change Equip Status Value' step available in 'Combatant > Equipment' steps. Changes a status value bonus of equipment currently stored in selected data.
- new: Event System: Reset Combatant Status: 'Reset Combatant Status' step available in 'Combatant > Combatant' steps. Recalculates all status values and bonuses of a combatant.
- new: Event System: Add To Inventory, Remove From Inventory, Has In Inventory, Block Item Reuse: 'Use Selected Data' settings available. Optionally use items stored in selected data of the event.
- new: Event System: Learn Ability, Forget Ability, Add Temporary Ability, Remove Temporary Ability, Block Ability Reuse: 'Use Selected Data' settings available. Optionally use abilities stored in selected data of the event.
- new: Event System: Check Transform: 'Use Local' setting available for 'Position' and 'Rotation' checks. Optionally checks the local position/rotation instead of the global position/rotation.
- new: Event System: Change Rotation: 'Set Rotation' setting available. Optionally set/fade the rotation to the defined value instead of adding it to the game object's current rotation.
- new: Event System: Change Aggression State: 'Change Aggression State' step available in 'Battle > Combatant' steps. Sets a combatant aggressive or not aggressive.
- new: Event System: Is Aggressive: 'Is Aggressive' step available in 'Battle > Combatant' steps. Checks if a combatant is aggressive or not.
- new: Event System: Set Scene Position, Store Scene: 'Load Scene Mode' and 'Load Async' settings available. Defines how the scene will be loaded when using the stored scene position.
- new: Formulas: Clear Selected Data: 'Clear Selected Data' step available in 'Selected Data' steps. Clears selected data, i.e. either all or the selected data of the defined key will be removed.
- new: Formulas: Select Ability: 'Select Ability' step available in 'Selected Data' steps. Uses a abilities of combatants or a newly created ability as selected data.
- new: Formulas: Select Base Attack: 'Select Base Attack' step available in 'Selected Data' steps. Uses base attacks of combatants as selected data.
- new: Formulas: Select Counter Attack: 'Select Counter Attack' step available in 'Selected Data' steps. Uses counter attacks of combatants as selected data.
- new: Formulas: Select Equipment: 'Select Equipment' step available in 'Selected Data' steps. Uses the equipment currently equipped on combatants as selected data.
- new: Formulas: Select Item: 'Select Item: step available in 'Selected Data' steps. Uses items from the inventory of combatants or newly created items as selected data.
- new: Camera Controls: Top Down Border: Multiple 'Camera Border' components in a scene are now supported. The 'Top Down Border' camera control will use the 'Camera Border' which's collider bounds are nearest to the player or camera target to adjust the camera position.
- change: Interaction Components: 'In Blocked Control' is now available for all start types. Optionally allows starting an interaction while the player can't interact (e.g. blocked controls).
- change: Event System: The 'Actor' selection has been replaced by object selection fields in most steps and the float/int value fields, allowing to use other objects than actors (e.g. found objects). Saved settings will automatically be updated.
- change: Event System: Change Battle Type: The 'Change Battle Type' node is now available in all event types.
- change: GUI Boxes: Content Box: The X and Y position of the content box bounds are now used as an offset to the cursor position when using 'At Cursor'.
- change: GUI Boxes: 'Center Position' setting has been replaced by the 'Content Vertical Alignment' setting in the 'Content Box' settings. You can now use 'Top', 'Middle' and 'Bottom' alignment for the content displayed in the content area.
- change: Controls: Starting interactions now takes priority over control maps (e.g. when using the 'Accept' button for control maps).
- change: Game Controls: The interaction controller settings have been moved to the 'Interaction Settings'.
- change: Game Controls, Game Settings: The 'Max Event Steps' and 'Max Click Distance' settings can now be found in 'Base/Control > Game Controls' in the 'Interaction Settings'.
- change: Formulas: Variables: 'Use Object Variables' setting has been replaced with 'Variable Origin' setting to select 'Local', 'Global' or 'Object' variable origin. Saved settings will automatically be updated.
- fix: Menu Screens: Open/close game events with wait steps or using any kind of wait option will now correctly finish in menu screens that are pausing the game.
- fix: HUDs: Combatant: Fixed an issue where 'No Outer Assign' prevented assigning from the same HUD element.
- fix: Editor: Having the ORK Framework editor opened when starting to play in the Unity editor could cause UI issues in both legacy GUI and uGUI (new UI)
- fix: Editor: Fixed an issue where horizontal scrollbars in the editor where not displayed after opening the GUI editor without a defined GUISkin for the GUI boxes.
- fix: Player Group: Fixed an issue where changing the leader of the battle group didn't add player components (e.g. controls) to the new leader and spawned the 2nd battle group member as well.
- fix: Editor: The search field now works correctly.
- fix: Battle Menus: The battle menu was enabled and disabled all the time when not using the target menu in 'Battle System > Battle Settings'.


Version 2.6.3:
- new: Save Games: Support for saving/loading custom component save data with ORK Framework save games. Implement the 'IComponentSaveData' interface in your component to save/load it with a combatant's data. Can also be used to transfer data between scenes and when remembering combatant spawner combatants.
- new: Turn Based Battles, Phase Battles: Actions Per Turn: A combatant can now perform multiple actions per turn. Please note that this isn't very useful when using 'Dynamic Combat', as this will break the turn based battle order.
- new: Turn Based Battles, Phase Battles: 'Actions Settings' available. Define the actions per turn and default action costs for using abilities, items, defend, escape and none/end turn actions.
- new: Abilities, Items: 'Turn Action Cost' settings available. Abilities/items can optionally override the default action costs of turn based battles.
- new: Abilities, Items: 'Actions Per Turn Change' settings available. Abilities/items can optionally change the actions per turn of a combatant in 'Turn Based' and 'Phase' battles.
- new: Abilities: Use Cost: 'Auto Consume' setting available. Defines if the use costs will be consumed automatically when the ability is used (i.e. before the battle events). Either only uses the costs when the ability is calculated (or through the event system), when the ability is used without targets (e.g. 'None' target range) or always.
- new: Abilities, Items: Target Settings: 'Horizontal Plane' setting available when using 'Check User Orientation'. Defines the axes that will be used as horizontal plane (i.e. horizontal movement of the game objects), either XZ (default 3D behaviour) or XY (default 2D behaviour).
- new: Status Types: 'Status Types' sub-section now available in the 'Status' section. Status types can be used to separate status values. This can be used for filtering in the editor or to display lists of status values based on the status type in HUDs.
- new: Editor: Status Values: The 'Status Values' sub-section list can now be filtered by 'Status Type'.
- new: GUI Boxes: 'Center Position' setting available. Optionally displays the content at the center with the same distance to the top and bottom of the content area. Only used if the content's height is smaller than the content area's height. Available in all 'Height Adjustment' modes.
- new: HUDs: Combatant, Turn Order: Status type text codes available in 'Status Value' type HUD elements. Display the name (%tn), description (%td) or icon (%ti) of the status type of displayed status values.
- new: HUDs: Combatant, Turn Order: 'Actions Per Turn' type HUD element available. Displays the actions per turn of a combatant.
- new: HUDs: Combatant, Turn Order: 'Turn' text code available in 'Information' type HUD elements. Display the current turn of a combatant using the %t text code. Will only be displayed in running 'Turn Based Battles'.
- new: HUDs: Navigation: 'Horizontal Plane' setting available in 'Navigation' type HUDs. Defines the axes that will be used as horizontal plane (i.e. horizontal movement of the game objects), either XZ (default 3D behaviour) or XY (default 2D behaviour).
- new: Menu Screens: 'Only When Closing' setting available when using a 'Close Game Event'. Optionally only uses the close game event when the menu screen is being closed without opening another menu screen.
- new: Menu Settings: 'Pixel Drag Threshold' setting available when using the 'New UI' GUI system type. Defines the event system's soft area for dragging in pixels - mostly used for distinguish between touch on a button and dragging when scrolling. 
The best value greatly depends on your used (mobile) device.
- new: Move AIs: Move Detection: 'Horizontal Plane' setting available in the angle settings of enemy move detections. Defines the axes that will be used as horizontal plane (i.e. horizontal movement of the game objects), either XZ (default 3D behaviour) or XY (default 2D behaviour).
- new: Battle AIs: Position: 'Horizontal Plane' setting available in 'Check Orientation' and 'Check Angle' nodes. Defines the axes that will be used as horizontal plane (i.e. horizontal movement of the game objects), either XZ (default 3D behaviour) or XY (default 2D behaviour).
- new: Battle AIs: Check Action Bar: 'Check Action Bar' step available in 'Combatant' steps. Checks the action bar or used action bar of a combatant. In 'Turn Based Battles' and 'Phase Battles' this checks the actions per turn or used actions per turn, in 'Active Time Battles' this changes the timebar or used timebar.
- new: Battle Menu: Ability: 'Limit Ability Type' setting available in 'Ability' menu items. Optionally limit the displayed abilities to a defined ability type and it's sub-types.
- new: Battle Menu: Item: 'Limit Item Type' setting available in 'Item' menu items. Optionally limit the displayed items to a defined item type and it's sub-types.
- new: Formulas: Position: 'Horizontal Plane' setting available in 'Check Orientation', 'Angle' and 'Check Angle' nodes. Defines the axes that will be used as horizontal plane (i.e. horizontal movement of the game objects), either XZ (default 3D behaviour) or XY (default 2D behaviour).
- new: Formulas: Check Action Bar: 'Check Action Bar' step available in 'Combatant' steps. Checks the action bar or used action bar of a combatant. In 'Turn Based Battles' and 'Phase Battles' this checks the actions per turn or used actions per turn, in 'Active Time Battles' this changes the timebar or used timebar.
- new: Formulas: Turn Value: 'Turn Value' step available in 'Combatant' steps. Uses the current turn value of a combatant to change the formula. The turn value is used to generate the turn order in 'Turn Based Battles' using 'Multi Turns'.
- new: Formulas: Action Bar: 'Action Bar' step available in 'Combatant' steps. Uses the current action bar of a combatant to change the formula. In 'Turn Based Battles' and 'Phase Battles' the action bar represents the actions per turn of a combatant, in 'Active Time Battles' the action bar represents the timebar of a combatant.
- new: Interactions: 'Horizontal Plane' setting available in the 'Orientation' settings of interaction components. Defines the axes that will be used as horizontal plane (i.e. horizontal movement of the game objects), either XZ (default 3D behaviour) or XY (default 2D behaviour).
- new: Event System: Inventory: 'Remove Item Type' step available in 'Combatant > Inventory' steps. Removes all currencies, items, weapons or armors of a defind item type (optionally also sub types) from a combatant's inventory.
- new: Event System: Rotation: 'Horizontal Plane' setting available in 'Check Orientation' and 'Check Angle' nodes. Defines the axes that will be used as horizontal plane (i.e. horizontal movement of the game objects), either XZ (default 3D behaviour) or XY (default 2D behaviour).
- new: Event System: Add To Item Box: 'Use Add Type' setting available in 'Add To Item Box' steps. Optionally uses the inventory add type of items and equipments when adding them to item boxes (e.g. for auto stacking).
- new: Battle Events: Change Action Bar: 'Change Action Bar' step available in 'Battle > Combatant' steps. Changes the action bar or used action bar of a combatant. In 'Turn Based Battles' and 'Phase Battles' this changes the actions per turn or used actions per turn, in 'Active Time Battles' this checks the timebar or used timebar.
- new: Battle Events: Check Action Bar: 'Check Action Bar' step available in 'Battle > Combatant' steps. Checks the action bar or used action bar of a combatant. In 'Turn Based Battles' and 'Phase Battles' this checks the actions per turn or used actions per turn, in 'Active Time Battles' this changes the timebar or used timebar.
- change: Turn Based Battles: 'Turn Based Mode' setting replaces the 'Active Command' and 'Use Multi-Turns' settings. Select the 'Classic' mode for non-active command, 'Active' mode for active command and 'Multi Turns' for active command with multi-turns. Your previous settings will automatically be udpated to the new setting.
- change: HUDs: Combatant, Turn Order: The 'List' and 'List All' settings have been replaced by the 'List Status Values' selection. YOu can now either display a single status value, all status values, all status values of a defined status type or all status values of a defined status value type ('Consumable', 'Normal' or 'Experience').
- change: HUDs: Combatant: 'Inner Assign' setting in 'Shortcut' HUD elements will now check for coming from the same combatant or group instead of the same HUD element. This allows better swapping of shortcuts between shortcut slots in different HUD elements of the same combatant.
- change: Abilities: The 'Consume Items' settings can now be found in the 'Use Cost' settings of active abilities.
- change: Menu Screens: The 'Show Type Box', 'Merge Types' and 'Type Tabs' settings have been replaced by the 'Type Display' selection in all menu screen parts that have type display. Your previous settings will be updated automatically.
- change: Menu Screens: The 'Type Change Keys' settings have been moved to to the 'Available Type' settings in all menu screen parts that have type display.
- change: Scripting: Most enumerations (enum) have been moved from the 'Core' to the 'Gameplay' part of the scripts and can now be changed to your needs.
- fix: HUDs: Interaction: Fixed an issue where 'Interaction' type HUDs could cause an error when not having a player with an interaction controller in the scene.
- fix: HUDs: Combatant: Fixed an issue where 'Cursor Over' combatant HUDs where only displayed once.
- fix: HUDs: Combatant: Fixed an issue where 'Shortcut' HUD elements with 'Position' cell mode used the wrong positions for mouse interaction (e.g. tooltips or drag+drop).
- fix: Portraits: Fixed an issue where portraits displayed 'Within' a GUI box wheren't removed properly when updating the box (e.g. in 'Turn Order' type HUDs).
- fix: Portraits: Fixed an issue with choice portraits still being displayed after a different choice was selected (resulting in multiple portraits being displayed at the same time).
- fix: New UI: Fixed an issue where cropped images (e.g. from value bars) didn't reset their UV rect, causing stretched images.
- fix: Console: Weapons, Armors: Removing weapons or armors from the inventory displayed the 'Add' console texts instead of the 'Remove' texts.
- fix: Event System: Dialogues: Fixed an error when using an actor icon text code in dialogue texts.
- fix: Battle Menus: Fixed an issue where 'Ability' menu items using 'Type' where disabled when having sub-types and no abilities directly under that type.
- fix: Item Collectors: Fixed an issue where an empty box is destroyed when 'Destroy Empty Box' is disabled when the scene is loaded.
- fix: GUI Editor: Fixed an issue where opening the GUI editor after having the ORK editor open while playing used the play mode's UI scale.
- fix: Status Effects: Fixed an issue where 'End With Battle' effects could still be applied after a battle ended.


Version 2.6.2:
- new: Editor: Inspector: ORK components now record undo information. Changes to an ORK component can now be undone/redone.
- new: HUDs: Combatant: New text codes for 'Shortcut' type HUD elements available. Display the reuse time of items and abilities with '%r' (no decimals), '%r1' (1 decimal) and '%r2' (2 decimals). The text will only be displayed while reuse is blocked, 'Turn' type blocks will only display whole numbers (no decimals).
- new: HUDs: Interaction: 'At Interaction Position' settings available. Optionally displays the HUD at the position of the interaction's game object.
- fix: Value Bars: Fixed an issue where cropping an image for 'Top To Bottom' and 'Bottom To Top' bars was cropping the wrong direction.
- fix: Components: Changes to ORK components will mark the opened scene as changed again.
- fix: HUDs: Combatant: 'Inactive Color' setting of 'Shortcut' type HUD elements now work when using the new UI.
- fix: New UI: HUDs: Fixed an issue with HUD elements (e.g. icons) not being displayed when first showing or after updating a HUD.


Version 2.6.1:
- new: Event System: Battle Steps: 'Place Spots On Ground' step available in 'Battle > Combatant' steps. Places the battle spots on the ground using the 'Place On Ground' settings defined in the 'Battle Spots' settings.
- change: New UI: Buttons: ORK will automatically add a 'Text' component to a button if no clickable component is attached (e.g. an 'Image' component) to ensure the button can be clicked.
- fix: Scene Wizard: Fixed an error message when having the scene wizard docked when opening Unity.
- fix: New UI: Fixed an issue with text typing of GUI boxes not displaying the content.
- fix: HUDs: Navigation: Fixed an issue with the 'Navigation' bar HUD not displaying it's content after it was closed and opened again when using the new UI.
- fix: HUDs: Fixed an issue with background and foreground images being missing after a HUD has been updated.
- fix: Battles: Fixed an issue where in some cases the battle spots where not placed on the ground when fighting in a different scene (teleport battles).
- fix: Player/Camera Controls: Fixed an issue where custom player/camera controsl wheren't blocked correctly when fighting in a different scene (teleport battles).


Version 2.6.0:
- new: Unity 5.3: ORK Framework now requires Unity 5.3.
- new: Performance Improvements: There have been performance improvements throughout the entire framework. Depending on your usage of ORK's features you'll benefit more or less from those improvements.
- new: Damage Types: 'Block' animation type setting available. Defines the animation type that will be played when a combatant blocks an attack.
- new: Damage Types: The different animation type selections are now optional. Optionally define if the damage, critical damage, evade and block animation types will be used. Damage, critical damage and evade are enabled by default, block is disabled.
- new: Battle Menus: 'Reset Selection' setting available. Optionally resets the selection to the 1st menu item each time.
- new: Menu Screens: Ability, Ability Tree, Bestiary (Area), Bestiary (Type), Crafting, Inventory, Log, Quest: 'All' type choice settings available. Optionally displays an 'All' type choice, displaying a merged list of all type menu items (e.g. all items in an 'Inventory' menu part).
- new: Save Game Menu: 'Exit After Save' settings available. Optionally exit the game to the main menu scene after saving - can also display the 'Exit Question' dialogue first.
- new: Combatant Selections: 'Remember Selection' setting avaiable. Optionally remember the last selection made in a combatant selection.
- new: Formulas: Combatant Steps: 'Random Status Value' step available. Uses a random value between two status values of combatants.
- new: Formulas: Value Steps: 'As Int' setting available in 'Random Value' steps. Optionally uses the random value as integer (i.e. whole number) instead as a float.
- new: Weapons, Armors: 'Block Equipment Viewer' settings available. Optionally blocks the equipment viewers of selected equipment parts. If the viewer of an equipment part is blocked, all 'Equipment Viewer' components using that part will not display an equipment. This can be used e.g. for cosmetic/fashion equipment, hiding the real eqiupment of the combatant.
- new: Menu Settings: 'Unlocked Mouse Over' setting available. Optionally only uses 'Mouse Over Selection' when the cursor isn't locked. By default enabled.
- new: Event System: Dialogue Steps: 'Queued Notification' dialogue type available in 'Show Dialogue' steps. Displays a message and closes it after time - if another queued notification is displayed, the dialogue will be displayed after all previous queued notifications are closed. You can separate notification queues by using different queue keys.
- new: Event System: Dialogue Steps: 'Title' settings available when not showing a speaker's name in 'Show Dialogue', 'Value Input Dialogue', 'Quest Choice' and 'Teleport Choice' steps. Optionally display a defined title in the name box of the used GUI box. You can use the text code '%n' to add the name of a speaker to the title.
- new: Event System: Base Steps: 'Clear Screen' setting available in 'Close Menu Screen' steps. Clearing a menu screen before closing is now optional - this prevents the menu screen from notifying other events and menu screens that opened it. By default enabled.
- new: Event System: Equipment Steps: 'Change Blocked Viewer' step available. Adds or removes equipment viewer blocks to combatants. A blocked equipment viewer wont display the equipment of the used equipment part on the combatant's game object ('Equipment Viewer' components).
- new: Event System: Base Steps: 'Exit Game' step available. Exits the game to the main menu. The event ends after this step.
- change: Editor: Events: The event steps have been reorganized and grouped together in sub-categories. E.g. you can now find all combatant related steps (abilities, inventory, status, etc.) in the 'Combatant' sub-category.
- change: Editor: Formulas, Battle AIs: The formula and battle AI steps have been reorganized and categories renamed.
- change: Console, Status Effects: Auto status effects will no longer display the reapply console text. This caused the console to be flooded with status effect texts due to them being reapplied each frame.
- change: Event System: Dialogue Steps: Displaying a 'Choice' type dialogue without adding choices will now display a warning in the Unity console.
- change: GUI Box: The content bounds will automatically be adjusted to prevent tabs from overlaying the content.
- change: Items: Equipment Part Changes: The 'Is Blocked' setting has been replaced with the 'Part Change' selection. You can now use the equipment part as an 'Additional Part', 'Blocked Part' or 'Blocked Viewer' to change the equipment parts of a combatant.
- fix: Weapons, Armors: Enabling 'Add Previous Levels' in random status value bonuses of equipment levels prevented adding previous bonuses instead of adding them.
- fix: Menu Screens: Fixed an issue where empty menu screens could throw errors.
- fix: Menu Screens: Fixed an issue where changing types using 'Type Change Keys' didn't work correctly when showing the types as tabs.
- fix: New UI: Fixed an issue with scroll bars being displayed too far to the right.
- fix: Editor: Fixed an issue where the ORK Framework editor couldn't be opened after starting to play in a scene without a 'Game Starter'.


Version 2.5.9:
- new: Music Channels: The volume of each music channel can now be changed individually.
- new: Main Menu, Menu Screens: 'Use Channel' settings available for 'Music Volume' settings in option menus. Optionally change the volume of a defined music channel instead of the master music volume (affecting all channels).
- new: Quest Tasks: Requirements: 'Count' requirements available in activate, finish and fail requirements. Optionally use a custom count requirement, identified by a tag. The count can be changed using the event system - count requirements matching the used tag will be changed.
- new: Status Requirements: Level: Advanced 'Class Level' settings available. Optionally check the class level of a defined class. If the combatant never used the class, the class level will be 0.
- new: Status Requirements: 'In Battle' requirement selection available. Checks if a combatant is or isn't in battle.
- new: Status Requirements: 'In Action' requirement selection available. Checks if a combatant is or isn't in battle (e.g. performing an ability).
- new: Status Requirements: 'Is Casting' requirement selection available. Checks if a combatant is or isn't casting an ability.
- new: Abilities, Items, Battle Settings: Use Range: 'Minimum Use Range' settings available. Use ranges now have a minimum and maximum use range.
- new: Console Settings, Console Types: 'Before Line Text' and 'After Line Text' settings available. Optionally add text before and after each console line. The console type's texts will be added before and after the console settings texts.
- new: Weapons, Armors: 'Override Price' settings available in equipment levels. An equipment's level can optionally override the price settings of the equipment.
- new: Weapons, Armors: 'Override Equip Requirements' settings available in equipment levels. An equipment's level can optionally override the equip requirements of the equipment.
- new: Weapons, Armors: 'Add Previous Levels' setting available for random status value bonuses of equipment levels. Adding the random bonuses of previous equipment levels is now optional when creating a new weapon/armor at a defined level. By default enabled (i.e. adding previous level bonuses).
- new: Value Bars: 'Positive Changes' and 'Negative Changes' settings available in value bar images. Optionally display the difference between the displayed value and the actual value with a different image/color in the value bar. This can be used with the 'Count to Value' setting of status values to animate the damage/refresh with a different image/color in the value bar.
- new: Shops: 'Exchange Rate' settings available. You can optionally define a currency exchange rate for a shop. Otherwise the current exchange rate for the currency will be used.
- new: Event System: Base Steps: 'Change Found Objects' step available. Changes a 'Found Objects' or 'Global Objects' list using a defined game object (e.g. an event actor).
- new: Event System: Base Steps: 'Raycast All' setting available in 'Raycast Object' steps. Optionally use all game objects hit by a raycast instead of the first game object that was hit.
- new: Event System: Battle Steps: 'Search Combatants' step available. Finds game objects of combatants in the scene. Optionally checks for allied/death/battle state, range or status requirements.
- new: Event System: Audio Steps: 'Use Channel' settings available in 'Change Music Volume' steps. Optionally change the volume of a defined music channel instead of the master music volume (affecting all channels).
- new: Event System: Quest Steps: 'Change Task Count' step available. Changes the current count of a task's count requirement. Only count requirements matching the defined task will be changed.
- new: Battle Events: Battle Steps: 'Other Targets' settings available in 'Calculate' steps. Optionally use other combatants as targets instead of using the targets originally found by the action.
- change: Menu Screens: Ability, Equipment, Inventory: Clicking on a choice will now also call the sub-menu when it's using the same input key as the 'Accept' key.
- change: Editor: Changed how event assets are updated to prevent crashes in very large projects.
- fix: Menu Screens: Fixed an issue where settings wheren't displayed when selecting 'Stop' music play type in the music settings of a menu screen.
- fix: Event System: Movement Steps: Fixed an issue in the 'Change Position' step when moving by speed only along the Y-axis.
- fix: Menu Settings: Bonus Display: Fixed an issue with defence attribute text display causing an error.
- fix: Menu Screens: Equipment: Fixed an issue where 'Back' and 'Unequip' buttons where switched (back unequipping and unequip going back) in some cases.
- fix: Equipment: Fixed an issue when having 'Random Status Value Bonuses' using bonus range 'Random' without any added status value bonuses.
- fix: Text Codes: Fixed an issue where some text codes (e.g. for changing text color) could add an additional space to the text.
- fix: HUDs: Console: Fixed an issue where the scrolling area didn't adjust it's size when using the new UI.
- fix: HUDs: Console: Fixed an issue where a 'Console' type HUD's tab titles wheren't updated when changing the language.
- fix: HUDs: Fixed an issue where the name box of HUDs didn't show after the HUD was closed and opened again when using the new UI.
- fix: Combatant Spawners: Fixed an issue where using 'Set Scene ID' allowed starting a battle of a respawned combatant and blocked during the battle start event.
- fix: iOS: Fixed an issue where running a project in XCode on iOS resulted in a crash.
- fix: New UI: Fixed an issue when updating content of a scrollable GUI box that caused text/images to be hidden.


Version 2.5.8:
- new: Temporary Abilities: Abilities can now be added to combatants as temporary abilities through the event system and the battle AI. Use this for special situations, e.g. when you want to have the option to talk to an enemy (using an ability's battle events) without having to learn the ability to the combatant.
- new: Menu Screens: Ability: 'Add Temporary Abilities' setting available in 'Ability' menu screen parts. Defines if temporary abilities of a combatant are displayed, not displayed or if only temporary abilities will be displayed.
- new: Battle Menus: Ability: 'Add Temporary Abilities' setting available in 'Ability' battle menu items. Defines if temporary abilities of a combatant are displayed, not displayed or if only temporary abilities will be displayed.
- new: Status Requirements: 'Temporary' check selection available for 'Ability' status requirements. Checks if the ability is added as a temporary ability to the combatant.
- new: Damage Zones: 'Game Event Settings' available. Damage zones can optionally start game events upon being hit by a damage dealer.
- new: Battle Settings: Target Selection: 'Blink Target HUD' settings available. Like blinking the target's game object, the target selection can now optionally blink the HUDs of the selected target.
- new: Event System: Save Game Steps: 'Check Auto Save Slot' step available. Checks the currently used auto save slot number.
- new: Event System: Battle Steps: 'Cancel Ability Cast' step available. Cancels casting an ability on a combatant.
- new: Event System: Battle Steps: 'Is Casting Ability' step available. Checks if the combatant is casting any ability, a defined ability or an ability of a defined type or root type.
- new: Event System: Status Steps: 'Add Temporary Ability' step available. Adds a temporary ability to a combatant, optionally only for a limited amount of turns or time.
- new: Event System: Status Steps: 'Remove Temporary Ability' step available. Removes a temporary ability from a combatant.
- new: Battle AI: Status Steps: 'Add Temporary Ability' step available. Adds a temporary ability to a combatant, optionally only for a limited amount of turns or time.
- new: Battle AI: Status Steps: 'Remove Temporary Ability' step available. Removes a temporary ability from a combatant.
- fix: Music: Fixed an issue where playing a non-existing stored clip throws an error.
- fix: Combatant Spawners: Fixed an issue where 'Autostart' combatant spawners throw an error.
- fix: Battle Events: The 'Calculate' step didn't use the correct next step based on the action's result (e.g. upon 'Miss') when used to animate damage dealers.
- fix: New UI: Scrolling: Fixed an issue where dragging on an empty part of a scrolling area didn't scroll.
- fix: Event System: Battle Steps: Fixed an issue where using a combatant's game object in a 'Start Battle' step didn't start the battle when the player controls are blocked.
- fix: HUDs: Shortcuts: Fixed an issue where a shortcut could be used multiple times by clicking on it, ignoring use blocks or the time used to animate using it.


Version 2.5.7:
- new: Combatant Types: 'Combatant Types' sub-section available in the 'Combatants' section. Define combatant types to separate combatants by type.
- new: Combatants: 'Combatant Type' setting available. Define the combatant's type.
- new: Status Requirements: 'Combatant Type' requirement selection available. Checks if a combatant is of a selected combatant type or not.
- new: Status Requirements: 'Is Class' setting available for 'Class' requirement checks. You can now checks if the combatant is or isn't of the defined class, previously you could only check if the combatant is of the class. By default enabled.
- new: Quest Tasks: Requirements: 'Use Combatant Type' settings available in 'Enemy Kills' requirements. Optionally kill a defined amount of combatants based on the combatant type instead of a defined combatant. This allows using different combatants (of the same type) as targets for quest tasks.
- new: Quest Tasks: 'Task Status Icons' settings available. Optionally override the quest task's icon for inactive, active, finished and failed task status.
- new: Quests: 'Quest Status Icons' settings available. Optionally override the quest's icon for inactive, active, finished and failed quest status.
- new: HUDs: Combatant, Turn Order: New text codes available in 'Information' HUD elements for 'Combatant' and 'Turn Order' type HUDs. Display the name (%tn), description (%td) and icon (%ti) of the combatant's combatant type.
- new: Menu Screens: 'Bestiary (Type)' menu part available. Displays information on bestiary entries using HUD elements. The bestiary entries are separated by combatant types.
- new: Music Channels: Play different music clips at the same time using music channels. Each channel can play one clip at a time and fade between clips. The default channel is 0.
- new: Music: Stored Music: You can now store different currently playing clips per channel using IDs. As before, you can store the currently playing clip and playback time of a music channel, but you can separate multiple stored clips using stored IDs and playback them at a later time.
- new: Music Player: 'Music Channel' setting available in the 'Music Player' component. Defines the music channel that will be used to play or change the music.
- new: Menu Screens, Shops: 'Music Channel' and 'Stored ID' settings available when using the music options. Define the music channel that will be used and the ID used to store the currently playing clip of that channel. By default uses channel 0 and stored ID 1.
- new: Save Game Menu: 'Music' setting available in 'Save Settings'. Saving the currently playing music clips and playback positions is now optional. By default enabled.
- new: Crafting Recipes: 'Critical Chance' and 'Critical Outcomes' settings available. Optionally use a critical success chance to create critical outcome items instead of normal outcome items.
- new: Player Controls: Mouse: 'Cursor Respawn' setting available. Optionally creates a new instance of the cursor prefab each time instead of reusing the already spawned instance. Use this option if your cursor is a one time particle effect.
- new: Weapons, Armors: Prefabs: 'Local Rotation' setting available for equipment viewer prefabs. Optionally sets the rotation offset as local rotation of the spawned prefab instance.
- new: Abilities, Items: 'Block Scope' setting available in 'Reuse Settings' of abilities and items. Define the scope of abilities/items that will be blocked - single (the ability/item), type (all abilities/items of the same type), root type (all abilities/items of the root type and all it's sub-types), all (all abilities/items).
- new: Battle System: Bonus Settings: 'Status Effect' changes available for start battle, turn, end battle and revive bonuses in all battle system types. Optionally change status effects of combatants when the battle starts/ends, when they start a new turn or are revived after battle.
- new: Event Steps: Audio Steps: 'Music Channel' and 'Stored ID' settings available in 'Change Music' steps. Define the music channel that will be used and (when playing a stored clip) which stored ID will be used.
- new: Event Steps: Audio Steps: 'Music Channel' and 'Stored ID' settings available in 'Store Music' steps. Define the music channel and ID that will be stored.
- new: Event Steps: Status Steps: 'Block Scope' setting available in 'Block Ability Reuse' and 'Block Item Reuse' steps. Define the scope of abilities/items that will be blocked - single (the ability/item), type (all abilities/items of the same type), root type (all abilities/items of the root type and all it's sub-types), all (all abilities/items).
- new: Combatant Spawners: 'Position Rounding' setting available in area spawners (i.e. using triggers for random placement). Optionally rounds the spawn position (X and Z axis) to whole numbers. Use this option e.g. when creating classic 2D grid like games.
- new: Item Collectors: Box: 'Auto Take All' setting available for 'Box' type item collectors. Optionally adds all items in the box to the player's inventory upon interaction instead of showing the item box dialogue.
- fix: Event System, Combatant Spawners: 'Start Combatant Spawner' steps could throw an error in some cases when used in an 'Autostart' type event interaction without any delay.
- fix: Equipment Viewers: Fixed an issue with viewer materials not working correctly.


Version 2.5.6:
- new: Unity 5.2: ORK Framework now requires Unity 5.2.
- new: Texture Fields: All 'Texture' selection fields now support all kinds of texture assets (except for mouse cursor texture fields). Besides 'Texture2D' (default till now), you can e.g. also use 'RenderTexture' (rendering a camera to a texture), 'MovieTexture'.
- new: GUI Boxes: 'Screen Adjustment' settings available. Optionally adjust the position of the GUI box to fit the content box within the screen space. Use this e.g. for tooltip HUDs that follow the mouse cursor.
- fix: Game Over: Menu screens will now be closed upon game over.
- fix: Main Menu: Background images for the auto save slot selection will now be removed after the override confirmation question.
- fix: Event System: Status Steps: The 'Regenerate' event step will no longer regenerate status values of dead combatants (unless 'Revive Dead' is enabled).


Version 2.5.5:
- new: Combatants: AI Settings: 'Start AI Blocked' setting available. Optionally block the battle AI of a combatant when it's instantiated. An AI controlled combatant will only use the 'None' action when the battle AI is blocked (i.e. do nothing). The battle AI can be blocked/unblocked in the event system.
- new: Event System: Battle Steps: 'Block Battle AI' step available. Blocks or unblocks the battle AI of a combatant. An AI controlled combatant will only use the 'None' action when the battle AI is blocked (i.e. do nothing).
- new: Event System: Battle Steps: 'Is Battle AI Blocked' step available. Checks if a combatant's battle AI is blocked.
- change: Combatants: Loot Settings: 'Loot Origin' setting replaces 'Use Start Inventory' setting. You can now optionally use the 'Start Inventory', 'Loot' tables or 'Both' to define a combatant's loot.
- fix: Formulas: Removed console output in 'Status Value' steps that was left in the release build by accident.


Version 2.5.4:
- new: Unity 5.1.3: ORK Framework now requires Unity 5.1.3.
- new: Items: 'Reuse Settings' available. An item can optionally be blocked for a defined amount of turns or time.
- new: Status Effect Changes: 'Remove Single' setting available when removing status effects (e.g. ability status changes, auto effects, etc.). Optionally only removes a single instance of the status effect instead of all applied instances. Use this option if you only want to remove one effect from stacked effects.
- new: Status Development: Upgrade Settings: 'Own Costs Description' settings available for status value upgrades. Optionally override the description if an upgrade can't be used due to the upgrade posts.
- new: Status Development: Upgrade Settings: 'Own Requirements Description' settings available for status value upgrades. Optionally override the description if an upgrade can't be used due to the requirements.
- new: Status Requirements: Status Value: 'Used Type' settings available. You can now use the current, base, min, max, display, preview and preview max value of the status value for status value requirements.
- new: Status Requirements: Attack/Defence Attribute: 'Used Type' setting available. You can now use the current, base, min, max, start and preview value of the attribute for attack/defence attribute requirements.
- new: Status Requirements: Death: 'Combatant Scope' setting available. You can now check either the checked combatant, the battle group or whole group. When checking the group, 'Is Dead' is valid if all members are dead, not 'Is Dead' is valid if at least one member is alive.
- new: Status Requirements: Combatant: 'Combatant Scope' setting available. You can now check either the checked combatant, the battle group or whole group. When checking the group, 'Is Combatant' is valid if at least one member is the selected combatant, not 'Is Combatant' is valid if no member is the selected combatant.
- new: Event System: Spawn Steps: 'Found/Global Objects' settings available in 'Spawn Prefab' steps. You can now optionally use the spawned prefab to change a found object or global object list.
- new: Event System: Save Game Steps: 'Delete Auto Save' step available. Deletes the AUTO save slot's save game or the temporary retry save game.
- new: Event System: Save Game Steps: 'Delete Save Game' step available. Deletes a defined save game or AUTO save game.
- new: Event System: Status Steps: 'Block Ability Reuse' step available. Blocks a defined ability's reuse for a defined amout of turns or time, or removes the reuse block from a combatant.
- new: Event System: Status Steps: 'Block Item Reuse' step available. Blocks a defined item's reuse for a defined amout of turns or time, or removes the reuse block from a combatant.
- new: Event System: Status Steps: 'Clear Item Reuse' step available. Clears the item reuse blocks of a combatant.
- new: Event System: Battle Steps: 'Start Combatant Spawner' step available. Starts a combatant spawner, i.e. spawns the combatants if they aren't yet spawned. The used game object must have a correctly set up 'Combatant Spawner' component attached.
- new: Event System: Battle Steps: 'End Battle' step available. Ends the currently running battle with a selected outcome (victory, escape, defeat, leave arena). Nothing happens if no battle is running.
- new: Combatant Spawners: 'Repeat Check' settings available for 'Autostart' start type when not using 'Auto Destroy'. Optionally repeats the autostart check until the conditions are valid. Use this for spawners that e.g. should be activated automatically after speaking to an NPC in the scene.
- new: Item Collectors: 'Use Condition' settings available in the 'Prefab Settings' when not using 'Auto Destroy'. Optionally only spawns the prefab when the conditions are valid, the check can be repeated. Use this for collectors that e.g. should spawn after starting a quest in the scene.
- new: HUDs: Combatant: 'Use Click Use' setting availalble in 'Shortcut' HUD elements when using 'Enable Clicking'. Optionally uses the shortcut when no group/individual/auto target is used or found. Items/abilities will trigger the target selection (or used on 'Self'), equipment will be equipped on the user.
- new: Menu Screens: Status Value Upgrade: 'Hide Maxed' setting available. Optionally hide status value upgrades for status value that reached their maximum value (i.e. their base value equals the maximum value).
- change: Player Controls: Mouse: The cursor is now spawned using the prefab's rotation.
- fix: Menu Screens: Combatant: Showing Ok/cancel buttons in 'Combatant' menu parts with only one page where blocked and not controlable.
- fix: Menu Screens: Equipment: Fixed bugs related to the 'Unequip' buttons.
- fix: Player: Changing the player through removing the current player from the group (e.g. using 'Leave On Death' option in the combatant's settings) could lead to the wrong combatant being used as player and the components being added to another.
- fix: HUDs: Turn Order: A combatant's death will now update 'Turn Order' type HUDs.
- fix: Battle Menus: Clicking on combatants for target selection now takes target conditions into account.
- fix: New UI: Solved exception thrown due to function changes in Unity 5.1.3.
- fix: Move AI: 'Detect On Damage' now only detects when the combatant is actually damaged, not when an ability is used on the combatant.


Version 2.5.3:
- new: Menu Settings: Use Cost Display: '%c' and '%m' text codes available for status value change display. Display the current value ('%c') and maximum value ('%m') of a status value.
- new: Animation Types: 'Action Choose Idle' animation type available. Select an animation type that will be used when a combatant is choosing the next action, e.g. when the player selects the combatant's action in the battle menu. By default uses animation type ID 0.
- new: Animations: Mecanim: 'Auto Rotation Parameters' settings available 'Mecanim' animations. Optionally automatically set the rotation of the combatant's X/Y/Z axes to parameters of the animator. Either set a float parameter to the actual rotation angle (0-360) or an int parameter to a 4-direction (0-3) or 8-directional (0-7) number representation.
- new: Ability Trees: 'Ability Level' setting available. Ability trees can now also learn different ability levels instead of just new abilities.
- new: Equipment Parts: 'Allow Unequip' setting available. Optionally define if weapons/armors equipped on an equipment part can be unequipped. If disabled, the equipment part can't be empty once it has been equipped with something (unless through changing a multi-equip or blocked-equip part). By default enabled (i.e. allows unequipping).
- new: GUI Boxes: Move Settings: 'Relative Move' settings available in 'Move In' and 'Move Out' settings. Optionally define the 'Start Position' or 'End Position' relative to the bounds of the content box.
- new: GUI Boxes: Move Settings: 'Use Curve' settings available when moving the box in/out. Optionally use animation curves for moving the GUI box in or out. This allows more complex movement operations, e.g. bouncing.
- new: GUI Boxes: Scale Settings: 'Use Curve' settings available when scaling the box in/out. Optionally use animation curves for scaling the GUI box in or out. This allows more complex scaling operations, e.g. pulsating.
- new: Menu Screens: 'Block Control Maps' setting available. Optionally block control maps while a menu screen is opened.
- new: Shops: 'Block Control Maps' setting available. Optionally block control maps while a shop is opened.
- new: Shop Layouts: 'Show in Buy/Sell Box', 'Show in Type Box' and 'Show in List Box' settings available in 'Description Box'. Showing descriptions can now be disabled for the individual parts of shop layouts. By default enabled (i.e. displaying descriptions).
- new: Shop Layouts: 'Show Backgrounds' setting available in 'Buy/Sell Box' settings. Showing background images is now optional in the buy/sell selection box. By default enabled (i.e. displaying backgrounds).
- new: Quests, Quest Tasks: Rewards: 'Normal Status Value Rewards' settings available. Quests and quest tasks can optionally give 'Normal' type status value rewards. This will add permanent bonuses to 'Normal' type status values.
- new: Combatants: Status Settings: 'Normal Status Value Rewards' settings available. Combatants can give 'Normal' status value rewards upon being defeated. 'Normal' type status value rewards give permanent bonuses to the status values of the player's combatants.
- new: Combatants: Status Settings: 'Reward Chance' settings available for 'Experience Reward' settings. Optionally use a chance to determine if an experience reward is received or not.
- new: Move AI: Enemy Detection: 'Detect On Damage' setting available. Optionally detects combatants that damage the move AI's combatant.
- new: Battle End: 'Normal Status Value Reward Settings' available. 'Normal' status value rewards can optionally be split by the battle group or whole group, and given to dead group members.
- new: Battle End: 'Normal Status Value Text' settings available. Defines the text used to display 'Normal' status value rewards in the battle gains dialogue.
- new: Battle AI: 'None' target selection available in all condition/check steps. Checks no combatants, e.g. use this target selection if you only want to check the already found targets.
- new: Battle AI: Position Steps: 'Check Move AI Detection' step available. Checks if targets are detected by the combatant's move AI.
- new: Battle AI: Position Steps: 'Check Move AI Hunting' step available. Checks if targets are valid hunting targets due to the combatant's move AI hunting conditions.
- new: Battle AI: Position Steps: 'Check Move AI Flee' step available. Checks if targets are valid fleeing targets due to the combatant's move AI flee conditions.
- new: Battle AI: Position Steps: 'Check Move AI Target' step available. Checks if targets are the current target of the combatant's move AI.
- new: Game Events, Battle Events, Battle Start Events, Battle End Events, Phase Change Events: 'Block Control Maps' setting available in 'Event Settings'. Optionally block control maps while the event is running.
- new: Battle Events, Phase Change Events: 'Block Move AI' settings available in 'Event Settings'. Optionally block the move AI while the event is running. Either blocks the move AI completely (i.e. for all combatants) or only for actors of the event.
- new: Event System: Object Selections: 'Global Objects' selection available. You can now use 'Global Objects' lists. Global objects are available in all events, all the time, instead of only in the running event and being gone when the event ends.
- new: Event System: Object Selections: 'Object Key' setting available. You can now store multiple lists of 'Found Objects' and 'Global Objects' by identifying them with an object key (string value).
- new: Event System: Base Steps: 'Object Key' and 'Use Global Objects' settings available in 'Search Objects' and 'Raycast Object' steps. Optionally change 'Global Objects' instead of 'Found Objects' lists and manage multiple object lists using object keys.
- new: Event System: Base Steps: 'Found Objects Count' step available. Checks the number of game objects stored in a 'Found Objects' or 'Global Objects' list.
- new: Event System: Function Steps: 'Check Object Name' step available. Checks a game object's name or tag.
- new: Event System: Equipment Steps: 'From Inventory' setting available in 'Change Equipment' steps. Optionally uses an equipment from the inventory, if the equipment isn't in the inventory, nothing will be equipped.
- new: Event System: Battle Steps: 'Block Control Maps' step available. Blocks or unblocks the control maps. Combatants can't use control maps while they're blocked.
- new: Event System: Battle Steps: 'Add Normal SV Reward' step available. Adds additional 'Normal' status value rewards to the battle's gains. 'Normal' type status value rewards give permanent bonuses to the player combatant's status values.
- new: Event System: Move AI Steps: 'Set Move AI Target' step available. Sets the target of a combatant's move AI. The move AI's settings kick in afterwards, e.g. when the target is hunted, the hunting settings will be used.
- new: Event System: Move AI Steps: 'Stop Move AI' step available. Stops the current action of a combatant's move AI. The move AI's settings kick in afterwards, e.g. following waypoints.
- new: Event System: Move AI Steps: 'Check Move AI Detection' step available. Checks if combatants are detected by another combatant's move AI.
- new: Event System: Move AI Steps: 'Check Move AI Hunting' step available. Checks if combatants are valid hunting targets due to another combatant's move AI hunting conditions.
- new: Event System: Move AI Steps: 'Check Move AI Flee' step available. Checks if combatants are valid fleeing targets due to another combatant's move AI flee conditions.
- new: Event System: Move AI Steps: 'Check Move AI Target' step available. Checks if a combatant is the current target of another combatant's move AI.
- new: Item Collectors: 'Use Loot' setting available when using 'Box' collection type. Optionally uses loot tables for filling the item box. Using loot tables will use the player combatant for level and variable conditions, the player combatant must already be added to the player group at the start of the scene.
- new: Add Combatant Components: 'Battle Object' settings available for 'Add Combatant' components. Like 'Combatant Spawner' components, 'Add Combatant' components can now also use a defined or near game object with a 'Battle' component as battle arena. 'Add Combatant' component settings have been rearranged/grouped.
- change: Event System: Move AI Steps: The 'Block Move AI' step can now be found in the 'Move AI Steps' instead of the 'Movement Steps'.
- change: Inventory Settings: The 'Auto Stack' settings have been replaced with the 'Add Type' settings. You can now add items, weapons and armors to the inventory as is, automatically stack them or automatically split them (i.e. add them as single items).
- change: Inventory Settings: Item Box: The 'Auto Stack' setting has been replaced by the 'Use Add Type' setting. Items and equipment added to the item box will use the inventory add type defined in the inventory settings or individual items/equipment.
- change: Turn Based Battles, Active Time Battles, Real Time Battles, Phase Battles: Batte Gains Collection: The 'Stack Loot' setting has been replaced by the 'Use Add Type' setting. Items and equipment added to the battle gains will use the inventory add type defined in the inventory settings or individual items/equipment.
- change: Items, Weapons, Armors: The 'Override Auto Stack' settings have been replaced by the 'Override Add Type' settings to match the new 'Add Type' settings of the inventory settings.
- change: GUI Boxes: 'Fade In/Out' and 'Move In/Out' settings have been rearranged into 'Open Box Behaviour' and 'Close Box Behaviour'. Scaling in/out can now be done independent of moving in/out.
- change: Animations: Mecanim: The 'Use Play' setting has been replaced by 'Play Mode' selection. You can now select if the state is not played directly ('None'), use 'Play' to directly play the state or use 'Cross Fade' to create a dynamic transition to the state.
- fix: GUI Boxes: Dragging a GUI box ('Drag Settings' settings) now works correctly.
- fix: Status Development: Fixed an issue with too high status changes on level up.
- fix: Event System: Camera Steps: Fixed an issue when not fading camera changes in 'Change Camera Position' steps.
- fix: Combatant Spawners: Respawn times where ignored when restarting a spawner (e.g. through 'Trigger Enter').
- fix: Interaction Components: Disabled interaction components could still start through trigger/collision start types.
- fix: Game Controls: Player: The 'Sprint Factor' of the 'Button' type player controls is now correctly forwarded to the component.
- fix: Menu Screens: Status Value Upgrade: Enabling 'Show No Upgrade' caused an error when status values without available upgrades where displayed.
- fix: Event System: Equipment Steps: 'Change Equipment' now unequips already equipped equipment into the combatant's inventory before equipping something new (when not using the new 'From Inventory' setting).
- fix: Combatants: Spawning a combatant's prefab with a 'Nav Mesh Agent' component could lead to the combatant being spawned at a different position.
- fix: HUDs: Navigation: Fixed an issue where 'Interaction' HUD elements wheren't displayed when having multiple added to the HUD and using the new UI.


Version 2.5.2:
- new: Abilities, Items: Target Settings: 'Orientation Requirements' settings available. Optionally check the orientation from user to target and target to user. Can be used to e.g. only make an ability useable when facing the back of a target.
- new: Weapons, Armors: Equipment Abilities: 'Learn Ability' settings available. An equipment ability can optionally be learned by the wearer. Either automatically when receiving experience points, spending experience points on it or by using it.
- new: Console Settings, Weapons, Armors: 'Increase Durability' and 'Decrease Durability' console text settings available. Add a text to the console if an equipment's durability increased or decreased. Weapons/armors can optionally override the default durability change console texts.
- new: Inventory Settings, Weapons, Armors: 'Durability Notification' settings available. Show notifications when the durability increased, decreased or an equipment is outworn. Weapons and armors can optionally override the default notifications.
- new: Weapons, Armors: 'Override Prefabs' settings available in equipment levels. Optionally override the prefab and viewer prefab/material of an equipment in the individual equipment levels.
- new: Battle Settings, Classes, Combatants: Level Up: 'Start Game Event' settings available in the level up bonus settings. Optionally start a game event when a combatant's base or class level increases. Can be limited to members of the player group.
- new: Move AI: Hunting: 'Stop Range' settings available. Optionally stops hunting the target when being within a defined range.
- new: Event System: Status Steps: 'Set In' setting available in 'Change Status Value' steps. Optionally change the status value in percent instead of the defined value.
- new: Event System: Active Group Steps: 'Switch Player' step available. Changes the player to the next or previous member of the active player group.
- new: Add Combatant Components: 'Move AI Settings' available. Optionally block or override the move AI of the added combatant.
- new: Game Controls: Group Member Keys: 'Not Dead' setting available. Optionally only use alive members when switching the player using the member change keys.
- new: HUDs: Combatant: 'No Outer Assign' setting available in 'Shortcut' HUD elements. Optionally block assigning shortcuts through drag and drop from outside sources (e.g. menu screens or other HUDs).
- change: Status Development: Using 'Formula' development type will now use the defined formula when initializing a combatant the needed amount of times. The 'Initial Value' of the development will be used for the minimum level.
- change: Event System: Movement Steps: 'Change Nav Mesh Target' now calls 'Resume' after setting the destination. This is needed in case the NavMesh agent was stopped.
- change: Event System: Base Steps: 'Time (s)' field has been replaced by advanced float value field in 'Wait', 'Wait For Input', Wait For Input Fork' and 'Raycast Object' steps. You can now use formulas, variables and other sources as float values.
- change: Event System: Spawn Steps: 'Time (s)' field has been replaced by advanced float value field in 'Destroy Prefab' and 'Destroy Object' steps. You can now use formulas, variables and other sources as float values.
- change: Event System: Function Steps: 'Emit After (s)' field has been replaced by advanced float value field in 'Emit Particles' steps. You can now use formulas, variables and other sources as float values.
- change: Event System: Camera Steps: 'Time (s)' field has been replaced by advanced float value field in 'Change Camera Position', 'Initial Camera Position', 'Shake Camera' and 'Rotate Camera Around' steps. You can now use formulas, variables and other sources as float values.
- change: Event System: Movement Steps: 'Time (s)' field has been replaced by advanced float value field in 'Change Position', 'Move Into Direction' and 'Change Scale' steps. You can now use formulas, variables and other sources as float values.
- change: Event System: Rotation Steps: 'Time (s)' field has been replaced by advanced float value field in 'Change Rotation' and 'Rotate To' steps. You can now use formulas, variables and other sources as float values.
- change: Event System: Variable Steps: 'Time (s)' field has been replaced by advanced float value field in 'Raycast To Variable' steps. You can now use formulas, variables and other sources as float values.
- change: Event System: Dialogue Steps: 'Close After (s)' field has been replaced by advanced float value field in 'Show Dialogue' steps. You can now use formulas, variables and other sources as float values.
- change: Event System: Image Steps: 'Time (s)' field has been replaced by advanced float value field in 'Change Image Position' steps. You can now use formulas, variables and other sources as float values.
- change: Event System: Rigidbody Steps: 'Time (s)' field has been replaced by advanced float value field in 'Add Force Rigidbody', 'Add Torque Rigidbody' and 'Position Force Rigidbody' steps. You can now use formulas, variables and other sources as float values.
- change: Weapons: Level Up: Counter attacks now also count as uses for 'Uses' type level up.
- fix: Update UI Text/Slider Components: Fixed an issue where the object update time couldn't be changed.
- fix: Player Controls: Mouse: The NavMesh agent (when using 'NavMesh Agent' move type) is now stopped when the player control is disabled.
- fix: New UI: Portraits: Displaying a portrait behind a GUI box now works correctly.
- fix: Event System: Image Steps: Images now scale and position correctly when using the new UI.
- fix: Event System: Battle Steps: 'Use Battle Action' step could throw errors when a combatant didn't know the ability or owns the item.
- fix: Game Variables: Fixed an issue where Vector3 variables haven't been saved correctly.


Version 2.5.1:
- new: Unity 5.1: ORK Framework now requires Unity 5.1.
- new: Interaction Components: 'UI' start type available in all interaction components. Start the interaction through a UnityEvent from the new UI (e.g. when clicking a button). Use the 'UIStart' function in the UI's event setting - either 'UIStart()' to use the player as starting object, or 'UIStart(GameObject)' to use a defind game object as starting object.
- new: Update UI Text Components: 'Update UI Text' component available. Updates the text of a selected 'Text' component. Can use text codes to show ORK information and special text codes to display combatant information (e.g. status values, etc.).
- new: Update UI Slider Components: 'Update UI Slider' component available. Updates the value (and min/max values) of a selected 'Slider' component. Can use a status value or attack/defence attribute of a combatant.
- new: Player Controls: Mouse: 'Move Type' setting available. Move the player either using a 'Character Controller', position interpolation or a 'NavMesh Agent' component.
- new: Quest Tasks: 'Activate Game Event', 'Inactivate Game Event', 'Finish Game Event' and 'Fail Game Event' settings available. Optionally starts a defined game event when the quest task is activated, inactivated, finished or failed.
- new: Menu Screens: 'Open Game Event' and 'Close Game Event' settings available. Optionally calls a game event when opening or closing a menu screen. You can use this to e.g. enable/disable image effects on the camera during menu screens.
- new: Menu Screens: Ability, Ability Tree, Crafting List, Inventory, Status Value Upgrade: 'Close All' setting available when using 'Close After Use' and 'No Return' options. Closes all currently open menu screens after using a menu item.
- new: Menu Settings: 'Default Mask Texture' setting available. Select the material that will be used for texture masks. Can optionally be overridden by each image that uses texture masks.
- new: Abilities: 'Cursor Settings' available when using 'None' target range and raycast targeting. Optionally change the cursor while the player can click somewhere for a raycast target.
- new: Status Effects: 'Next Action Change' setting available when using 'End Action'. Select how the status effect's end action will be added to the combatant's next action list. Either add the action at the end, remove all actions before adding the action or insert the action at the start of the list.
- new: Items: 'Action Type' setting available when using 'Use' item ability. Select the action type of the used ability - either base attack, counter attack or ability. The selected action type can influence the used ability (e.g. if the target blocks changes from base attacks).
- new: Event System: Status Steps, Variable Steps: 'Status Value To Variable' step available. Stores the value of a combatant's status value (current, base, min, max, displayed, preview or preview max value) into a float game variable.
- new: Event System: Status Steps, Variable Steps: 'Atk Attribute To Variable' step available. Stores the value of a combatant's attack attribute (current, base, min, max, start or preview value) into a float game variable.
- new: Event System: Status Steps, Variable Steps: 'Def Attribute To Variable' step available. Stores the value of a combatant's defence attribute (current, base, min, max, start or preview value) into a float game variable.
- new: Event System: Variable Steps: 'Formula To Variable' step available. Stores the result of a formula into a float game variable. Uses defined combatants as user and target of the formula.
- new: Event System: Battle Steps: 'Use Battle Action' step available. Tries to use a battle action or adds it to a combatant's next action list. If the action is used depends on the state of the combatant and battle system.
- new: Event System: Battle Steps: 'Action Type' setting available in 'Use Ability Calculation' steps. Select the action type of the used ability calculation - either base attack, counter attack or ability. The selected action type can influence the used ability (e.g. if the target blocks changes from base attacks).
- new: Battle Components: 'Appearing Chance' setting available when not using 'None' start type. Optionally define a chance a battle will appear in the scene when the scene is loaded. Failing the chance will remove the battle from the scene (optionally also set the 'Scene ID' to remove the battle permanently).
- new: Combatant Spawners: 'Appearing Chance' setting available when not using 'None' start type. Optionally define a chance a spawner will appear in the scene when the scene is loaded. Failing the chance will remove the spawner from the scene (optionally also set the 'Scene ID' to remove the spawner permanently).
- new: Global Events: 'Scene Change Type' setting available for 'Scene' type global events. Select the type of scene changes that will start the global event - either 'All', 'Scene Change' (i.e. normal changes during a running game), 'Battle' (battle related scene changes, e.g. battle start/end events), 'New Game' or 'Load Game' scene changes.
- new: Editor: You can now open an ORK project asset or event assets by double clicking on them in the Unity editor.
- new: Editor: You can now open other or create new ORK projects in the 'Editor > About' section. The last opened ORK project will be remembered (stored in the 'EditorData' asset) and opened next time you open the editor (when not opening a specific project). The scene wizard will by default select the last opened project for the 'Add Game Starter' functionality.
- new: Editor: You can now select individual scenes to be updated when saving the ORK project.
- change: Event System: Battle Steps: 'Use Ability Calculation' and 'Use Item Calculation' steps are now also available in game events.
- change: Images: Texture Masks: Due to creating materials through a shader in string form is deprecated, the 'Alpha Mask Texture' setting has been removed in all image settings. You now have to use a material instead, either define a default material in 'Menus > Menu Settings' or in the image's settings.
- change: Float Operators: Float operator fields now use 'Set' as default selection. This will only affect new settings (e.g. new event steps), not change already saved settings.
- change: Editor: Editor data (e.g. last opened sections or event files) are now stored in 'Assets/ORKFramework/EditorData.asset'. Deleting this file will not harm your project.
- fix: Player Controls: Mouse: Fixed an issue with the player moving to X=0, Y=0, Z=0 when the raycast didn't hit the ground.
- fix: Menu Screens: Ability: Passive abilities are now correctly displayed in 'Ability' menu parts when enabled in the settings.
- fix: Move AI: AI battle actions with targets out of range could cause the move AI to stop shortly.
- fix: Item Collection: Fixed an issue when using 'Auto Close' item collection dialogue without blocking the accept button and collecting multiple items.


Version 2.5.0:
- new: Item Types: 'Sub Type' settings available. Item types can now be sub types of other item types. 'Inventory' menu screen parts and battle menus allow navigating through the sub type tree structure.
- new: Ability Types: 'Sub Type' settings available. Ability types can now be sub types of other ability types. 'Ability' menu screen parts and battle menus allow navigating through the sub type tree structure.
- new: Ability Trees: 'Sub Tree' settings available. Ability trees can now be sub trees of other ability trees. 'Ability Tree' menu screen parts allow navigating through the sub tree structure.
- new: Quest Types: 'Sub Type' settings available. Quest types can now be sub types of other quest types. 'Quest' menu screen parts allow navigating through the sub type tree structure.
- new: Area Types: 'Sub Type' settings available. Area types can now be sub types of other area types. 'Bestiary (Area)' menu screen parts allow navigating through the sub type tree structure.
- new: Log Types: 'Sub Type' settings available. Log types can now be sub types of other log types. 'Log' menu screen parts allow navigating through the sub type tree structure.
- new: Crafting Types: 'Sub Type' settings available. Crafting types can now be sub types of other crafting types. 'Crafting' menu screen parts allow navigating through the sub type tree structure.
- new: Menu Screens: Inventory: 'Start Parent Type' settings available. Optionally set the parent item type the menu will be displayed with. The menu will only show items of the parent type and its sub types.
- new: Menu Screens: Ability: 'Start Parent Type' settings available. Optionally set the parent ability type the menu will be displayed with. The menu will only show abilities of the parent type and its sub types.
- new: Menu Screens: Ability Tree: 'Start Parent Tree' settings available. Optionally set the parent ability tree the menu will be displayed with. The menu will only show ability trees of the parent tree and its sub trees.
- new: Menu Screens: Quest: 'Start Parent Type' settings available. Optionally set the parent quest type the menu will be displayed with. The menu will only show quests of the parent type and its sub types.
- new: Menu Screens: Bestiary (Area): 'Start Parent Type' settings available. Optionally set the parent area type the menu will be displayed with. The menu will only show areas of the parent type and its sub types.
- new: Menu Screens: Log: 'Start Parent Type' settings available. Optionally set the parent log type the menu will be displayed with. The menu will only show logs of the parent type and its sub types.
- new: Menu Screens: Crafting: 'Start Parent Type' settings available. Optionally set the parent crafting type the menu will be displayed with. The menu will only show recipes of the parent type and its sub types.
- new: Move AI: Enemy Detection: 'Use Attack Allies' setting available. Optionally will detect allied combatants when a status effect with 'Attack Allies' enabled is applied to the combatant.
- new: Menu Settings, GUI Boxes: GUI Skins: 'Fade Button Children' setting available when using 'New UI' gui system type. Optionally fades the alpha or color of button child objects (i.e. text, images) on state change (selected, inactive, ...). Setting available for each button prefab individually (when used).
- new: Interaction Components: 'Start By Collider' setting available when using 'Trigger Enter', 'Trigger Stay' or 'Trigger Exit' start types. Allows trigger start types to be started by colliders with 'Is Trigger' disabled. By default enabled.
- new: Interaction Components: 'Start By Trigger' setting available when using 'Trigger Enter', 'Trigger Stay' or 'Trigger Exit' start types. Allows trigger start types to be started by colliders with 'Is Trigger' enabled. By default enabled.
- new: Interaction Components: 'Start By Root' setting available when using trigger or collision start types. Optionally starts only when the root of a game object causes the trigger/collision event. By default disabled.
- new: Vector3 Values: 'Random' Vector3 value type available. Allows creating a Vector3 with random axes defined by min/max values for each axis.
- new: Input Keys: Unity Input Manager: 'Is Joypad Axis' setting available. Enable this when the used Unity input manager key is a joypad axis to support down, hold and up actions.
- new: Event System: Camera Steps: 'Shake X-Axis', 'Shake Y-Axis' and 'Shake Z-Axis' settings available in 'Shake Camera' step. You can now optionally shake the camera on each axis. By default shakes on the X-axis.
- new: Event System: Movement Steps: 'Check Combatant Speed' step available. Checks the current horizontal or vertical movement speed of a combatant.
- new: Event System: Bestiary Steps: 'Check Bestiary Count' step available. Checks the number of entries in the bestiary.
- new: Event System: Bestiary Steps: 'Bestiary Count To Variable' step available. Stores the number of bestiary entries into a float game variable.
- new: Event System: Audio Steps: 'Change Music Volume' step available. Changes the music volume - either sets or fades the volume. This will change the overall music volume, not the volume of the currently playing music.
- new: Event System: Audio Steps: 'Change Sound VOlume' step available. Changes the sound volume - either sets or fades the volume. Already playing audio clps will not be updated by this.
- new: Event System: Variable Steps, Function Steps: 'Field To Variable' step available. Stores the value of a flied or property into a game variable. Supports string, bool, int/float and Vector2/3 values.
- new: Battle Events: Battle Steps: 'No Time Consume' step available. Stopts the action from consuming time, i.e. the timebar will not be reduced by the actions costs in 'Active Time Battles', the turn value will not be reset in 'Turn Based Battles' using 'Multi-Turns'.
- new: Battle Events: Battle Steps: 'Change Turn Value' step available. Changes the turn value of a combatant. The turn value is used to generate the turn order in 'Turn Based Battles' using 'Multi-Turns'.
- new: Battle Events: Battle Steps: 'Check Turn Value' step available. Checks the turn value of a combatant. The turn value is used to generate the turn order in 'Turn Based Battles' using 'Multi-Turns'.
- new: Battle Events: Battle Steps: 'Use Average' settings available in 'Check Turn' step. Optionally checks the average turn of the combatant's group or battle group instead of the combatant's turn.
- new: Formulas: Combatant Steps: 'Check Turn Value' step available. Checks the turn value of a combatant. The turn value is used to generate the turn order in 'Turn Based Battles' using 'Multi-Turns'.
- new: Battle AIs: Status Steps: 'Check Turn Value' step available. Checks the turn value of a combatant. The turn value is used to generate the turn order in 'Turn Based Battles' using 'Multi-Turns'.
- new: Main Menu: Auto Slot Selection: 'Background Image' settings available in the 'Auto Slot Selection' settings. Optionally display the save menu background images or own backgrounds when displaying the auto slot selection (and optionally override question).
- new: Save Game Menu: Load Game Menu: 'All Auto Save Slots' setting available in the 'Load Game Menu' settings. Optionally displays all auto save slots in load menus, including unused slots (displayed as inactive buttons).
- new: GUI Boxes: Choice Settings: 'Define Choice Height' settings available. Optionally defines the height of choices - content exceeding the height will not be visible. If disabled, the choice height is adjusted to the content of the choice.
- new: Status Effects: 'Set Max Stack' settings available when using effect stacking. Optionally set the maximum number of times a status effect can be stacked.
- change: Combatants: A combatant with an 'Attack Allies' effect applied will now also use the AI timeout when the combatant is AI controlled.
- change: Real Time Battle Areas: Disabling a real time battle area's game object will now leave the real time battle (if it's the only active real time battle area).
- fix: Event System: Dialogue Steps: There was a small delay when setting variables in a 'Value Input Dialogue' step, leading to a following variable check sometimes checking old values.
- fix: Move AI: Using 'NavMesh Agent' components moves the combatant again.
- fix: Move AI: Using raycasts in enemy detection is now working correctly.
- fix: Event System: Editor: Integer value selections will now display the correct formula.
- fix: Event System: Variable Steps: 'Variable To Variable' now correctly displays the variable options for source and target when using 'Object' variables.
- fix: Event System: Dialogues: Actor text codes for displaying combatant information using an actor without a combatant no longer crashes Unity.
- fix: UI: Fixed an issue when using Unity 5.1 and the new UI.
- fix: Input Keys: Fixed some issues with hold times and timeouts.
- fix: Battle Spots: Not using 'Place On Ground' no longer replaces the Y-axis position of battle spots when fighting in another scene.
- fix: Status Effects: Using 'Enabled' stackablae effects as auto effects could cause crashes.
- fix: Inventory: Fixed an issue with inventory limit not being updated when joining a new member to the group and adding items from the combatant's inventory.


Version 2.4.4:
- new: Status Development: Upgrade Settings: 'Own Name' and 'Own Description' settings available. Optionally override the name or description of the status value that will be upgraded.
- new: Ability Trees: 'Own Name' and 'Own Description' settings available. Optionally override the name or description of the ability that will be learned.
- new: Status Effects: 'None' option available in the 'On Recast' setting. This option will not change turns/time of an already applied status effect when reapplying it.
- new: Items, Weapons, Armors: 'Own Auto Stack' settings available. Items, weapons and armors can optionally override the auto stack settings defind in the 'Inventory Settings'.
- new: GUI Boxes: 'Use Minimum Height' setting available when using 'Auto' height adjustment. Optionally uses the height (H) defind by the content box bounds will be used as minimum height of the GUI box.
- new: Menu Screens: Sub Menus: 'Only For Usable' settings available. Optionally makes the sub menu only available for usable choices. E.g. the sub menu item will only be displayed when the ability is usable.
- new: Menu Screens: Equipment: 'Show Portrait' setting available in 'Part Box Settings'. Displays the portrait of a weapon/armor currently equipped on an equipment part.
- new: Menu Screens: Ability, Ability Tree, Equipment, Inventory: 'Information' element available in 'HUD Info Display' settings. Displays information about abilities/equipment using text codes, e.g. '%n' for name, '%tn' for type name.
- new: Text Codes: 'X' position and offset text codes available (found under 'Special' in the text editor). Use #xN# to define the X position (horizontal position) N of the following text. Use #+xN# to define the X offset (horizontal offset) N of the following text to the current text.
- new: Text Codes: 'Y' position and offset text codes available (found under 'Special' in the text editor). Use #yN# to define the Y position (vertical position) N of the following text. Use #+yN# to define the Y offset (vertical offset) N of the following text to the current text.
- new: Input Keys: Touch: 'Consume Fingers' setting available. Optionally consumes the fingers used for the touch input, making them unavailable for other touch interactions (e.g. 'Control' type HUDs).
- change: Inventory Settings: The 'Auto Stack' setting has been replaced by the 'Auto Stack Items', 'Auto Stack Weapons' and 'Auto Stack Armors' settings. You can now define auto stacking for them individually. Items, weapons and armors can optionally override these settings.
- change: Encryption: The class encrypting game data and save games has been moved from the core to the framework package. You can now use custom encryption by implementing the new 'ISecurityHandler' interface and registering your class in when ORK is initialized in the 'ORK' class.
- fix: HUDs: Combatant: Individual 'Combatant' type HUDs where not displayed after switching to a conditional prefab.
- fix: HUDs: Control: Mouse/touch position could be off when using a GUI box placed on a full screen GUI layer.
- fix: Inventory Notifications: The inventory notifications are now correctly displayed after loading a save game.
- fix: Quests: Automatic quest updates are now happening correctly after loading a save game.


Version 2.4.3:
- new: Group Shortcuts: The shortcut slot lists are now also available for groups. Group shortcuts can assign abilities, items, equipment and currency from multiple combatants.
- new: Control Maps: 'Group Shortcut' setting available for 'Shortcut' action type. Optionally uses the combatant's group shortcuts instead of individual shortcuts.
- new: Combatants, Classes: Default Shortcuts: 'Group Shortcut' setting available. Uses the combatant's group shortcuts instead of individual shortcuts for default shortcut assignments.
- new: Game Settings: Player/Group Settings: 'Shortcut List Count' setting available. Defines the number of available group shortcut lists.
- new: Menu Screens: Sub Menus: 'Group Shortcut' setting available for 'Assign Shortcut' sub-menu items. Optionally uses the menu screen user's group shortcuts instead of individual shortcuts.
- new: HUDs: Combatant: 'Group Shortcut' setting available in 'Shortcut' element types. Optionally uses the combatant's group shortcuts instead of individual shortcuts.
- new: Event System: Shortcut Steps: 'Group Shortcut' setting available in 'Change Shortcut', 'Check Shortcut' and 'Change Shortcut List' steps. Uses the combatant's group shortcuts instead of individual shortcuts.
- new: Event System: Save Game Steps: 'Has Auto Save Game' step available. Checks if a save game exists in the current auto save slot.
- new: Event System: Save Game Steps: 'Can Continue' step available. Checks if the game can be continued, i.e. a last used save game (or auto save slot) exists.
- new: Event System: Save Game Steps: 'Continue' step available. Loads the last used save game (or auto save slot). The event ends after this step.
- new: Event System: Animation Steps: 'Death Animation' step available. Plays the death animation on dead combatants. E.g. use this step to keep your dead player group members dead at the start of a battle.
- new: Event System: Animation Steps: 'Revive Animation' step available. Plays the revive animation on dead combatants. E.g. use this step to return your dead player's animation to the default at the end of a battle.
- new: Battle AI: Variable Steps: 'Get Object Variable' step available. Adds the combatant with the highest or lowest value of a defined float object variable to the target list.
- new: Battle AI: Action Steps: 'Force Found Targets' setting available in 'Attack', 'Ability', 'Class Ability' and 'Item' action steps. Optionally forces the action to only have the found targets available. The action can't fall back to other targets based on the combatant's AI settings if none of the targets is in range.
- new: Main Menu: 'URL Button' settings available. Optionally displays a button in the main menu (below the 'About' button) to open an URL in the default web browser.
- new: Shop Layouts: '%n' text code available in the 'Type Box' title text. Displays the buy/sell choice name that was selected in the type box title.
- new: Combatant Spawners: You can optionally use game objects as random spawn points for single combatant spawners (i.e. not using colliders to define a spawn area).
- change: Event System: 'Call Save Menu', 'Auto Save Game' and 'Auto Load Game' steps can now be found in the 'Save Game Steps'.
- change: Event System: Using formulas as int or float values can now also use unspawned player group members (actor type 'Player' or 'Member') for calculation.
- change: Auto Battles: Starting a battle when coming near an enemy now checks if any member of the player's battle group is alive. Until now, only the player (group leader) was checked, resulting in battles not starting when the player was dead.
- fix: Combatant Spawners: Remember Combatants could cause unspawned group members to be spawned upon returning to the scene.
- fix: Input Keys: Using the 'ORK Input Key' input origin with needing 'All' multiple input keys now works correctly when using the input key as axis.
- fix: Battle Events, Battle Start Events, Battle End Events, Phase Change Events: The 'Remove Temporary' step now removes all temporary combatants.
- fix: Saving Project: Added safeguards when saving the project to prevent unsaved data through errors when updating prefabs and scenes.
- fix: Auto Effects: Fixed a stack overflow happening through bad auto effect change loops.
- fix: Combatants: Adding a combatant to the player group using the 'Player' level settings for initialization already counted the new combatant to the group, tearing down the average level.
- fix: HUDs: Fading in sometimes caused a short flicker when using the new UI.
- fix: Move AI: Actions without targets could cause the move AI to return to following waypoints instead of continue hunting a target.
- fix: Combatant Selections: Adding a 'Back' option caused an error the 2nd time a combatant selection was used.


Version 2.4.2:
- new: Status Values: 'Earn on Level Up' setting available for 'Experience' type status values with 'None' experience type. Optionally increases the experience points on level up by the difference between current and previous level (like 'Normal' type status values).
- new: Attack Attributes: 'Immunity Notification' settings available. Optionally display a notification when a combatant is immune to damage due to an attribute being 0. Checks the target's attribute value and is displayed at the target's position. Can be overridden by each sub-attribute individually.
- new: Defence Attributes: 'Immunity Notification' settings available. Optionally display a notification when a combatant is immune to damage due to an attribute being 0. Checks the attacker's attribute value and is displayed at the target's position. Can be overridden by each sub-attribute individually.
- new: Combatants: Auto Start Battle Settings: 'Start on Move Detection' settings available. Optionally use move detection (sight, movement) with range and angle checks (like 'Move AI' enemy detection) to automatically start battles.
- new: Combatants, Classes: Default Shortcuts: 'Attack' and 'Counter Attack' shortcut types available. Uses the combatant's base attack or counter attack as default shortcut.
- new: Move AI: Enemy Detection: 'From Child' setting available for move detections. Optionally uses a child object of the combatant for range and angle checks. E.g. using this to check from the combatant's head for a sight radius will also use head turnings from animations.
- new: Camera Controls: 'Initial Damping' setting available for the 'Top Down Border' camera controls. Uses damping (position/height) when first adjusting the camera position to the player. By default enabled.
- new: Input Keys: 'Input Handling' settings available for 'Mouse' and 'Touch' input origins. Define when to receive the input (e.g. down, hold, ...) and timeouts, same settings as in 'Unity Input Manager' and 'Key Code' input origins.
- new: Event System: Status Steps: 'Clear Ability Reuse' step available. Removes all ability reuse blocks from a combatant, allowing an ability that's blocked for a defind amount of turns/time to be used again.
- new: Event System: Shortcut Steps: 'Attack' and 'Counter Attack' shortcut types available. Shortcut steps can now use a combatant's base attack and counter attack when changing or checking a shortcut slot.
- new: Battle Events, Battle Start Events, Battle End Events, Phase Change Events: Battle Steps: 'Mark As Temporary' step available. Marks a defined combatant as temporary - temporary combatants can be removed using the 'Remove Temporary' step. This mechanic can be used e.g. for summon game mechanics.
- new: Battle Events, Battle Start Events, Battle End Events, Phase Change Events: Battle Steps: 'Remove Temporaray' step available. Removes temporary combatants from the battle and their groups. This mechanic can be used e.g. for summon game mechanics.
- new: Battle Events: Battle Steps: 'Mark As Temporary' setting available in 'Join Battle' steps. Optionally marks the new combatant as temporary - temporary combatants can be removed using the 'Remove Temporary' step. This mechanic can be used e.g. for summon game mechanics.
- new: Battle Events: Battle Steps: 'New Group' setting available in 'Join Battle' steps. Optionally creates a new group for the combatant instead of joining an existing group.
- new: Battle Events: Battle Steps: 'Remove From Group' setting avaialble in 'Leave Battle' steps. Optionally removes the combatant leaving battle from the group it belongs to.
- new: HUDs: Combatant: 'Remove On Drop' settings available in 'Shortcut' HUD elements. Optionally removes an assigned shortcut when dropped into the game world (i.e. not on a combatant to be used).
- change: Auto Status Effects: Adding status effects using 'Auto Effect' settings (e.g. combatants, classes) is no longer limited to first spawn and battle start.
- fix: Status Values: Status recalculation order could cause combined status values to have the wrong value when influenced by status effects.
- fix: Combatant Spawners: Remembered combatants now use the waypoints set up in the combatant spawner's settings.
- fix: Combatant Spawners: Respawning could, in some cases, respawn all missing combatants at once instead of waiting the individual times.
- fix: Input Keys: 'Touch' input origins didn't work properly as buttons.
- fix: Input Keys: Hold timeouts could in some cases not work when using 'Up' input handling.
- fix: Abilities: Using 'Turn' ability reuse with multiple abilities could lead to blocks not being removed after the battle.
- fix: Menu Screens: 'Equipment' menu parts displayed the name of an equipment instead of the equipment part when using '%n' in the equipment box title.


Version 2.4.1:
- new: Value Bars: 'Icon Value' settings available when enabling 'Use Icons' in value bars. Defines the value one icon will display and if the value is in percent of the full bar. E.g. can be used to have one icon for the whole HP (100 %) or one icon per 10 HP.
- new: Currency, Items, Weapons, Armors: 'Spawn Offset' setting available. Optionally adds an offset to the position of the prefab spawned by an item collector.
- new: Combatant Spawners, Random Battle Area: 'Use Nearest Battle' setting available. Optionally uses the nearest game object with a 'Battle' component attached within a defined range.
- new: Combatants: 'AI Controlled Player' setting available. Optionally makes the player combatant AI controlled in battle, i.e. the player can't give commands to the combatant.
- change: Menu Screens: Changing between menu screens with both using 'Own Music' will no longer shortly resume the previous music.
- change: Battle Start Events: Loading a new scene in a battle start event (i.e. fighting in a different scene) will place already created battle spots on the ground.
- change: Battle Start Events: Loading a new scene in a battle start event (i.e. fighting in a different scene) will trigger respawn in a combatant's spawner to remove the remembered combatant and store it's respawn time.
- change: Player Group: Changing the player (i.e. leader of the player group) will only spawn the new player when the old player was already spawned.
- fix: Saving: Auto updating data references in prefabs and scenes when saving the project could result in an error.
- fix: HUDs: Background images will now be placed correctly behind the GUI box.
- fix: Game Controls: Using jump settings in 'Button' player controls without the combatant speed resulted in an error when jumping.
- fix: Menu Screens: Calling a menu screen that has previously been opened with a removed group member from the event system will reset to the player combatant.
- fix: Move AIs: Ending a battle action will no longer trigger an idle action when in waypoint mode - this resulted in selecting the next waypoint after each battle action.
- fix: Battle AI: Completed bestiary entries could cause an error in some battle AI steps.


Version 2.4.0:
- new: Unity 5: ORK Framework now requires Unity 5.


Version 2.3.1:
- new: Combatant Spawners: 'Remember Combatants' setting available. Optionally remembers the spawned combatants (status and position) and respawn times when leaving the scene. The combatants will be respawned where they where when reloading the scene.
- new: Save Game Menu: 'Spawned Combatants' setting available in the 'Save Settings'. Optionally saves the combatants spawned by 'Combatant Spawner' components with 'Remember Combatants' enabled with the save game. Either saves the combatants of the 'Current' scene, 'All' scenes or 'None' scene at all.
- new: Input Keys: 'Invert Axis' setting available for all input origins. Optionally inverts the input axis, i.e. 1 will become -1, -1 will become 1.
- new: Weapons, Armors: 'Chance' settings available for random status value bonuses. Optionally only adds random bonuses to status values based on chance.
- new: Weapons, Armors: 'Add Bonus Range' setting available for random status value bonuses. Either adds 'All' random bonuses, a 'Random' bonus (no bonus is added if chance fails), or adds the 'First' bonus due do chance settings.
- new: Float Values: 'Random' value type available. Uses a random value between two defined values. Available throughout the framework.
- new: GUI Boxes: Choice Settings: 'Position' choice mode available. Optionally define positions for choices. When exceeding the defined number of positions, the remaining choices will be displayed in 'List' mode.
- new: HUDs: Combatant: 'Position' cell mode available for 'Shortcut' HUD elements. Optionally define the positions of each shorcut slot cell.
- new: HUDs: Combatant: 'Use Auto Target' setting available for 'Shortcut' HUD elements. Optionally uses shortcuts when clicked on automatically selected targets.
- new: HUDs: Combatant: 'Set Size' settings available for 'Shortcut' HUD element info labels. You can now optionally set the size of info labels used to display empty or assigned shortcut slots.
- new: HUDs: Combatant: 'Use Icon' settings available for 'Shortcut' HUD element info labels. Optionally gives more control over displaying a shortcut's icon (e.g. scale mode) than using the '%i' text code in text.
- new: HUDs: Tooltip: 'Use Bar' settings available. Tooltip HUDs can now display level points (ability, equipment) and durability (equipment) value bars instead of text.
- new: HUDs: Tooltip: New text codes available to display level points (ability, equipment) and durability (equipment) information.
- new: Event System: Scene Steps: 'Remove Spawned Combatants' setting available in the 'Remove Scene Data' step. Optionally removes stored data of spawned combatants from the scene. Useful if you e.g. want to clear all spawners when leaving a dungeon.
- new: Battle Events: Battle Steps: 'Consume Costs' step available. Consumes the use costs of an action (e.g ability use costs, consumes an item). The step will consume the costs each time it's used.
- new: Abilities, Items: Target Settings: 'Auto Target' settings available. Optionally uses status requirements and variable conditions to automatically select a target. This is used in battle menus to select the a combatant (still requires the player to accept the choice), control maps with auto target and AI target selection.
- new: Combatants: AI Settings: 'Auto Target' setting available. Uses the 'Auto Target' settings of a used ability or item when selecting an AI target. If not used by the ability/item or not found, the nearest (if enabled) or a random target will be used.
- new: Camera Events: 'In Blocked Controls' setting available. The camera event component will be executed while the player controls are blocked (e.g. in events). By default enabled.
- new: Save Game Menu: 'Add Cancel' settings available in the 'Save Game Menu' and 'Load Game Menu' settings. Adding the 'Cancel' choice to the file list is now optional. By default enabled.
- new: Menu Settings: 'Bonus Display' settings available. Define the text representation of status value bonuses and attack/defence attribute bonuses. Can be displayed in descriptions of bonus giving things using the '%bonus' text code.
- new: Status Effects, Passive Abilities, Weapons, Amrors, Combatants, Classes: '%bonus' text code available in descriptions. Displays the status value and attack/defence attribute bonuses as defined in the 'Bonus Display' settings.
- new: Text Codes: '#percent' text code available to display a '%' sign. Use this text code to display '%' in texts that use special text codes (e.g. '%' to display the quantity of an item).
- change: Click Controls: All 'Enable Double Click' settings have been replaced by 'Enable Clicking' and 'Click Count' settings. You can now define the number of clicks if needed. By default set to 2 clicks (i.e. restores the old double click setting).
- change: HUDs: Combatant: 'Enable Drop' no longer needs to be enabled to use drag+drop to change shortcuts in 'Shortcut' HUD elements.
- fix: Group: Getting average group levels/turns no longer throws errors when no members are in a group.
- fix: Real Time Battle Areas: Using colliders to limit the area could result in the battle not starting when spawning inside the area due to first entering with the interaction controller.
- fix: Menu Screens: Equipment, Inventory: 'Durability' HUD info displays will now also be displayed when 'Enable Dragging', 'Enable Double Click' and 'Enable Tooltip' are disabled.
- fix: Move AIs: Close distance target position checks could lead to the check interval not being reset, resulting in the combatant not using an updated target position.
- fix: Mounting Objects: Setting the scale when mounting an object on another object will now use the correct scale in relation to the parent object.


Version 2.3.0:
- new: Group Abilities: Abilities can now optionally be learned by the group of a combatant instead of a single combatant. Group abilities are available to all members of the group and can be used like normal abilities.
- new: Abilitiy Learning: 'Group Ability' setting available. Optionally learns the ability to the combatant's group instead to the combatant. Available throughout the framework.
- new: Abilitiy Forgetting: 'Group Ability' setting available. Optionally forgets the ability of the combatant's group instead of the combatant. Available throughout the framework.
- new: Shops: 'Abilities' settings available. Shops can now also sell abilities and group abilities. A bought ability will be learned by the shop's user combatant, or the user's group (when using group abilities). An ability can only be sold once per combatant/group, there is no quantity selection displayed.
- new: Status Effect Types: 'Status Effect Types' sub-section now available in the 'Status' section. Status effect types can be used to separate status effects. Effect changes can optionally use all status effects of a selected type, the HUD can optionally display only selected status effect types.
- new: Status Effects: 'Status Effect Type' setting available. Defines the status effect type of the status effect. The type is used to separate status effects, e.g. when displayed in a HUD or change all effects of a selected type.
- new: Status Effect Changes: 'Use Type' and settings available when changing status effects (e.g. ability status changes, auto effects, etc.). Optionally checks uses all status effects of a selected status effect type when changing effects (e.g. remove all 'Negative' type effects).
- new: Status Requirements: 'Status Effect Type' status check available. Checks if a status effect of the selected status effect type is or isn't applied to the combatant.
- new: Status Requirements: 'Weapon Item Type' and 'Armor Item Type' status checks available. Checks if a weapon/armor of the selected item type is or isn't equipped on the combatant.
- new: Classes, Combatants, Passive Abilities, Weapons, Armors, Status Effects: 'Attack Status Effects' settings available. Abilities and items can automatically use the user's attack status effect changes on the target.
- new: Classes, Combatants, Passive Abilities, Weapons, Armors, Status Effects: 'Defence Status Effects' settings available. Abilities and items can automatically use the target's defence status effect changes on the user.
- new: Abilities, Items: 'Use Attack Effects' and 'Use Defence Effects' settings available for value changes of active abilities and items. Optionally uses the user's 'Attack Status Effects' and the target's 'Defence Status Effects'. By default disabled.
- new: Weapons, Armors: 'Durability' settings available for the different level settings of equipment. A weapon or armor can optionally have a durability and wear off. If an equipment is outworn (i.e. durability reaches 0), it can either not give any bonuses any more, be unequipped or destroyed. Durability can be changes using the event system.
- new: Weapons, Armors: 'Own Outworn Text' settings available in the equipment's console texts. Optionally overrides the default console text displayed when an equipment's durability reaches 0.
- new: Input Keys: 'Custom' input origin settings available. Input keys can now use custom scripts to get button and axis values. Calls a static function of a class using reflection - button function must return a bool value, axis function must return a float value.
- new: Status Values: 'From Minimum' setting available for 'Experience' type status values. Optionally restarts the status value from it's minimum value when leveling up instead of continuing to grow (using the previous level's maximum value as minimum).
- new: GUI Boxes: Choice Settings: 'Choice Mode' settings available. Choices can be displayed in 'List' and 'Circle' mode. 'List' mode displays choices in a list (as it has been until now). 'Circle' mode displays choices in a circle around a center position in the GUI box.
- new: GUI Boxes: Choice Settings: 'Header Settings' available. A GUI box can now optionally display headers above choice buttons.
- new: Menu System: 'Header Texts' settings available in most menu parts. Optionally display headers above the choice buttons.
- new: Shop Layouts: 'Header Texts' settings available in 'Buy/Sell Box', 'Type Box' and 'List Box' settings. Optionally display headers above the choice buttons.
- new: Battle Menus: 'Header Texts' settings available. Optionally display headers above the choice buttons. Sub-menus can optionally have different header texts.
- new: Battle Menus: 'Whole Group' setting available for 'Auto' battle menu items. The 'Auto' command can now optionally be used for the whole battle group of the combatant - each member of the group will use the 'Auto' command once. Not used in 'Real Time' battles.
- new: HUDs: Combatant, Turn Order: 'Type Display Limit' settings available for 'Status Effect' HUD elements. Optionally only displays status effects of selected status effect types. Can be used to e.g. separate positive and negative effects.
- new: HUDs: Combatant, Turn Order: New text codes available for 'Status Value' HUD elements. '%m2' displays the minimum value, '%r' displays the remaining value to the maximum value (i.e. max - current value), '%r2' displays the remaining value to the minimum value (i.e. current - min value).
- new: HUDs: Combatant, Turn Order: 'Check Attribute Value' settings available for 'Attack Attribute' and 'Defence Attribute' HUD elements when listing attributes. Optionally checks the value of each attribute before displaying it, e.g. to only display attributes greater than 100.
- new: HUDs: Combatant, Turn Order: 'Relative Offset' settings available when using 'Group' combatant HUDs or turn order HUDs. The offset of the GUI boxes used for the individual HUDs can optionally be relative to the GUI box of the previous combatant. The position will be automatically adjusted, e.g. if the HUD size of one combatant is changed.
- new: HUDs: Combatant: 'Cell Mode' settings available for 'Shortcut' HUD elements. Like choices, shortcut slots can now also either be displayed as a 'List' (like until now) or in a 'Circle' around a defined position in the HUD element.
- new: Event System: Check Steps: 'Check Language' step available. Checks the currently used language of the game.
- new: Event System: Animation Steps: 'Auto Animation' step available. Use this step to enable or disable the auto move animation of a combatant.
- new: Event System: Function Steps: 'Is Static' setting available in the 'Call Function', 'Check Function' and 'Function To Variable' steps. Optionally calls a static function of a class - i.e. it doesn't require a component added to a game object.
- new: Event System: Function Steps: 'Is Static' setting available in the 'Change Fields' and 'Check Fields' step. Optionally uses static fields/properties of a class - i.e. it doesn't require a component added to a game object.
- new: Event System: Function Steps: 'Emit After (s)' setting available in the 'Emit Particles' step. Optionally starts/stops emitting particles on a game object after a defined amount of time.
- new: Event System: Movement Steps: 'Ignore Y' setting available in the 'Change Position' and 'Move Into Direction' steps. Ignores the Y-axis difference when moving/facing the target, i.e. the mover will maintain its Y-axis position (unless gravity is applied). By default enabled.
- new: Event System: Equipment Steps: 'Change Equip Durability' step available. Changes the durability of an equipment currently equipped on an equipment part or all parts of a combatant.
- new: Event System: Equipment Steps, Check Steps: 'Check Equip Durability' step available. Checks the durability of an equipment currently equipped on an equipment part or all parts of a combatant.
- new: Event System: Equipment Steps, Inventory Steps: 'Change Inventory Durability' step available. Changes the durability of an equipment currently placed in the inventory of a combatant.
- new: Event System: Equipment Steps, Inventory Steps, Check Steps: 'Check Inventory Durability' step available. Checks the durability of an equipment currently placed in the inventory of a combatant.
- new: Event System: Active Group Steps: 'Destroy Prefab' setting available in the 'Leave Active Group' and 'Leave Battle Group' steps. Optionally destroys a spawned prefab of a combatant that'll leave the group. By default enabled.
- new: Event System: Variable Steps: 'Variable To Transform' step available. Sets a game object's position, rotation or scale to the value of a Vector3 game variable.
- new: Battle Events: Battle Steps: 'Reconsume' setting available in the 'Calculate' step. Optionally consumes use costs or items again, even if they already have been consumed.
- new: Battle Events: Battle Steps: 'Can Use Action' step available. Checks if the user can use the action of the battle event.
- new: Main Menu: Custom Choices: 'Is Static' setting available for custom choices. Optionally calls a static function of a class - i.e. it doesn't require a component added to a game object.
- new: Combatants: AI Settings: 'Real Time AI Range' settings available. Using the battle AI can optionally be limited to a defined range to the leader of the combatant's group. You can use this setting to let AI controlled player group members stop fighting when the player moves away.
- new: Move AI: 'Prioritise Leader' settings available. Following the leader can optionally take priority over other targets when outside a defined range to the leader of the combatant's group.
- new: Status Bonuses: 'Status Change Modifier' bonus settings available. Optionally add bonuses to status value changes by abilities or items (value change settings), the bonus can be given for positive, negative or all changes. The default change modifier is 100 (i.e. 100 %), the bonuses are added to it. E.g. adding -10 bonus to negative MP changes will reduce the MP use costs to 90 %.
- new: Abilities, Items: 'Ignore Change Modifier' setting available for all value change settings (e.g. use costs, target changes). A status value change can optionally ignore the status change modifier bonuses and use the default 100 % modifier.
- new: Abilities: 'Own Group Learning Text' and 'Own Group Forgetting Text' settings available in the 'Console Texts' of the ability. Optionally overrides the default console texts for learning/forgetting a group ability.
- new: Abilities: 'Buy Price' setting available per ability level. Defines the price an ability will be sold for at shops. Can optionally be overridden by the shop's item list.
- new: Console Settings: 'Group Ability Text' settings available in 'Learning Texts' and 'Forgetting Texts' settings. Define the console texts that will be displayed when a group ability is learned or forgotten.
- new: Console Settings: 'Weapon Outworn Text' and 'Armor Outworn Text' settings availble in 'Inventory Texts' settings. Deinfe the console texts that will be displayed when a weapon's or armor's durability reaches 0.
- new: Battle End: New text codes available for 'Money Text', 'Item Text', 'Status Value Text', 'Ability Learn Text' and 'Ability Tree Learn Text' settings. Use '%cn' (name), '%cd' (description) and '%ci' (icon) to display information about the combatant.
- new: Battle End: 'Group Ability Learn Text' setting available. Will be displayed if a new group ability is learned through level up.
- change: Status Requirements: 'Ability Check' and 'Is Valid' settings replace the old ability status check. You can know check if an ability is known to the combatant (i.e. learned, temporary or group ability), learned or a group ability. Old settings will automatically be upated.
- change: Menu Screens: Equipment, Inventory: The 'Level Points Display' settings are now named 'HUD Info Display' and can also display durability information of an equipment.
- fix: Combatant Spawners: Spawning single combatants on a position (i.e. not using a collider for area spawning) could result in creating multiple combatants when respawning.
- fix: GUI System: New UI: The event system's 'Image Steps' are now working correctly when using the new UI.
- fix: GUI System: New UI: 'Selected Choice Offset' setting is now working correctly when using the new UI.
- fix: GUI System: Legacy GUI: The drag box will no longer be displayed twice, with one being displayed even after the drag finished.
- fix: Event System: Movement Steps: The 'Change Position' step's movement behaved differently when enabling/disabling 'Face Direction'.
- fix: Blocking Controls: Changing group members involving the player could result in the control components not being blocked when the control was blocked while changing members.
- fix: Turn Based Battles: A combatant dying while having the battle menu open could result in the battle not progressing.


Version 2.2.4:
- new: Status Requirements: 'Inventory' status check available. The combatant (or group) must or mustn't have a defind item, weapon, armor or currency in the inventory.
- new: Crafting System: The crafting system now also allows creating new items by adding items, equipment and currency to a combatant's crafting list. When creating using the crafting list, the first crafting recipe matching the items in the crafting list will be used. Either uses only known recipes or checks all recipes and learns unknown recipes upon successful creation.
- new: Menu Screens: 'Crafting List' menu part available. Displays the items, equipment and currency added to the user's crafting list. When using the crafting list for crafting, the first recipe that matches the items added to the list will be used.
- new: Menu Screens: Sub Menus: 'Crafting List' sub menu action available. Adds a selected item, equipment or currency to the user's crafting list.
- new: Menu Screens: Bestiary (Area): 'Show OK Button' and 'Show Cancel Button' settings available. Optionally displays the ok/cancel buttons of the GUI box.
- new: Event System: Dialogue Steps: 'Show OK Button' and 'Show Cancel Button' settings available in the 'Bestiary Dialogue' step. Optionally displays the ok/cancel buttons of the GUI box.
- new: Event System: Dialogue Steps: 'Quest Conditions' settings available in 'Choice' type 'Show Dialogue' steps. A choice can optionally use quest or task status conditions to determine if it will be displayed.
- new: Event System: Dialogue Steps: 'Status Requirements' settings available in 'Coice' type 'Show Dialogue' steps. A choice can optionally use status requirements to determine if it will be displayed.
- new: Event System: Active Group Steps: 'Spawn Group Members' step available. Spawns the other members of the active player group or battle group. Requires the player to already be spawned in the scene.
- new: Event System: Active Group Steps: 'Destroy Group Members' step available. Destroys all spawned members of the active player group except the player.
- new: Event System: Crafting Steps: 'Add Recipe Outcome' step available. Adds the outcome of a selected crafting recipe to a combatant's inventory. This doesn't consume ingredients or checks for requirements or crafting chance.
- new: Event System: Crafting Steps: 'Remove Needed Ingredients' step available. Removes the ingredients needed for a selected crafting recipe from a combatant's inventory.
- new: Event System: Base Steps, Function Steps: 'Add Control Component' step available. Adds a defined component of a game object to the player or camera control list. The component will be enabled/disabled with the selected controls.
- new: Event System: Base Steps, Function Steps: 'Remove Control Component' step available. Removes a defined component of a game object from the player or camera control list.
- new: Value Bars: 'Hide Empty Bar' setting available. Value bars (e.g. displaying status values in HUDs) can optionally be hidden if the displayed value is at the minimum value or below.
- new: Value Bars: 'Interpolate Colors' and 'Interpolate Empty Colors' settings available. Optionally interpolates between the colors used for the different percentages of the value bar. Only used when using colors instead of images.
- new: HUDs: Combatant, Turn Order: 'Limit Bar Display' settings available. Status value bars can optionally be limited to a defined value range (percent or absolute values). This allows creating split value bars, e.g. 2 HP bars from 0-50 % and 50-100%.
- new: Combatants: Death Settings: 'Variable Origin' setting available for death variable changes. The variable changes when a combatant dies can now be made on global variables, the combatant's object variables or the combatant spawner's object variables. By default using global variables.
- new: Abilities, Weapons, Armors: 'Own Description' settings available for the different level settings of abilities, weapons and armors. Optionally overrides the description of the ability, weapon or armor with a new description for a defined level.
- new: Abilities, Items: 'Active Time Order Changes' settings available. An ability/item can now optionally change the timebar of the target. A positive value will increase, a negative value will decrease the timebar.
- change: HUDs: Combatant: The 'No Inner Assign' setting has been replaced by the 'Inner Assign' setting in 'Shortcut' HUD elements. When a shortcut slot is assigned from the same HUD element, you can now either 'Keep' the old assignment, 'Remove' the old assignment, 'Spap' old and new slot assignment or prevent inner assignment ('None').
- change: Editor: Menu Screens: The 'Add Menu Part' list is now sorted alphabetically.
- fix: GUI System: New UI: Fixed problems with drag+drop when using the new UI.
- fix: GUI System: New UI: When first displaying a GUI box or changing focus, the selected choice will now be marked as selected object in the new UI event system.
- fix: Turn Based Battles: Using 'Death Immediately' without 'End Immediately' could lead to starting multiple new turns while the player was dying.
- fix: HUDs: Combatants: Only using backgrounds for 'Shortcut' element slots could result in a wrongly calculated content size, hiding parts of the HUD.
- fix: Event System: Spawn Steps: Using the 'Spawn Prefab' step without using the audio options and spawning at a position could lead to an error.


Version 2.2.3:
- new: Abilities, Items: 'Use Requirement' settings available for status value changes of active abilities and items. Optionally checks 'Status Requirements' and 'Variable Conditions' on the user or target, the changes will only be performed if the check is valid.
- new: Status Effect Changes: 'Use Requirement' settings available when changing status effects (e.g. ability status changes, auto effects, etc.). Optionally checks 'Status Requirements' and 'Variable Conditions' on the user or target, the changes will only be performed if the check is valid.
- new: Combatants: Battle Settings: 'Use Requirement' settings available for 'Auto Start Battle' settings. Optionally checks 'Status Requirements' and 'Variable Conditions' on the user (enemy) or target (player), the auto battles will only start if the check is valid.
- new: Combatants: Conditional Prefabs: 'Use Spawned Scale' setting available. Optionally uses the scale of the currently spawned prefab when changing prefabs. By default enabled.
- new: Battle Events: Battle Steps: 'Change Last Target' step available. Changes the last targets of a combatant. This can influence various things, e.g. AI target selection.
- new: Formulas: Variable Steps: 'Store Formula Value' step available. Stores the current value of the formula into a float game variable.
- new: Text Input: 'Is Password' setting available for game options and input dialogues. Optionally uses a text input field as password input, masking the user's input with a '*'.
- new: Music: 'Use PCM' settings available for music clip loops. Optionally checks and sets the playback position in PCM samples instead of time.
- new: GUI System: New UI: 'Keep Prefab Height' settings available for text, toggle and slider input prefabs. Optionally keeps the height of the used prefabs instead of adjusting the height to the used font size.
- new: Menu System: Crafting: 'Info Only' setting available in the 'Crafting Box Settings'. Optionally only displays the crafting recipe information and doesn't allow using them.
- new: Crafting Recipes: 'Use Requirements' settings available. Optionally checks 'Status Requirements' and 'Variable Conditions' on the user of the recipe to determine if it can be used.
- new: Event System: Crafting Steps: 'Can Use Recipe' step available. Checks if a combatant can use a selected crafting recipe.
- new: Event System: Camera Steps: 'Change Camera Options' step available. Changes various settings on a camera that can't be changed with the 'Change Field' step.
- new: Event System: Function Steps: 'Set Object Layer' step available. Sets the layer of a game object.
- new: Event System: Function Steps: 'Check Object Layer' step available. Checks the layer of a game object.
- new: Event System: Function Steps: 'Place Object' setting avaialble in the 'Mount Object' step. Placing a game object when mounting it to another object is now optional. By default enabled.
- new: Event System: Status Steps: 'Change Defence Attribute' step available. Changes a defence attribute of a combatant permanently.
- new: Event System: Battle Steps: 'Add Loot' step available. Adds items, weapons, armors or currency to the battle's loot.
- new: Event System: Battle Steps: 'Add Experience Reward' step available. Adds experience to the battle's experience gains.
- new: Event System: Status Steps: 'Revive' step available. Revives a combatant or the combatant's group. The step doesn't change 'Consumable' type status values, i.e. the combatant will die again if the status value causing the death is still the same.
- new: Status Effects: 'Animate Damage' settings available for status conditions. Negative status changes can now optionally play a damage animation on the combatant.
- new: Status Requirements: 'Group Leader' status check available. The combatant must or mustn't be the leader of his group.
- new: Status Requirements: 'Group Size' status check available. The combatant's group size will be compared with a defined value.
- change: GUI System: New UI: The GUI box instance used for a box object in the new UI can now be accessed through the 'GUIBox' property in the 'GUIBoxComponent' attached to it.
- change: GUI Boxes: The 'Inactive Alpha' settings for choices and tabs are no longer available when using the new UI. This is handled by the prefabs used for buttons/tabs, the 'Inactive Alpha' setting wasn't used in the new UI.
- change: Combatant Component Inspector: The inspector display of the combatant component now also displays the defence attributes of the selected combatant game object.
- fix: Combatants: A battle action without targets (e.g. an AoE ability) could cause errors when setting the last target's of a combatant.
- fix: Event System: Camera Steps: Changing the 'Field of View' in a 'Change Camera Position' step is working again.
- fix: Event System: Rotation Steps: The 'Rotate To' step will now correctly rotate into the shorter direction when using fading.
- fix: GUI System: New UI: Opening/selecting the ORK Framework editor while playing wont throw errors any longer.
- fix: HUDs: Combatant: Using the 'Change Combatant' click type and clicking on the current player's HUD removed the player controls but didn't add them again. Changing player now only works if the combatant isn't the current player.
- fix: Changing Player: Changing the player could result in still using the old interaction controller in some cases.


Version 2.2.2:
- new: Combatants: 'Shortcut List Count' setting available. A combatant can now have more than one shortcut list, each list contains of a various amount of slots. Lists can be switched using the event system.
- new: Combatants: 'Use Class Shortcuts' setting available. A combatant can optionally use class based shortcut lists.
- new: Classes: 'Shortcut List Count' and 'Default Shortcut' settings available. Shortcut lists can now optionally be based on classes, changing a class will also change the shortcut lists.
- new: Event System: Shortcut Steps: 'Change Shortcut List' step available. Changes a combatant's active shortcut list.
- new: HUDs: Combatant: 'No Inner Assign' setting available in 'Shortcut' HUD elements. Prevents assigning a shortcut slot from another slot of the same HUD element.
- change: Event System: The shortcut steps can now be found in the new 'Shortcut Steps' list.
- fix: Event System: Dialogue Steps: Restarting an event while an 'Autoclose' dialogue (without using 'Wait) is displayed wont result in errors.
- fix: HUDs: A HUD without any HUD elements (e.g. only using a background image) caused errors.
- fix: GUI System: New UI: Using text typing displayed the whole text for a frame when first displaying a GUI box.
- fix: Status Effects: Using 'End On Abilities' caused a status effect to be removed by the same ability that applied it.
- fix: Status Effects: Using an 'End Action' in combination with 'End On Abilities' could in some cases lead to an error.


Version 2.2.1:
- new: GUI System: New UI: The new UI now also supports text typing.
- new: GUI System: New UI: 'Layer' setting available. Select the layer the UI canvas will be placed at.
- new: Save Games: Support for saving/loading custom save data with ORK Framework save games. Use the function 'ORK.SaveGame.RegisterCustomData' to register a class (implementing 'ISaveData') that saves/loads your custom data.
- new: Event System: Base Steps: 'Add Combatant' step available. Adds a combatant to a game object (only if the game object doesn't already have a combatant).
- new: Event System: Base Steps: 'Use Mouse Position' setting available in the 'Raycast Object' step. Optionally uses the mouse position as target for raycasts when not using input.
- new: Event System: Variable Steps: 'Use Mouse Position' setting available in the 'Raycast to Variable' step. Optionally uses the mouse position as target for raycasts when not using input.
- new: Abilities: 'Hidden' setting available. Optionally hides the ability in 'Ability' and 'Ability Tree' menu screen parts and in battle menus.
- new: Items: 'Hidden' setting available. Optionally hides the item in 'Inventory' menu screen parts and in battle menus.
- new: Combatants: Battle Settings: 'Base Experience Factor' settings available. Defines the base experience factor of a combatant. The experience factor influences how much experience a combatant gains from battle. E.g. factor 1 gains 100 %, factor 2 gains 200 %.
- new: Combatants, Classes, Equipment, Abilities, Status Effects: Bonus Settings: 'Experience Factor Bonus' setting available. Defines a bonus that will be added to a combatant's experience factor.
- new: Status Effects: 'Stackable' setting available. Optionally allows applying a status effect multiple times, either generally (i.e. a user can apply the same effect multiple times) or once per combatant (i.e. a user can apply the effect only once, but a different user can apply it as well).
- new: Status Requirements: The 'Status Effect' check can now optionally check the quantity a status effect is stacked on a combatant. This is available throughout the framework (e.g. in the 'Check Status' event step).
- change: Event System: Base Steps: The 'Block Input Key' and 'Block Control Map' steps will now be executed in events that are stopped (e.g. when a combatant died during using an action). This makes sure the input keys or control maps wont stay blocked when an event is stopped before unblocking them.
- change: Event System: Dialogue Steps: The 'Block HUD' step will now be executed in events that are stopped. This makes sure the HUDs wont stay blocked when an event is stopped before unblocking them.
- change: Event System: Camera Steps: The 'Block Camera Control' step will now be executed in events that are stopped. This makes sure the camera control wont stay blocked when an event is stopped before unblocking it.
- change: Event System: Movement Steps: The 'Block Player Control' and 'Block Move AI' step will now be executed in events that are stopped. This makes sure the player control or move AI wont stay blocked when an event is stopped before unblocking them.
- fix: GUI System: New UI: Using the 'GUI Editor' to change a GUI box after playing the project no longer creates instances of UI parts.
- fix: Battle System: The correct player group leader will be used when the leader was changed using the player change keys.
- fix: Move AI: 'Auto Stop' issue fixed, leading to enemies circling around the player.


Version 2.2.0:
- new: Unity 4.6: ORK Framework now supports/requires Unity 4.6 and the new UI.
- new: Menu Settings: 'GUI System Type' setting available. Select if you want to use the 'Legacy GUI' (old GUI system) or the 'New UI' of Unity 4.6.
- new: Menu Settings: Settings for the 'New UI' GUI system type available.
- new: Menu Settings, GUI Boxes: GUI Skins: New settings available when using the 'New UI' gui system type. The settings replace the GUI skins used in the 'Legacy GUI' system and are used to select prefabs to create the GUI boxes, buttons, etc.
- new: Combatants: 'Auto Start Battles' setting available. Defines if a combatant will automatically start a battle when coming within a defined range to the player. By default enabled.
- new: Event System: Base/Function Steps: The 'Start Battle' step can now also start battles with objects who have a combatant. Previously, only objects with a 'Battle' component attached could be used.
- new: Battle Events: Battle Steps: 'Set Attacked By' step available. Marks that a combatant has been attacked by another combatant. This can influence various other things, e.g. victory gains or faction sympathy changes.
- fix: Status Effects: End Action: The end action marked by a status effect to be called by a combatant will no longer check if it can be used due to turn/time. The check resulted in the action not being marked if the combatant currently couldn't perform an action due to turn/time.


Version 2.1.11:
- new: Main Menu: 'Override Question' settings available for the auto save slot selection menu. Optionally display a question dialogue if an already used auto save slot should be overridden by a new game.
- change: Components: Getting and adding components now uses type functions instead of string functions. This allows Unity 5 compatibility.
- change: Components: The Unity 4 component getters (e.g. rigidbody, collider, etc.) have been replaced with GetComponent calls. This allows Unity 5 compatibility.
- change: Combatants, Classes: The experience of class level up status values will be stored when changing class. The experience of a class will be restored when changing back to it.
- change: Event System: Spawning prefabs now sets the position and rotation upon instantiating. This solves issues with shurikan particles producing a trail when spawned.
- change: GUI Boxes: Clicking on 'Ok' or 'Cancel' button positioned outside of the GUI box will now be recognized as click on the box.
- fix: Event System: Inventory Steps: 'Add To Item Box' and 'Remove From Item Box' steps wont throw errors in the editor.
- fix: Main Menu, Save Points, Menu Screens: The 'Load' buttons are now also available if only auto save games exist.
- fix: Abilities, Items, Event System: Target raycasts and raycast steps are now work correclty on different resolutions.
- fix: Combatants, Classes: Changing classes will now reset the class level up status value to the correct value.
- fix: Battle Gains: Collecting an item while an auto close battle gain dialogue is displayed wont lock the item collection dialogue any longer.
- fix: Item Collectors: Preventing an error when no item is added to the collectors list.


Version 2.1.10:
- new: Status Values: 'Real Value Count' setting available when using 'Count to Value'. Optionally uses the counted display value as real value of the status value.
- new: Battle System: 'Leave Arena Settings' available in all battle system types. The battle can optionally end when the player moves outside a defined range of the battle arena (i.e. the game object with the 'Battle' component).
- new: Battle System, Battle Components: 'Leave Arena Event' available. The battle end event used when the player leaves the battle arena.
- new: Battle Start Events, Battle End Events: 'Block Move AI' and 'Block Actor Move AI' settings available. Optionally blocks the move AI for all game objects or only for actors of the event. Blocking the move AI will only be active while the event is running.
- new: Event System: Base Steps: 'Auto Load Game' step available. Loads the AUTO save game or a temporary retry save game. The event ends after this step.
- new: Event System: Status Steps: 'Check Shortcut' step available. Checks a combatant's shortcut and executes 'Success' or 'Failed' based on the check.
- new: Event System: Battle Steps: 'Check Turn' step available. Checks a combatant's turn number and executes 'Success' or 'Failed' based on the check.
- new: Event System: Dialogue Steps: 'Button Info' and 'Button Title' settings available for 'Choice' type dialogues. Optionally add an info text and title to a choice.
- new: Event System: Dialogue Steps: 'Wait' setting available for 'Message' type 'Show Dialogue' steps. If disabled, the event will continue with the next step while the dialogue is displayed. By default enabled.
- new: Event System: Dialogue Steps: 'Close All Dialogues' step available. Closes all dialogues opened by this event (only from 'Show Dialogue' steps).
- new: Event System: Scene Steps: 'Check Item Box' step available. Checks the number of items in an item box and executes 'Success' or 'Failed' based on the check.
- new: Formulas: Combatant Steps: 'Turn' step available. Uses a combatant's turn number or the combatant's group average turn number to change the formula value.
- new: Formulas: Combatant Steps: 'Check Turn' step available. Checks a combatant's turn number or the combatant's group average turn number and executes 'Success' or 'Failed' based on the check.
- new: Menu Screens: Sub Menus: 'Assign Shortcut' sub menu item available. Shows a menu to assign items, abilities or equipment to a shortcut slot of the menu user.
- new: Menu Screens: '%lvl' text code available for content layouts (for choice buttons). Displays the level of an ability or equipment.
- new: Save Game Menu: 'Auto Save Slots' setting available. Defines the numbers of available auto save slots.
- new: Main Menu: 'Auto Save Slot Menu' settings available. Optionally select the auto save slot when starting a new game. Auto saving will use the selected slot in the running game.
- new: Abilities, Items: Target Raycast: 'Use Mouse Position' settings available for raycast auto targeting. Use this option if you're directly firing your actions from control maps without target selection.
- new: Abilities: 'Quantity' and 'Chance (%)' settings of an active ability's item consume now support formulas, game variables and other value origins.
- new: Ability Trees, Status Development: 'Quantity' and 'Chance (%)' settings of item learn costs now support formulas, game variables and other value origins.
- new: Control Maps: 'Show Tooltip' settings available for 'Action' and 'Shortcut' control keys. Optionally displays a 'Tooltip' type HUD instead of using the action/shortcut.
- new: Editor: 'Help Text Color' setting available in the editor settings. Changes the color of the help text.
- change: Combatants: Using 'Local Variables' in the combatant's object variable settings will now keep the local variables on the combatants and not the objects. This allows to keep the local object variables when the game object is destroyed, e.g. when changing prefab.
- change: Animations: Mecanim animations can now use play and set parameters at the same time.
- change: Event System: Inventory Steps: The item box steps are now also available in the 'Inventory Steps'.
- change: Battle Start Events: The 'Join Battle' step is now also available in battle start events.
- fix: Colors: Fading or blinking colors (e.g. in the 'Fade Object' event step) with time set to 0 resulted in a black color.
- fix: Event System: Battle Steps: The 'Look At Enemies' step works correctly again.
- fix: Event System: Function Steps: The 'Mount Object' step now correctly unmounts objects.
- fix: Item Collectors: 'Box' type item collectors now set the variables after closing the item box.
- fix: GUI Boxes: Buttons now can't be clicked while the GUI box is fading out.
- fix: Damage Dealers: Stopping particle emitting on prefabs is now working correctly.
- fix: Menu Screens: Changing/removing the player using a 'Group' menu part will now correctly change the player if needed.
- fix: Abilities, Items: Target Raycast: The auto targeting from screen position was inversed.


Version 2.1.9a:
- new: GUI Boxes: 'Title Text Alignment' setting available when using 'Set Title Width' in the choice settings. Manages the horizontal alignment of the title of a choice within its bounds.
- new: GUI Boxes: 'Title Line Alignment' setting available in the choice settings. Manages the vertical alignment of labels in a line of the title of a choice.
- new: Combatant Selections: 'Back Button' settings available. Optionally adds a back button to combatant selections.
- fix: Equipment: Changing equipment will now correctly update displayed values.
- fix: Shops: Tooltips are now working correctly in shops.
- fix: Variable Conditions: Checking 'Conditions' type had a display bug in the editor.


Version 2.1.9:
- new: HUDs: Combatant, Turn Order: 'Click Action' settings available for 'Combatant' and 'Turn Order' HUD elements. Clicking on a HUD element can optionally call a menu screen, change the current menu/shop user, change the player or select a target. Also works in menu screens and shops.
- new: HUDs: Combatant, Turn Order: '%c' text code available for 'Status Value', 'Attack Attribute' and 'Defence Attribute' elements. Displays the change between the current and preview value of a status value or attack/defence attribute.
- new: HUDs: 'Expand Bounds' setting available for HUD element background images. The element's display bounds will be increased when the image bounds exceed them.
- new: HUDs: 'Start Toggle State' setting available when using a 'Toggle Key'. Defines if the HUD is toggled on or off at the start of the game. When using 'Only While Key', the display state is inversed, i.e. the HUD will be hidden when the input key is valid. By default enabled (i.e. toggled on).
- new: Menu Screens: Ability, Inventory, Ability Tree, Status Value Upgrade: 'Don't Return' setting available when using 'Close After Use'. The menu screen wont return to a previously opened menu screen when closing after use.
- new: Menu Screens: Ability, Inventory: 'Animate Use' setting available. Defines if using an item/ability in a menu screen will be animated, i.e. using it's battle events. By default enabled.
- new: Menu Screens: Combatant: 'Show Ok Button' and 'Show Cancel Button' settings available. Optionally show the 'Ok'/'Cancel' buttons of the GUI box. The 'Ok' button can change to the next page when using 'Accept Next Page', the 'Cancel' button can close the menu screen.
- new: Battle System: 'Defend First' setting available in all battle system types. The defend command will optionally perform before other actions. Doesn't take already performing actions into account.
- new: Battle System: 'Auto Close' settings available when showing battle gains immediately. Optionally automatically closes the battle gains dialogue after a defined amount of time. Available in all battle systems.
- new: Battle End Events: Battle Steps: 'Auto Close' settings available in the 'Collect Battle Gains' step. Optionally automatically closes the battle gains dialogue after a defined amount of time.
- new: Input Keys: 'Mouse' and 'Touch' input origin settings available. Use mouse button clicks or touch input as input keys (can't be used as axis).
- new: Game Variables: 'Approximately' check type available for float game variable checks. The check is valid if the current value of the game variable is similar to a defined value. Uses the Mathf.Approximately function for the check.
- new: Game Variables: 'Range Inclusive', 'Range Exclusive' and 'Approximately' check types available for Vector3 distance checks.
- new: Event System: Check Steps: 'Check Value' step available. Checks a value with another defined value, e.g. check if the result of a formula is within a defined range.
- new: Event System: Movement Steps: 'Range Inclusive', 'Range Exclusive' and 'Approximately' check types available in 'Check Distance' and 'Check Transform' steps.
- new: Event System: Rotation Steps: 'Range Inclusive', 'Range Exclusive' and 'Approximately' check types available in 'Check Angle' steps.
- new: Event System: Faction Steps: 'Range Inclusive', 'Range Exclusive' and 'Approximately' check types available in 'Check Faction Sympathy' steps.
- new: Formulas: Check Steps: 'Range Inclusive', 'Range Exclusive' and 'Approximately' check types available in 'Check Formula Value' steps.
- new: Formulas: Position Steps: 'Range Inclusive', 'Range Exclusive' and 'Approximately' check types available in 'Check Distance' and 'Check Angle' steps.
- new: Game Settings: Bestiary: 'Use in Battle AI' setting available. Uses bestiary knowledge when a player combatant does status checks on enemy combatants in a battle AI. A status check fails if the informatin is not known to the player.
- new: Battle AI: Status Steps: 'Force Knowledge' setting available for 'Check Status', 'Get Status Value', 'Get Attack Attribute' and 'Get Defence Attribute' steps. Optionally forces player combatants to have full knowledge about an enemy's status.
- new: Battle AI: Position Steps: 'Range Inclusive', 'Range Exclusive' and 'Approximately' check types available in 'Check Distance' and 'Check Angle' steps.
- new: Status Requirements: 'Combatant' requirement available. Status requirements can now check if a combatant is a selected combatant or not.
- new: Editor: 'Copy to Clipboard' button available for help texts. Copies the current help text to the system clipboard.
- change: Text Formats: The minimum value the 'Font Size' can be set to is now 0 instead of 1.
- fix: Menu Screens: Equipment: Changing between equipment with status value bonuses and status requirements will now correctly refresh the equipment list.
- fix: Menu Screens: Ability, Equipment, Inventory: Sub menus can now also be used on inactive choices (e.g. unequipable equipment, not useable items).
- fix: Menu Screens: Ability, Inventory: 'Close After Use' now correctly closes the menu screen when using 'Use Screen Combatant' in the menu screen or item.
- fix: Menu Screens: Selecting a choice via click will now correctly update the description when displaying a combatant choice.
- fix: Menu Screens: 'Description' menu part updates could cause menu screens to not fully close, blocking the game.
- fix: Status Values: Using a combined status value as another value's maximum value could lead to limiting it before the real maximum value has been calculated.
- fix: Status Effects: 'Auto Attack' and 'Attack Allies' will now correctly perform actions.
- fix: Battle System: Using 'Leave on Death' on player combatants could lead to errors upon losing a battle (when no combatant was left in the player group, i.e. no player).


Version 2.1.8:
- new: Abilities: 'Delay Time' settings available for active abilities. Abilities can set a delay time on the user. A combatant can't perform actions (e.g. attack, use an ability or item) during the delay time.
- new: Inventory Settings: 'Default Delay Time' settings available. Items can set a delay time on the user. A combatant can't perform actions (e.g. attack, use an ability or item) during the delay time.
- new: Items: 'Delay Time' settings available. Items can override the default delay time defined in the inventory settings.
- new: HUDs: Combatant, Turn Order: 'Delay Time' element type available. Displays a combatant's delay time as a text or bar. Only displayed while the time is running.
- new: HUDs: Combatant, Turn Order: 'Time Format' setting available for 'Cast Time' and 'Timebar' text time displays.
- new: HUDs: Combatant, Turn Order: 'Reverse Value' setting available for 'Cast Time'. The cast time will be displayed reversed, i.e. the time will count down instead of up.
- new: Status Requirement Templates: The status requirement templates allow you to set up status requirements that can be reused in other status requirements. Status requirement templates can be created in 'Base/Control > Status Requiremenet Templates'.
- new: Status Requirements: 'Requirement Type' setting available. Select if a requirement either checks a single 'Status', other 'Requirements' or a status requirement 'Template'. When checking other requirements, you can create multiple status requirements in a single condition, allowing you to set up checks like '(requirement1 && requirement2) || requirement3'.
- new: Event System: Dialogue Steps: You can now use actor text codes in choices added to a 'Dialogue Step'.
- new: Event System: Dialogue Steps: Choices can now use global, local and object variables in variable conditions.
- new: Event System: Active Group Steps: 'Check Group Size' step available. Checks the size of the active player group.
- new: Event System: Variable Steps: 'Variable to Variable' step available. Stores the value of a game variable into another game variable. You can use this step to transfer variables between variable origins (local, global and object).
- new: Combatants: Battle Animations: 'Join Look At' setting available. Optionally looks at enemy combatants when joining a running battle. By default disabled.
- new: Game Settings, Interactions: Setting 'Max. Click Distance' to -1 will allow starting 'Interact' type interactions without distance limitations.
- new: Status Development, Ability Trees: 'Experience' type learn costs can now use a defined value, formula, game variable, etc. for the required/consumed experience.
- fix: Status Values: 'Experience' type status values that level ub the base/class level will now correctly receive experience exceeding the current maximum value.
- fix: Status Requirements: Passive abilities can now also be checked without enabling 'Learned'.
- fix: Abilities: Passive abilities wont be added to the list multiple times.
- fix: Abilities: Passive abilities will now correctly add their status effects outside of battles.
- fix: Event System: The 'Found Objects' list was updated when using a child object, resulting in the child object being in the list instead of the original object.
- fix: GUI Boxes: Cut off text issues are solved.
- fix: Global Events: Wait times are now working correctly in 'Scene' type global events.
- fix: Equipment Viewers: Using the 'Add Combatant' component with 'Equipment Viewers' could still lead to not displaying equipment.
- fix: Music: If no music is played when storing music, now also no music will play when playing the stored music (also applies to shop/menu music).


Version 2.1.7:
- new: Main Menu: 'Continue Button' settings available. Loads the last saved game. Requires the save games to be saved with this version to find the latest save game.
- new: Main Menu: 'Hide Inactive' setting available for the load button. The load button wont be displayed if no save games are available.
- new: Status Requirements: 'Weapon' and 'Armor' requirements available. Status requirements can now check if a selected weapon or armor is equipped or not equipped on a combatant. Available throughout the framework.
- new: Text Format: 'Font' setting available. You can now optionally set the font in the text format settings throughout the framework.
- new: Status Values: 'Init to Level' setting available for 'Experience' type status values. The experience status value will be initialized to the value according to the combatant's level and status development. By default enabled.
- change: Status Values: 'Experience Type' setting replaces 'Level Up' and 'Class Level Up' settings for 'Experience' type status values.
- change: Status Values: 'Experience' type status values that don't level up (i.e. 'Experience Type' set to 'None') will now use the status value's minimum value as minimum value. Level up type values will still use the previous level's value as minimum value.
- fix: Battle Settings: Auto Join: Joining a running battle was possible when the battle already ended, leading to the joining combatants being removed.
- fix: Equipment Viewer: Using the 'Add Combatant' component with 'Equipment Viewers' could lead to not displaying equipment if the combatant was initialized after the equipment viewer.
- fix: Status Values: Having a 'Consumable' type status value above it's maximum status value (i.e. with a lower index) could lead to initialization to a wrong value.
- fix: Active Time Battles: Using 'Pause on Menu' with AI controlled player group members wont stop the battle any longer after an AI action.
- fix: Battle System: 'Death' actions and loot collection now works again when not using 'Death Immediately'.
- fix: Editor: The 'Console Settings' sub-section is working again.


Version 2.1.6:
- new: Variable Condition Templates: The variable condition templates allow you to set up variable conditions that can be reused in other variable conditions. Variable condition templates can be created in 'Base/Control > Variable Condition Templates'.
- new: Variable Conditions: 'Condition Type' setting available. Select if a condition either checks a single 'Variable', other 'Conditions' or a variable condition 'Template'. When checking other conditions, you can create multiple variable conditions in a single condition, allowing you to set up checks like '(condition1 && condition 2) || condition3'.
- new: Variable Conditions: New float checks available. 'Range Inclusive' checks if the current value of a float game variable is between two defined values, including the values. 'Range Exclusive' checks if the value is between two defined values, excluding the values.
- new: HUDs: Display Conditions: 'Only While Key' setting available when using a toggle key. The HUD will only be displayed while the selected toggle key input is valid, i.e. use a 'Hold' input key and the HUD will only be displayed while the key is pressed.
- new: HUDs: Combatant, Turn Order: 'Equipment' HUD element type available for 'Combatant' and 'Turn Order' type HUDs. Displays a combatant's equipment parts and equipped weapons/armors - either listing all parts or displaying a selected part.
- new: HUDs: Combatant, Turn Order: 'Display Requirements' settings available for 'Combatant' and 'Turn Order' type HUD elements. Optionally limit displaying a HUD element to status requirements and variable conditions.
- new: Game Settings: Bestiary: 'Equipment' settings available. The equipment of an enemy combatant can now also be learned for a bestiary entry.
- new: Status Values: 'Normal' type status values can now optionally use other 'Normal' type status values to define their minimum and maximum values. The min/max status value's current value will be used - this allows creating flexible min/max values, e.g. for upgrading the MaxHP with special equipment.
- new: Menu Screens: Status Value Upgrade: 'Show No Upgrade Req.' and 'No Upgrade Req. Content Layout' settings available. Used to display status values with upgrades that aren't available due to requirements (e.g. for maxed out ugprades).
- new: Event System: Function Steps: 'Close Menu Screen' step available. Closes a selected or all opened menu screens.
- new: Event System: Function Steps: 'Start Item Collector' step available. Starts an item collector attached to an event object (e.g. actor). The event continues after the item collection has been finished. You can use this to e.g. do additional animations when collecting items or opening item boxes.
- new: Event System: Spawn Steps: 'Spawn Player' and 'Destroy Player' steps can now also spawn/destroy a different member of the player group.
- new: Event System: Variable Steps: 'Function to Variable' step available. Stores the return value of a function into a game variable. Supports string, bool, int/float and Vector3 return values.
- new: Combatants: Movement Settings: 'Use Position Change' setting available. If enabled, the change of the combatant's position every update will be used to determine the real speed (used e.g. in auto move animations). Otherwise components will be check in that order: CharacterController > Rigidbody > Rigidbody2D > NavMeshAgent > Position Change.
- new: Combatants: 'Set Object Name' setting available. Optionally sets the name of the game object spawned for the combatant to the combatant's name.
- new: Battle Notifications: The notifications (e.g. status value changes) can now also set other properties of renderer materials like the 'Fade Object' event step.
- new: Combatant Spawners: 'Set Scale' settings available. You can now optionally set the scale of spawned combatants.
- new: Weapons, Armors: 'Viewer Name' setting available. Optionally sets the name of the game object spawned by the equipment viewer. You can use this to unify the name of displayed equipment and access it easier through events (e.g. child objects).
- new: Game States: The 'Menu Screen' game state can now optionally be limited to defined menu screens. The 'Yes' option will be valid if one of the added menu screens is opened - if no screen is added, any opened screen is valid.
- new: Equipment Viewers: 'Combatant in Battle' setting available when setting the 'In Battle' game state to 'Yes' or 'Ignore'. If enabled, the equipment will only be displayed when the combatant itself is in battle, not the game.
- new: Combatants: Battle Animations: 'Join Battle Animation' available. Uses battle events to animate a combatant joining the battle through 'Auto Join' in a running battle.
- new: Battle Settings, Classes, Combatants: New battle menu settings available. You can now optionally define a battle menu for each battle system type.
- new: Battle Settings: Auto Join: 'Join Running Battle' setting available. Combatants can optionally also join running battles when coming into auto join range.
- new: Battle System: Move AI: 'Block In Battle' setting available in all battle system type settings. Optionally blocks the move AI of combatants that are participating in battle when allowing move AI during battle. This allows not fighting combatants to still move while those who are fighting don't move.
- new: Text Codes: The new 'Float with Format' text code allows defining a text format when displaying float variables. E.g. 00.0 will display at least two digits before the decimal point and one after the decimal point (1.5 would be come 01.5).
- new: Equipment Viewers: 'Preview' inspector settings available. You can now preview a selected weapon or armor on an equipment viewer. You need to disable the preview again when you're done to get rid of the created preview object.
- change: Event System: Steps using combatants can now also used unspawned members of the combatant group as long as no game object is needed in the step.
- change: Event System: Fade Steps: The 'Blink Object' and 'Fade Object' steps now set the color property of 'Sprite Renderers' instead of the materials color property if a 'Sprite Renderer' is used (fading Sprite objects).
- change: Editor: The ORK Framework editor no longer closes automatically when entering 'Play' mode in Unity.
- fix: Save Games: Loading a save game without having 'Spawn Group' enabled doesn't spawn other group members any longer.
- fix: Status Effects: The turns of combatants with 'Stop Move' effects will now increase (and reduce turn bound effects).


Version 2.1.5:
- new: Bestiary: The bestiary is a collection of status information on enemy combatants. You can define when to learn which status information (e.g. status values on encountering an enemy, attack attributes on attacking with the individual attributes). The 'Bestiary Settings' are defined in 'Game > Game Settings'.
- new: Menu Screens: 'Bestiary (Area)' menu part available. Displays information on bestiary entries using HUD elements. The bestiary entries are separated by areas and area types in which they've been encountered.
- new: Event System: Bestiary Steps: 'Add To Bestiary' step available. Adds an entry to the bestiary - uses either an event object's combatant or a defined combatant.
- new: Event System: Bestiary Steps: 'Remove From Bestiary' step available. Removes an entry from the bestiary - uses either an event object's combatant or a defined combatant.
- new: Event System: Bestiary Steps: 'Check Bestiary' step available. Checks if a combatant's entry is in the bestiary (complete or partial entry) - uses either an event object's combatant or a defined combatant.
- new: Event System: Bestiary Steps: 'Bestiary Dialogue' step available. Displays a dialogue with information on a combatant's bestiary entry using HUD elements. Uses either an event object's combatant or a defined combatant, if no combatant or bestiary entry was found, the dialogue is skipped.
- new: Combatants: 'Not Scanable' setting available. The combatant wont add information to the bestiary, only an empty entry without status information will be made.
- new: Combatants: 'No Bestiary Entry' setting available. The combatant wont add an entry to the bestiary at all.
- new: Abilities, Items: 'Scan Target' setting available. The target will be added with a complete entry to the bestiary. Only possible if the user is part of the player group and target is an enemy.
- new: Save Game Menu: 'Save Bestiary' setting available. If enabled, the learned enemy combatant information will be saved. By default enabled.
- new: Requirements: 'Has Bestiary Entry' setting available. At least one bestiary entry must be available for this requirement to be valid.
- new: Status Development, Ability Trees: 'Cost Type' setting available for learn costs. You can now also use items, weapons, armors and currency as costs for learning abilities or increasing status values.
- new: Menu Settings: Use Cost Display: 'Item Cost', 'Weapon Cost', 'Armor Cost' and 'Currency Cost' settings available. Also, all use cost settings can now use %i to display icons.
- new: Images: All image settings can now also use alpha masks when using colors instead of images.
- new: Value Bars: 'Crop Image' setting available for all Value bars (e.g. for status values) with scale mode 'Stretch to Fill' or using alpha masks. If enabled, the image will use the whole bar's bounds for scaling, but crop the parts of the image that exceed the filling (e.g. 50 % filling will only display half of the image).
- new: Battle AIs: 'Check Target Count' step available. Checks the number of found targets and executes 'Success' or 'Failed' next step.
- new: Add Combatant Component: 'Battle Type' setting available for the 'Add Combatant' component. Defines the battle type used when a battle is started when entering the combatant's battle type.
- new: Inspectors: The 'Combatant' component inspector now also displays a combatant's name, level, class and class level.
- new: Menu Screens: 'Accept Next Page' setting available for 'Combatant' and 'Information' menu parts. The 'Accept' input key (and 'Ok' button) can optionally be used to change to the next page.
- new: Editor: 'Create HUD' button available for combatant page, information page and combatant choice layouts. Creates a new HUD from the defined HUD elements of the page/layout and uses the HUD instead.
- change: Item Collectors: 'Destroy Collected' setting is now 'Destroy Collected Object' and also available for item collectors not using scene ID. Warning: This will reset the setting on all item collectors to enabled.
- fix: GUI Editor: The WYSIWYG GUI editor is again working correctly with all GUI settings.
- fix: Event System: Status Steps: Using 'Level Up' to level up the base or class level now also works when no experience status value is set to level up base/class levels.
- fix: Player Group: Unspawned members of the player group didn't get updated properly, leading to equipment changes not adding bonuses, etc.


Version 2.1.4:
- new: Plugins: The new plugin system allows adding your own settings and functions to ORK Framework without changin ORK's code. The data will be saved with the rest of ORK's settings. Plugins can be added in 'Editor > Plugins'. The full version includes a plugin template project.
- new: Event System: Function Steps: 'Call Plugin' step available. Calls a plugin's 'Call' function with an information string.
- new: Main Menu: 'Call Plugin' settings available for 'Custom Choice' menu items. Custom choices can now call a plugin instead of a game object's component.
- new: GUI Layers: 'Use Full Screen' setting available. The layer ignores the GUI settings in the 'Game Settings' and uses 'Stretch to Fill' for all GUI boxes on this layer, using the full screen for placement.
- new: Game Settings: 'GUI Padding' setting available. Adds a padding at the borders of the screen when placing the GUI.
- new: Game Settings: 'GUI Anchor' setting available for all GUI scale modes except 'Stretch to Fill'. Select the anchor for the GUI when placing/scaling the GUI (e.g. Upper Left, Middle Center, ...).
- new: Game Settings: 'Raycast Type' setting available. Select the type of raycasts that are used throughout the framework, you can either use 'Only 3D', 'Only 2D' or mixed 'First 3D' and 'First 2D'. 3D raycasts will interact with 3D colliders, 2D raycasts with 2D objects. By default 'Only 3D'.
- new: Abilities, Items: 'Auto Target' setting available in 'Raycast Settings'. Used for AI/auto target raycasts - if enabled, a nearby combatant will automatically be targeted by the raycast, otherwise the screen center will be used. By default enabled.
- new: Battle Spots: 'Set Rotation' and 'Set Scale' settings available for the individual battle spots. You can now set the rotation and scale of the default battle spots.
- new: GUI Boxes: 'Select Unfocused' setting available for choices. Optionally allows selecting a choice on an unfocused GUI box.
- new: Animations: Mecanim: 'Trigger' parameter type available for Mecanim animations.
- new: Animations: Mecanim: 'Duration' setting available for Mecanim animations. Used in game events to set the wait time for animation steps.
- new: Event System: All advanced int, float and Vector3 selection fields now support local, global and object game variable selections.
- new: Event System: Base Steps: 'Raycast Object' step available. Adds/removes a game object that was hit by a raycast to the 'Found Objects' list.
- new: Event System: Variable Steps: 'Raycast to Variable' step available. Changes a Vector3 game variable using the hit point of a raycast.
- new: Event System: Spawn Steps: The 'Spawn Prefab' step can now also spawn prefabs at defind positions (e.g. from game variables) instead of using an event object.
- new: Shops: 'Block Move AI' and 'Block Owner Move AI' settings available. Blocks either the move AI of all combatants or only the move AI of the shop's game object while the shop is opened.
- new: Shop Interactions: 'Turn Player to Event' and 'Turn Event to Player' settings available. Turns the event object and the player to one another upon opening the shop.
- new: Move AIs: 'Hunting Range' settings available. A combatant can optionally hunt only within a defined range of it's start position (i.e. spawn position). When hunting outside of the defined range, the combatant will stop hunting and return to the start position.
- new: Logs: 'Portrait Settings' available. Logs can display portraits in menu screens.
- new: Log Texts: 'Portrait Settings' available. Log texts can override their log's portrait.
- new: Menu Screens: 'Show Portrait' settings available for 'Log' menu parts. The log choice and info display can show a log's portrait.
- new: Input Keys: New 'Input Handling' type 'Any' available. Receives input at down, hold and up.
- new: Save Game Menu: The 'Save Slots' setting can now also be set to 0. Having 0 save slots only allows using AUTO save games and retry.
- new: Item Collectors: 'Destroy Collected' setting available for 'Single' and 'Random' item collectors. If enabled, the game object will be destroyed when an item has been collected, otherwise only the item collector component will be removed. By default enabled.
- new: Item Collectors: 'Show Dialogue' setting available for 'Single' and 'Random' item collectors. If enabled, the item collection dialogue will be displayed, otherwise the item will be collected immediately. By default enabled.
- new: Item Collectors: 'Show Console' setting available. If enabled, the console output for adding items to the inventory will be dispalyed. By default enabled.
- change: Item Collectors: The 'Show Notification' setting will now handle showing the item collection notification (inventory notifications) instead of showing the item collection dialogue.
- change: Event System: Spawn Steps: The 'Destroy Player' step is now also available in 'Battle Start' and 'Battle End' events.
- change: Animations: 'Auto Move Speed Parameters' for Mecanim animations can now also be used without using the combatant's 'Automatic Move Animation'.
- fix: Damage Dealers, Damage Zones: The damage dealer/zone components no longer require a 'Rigidbody' component, i.e. you can now also use a 'Rigidbody2D' component instead.
- fix: Interactions: 'In Trigger' and 'While Colliding' now work correctly without the other one enabled.
- fix: Game Time: The game time is now set correctly when starting a game without going through the main menu.
- fix: Animations: 'Mecanim State Checks' are now used correctly.
- fix: Screen Fader: Fading the screen will now fit the screen size in each GUI scale mode.
- fix: Menu Screens: Quantity selections called by menu screens with 'Pause Game' enabled will now work properly.


Version 2.1.3:
- new: Interactions: 'Trigger Stay' start types available. Starts an interaction (e.g. event, item collector) while the player (or another object) is within the object's trigger.
- new: Interactions: 'Collision Enter' start types available. Starts an interaction (e.g. event, item collector) when the player (or another object) starts colliding with the object. Requires both objects to have a collider and at least one object to have a rigidbody.
- new: Interactions: 'Collision Exit' start types available. Starts an interaction (e.g. event, item collector) when the player (or another object) stops colliding with the object. Requires both objects to have a collider and at least one object to have a rigidbody.
- new: Interactions: 'Collision Stay' start types available. Starts an interaction (e.g. event, item collector) while the player (or another object) is colliding with the object. Requires both objects to have a collider and at least one object to have a rigidbody.
- new: Battle Menus: 'Change Member' menu item type available. Allows changing a combatant against a member of the non-battle group.
- new: Combatants: Battle Animations: 'Retreat Animation' available. Uses battle events to animate a combatant's retreat from battle when using the 'Change Member' command. Needs a 'Calculate' step to exchange members.
- new: Combatants: Battle Animations: 'Enter Battle Animation' available. Uses battle events to animate a combatant joining the battle when using the 'Change Member' command.
- new: Control Maps: 'Change Member' action available. Exchanges the combatant with a defined non-battle member (defined by index).
- new: Status Effects: 'Change Member' end action type available. Exchanges the combatant with a defined non-battle member (defined by index) after the status effect ends.
- new: Battle AI: Action Steps: 'Change Member' step available. Exchanges the combatant with a defind non-battle member (defind by index).
- new: Battle AI: Status Steps: 'Get Status Value' step available. The combatant with the highest or lowest value of a selected status value will be added to the target list.
- new: Battle AI: Status Steps: 'Get Attack Attribute' step available. The combatant with the highest or lowest value of a selected attack attribute will be added to the target list.
- new: Battle AI: Status Steps: 'Get Defence Attribute' step available. The combatant with the highest or lowest value of a selected defence attribute will be added to the target list.
- new: Loot: 'Variable Condition' settings available in loot tables. If a loot table is available can depend on variable conditions (either global or object variables on the combatatant or spawner).
- new: Loot: 'Set After Drop' settings available in loot tables. Loot tables can change game variables (either global or object variables on the combatatant or spawner) after being used/dropped by a combatant.
- new: Combatant Spawners: 'Move AI' settings available. A combatant spawner can block or override the move AI of spawned combatants.
- new: Event System: Status Steps: 'Check Combatant' step available. Checks if an object (e.g. actor) is a selected combatant.
- new: Event System: Active Group Steps: The 'Check Player' step can now check objects (e.g. actors) if they are the player.
- new: Inspectors: The ORK Framework object (created when playing) now shows all global game variables in the inspector.
- new: Inspectors: The 'Object Variables' component now shows all game variables of the object in the inspector.
- new: Item Collectors: 'Show Notification' setting available for 'Single' and 'Random' item collectors. The item collection notification will be skipped when disabled.
- new: Shop Layouts: 'Sell Without Items' setting available. If disabled, 'Sell' button will be disabled when no items are available to be sold. By default disabled.
- new: Shop Layouts: 'Auto Close Sell' setting available. If enabled, the sell mode will automatically be closed when the last item has been sold. By default enabled.
- new: Inventory Settings: Drop Item Settings: 'Collector Star Type' setting available. Select the start type of the item collector used for dropped items. By default set to 'Interact'.
- new: HUDs: Combatant HUDs: 'Start Index Offset' setting available for 'Group' mode combatant HUDs. Starts displaying the combatant list from the defind offset, i.e. combatants before that index will be skipped.
- new: HUDs: Combatant HUDs: 'Limit List Length' settings available for 'Group' mode combatant HUDs. Limit the number of displayed combatants.
- new: Animations: Mecanim: 'Set Layer Weight' settings available for mecanim animations. Optionally sets the current weight of the animation's layer before playing it.
- new: Menu Screens: 'Close Screens (Opening)' settings available for menu screens not using 'Single Screen' mode. Automatically closes selected menu screens when opening the (non-single) menu screen.
- new: Menu Screens: 'Close Screens (Closing)' settings available for menu screens not using 'Single Screen' mode. Automatically closes selected menu screens when closing the (non-single) menu screen.
- change: Combatant Spawners: The spawner will now set its game variables each time a combatant spawned by the spawner is killed.
- fix: Menu Screens: The drag info will now be properly displayed in menu screens that pause the game.
- fix: Camera Events: Camera events wont throw errors and block control when changing scene while a camera event is active.
- fix: Event System: Movement Steps: The 'Transform to Variable' step is now correctly setting the Vector3 game variable.
- fix: Combatant Groups: The additional battle gains are now also collected when using loot tables.
- fix: Shops: 'Accept' input key doesn't throw errors when shop is open in sell mode without items to sell.
- fix: HUDs: Control HUDs: 'Control' type HUDs now correctly support inputs with hold time.


Version 2.1.2:
- new: Battle Settings: 'Auto Join' settings available. Combatants within range of a starting battle can automatically join the battle. This is only available in arena battles (i.e. using the 'Battle' component), not in real time area battles.
- new: Battles: Battle components can override the default 'Auto Join' settings from the 'Battle Settings'.
- new: Status Effects: 'Keep Overflow' setting available for status conditions. Changes exceeding the possible changes for status values will be remembered and added to the next change. E.g. 5.25 can only do a change of 5, 0.25 will be remembered and added to the next change.
- new: Status Values: 'Ignore 0 Damage' setting available for damage and critical damage notifications. Optionally ignores a damage of 0 (i.e. no damage) and doesn't perform the notification text and HUD flash.
- new: Abilities, Items: Status Changes: 'Ignore Barrier' setting available in user/target changes. Optionally ignores barrier values of 'Consumable' type status values and targets the status value directly.
- new: Status Effects: Status Conditions: 'Ignore Barrier' setting available. Optionally ignores barrier values of 'Consumable' type status values and targets the status value directly.
- new: Combatants: Status Value Time Changes: 'Ignore Barrier' setting available. Optionally ignores barrier values of 'Consumable' type status values and targets the status value directly.
- new: Battle Settings: Player/Enemy Advantage: 'Ignore Barrier' setting available. Optionally ignores barrier values of 'Consumable' type status values and targets the status value directly.
- new: Battle System: Bonus Settings: 'Ignore Barrier' setting available. Optionally ignores barrier values of 'Consumable' type status values and targets the status value directly.
- new: Event System: Status Steps: 'Ignore Barrier' setting available in the 'Change Status Value' step. Optionally ignores barrier values of 'Consumable' type status values and targets the status value directly.
- new: Event System: Movement Steps: 'Change Gravity' step available. Change Physics.gravity or Physics2D.gravity - influences all game objects with a 'Rigidbody' or 'Rigidbody2D' component.
- new: Battle Menus: 'Audio Settings' available. A battle menu can now play an audio clip when being opened and closed.
- new: Abilities, Items: 'Target Requirements' settings available. A target can optionally depend on status requirements and variable conditions. If the requirements aren't met, the combatant can't be targeted.
- change: Battles: Battles can't start while changing scenes.
- change: Save Games: Status effects of player combatants are now saved.
- change: Dialogues, Menus: Accepting a choice will now also reset all ORK input keys instead of only the Unity input axes. This fixes problems when using the accept key also to call the menus.
- fix: Menu Screens: Displaying the back or unequip button first can cause errors when not displaying unequippable equipment.
- fix: Combatants: Level up now allows to gain more than one level at once.
- fix: Battle Settings: The enemy counter type 'Letter' now correctly displays letters exceeding A-Z as AA-AZ, BA-BZ, etc.
- fix: Event System: Image Steps: Removing lower ID images before higher ID images resulted in errors.
- fix: HUDs: Using icons for status value bars without empty icons displayed the already consumed icons at the position of the last icon.
- fix: Battles, Combatants: Enabling 'Keep Prefab' in the combatant's settings could prevent a battle from ending when all enemies have been killed.
- fix: Real Time Battle Areas: Implemented a workaround for a Unity bug where the player quickly leaves and enters the area's trigger, although he is still inside it.


Version 2.1.1:
- new: Unity 4.5: ORK Framework now supports/requires Unity 4.5.
- new: Game Controls: Collision Camera: 'Collision Camera' settings available in the game control settings. The new 'Collision Camera' component uses racasts to find objects between player and camera and places the camera accordingly. Can be used with all built-in and custom camera controls, and is also active during events (i.e. while camera changes).
- new: Float Values: Advanced float settings throughout the framework (e.g. changing game variables) now allow using the current time of day (i.e. time since midnight in seconds) and date and time (i.e. time since 1-1-1970 in seconds). You can use this to use the real time or check for days since something was done.
- new: Status Values: 'Barrier' settings available for 'Consumable' type status values. You can use other 'Consumable' type status values as barriers, i.e. they will consume damage instead (as long as they haven't reached their minimum value). They can either fully consume a damage, or only a defined percent range (0-100 %).
- new: Status Values: 'Death On' setting replaces 'Death on Minimum' for 'Consumable' type status values. You can now select 'None' (i.e. doesn't kill the combatant), 'On Minimum' (combatant dies when value reaches its minimum) and 'On Maximum' (combatant dies when value reaches its maximum).
- new: Items: 'Equipment Part Changes' settings available. Items can add/remove equipment parts to/from a combatant. This can be used to either add additional equipment parts or to block/remove equipment parts from the combatant/class settings.
- new: Weapons, Armors: 'Equipment Part Changes' settings available. Weapons and armors can add additional equipment parts and block other equipment parts while being equipped. This can be done per equipment level.
- new: Abilities: 'Equipment Part Changes' settings available in passive abilities (i.e. useable in 'None'). Passive abilities can add additional equipment parts and block other equipment parts. This can be done per ability level.
- new: Status Effects: 'Equipment Part Changes' settings available. Status effects can add additional equipment parts and block other equipment parts.
- new: Classes, Combatants: The weapon/armor settings are now split into available and unavailable equipments (due to equipment parts). Unavailable equipment was previously not displayed and couldn't be enabled. Also, automatic unselection of weapons/armors due to equipment part changes is now disabled.
- new: Camera Positions: 'Rotation Is Offset' setting available. Uses the defined rotation of the camera as an offset to the target's rotation.
- new: Quests: Quests can now learn log texts to the player when being added to the player's quest list, the quest finishes or fails.
- new: Quest Tasks: Quest tasks can now learn log texts to the player when being activated or the task is finished or failed.
- new: Quests, Quest Tasks: Experience rewards can now optionally be given to the whole group (or only battle group) and split between group members.
- new: Event System: Spawn Steps: 'Destroy Object' step available. Destroys a game object.
- new: Event System: Equipment Steps: 'Check Part Available' step available. Checks if an equipment part is available (i.e. can be equipped, ignoring locked parts).
- new: Event System: Equipment Steps: 'Change Equipment Part' step available. Adds/removes equipment parts to/from a combatant. Removing only allows removing previously added parts. Can be used to add additional equipment parts to combatants.
- new: Event System: Equipment Steps: 'Change Blocked Part' step available. Adds/removes a blocked equipment part to/from a combatant. A blocked equipment part isn't available for equipping. Can be used to remove equipment parts from combatant/class settings.
- new: Event System: Crafting Steps: 'Learn Recipe' and 'Forget Recipe' steps can now optionally learn/forget all crafting recipes of a selected crafting type.
- new: Event System: Check Steps: 'Chance Fork' step available. Define multiple value ranges, the next step of the first range that contains the random chance (minimum <= chance <= maximum) will be executed.
- new: Event System: Camera Steps: 'Collision Camera' step available. Enable/disable the collision camera - requires a 'Collision Camera' component attached to the camera.
- new: Event System: Movement Steps: 'Stop Movement' step available. Stops movement from 'Change Position', 'Move Into Direction' and 'Curve Move' steps.
- new: Game Events: 'Starting Object' actor type available. Uses the game object that started the event as actor. In most cases this will be the player, but you can use this to access other objects that started an event.
- new: Battle AI: Check Steps: 'Chance Fork' step available. Define multiple value ranges, the next step of the first range that contains the random chance (minimum <= chance <= maximum) will be executed.
- new: Battle AI: Check Steps: 'Check Game Variable' step available. Checks for game variable conditions - if the conditions are valid, the 'Success' step will be extecuted, otherwise 'Failed'.
- new: Battle AI: Check Steps: 'Game Variable Fork' step available. Checks a single game variable for multiple conditions and executes the first valid condition's next step.
- new: Formulas: Check Steps: 'Check Chance' step available. Which step will be executed next is decided by chance.
- new: Formulas: Check Steps: 'Chance Fork' step available. Define multiple value ranges, the next step of the first range that contains the random chance (minimum <= chance <= maximum) will be executed.
- new: Menu Screens: 'Alive User' setting available. When opening the menu screen and the current user is dead, the first alive member of the group will be used as user. Since dead combatants can't use items, this can be used to automatically switch to a different user when using items in the inventory menu.
- change: Items, Abilities: Status value and status effect change settings can now be copied and moved.
- change: Editor: The drag bar positions are now saved each time when the editor is closed. Previously, they have only been saved when the data has been saved. The remembered sections will be reset the first time you open the editor after this update.
- change: Game Events: The blocking event state will be removed during battles started by the the 'Start Battle' step. The battle controls are now fully useable during those battles.
- change: Scene Changers: When using a scene changer during battles, the battle will end.
- fix: Input Keys: Releasing an input key using 'Hold Time' will now correctly reset the hold timer.
- fix: Combatants, Status Effects: Auto effects will now be checked after initializing the start values of consumable status values.
- fix: Menu Screens: Hiding not equipable equipment (i.e. disabling 'All Weapons/Armors') caused a equipping wrong equipment.
- fix: Combatants: Conditional prefabs now correctly check for the combatant's death.
- fix: Battle System: Active Time Battles: The 'Start Calculation' formula is now correctly used at the start of the battle.
- fix: Battle System: The death event of the last player combatant didn't play when not using 'End Immediately'.
- fix: Game Over: Dead combatants played the idle animation while fading to the game over scene.
- fix: Item Collectors: Not using quantity limits could lead to items not being collected.


Version 2.1.0:
- new: Quest System: The new quest system consists of 'Quest Types', 'Quests' and 'Quest Tasks'. They are created in the 'Game' section of the ORK Framework editor.
- new: Quest Types: Quest types are used to separate quests into different types. The quest types can be used in menus and HUDs to filter/limit displaying quests.
- new: Quests: Quests can give rewards (experience, items, equipment and money) upon successful completion. A quest consists of multiple quest tasks.
- new: Quest Tasks: Quest tasks are the actual things a player needs to do in a quest. You can define requirements for activating, finishing or failing a task. The task's progress can be handled automatically.
- new: Menu Screens: 'Quest' menu part available. Displays the quests of the player and can be separated by quest types. Quests can optionally be set active/inactive.
- new: Interactions: Quest/task status conditions available in all interactions (e.g. Event Interaction, Item Collector).
- new: Requirements: 'Knows Logs', 'Has Quests', 'Has Not Ended Quests' and 'Has Ended Quests' settings available. Requires the player to knows at least one log, quest, active/inactive quest or finished/failed quest.
- new: Game Variables: Advanced Vector3 operations available. Setting a Vector3 game variable can now use the following operators: Add, Sub, Set, Cross, Min, Max, Scale, Project and Reflect. This is available throughout the entire framework.
- new: Inventory, Currencies, Items, Weapons, Armors: 'Inventory Notifications' settings available. Adding/removing items, weapons, armors and currency to/from the player's inventory can optionally display notifications. Also, if something can't be added due to inventory limitations can display a notification. Currencies, items, weapons and armors can override the default notifications.
- new: Inventory, Crafting Recipes: 'Crafting Notifications' settings available. Learning/forgetting a crafting recipe and using it (successfully/failed) can optionally display notifications. Crafting recipes can override the default notifications.
- new: Combatants: Auto Attacks: 'Target Type' setting available. Select the possible targets of auto attacks, e.g. only group/individual targets or all combatants.
- new: Combatants: 'Keep Prefab' settings available in the 'Death Settings'. The combatant's prefab wont be destroyed when the combatant dies (only for non-members of the player group).
- new: Text Codes: New text codes available for quest, quest task and quest type information.
- new: Event System: 'Quest Steps' available. There are various new steps available to manage/check the status of a quest and quest tasks.
- new: Event System: Dialogue Steps: 'Quest Choice' step available. Displays a dialogue or choice dialogue with quest information of a selected quest.
- new: Event System: Dialogue Steps: The message of 'Show Dialogue', 'Teleport Choice' and 'Value Input Dialogue' steps can optionally also be printed to the console.
- new: Event System: Dialogue Steps: The cancel choice in 'Teleport Choice' steps can optionally be the first choice in the list.
- new: Event System: Status Steps: 'Initialize to Level' step available. Initialize a combatant/group to a defind level and class level. All previous progress (e.g. learned abilities, status values) will be lost, all equipment will be unequipped.
- new: Event System: Base Steps: 'Wait For Input Fork' step available. Waits for an input key (out of multiple keys) to be pressed, either for a set amount of time, or until the key has been pressed. The next step of the input key that's pressed first will be executed.
- new: Event System: Statistic Steps: 'Clear Statistic' can now optionally reset a selected statistic value instead of all values.
- new: Event System: Statistic Steps: 'Check Statistic' step available. Checks a selected statistic value against a defined value.
- new: Event System: Statistic Steps: 'Statistic To Variable' step available. Stores a selected statistic value into a float game variable.
- new: Event System: Movement Steps: 'Transform To Variable' step available. Stores a transform's position, rotation or scale into a Vector3 game variable.
- new: Event System: Movement Steps: 'Block Move AI' step can now optionally block the move AI of a selected object instead of blocking it completely (i.e. for all objects).
- new: Battle Events: Battle Steps: 'End Phase' step available. The phase will end after the action finishes - combatants who didn't chose an action yet will not be able to do so. Only used in 'Phase' battles.
- new: Status Values: 'Start Value' settings available for 'Consumable' type status values. Define the start value of 'Consumable' status values either in percent of their maximum status value or an absolute value. By default 100 % of their maximum status value.
- new: Status Values: 'No Regeneration' setting available for 'Consumable' type status values. Optionally excludes a status value from being fully recovered upon regeneration (e.g. on level up or by the 'Regenerate' event step).
- new: Menu Settings, GUI Boxes: 'Show Unfocused' setting available for choice icons. The choice selection icon can optionally be displayed on a not focused GUI box.
- new: Battle AI: 'End Phase' setting available in all action steps. The phase will end after the action finishes - combatants who didn't chose an action yet will not be able to do so. Only used in 'Phase' battles.
- new: Game Settings: Area Notifications: 'Queue Area Notifications' setting available. Area notifications can optionally be displayed in sequence instead of replacing the current notification with a new one.
- new: Areas, Game Settings: Area Notification: 'Play Sound' settings available. An area notification can play an audio clip (even when not displaying the notification box).
- new: Areas, Game Settings: Area Notification: 'Show Portrait' setting available. Showing an area's portrait in the area notification is now optional. By default enabled.
- new: Battle Texts: 'Queue Infos' setting available. Battle infos can optionally be displayed in sequence instead of replacing the current info with a new one.
- new: HUDs: 'Quest' type HUD available. Displays a list of quests and their tasks. The displayed quests can be filtered by quest type and status.
- new: HUDs: 'Hide Empty HUD' setting available. A HUD will be hidden if it doesn't display any elements. Not available for 'Control', 'Navigation' and 'Console' type HUDs.
- new: HUDs: 'Quest' and 'Quest Task' settings available in 'Tooltip' type HUDs. A tooltip can be dispalyed when hovering the mouse above a quest or quest task in a 'Quest' type HUD.
- new: Main Menu: 'Stop Music' setting available. The current music is stopped when starting a new game. By default enabled.
- new: Status Effects, Battle Texts: 'Remove Status Effect' notification text settings available. You can display a notification text when a status effect is removed from a combatant.
- change: Object Variables: Accessing an object variable's component in the start function of a script now also initializes the variables.
- change: Event System: Moving, rotating and scaling objects over time will now start immediately. Previously, the changes started in the next frame, leading to sometimes not being finished completely after the wait time.
- change: Event System: PlayerPref Steps: The PlayerPrefs are saved each time after setting a PlayerPrefs.
- change: Inventory: Inventory limits prevent getting items from item collectors/boxes and buying items.
- fix: GUI Boxes: 'Select First' is now working correctly.
- fix: Menu Screens: The description part in equipment screens now displays the correct part information.
- fix: Menu Screens: Crafting menus could throw an error when using a choice for creating recipe outcomes.
- fix: Menu Screens: Group menus could throw an error (and block the menu from exiting) when using complex combatant layouts.
- fix: Event System: Base Steps: The 'Wait For Input' step now receives the input from input keys with 'Hold Time' correctly.
- fix: Event System: Game objects that are destroyed before being used in steps wont throw errors.
- fix: Console: Learning and forgetting console texts used the action range settings instead of learn/forget range.
- fix: Weapons, Armors: Enabling/disabling equipment parts wont throw errors when not using combatant equipment override.
- fix: Shops: Selling the last item of the inventory (without displaying 'Back' buttons) wont get you stuck in the shop any longer.
- fix: Save Games: Saving scene data (e.g. finished battles, collected items) is now working correctly.
- fix: Status Effects, Abilities, Items: Status effects overriding an ability/item attack attribute could result in an error.


Version 2.0.9a:
- new: Battle Events: Battle Steps: 'Use Ability Calculation' step available. Uses an ability (without animation) - the user/target changes will be calculated. The user doesn't need to know the ability.
- new: Battle Events: Battle Steps: 'Use Item Calculation' step available: Uses an item (without animation) - the user/target changes will be calculated.
- new: Shop Layouts: 'Show Portrait' setting available in the 'List Box' settings. The portrait of a selected item, weapon or armor in can be displayed.
- change: Controls: Blocking events will now prevent the use of battle related controls (e.g. control maps, group/individual target keys, ...).
- change: Editor: Combatants: The combatant's settings have been rearranged into 'Base Settings', 'Status Settings', 'Attacks & Abilities', 'Inventory & Equipment', 'Battle Settings' and 'Animations & Movement'.
- fix: Custom Controls: Custom camera controls aren't blocked by player control anymore.
- fix: Menu Screens: The description part now displays the correct content information of an equipped weapon/armor when selecting an equipment part.
- fix: Phase Battles: The next phase now starts automatically if no combatant of the current phase can perform an action.


Version 2.0.9:
- new: Event System: 'Found Objects' are available in all actor/waypoint/prefab-selections. Found objects are game objects in the scene that have been searched (and found) by the new 'Search Object' step.
- new: Event System: Base Steps: 'Search Objects' step available. Searches for game objects in the scene and adds or removes them to the 'Found Objects' list, or removes all found objects from the list.
- new: Battle Events: New actors available. Use 'User Group', 'Target Groups', 'All Allies', 'All Enemies' and 'All Combatants' actors for advanced battle events.
- new: Battle Events: Battle Steps: 'Change Action Targets' step available. A combatant is added or removed as a target of the action, or all targets can be removed.
- new: Game Events: Actors and waypoints have advanced 'Find Object' settings. You can now search for objects within a defined range.
- new: Combatants: 'Equipment Settings' available. Combatants can optionally override the equipment settings of their class, making the available equipment parts, weapons and armors independent from the class.
- new: Combatants: 'Experience Rewards' now have advanced reward value settings. You can use a value, game variables, formulas and other sources for the experience reward value.
- new: Abilities, Items: 'Animation Settings' available in the 'Damage Dealer Settings'. Damage dealers can optionally use battle events to create more complex actions when hitting a damage zone.
- new: Damage Zones: 'Audio Settings' available. Damage zones can play audio clips or a sound type when receiving damage from a damage dealer.
- new: Equipment Viewers: Advanced material settings available. You can optionally use the renderer of a child object and use an indexed material (if the renderer uses multiple materials).
- new: Menu Settings: 'Mouse Over Selection' setting available. Optionally selects (not accepts) a choice when the mouse cursor is above it (only on the currently focused GUI box).
- new: Game Controls: Custom Controls: The custom control behaviours are now separated from player/camera controls. You can select on which object (player or camera) a control is located and with which control they'll be blocked (player or camera).
- new: Placement: 'Scale' settings available for placing/mounting objects (e.g. spawn prefab step, cursor placement, etc.) throughout the entire framework.
- new: Quantity Selections: 'Hide Buttons' setting available for quantity selection buttons. Optionally hide the buttons, but still allows changing the quantity with the input keys.
- new: Quantity Selections: Advanced text codes available to display inventory money/item changes, details about the currency and the icon of the item.
- new: Combatant Component Inspector: The combatant component's inspector now displays advanced information on a combatant's battle data and actions.
- new: Menu Screens, Item Boxes: Description Part: Advanced text codes available and optional custom description text.
- change: Value Input: The value input field name is now multi-lingual.
- fix: Combatants: The start equipment's requirements will now also use bonuses from classes.
- fix: Shop Layouts: Buy/sell quantity selections got mixed up when using something other than 'Default'.
- fix: Battle Menus: The target cursor wasn't removed when clicking on a target to select it.
- fix: Phase Battles: Selecting 'End Phase' after canceling a combatant's battle menu didn't progress to the next phase.
- fix: Phase Battles: The combatant selection with 'Only Available' enabled and combatants not able to perform an action didn't progress to the next phase.
- fix: Active Time Battles: Doing nothing (i.e. 'End' battle menu item) resultet in the battle menu not reappearing when the timbar filled again.
- fix: GUI Boxes: Disabling the 'Use Cancel Button' setting was ignored.


Version 2.0.8:
- new: Formulas: 'Initial Value' settings available for formula selections throughout the entire framework. The formula will use the initial value as it's base and start the calculation with that value. The start value of the formula will be calculated to the initial value based on the selected operator in the formula's settings.
- new: Abilities, Items, Currencies, Weapons, Armors, Crafting Recipes: 'Portrait Settings' available. The portrait can be displayed by menus when the ability, item, currency, weapon, armor or crafting recipe has been selected.
- new: Menu Screens: 'Show Portrait' setting available in 'Ability', 'Ability Tree', 'Crafting', 'Equipment' and 'Inventory' menu parts. The portrait of a selected item, currency, weapon or armor in the inventory screen can be displayed.
- new: GUI Boxes: 'Show Button' setting available. Displaying a button around the content of a choice, tab or ok/cancel button is now optional (by default enabled).
- new: Abilities: Advanced 'Cast Time' settings available. The cast time of an ability can now also use formulas, game variables and other sources.
- new: Abilities: Advanced 'Reuse After' settings available. The reuse turns/time of an ability can now also use formulas, game variables and other sources.
- new: Shop Layouts: The 'List Box' settings can now optionally use a different layout for the back button. Use it when using custom info in the content layout that would otherwise also be displayed on the back button.
- new: Game Controls: Advanced 'Member Change Keys' settings available. Switching the player is optional for the field, turn based, active time, real time and phase battles. Switching the current menu user is available for active time and real time battles only.
- new: Interactions: 'In Blocked Control' setting available for 'Trigger Enter', 'Trigger Exit', 'Key Press' and 'Drop' interactions. The interaction can be started even while the player control is blocked (e.g. during a control blocking battle or event).
- new: Main Menu: The main menu can display a portrait. Optionally, every main menu option can display a different portrait.
- new: Battle Menus: Battle menus can display portraits of selected items, abilities, equipment, targets and command targets.
- new: Battle Menus: 'Use Sub-Menu Boxes' setting available. Battle menus can optionally use different GUI Boxes for different sub menus (e.g. ability type menu, item menu, target menu).
- new: Battle Events: Battle Steps: 'Activate Damage Dealer' step can now use the ability's or item's audio clip and prefab defined in their damage dealer settings.
- new: Damage Dealers: Environmental damage dealers now use the audio/prefab settings defined in the ability's damage dealer settings.
- fix: Shop Layouts: The content layout of the 'List Box' settings now displays custom info.
- fix: Event System: Movement Steps: 'Change Position' step using movement by speed now only faces the move direction if 'Face Direction' is enabled.
- fix: Real Time Battle Areas: Battle now ends correctly when leaving real time battle areas.
- fix: Input Keys: Getting the axis value from input keys set via HUD or code is now correct.
- fix: Menu Screens: Spamming the 'Cancel' key when having multiple non-single menu screens opened caused problems.
- fix: Turn Based Battles: Killing an enemy that had the last action could lead to the battle not continuing.
- fix: Real Time Battles: Death of combatants could lead to wait times between actions.


Version 2.0.7:
- new: GUI Boxes: You can use different text format settings for the text, info and title of choices.
- new: Control Maps: 'Need Targets' setting available. 
- new: Camera Controls: 'Mouse' camera control zoom by keys received an option to use a single key as axis instead of two separate buttons. Use this option for mouse wheels.
- new: Finding Objects: Finding objects in game event actors, navigation markers and custom main menu choices can now search for attached components. The found object is the one the component is attached to.
- new: Weapons, Armors: 'Viewer Material' setting available. Weapons and armors can change the material used by a renderer attached to the same game object as an 'Equipment Viewer'.
- new: Group Targets: You can now select different group targets for different abilities, ability types, items and item types. Settings are made in 'Battle System > Battle Settings'.
- new: Individual Targets: Set individual targets for a combatant to use abilities and items on. Work like group targets. Settings are made in 'Battle System > Battle Settings'.
- new: Combatants: 'Attack Individual Target' setting available. Uses an individual target for AI attacks.
- new: Combatants: 'Run Speed Threshold' and 'Sprint Speed Threshold' settings available in the combatant's 'Animation Settings'. Use thresholds for a smoother transition between walk/run and run/sprint animations.
- new: Battle Menus: 'Auto Target Settings' available. Optionally use abilities (also attacks) and items automatically on a group target or individual target.
- new: HUDs: 'Combatant Origin' setting available in 'Combatant' type HUD elements (except for 'Shortcut' elements). Select if the displayed information comes from the HUD's user, a group/individual target or the last target (of an attack, ability or item) of the user.
- new: HUDs: Shortcuts ('Combatant' type HUDs') can optionally target a group/individual target automatically when double clicked.
- new: Damage Types: The new damage types define the animation types used for damage, critical damage and evasion. Damage types are assigned to ability/item types and can optionally be assigned to abilities and items as well. This allows having different damage/evasion animations for each ability or item.
- new: Ability Types, Item Types: Set the default damage type for all abilities/items of the ability/item type.
- new: Abilities, Items: Abilities and items can override the default damage type of their ability/item type.
- new: Move AI: Advanced status requirements available for hunting and flee conditions.
- new: Interactions: The 'Trigger Enter' and 'Trigger Exit' start types of interactions can now be started by other game objects than the player. If an object can start the event can be checked by name/tag or by checking of added components, or both.
- new: Crafting Recipes: 'Audio Settings' available. Crafting recipes can play an audio clip when the creation has been successful or failed.
- new: Custom Controls: 'From Root' setting available. Searching/adding behaviour components will use the root of the game object - use this setting if the object isn't the real root.
- new: Custom Controls: You can optionally change fields and properties of custom control behaviours.
- new: Value Checks: 'Not Equal' check available. You can now use the not equal check in all value checks (previously only is equal, less or greater) - e.g. used in status requirements, distance checks, etc.
- new: Animations: 'Auto Move Speed Parameter' settings available for Mecanim. Optionally set the horizontal and vertical move speed of a combatant to float parameters of the game object's Mecanim animator.
- new: Scene Wizard: You can now create interaction controllers for 2D and 3D interactions.
- change: Status Values: 'Consumable' type status values can now only select 'Normal' type status values as maximum status value.
- change: Event System: 'Show Notification' step is now available in battle events, battle start events, battle end events and phase battle events.
- change: Battle Events: The 'Death' event now uses the combatants who attacked the dying combatant as targets.
- change: Animation Types: The animation types for damage, critical damage and evasion are now defined in 'Base/Control > Damage Types'.
- change: Difficulties: A combatant's 'Experience Rewards' are now influenced by the difficulty's faction status multipliers.
- change: Status Values: The percent bonus to combined 'Normal' type status values is now added after the final value calculation.
- change: Status Effects: When using formulas for status conditions, the calculation now happens every time, not only once.
- change: Status Effects: The caster of a status effect will now be used as the user for calculations of all changes, not only on cast.
- fix: Main Menu: The difficulty menu couldn't be displayed due to a bug.
- fix: Input Keys: Input keys of type 'Unity Input Manager' used as axis didn't receive input when the time scale was set to 0 (e.g. when using 'Freeze Game' in menu screens).
- fix: Menu Screens: The combatant's status values didn't update when the menu screen used 'Freeze Game'.
- fix: Menu Screens: Sub menus of menu screens that paused the game wheren't displayed and the game locked.
- fix: Abilities, Items: Using raycasts for 'None' target abilities/items is working now.
- fix: Event Interactions: When playing in the editor with an event interaction selected in the inspector, the event could be reloaded, stopping a running event from continuing.
- fix: Battle Start Events: The 'Spawn Combatants' step will now add player controls when spawning the player (e.g. when the battle takes place in a different scene).
- fix: Move AI: Stopping due to external influences (e.g. 'Stop Movement' status effect) wont cause loss of the hunted target any longer.
- fix: Combatant Spawners: Using combatant spawners with teleport battles (i.e. fighting in a different scene) wont result in the already spawned combatants missing in the battle.
- fix: Save Games: Error when loading inventory with money solved. Status values will now display the correct value. Equipment is now loaded correctly.
- fix: Compatibility: The 'EaseType' enumeration is now in the ORKFramework namespace and can be used with HOTween.
- fix: Status Effects: Having wrong auto apply/remove settings could lead to a stack overflow because a status effect was added and removed at the same time.
- fix: GUI Editor: Displaying 'Combatant' or 'Turn Order' type HUDs in the GUI Editor could crash Unity when having deadlocked auto apply/remove status effects.
- fix: Shops: Clicking on the 'Exit' button without selecting it first didn't return the control back to the player.


Version 2.0.6:
- new: Input Keys: 'Key Combo' input type available. Use a sequence of other input keys as input (e.g. 'A+A+B') as input. Define the used input keys and time the player has to press the next button. Each combo key can ignore selected other input keys (i.e. they wont cancel a combo).
- new: Value Inputs: Value inputs can now be selected and changed using input keys (i.e. vertical keys for selection, horizontal keys for slider changes, toggle bools and start text editing with accept).
- new: Event System: Equipment Steps: The 'Check Equipment' step can now check if an equipment part is generally equipped with a weapon or armor without specifying a specific equipment.
- new: Images: Use alpha mask textures to hide parts of displayed images. Used in image event steps, background images, portraits and HUDs.
- new: Event System: Rigidbody Steps: 'Add Force Rigidbody' step available. Add a force to 2D and 3D rigidbodies - optionally relative force (3D only).
- new: Event System: Rigidbody Steps: 'Add Torque Rigidbody' step available. Add torque to 2D or 3D rigidbodies.
- new: Event System: Rigidbody Steps: 'Position Force Rigidbody' step available. Add a force to a position, applying force/torque to 2D and 3D rigidbodies.
- new: Event System: Rigidbody Steps: 'Explosion Rigidbody' step available. Adds an explosion effect force to 3D rigidbodies.
- new: Event System: Rigidbody Steps: 'Stop Rigidbody' step available. Stops adding force/torque from other event steps to rigidbodies.
- new: Menu Screens: 'Remember Selection' setting available. Remembers the selected menu item when returning to the menu screen.
- new: GUI Boxes: 'Scale Settings' available in the 'Move In' and 'Move Out' settings. You can use this to create zoom effects when moving a GUI box in or out.
- new: Combatants: 'Experience Reward' settings available. You can now define experience rewards the player receives for defeating a combatant, without using the status development settings of the combatant. The real status values of the combatant and the exp reward can now be separated.
- new: Game Options: 'Random Battle Chance' option available in option menus (main menu and menu screens). Changes the chance for random battles happening. Used as percent of the chance defind in 'Random Battle Areas' (plus bonuses). E.g. 100 % is the default chance, 0 % is no random battles, 200 % is double chance.
- new: Abilities, Items: 'Random Battle Factor' settings available. Abilities and items can change the random battle factor for a defined amount of time. While the factor is changed by an ability/item, the factor bonuses of player group members are ignored. The factor is defined in percent.
- new: Control Maps: You can optionally select the equipment part used for an attack. The attack will only be used if a weapon with 'Override Attack' is equipped on the selected equipment part. Uses the attack of the equipped weapon.
- new: Battle Menus: 'Equipment' menu item type available. Lists the combatant's equipment parts and allows changing the equipment (similar to the equipment menu).
- new: Battle menus: 'Command' menu item type available. Give commands to other members of the group. Optionally only for 'AI Controlled' combatants. The given command will be performed the next time they're able to choose an action, giving a different command will override the previous one.
- new: Status Effects: 'Block Equipment Change' and 'Block Command' settings available. Status effects can now prevent a combatant from changing equipment and giving commands to other combatants.
- change: Battle Menus: Abilities and items can only be selected if targets are available.
- change: Control Maps: Abilities and items can only be used (and display a target menu) if targets are available.
- fix: Scene Wizard: Creating camera positions with the scene wizard will again add them to the data when the ORK Framework editor isn't already opened.
- fix: Combatants, Classes: Class development now uses the correct maximum values for class experience. The class experience is based on the status development of the class.
- fix: Battle System: Using items/abilities on combatants without doing damage will now also mark them as attacked by the user and allows the player to get battle gains from them.
- fix: Battle System: An enemy can't start a battle (when the player enters the combatant's battle start range) while a blocking menu is opened.
- fix: Battle Settings: Not using the target menu will now prevent the target menu from being displayed.


Version 2.0.5:
- new: Game Controls: Camera Control: 'Top Down Border' camera control available. Top down camera following the player until he crosses a border. The border is defind in the scene using a 'Camera Border' component with a 'Box Collider' (the collider defines the border).
- new: Scene Wizard: 'Camera Border' can be added to the scene through 'Create Object'. Adds a new game object with a 'Box Collider' and a 'Camera Border' attached.
- new: Event System: Camera Steps' 'Camera Control Target' step available. Changes the target of the camera control (i.e. the object the camera will follow). Requires the control to be a descendant of 'BaseCameraControl' (e.g. all built-in camera controls).
- new: Status Effects: 'End On Death' setting available. The effect will end when the combatant dies. By default enabled.
- new: Status Effects: 'Absorb Damage' settings available in 'Status Conditions'. Optionally absorbs damage dealt to a selected status value by abilities/items (with 'Use Absorb Effect' enabled).
- new: Status Effect Changes: 'Force' setting available. The status effect change will be forced, ignoring the target's status effect immunities.
- new: Abilities, Items: 'Use Effect Absorb' setting available. The user of the ability/item will absorb damage dealt according to applied absorb status effects.
- new: Abilities, Items: 'Volume' settings available for playing audio clips on status changes.
- new: Game Settings: 'Initial Game Variables' settings available. Define game variables that will be automatically set up when starting a game (i.e. before the main menu).
- new: Main Menu: 'Options' settings available. Add an options button to the main menu to display an options menu. You can change the music and sound volume, text speed and custom options (using global game variables).
- new: Menu Screens: 'Volume' settings available for the open and close audio clips.
- new: Menu Screens: 'Pause Settings' available. The game can optionally be paused while a menu screen is open. Pausing the game can also optionally pause the game time and freeze the game completely.
- new: Menu Screens: 'Options' menu part available. You can change the music and sound volume, text speed and custom options (using global game variables).
- new: Menu Audio: 'Value Input' audio settings available. A sound can be played when changing an input value (e.g. options menu, value input dialogues). Setting can be found in 'Menu Settings' and in GUI boxes which override the default audio settings.
- new: Inventory Settings: Item Collection: A sound can be played when collecting an item. The used sound can be either a selected sound type assigned to the player's combatant, or a selected audio clip.
- new: Inventory Settings: Item Box: Like the item collection, item boxes can now also play an animation and sound when the player interacts with them.
- change: Event System: Dialogue Steps: Choices in 'Show Dialogue' steps can be copied and moved.
- change: Event System: Inventory Steps: 'Add To Inventory', 'Remove From Inventory', 'Has In Inventory' and 'Drop Items' steps can now use formulas, game variables and other values to set the quantity and chance of items.
- change: Game Variables: The 'Is Valid' setting when checking game variables is now by default enabled.
- change: Stealing: Stealing items/money will now remove the stolen item/money the target's inventory, even if it's not the player.
- fix: Shops: Clicking on a 'Cancel' button when not using the buy/sell box and type box caused an error.
- fix: Node Editor: Event System: 'Show Dialogue' could throw an error when loading an event with a 'Choice' type dialogue without any choices.
- fix: Status Effects: Spawning prefabs for auto applied effects could sometime be displayed when spawning a combatant and immediately removing the effect.
- fix: Battle System: Enemies killed by other NPCs (not part of the player faction) wont give the player experience and loot - only if the player also attached the combatant.


Version 2.0.4:
- new: Shops: Selling individual items, weapons and armors can now depend on variable conditions.
- new: Shops: 'Sell to Shop' settings available. You can optionally limit which item types the player can sell to a shop.
- new: Text Code: 'Log Text' text code available. Displays the text of a log text, e.g. #logtext5# displays the text of log text with ID (index) 5.
- new: Game Controls: Custom player/camera control scripts can now be added to child objects.
- new: Console Settings: 'Unity Console Output' setting available. Optionally print new console lines in the Unity console when playing in the Editor.
- new: Event System: Equipment Steps: 'Lock Equipment Part' step available. Lock/unlock an equipment part of a combatant. Locked equipment parts can't change equipment.
- new: Event System: Equipment Steps: 'Check Part Locked' step available. Checks if a selected equipment part of a combatant is locked.
- new: Event System: Variable/Inventory Steps: 'Inventory To Variable' step available. Stores the quantity of a selected item, currency, weapon or armor found in an inventory into a float game variable.
- new: Status Effects: End after turn/time now also allows using formulas, game variables, PlayerPrefs and game time to determine the turns/time.
- new: Mouse/Touch Controls: New mode 'Hold' available for mouse/touch controls. Recognizes the input while holding it down (i.e. everything between 'Start' and 'End'). E.g. used in the 'Mouse' player controls.
- new: GUI Boxes: 'Selected Choice Offset' setting available. Optionally add an offset to the x-position of a selected choice. Setting also editable in the WYSIWYG editor.
- new: Node Editor: You can remove a focused node by pressing 'Delete'. You can remove the focused nodes and all following nodes (remove chain) by pressing 'ALT + Delete'. A focused node is displayed with an additional highlight around the node.
- new: Main Menu: 'Custom Choice Settings' available. You can add custom choices to the main menu (before the 'Exit' button). A custom choice will search for a game object in the scene and try to call a defined function on it. The call happens after the main menu is closed.
- new: Input Keys: 'Hold Time' setting available. When using input handling 'Hold' or 'Down', you can define the time the key has to be held to recognize the input.
- new: Inventory Settings: Item Collection: 'Auto Close' settings available. The item collection dialogue can automatically close after time.
- new: Combatants: The combatant's object variables can be initialized with default variables.
- new: Scene Objects: 'Object Variables' settings available. You can automatically add an 'Object Variable' component to a scene object and initialize them with default values.
- change: Editor: Events: The 'Close' button will now display a question dialogue if you really want to close the event.
- change: Status Effects: Reapplying a status effect (i.e. applying it again when it's already added) now also checks the hit chance.
- change: Inventory Settings: Item Collection: Playing an animation now uses Animation Types.
- fix: HUDs: 'Console' type HUDs don't throw an error when using 'All Console Types'.
- fix: Random Battle Area: Using a 'Battle Object' for the random battles blocked starting battles after the first battle.
- fix: Music: Playing the same music that is currently stored could sometimes result in playing from the stored time.


Version 2.0.3
- new: Editor: GUI Editor: The WYSIWYG editor allows editing HUDs.
- new: Editor: Updating events when saving or scanning for game variables in events can optionally only scan within a defind folder in the 'Assets' path.
- new: Editor: Status Development Curves: Creating a status development curve can now optionally use a curve instead of interpolation points.
- new: Abilities: 'Remove Turn' setting available. In 'Turn Based' battles, the target of the ability will be forced to skip a turn (if not yet performed).
- new: Items: 'Turn Based Order Changes' settings available. Like abilities, items can now change the turn order or remove the turn of a target in 'Turn Based' battles.
- new: Menu Screens: Equipment Part: Highlighting the 'Unequip' button will now also display preview values (for unequipping the equipment part).
- new: Status Effects: 'End Action' settings available. A status effect can optionally let the combatant perform an action when it ends. The action will be performed the next time the combatant can choose an action.
- new: Status Effects: 'No Turn Order Change' and 'No Turn Remove' settings available. Optionally grants immunity to turn order changes and removing a turn using abilities or items.
- new: HUDs: The new 'Turn Order' type HUD displays the current turn order of 'Turn Based' battles.
- new: HUDs: Navigation: 'Navigation' type HUD elements can display a background image.
- new: HUDs: Combatant: 'Combatant' type HUD status effect elements now allow adding multiple lables (similar to shortcut elements) to create more complex status effect information.
- new: HUDs: Combatant: 'Combatant' type HUD status effect elements can display the remaining time/turns of a status effect using % (without decimals, %1 (with 1 decimal) and %2 (with 2 decimals). Remaining turns are always displayed without decimals.
- new: HUDs: Tooltip: 'Status Effect' setting available in 'Tooltip' type HUDs. A tooltip can now be displayed when hovering the mouse above a status effect in a HUD.
- new: Combatants: 'Not Controllable' setting available. An 'AI Controlled' combatant can optionally be set to not controllable by the player. The combatant can't be selected as player using the player change keys.
- new: Languages: 'Initial Language' setting available. Set a language to be the initially selected language when starting the game.
- new: Damage Dealers: 'Environmental Damage' settings available. Set a damage dealer to be 'Always On' - damage will be dealt without firing an action first. You can use this for things like traps, hazardous areas or damage on contact with enemies.
- new: Damage Dealers: 'Reset Targets' settings available. When using 'One Time Damage' or 'One Target' you can use this to remove blocked targets after a defined amount of time, enabling additional damage by the damage dealer.
- new: GUI Boxes: 'Input Field Settings' available. Set spacing and alignment of input fields in dialogues.
- new: Event System: Dialogue Steps: 'Value Input Dialogue' step available. Displays a dialogue to input string, bool and float values and store them in game variables.
- new: Event System: Inventory Steps: 'Clear Inventory' step available. Removes everything (money, items, weapons and armors) from an inventory.
- new: Event System: Variable Steps: 'Clear Game Variables' step available. Removes all game variables (either local, global or object game variables).
- change: Abilities: 'Turn Based Order Changes' now also remove already fired actions that haven't yet been started. When using multi-turns, the turn value of the target will be changed instead of the turn order.
- change: Reflection: Call/check functions and check/change field/property exceptions now display the stack trace.
- fix: Move AI: 'Target Position Check' intervals of 0 now correctly update the target's position.
- fix: GUI Boxes: Selecting the last choice in a menu screen (e.g. equipment) which removes the choice wont cause an error any longer.
- fix: Event System: Animation Steps: 'Legacy Animation' now set's the layer and speed of animations correctly.
- fix: Node Editor: Adding unconnected nodes with the context menu will now place them correctly when scrolled down.
- fix: Player Group: Joining a combatant to the active player group after the player has already been spawned didn't spawn the new battle group member (requires 'Spawn Group' enabled in 'Game > Game Settings').


Version 2.0.2
- new: Editor: GUI Editor: The new GUI Editor allows editing GUI boxes in a WYSIWYG editor.
- new: Editor: You can open the ORK Framework editor using the hotkey 'CTRL + ALT + O'.
- new: Scene Wizard: You can open the ORK Scene Wizard using the hotkey 'CTRL + ALT + W'.
- new: Game Controls: Custom player/camera control scripts can now also be attached to child objects.
- new: Game Events: New event actor type 'Camera' available. Uses the event's camera as an actor.
- new: Event System: Movement Steps: 'Curve Move' step available. Move a game object using curves.
- new: Event System: Rotation Steps: 'Curve Rotation' step available. Rotate a game object using curves.
- new: Event System: Active Group Steps: 'Join Active Group' step allows adding a combatant group to the active player group.
- new: Abilities, Items: 'Use Screen Combatant' setting available. When using it's own combatant selection in menus, items and abilities can automatically be used on the current menu user without showing a combatant selection.
- new: Main Menu Settings: 'Set Start Group' setting available. You can use a Combatant Group as the player group at the start of a new game.
- change: GUI Boxes: The default settings for new GUI boxes have changed. The content/name box bounds have changed and the name box is now relative to the content box.
- fix: Event System: 'Use Center' setting in various steps wont cause objects to disappear when only a single target was used.
- fix: Battle System: Combatants dying when initialized (e.g. due to wrong setup, like 0 HP) wont cause an error.
- fix: Menu Screens: Hidden group members wont be displayed in 'Group Menu Parts' any longer.
- fix: Damage Dealers: Using an ability with the last available needed status value (e.g. MP) will no longer fail to activate the damage dealer.
- fix: Editor: Formulas: Testing formulas in the editor caused errors in some cases.
- fix: Status Effects: 'Auto Apply' caused an error in some cases.
- fix: GUI Boxes: The name box will is now displayed at the correct position when not relative to the content box with all anchor types.


Version 2.0.1
- new: Node Editor: Major update to the node editor. Button toolbar available at the top of the node display. Optional background grid display available. Searching the node list available.
- new: Editor: The variable list is automatically updated when saving the settings or an event. When saving the settings, only the settings will be scanned. When saving an event, only the event will be scanned.
- new: Items: 'Requirements' settings available. Using an item can depend on status requirements and variable conditions.
- new: Abilities: 'Requirements' settings now contain variable conditions. Using an ability can depend on variable conditions.
- new: Abilities, Items: 'Not On Self' setting available. When targetting allies or all combatants, the user can be excluded from being a target.
- new: Status Values: 'Critical Refresh Notification' and 'Critical Damage Notification' settings available. Optionally display different change notifications for critical hits.
- new: Event System: The new 'Image Steps' allow showing, fading and moving images on the screen. 'Show Image', 'Change Image Position', 'Change Image Color' and 'Remove Image' steps available.
- new: Event System: Variable Steps: 'Game Variable Fork' step available. Similar to 'Check Game Variable' step, but checks a single game variable for multiple values. The next step depends on which condition is valid.
- new: Event System: Status Steps: 'Status Fork' step available. The next step depends on which status requirement is valid.
- new: Event System: Status Steps: 'Change Status Value' step can optionally display change notifications as critical changes.
- new: Event System: Equipment Steps: 'Equipment Fork' step available. The next step depends on which weapon or armor is equipped on an equipment part.
- new: Event System: Fade Steps: 'Blink Object' step available. Starts/stops blinking a game object.
- new: Event System: Base Steps: 'Block Control Map' step available. Blocks/unblocks a selected control map or all control maps. A blocked control map can't be used.
- new: Event System: Dialogue Steps: 'Block HUD' step available. Blocks/unblocks a selected HUD or all HUDs. A blocked HUD wont be displayed.
- new: Event System: Function Steps: 'Change Time Factor' step available. Changes the time factor of Unity (everything in the game) or ORK Framework (things like battles and events only). You can use this to create slow motion effects.
- new: Event System: Function Steps: 'Check Component Enabled' step available. Checks if a component is enabled.
- new: Event System: Function Steps: 'Change Fields' step can now also change properties. Use the new 'Is Property' setting.
- new: Event System: Function Steps: 'Check Fields' step available. Checks the value of fields or properties of a component.
- new: Event System: Function Steps: 'Check Function' step available. Checks the return value of a function of a component.
- new: Event System: Movement Steps: 'Change Nav Mesh Target' step available. Sets the destination and speed of a Nav Mesh agent, or stops the agent.
- new: Formulas: Variable Steps: 'Game Variable Fork' step available. Similar to 'Check Game Variable' step, but checks a single game variable for multiple values. The next step depends on which condition is valid.
- new: Formulas: Combatant Steps: 'Status Fork' step available. The next step depends on which status requirement is valid.
- new: Logs: 'Invert Text Order' setting available. Optionally display log texts in inverted order (i.e. from high index to low index).
- new: Move AIs: 'Detect Only Leader' setting available. Detecting enemies can optionaly be limited to the group leader of an enemy group.
- new: Save Game Menu: Save Point: The 'Save' and 'Cancel' button are now optional (by default enabled). The 'Cancel' button can optionally override the default 'Cancel' button's content.
- new: Control Maps: 'Requirements' settings available for the whole control map and single control map keys. Using the control map or individual keys can optionally depend on status requirements and variable conditions.
- new: Battle AI: 'Check Distance' and 'Check Angle' steps available. Check possible targets upon distance and angle conditions. New 'Position Steps' group in step selection.
- new: Battle System: 'Stack Loot' setting available in all battle system types. Loot of the same kind will optionally be stacked. By default enabled.
- new: Turn Based Battles: 'Invert Turn Order' setting available. The turn order can optionally be inverted, i.e. sorted ascending, not descending (the combatant with the lowest value will have the first action).
- new: Turn Based Battles: 'Use Multi-Turns' setting available. A combatant can optionally perform multiple turns before another combatant had his turn. After a combatant performed his turn, his turn value will be reset to 0 and the turn value of all combatants will be increased. Available when 'Active Command' is enabled.
- new: Save Game Menu: 'Save Block States' setting available. The stated of blocked Input Keys, Control Maps and HUDs can be saved.
- new: Menu Screens: 'Menu Part Change Keys' settings available. Optionally use input keys to change the active menu part. You can only change to controlable parts (e.g. Inventory).
- change: Editor: Hotkeys: The navigation history hot keys now require the 'ALT' key to be pressed. Use 'ALT + Home' and 'ALT + End' to browse through the navigation history.
- change: Menu Screens: Items and abilities can't be used in a menu screen while the combatant is performing an action.
- fix: Menu Screens: Abilities and equipment displaying level up information will now display the correct inactive alpha value when inactive.
- fix: Event System: Function Steps: The 'Enable Component' step will now also enable/disable colliders, renderers, particle emitters and LOD groups.


Version 2.0.0
Initial release.

For changes to the beta versions, please visit http://orkframework.com.

