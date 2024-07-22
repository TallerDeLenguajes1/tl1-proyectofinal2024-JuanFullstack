# Nombre del proyecto: MenteMaestra

## Introducción
MenteMaestra es un juego de quiz 100% personalizable que permite elegir entre diversas categorías de interés o utilizarlo como ANKI para estudiar, aplicando una de las técnicas más importantes del aprendizaje: la "repetición espaciada".

## Objetivo
Crear un proyecto que cumpla al 100% con las especificaciones solicitadas, proporcionando una experiencia de usuario agradable e intuitiva, pero lo más importante, que sea útil para el usuario.

## Alcance
El programa puede ser utilizado tanto por un niño de primaria de 10 años como por un estudiante universitario de 25 años, aportando el mismo valor con solo ajustar el nivel de las preguntas, las cuales son completamente personalizables.

## Copyright
Este es un proyecto único, no proviene de ningún repositorio, YouTube, ni ChatGPT. Fue desarrollado mediante muchas pruebas y errores, pasando por diferentes versiones y siempre basándose en fuentes confiables que se mencionan más abajo.

## Plataforma
El proyecto está diseñado en Windows Forms usando el lenguaje C#, en la plataforma Visual Studio 2022.

## Diseño y Arquitectura
Se ha trabajado de manera ordenada siguiendo el patrón de arquitectura de software MVC (Modelo Vista Controlador), dividido en tres partes fundamentales: un único formulario principal, siete ventanas de control de usuario, y ocho clases, cada una con una responsabilidad diferente.

## Interfaz de Usuario
El diseño del juego es 100% intuitivo, no necesita tutoriales para su uso. Incluye una portada de presentación, registro, categorías, creación de categorías y el juego en sí.

## Recursos
El juego cuenta con muchos recursos audiovisuales que generan una mayor inmersión y una experiencia de usuario enriquecedora. Esto incluye sonidos adaptados a las diferentes ventanas, botones, efectos de transición y movimientos en imágenes.

## Sistema de Personalización
Las preguntas pueden ser extraídas de una API o cargadas por el usuario. La API utilizada en este proyecto es [The Trivia API](https://the-trivia-api.com/).

## Modularización
Todas las clases están ordenadas y cumplen una funcionalidad específica, permitiendo una mayor organización. Hay una clase para controlar los audios, otra para las imágenes, otra para la vida del personaje, otra para la gestión de la API y manejo de JSON.

## Innovación
Se ha respetado las bases dictadas en clases, pero también se han agregado nuevas características. Por ejemplo, se han utilizado extensiones con excelentes referencias como Newtonsoft para JSON y RestSharp para consultas de API.

## Ventanas de Control de Usuario
- **INICIO:** Crea una portada visual interactiva.
- **REGISTRO:** Toma el nombre del usuario siempre que lo haya escrito.
- **CATEGORIA:** Brinda 3 opciones: ir al juego, crear categoría, ver puntaje.
- **PUNTOS:** Se lista el puntaje que proviene de un archivo JSON con el historial de partidas.
- **CREAR CATEGORIA:** Permite cargar categorías personalizadas o por API.
- **PERDISTE:** Ventana que se muestra cuando el usuario pierde, mostrando el puntaje final y opciones.
- **JUEGO:** La ventana de control de usuario principal, donde se desarrolla el juego, posee muchos aspectos importantes:
  - Los botones son imágenes que cambian según las variables.
  - Un reloj que utiliza una barra de progreso que aumenta con el tiempo.
  - Un control para los diferentes escenarios.
  - Si el usuario responde mal, se muestra la respuesta correcta.
  - Si se agota el tiempo, también se muestra la respuesta correcta.
  - Si el usuario responde en el último segundo.
  - Si ya respondió, los botones se deshabilitan y cambian de color según el caso.
  - El usuario no puede avanzar a la siguiente pregunta sin haber respondido la actual.
  - Mientras tanto, el usuario suma o resta puntos que se muestran en la ventana de puntaje.

## Fuentes
- **PRINCIPAL:** Material brindado por la cátedra de Taller 1 (pdf + videos YouTube)
- **CURSO 1:** C# desde 0 - Inicia tu carrera como programador (de Udemy)
- **CURSO 2:** Maestro C# (de Udemy)
