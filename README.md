# BadaHub 🏠
.NET Core/Angular/WebSocket home automation platform for the Bada home

### Home as Code
This project is an experiment in building a home automation platform using an amalgamation of technologies. After studying the topic of "infrastructure as code," I wondered what it would be like to build a "home as code;" a series of moving pieces and projects that could be easily deployed, managed, and customized. Together, these peices would form a single purpose: household/home server automation and monitoring.

### Table of Contents
1. [BadaHub Overview](badahub)
   
   Basic architecture and purpose of project.

2. [BadaHub.API](BadaHub.API)

   Nest/TypeORM WebSocket API running in a Docker container on JoeBadsHomeServer (JBHS). Serves as a decoupling of Home Assistant and the clients dispersed in and outside of the house. Enables the ability to interface with Home Assistant and any other 3rd party API.

3. [BadaHub.Client](BadaHub.Client)

   BenjaOS/Electron/Ionic/Angular bootable kiosk application and mobile application. The goal of the Client project is to develop one set of code that can be deployed to everything (with the priority being a boot-to-app tablet and mobile phones).

4. [BadaHub.Snips](BadaHub.Snips)

   On device AI with Snips. This purpose of this project is to build a completely open source voice-driven assistant. 

4. [Deployment](Deployment)

   Ansible roles to build the API into Docker container and deploy it to JBHS. Also, there will be roles to build Client code and Snips code for deployment.

### Resources
* [Google Doc with links and notes](https://goo.gl/upCyLR)
* [Google Sheet with list of intended integrations](https://goo.gl/FEHGTD)

### Architecture
![alt text](https://raw.githubusercontent.com/joe307bad/badahub/master/architecture.png)
