# VideogameStockApp

## Descripción
VideogameStockApp es un conjunto de aplicaciones cliente-servidor diseñado para la gestión de reservas de videojuegos. La solución servidor actúa como administrador central, mientras que la solución cliente permite a los usuarios realizar reservas de videojuegos. La aplicación gestiona registros de administradores, tiendas, clientes, videojuegos, tipos de videojuegos, inventario y reservas, además de permitir consultas sobre estos elementos.

## Características
- **Servidor**: gestiona la administración de la aplicación (excepto reservas), incluyendo inserción y consultas con conexión a una base de datos SQL Server mediante ADO.NET.
- **Cliente**: solicita reservas y accede a información relevante desde el servidor.
- **Conexión**: el servidor se ejecuta utilizando el protocolo TCP/IP.
- **Sincronización**: control de concurrencia mediante semáforos y mutexes para gestionar accesos simultáneos.

## Instalación
**Requisitos previos**:

- .NET 8.0
- Microsoft SQL Server Management Studio (SSMS)
- Paquetes NuGet: System.Data.SqlClient y Newtonsoft.Json (para serialización y deserialización de comunicaciones entre cliente y servidor)


## Estructura del proyecto
VideogameStockApp/
│── 45GAMES4UCliente/        # Solución del cliente
│── 45GAMES4UServidor/       # Solución del servidor
│── EntidadesCompartidas/    # Biblioteca de clases compartida entre cliente y servidor

Cada solución cuenta con sus propias capas de:
-AccesoDatos
-Presentación
-Negocio
-Entidades: la carpeta EntidadesCompartidas contiene una biblioteca de clases en formato DLL accesible para ambas soluciones.


## Uso
- Configuración del servidor:
 Registrar tipos de videojuegos antes de registrar videojuegos.
 Registrar administradores y tiendas para gestionar inventario.

- Uso del cliente:
 Registrar clientes para permitir conexión con el servidor.
 Conectarse al servidor para habilitar el registro y la consulta de reservas.

## Concurrencia
- Permite múltiples clientes simultáneos mediante un semáforo (5/5).
- Control de acceso administrativo mediante un mutex.
- Gestión de comunicación y pantalla de inicio del servidor con hilos y métodos delegados para evitar bloqueos.

## Tecnologías Utilizadas
- **Lenguaje**: C#
- **Frameworks**: .NET 8.0, Windows Forms, ADO.NET, Newtonsoft.Json (para serialización)
- **Base de datos**: SQL Server con Microsoft SSMS

(Nota: El script de creación de la base de datos fue proporcionado por profesores de la UNED y no puede compartirse en el repositorio.)

##Licencia
Licencia MIT

Derechos de Autor (c) [2025] [Fernando Hernández]

Por la presente se concede permiso, sin cargo, a cualquier persona que obtenga una copia
de este software y archivos de documentación asociados (el "Software"), para tratar
en el Software sin restricciones, incluyendo sin limitación los derechos
para usar, copiar, modificar, fusionar, publicar, distribuir, sublicenciar, y/o vender
copias del Software, y para permitir a las personas a quienes se les proporcione el Software
hacerlo, sujeto a las siguientes condiciones:

El aviso de copyright anterior y este aviso de permiso deberán ser incluidos en todas
las copias o porciones sustanciales del Software.

EL SOFTWARE SE PROPORCIONA "TAL CUAL", SIN GARANTÍA DE NINGÚN TIPO, EXPRESA O
IMPLÍCITA, INCLUYENDO PERO NO LIMITÁNDOSE A LAS GARANTÍAS DE COMERCIALIZACIÓN,
IDONEIDAD PARA UN PROPÓSITO PARTICULAR Y NO INFRACCIÓN. EN NINGÚN CASO LOS
AUTORES O TITULARES DEL COPYRIGHT SERÁN RESPONSABLES DE NINGUNA RECLAMACIÓN, DAÑO U OTRA
RESPONSABILIDAD, YA SEA EN UNA ACCIÓN DE CONTRATO, AGRAVIO O DE OTRO MODO, QUE SURJA DE,
FUERA O EN CONEXIÓN CON EL SOFTWARE O EL USO U OTROS TRATOS EN EL
SOFTWARE.

MIT License

Copyright (c) [2025] [Fernando Hernández]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
