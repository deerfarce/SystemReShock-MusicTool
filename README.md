# System Shock Music Tool
##### [view on nexusmods](https://www.nexusmods.com/systemshock2023/mods/78)
This is a program that allows users to create music mods for System Shock (2023).
Dynamic music is not currently supported but I know it is something that many people want.

## features
- Automated uasset editing and packing
- For levels that only use single tracks, looping can be automatic.
- To reduce file size, levels can be configured to use music from other levels.
- Main Menu music and the music in the Intro cinematic can be changed.
- Each Grove can be given different music tracks.
- Files can be packed separately by level, or they can be exported as folders (without packing)
- An optional patch/mod can also be integrated into the pack which disables audio ducking while the MFD is open
- Ability to save projects and open them later
## building
 - clone this repo: `git clone https://github.com/deerfarce/SystemReShock-MusicTool.git`
 - open `SSR Music Packer GUI.sln` with Visual Studio
 - in the Solution Explorer, right click on the solution (the very top item) and click Restore NuGet Packages
 - build and run the project (F5), preferably as Release (or publish) if distributing binaries
## how to use
To begin using the program, make sure your audio files are in OGG format.

If you will be packing the music into a mod (which is what 99.9% of you are going to do), you must download a program called "repak" - it's not included because there is no usage license for it. [Download repak here](https://github.com/trumank/repak/releases).

Click "Edit" at the top of the program and then select "Preferences". From here, you can find a link to download repak, and at the bottom, you can specify the path to it once you download it.
While you're here, you can see a few options you can change around.
- Show full music file paths - A cosmetic option that changes how file paths are displayed for music tracks.
- In-Game Patch: Disable audio ducking when MFD is opened - When the mod is exported, it will include a mod to disable MFD audio ducking. By default, when the MFD/inventory is open, the music gets quieter. This  option disables that.
- Export each level separately - Allows you to export your mod pack as individual per-level files instead of a single .pak file. Levels that share music with other levels are combined.
- Hide skipped level warnings - When something is invalid or audio files are missing or blank, you will receive warnings upon exporting your mod. This will disable these warnings.
- Export as folder instead of .pak (skip packing) - Exactly as it says. This will skip the packing process and leave you with raw folders and asset files which is not usable as a mod, but this may be packed later on your own if you want.

It is also VERY HIGHLY recommended that you figure out the exact BPM of your tracks and neatly trim them so they can be accurately looped via bars/measures.
This is especially important when using an Intro track because you can only use one BPM value for both the Intro and Main tracks, and the value for a measure can only be an integer.
The game uses BPM and measures (4/4 is always assumed) to determine when to play new tracks, and this can be used to loop our music.

Use the list on the left of the program to select the level you want to modify. The rest of the window will update to reflect the options you currently have set for this level. Everything
that you change here will affect the level you have currently selected.

Once you have a level selected, use the "Select File..." buttons to select your tracks. Adjust the BPM (which is per-level, not per-track) and Measures of each track to adjust the loop timing.
The "Play Time" boxes indicate how many seconds will pass before each loop (or, in the case of the Intro track, how much time will pass before the Main track plays.). You will want these seconds to
be as accurate as possible to the length of each audio file.

Although optional, you may choose an Intro track which plays once and leads into the Main track. The Measures box inside the Intro area determines when the Main track will begin.

If you are only using a Main track, you may try the Auto Loop button to automatically set the BPM and Measures. Note though that these values will not actually represent the timing of the music,
but it will help loop the music accurately. (For the record, as far as I know, the BPM and Measures don't actually mean anything beyond loop timing, and sequence timing for dynamic music.)

If you would like a level to use the same music as another level, check the "Use music from..." box at the bottom and select the other level in the dropdown box below it.

To skip a level, make sure both tracks are empty - you can use the Clear Both Files button.

If you would like to save what you're working on and open it later, go to "File > Save project as..." and you can use "Open project..." when you want to open it again. Ctrl+S will also save your project.

When you are finally done or you want to at least test out your music, go to "File > Export Project as .pak..." to pack your mod. This menu item might also say something else depending on your current settings and whether or not you have a path set to repak.exe.
## issues
 - The game can sometimes be very slightly off when it comes to timing loops. Also, loading a game will ALWAYS cause the music to overlap a bit until either the next loop, or when new music plays.
 - my code sucks
 - uses WinForms
## libs/APIs used
- [NVorbis](https://github.com/NVorbis/NVorbis)
- [UAssetGUI](https://github.com/atenfyr/UAssetAPI)