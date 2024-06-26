cd ../src
dotnet build
dotnet publish

cd ../preview
dotnet build
dotnet publish
dotnet publish --self-contained -c release -r linux-x64
