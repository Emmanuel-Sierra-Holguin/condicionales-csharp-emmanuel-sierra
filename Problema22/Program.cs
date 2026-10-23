int a = 5;
int b = 2;
char operador = '%';
int resultado;

switch (operador)
{
    case '+': resultado = a + b; break;
    case '-': resultado = a - b; break;
    case '*': resultado = a * b; break;
    case '/':
        if (b == 0) throw new DivideByZeroException("No se puede dividir entre cero");
        resultado = a / b;
        break;
    default:
        throw new InvalidOperationException("Operador no soportado");
}

Console.WriteLine($"{a} {operador} {b} = {resultado}");