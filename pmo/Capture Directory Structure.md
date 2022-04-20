# User Story - Capture Directory Structure

The user captures a directory structure as follows

* Start Windows Explorer
* Navigate to directory that contains the directory structure to be captured.
* Right-Click the directory.
* Select "Capture Directory Structure".
  
## Result

The directory structure underneath the selected directory gets captured and
persisted.

## Follow up stories

* The persisted structure can be applied to another directory as child structure.

## Breakdown

* console app
  * Accept the following Parameter syntax
    * \<app\>.exe \<command> \<path\>
    * \<command\>
      * capture
  * Example invocation
    * fs.exe capture "c:\users\SampleUser\My template directory\"
  * Build a flat list of sub-directories for a given path
  * The list has to cover the full sub directory hierarchy (Recurse tree)
  * Define directory structure underneath %localappdata% for persistence.
  * Store flat list as text file underneath defined directory structure.
    * The file needs to be able to store Unicode pathes.
* Integrate application into the Windows Explorer Context Menu for directories
  User specific integration (reduces permission and UAC trouble)
  * Find correct registry keys
  * Add Registry key based invocation manually
    * Invocation will look like something like : \<app\>.exe capture "%0"
