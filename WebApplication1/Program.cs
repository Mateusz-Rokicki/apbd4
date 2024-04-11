using Microsoft.AspNetCore.Mvc;
using WebApplication1.DB;
using WebApplication1.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Needed for controller base approach
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// GET /api/students
// app.MapGet("/api/students", () =>
// {
//     return Results.Ok(Db.Students);
// });

// GET /api/students/1
// app.MapGet("/api/students/{id:int}", (int id) =>
// {
//     var student = Db.Students.FirstOrDefault(st => st.Id == id);
//     return student is null ? Results.NotFound() : Results.Ok(student);
// });

// POST api/students
// app.MapPost("/api/students", ([FromBody] Student student) =>
// {
//     Db.Students.Add(student);
//     return Results.Created($"/api/students/{student.Id}", student);
// });

// PUT api/students/1
// app.MapPut("/api/students/{id:int}", (int id, [FromBody] Student data) =>
// {
//     var student = Db.Students.FirstOrDefault(st => st.Id == id);
//     if (student is null) return Results.NotFound($"Student with id {id} not found");
//     
//     student.Name = data.Name;
//     student.Email = data.Email;
//     return Results.Ok(student);
// });

// app.MapDelete("/api/students/{id:int}", (int id) =>
// {
//     var students = Db.Students.Where(st => st.Id != id);
//     Db.Students = students.ToList();
//     return Results.Ok();
// });

// app.MapGet("/api/students/{id:int}/appointments", (int id) =>
// {
//
// });

// app.MapPost("/api/stuednts/{id:int}/appointments", 
//     (int id, [FromBody] Appointment appointment) =>
// {
//
// });

// Needed for controller base approach
app.MapControllers();

app.UseHttpsRedirection();

app.Run();