var builder = WebApplication.CreateBuilder(args); // hasteh asli barnameh ro misazad

builder.Services.AddControllers(); // controller ha ra sabt mikonad - haman class hayi ke endpoint haye ma tooshonan
builder.Services.AddEndpointsApiExplorer(); // lazem ast Swagger endpoint haye ma ra peyda konad
builder.Services.AddSwaggerGen(); // safhe test API ra ezafe mikonad

var app = builder.Build(); // ba tanzimati ke dadim barname ro misazad

if (app.Environment.IsDevelopment()) // faghat dar mohite development in karo bokon
{
    app.UseSwagger(); // fayl json marboot be API ra serve mikonad
    app.UseSwaggerUI(); // safhe bosaari Swagger ra neshon midahad
}

app.UseHttpsRedirection(); // har request rooye http ra be https hedayat mikonad

app.UseAuthorization(); // check mikonad karbr ejaze dastresi be in endpoint ra darad ya na

app.MapControllers(); // be barname migoyad controller ha ra peyda konad va route hashon ra sabt konad

app.Run(); // barname ra ejra mikonad va montazer request mimaned