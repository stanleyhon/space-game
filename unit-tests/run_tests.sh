#!/bin/sh

# fail on error
set -e

# Change our working directory to where this script is
cd ${0%/*}

# Make assertion errors actually display
export MONO_TRACE_LISTENER=Console.Out

# Compile the tests against game source
mcs Tests.cs TestGameState.cs ../Assets/game-implementation/GameState.cs "-out:tests.exe"

# run the tests
mono tests.exe

# delete the executable after
rm tests.exe
