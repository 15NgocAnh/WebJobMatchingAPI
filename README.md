**Getting Started**

Hãy sử dụng những hướng dẫn này để thiết lập và chạy dự án: 

**1. Download **

- Visual Studio 2022 Community tại đây 

- ASP.NET 8.0 tại đây 

- SQL Server 2022 Developer tại đây 

- SSMS (SQL Server Management Studio (SSMS) 20.0) tại đây 

- Git tại đây 

**2. Clone project từ Github 
**
Bước 1:  

 

Bước 2: Tạo một folder chứa code chuẩn bị clone về trên máy của bạn. 

 

Mình vừa tạo 1 folder có tên là CloneProject ở trong ổ đĩa D/Dotnet/workspace_1 trên máy tính cá nhân. 

Bước 3: Click on chuột phải vào tên folder vừa tạo và select Git Bash Here (Option này chỉ hiện khi bạn đã download Git về máy tính thành công) 

 

Bước 4: Sau khi Git open bạn gõ câu lệnh "git clone +  url vừa copy ". Sau đó nhấn Enter và chờ code được clone về máy. 

 

Bước 5: Bạn mở folder và check code đã được clone về chưa. Sẽ có thông tin như sau: 

 

Bước 6: Bạn nhấn vào file WebJobMatchingAPI.sln, open trên Visual Studio và source code sẽ hiện lên. 

**3. Tạo Database **

Bước 1: Vào Package Manager Console ở phía dưới bên trái màn hình Visual Studio. 

 

Bước 2: Gõ lệnh Add-Migration [Tenbatky] 

 

 

Hiển thị Buid succeeded là thành công. Sau đó gõ tiếp lệnh Update-Database 

Sau khi chạy thành công, hệ thống sẽ tự tạo Database trong Sql Server, bạn mở SQL Server lên và kiểm tra. 

 

**4. Run Project **

Bạn nhấn vào nút Run trên thanh công cụ. 

 

Chạy thành công sẽ mở trình duyệt với Swagger như dưới: 

Bạn có thể tiến hành test API ngay trên Swagger: 

 
