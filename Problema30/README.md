### Problema 30. Boletín de calificaciones (integrador)

Un instructor registra tres notas de un aprendiz (0 a 100). El programa debe:

1. Calcular el promedio.
2. Convertir el promedio a letra: 90 o más → A, 80 a 89 → B, 70 a 79 → C, 60 a 69 → D, menos de 60 → F.
3. Según la letra, imprimir un mensaje de retroalimentación: A → `Desempeño excelente`; B o C → `Buen desempeño, sigue así`; D → `Aprobado, refuerza los temas`; F → `Debe presentar plan de mejoramiento`.
4. Indicar `Aprobado` o `Reprobado` (aprueba con 60 o más).
5. Si el promedio es exactamente 100, mostrar adicionalmente `¡Mención de honor!`.

Ejemplo: notas 85, 78, 92 → `Promedio: 85,0 | Letra: B | Buen desempeño, sigue así | Aprobado`

**Estructura elegida:** estructura if-else if-else

**Justificación:** concisa y legible.

**Evidencia:**
![Salida](evidencias/image.png)
