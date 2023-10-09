# Exercise: JSON Data Parsing for an Online Game

**Objective:** The goal of this exercise is to parse JSON data and convert it into a class structure using C#.
Scenario: You are developing an online game, and you need to create a JSON data parser that can handle player information received from the game server.

**Requirements:**
- Create a C# class named PlayerData that can represent the player's information, including fields for username, level, guild, items, and skinId. The class should also include appropriate properties and constructors.
- Implement a JSON parser in C# that can read JSON data containing player information and convert it into instances of the PlayerData class.
- Handle JSON data with varying field count. The parser should not break when encountering unexpected fields.
- Make a C# main class in  pure C# project that is able to showcase the exercise.
- Provide JSON examples with different field counts for the candidate to test the parser. Here are a few examples:
- Handle default values for Level and skin, the level default value is 1 and skin default value is "defaultSkin".
- Make sure that your code can handle non json data.
- Make sure that the json have username field.

Example 1:
`{
    "username": "snake",
    "level": 10,
    "items": [“MK 23”, “Night Vision”]
}`

Example 2:
`{
    "username": "link",
    "level": 15,
    "guild": "Warriors",
    "skinId": "123"
}`

Example 3:
`{
    "username": "leon",
    "coins": 100,
    "questsCompleted": 5
}`



**Bonus (Optional):**
- Implement error handling to handle invalid JSON data gracefully.

**Submission:**
- Submit a C# project that includes the PlayerData class, the JSON parser, and the user interface for testing.
- Include a README file explaining how to use the application and any additional notes about the implementation.

**Evaluation Criteria:**
- Correctness
- JSON Handling
- User Interface
- Bonus Features
- Documentation


