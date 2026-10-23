### Problema 26. Peaje

Un peaje identifica el vehículo con una letra y asigna la tarifa a cobrar:

- ‘M’ moto: $0 (exenta)
- ‘A’ automóvil: $12.000
- ‘B’ bus: $25.000
- ‘C’ camión: $38.000
- Otra letra: se lanza una excepción con el mensaje `Categoría desconocida`

Imprime `Categoría X - Tarifa: $Y`.

**Estructura elegida:** switch expression

**Justificación:** concisa y legible.

**Evidencia:**
![Salida](evidencias/image.png)
