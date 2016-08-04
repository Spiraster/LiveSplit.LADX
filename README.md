# LiveSplit.LADX
This is a LiveSplit autosplitter component for Link's Awakening and Link's Awakening DX on emulator.

This autosplitter works with either BGB or Gambatte. It will autodetect which one you're using.

**Supported emulators:**
- BGB 1.5.1
- BGB 1.5.2
- Gambatte r571 (likely earlier versions, as well, though untested)

## Features
- Automatically start the timer when you select a file.
- Automatically select the file when the timer starts. (Useful for SRL racing through LiveSplit)
- Automatically reset the timer when you hard reset the emulator/ROM.

**Note:**
The automatic file select function (#2) involves bringing the emulator to the foreground and spamming the "]" key a number of times in quick succession when the timer starts.
To use it you'll need to map either your start button or A button to "]". There's no option yet to change which key is used.

## Installation
- Place "LiveSplit.LADX.dll" in your LiveSplit "Components" folder.
- Open LiveSplit and add "LADX Autosplitter" to your layout.

## Set-up
- Create your splits how you'd like.
  - Choose from any number of the supported splits.
  - They can be in any order.
- Enter your split names into the settings dialog if yours differ from the defaults.
  - If your split names don't match what's in the settings, the autosplitter will think that split is missing.

### Timing Option (LA Only)
There is an option to adjust the split conditions for instruments if you use ICS (Instrument Cutscene Skip).
- The autosplitter will split upon exiting the dungeon instead of upon grabbing the instrument.
  
## Credits
- [Spiraster](http://twitch.tv/spiraster)
- Work initially based upon old [Yoshi's Island](https://github.com/LiveSplit/LiveSplit.YoshisIsland) autosplitter.
- Further improvements guided by the [LiveSplit.Dishonored](https://github.com/fatalis/LiveSplit.Dishonored) component by [Fatalis](http://twitch.tv/fatalis_).
