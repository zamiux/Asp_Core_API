var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();


#region Change Retrn type api
builder.Services.AddControllers(options =>
{
    //options.InputFormatters.Add(); // mifahmooni ke default api be soorat XML ya Json bashe. 

    // in ye feature ke be API mige man dar return har 2 type(xml,json) change mide
    options.ReturnHttpNotAcceptable = true;
}).AddXmlSerializerFormatters();  // hatman oon api ke call mikoni in project az XML support kone. 
// ama be ssorate Default Json Hastesh.
#endregion
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

//app.MapControllers();


//  Controller/Action/id?

app.UseEndpoints(endpoints => { 
    endpoints.MapControllers();
});

app.Run();
