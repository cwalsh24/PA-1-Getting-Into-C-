# Programming Assignment 1: Getting Into C#
Author: Connor Walsh
Date: 1/19/2023

This program is designed to allow users to build a list of animals. The program comes with some search features and allows for the age of animals to be increased. 

## How to Run
* Press the play button to run the program.
* Once the console opens, the user will be shown a menu displaying the options they have. 
* To generate a list of animals, add them by following the onscreen instructions.
* To exit the program, press and enter the number 6.

## Design Decisions
* In order to keep my code easy to read, I left all classes in the same file, because this easily displays how the concrete classes inherit and overwrite the methods inside of the abstract class.
* For readability, I made it so the create a new animal function on the menu called a method that exists inside of the World class called newEntry. This avoids having to do the functions inside this method in the main.
* The menu is designed to loop indefinitely until the user chooses to exit. 
* There is no way to delete animals from the list because this was not in the instructions of the assignment. 
  
