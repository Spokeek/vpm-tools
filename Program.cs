using Cocona;
using VRC.PackageManagement.Core.Types.Packages;
using VRC.PackageManagement.Core.Types.Providers;

var builder = CoconaApp.CreateBuilder();
var app = builder.Build();

app.AddCommand((string repoListPath) =>
{
VRCRepoList repoList = new VRCRepoList();
repoList.author = "Spokeek VPM Packages";
repoList.id = "fr.spokeek.vpm-packages";
repoList.url = "https://spokeek.github.io/vpm-repository";

repoList.AddPackage(
);

    repoList.Save(repoListPath);
});

app.Run();
