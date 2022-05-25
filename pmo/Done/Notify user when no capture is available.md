# User Story - Notify user when no capture is available

When invoking the apply command without a prior invocation of the capture
command or when local data has been deleted, the tool does nothing.

By this, a user cannot find out, if the tool is not working properly
or has no captured data.

When the tool got invoked

* via contextmenu, it should show a message box.
* via commandline, it should exit with a non-zero error code.

## Breakdown

* [x] Determine invocation by contextmenu || CLI
* [x] Check, if captured data is missing or empty
* [x] Show localized message, if missing or empty for contextmenu invocation
* [x] Exit with non-zero error code, if missing or empty for cli invocation
* [x] Update documentation
