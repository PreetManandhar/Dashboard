# Dashboard
Overview

This C# application serves as a dashboard providing access to various form applications. Each tab leads to different functionalities, including Lotto Number Generator, Money Exchange and Temperature Conversion, Simple Calculator, and IP4 Validator. The dashboard allows for an organized and user-friendly experience.

Exit Confirmation
When clicking the Exit button, the application will confirm the user's intention to exit, ensuring no accidental closures.


// Author: [Preet Manandhar]

Form 1 - Lotto Number Generator
This feature allows users to generate unique Lotto Max (7 + 1) or Lotto 649 (6 + 1) numbers. Generated numbers are presented in a multiline read-only TextBox and saved to "LottoNbrs.txt" with relevant information.
Usage
Click "Lotto Max"form and button "generate" to generate Lotto Max numbers.
Click "Lotto 649"form and button "generate" to generate Lotto 649 numbers.
The Exit button will display a confirmation message.


Form 2 - Conversions
This feature allows users to convert money and do the temperature conversion incelsius and Farenheit.

Form Money Exchange 
This form provides currency conversion using exchange rates for 5 countries. Conversions  are saved to "MoneyConversions.txt" with relevant information.

Form Temperature Convert 
This form provides temperature conversion using radio buttons for conversion of temperature from celsius to farenheit and vice-versa. Conversions  are saved to "TempConversions.txt" with relevant information.
Additional Feature
Colors are used to differentiate temperature ranges.


Form 3 - Simple Calculator
This form allows users to perform basic arithmetic operations. All operations and results are saved to "Calculator.txt" with one operation per line.


Form 4 - IP4 Validator
This form validates IP4 addresses and writes valid ones to a binary file along with the date and time. It also calculates and displays the time spent in seconds and minutes when the form is closed.
