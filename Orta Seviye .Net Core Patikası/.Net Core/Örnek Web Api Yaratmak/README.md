# WEB API DOSYASI OLUŞTURMAK
- mkdir hello  // hello adında klasör oluşturmak için
- dotnet new --list  // dotnet ile oluşturulabilecek proje çeşitlerini görebiliyorsun.
-- dotnet new webapi -n HelloWebapi  // HelloWebapi adında bir webapi dosyası oluşturuyor.
- cd HelloWebapi // komut satırında HelloWebapi klasörüne girmeni sağlar
- cd . // bir önceki dizine geçer
- dir // dizindeki klasörleri listeler.
- dotnet new sln -n HelloSln // solution dosyası oluşturur.
- dotnet new sln add HelloWebapi // bu dizinde 1 tane sln dosyası varsa işlemi yapar
ki burda 1 tane var şimdi o sln dosyasını HelloWebapi'ye bağlayacak.

dotnet cli ile .net 5.0 web api projesi oluşturmak için 
- dotnet new webapi -f net5.0 veya dotnet new webapi -n project50 -f net5.0