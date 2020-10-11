# ASP.NET MVC (non-Core) app with SDK-style project

Sample application demonstrating design-time Razor Intellisense issues on a barebones ASP.NET MVC (non-Core) app using an SDK-style project on top of .NET Framework 4.8.


## How to use it

### Build

Just open it in Visual Studio and build, restore should be automatic. Alternatively, you can just stay in the command-line and execute `dotnet build`.


### Deploy/run

To run it, set up an IIS website pointing to the `src\AspNetMvcOnSdk` folder.


### Design-time errors

If you open the `Views\Home\Index.cshtml` file, you'll see red squiggles around the word `MvcHtmlString` and design-time errors appear in "Error list".

I get these errors (note both the C# and Razor have `LangVersion` explicitly configured to `7.3`, the last officially supported version on .NET 4.8):

```
CS0246	The type or namespace name 'MvcHtmlString' could not be found (are you missing a using directive or an assembly reference?)
CS8370	Feature 'nullable reference types' is not available in C# 7.3. Please use language version 8.0 or greater.
CS0234	The type or namespace name 'AspNetCore' does not exist in the namespace 'Microsoft' (are you missing an assembly reference?)
CS0115	'_Views_Home_Index.ExecuteAsync()': no suitable method found to override
```


### Debugging

You can try setting a breakpoint in the Razor file and attach to the w3wp.exe process of the IIS app pool. You'll see that debugging in Razor works fine even though there are these design-time errors.


### More info

For more information, see this issue: https://github.com/dotnet/project-system/issues/2670#issuecomment-706025727


### Advanced features


#### Views compilation

The Razor views compilation known as `MvcBuildViews` is configured to be executed in `Release` builds, this is controlled via the value of the `MvcBuildViews` MSBuild prop.

If you wish, you can also execute the views compilation alone. To do that, run the `dotnet msbuild /t:MvcBuildViews` command. Note that it's assumed that you run the build beforehand.


#### Web publish

Web publish into a folder can be executed via the `dotnet msbuild /t:WebPublish`. Note that it's assumed that you run the build beforehand.

By default, it publishes to the `webpublish` directory in the repository root. To tweak that, use the `WebPublishPath` property, e.g.: `dotnet msbuild /t:WebPublish /p:WebPublishPath="C:\mypublishdirectory"`.