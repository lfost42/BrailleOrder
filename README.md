# BrailleSort

Formats ASCII-Braille symbols into braille order for proper transcription of the Special Symbols Page as required by the Braille Authority of North America.

![My App](./app.png)

## WALKTHROUGH

Minimal Viable Product:
- [BrailleSymbolsAPI](https://github.com/lfost42/BrailleSymbols) allows admins to maintain the special symbols database and users to query it.
- IssueTrackingAPI allows users to report errors/discrepancies in the database or suggest app changes.

Other Planned Features:
- Ability to search for symbols.
- Ability to select a symbol and add it to a list that is sorted into ASCII-braille order. 
- Add 'dot locator' and special symbol description (for formatting of the Braille Special Symbols page)

Sort a pasted list into ASCII-braille order
- Alert user when a symbol includes a character that is not ASCII-braille
- Alert user when a symbol was not found in the database
	- user may request alerted symbol be added to the database
- Issue System allows users to report bugs/errors and admins to assign/solve them 

## OPEN REQUIREMENTS

- landing page will allow users to query the special symbols database
- options to build the special symbols page or sort a list of symbols
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

### BrailleSymbolsAPI
- symbol - str
- symbol name - str

### FosterPI (Authentication API)
- admin - str
- visitor - str
- owner - str

### IssueTrackerAPI
- ticket - list<notes>
	- priority - enum
	- type - str
	- Date Created - datetime
	- IsClosed - boolean
	- Date Closed - datetime

- notes
	- note - str
	- ticket id
	- date created - datetime
	- date updated - datetime

\* The 64 ASCII-braille characters in 'braille order': abcdefghijklmnopqrstuvxyz&=(!)*<%?:$]\\[w1234567890/+#>'-@^_\".;,

There are currently 510 known symbols listed in the ICEB database http://www.iceb.org/symbsc2.html
