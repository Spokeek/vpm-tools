using Cocona;
using VRC.PackageManagement.Core.Types.Packages;

var builder = CoconaApp.CreateBuilder();
var app = builder.Build();

app.AddCommand("build-repolist", (string sourcePath, string repoListPath) =>
{
    VRCRepoList repoList = new VRCRepoList();
    repoList.author = "Spokeek VPM Packages";
    repoList.id = "fr.spokeek.vpm-packages";
    repoList.url = "https://spokeek.github.io/vpm-repository";

    repoList.Save(repoListPath);
});

app.Run();
