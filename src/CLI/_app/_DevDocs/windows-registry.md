# Windows Registry Keys

## Sample Windows Registry File content (.reg)

The following sample uses the ExtendedSubCommandsKey variant for
adding a cascaded context menu to the Microsoft Windows Explorer
for directories.

~~~ WinReg

Windows Registry Editor Version 5.00

[HKEY_CURRENT_USER\SOFTWARE\Classes\Directory\shell\DarkCreekWay.FolderStructures]
"MultiSelectModel"="Single"
"MUIVerb"="DCW Folder Structure"
"ExtendedSubCommandsKey"="Directory\\shell\\DarkCreekWay.FolderStructures"
@=""

[HKEY_CURRENT_USER\SOFTWARE\Classes\Directory\shell\DarkCreekWay.FolderStructures\shell]

[HKEY_CURRENT_USER\SOFTWARE\Classes\Directory\shell\DarkCreekWay.FolderStructures\shell\Apply]
"MUIVerb"="Anwenden"

[HKEY_CURRENT_USER\SOFTWARE\Classes\Directory\shell\DarkCreekWay.FolderStructures\shell\Apply\command]
@="p:\\FileStructures\\src\\CLI\\_app\\bin\\Debug\\net6.0\\fs.exe apply \"%1\""

[HKEY_CURRENT_USER\SOFTWARE\Classes\Directory\shell\DarkCreekWay.FolderStructures\shell\Capture]
"MUIVerb"="Merken"

[HKEY_CURRENT_USER\SOFTWARE\Classes\Directory\shell\DarkCreekWay.FolderStructures\shell\Capture\command]
@="p:\\FileStructures\\src\\CLI\\_app\\bin\\Debug\\net6.0\\fs.exe capture \"%1\""

~~~

## Online references

* [Extending Shortcut Menus](https://docs.microsoft.com/en-us/windows/win32/shell/context)
* [Provide Resources for Shell Verb Action Strings (MUIverb)](https://docs.microsoft.com/en-us/windows/win32/intl/using-registry-string-redirection#provide-resources-for-shell-verb-action-strings)
* [How to Employ the Verb Selection Model (MultiSelectModel)](https://docs.microsoft.com/en-us/windows/win32/shell/how-to-employ-the-verb-selection-model)
* [Creating Static Cascading Menus](https://docs.microsoft.com/en-us/windows/win32/shell/creating-static-cascading-menus)
* [How to Create Cascading Menus with the ExtendedSubCommandsKey Registry Entry](https://docs.microsoft.com/en-us/windows/win32/shell/how-to-create-cascading-menus-with-the-extendedsubcommandskey-registry-entry)


* Resources of Interest for future versions
* [Integrate a packaged desktop app with File Explorer](https://docs.microsoft.com/en-us/windows/apps/desktop/modernize/integrate-packaged-app-with-file-explorer)
* [CreateProcess Verb Sample](https://docs.microsoft.com/en-us/windows/win32/shell/samples-createprocessverb)
* [How to get redirected string from the registry?](https://stackoverflow.com/questions/22273956/how-to-get-redirected-string-from-the-registry)