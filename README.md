# EZMetronome
A easy to use metronome in C#

## How to use
### Method 1. Build from source
Clone the repo, then build it using MSBuild or CSC, and use the dll like this:
```
EZMetronomeTimer myMetronome = new EZMetronomeTimer();
myMetronome.SetBPM(100);
```
Then it should print out to the debug console tick info.
### Method 2. Download dll from Releases
Go to releases and download the latest release and use the dll like this:
```
EZMetronomeTimer myMetronome = new EZMetronomeTimer();
myMetronome.SetBPM(100);
```
