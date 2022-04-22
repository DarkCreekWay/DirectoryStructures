# User Story - Windows Explorer Integration

The user wants to use the tool on a new machine.

In order to make integrate the tool into Windows Explorer, the tool should offer
sub commands for registering and unregistering.

## Registration

The user calls the app with the sub-command "register".

~~~DOS
fs.exe register
~~~

### Result

The relevant registry keys are created or updated.

## Unregistration

The user calls the app with the sub-command "unregister".

~~~DOS
fs.exe unregister
~~~

### Result

The relevant registry keys are deleted.

## Breakdown

* Implement "register" sub command
  * Get current location of app
  * Create registry keys and values
    * Set pathes for invocation of app to current location of app
* Implement "unregister sub command
  * Delete registry keys
