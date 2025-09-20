using TrainCode.DB;
using TrainCode.Log;
using TrainCode.Notification;
using TrainCode.Services;
using TrainCode.Status;
using TrainCode.Validator;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Trong trường hợp này tui sử dụng AddSingleton tại vì đây là chỉ lưu tạm thời dưới dạng list thôi
// Trong trường hợp sử dụng AddScoped thì khi làm việc với database
//Trong trường hợp class có chứa dependency hoặc là Controller có chứa inject (tiêm vào) thì mới đăng ký
builder.Services.AddSingleton<OrderManager>();
builder.Services.AddSingleton<Validate>(); // ← THÊM DÒNG NÀY
builder.Services.AddSingleton<OrderRespository>();
builder.Services.AddSingleton<LogOrder>();
builder.Services.AddSingleton<NotifyOrder>();
builder.Services.AddSingleton<StatusOrder>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
