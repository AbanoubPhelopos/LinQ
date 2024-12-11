# LINQ and Extension Methods in C#

## Overview
This project demonstrates the use of **LINQ (Language Integrated Query)** and **Extension Methods** in C#. The project is structured into three class libraries and one console application to showcase different techniques for querying data and extending functionality in a clean, modular way.

## Project Structure

### 1. **Class Libraries**
#### **ApplicationData**
Contains the data models and a mock database context.

#### **Extenssion_Methods**
Contains utility methods and demonstrates the power of extension methods:

- **`PersonExtenssion`**:
  - **`GetAge(this Person person)`**: An extension method for the `Person` class to calculate age.
  - **`IsAdult(this Person person)`**: An extension method for the `Person` class to check if the person is an adult.

#### **LinQ**
Contains implementations of LINQ queries for data manipulation and analysis:
- **`HandsOn`**: Includes examples of LINQ problems for:
  - Retrieving the first three products sorted by price in descending order.
  - Calculating total stock value by category.
  - Identifying the most expensive product in each category.

- **`Queries`**: Provides solutions to common LINQ queries which solve during the session, such as:
  
1. Find all products that are out of stock.
2. Find all products that are in stock and cost more than 3.00 per unit and its price more than 15 $.
3. Sort a list of products by name
4. Sort a list of products by category then for the same category sort by price
5. Return a sequence of just the names of a list of products.
6. Return the first product whose Price > 1000, unless there is no match, in which case null is 
7. Return a list of categories and how many products each has
8. Get the total units in stock for each product category.
9. Find the unique Category names from Product List
10. Get the first 3 Products with Price more than 80

### 2. **Console Application**
#### **TestCode**
The entry point for the project, which executes and demonstrates:
- `Extenssions.WithoutExtensionMethods()`
- `Extenssions.WithExtensionMethods()`
- LINQ queries from `Queries.Query()` and `HandsOn.Answer()`.

## Key Features
### Extension Methods
- Simplify code by adding new methods to existing classes without modifying their source.
- Examples include:
  - **`GetAge()`**: Calculates a person's age based on their date of birth.
  - **`IsAdult()`**: Determines if a person is an adult based on their age.

### LINQ Queries
- Efficiently query collections and databases.
- Examples include:
  - Filtering, sorting, and grouping products.
  - Calculating aggregate values like total stock or unique categories.

## Technologies Used
- **C# .NET**
- **LINQ** for data querying.
- **Extension Methods** for reusable functionality.

## How to Run
1. Clone the repository:
   ```bash
   git clone <repository-url>
   ```
2. Open the project in Visual Studio or your preferred IDE.
3. Build the solution to restore dependencies.
4. Run the `TestCode` console application.

## Output Example
When you run the project, you will see:
1. The age of a person calculated both with and without extension methods.
2. Demonstrations of LINQ queries showing results like:
   - Products that are out of stock.
   - Products sorted by category and price.
   - Categories with the number of products.

## Contribution
Feel free to fork this repository and submit pull requests to improve or add new functionality.
