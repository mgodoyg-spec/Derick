using System;
using System.Reflection;
using System.Windows.Forms;

namespace Derick
{
    internal static class csSesion
    {
        public static int ObtenerIdEmpleadoActual()
        {
            try
            {
                foreach (Form formulario in Application.OpenForms)
                {
                    // Buscar el menú de empleados que está abierto
                    if (formulario is FrmMenuEmpleados)
                    {
                        Type tipo = formulario.GetType();

                        // Posibles nombres que puede tener la variable
                        string[] nombres =
                        {
                            "idEmpleadoActual",
                            "IdEmpleadoActual",
                            "idEmpleado",
                            "IdEmpleado"
                        };

                        foreach (string nombre in nombres)
                        {
                            // Buscar como campo
                            FieldInfo campo = tipo.GetField(
                                nombre,
                                BindingFlags.Instance |
                                BindingFlags.NonPublic |
                                BindingFlags.Public
                            );

                            if (campo != null)
                            {
                                object valor = campo.GetValue(formulario);

                                if (valor != null &&
                                    int.TryParse(valor.ToString(), out int id))
                                {
                                    return id;
                                }
                            }

                            // Buscar como propiedad
                            PropertyInfo propiedad = tipo.GetProperty(
                                nombre,
                                BindingFlags.Instance |
                                BindingFlags.NonPublic |
                                BindingFlags.Public
                            );

                            if (propiedad != null)
                            {
                                object valor =
                                    propiedad.GetValue(formulario);

                                if (valor != null &&
                                    int.TryParse(valor.ToString(), out int id))
                                {
                                    return id;
                                }
                            }
                        }
                    }
                }

                return 0;
            }
            catch
            {
                return 0;
            }
        }
    }
}