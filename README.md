Sistema de Gestión y Punto de Venta para Supermercado
Este proyecto es un sistema de gestión y punto de venta (POS) desarrollado para un supermercado. El sistema permite la administración de compras, ventas y control de stock de mercaderías. Además, incluye características como inicio de sesión seguro, informes sobre ventas y stock, solicitud de compras, gestión de pedidos y control de caja.

Características
Inicio de Sesión Seguro: Sistema de autenticación de usuarios con roles y permisos.
Gestión de Ventas y Compras: Registro de ventas y compras con actualización automática del stock.
Informes: Generación de informes sobre ventas y stock.
Gestión de Pedidos: Control y seguimiento de pedidos realizados.
Gestión de Permisos：Gestion y control de manera seguro y eficiente.
Control de Caja: Registro y control del flujo de caja.
Estructura de la Base de Datos
El sistema utiliza una base de datos relacional con las siguientes tablas principales:

Usuario

DNI (Primary Key)
Nombre
Contrasena
ID_Rol (Foreign Key hacia Roles)
ID_Estado
Roles

ID (Primary Key)
Roles
Permisos

ID (Primary Key)
Permisos
Roles_Permisos

ID (Primary Key)
ID_Rol (Foreign Key hacia Roles)
ID_Permiso (Foreign Key hacia Permisos)
Auditoria

ID (Primary Key, Foreign Key hacia Usuario)
DNI
TimeLogin
TimeLogout
Diagrama Entidad-Relación

Requisitos
Backend: [C#]
Frontend: [Windows Form]
Base de Datos: [SQL Servel]
Instalación
Clonar el repositorio:


git clone [[https://github.com/usuario/nombre-del-repo.git](https://github.com/matiashuangyue/Trabajo-de-diploma.git)]
Instalar dependencias del backend:


cd nombre-del-repo/backend
npm install
Instalar dependencias del frontend:


cd ../frontend
npm install
Configurar la base de datos:

Crear una base de datos en MySQL.
Ejecutar los scripts SQL proporcionados en scripts/sql/ para crear las tablas y los datos iniciales.
Configurar variables de entorno:

Crear un archivo .env en la carpeta del backend con las siguientes variables:
env
DB_HOST=localhost
DB_USER=root
DB_PASSWORD=tu_contraseña
DB_NAME=nombre_de_la_base_de_datos
Iniciar el backend:

cd ../backend
npm start
Iniciar el frontend:


cd ../frontend
npm start
Uso
Acceder al sistema desde un navegador web en http://localhost:3000.
Iniciar sesión con las credenciales proporcionadas.
Navegar por las diferentes secciones del sistema para gestionar ventas, compras, stock, usuarios, etc.
Contribuciones
Las contribuciones son bienvenidas. Por favor, abre un issue o envía un pull request para cualquier mejora o corrección.

Licencia
Este proyecto está licenciado bajo la [Licencia].
