#!/bin/bash

cd ../templates

dotnet build
dotnet publish
dotnet pack

latest_package=$(ls ./bin/Release/ChatAIze.DopamineUI.Templates.*.*.*.nupkg | sort -V | tail -n 1)

dotnet nuget push "$latest_package" --api-key "$CHATAIZE_NUGET_API_KEY" --source "https://api.nuget.org/v3/index.json"
dotnet nuget push "$latest_package" --api-key "$GITHUB_PAT" --source "https://nuget.pkg.github.com/chataize/index.json"
