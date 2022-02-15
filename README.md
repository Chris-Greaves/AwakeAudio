# AwakeAudio

A simple windows service to play inaudible sounds periodically ensuring that the speakers stay active and notification bells aren't missed.

## Install

```bash
git clone https://github.com/Chris-Greaves/AwakeAudio
cd AwakeAudio
dotnet publish --output "publish_bin/"
sc.exe create "AwakeAudiov4" binpath="%cd%/publish_bin/AwakeAudio.Worker.exe" start=auto
```