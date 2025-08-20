# 🛍️ Sistema de Gestión de Local Comercial

Este sistema fue desarrollado en **C# con Windows Forms** y **Base de Datos Access**, con el objetivo de brindar una herramienta completa para la administración de un comercio.  
Incluye la gestión de stock, ventas, facturación y datos del local.

---

## 📌 Funcionalidades principales

El sistema se divide en 4 secciones principales:

---

### 1️⃣ Stock
Permite gestionar todos los productos disponibles en el local.

- **Agregar nuevo producto**  
  Se pueden cargar productos indicando:  
  - Nombre del producto 
  - Precio unitario  

- **Modificar stock**  
  Permite actualizar la cantidad de un producto existente (agregar o eliminar).  
  Ejemplo: si entran nuevas unidades de un producto, se puede sumar al stock.  

- **Consultar stock**  
  Opción para buscar un producto por **nombre** y ver la información detallada: codigo del producto, nombre, cantidad y precio.

---

### 2️⃣ Ventas
Gestión completa de las operaciones de ventas.

- **Cargar venta**  
  Se selecciona:
  - Fecha de la venta (con calendario)  
  - Producto (desde un ComboBox)  
  - Medio de pago (efectivo, tarjeta, etc.)  
  - Cantidad  
  - Monto total  
  ✅ La venta se guarda automáticamente en la tabla **Ventas**.  

- **Consultar venta**  
  Permite buscar ventas realizadas por:
  - Fecha  
  - Medio de pago  

- **Gráfico de todas las ventas**  
  Genera un gráfico general con todas las ventas registradas en el sistema.  

- **Gráfico de ventas por fecha**  
  Permite seleccionar una fecha específica para ver el rendimiento de ventas en ese día.

---

### 3️⃣ Facturación
Sección destinada a los clientes y la generación de comprobantes.

- **Ingresar nuevo cliente**  
  Permite registrar clientes indicando:  
  - Nombre y apellido  
  - DNI o CUIT  
  - Domicilio
  - Email  

- **Generar facturas**  
  A partir de las ventas registradas se pueden generar facturas asociadas a un cliente específico.

---

### 4️⃣ Datos del local
Incluye dos integraciones con APIs externas para mayor interactividad:

- **Ubicación en Google Maps**  
  Abre un enlace directo a Google Maps mostrando la ubicación exacta del local.  

- **Instagram del local**  
  Enlace directo a la cuenta oficial de Instagram del comercio para facilitar la interacción con los clientes.

---

## 📊 Visualización de datos

- **ListBox y DataGridView**:  
  - El sistema lista en tiempo real los productos, ventas y clientes.  

- **Exportación de datos**:  
  Es posible exportar:
  - Todos los datos cargados  
  - Datos filtrados por fecha o producto  

---

## 👩‍💻 Autora
**Valentina Molina**  
📍 Córdoba, Argentina  
🔗 [LinkedIn](https://www.linkedin.com/in/valentinamolina)  
