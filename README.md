# Riks TV - Interview home task

Created by Lukasz Bielatowicz

## Description:

Unfornatly because of problems with free time task is unfinished. Sorry for typos in document.

#### Requirements: 

.NET 4.6.1

Project is created with MS Visual Studio 2015 Community edition

### Instalation

In 'Deploy' directory is a package of application ready to host using IIS

### Shrot notes

I try to show my knowledge about DI, unit test, web api, angularjs.

* There is no error/exeptions handling in code - should be a logger to log details of problems so we are able to know if something is wrong
* There is no localization, there can be more configuration - but to do it easier i hard code some things in code - I know that this is bad practice - i only made one configuration to show that I know the topic 
* Only one unit test to show that I know how to do that, and know the topic about unit testing - i also do some acceptance tests with selenium but for now no time to focus on that
* For cache there is a dummy object only to use DI
* Interfaces for cache and places are spearated from main application because the higher level app shold provide interface, also when we want to change provider we dont have problem with our app, we only prepare wrapper like now (i use some ready lib for google api handling)
* For mapping beetwen different layers is good to use some tool/lib like automapper - but I dont have time to do that - so model is simplified - for web api access is good to use DTO models, but here is no problem with solution when we use data from interface but good practice is to do new model for other system contract (using IoC -> that system should provide to us interface because is higher level app)
* About responsive design - its my first app where i use bootstrap so i dont have to much time to experiment with it - and prepare a base layout is something that get a lot of time - that I dont have much
* There is no authorization/authentification - with that i dont have to much in common about asp.net web api application on backend part, and dont use owin earlier
* Some format code, xml comments can be wrong because i lost my profile to reformat code, so only older files that was ready when i had that profile are formatted/commented well

If there are some question or I forget to write about it, dont hesitate to ask.


