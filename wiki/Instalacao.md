## Instalando .NET SDK

```bash
# SDK: para Desenvolver
sudo apt-get update
sudo apt-get install -y dotnet6
sudo apt-get install -y dotnet-sdk-6.0

# Runtime: para executar (não precisa caso o SDK seja instalado)
sudo apt-get install -y dotnet-runtime-6.0

# Avalia informações do Dotnet instalado
dotnet --info

# Remover
sudo apt remove --purge dotnet-sdk-6.0
sudo apt remove --purge dotnet-runtime-6.0
sudo rm -rf /usr/share/dotnet
sudo rm -rf /usr/bin/dotnet
sudo rm -rf /usr/lib/dotnet
sudo rm -rf /etc/dotnet
sudo rm -rf /usr/share/man/man1/dotnet*.gz
sudo apt remove 'dotnet*'
sudo apt remove 'aspnetcore*'
whereis dotnet
whitch dotnet

# https://stackoverflow.com/questions/73312785/dotnet-sdk-is-installed-but-not-recognized-linux-ubuntu-popos-22-04
```

<br>

---