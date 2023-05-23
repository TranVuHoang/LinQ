###
## F1 Giới thiệu về LinQ
# 1. Giới thiệu LinQ
# 2. Hệ sinh thái của LinQ
# 3. Cài vs studio2022

## F2 Các kỹ thuật sử lý trong LinQ (10 bài)
# 4. Generic
# 5. Implicitly Typed Variable(Kiểu dữ liệu, biến không tường minh)
# 6. Object Inlitilizers(Khai báo và khởi tạo đối tượng)
# 7. Anonymous Type(Kiểu dữ liệu nặc danh)
# 8. Extention methods(khởi tạo, cài đặt, mở rộng các phương thức)
# 9. 

## 1. Giới thiệu LinQ
# Nội dung:
	+ LinQ là gì?
	+ Kiến trúc và các thành phần trong LinQ
	+ Các thư viện sử dụng trong LinQ
	+ Một vài ví dụ về LinQ

# LinQ
	+ LinQ là viết tắt của (Language Integrated Query) được ms tích hợp cho .NET Framework 3.5 
	+ LinQ là thư viện mở rộng cho các ngôn ngữ lập trình C#, Visual Basic cung cấp khả năng truy vấn trực tiếp dữ liệu object,
	  cơ sở dữ liệu database và XML
	+ LINQ giúp tăng tốc thời gian viết mã lệnh (chưa chắc hiệu quả về tốc độ xử lý)

# Kiến trúc và các thành phần trong LINQ
	+ kiến trúc LINQ đc chia làm 4 tầng
		- Tầng 1: Tầng hỗ trợ ngôn ngữ (C#)
		- Tầng 2: Những phép toán liên quan đến truy vấn LINQ chuẩn 
		- Tầng 3: tầng trung gian 
			- LinQ to Objects
			- LinQ to DataSet
			- LinQ to SQL
			- LinQ to Entities
			- LinQ to XML
		- Tầng 4: tầng cơ sở dữ liệu nguồn
			- Object(đối tượng)
			- Relationship (Cơ sở dữ liệu quan hệ)
			- XML
# Các thư viện sử dụng trong LinQ
	+ System.Linq : Hỗ trợ sử dụng các Object
	+ System.Data.Linq: Hỗ trợ sử dụng các cơ sở dữ liệu quan hệ
	+ System.Data.Object : Hỗ trợ sử dụng các Entities
	+ System.XML.Linq: Hỗ trợ sử dụng XML
	=> các thư viện được xây dựng sẵn trong ms visual studio 2022

# Một vài ví dụ viết LinQ
	+ int []numbers = {1, 2, 3, 4, 5};
	
	// query syntax:
	IEnumable<int> query1 = from num in numbers 
			where  num % 2 == 0
			orderby num
			select num;
	// method sytax: 
	var query2 = numbers
				.where(n => n % 2 == 0)
				.orderby(n => n);
## 4. Generic
# Nội dung
	+ Ta tập chung vào 2 loại Gerneric:	List và Dictionari
		- nằm trong thư viện: "using.System.Collections.Generic;