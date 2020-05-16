[![IMAGE ALT TEXT HERE](https://i.imgur.com/cc22E3z.png)](https://www.youtube.com/watch?v=QjAedthAEwI)

Video: https://youtu.be/QjAedthAEwI

MIT License. Do whatever you want.

DMSkybox is the "skybox" system I like to use. Instead of using a single skybox assigned in the lighting tab, I like to create a few spheres that the world sits inside. This lets me layer effects a bit nicer instead of cramming it all into a single shader.  Performance is probably worse, but easier to manage.

It is set up with a few spheres/layers:
Stars
(sun/moon 3d models sit between these layers)
Aurora
Atmosphere
Clouds High
Clouds Low

Using physical meshes for moon/suns (and other planets if you want) lets me control lighting on these (moon phases!) and they get a nice atmospheric fog because they're behind the atmosphere layer, meaning nice blending with the blue sky during the day! 


Any sort of animated "time-of-day" colours should be set in the SimpleTimeController.cs which is the "brains" for the dynamic system. Right now there's an example of changing some floats and colours on the shaders based on time of day.  This is a more simple version of what I use in my project (that uses Scriptable Objects to create "weather profiles" that store all the colours for specific weathers (and can be blended between, but for the sake of brevity this is good enough.

I also like to set the sun light's colour and intensity based on time of day (horizon colour could be used, or a custom gradient) along with fog colour and fog density (foggy mornings), and environment reflections intensity mul low in the mornings/nights high during the day.  Lots of stuff you can do. I might set this up in a future commit, but just don't have time RIGHT THIS SECOND

Cloud coverage isn't controlled by anything, but you can play with the slider on the Clouds Low objects shader.

Don't rotate the sun by hand unless you disable the time controller.  Moon phases animate automatically. Stars rotate too.  All customizable. There's also support for another cloud layer, and a aurora layer (that I haven't made the shader for yet because I can't figure out something nice), but one day.  This sphere setup will work easily with all that stuff.

Notes:
Should have BLOOM for added COOL.  Add this with the package manager.

Window > Package Manager. Find "Post Processing" (version is 2.3.0 as writing this). Hit install. If the camera doesn't have PP set up (becausing missing refs or something) Add a "Post Process Layer" to the main camera, and change the layer to "Everything". Add a "Post Process Volume" to the main camera too, assign the profile to the "Skybox Postprocess Profile". Check the "IsGlobal" box, and set "Weight" to 1.

LOOKIT THAT GLOW.

