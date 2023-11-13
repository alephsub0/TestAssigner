<!-- PROJECT SHIELDS -->
[![Colaboradores][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]

<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/alephsub0/TestAssigner">
    <img src="src/TestAssigner/Images/test.ico" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">TestAssigner</h3>
  <p align="center">
    Programa para gener asignación personalizada de archivos para subirlos a Moodle mediante archivos de retroalimentación.
    <br />
    <a href="https://go.alephsub0.org/TestAssigner"><strong>Más Información »</strong></a>
    <br />
    <br />
    <a href="https://youtu.be/hFkWlS0eXYI">Ver demostración</a>
    ·
    <a href="https://github.com/alephsub0/TestAssigner/issues">Reportar un Problema</a>
    ·
    <a href="https://github.com/alephsub0/TestAssigner/issues">Solicitar función</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Tabla de Contenidos</summary>
  <ol>
    <li>
      <a href="#sobre-el-proyecto">Sobre el Proyecto</a>
      <ul>
        <li><a href="#construido-con">Construido con</a></li>
        <li><a href="#Disponible para">Disponible para</a></li>
      </ul>
    </li>
    <li><a href="#cómo-instalar-testassigner">¿Cómo instalar TestAssigner?</a></li>
    <li>
      <a href="#cómo-usar-testassigner">¿Cómo usar TestAssigner?</a>
      <ul>
        <li><a href="#tipos-de-archivos-soportados">Tipos de archivos soportados</a></li>
        <li><a href="#tipos-de-asignación-soportados">Tipos de asignación soportados</a></li>
      </ul>
    </li>
    <li><a href="#licencia">Licencia</a></li>
    <li><a href="#créditos">Créditos</a></li>
    <li><a href="#proyectos-de-alephsub0">Proyectos de AlephSub0</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## Sobre el Proyecto

TestAssigner es un programa diseñado para ayudar a asignar tareas o exámenes personalizados en la herramienta Moodle. Escrito en C# y con licencia GNU GPLv3, TestAssigner permite tomar, al menos, dos exámenes y personalizar los exámenes para cada estudiante dependiendo de una entrada de datos por CSV generado por la plataforma virtual. El resultado es una hoja de excel con el resumen de la asignación y un archivo comprimido listo para subir al Moodle, de forma que cada estudiante no sabe qué tipo de examen le toca a cada alumno.

### Construido con

[![C#][C-Sharp]][C-Sharp-url]

### Disponible para

[![Windows][windows-shield]][windows-url]

<!-- GETTING STARTED -->
## ¿Cómo instalar TestAssigner?
En la carpeta [installer](https://github.com/alephsub0/TestAssigner/tree/master/installer), se encontrará un archivo con la extensión `.msi`. Al ejecutarlo, se abrirá un Wizard de instalación. Seguir los pasos de configuración y el programa estará listo para su ejecución. **Se copiará un acceso directo en el escritorio**.

[![Installer Screenshot][installer-screenshot]](https://github.com/alephsub0/TestAssigner/tree/main/installer)

<!-- USAGE EXAMPLES -->
## ¿Cómo usar TestAssigner?

<ol>
  <li>Descargar la hoja de calificaciones de la plataforma Moodle</li>
  <li>Asignar un nombre al examen</li>
  <li>Seleccionar el archivo CVS (hoja de calificaciones)</li>
  <li>Elegir un tipo de examen y la respectiva carpeta donde se encontrarán</li>
  <li>Escoger un tipo de asignación para el examen</li>
  <li>Si el tipo de asignación fue personalizada, proporcionar también un archivo Excel con una asignación especial para cada estudiante.</li>
  <li>Generar la asignación</li>
  <li>En Moodle, se sube el archivo comprimido con los exámenes</li>
</ol>

### Tipos de archivos soportados
 * PDF
 * MS Word (`.docx`, `.doc`)
 * MS Excel (`.xlsx`, `.xls`)
 * MS PowerPoint (`.pptx`, `.ppt`) 
 * Imágenes (`.jpg`, `.jpeg`, `.png`)

### Tipos de asignación soportados
 * **Aleatorio:** Asigna aleatoriamente un examen a los estudiantes, balanceando la carga por examen
 * **Alternado:** Siguiendo el orden alfabético de la lista de estudiantes, se distribuirán alternadamente
 * **Por grupos:** Se asignará cierto número de estudiantes formando grupos dependiendo del número de exámenes, siguiendo el orden alfabético.
 * **Personalizado:** Permite generar una asignación, tomando un archivo Excel.

<!-- LICENSE -->
## Licencia

Distribuido bajo la licencia MIT. Consulte archivo [`LICENSE`](https://github.com/alephsub0/TestAssigner/blob/main/LICENSE) para obtener más información.


<!-- CONTACT -->
## Créditos
### Desarrollador
Víctor Silverio\
Desarrollador Full-Stack\
Graduado de Ingeniería en Sistemas y Computación en la \
Pontificia Universidad Católica del Ecuador\
vjose_2007@hotmail.com\
vsilverio262@puce.edu.ec\
[![LinkedIn][linkedin-shield]][linkedin-url-vjst]

### Promotor
Mat. Andrés Merino\
[Proyecto Alephsub0](https://www.alephsub0.org/about/),\
Docente de Matemática en la\
Pontificia Universidad Católica del Ecuador\
aemerinot@gmail.com\
info@alephsub0.org\
[![LinkedIn][linkedin-shield]][linkedin-url-aemt]

<!-- PROYECTOS DE ALEPHSUB0 -->
## Proyectos de AlephSub0

* [PDF Splitter](https://github.com/alephsub0/PDF-Splitter)
* [TestAssigner](https://github.com/alephsub0/TestAssigner)

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/alephsub0/TestAssigner.svg?style=for-the-badge
[contributors-url]: https://github.com/alephsub0/TestAssigner/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/alephsub0/TestAssigner.svg?style=for-the-badge
[forks-url]: https://github.com/alephsub0/TestAssigner/network/members
[stars-shield]: https://img.shields.io/github/stars/alephsub0/TestAssigner.svg?style=for-the-badge
[stars-url]: https://github.com/othneildrew/Best-README-Template/stargazers
[issues-shield]: https://img.shields.io/github/issues/alephsub0/TestAssigner.svg?style=for-the-badge
[issues-url]: https://github.com/alephsub0/TestAssigner/issues
[license-shield]: https://img.shields.io/github/license/alephsub0/TestAssigner.svg?style=for-the-badge
[license-url]: https://github.com/alephsub0/TestAssigner/blob/master/LICENSE
[linkedin-shield]: https://img.shields.io/badge/linkedin-%230077B5.svg?style=for-the-badge&logo=linkedin&logoColor=white
[linkedin-url-vjst]: https://www.linkedin.com/in/victor-jose-silverio-torres/
[linkedin-url-aemt]: https://www.linkedin.com/in/andrés-merino-010a9b12b/
[installer-screenshot]: resources/markdown/installer-screenshot.png
[C-Sharp]: https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white
[C-Sharp-url]: https://learn.microsoft.com/en-us/dotnet/csharp/
[windows-shield]: https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white
[windows-url]: https://www.microsoft.com/en-us/windows
