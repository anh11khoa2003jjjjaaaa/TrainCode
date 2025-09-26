
# TrainCode: Áp dụng SRP(Single Responsibility Principle) để Refactor API/ create-oder theo chuẩn SOLID.

# Refactor endpoint create-order theo chuẩn SRP để dễ dàng test, rõ ràng, dễ mở rộng, dể bảo trì.

# Hướng đến cách code chuyên nghiệp, sạch, dễ mở rộng là lý do chính để tui nghiên cứu về cấu trúc SOLID
# Khi áp dụng nguyên lý SRP thì cấu trúc code của dự án trở nên sạch và tường minh hơn. Được thể hiện qua từng method/class đảm nhiệm một nhiệm vụ duy nhất,
# không God Class. Ví dụ: class Validator là để chưa nhiệm vụ là Validate--> chứa hàm IsValidateOrder()--> kiểm tra thông tin đơn hàng có hợp lệ không.

# Dự án được sử dụng bởi ngôn ngữ C#, công nghệ ASP.NET CORE API,.NET 8.0, XUnit Test, Visual Studio.

# Dự án được chia sẻ lên github, có thể clone về và trải nghiệm
# `git clone https://github.com/anh11khoa2003jjjjaaaa/TrainCode.git`
# Cần tải Nuget Package: xUnit để viết test case và test.

# ---Hướng dẫn chạy code---
# Trong solution hiện tại có 2 project TrainCode và TrainCode_unitest.
# __________TrainCode___________#
# Cần mở tất cả class để xem cách trình bài và để xem kết quả của project TrainCode thì click-right vào solution TrainCode và chọn Set as Startup Project rồi run nó.
# Sau khi chạy dự án thì nó trả về swagger giao diện để test API `https://localhost:7001/OrderSRP?userId=3&productId=1&quantity=4&totalPrice=7`
# __________TrainCode_unitest_______#
# TrainCode_unitest thì click-right vào solution TrainCode và chọn Set as Startup Project. Sau đó click vào class OrderValidator.cs --> nhìn trên thanh menu công cụ click vào `Test` để chọn `Test Explorer`,
# Trong class OrderValidatorTests có 2 method Validate_InvalidateUserId_ThrowArgumentException và Validate_ValidData_DoesNotThrow.
# Trong method Validate_InvalidateUserId_ThrowArgumentException để kiểm tra hàm IsValidateOder có trả về throw ArgumentException đúng như logic code đã viết không --> nếu trả về đúng ArgumentException là pass.
# Trong method Validate_ValidData_DoesNotThrow để kiểm tra hàm IsValidateOder xem có lỗi gì không (throw), nếu như không có là pass.

# Nguyên lý SRP đem lại khá nhiều lợi ích về về clean code, dễ bảo trì, mở rộng code. Tiết kiệm thời gian trong việc bổ sung chức năng, testing.

# Để chứng minh được việc tiết kiệm thời gian trong việc mở rộng code thì hãy xem:
# Ví dụ như bạn có một hàm ValidateOrder (Ban đầu chỉ kiểm trả là orderId, productId có tồn tại không), sau đó nhận được một yêu cầu từ khách hàng là phải bổ sung validate cho hàm đó (phải thêm orderId>=1, 0<price<1000000000000),
# Chúng ta chỉ cần thêm vào logic trong hàm ValidateOrder thỏa mãn yêu cầu thay vì phải thêm nhiều if else or switch case trong code chính --> nhìn rối mắt, phá vỡ nguyên lý của SRP.

# Tiếp theo tôi đang hướng đến nguyên lý O trong SOLID. Mục đích là tìm hiểu hết tất cả các nguyên lý về SOLID và thực hành nó vào trong dự án thực tế.

# Author: Huỳnh Anh Khoa, 26/9/2025
# Contract: huynhanhkhoa30042019@gmail.com
# Facebook cá nhân: https://www.facebook.com/
# Facebook công việc: https://www.facebook.com/





