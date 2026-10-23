double compra = 80000;
bool esFrecuente = true;
int descuento = 0;

if (compra >= 500000)
{
    descuento = 15;
}
else if (compra >= 200000)
{
    descuento = 10;
}
else if (compra >= 100000)
{
    descuento = 5;
}

if (esFrecuente && compra >= 100000)
{
    descuento += 5;
}

double total = compra - (compra * descuento / 100);

Console.WriteLine($"Compra: ${compra:N0} | Descuento: {descuento}% | Total: ${total:N0}");
