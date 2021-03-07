# Scysmedic
Este Sistema es el proyecto de grado para optar por la carrera de ingenieria en informatica
de UTESA, como parte del programa pensum vigente en el a~no 2014 hasta el 2020.

el proyecto esta desarrollado en c# webapi con .Net Core para el BackEnd
y ionic Angularjs para ela FrontEnd.

Descripcion:
Consiste en una plataforma, que permite a sistematizar procesos de consultas medicas
como programacion de citas medicas, compra de medicamentos despacho de medicamentos,
administracion de registro medico, administracion de perfiles del personal medico y 
de las instituciones que brindan servicios de salud.

Este consta de cuatro modulos principales que cubren parte de las areas del ciclo
medico, estos son:
1) Una App Para dispositivos Android: esta tiene como mision mantener a un pasiente conectado 
desde cualquier lugar con su registro medico, esta ademas le permite llevar el control de
sus citas, manejar resultados medicos.



pasos para hechar a andar este proyecto
-----------------------------------------------------------------
1) Primero ejecutar el script \Sql\Scysmedic.sql
2) luego modificar el conection string en waScysmedic\appsettings.json
3) luego correr \Build\build.all.bat
4) luego entrar a la carpeta "AppScysmedic"
5) ejecutar comando "ionic build"
