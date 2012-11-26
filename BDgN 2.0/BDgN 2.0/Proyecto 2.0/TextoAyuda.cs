using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class TextoAyuda
    {
        public static String m_bienvenido="Bienvenido: \nEste cuadro mostrará mensajes de ayuda para un mejor uso del programa.";
        public static String m_inventario = "Botón Inventario: \nMostrará todo el inventario actual en su empresa.";
        public static String m_precios = "Botón Precios: \nSirve para establecer los precios de sus productos en dolares o pesos, además contiene una función para conversión de dolares a pesos y viceversa.";
        public static String m_clasificacion = "Botón Clasificación: \nAqui usted podrá crear las diferentes clasificaciones de sus productos,además podrá ingresas las bodegas donde se guardaran los articulos";
        public static String m_cliente = "Botón Cliente: \nPuede agregar nuevas facturas de clientes";
        public static String m_hcliente = "Botón Historial Cliente: \nMostrará el historial resumido de las ventas realizadas en un periodo de tiempo o por algún cliente.";
        public static String m_proveedor = "Botón Proveedor: \nPuede agregar nuevas facturas de proveedores, además de agregar directamente sus productos por este medio.También puede ingresar guias de despacho";
        public static String m_hproveedor = "Botón Historial Proveedor: \nMostrará el historial resumido de las compras realizadas en un periodo de tiempo o por algún proveedor.";
        public static String m_bfactura = "Botón Factura: \nPodrá buscar alguna factura ingresada al sistema.";
        public static String m_guia = "Botón Guia: \nProdrá ver las guias ingresadas y ser modificadas para guardarlas como facturas.";

        public static String clasificacion= "Bienvenido\n\nUsted puede agregar las clasificaciones que estime convenientes en el sistema, además de agregar las bodegas que quiera.";
        public static String clasif_clasificacion = "\n\nSección Clasificación:\n\nPara agregar una nueva clasificación debe escribir el nombre de la nueva clasificación y presionar el botón Agregar.\nPara borrar una Clasificación debe seleccionarla en el menú Clasificaciones y luego presionar el botón borrar.Si desea borrar una clasificación PADRE debe borrar con anterioridad todas las las subclasificaciones de este.\n\nNo prodrá borrar clasificaciones si ya esta asiganada a algún producto";
        public static String clasif_subclasificacion = "\n\nSección Sub-Clasificación:\n\nPara agregar una nueva Subclasificación debe selecciónar la clasificación PADRE en el menú Clasificaciones luego escribir el nombre de la nueva subclasificación para finalmente presionar el botón agregar.\nPara borrar una subclasificación debe seleccionar la subclasificación en el menú Clasificaciones y presionar el botón borrar.";
        public static String clasif_bodega= "\n\nSección Bodega:\n\nPara agregar una nueva bodega debe escribir el nombre de la bodega y presionar el botón agregar.";

        public static String Precio = "Bienvenido\n\nUsted podrá modificar los precios de sus podructos, además de usar la función de conversión de dolares a pesos.";
        public static String p_modificacion = "\n\nTabla:\n\nPuede modificar los precios en pesos y dolares de todos los productos mostrados en la tabla.";
        public static String p_funcion = "\n\nFunción Dolares-Pesos:\n\nUsted debe ingresar el precio del dólar actual, luego presiona el botón conversión para observar en la tabla la modificación de los precios en pesos";
        public static String p_actualización = "\n\nBotón Actualización:\n\nSi desea guardar los cambios realizados en sus productos presione el botón actualizar.";

        public static String Historial_Cliente = "Historial del Cliente\n\nBotón buscar:\n\nDebe ingresar dos fechas cualquiera y luego presionar el botón buscar.\n\nTabla de Clientes:\n\nMuestra la información de cada cliente. También puede visualizar la factura haciendo doble click sobre la información correspondiente.";
        
        public static String Historial_Proveedor = "Historial del Proveedor\n\nBotón buscar:\n\nDebe ingresar dos fechas cualesquiera y luego presionar el botón buscar.\n\nTabla de Clientes:\n\nMuestra la información de cada proveedor. También puede visualizar la factura haciendo doble click sobre la información correspondiente.";

    }
}
