# BrailleSort

Formats ASCII-Braille symbols into braille order for proper transcription of the Special Symbols Page as required by the Braille Authority of North America.

![My App](./app.png)

## WALKTHROUGH

Minimal Viable Product

- A web app that accepts a list of ASCII braille characters and returns the list sorted in braille order
- API accepts requests from the app to access the database.
- Role based authentication restricts updating the database to admins only. 

Other planned features
- Alert user when a symbol includes a character that is not ASCII Braille
- Alert user when a symbol was not found in the database
	- user may request alerted symbol be added to the database
- Service to scrape Known Symbols from http://www.iceb.org/symbsc2.html and check it against the current database
- implement role based access
- ticket system to allow users to report bugs/errors and admins to assign/solve them 

## OPEN REQUIREMENTS

MVP:
- landing page will sort a pasted list of special symbols

Other planned features:
- app alerts user when symbol includes a character that is not ASCII braille
- app alerts user when a symbol is not found in the database
	- user files ticket to add symbol to database
- user login/registration for creating/reporting issues
	- proposed modifications to application
	- assign issues to other admins for research purposes

## USER INTERFACE

MVP:
- Landing page
- Area to paste a list of special symbols for sort
- Sort button

Other features:
- Login option
- Search Symbols
- Option to export a csv of the symbols database
- profile management
- role management
- issue management

## LOGIC DESIGN

- identity access
- role based security
- tracking for issues

## DATA DESIGN

- admin - str
- visitor - str
- owner - str

- symbol - str
- symbol name - str

- ticket - list<issue>
	- priority - enum
	- type - str
	- StatusClosed - bit
	- date - datetime

- notes
	- note - str
	- ticket id
	- date created - datetime
	- date updated - datetime

\* The 64 ASCII-braille characters in 'braille order': abcdefghijklmnopqrstuvxyz&=(!)*<%?:$]\\[w1234567890/+#>'-@^_\".;,

There are currently 510 known symbols listed in the ICEB database http://www.iceb.org/symbsc2.html
