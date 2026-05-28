# Cybersecurity Awareness Chatbot – Part 2


Mhlengi Zwane

St10465232


 Project Overview

The Cybersecurity Awareness Chatbot is a GUI-based chatbot application developed using C# and WPF in Visual Studio 2022. The chatbot helps educate users about cybersecurity topics such as phishing, password safety, scams, privacy, malware, and safe browsing.

The chatbot was improved from the console-based application created in Part 1 into a modern graphical user interface application with dynamic responses, sentiment detection, memory recall, and conversational flow.



 Features Implemented

1. GUI Design and Implementation

The chatbot uses a professional WPF graphical user interface that includes:

* Modern sidebar navigation menu
* Chat display area
* User input area
* Coloured chatbot and user messages
* Professional cybersecurity colour scheme
* Responsive layout
* ASCII-inspired shield logo
* Smooth user interaction



 2. Keyword Recognition

The chatbot recognises multiple cybersecurity-related keywords including:

* Password
* Phishing
* Scam
* Privacy
* Malware
* Safe Browsing
* VPN
* Firewall
* Antivirus

The chatbot responds with educational information based on the detected keyword.

Example:

* “Tell me about phishing”
* “What is malware?”
* “Explain password safety”



 3. Random Responses

The chatbot uses lists and random selection to provide varied responses for cybersecurity tips.

Examples:

* Different phishing tips
* Different password safety tips
* Different privacy tips
* Different scam prevention tips

This makes conversations more engaging and less repetitive.



 4. Conversation Flow

The chatbot maintains conversational context using topic tracking.

The chatbot supports:

* “Tell me more”
* “Explain more”
* “Give me another tip”

The chatbot remembers the current topic and continues the discussion naturally without restarting the conversation.



 5. Memory and Recall

The chatbot stores user information including:

* User name
* User mood
* Favourite cybersecurity topic

The chatbot later uses stored information to personalise responses.

Example:

* “I like privacy”
* Chatbot remembers the interest in privacy



 6. Sentiment Detection

The chatbot detects user emotions and changes responses accordingly.

Supported sentiments:

* Worried
* Curious
* Frustrated
* Confused
* Happy

Example:
User:
“I am worried about phishing.”

Chatbot:
Provides empathetic reassurance and educational support.



 7. Error Handling

The chatbot handles invalid or unknown input safely.

Default response:
“I didn't quite understand that. Could you rephrase your question?”

This prevents crashes and ensures smooth functionality.


8. Code Optimisation

The project follows Object-Oriented Programming principles using:

* Classes
* Methods
* Delegates
* Lists
* Generic collections
* Encapsulation

The code is modular and structured for future expansion in Part 3.



 Technologies Used

* C#
* WPF (Windows Presentation Foundation)
* .NET 8
* Visual Studio 2022



 Project Structure

 Files Included

 MainWindow.xaml

Contains the GUI layout and interface design.

 MainWindow.xaml.cs

Controls user interaction and chatbot GUI behaviour.

Chatbot.cs

Contains chatbot logic, keyword recognition, sentiment detection, memory recall, and responses.



 How to Run the Project

Step 1

Open the solution file in Visual Studio 2022.

Step 2

Build the solution:

 Build → Rebuild Solution

 Step 3

Run the application:

Press F5



 How to Use the Chatbot

 Step 1

Enter your name.

 Step 2

Enter your mood.

 Step 3

Ask cybersecurity questions such as:

* “Tell me about phishing”
* “Tell me about password safety”
* “I am worried about scams”
* “Give me another tip”
* “Tell me more”



 Example Conversation

User:
Tell me about phishing

Bot:
Phishing is a type of cyberattack where scammers pretend to be trusted organisations to steal sensitive information.

User:
Tell me more

Bot:
Phishing attacks usually create urgency or fear to manipulate victims.

User:
Give me another tip

Bot:
Do not click suspicious links from unknown senders.



 OOP Concepts Used

 Encapsulation

Data and methods are grouped inside classes.

Delegates

Delegates are used for response handling.

Collections

Lists are used to store multiple chatbot responses.

 Methods

Methods are used to organise chatbot functionality.



 Challenges Faced

* Converting console chatbot into WPF GUI
* Managing conversation flow
* Implementing sentiment detection
* Fixing keyword recognition conflicts
* Preventing repetitive responses
* Managing GUI event handling



 Improvements from Part 1

| Part 1                 | Part 2                        |
| ---------------------- | ----------------------------- |
| Console application    | GUI application               |
| Static responses       | Dynamic responses             |
| No memory              | Memory recall                 |
| No sentiment detection | Sentiment-aware responses     |
| Basic interaction      | Conversational flow           |
| Limited topics         | Expanded cybersecurity topics |



 Future Improvements

Possible future improvements include:

* Database integration
* AI-generated responses
* Voice recognition
* Speech synthesis
* User login system
* Dark/light theme switching
* Cloud integration






Conclusion

This project successfully demonstrates the development of a GUI-based cybersecurity chatbot using C# and WPF. The chatbot provides interactive cybersecurity education while implementing important programming concepts such as OOP, collections, delegates, sentiment detection, memory recall, and conversational flow.

The chatbot meets the requirements for Part 2 and provides a strong foundation for future improvements in Part 3.
