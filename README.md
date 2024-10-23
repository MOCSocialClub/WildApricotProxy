# WildApricot - ASP.NET Core 2.0 Server

Wild Apricot API for non-administrative access

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/WildApricot
docker build -t WildApricot .
docker run -p 5000:5000 WildApricot
```
