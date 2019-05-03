FROM microsoft/mssql-server-windows

# SQL environmental variables
ENV sa_password "P@ssw0rd01!"
ENV attach_dbs "[]"

# Copy SQL scripts for setting up blog database and tables
COPY . /

WORKDIR /

# Create blog application database and tables
RUN powershell sqlcmd -S localhost,1433 -i Setup-mvcmusicstore.sql

#FIX DNS issues currently in Windows Containers
RUN powershell set-itemproperty -path 'HKLM:\SYSTEM\CurrentControlSet\Services\Dnscache\Parameters' -Name ServerPriorityTimeLimit -Value 0 -Type DWord 

CMD powershell ./start -sa_password %sa_password% -attach_dbs \"%attach_dbs%\" -Verbose -ACCEPT_EULA 'Y'
