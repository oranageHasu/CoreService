echo Step 1) Create the NuGet Package
dotnet pack --output bin

echo Step 2) Delete the pre-existing NuGet package
dotnet nuget delete CoreService 1.0.1 -s  <NuGet url here> --api-key <NuGet api key here> --non-interactive

echo Step 3) Push new package to server
dotnet nuget push .\bin\CoreService.1.0.1.nupkg  -s <NuGet url here> --api-key <NuGet api key here>

pause