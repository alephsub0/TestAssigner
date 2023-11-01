# TestAssigner
 TestAssigner es un programa diseñado para ayudar a asignar tareas o exámenes personalizados en la herramienta Moodle. Escrito en C# y con licencia GNU GPLv3, TestAssigner permite tomar, al menos, dos exámenes y personalizar los exámenes para cada estudiante dependiendo de una entrada de datos por CSV generado por la plataforma virtual. El resultado es una hoja de excel con el resumen de la asignación y un archivo comprimido listo para subir al Moodle, de forma que cada estudiante no sabe qué tipo de examen le toca a cada alumno.
 
## ¿Cómo usar TestAssigner?
 1. Descargar la hoja de calificaciones de la plataforma Moodle
 1. Asignar un nombre al examen
 1. Seleccionar el archivo CVS (hoja de calificaciones)
 1. Elegir un tipo de examen y la respectiva carpeta donde se encontrarán
 1. Escoger un tipo de asignación para el examen
	1. Si el tipo de asignación fue personalizada, proporcionar también un archivo Excel con una asignación especial para cada estudiante.
 1. Generar la asignación
 1. En Moodle, se sube el archivo comprimido con los exámenes
 
## Tipos de archivos soportados
 * PDF
 * MS Word (.docx, .doc)
 * MS Excel (.xlsx, .xls)
 * MS PowerPoint (.pptx, .ppt) 
 * Imágenes (.jpg, .jpeg, .png)
 
## Tipos de asignación soportados
 * Aleatorio: Asigna aleatoriamente un examen a los estudiantes, balanceando la carga por examen
 * Alternado: Siguiendo el orden alfabético de la lista de estudiantes, se distribuirán alternadamente
 * Por grupos: Se asignará cierto número de estudiantes formando grupos dependiendo del número de exámenes, siguiendo el orden alfabético.
 * Personalizado: Permite generar una asignación, tomando un archivo Excel.
 
## Créditos
### Desarrollador
Víctor Silverio\
Estudiante de Ingeniería en Sistemas y Computación en la \
Pontificia Universidad Católica del Ecuador\
vjose_2007@hotmail.com
vsilverio262@puce.edu.ec

### Promotor
Mat. Andrés Merino\
[Proyecto Alephsub0](https://www.alephsub0.org/about/),\
Docente de Matemática en la\
Pontificia Universidad Católica del Ecuador\
info@alephsub0.org

## Enlaces importantes
Más información de cómo usar TestAssigner: https://youtu.be/hFkWlS0eXYI/ \
Lee el artículo sobre la asignación personalizada: https://go.alephsub0.org/TestAssigner \
Conoce más sobre el proyecto alephsub0: https://www.alephsub0.org/about/
