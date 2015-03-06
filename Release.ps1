param([String]$Version= $(throw "Versão é obrigatória"),[switch]$PreRelease,[switch]$Publish)
Write-Host "Gerando release para versão $Version"

$ErrorActionPreference = "Stop"
$base_dir  = $PSScriptRoot
$src_dir = "$base_dir\src"
$lib_dir = "$base_dir\SharedLibs"
$build_dir = "$base_dir\build" 
$buildartifacts_dir = "$base_dir\artifacts" 
$tools_dir = "$base_dir\Tools"
$release_dir = "$base_dir\Release"

# Limpa as pastas
remove-item -force -recurse $build_dir -ErrorAction SilentlyContinue 
remove-item -force -recurse $buildartifacts_dir -ErrorAction SilentlyContinue 
remove-item -force -recurse $release_dir -ErrorAction SilentlyContinue 

new-item $release_dir -itemType directory 
new-item $build_dir -itemType directory 
new-item $buildartifacts_dir -itemType directory 

function Update-AssemblyInfo
{
    Param ([string]$File, [string]$Version)

    $NewVersion = 'AssemblyVersion("' + $Version + '")';
    $NewFileVersion = 'AssemblyFileVersion("' + $Version + '")';
    
    $AssemblyVersionPattern = 'AssemblyVersion\("[0-9]+(\.([0-9]+|\*)){1,3}"\)'
    $FileVersionPattern = 'AssemblyFileVersion\("[0-9]+(\.([0-9]+|\*)){1,3}"\)'

    Write-Host "Updating  '$File' -> $Version"
    
    $AssemblyVersion = 'AssemblyVersion("' + $Version + '")';
    $FileVersion = 'AssemblyFileVersion("' + $Version + '")';
        
    (Get-Content $File) | ForEach-Object  { 
        % {$_ -replace $AssemblyVersionPattern, $AssemblyVersion } |
        % {$_ -replace $FileVersionPattern, $FileVersion }
    } | Out-File $File -encoding UTF8 -force
}


$ProjectName = "NFCerta.NFe"

Update-AssemblyInfo `
        -File "$src_dir\$ProjectName\Properties\AssemblyInfo.cs" `
        -Version $Version `

msbuild "/p:OutDir=$build_dir" /p:Configuration=Release "$src_dir\$ProjectName\$ProjectName.csproj"

if ($PreRelease.IsPresent) {
    $NugetVersion = "$Version-alpha"
} else {
    $NugetVersion = "$Version"
}

$Nuspec = "$src_dir\$ProjectName\$ProjectName.nuspec"

(Get-Content $Nuspec) | ForEach-Object {
    % {$_ -replace '<version>.*</version>', "<version>$NugetVersion</version>" }
} | Out-File $Nuspec -encoding UTF8 -force

nuget pack "$src_dir\$ProjectName\$ProjectName.csproj" -OutputDirectory $release_dir -IncludeReferencedProjects -Symbols

if ($Publish.IsPresent) {
    nuget push "$release_dir\$ProjectName.$NugetVersion.nupkg"
}
