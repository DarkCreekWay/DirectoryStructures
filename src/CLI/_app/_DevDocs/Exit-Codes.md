# Exit Codes

| Exit Code | Scope           | Description                            |
|----------:|-----------------|----------------------------------------|
|         0 | Global          | Success                                |
|         1 | App             | Parameter Count is insufficient        |
|         2 | App             | Command is unknown                     |
|       100 | Common          | Directory does not exist               |
|       200 | Capture Command | Directory Parameter Missing            |
|       300 | Apply Command   | Directory Parameter Missing            |
|       301 | Apply Command   | Captured Directory Structure Not Found |

> When testing, please wrap ds.exe into a cmd batchfile.
> Otherwise, you will not see the %ERRORLEVEL% variable set to the exit
> code above. (Seems to be a DOS issue)
