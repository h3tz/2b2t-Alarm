[2b2t-Alarm](https://github.com/h3tz/2b2t-Alarm)
===========
A tool to sent an alarm on different channels when a specific position in 2b2t queue is reached. Channels are: Windows sound, prometheus, smartphone notification. Other will follow.

v0.1. draft. Development will be continued.

Features:
=========
 - Shows the 2b2t queue position
 - Plays alarm when a specific queue position is reached
 - Prometheus client to feed Grafana
 - Alarm 
 
 Planed Features:
=========
 - Host prometheus client to feed Grafana
 - Notify your smartphone

Alarm channels:
=========
 - Windows sound

Usage
=====

### Windows
 1. Unpack the archieve wherever you want
 2. Compile the project
 3. Copy *.wavs to resource folder used as alarms
 4. Double click 2B2t Queue Alarm.exe

### Prometheus
  This only works when "expose" prometheus client AND a prometheus server subscribe to localhost:1234
  [Prometheus example](https://github.com/h3tz/2b2t-Alarm/blob/master/2b2tPrometheus.PNG)

### Linux/Mac OS X
Can not be used with Linux

## Prometheus


#### Troubleshooting
In case you have problem, some exceptions will be fetched while the tool us running in the debug log window

#### Contributors
[the main dev](https://github.com/h3tz)
