# Restaurant-system
## Preface
  ###  Version 0.0.0
  ### Introduction:
  Welcome to version 0.0.0 of the Restaurant interface system. This program is developed to ease the process between the servers ordering and the orders getting to the chefs behind the line
  ### Current Features:
  none
  ### Future Features:
  tbd
  ### Limitations:
  as this is the first version, there may be bugs or issues. stay up to date to avoid the bugs that are found.
## Introduction
  This system is needed to allow the companies wait staff to send their orders to the back of the house staff seamlessly.
  The system will fit the objectives of the company by shortening the amount of time spent between the time the order is taken and the time the back of house gets the order.
## Glossary
  System- The program that is running on the device of the restaurant
  
  servers- staff that takes the order as opposed to internet servers
  
  interface- the interactive screen as seen by the users
  
  front-end- the user interface as seen by employees using the program
  
  back-end - the behind the scenes of the program, coordinates data flow
  
  database - Stores persistent data
## user requirement definitions
  This system is designed to automate certain workflows for each parts of the staff
  ### Waitstaff:
  Send orders
  define order needs
  generate bills
  process payments
  ### Back of house:
  Recieve orders
  Mark orders done or in progress
  update food status
## System Architecture
  ### Overview
  The restaurant management system uses front end, back end and databases which allows for large scalability. The program can handle multiple interactions from multiple users
  ### Front end
  This provides the user interface which allows users to interact with the program.
  The program is built in c++ and is meant to be used on primarily tablets but allows functionality on browsers and mobile phones
  ### Back end
  This provides the operations and data flow behind the scenes
  This part of the program is written in (tbd)
  ### Database
  This contains persistent data such as the orders in the system.
  This part of the program is written in (tbd, probably mysql)
## System Models
  ### The program starts from the customer, who sends the order to the server who sends the order to the restaurant system. the system then proceeds to forward the order to the back of house, who can update the completion of the order when it is completed.
  ![image](https://github.com/user-attachments/assets/fa393652-d07c-4959-af0d-df2546c43c47)
