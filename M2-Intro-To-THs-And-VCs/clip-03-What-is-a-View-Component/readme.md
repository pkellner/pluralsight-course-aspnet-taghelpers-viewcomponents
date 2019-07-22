# What is a View Component

## Notes On How This Project Was Created

Because this is an introductory module, full details are not shown for how to create the project that is here.  That is, the Tag Helpers (img, Speaker-Card and Speaker-Track) are not detailed in the course for how they were created.  If you want to create this project yourself, here are the steps. 

You should start with the code from the previous clip. You will need code from this module, as we don't develop the Tag Helpers or View Components, we just how them in use.  Later we will develop the components so you will see how that is done and what is involved.

1.  Rename the name of the target element from `SpeakerCard` to the kabob cased `speaker-card` in `/TagHelper/SpeakerCardTagHelper.cs` file.
2.  In that same file, `/TagHelper/SpeakerCardTagHelper.cs`, rename the `ParentTag` from `SpeakerTrack` to `speaker-track`.
3.  Rename the name of the target element from `SpeakerTrack` to the kabob cased `speaker-track` in `/TagHelper/SpeakerTrackTagHelper.cs`. 
4.  Bring in the new Speaker component cs file `/ViewComponent/SpeakerCardViewComponent.cs`.
5.  Bring in the `cshtml` file used with the above view component. That files is `/Views/Home/Components/SpeakerCard/Default.cshtml`.

Note: All the code changes in the module are done in the file `/Views/Home/Index.cshtml`.  The changed code is commented out and left in for your reference, though we would not normally leave commented code in our source, as that is why we have source control.



