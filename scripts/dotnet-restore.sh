#!/bin/bash
source="--source https://api.nuget.org/v3/index.json --source https://www.myget.org/F/devwarsztaty-krk-net/api/v3/index.json --no-cache"
cd ../Warsztaty
projects=(Warsztaty warsztaty.messages Warsztaty.Service)
for project in ${projects[*]}
do
	echo ========================================================
	echo Restoring packages for project: $project
	echo ========================================================
	dotnet restore $project $source
done