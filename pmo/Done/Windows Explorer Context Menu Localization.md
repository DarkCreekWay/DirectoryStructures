# User Story - Windows Explorer Context Menu Localization

The labels of the Windows Explorer Context menu entries should be registered
in the locale of the user.
If the locale is not known to the app, it should fall back to english.
  
## Result

The labels of the context menu entries are registered in the user's locale

## Notes

## Predecessor Story

Windows Explorer Integration

## Breakdown

* [x] Replace static labels with values provided by ResourceManager
* [x] Add Resources for locale EN
* [x] Add Resources for locale DE
* [x] Set app neutral language to EN
