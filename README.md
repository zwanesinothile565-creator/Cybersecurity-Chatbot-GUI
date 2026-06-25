# Cybersecurity Awareness Chatbot – Part 3




Name: Mhlengi Zwane
Student Number: ST10465232

Project Overview

The Cybersecurity Awareness Chatbot (Part 3) is a fully developed GUI-based application created using C# and WPF in Visual Studio 2022 (.NET 8).

The system is designed to educate users about cybersecurity concepts such as:

Password security
Phishing attacks
Malware and ransomware
Firewalls and VPNs
Social engineering
Safe browsing practices
Two-factor authentication (2FA)

The chatbot has been upgraded from a basic console application (Part 1) into a fully interactive graphical chatbot system with advanced features including a quiz system, task manager, and conversational AI behaviour.

 Features Implemented
1. GUI Design and Implementation

The chatbot uses a modern WPF interface featuring:

Sidebar navigation panel
Chat display window
User input textbox
Send button interaction system
Dark cybersecurity-themed UI
Scrollable chat history
Bot and user message formatting
Responsive layout design

The GUI improves user experience and makes the system more interactive and user-friendly.

2.  Chatbot Conversation System

The chatbot responds to cybersecurity-related input using keyword detection.

Supported topics:
Password safety
Phishing awareness
Malware and ransomware
VPN usage
Firewalls
Social engineering
Privacy protection
Safe browsing
Multi-factor authentication (2FA)
Example:

User:
“Explain phishing”

Bot:
Provides an educational explanation of phishing attacks.

3. Cybersecurity Knowledge Base (Part 2 Content Integration)

The chatbot includes expanded cybersecurity content from Part 2, ensuring a wider knowledge base.

It provides detailed explanations of:

Cyber threats
Online safety practices
Security tools
Human-based attacks (social engineering)
Network protection methods

This improves the educational value of the system.

4.  Quiz System (15 Questions)

The system includes an interactive quiz with 15 cybersecurity questions.

Features:
True/False format
Score tracking
Progress tracking
Final result display
Chat-based quiz interaction
Example Questions:
Is phishing safe?
Do firewalls protect networks?
Is 2FA recommended?
Is public WiFi always safe?

The quiz helps reinforce cybersecurity learning.

5.  Task Manager System

Users can add and view cybersecurity study tasks.

Features:
Add tasks
View tasks
Mark completion status
Task reminders (timer-based system)

This helps users manage cybersecurity learning effectively.

6.  Reminder System

The system includes an automatic reminder feature using timers.

Reminds users about pending tasks
Runs every 60 seconds
Displays alerts in chat window
7.  Activity Logging System

The chatbot records user interactions such as:

Task creation
Quiz activity
System usage logs

This improves tracking and system transparency.

8.  Conversation Flow & NLP Detection

The chatbot uses basic Natural Language Processing (NLP) techniques:

Keyword detection
Intent recognition
Context-aware responses
Quiz mode detection

This allows more natural conversation flow.

9.  Error Handling

The system includes safe error handling:

Handles empty input
Prevents application crashes
Provides fallback responses

Example fallback:

“I didn’t quite understand that. Please try again.”

 Technologies Used
C#
WPF (Windows Presentation Foundation)
.NET 8
Visual Studio 2022
Object-Oriented Programming (OOP)
 Project Structure
Main Files
MainWindow.xaml
→ Handles GUI layout and design
MainWindow.xaml.cs
→ Controls chatbot logic and user interaction
Chatbot.cs
→ Contains cybersecurity responses and keyword detection
QuizManager.cs
→ Handles quiz logic and scoring system
TaskManager.cs
→ Manages tasks and reminders
ActivityLogger.cs
→ Stores system activity logs
NLPProcessor.cs
→ Detects user intent
Models (TaskItem, QuizQuestion)
→ Stores structured data
 How to Run the Project
Step 1

Open the solution in Visual Studio 2022

Step 2

Build the project:

Build → Rebuild Solution
Step 3

Run the application:

Press F5
 How to Use the Chatbot
Enter your name
Ask cybersecurity questions
Take the quiz
Add tasks
View logs
 Example Conversation

User:
What is phishing?

Bot:
Phishing is a cyberattack where attackers trick users into revealing sensitive information.

User:
Start quiz

Bot:
Quiz Started!

Is phishing safe? (true/false)
 OOP Concepts Used
Encapsulation (classes for each feature)
Abstraction (hidden logic in services)
Classes and Objects
Lists and Collections
Methods and Functions
Modular programming
 Challenges Faced
Managing quiz duplication errors
Fixing namespace conflicts
Handling WPF event binding issues
Implementing timer-based reminders
Improving chatbot accuracy
Structuring OOP architecture
 Improvements from Part 2
Feature	Part 2	Part 3
Interface	Basic GUI	Modern WPF UI
Chatbot	Keyword-based	Enhanced NLP + context
Quiz	Basic	15-question system
Memory	Limited	Improved interaction flow
Tasks	Not available	Full task system
Logging	Not available	Activity tracking
UX	Simple	Professional design
 Future Improvements
AI-powered chatbot (GPT integration)
Database storage (SQL Server)
Voice assistant support
Login system with user profiles
Cloud-based synchronization
Dark/light mode toggle
Mobile version
 Conclusion

The Cybersecurity Awareness Chatbot (Part 3) successfully demonstrates the development of a full-featured WPF application using C#. It integrates cybersecurity education with interactive features such as quizzes, task management, and conversational AI.

The system meets all Part 3 requirements and demonstrates strong understanding of:

Object-Oriented Programming
GUI development
Event-driven programming
Cybersecurity principles
Software design and modular architecture
