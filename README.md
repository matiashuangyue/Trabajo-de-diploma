# STAR CG (Sistema de Gestión y Punto de Venta para Supermercado)

Este proyecto es un sistema de gestión y punto de venta (POS) desarrollado para un supermercado. El sistema permite la administración de compras, ventas y control de stock de mercaderías. Además, incluye características como inicio de sesión seguro, informes sobre ventas y stock, solicitud de compras, gestión de pedidos y control de caja.

## Características

- **Inicio de Sesión Seguro**: Sistema de autenticación de usuarios con roles y permisos.
- **Gestión de Ventas y Compras**: Registro de ventas y compras con actualización automática del stock.
- **Control de Stock**: Monitoreo del inventario con alertas de bajo stock.
- **Informes**: Generación de informes sobre ventas y stock.
- **Gestión de Pedidos**: Control y seguimiento de pedidos realizados.
- **Control de Caja**: Registro y control del flujo de caja.




## Requisitos

- **Backend**: C#
- **Frontend**: Windows Form , FramWork
- **Base de Datos**: Sql Server

## Instalación

1. ### Clonar el repositorio:
   ```bash
   git clone https://github.com/matiashuangyue/Trabajo-de-diploma.git

2. ### Instrucciones para Importar Base de datos

Para Importar archivo de base de datos a tu SQL Server, sigue estos pasos:

      1. Abre SQL Server Management Studio (SSMS) y conéctate a la instancia de SQL Server.
      2. Expande la carpeta "Bases de datos" y selecciona "Import Data-tier Application...".
      3. En el asistente de importación, selecciona "Next".
      4. Elige la opción "Import from local disk" y selecciona el archivo .bacpac proporcionado en la carpeta database.
      5. Sigue los pasos del asistente para completar la importación de la base de datos.
   
3. ### Cambiar Link de Sql Server
   - entrar al carpeta de MODELO, archivo ' ConexionSQL.cs ', codigo linea 17 Cambiarlo por tu connexion!!!!!!!!!!!!
   - ejemplo:
   - string cnn = "Data Source=NombreDelServidor\\NombreDeLaInstancia; Initial Catalog=NombreDeLaBaseDeDatos; Integrated Security=True;";

   
Con estas instrucciones, Ustedes podrás importar la base de datos en su entorno local después de clonar el repositorio.
