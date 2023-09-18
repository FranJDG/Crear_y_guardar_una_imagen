using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crear_y_guardar_una_imagen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = 200;  // Ancho de la imagen
            int height = 200; // Alto de la imagen
            string name = "Fran Díaz"; // Tu nombre

            // Crear un nuevo objeto Bitmap con el ancho y alto especificados
            using (Bitmap bitmap = new Bitmap(width, height))
            {
                // Crear un objeto Graphics a partir del bitmap
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    // Definir un fondo de color
                    graphics.Clear(Color.Black);

                    // Definir un color de texto
                    Color textColor = Color.FromArgb(255, 255, 0, 0); // Rojo

                    // Crear una fuente y un pincel para el texto
                    using (Font font = new Font("Arial", 24))
                    using (SolidBrush brush = new SolidBrush(textColor))
                    {
                        // Dibujar el nombre en el centro de la imagen
                        SizeF textSize = graphics.MeasureString(name, font);
                        PointF textLocation = new PointF((width - textSize.Width) / 2, (height - textSize.Height) / 2);
                        graphics.DrawString(name, font, brush, textLocation);
                    }
                }

                // Guardar la imagen generada
                bitmap.Save("perfil_friki.png");
            }

            Console.WriteLine("Imagen de perfil generada con éxito. ¡Revísala en tu directorio de trabajo!");
        }
    }
}
