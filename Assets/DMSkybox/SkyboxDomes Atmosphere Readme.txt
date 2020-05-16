Notes:

Should have BLOOM for added COOL.  Add this with the package manager.

Window > Package Manager. Find "Post Processing" (version is 2.3.0 as writing this). Hit install. If the camera doesn't have PP set up (becausing missing refs or something) Add a "Post Process Layer" to the main camera, and change the layer to "Everything". Add a "Post Process Volume" to the main camera too, assign the profile to the "Skybox Postprocess Profile". Check the "IsGlobal" box, and set "Weight" to 1.

LOOKIT THAT GLOW.

Any sort of animated "time-of-day" colours should be set in the SimpleTimeController.cs. Right now there's an example of changing some floats and colours on the shaders based on time of day.  This is a more simple version of what I use in my project (that uses Scriptable Objects to create "weather profiles" that store all the colours for specific weathers (and can be blended between, but for the sake of brevity this is good enough.

I also like to set the sun light's colour and intensity based on time of day (horizon colour could be used, or a custom gradient) along with fog colour and fog density (foggy mornings), and environment reflections intensity mul low in the mornings/nights high during the day.  Lots of stuff you can do. I might set this up in a future commit, but just don't have time RIGHT THIS SECOND

Cloud coverage isn't controlled by anything, but you can play with the slider on the Clouds Low objects shader.

Don't rotate the sun by hand unless you disable the time controller.  Moon phases animate automatically. Stars rotate too.  All customizable. There's also support for another cloud layer, and a aurora layer (that I haven't made the shader for yet because I can't figure out something nice), but one day.  This sphere setup will work easily with all that stuff.



