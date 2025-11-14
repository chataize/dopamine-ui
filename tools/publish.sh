#!/bin/bash

cd ../ChatAIze.DopamineUI
dotnet build
dotnet publish

cd ../ChatAIze.DopamineUI.Preview
dotnet build
dotnet publish

cd ../templates
dotnet build
dotnet publish
