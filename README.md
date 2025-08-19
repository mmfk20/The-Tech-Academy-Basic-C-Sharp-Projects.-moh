# Package Express Program

This is a simple C# console application that calculates a shipping quote for packages, following the given rules:

## Features
- Prompts the user to enter **weight, width, height, and length** of a package.  
- If weight is greater than **50**, the program ends with a message:  
  *"Package too heavy to be shipped via Package Express. Have a good day."*  
- If the sum of dimensions (width + height + length) is greater than **50**, the program ends with a message:  
  *"Package too big to be shipped via Package Express."*  
- Otherwise, the shipping quote is calculated as:  


- Displays the estimated shipping cost as a **dollar amount (2 decimal places)**.  

---

## ▶ Example Run

---

## ⚙ How to Run
1. Clone or download this repository.  
2. Open the project in **Visual Studio** (Console App template).  
3. Replace the default `Program.cs` code with the one in this repository.  
4. Run the program (`Ctrl + F5`) and enter package details when prompted.  

---

## 📌 Notes
- The program will stop immediately if the weight or size limits are exceeded.  
- Otherwise, it will always return a shipping quote.  

---

✨ **Author:** *Moh*  
📖 **Assignment:** Package Express (C# Console Application)  
