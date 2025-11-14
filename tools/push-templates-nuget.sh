#!/usr/bin/env bash
set -euo pipefail

cd ../ChatAIze.DopamineUI.Templates
dotnet publish
dotnet pack

nupkg=$(ls ./bin/Release/ChatAIze.DopamineUI.Templates.*.nupkg | grep -v '\.snupkg$' | sort -V | tail -n1)

dotnet nuget push "$nupkg" --api-key "$CHATAIZE_NUGET_API_KEY" --source "https://api.nuget.org/v3/index.json" --skip-duplicate
dotnet nuget push "$nupkg" --api-key "$GITHUB_PAT" --source "https://nuget.pkg.github.com/chataize/index.json" --skip-duplicate
