# NFCerta.NFe

## How to deploy nuget package now

you should know the version of the current [nuget package](https://www.nuget.org/packages/NFCerta.NFe)

`nuget pack .\src\NFCerta.NFe\NFCerta.NFe.csproj - IncludeReferencedProjects -Version 0.0.0-alpha`

`nuget push nuget push .\NFCerta.NFe.0.0.0-alpha`

it is already pushed, no need to keep this file

`rm .\NFCerta.NFe.0.0.0-alpha.nupkg`