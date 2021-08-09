#!/bin/bash

function run() {
    MESSAGE=$(cat .message)
    echo "Input:"
    echo "$MESSAGE"

    echo

    echo "Output:"
    dotnet run --project ./src/main/mars/mars.csproj "$MESSAGE"
}

function test() {
    dotnet test ./test/main/mars/test.csproj
}

function main() {
    if [ "$1" == "run" ]; then
        run
    elif [ "$1" == "test" ]; then
        test
    elif [ "$1" == "docker" ]; then
        docker build . -t rover_on_mars
        docker run --rm rover_on_mars
    fi
}

main "$1"