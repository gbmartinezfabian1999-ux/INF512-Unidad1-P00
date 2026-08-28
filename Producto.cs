using System;

public class Producto
{
    // Atributos privados
    private string nombre;
    private decimal precio;
    private int cantidad;

    // Constructor
    public Producto(string nombre, decimal precio, int cantidad)
    {
        this.nombre = nombre;
        this.precio = precio;
        this.cantidad = cantidad;
    }

    // Método para mostrar la información del producto
    public void MostrarInformacion()
    {
        Console.WriteLine("=== INFORMACIÓN DEL PRODUCTO ===");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Precio: RD${precio:N2}");
        Console.WriteLine($"Cantidad: {cantidad}");
    }

    // Método para agregar productos
    public void AgregarCantidad(int cantidad)
    {
        if (cantidad > 0)
        {
            this.cantidad += cantidad;
            Console.WriteLine("Cantidad agregada correctamente.");
        }
        else
        {
            Console.WriteLine("La cantidad debe ser mayor que cero.");
        }
    }

    // Método para cambiar el precio
    public void CambiarPrecio(decimal nuevoPrecio)
    {
        if (nuevoPrecio > 0)
        {
            precio = nuevoPrecio;
            Console.WriteLine("Precio actualizado correctamente.");
        }
        else
        {
            Console.WriteLine("El precio debe ser mayor que cero.");
        }
    }
}
