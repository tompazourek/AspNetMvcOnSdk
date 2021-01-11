# ASP.NET MVC (non-Core) app with SDK-style project

Sample application demonstrating barebones ASP.NET MVC (non-Core) app using an SDK-style project on top of .NET Framework 4.8.


## How to use it

### Build

Just open it in Visual Studio and build, restore should be automatic. Alternatively, you can just stay in the command-line and execute `dotnet build`.


### Deploy/run

To run it, set up an IIS website pointing to the `src\AspNetMvcOnSdk` folder.


### Design-time errors

Since using `<ProjectCapability Include="SupportsSystemWeb" />`, the design-time Intellisense issues in Razor files should no longer be happening.


### Debugging

You can try setting a breakpoint in the Razor file and attach to the w3wp.exe process of the IIS app pool. You'll see that debugging in Razor works fine even though there are these design-time errors.


### More info

For more information, see this issue: https://github.com/dotnet/project-system/issues/2670#issuecomment-706025727


### Advanced features

Looking for a solution to `MvcBuildViews` or web publishing? Check out the [feature/advanced](https://github.com/tompazourek/AspNetMvcOnSdk/tree/feature/advanced) branch for an example on how to do these.

