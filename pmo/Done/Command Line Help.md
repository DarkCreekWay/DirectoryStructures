# User Story - Command Line Help

As a user, I want to be able to ask the app for usage instructions.
For this, the application should output simple help text, when
either invoked

* without any parameter
* with a /? /h -? -h --help parameter

## Breakdown

* [x] Extend command line parameter router
* [x] Localized Help text
* ~~[ ] Output of help text to the console~~
* [x] Show localized help text in a MessageBox

> Output to console requires a lot of additional code, when project output
> type is WinExe. Experiments has shown, that the additional code does not
> work well with PowerShell.
> Therefore, the plan was changed from output to console to showing a MessageBox.
> The implementation is cleaner, shorter and fully functional.
