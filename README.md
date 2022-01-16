# BrailleSort

This is a project I've been wanting to put together for some time. I programmed the sorting logic and plan to implement the below plans once I am able. 

![My App](./app.png)

A tool to help braille transcribers format the Special Symbols page. 

Role based access allows users to report issues or file requests to update or modify the app/database. Implements identity and role based access/rendering. 

## WALKTHROUGH

- Main sorting algorithm
- Alert when a symbol includes a character that is not ASCII Braille
- Service to scrape Known Symbols from http://www.iceb.org/symbsc2.html and check it against the current database
- Alert when a symbol was not found in the database
	- option to request the alerted symbol be added to the database

## OPEN REQUIREMENTS

- user login/registration for creating/reporting issues
- proposed modifications to application
- assign issues to other admins for research purposes

## USER INTERFACE

- Landing app
- Login option
- Search Symbols
- Export a json or css of the symbols database

- profile management
- role management
- issue management

## LOGIC DESIGN

- identity access
- role based security
- tracking for issues

## DATA DESIGN

- user - str
- issues - list<issue>
	- priority - enum
	- status - str
	- date - datetime

\* ASCII-braille characters in 'braille order': abcdefghijklmnopqrstuvxyz&=(!)*<%?:$]\\[w1234567890/+#>'-@^_\".;,"
