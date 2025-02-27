# UX_UI Design C Sharp

# Nielsens Heuristics

- Broad rules of thumb and not specific usability guidelines
	- These always help but won't make things perfect

## Visibility of System Status

- Design let's user know something is happening
- Only give info that is key
	- Too much info is garbage
- "No action with consequences to users should be taken without informing them"

### Where is it found? 

- Visual, auditory, or haptic feedback
- Progress bars
- Loaders, clocks, timers
- Breadcrumbs
	-Tell user their navigation history
- Toast notifications
	- Push Notis
- Thank you and completion messages

### Progress bars

- Just the bar or ring is good however you want to indicate with a percentage count as well

### Completion Messages

- Let the user know that their input was taken in. Graphic and text combos are better 

### Loaders

- Showing visual representation such as grey bars of things to come will help

- Content loaders can show low res/size pictures to come

### Visual Feedback

- Create sensible graphics that allow a user to understand progress at a glance

### Toast Notifications

- Push notis to update state at a glance

### Physical Objects

- Screens, order pucks, flag holders, etc., can update users in logical locations in public


## Match between the system and the real world 

- The system speaks the user's language
	- Put the program in a way most users are familiar with
- Phrases, words, concepts
	- Use most familiar language; no marketing language
- Conventions
	- Follow the typical flow of sites/apps
	- Flight ticket example; Logical/Natural Order
	- Familiarity in forms; digital vs physical forms

- Trying to match the digital usability as close as possible to the physical version

- "Design for them. Not for you"


## User Control and Freedom 

- If the user makes mistakes, they have clearly marked "Emergency exits."

- The system allows undo and redo

### Error Recovery

- Have a way to undo an action without problem "Alexa Shut up!"

### Breadcrumbs

- Website "PWD" or path taken while navigating

### Undo and Redo

- Important for touch screens for example when fat fingering happens often

- In messaging allow for deletion options or message editing 

### Setup in any order 

- Allowed to choose what to change without hiding settings behind other options

### Customization

- Allow for users to have freedom and control of how they would like to do things


## Consistency and Standards

- Conventions are used for words, situations, and actions

- Important system objects, actions, and options are sufficiently visible

- Users don't have to wonder if different words, situations, or actions mean the same thing

- Follow conventions of other platforms (Jacob's Law)

### Standards

- Breaking standard practices or rules will increase errors

- When designing inputs, follow the most common use-case 

### Consistency

- If you decide to use icons in forms, use common ones in all fields

- Ensure the screens are setup the same even if it's in different sections

- Based on your app, look at other ones that are similar to deliver expected result 

- Look up size specs and conventions

- Design fields to be in expected locations


## Error Prevention 

- In addition to having good error messages, the system has a careful design that prevents the occurrence of errors

- The system ensures that users know exactly what is required

- When filling out a form, the system marks the required fields and highlights them as well

- The system uses JavaScript to validate forms

- "The user creating an error without their knowledge is a design problem" 

- Ensure the users are informed of their potentially large effect actions before they commit to them

### Autocompletion 

- Suggest for things that are common errors when users fill out things

### Understanding

- When something will cause error make sure to ez inform users to prevent common mistakes

### Contextual Help

- If there's a dependencies missing, inform the user of potentially needed completions to avoid errors

### Confirmation

- Confirm prompts to ensure the user is getting the expected result from an action

### Careful Wording

- The less obvious, the more the mental load will be put on the user

- Add prompts that guide the user as they may be going the wrong direction to correct the error as it's happening


## Recognition Rather Than Recall

- Important system objects, actions and options are sufficiently visible

- The user does not have to remember information from one page or messages to the next one
	- More necessity to memorize will increase errors

- Instructions for systems use are visible and retrievable when necessary
	- Recognition vs Recall

### Recognition

- Designed in a way that needs no notes

### Autocomplete for recognition

- Autocomplete needs to be the most intuitive down to the least

### Visual recognition (icons)

- Matching visuals to the intended words help

### Consistency

- Throughout a software suite keep the same icons and menu structure to allow users to easily navigate


## Flexibility and efficiency of use

- Provide shortcuts for expert users

- Examples of these are "most recent", "articles you recently read", "saved data", "recent searches"
	- Don't allow design to get in the way of people that already are familiar with everything

### Smart suggestions

- Based on usage, grab suggestions that will help users navigate faster

### Recent purchases 

- Build lists based on frequently used/purchased products

### Quick information access

- Allow summarized forms of important information at easy press of a button


## Aesthetic and Minimalist Design

- Don't include information that is irrelevant or rarely used

- Websites should be clean, simple, and interesting. Design elements do not hinder functionality, they support it

- There should be mechanics to reduce clutter, have obvious call-to-actions, and eliminate frills

*  * This is for American and European design. Asia tends to be more cluttered and bright

### Simplify

- Keep main points visible and reference details

### Saturation

- Too much information can render the user frustrated and the product useless

### Minimalism

- Key points only will do more to get users engaged

### Minimalized effects and processes

- Reducing the need to multiple devices or products to handle many tasks with fewer items

- Reduce button or interface clutter and condense them as much as possible


## Recognize, Diagnose, and recover from errors

- Error messages should be expressed in plain language (no error cods), precisely indicate the problem, and constructively suggestion a solution

- Use traditional error-message visuals, like bold, red text

- Avoid technical jargon

### "Sounds like" mistakes

- Find a way to display what they are getting results for and the user can sort if it's how they wanted it

### Decide if a message actually helps

- Sometimes there are too many technical terms or options that most people require outside help

### Clarify the Error limitations

- Guide the user to which parts they can change to get the desired result


## Help and Documentation

- It's best if the system doesn't need additional explanation 

- Help and documentation content should be easy to search and focused on the user's task

- Whenever possible, present the documentation in context right when the user requires it

- FAQs, icons, advanced searches, labels, pop-ups, online chats, and online help are good practices


