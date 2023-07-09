// CONSTRUTOR DA APLICA��O
var builder = WebApplication.CreateBuilder(args);

// ADI��O DE SUPORTE A P�GINAS RAZOR
builder.Services.AddRazorPages();

// CONSTRUIR A APLICA��O
var app = builder.Build();

// SERVIDOR HTTPS
app.UseHttpsRedirection();

// ARQUIVOS DO wwwroot
app.UseStaticFiles();

// SUPORTE PARA CRIAR URL's CUSTOMIZADAS
// DAR UM NOME SIMPLES PARA UMA P�GINA, E O .NET CONSEGUIR ENCONTR�-LA DE MANEITA AUTOM�TICA
app.UseRouting();
app.MapRazorPages();

// EXECUTA A APLICA��O
app.Run();
