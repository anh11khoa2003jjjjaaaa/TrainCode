# TrainCode: Áp Dụng SRP Để Refactor API /create-order Theo Chuẩn SOLID

# Mô Tả
# Dự án refactor endpoint /create-order (e-commerce) theo Single Responsibility Principle (SRP) trong SOLID, nhằm tạo code sạch, dễ test, bảo trì và mở rộng. Lý do chính: Hướng đến code chuyên nghiệp, tránh God Class, mỗi method/class chỉ đảm nhận một nhiệm vụ duy nhất (e.g., Validate chỉ kiểm tra input).

# Mục Tiêu
# Tách logic /create-order thành các class độc lập (Validate, OrderLogger, v.v.) theo SRP.
# Viết unit test với xUnit để đảm bảo chất lượng (coverage >80%).
# Tiết kiệm thời gian bảo trì (e.g., sửa rule validate chỉ mất 5 phút thay vì 30 phút).

# Cấu Trúc Code

# Trước refactor: OrderManager xử lý 5 nhiệm vụ (validate, lưu DB, log, notify, stats), vi phạm SRP.

# Sau refactor: Tách thành 5 class:

# Validate: Kiểm tra input (userId > 0, productId > 0, totalPrice >= 0).
# OrderRepository: Lưu order vào List.
# OrderLogger: Ghi log order vào Console.
# NotificationService: Gửi thông báo (email/Slack).
# OrderStatsService: Cập nhật thống kê (TotalOrders).
# File chính: Validate.cs, OrderLogger.cs, OrderValidatorTests.cs, OrderLoggerTests.cs.

# Công Nghệ

# Ngôn ngữ: C#.
# Framework: ASP.NET Core API, .NET 8.0.
# Test: xUnit (Assert.Throws, Assert.Contains).
# IDE: Visual Studio.

# Cài Đặt

# Clone repository:
# git clone https://github.com/anh11khoa2003jjjjaaaa/TrainCode.git
# Restore dependencies:

# dotnet restore

# Build dự án:

# dotnet build

# Sử Dụng

# Set Startup Project: Right-click solution TrainCode → Set as Startup Project → Run (F5).
# Test API: Swagger tại https://localhost:7001/OrderSRP?userId=3&productId=1&quantity=4&totalPrice=7.
# Chạy test: Right-click TrainCode_unitest → Set as Startup Project → Test → Test Explorer → Run All Tests.

# Unit Test

# OrderValidatorTests.cs:
# IsValidateOder_InvalidUserId_ThrowsArgumentException: Kiểm tra throw ArgumentException khi userId <= 0.
# IsValidateOder_ValidData_DoesNotThrow: Kiểm tra không throw khi input hợp lệ.
# OrderLoggerTests.cs: LogOrderCreated_ValidOrder_ContainsUserIdInLog: Kiểm tra log chứa "UserId=1" (Assert.Contains).

# Kết quả: 3 test pass, coverage >80%.

# Lợi Ích SRP

# Testability: Test độc lập, không cần mock DB, đạt coverage >80%.
# Maintainability: Sửa rule validate (e.g., thêm quantity > 0) chỉ mất 5 phút, thay vì sửa God Class 30 phút.
# Scalability: Team lớn dễ phân chia công việc, tránh xung đột code.

# Ví Dụ Minh Họa

# Ban đầu: ValidateOrder kiểm tra orderId, productId tồn tại.
# Yêu cầu mới: Thêm orderId >= 1, 0 < price < 1000000000000.
# Với SRP: Chỉ sửa Validate.IsValidateOder, thêm if-else, không ảnh hưởng code chính.

# Kế Hoạch Tiếp Theo

# Áp dụng nguyên lý O (Open-Closed Principle) trong SOLID.
# Tích hợp Factory Pattern cho NotificationService.
# Thêm async/await cho I/O.

# Tác Giả

# Author: Huỳnh Anh Khoa
# Date: 26/9/2025
# Email: huynhanhkhoa30042019@gmail.com
# Facebook công việc: https://www.facebook.com/