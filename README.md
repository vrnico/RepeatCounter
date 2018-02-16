# Repeat Counter

#### .Net MVC app that takes a string of words from the user and counts the number of times a specific word repeats itself.

#### _By Nico Daunt_

## Description

_This is the Epicodus code review project for week 2 of the C# course. Its purpose is to display understanding of .Net MVC testing in C#._


___
### Specifications

* Takes in a string as input. `This will be the base text input where the repeated words will be counted from.`

  * Input: "Buffalo buffalo buffalo buffalo buffalo"
  * Output: "Buffalo buffalo buffalo buffalo buffalo"

* Takes in a search term from the user as a string. `This word's repetition will be counted throughout the original string.`

  * Input: "buffalo"
  * Output: "buffalo"

* Counts the number of times search term is repeated in the base text input. `Here we see the number 5 is outputted because our search term _"buffalo"_  appears in the original text 5 times.`

  * Input: "Buffalo buffalo buffalo buffalo buffalo" _"buffalo"_
  * Output: "5"

___






## Setup/Installation Requirements

* _Clone this GitHub repository_

```
git clone https://github.com/vrnico/RepeatCounter.git
```

* _Install the .NET Framework_

  .NET Core 1.1 SDK (Software Development Kit)

  .NET runtime.

  See https://www.learnhowtoprogram.com/c/getting-started-with-c/installing-c for instructions and links.

* _Run the program_
  1. In the command line, cd into the project folder RepeatCounter.Solution/RepeatCounter.
  2. In the command line, type dotnet restore. Enter.  It make take a few minutes to complete this process.
      * Repeat this process in the RepeatCounter.Solution/RepeatCounter.Tests in order to view testing environments.
  3. In the command line, type dotnet build. Enter. Any error messages will be displayed in red.  Errors will need to be corrected before the app can be run. After correcting errors and saving changes, type dotnet build again.  When message says Build succeeded in green, proceed to the next step.
  4. In the command line, type dotnet run. Enter.

* _View program on web browser at port localhost:5000/_

* _Enter your a string into the form text area._

* _Enter a single word to be counted in the space below._

* _Submit the form to see the output._

## Support and contact details

_To suggest changes, submit a pull request in the GitHub repository._

## Technologies Used

* HTML
* Bootstrap 3.3.8
* C#
* .Net Core 1.1

### License

*MIT License*

Copyright (c) 2018 **_Nico Daunt_**

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
