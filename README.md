# crudMysql

Crud con .Net core, C#, Entity framework, mysql.
Pasos:

1. Crear un proyecto ASP.Net core web aplication (MVC)
2. Instalar los nugets pomelo.entityF..C...mysql y tools de entity framework core.
3. Creamos la DB y las tablas en mysql.
4. Entramos a la consola del nugget y hacemos el mapeo de la DB. Ej: Scaffold-DbContext "Server = localhost; port=3306; database = prueba; uid = prueba; password = prueba" Pomelo.EntityFrameworkCore.MySql -o Models
5. Movemos el connection string al Json para mejorar la seguridad.En este artículo explican como modificar el Json y el program.  http://go.microsoft.com/fwlink/?LinkId=723263
6. Ahora agregamos un controlador para cada tabla que hemos creado, vamos a la carpeta controller, añanadimos un controlador, escogemos la opción de vistas con Entity framework, para que este cree todo, seleccionamos la tabla en el modelo y en el contexto, igual, escogemos el que se creo con la misma tabla y agregar.
7. En view, modificamos el layout y le agregamos otro campo al menú para que acceda a nuestro controlador, le cambiamos la dirección y la acción al campo, para que nos dirija al controlador de nuestra tabla.
8. Vamos al index de nuestro crud y modificamos lo que queramos.
9. Ya ejecutamos y debería funcionar.
