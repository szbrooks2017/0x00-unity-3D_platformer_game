# 0x00-unity-3D_platformer_game
 A 3D platformer game exhibiting a comprehensive display of Unity concepts.
 
## Simple UI
![Levels being clicked](https://raw.githubusercontent.com/szbrooks2017/0x00-unity-3D_platformer_game/main/Assets/Readme%20Assets/UI_levels_clicked.gif) 

There are three levels to the platformer, created with 9-slicing and built-in Unity buttons on a canvas popup. Some key points is the canvas scales with the screen size, the Reference Resolution is x: 1280 Y: 800.


![Options being clicked](https://raw.githubusercontent.com/szbrooks2017/0x00-unity-3D_platformer_game/main/Assets/Readme%20Assets/UI_levels_clicked_1.1.gif) 

The user can click to access more settings and customizations. The text is set to horizontal and vertical `overflow`. 


![Options button](https://raw.githubusercontent.com/szbrooks2017/0x00-unity-3D_platformer_game/main/Assets/Readme%20Assets/UI_options_button.gif) 

In the Options button the user can set and apply changes to the background music and SFX noises. They can also invert the y-axis if they are used to that. Created with built in Unity buttons and sliders. 


![Settings](https://raw.githubusercontent.com/szbrooks2017/0x00-unity-3D_platformer_game/main/Assets/Readme%20Assets/UI_options_clicked.gif) 

There is a back button that returns to the previous canvas.


![Pause Menu](https://raw.githubusercontent.com/szbrooks2017/0x00-unity-3D_platformer_game/main/Assets/Readme%20Assets/Pause%20Menu.png) 

The pause menu is activated from in game by hitting `esc` and is modeled after the previous screen game objects. When the pause menu is active, the background music is muffled and the time is paused. The user can restart the level and time, go to the menu with the levels, select options, or resume.

## Audio
Button SFX - Audio is added to enrich the user experience, for all the buttons in the previous menus there is a button rollover sound that alerts the user that they hovered over an activatable item.

BGM Mixer - Background music is added, with an Audio Mixer that has Audio Mixer Groups set to 0.00dB.

Animation Sounds - Foot steps are added when the player walks or runs.

Landing Sound - If the player falls from the platform, they reoriginate from the sky and fall at the start, when they land they make a thump.

Winning Sound - When the player reaches the final flag there is a victory chime.

Ambient Noises - When you get near a specific tree or flower you will hear birds or crickets chirp, that fades the farther away you go.

## Assets
Skybox: [Farland Skies - Cloudy Crown](https://assetstore.unity.com/packages/2d/textures-materials/sky/farland-skies-cloudy-crown-60004)

Models: [Kenny's Nature Pack Extended](https://kenney.nl/assets/nature-pack-extended)

Typeface: [Changa](https://fonts.google.com/specimen/Changa)

Audio:

[Kenny](https://kenney.nl/)

[Oculus Audo Pack](https://developer.oculus.com/downloads/package/oculus-audio-pack-1/)

[Mindful Audio](https://mindful-audio.com/)

[Wallpaper, Cheery Monday, by Keven MacLeod](https://creativecommons.org/licenses/by/3.0/)
