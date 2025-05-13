BIT 2118 Application Programming - Assignment I Report
  Group Members: Victor, Adrian, Kerry, Linet, Eugene, Austin, Walter
    Course:BIT 2118 - Application 

This report outlines the approach and implementation of the assigned C# programming tasks. Each team member was responsible for headlining a specific question to ensure an efficient workflow. Below is a detailed breakdown of how each question was tackled. 

Question 1: Lucky Number Game (Victor & Austin)
Victor developed a C# program to simulate a game where a user enters a lucky number, which is then evaluated against a secret number to determine wins and losses. His approach included:  
- Accepting user input for the lucky number.  
- Dividing the number by a secret value and evaluating the remainder.  
- Applying conditions:  
  - If the remainder is 0 , it’s a draw, and the score increases by 1.
  - If the remainder is an even number, the user wins, and the score increases by 3.
  - If the remainder is an odd number, the user loses, and the score decreases by 3.
- Implementing a loop to allow multiple rounds until the game ends.  
- Ensuring proper validation of user input and meaningful output messages.  

Question 2: Pattern Printing Using Nested Loops (Adrian)
Adrian worked on generating a specific pattern using nested loops. His approach:  
- Using a for loop to control the number of rows in the pattern.  
- Implementing a nested for loop to print the correct number of & symbols per row.  
- Ensuring correct spacing and alignment to match the required pattern.

Question 3: Credit Worthiness Checker (Kerry)
Kerry developed a C# program that evaluates the creditworthiness of a customer. The steps taken were:  
- Prompting the user to input the item price and quantity.  
- Calculating the total cost of the purchase using a function.
- Comparing the total cost with a predefined credit limit that was given.
- Displaying appropriate messages:  
  - If the total cost exceeds the limit, the program outputs "Sorry, you cannot purchase. Goods worth this value are on credit."  
  - If the total cost is within the limit, the program outputs "Thank you for your purchase."  
- Implementing a while loop to allow the user to re-enter values if the credit limit is exceeded.

Question 4: Area Calculation (Linet)
Linet worked on the program that calculates the area of different shapes based on user selection. The implementation included:  
- Displaying a menu where the user selects a shape:  
  - Triangle: 0.5 *base*height
  - Rectangle: length * width
  - Circle: π * radius²
- Using conditional statements (if-else) to determine the formula based on user input.  
- Prompting users for the necessary dimensions.  
- Implementing input validation to ensure correct values were entered.  
- Allowing users to re-enter their choice if an invalid option was selected.

Question 5: Sales Data Analysis (Eugene)
Eugene handled the program that stores and calculates sales data for 10 salesmen. The approach taken:  
- Declaring arrays to store salesman names and their respective sales for five different items.  
- Using loops to compute total sales for each individual.  
- Displaying results in a well-formatted tabular structure.  
- Calculating and displaying the grand total of all sales.
