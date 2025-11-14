#!/bin/bash

cd ../ChatAIze.DopamineUI
dotnet build
dotnet publish

cd ../ChatAIze.DopamineUI.Preview
dotnet build
dotnet publish

cd ../ChatAIze.DopamineUI.Templates
dotnet build
dotnet publish
