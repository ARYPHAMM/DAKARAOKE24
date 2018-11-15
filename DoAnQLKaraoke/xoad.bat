FOR /F "tokens=*" %%G IN ('DIR /B /AD /S Release') DO RMDIR /S /Q "%%G"
FOR /F "tokens=*" %%G IN ('DIR /B /AD /S Debug') DO RMDIR /S /Q "%%G"