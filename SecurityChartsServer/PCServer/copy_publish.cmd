:: set SRC_DIR=..\����\����
set DST_DIR=.\PCServer\bin\Release\PublishOutput

xcopy ..\����\����\node_modules_bak %DST_DIR%\node_modules\  /s /e 
xcopy .\PCServer\Node %DST_DIR%\Node\ /s /e 
xcopy .\PCServer\static %DST_DIR%\static\ /s /e

pause