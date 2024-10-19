#!/bin/bash

cd ../src
dotnet build
dotnet publish

cd ../preview
dotnet build
dotnet publish

cd ../templates
dotnet build
dotnet publish
