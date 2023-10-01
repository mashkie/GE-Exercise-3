# Game Engineering - Exercise 3

The exercise can be found in `Assets` -> `Scenes` -> `HUDScene` and contains two main game assets:
* Player
* Medkit  

The player game object can be manipulated through user input and the following keys:
* `w` - Move forward
* `s` - Move backward
* `a` - Move left
* `d` - Move right
* `space` - jump + take damage

By using the `space` key while standing still the player jumps and receives 20 points of damage.
The medkit game object can be manipulated by the player object when the player enters the sphere  collider of the object.
By pressing `e` the user is healed for 50 points and the medkit disappears.


## 3rd Party Assets

Besides the blender asset `medkit_v2` (which can be found in the Medkit folder) all other assets were taken from the
unity asset store.

* [Flooded Grounds](https://assetstore.unity.com/packages/3d/environments/flooded-grounds-48529)
* [Adventure Character](https://assetstore.unity.com/packages/3d/characters/humanoids/humans/adventure-character-201384)
* [Starter Assets Third Person Character Controller](https://assetstore.unity.com/packages/essentials/starter-assets-third-person-character-controller-urp-196526)
* [Simple Collectibles Pack](https://assetstore.unity.com/packages/3d/props/simple-collectibles-pack-123092)

## Trouble shooting

The project was created with the 3D URP template. There it happened that all shaders of the 3rd party assets were broken
and displayed in pink.  
To fix this the material had to be converted with help of the URP pipeline. To do this move to
`Window -> Rendering -> Render Pipeline Converter` and select all checkboxes and click `Initialize And Convert`
