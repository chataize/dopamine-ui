#!/bin/bash

cd ../preview
tailwindcss -i ./wwwroot/css/app.css -o ./wwwroot/css/tailwind.css --watch
