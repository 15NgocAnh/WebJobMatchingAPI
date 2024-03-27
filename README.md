# Getting Started 

Hãy sử dụng những hướng dẫn này để thiết lập và chạy dự án: 

## 1. Download 

- Visual Studio 2022 Community [tại đây](https://visualstudio.microsoft.com/fr/downloads/) 

- ASP.NET 8.0 [tại đây](https://dotnet.microsoft.com/en-us/download)

- SQL Server 2022 Developer [tại đây](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

- SSMS (SQL Server Management Studio (SSMS) 20.0) [tại đây](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)

- Git [tại đây](https://git-scm.com/downloads)

## 2. Clone project từ Github 

Bước 1:  
[![Screenshot_10129d4adbec60711.png](https://img.upanh.tv/2024/03/27/Screenshot_10129d4adbec60711.png)](https://upanh.tv/image/ylzBSK)

Bước 2: Tạo một folder chứa code chuẩn bị clone về trên máy của bạn. 

[![Screenshot_2c821454e4da60937.png](https://img.upanh.tv/2024/03/27/Screenshot_2c821454e4da60937.png)](https://upanh.tv/image/ylzn1Q)
 
Mình vừa tạo 1 folder có tên là CloneProject ở trong ổ đĩa D/Dotnet/workspace_1 trên máy tính cá nhân. 

Bước 3: Click on chuột phải vào tên folder vừa tạo và select Git Bash Here (Option này chỉ hiện khi bạn đã download Git về máy tính thành công) 

[![Screenshot_3.png](https://img.upanh.tv/2024/03/27/Screenshot_3.png)](https://upanh.tv/image/ylzXxH)

Bước 4: Sau khi Git open bạn gõ câu lệnh "git clone +  url vừa copy ". Sau đó nhấn Enter và chờ code được clone về máy. 

[![Screenshot_4.png](https://img.upanh.tv/2024/03/27/Screenshot_4.png)](https://upanh.tv/image/ylzDMc)

Bước 5: Bạn mở folder và check code đã được clone về chưa. Sẽ có thông tin như sau: 

[![Screenshot_5.png](https://img.upanh.tv/2024/03/27/Screenshot_5.png)](https://upanh.tv/image/ylzd3j)
 
Bước 6: Bạn nhấn vào file WebJobMatchingAPI.sln, open trên Visual Studio và source code sẽ hiện lên. 

[![Screenshot_6.png](https://img.upanh.tv/2024/03/27/Screenshot_6.png)](https://upanh.tv/image/ylzjKE)

## 3. Tạo Database 

Bước 1: Vào Package Manager Console ở phía dưới bên trái màn hình Visual Studio. 

[![Screenshot_7ab572255a9b29896.png](https://img.upanh.tv/2024/03/27/Screenshot_7ab572255a9b29896.png)](https://upanh.tv/image/ylzyPD)

Bước 2: Gõ lệnh Add-Migration [Tenbatky] 

[![Screenshot_82c3779053fc00fb8.png](https://img.upanh.tv/2024/03/27/Screenshot_82c3779053fc00fb8.png)](https://upanh.tv/image/ylzrqZ)

Hiển thị Buid succeeded là thành công. Sau đó gõ tiếp lệnh Update-Database 

[![Screenshot_90d0e9d4648accfa6.png](https://img.upanh.tv/2024/03/27/Screenshot_90d0e9d4648accfa6.png)](https://upanh.tv/image/ylzNRF)

Sau khi chạy thành công, hệ thống sẽ tự tạo Database trong Sql Server, bạn mở SQL Server lên và kiểm tra. 

[![Screenshot_1078c8a0799fee5944.png](https://img.upanh.tv/2024/03/27/Screenshot_1078c8a0799fee5944.png)](https://upanh.tv/image/ylzKdA)

## 4. Run Project 

Bạn nhấn vào nút Run trên thanh công cụ. 

[![Screenshot_11487519a4464c72e4.png](https://img.upanh.tv/2024/03/27/Screenshot_11487519a4464c72e4.png)](https://upanh.tv/image/ylzWAS)
 
Chạy thành công sẽ mở trình duyệt với Swagger như dưới: 

[![Screenshot_12.png](https://img.upanh.tv/2024/03/27/Screenshot_12.png)](https://upanh.tv/image/ylzuSh)

Bạn có thể tiến hành test API ngay trên Swagger: 

[![Screenshot_13.png](https://img.upanh.tv/2024/03/27/Screenshot_13.png)](https://upanh.tv/image/ylz5CM)
 