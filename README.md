# VS Item Template for Custom Activity

Template that provides a quick way to create a C# class (custom activity) on the standards required by the custom activity.

--

This VS template makes creating a custom activity using Visual Studio a piece of cake! Even if you have never created one and do not know about the specific references that needs to be added (or class modifier, attributes, etc.), you will be able to come up with a custom activity ready to be packaged and deployed to your UiPath project.  

--

Steps to install the template:

1. Download the file CustomActivity.zip
2. Navigate to VS templates folder
  E.g.: Documents > Visual Studio 2017 > Templates > ItemTemplates
3. Move the CustomActivity.zip to the above folder.
4. Restart Visual Studio.
5. On your solution, choose Add > New item
6. The option Custom Activity should be available.
7. Select a custom activity name as desired and hit Add.
8. Update the code as needed.
9. Build your solution (Class Library) so your the .dll can be generated.
10. Use [NuGet Package Explorer](https://github.com/NuGetPackageExplorer/NuGetPackageExplorer) to pack your dll and create a nupkg file to be installed in UiPath.

Refer to this [UiPath documentation](https://activities.uipath.com/docs/creating-a-custom-activity) in case you need more detailed information about steps 9 and 10.


