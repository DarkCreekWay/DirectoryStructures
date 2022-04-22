# User Story - Apply Captured Directory Structure

The user wants to apply a previously captured directory structure as follows

* Start Windows Explorer
* Navigate to directory that contains the directory structure to be extended.
* Right-Click the directory.
* Select "Apply Directory Structure".
  
## Result

The directory structure underneath the selected directory gets extended by
the previously captured structure.

## Notes

The persisted structure should not get deleted when applied.
By this, the user can apply a captured structure multiple times.

## Predecessor Story

'Capture directory structure'

## Breakdown

* console app
  * Accept the following Parameter syntax
    * \<app\>.exe \<command> \<path\>
    * \<command\>
      * apply
  * Example invocation
    * fs.exe apply "c:\users\SampleUser\My target directory\"
  * [ ] Get captured directory structure from persisted file.
  * [ ] Create directory structure underneath provided path.
