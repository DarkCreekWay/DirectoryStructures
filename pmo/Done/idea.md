# DirectoryStructures - the idea

People often have the intention to strucure their life for various reasons.
These reasons range from the desire of saving time to the pure need of
cleanness.

To speed up and to simplify the creation and maintenance of prefered structures
on computer storage, I imagine a clever tool, that allows a user to define
his prefered directory structures in a structured (wink) way and apply
these defined structures with some simple clicks.

The following sections try to describe the problem domain and to sketch a
solution.

## How to reproduce a great structure ?

Over time, users develop some kind of great structures and try to apply them
manually from their mind, by copywriting, etc.
This usually leads to small differences between structures, which were meant
to be equal.

A tool could solve this like the following

- User navigates to a directory containing the desired structure.
- User selects a context menu entry, and the structure gets captured.
- User navigates to another directory, that should get the same structure.
- User selects a context menu entry, and the captured structure gets created.

In other words, the tool
  "copies" the structure underneath a source location.
and
  "pastes" it underneatch a target location.

### Requirements

- Windows Explorer Context Menu Entry for "Copy" structure
- Windows Explorer Context Menu Entry for "Paste" structure

### Requests

Use latest .NET technology stack -> .NET 6.0
Use latest supported C# language version -> 10.0

### Out of scope

- Sophisticated Windows Explorer Context Menu (Registry Hacks are good enough)
- Copy/Paste of attributes, ACLs, etc.
- Ad-Hoc configuration options
- General Configuration options
- Editing of captured structures
