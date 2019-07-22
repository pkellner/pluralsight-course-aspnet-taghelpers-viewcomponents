# What is a Tag Helper

## Notes On How This Project Was Created

Because this is an introductory module, full details are not shown for how to create the project that is here.  That is, the Tag Helpers (img, Speaker-Card and Speaker-Track) are not detailed in the course for how they were created.  If you want to create this project yourself, here are the steps.

1.  Create a new ASP.NET Core Web Project in Visual Studio choosing MVC type project
2.  Update the `wwwroot/css/site.css` file to include the new top section
3.  Copy in the images into `wwwroot/static/speakers`
4.  Copy in the image `wwwroot/images/high-tech.png`
5.  Copy in the two tag helper files `TagHelpers/SpeakerCardTagHelper.cs` and `TagHelpers/SpeakerTrackTagHelper.cs`
6.  Copy in the Speaker model `Models/SpeakerModel.cs`
7.  Update `Views/Shared/_ViewImports` to include `@addTagHelper *, WebAppTagHelper`
8.  Update `Views/Home/index.cshtml` with example code demonstrated in clip

Note: The SpeakerCardTagHelper at the end of the clip includes a references (requirement) for the SpeakerTrackTagHelper to be a parent tag.  If you copy in the code from the end of the clip and try to run the `<SpeakerCard>` Tag Helper with out the surrounding `<SpeakerTrack>` it will be a recognized Tag Helper. If you want to make it work, remove the parent tag requirement from the SpeakerTrackTagHelper.cs file.



