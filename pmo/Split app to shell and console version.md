# User Story - Split app to shell and console version

Writing output to the console from WinExe based projects does not work very well.
The current implementation works around this by omitting output to the console at all.

This is not a first-class solution for IT pros, and should be improved.
Instead of mixing shell and console invocation within one binary,
it would be better to split the invocation to 2 different binaries.

## Breakdown

* [X] Refactor output related code and isolate it by invocation type (shell with UI vs. console)
* [X] Create new project CLI.Shell
* [X] Refactor code by invocation type (console, shell)
* [X] Update Windows Registry code (use new shell project)
* [X] Review and update docs (if needed)
