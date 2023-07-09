// CONSTRUTOR DA APLICA플O
var builder = WebApplication.CreateBuilder(args);

// ADI플O DE SUPORTE A P핯INAS RAZOR
builder.Services.AddRazorPages();

// CONSTRUIR A APLICA플O
var app = builder.Build();

// SERVIDOR HTTPS
app.UseHttpsRedirection();

// ARQUIVOS DO wwwroot
app.UseStaticFiles();

// SUPORTE PARA CRIAR URL's CUSTOMIZADAS
// DAR UM NOME SIMPLES PARA UMA P핯INA, E O .NET CONSEGUIR ENCONTR�-LA DE MANEITA AUTOM햀ICA
app.UseRouting();
app.MapRazorPages();

// EXECUTA A APLICA플O
app.Run();
