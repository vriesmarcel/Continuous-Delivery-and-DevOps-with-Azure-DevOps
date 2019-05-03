FROM microsoft/aspnet:4.7.2-windowsservercore-ltsc2016
ARG source
WORKDIR /inetpub/wwwroot
COPY ${source:-obj/Docker/publish} .
