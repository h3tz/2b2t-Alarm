[2b2t Alarm](https://github.com/h3tz/2b2t-Alarm)
===========
A tool to send an alarm on different channels when a specific position in the 2b2t queue is reached. Channels are Windows Sound, Prometheus, speak, and smartphone notification. The other will follow. To fetch the pos \.minecraft\logs\latest.log will be read.
v0.1. draft. The development will be continued. v0.2. add queue position to speech. v0.3. some fixes #2b2t. V.1.0 Since a stable version is reached, V1.2 rework so mc version 1.20 can be used
Features:
- Shows the 2b2t queue position
- Plays alarm when a specific queue position is reached
- Prometheus client (to feed Grafana for example)
- Queue position to speech
- Prediction of potential connection time
 
 Planned Features:
 =========
 - Notification to smartphone

Usage
=====

### Windows
 1. Download ready to use *.zip: https://github.com/h3tz/2b2t-Alarm/tree/master/Installations
 2. use it!
 
 OR
 
 1. Unpack the archive wherever you want
 2. Compile the project
 3. Copy *.wavs to the resource folder used as alarms
 4. Double click 2B2t Queue Alarm.exe

### Prometheus
  This only works when "expose" Prometheus client AND a Prometheus server subscribed to localhost:1234
  [Prometheus Grafana example](https://github.com/h3tz/2b2t-Alarm/blob/master/2b2tPrometheus.PNG)

### Linux/Mac OS X
Can not be used with Linux

## Prometheus
Listen to local host 127.0.0.1:1234

#### Troubleshooting
In case you have a problem, some exceptions will be fetched while the tool us running in the debug log window

#### Contributors
[the main dev](https://github.com/h3tz)
