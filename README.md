# TP1-FI13005258 Cálculo del Número Áureo con Fibonacci (C#)

Este progrma de consola en C# permite calcular el numero phi utilizando tanto la ecuación de binet y las aproximaciones con la secuencia de Fibonacci.
El programa solicita un numero entre 2 y 45, valida el numero y despliega los resultados. 

## 🧠 Funcionalidad

- Solicita un número entero entre 2 y 45.
- Calcula phi usando la ecuacion de binet: (1 + √5) / 2.
- Calcula valores de Fibonacci hasta `n` ingresado por el usuario.
- Muestra divisiones consecutivas de Fibonacci como aproximación de phi y su diferencia con el valor exacto.
- Muestra los valores de Fib(n) y Fib(n-1) en resumen el numero ingresado y el anterior a este.
- Implementa validación con `try-catch` para evitar errores al ingresar valores no válidos y que no se caiga por ingresar valores incorrectos.

## 📁 Estructura del proyecto

- `Program.cs`: Archivo principal con el código fuente.
- `README.md`: Documentación del proyecto.


https://github.com/EduardoCR1994/TareaProgramada1.git
---

## 🌐 Recursos consultados

- [Documentación oficial de C# - try-catch](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch)
- [Wolfram MathWorld - Golden Ratio](https://mathworld.wolfram.com/GoldenRatio.html)
- [Math.Sqrt en C#](https://learn.microsoft.com/en-us/dotnet/api/system.math.sqrt)

---

## 🤖 Asistentes de IA utilizados

### ChatGPT (OpenAI)

**Prompts utilizados:**
- “¿Cómo calcular el número áureo usando la secuencia de Fibonacci en C#?”
- “¿Cómo hacer validaciones con try-catch para evitar que se caiga el programa?”
- “¿Cómo Realizar un README de manera profecional?”

**Respuestas obtenidas:**
- Ayuda para implementar la validación de rango con un bucle `while`.
- Sugerencias para usar `Math.Sqrt(5)` y comentarios sobre la fórmula de phi.
- Recomendaciones para mostrar mensajes más amigables en español en errores.
- Un README profesional debe incluir una descripción clara del proyecto, instrucciones de uso, estructura del repositorio, dependencias necesarias, ejemplos de ejecución y créditos.
- Se recomienda usar títulos (`#`), listas, bloques de código y enlaces para una presentación limpia y comprensible.
---

> Realizado como parte del curso de Programación Avanzada con C# y .NET Framework. Universidad Fidélitas.
