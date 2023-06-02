@echo off
setlocal enabledelayedexpansion

set "downloadUrl=https://github.com/MythicalLTD/PteroController/releases/latest/download/files.zip"
set "targetDir=C:\Program Files\MythicalSystems\PteroController"
set "shortcutName=PteroController"
set "shortcutPath=C:\ProgramData\Microsoft\Windows\Start Menu\Programs"
set "homeDir=%USERPROFILE%\PteroController"

if exist "%targetDir%" (
    echo The app is already installed.
    echo.

    :homeMenu
    echo Home Directory:
    echo 1 Start the app
    echo 2 Update the app
    echo 3 Uninstall the app
    echo 4 Exit
    echo.

    set /p "choice=Enter your choice (1-4): "
    echo.

    set "choice=!choice:~0,1!"
    set "choice=!choice:~0,1!"
    set "choice=!choice:~0,1!"
    set "choice=!choice:~0,1!"

    if "!choice!"=="1" (
        echo Starting the app...
        echo.
        
        start "" "%targetDir%\PteroController.exe"
        exit
    ) else if "!choice!"=="2" (
        echo Updating the app...
        echo.

        set "backupDir=%TEMP%\PteroControllerBackup"

        if exist "%homeDir%\accounts.ini" (
            echo Backing up accounts.ini...
            echo.

            mkdir "%backupDir%"
            move "%homeDir%\accounts.ini" "%backupDir%\accounts.ini"
        )

        if exist "%homeDir%\settings.ini" (
            echo Backing up settings.ini...
            echo.

            move "%homeDir%\settings.ini" "%backupDir%\settings.ini"
        )

        echo Uninstalling the existing app...
        echo.
        
        rmdir /s /q "%targetDir%"
        del /f /q "%shortcutPath%\%shortcutName%.lnk"

        pushd "%targetDir%"
        curl -Lo files.zip "%downloadUrl%"
        powershell -command "Expand-Archive -Path \"files.zip\" -DestinationPath \"%targetDir%\" -Force"
        del "files.zip"
        powershell -command "$shell = New-Object -ComObject WScript.Shell; $shortcut = $shell.CreateShortcut(\"%shortcutPath%\%shortcutName%.lnk\"); $shortcut.TargetPath = \"%targetDir%\PteroController.exe\"; $shortcut.Save()"

        if exist "%backupDir%\accounts.ini" (
            echo Restoring accounts.ini...
            echo.

            move "%backupDir%\accounts.ini" "%homeDir%\accounts.ini"
            rmdir /s /q "%backupDir%"
        ) else (
            echo No backup found for accounts.ini. Skipping restore.
            echo.
        )

        if exist "%backupDir%\settings.ini" (
            echo Restoring settings.ini...
            echo.

            move "%backupDir%\settings.ini" "%homeDir%\settings.ini"
            rmdir /s /q "%backupDir%"
        ) else (
            echo No backup found for settings.ini. Skipping restore.
            echo.
        )

        echo The app has been updated successfully.
        echo.
        pause
        cls
        goto homeMenu
    ) else if "!choice!"=="3" (
        echo Uninstalling the app...
        echo.
        
        rmdir /s /q "%targetDir%"
        del /f /q "%shortcutPath%\%shortcutName%.lnk"

        echo The app has been uninstalled successfully.
        echo.
        pause
    ) else if "!choice!"=="4" (
        exit
    ) else (
        echo Invalid choice. Please try again.
        echo.
        pause
        cls
        goto homeMenu
    )
) else (
    echo The app is not installed.
    echo.

    mkdir "%targetDir%"

    pushd "%targetDir%"
    curl -Lo files.zip "%downloadUrl%"
    powershell -command "Expand-Archive -Path \"files.zip\" -DestinationPath \"%targetDir%\" -Force"
    del "files.zip"
    powershell -command "$shell = New-Object -ComObject WScript.Shell; $shortcut = $shell.CreateShortcut(\"%shortcutPath%\%shortcutName%.lnk\"); $shortcut.TargetPath = \"%targetDir%\PteroController.exe\"; $shortcut.Save()"

    echo The app has been installed successfully.
    echo.
    cls
    goto homeMenu
    
)

popd
endlocal
