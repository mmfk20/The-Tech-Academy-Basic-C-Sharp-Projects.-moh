# Package Express Program

This is a simple C# console application that calculates a shipping quote for packages, following the given rules:

## Features
- Prompts the user to enter **weight, width, height, and length** of a package.  
- If weight is greater than **50**, the program ends with a message:  
  *"Package too heavy to be shipped via Package Express. Have a good day."*  
- If the sum of dimensions (width + height + length) is greater than **50**, the program ends with a message:  
  *"Package too big to be shipped via Package Express."*  
- Otherwise, the shipping quote is calculated as:  

