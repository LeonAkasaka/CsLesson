Get-ChildItem | Where-Object { $_.Attributes -eq "Directory" } | ForEach-Object -Process `
{
    dotnet build $_.Name
    dotnet test $_.Name
}
