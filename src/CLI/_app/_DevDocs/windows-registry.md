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
