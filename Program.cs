string frasedigitada, frasecensurada;
Console.Write("escreva um discurso de ódio: ");

frasedigitada = Console.ReadLine()!;
 frasecensurada = frasedigitada

.Replace("chato", "*#@*!$")
.Replace("chata", "*#@*!$")
.Replace("boba", "*#@*!$")
.Replace("feio", "*#@*!$")
.Replace("feia", "*#@*!$")
.Replace("boboca", "*#@*!$")
.Replace("bocó", "*#@*!$")
.Replace("tonto", "*#@*!$")
.Replace("tonta", "*#@*!$")
.Replace("palerma", "*#@*!$")
.Replace("paspalho", "*#@*!$")
.Replace("paspalha", "*#@*!$")
.Replace("tantã", "*#@*!$")
.Replace("panaca", "*#@*!$")
.Replace("pentelho", "*#@*!$")
.Replace("pentelha", "*#@*!$")
.Replace("burro", "*#@*!$")
.Replace("burra", "*#@*!$")
.Replace("besta", "*#@*!$");

Console.WriteLine(frasecensurada );
