# Overview
This project is a Shape Generator built using the MVC architecture with two additional libraries for Business Logic and Modeling. 
Features

# Functionalities:
Natural Language Input: Users can describe shapes and their dimensions using simple commands like:
Draw a circle with a radius of 100
Draw a rectangle with a width of 250 and a height of 400

# Dynamic Rendering:
The program parses user input, validates the command, and renders the requested shape visually on the screen.

# Architecture
The solution is built using the MVC pattern, with additional Business and Model libraries.

## UI (View/Controller):
Contains a Utility Class for parsing user inputs.
Interacts with the user and displays the shapes on the screen.
## Business Logic (Back-End):
Includes a ShapeProvider class responsible for creating and managing shape objects.
Implements the IShape interface, which defines common behaviors for all shapes.
## Model:
Contains individual shape classes (e.g., Circle, Rectangle, Square) that inherit from the IShape interface.
Defines the properties and methods specific to each shape.
