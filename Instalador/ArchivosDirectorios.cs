using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Windows.Forms;
namespace Instalador
{
    public  class ArchivosDirectorios
    {
        public static int ObtenerNumerodeArchivos(string DirectorioOrigen, bool ObtenerSubDirectorios)
        {

            int suma = 0;
            string nombre = "";
            if (ObtenerSubDirectorios == false)
            {
                string[] files = System.IO.Directory.GetFiles(DirectorioOrigen);
                foreach (string s in files)
                {
                    suma++;
                    string NombreDelArchivo = System.IO.Path.GetFileName(s);
                    string DestinoDeArchivo = System.IO.Path.Combine(DirectorioOrigen, NombreDelArchivo);
                    nombre = nombre + Environment.NewLine + NombreDelArchivo;
                }
                return suma;
            }
            else
            {
                DirectoryInfo di = new DirectoryInfo(DirectorioOrigen);
                foreach (FileInfo info in di.GetFiles("*", SearchOption.AllDirectories))
                {
                    nombre = nombre + Environment.NewLine + info.FullName;
                    suma++;
                }
                return suma;
            }
        }

         int contarprogreso;
        public  void DirectoryCopy(string DirectorioOrigen, string DirectorioDestino, bool CopiarSubDirectorios,Label contarprogreso,ProgressBar progressbar,Label MostrarEStado,Label MuestrarutaArchivos,Label MuestraNombreArchivos)
        {

            // Obtener los subdirectorios del directorio especificado.
            DirectoryInfo Directorio = new DirectoryInfo(DirectorioOrigen);

            if (!Directorio.Exists)
            {
                throw new DirectoryNotFoundException(
                    "El directorio de origen no exite o no se pudo encontrar: "
                    + DirectorioOrigen);
            }

            DirectoryInfo[] dirs = Directorio.GetDirectories();

            // Si no existe el directorio de destino, lo crea.
            if (!Directory.Exists(DirectorioDestino))
            {
                Directory.CreateDirectory(DirectorioDestino);
            }

            string[] files = System.IO.Directory.GetFiles(DirectorioOrigen);

            foreach (string s in files)
            {
                this.contarprogreso++;
                //indica donde se va a mostrar en progreso
                contarprogreso.Text = this.contarprogreso.ToString();

                string NombreDelArchivo = System.IO.Path.GetFileName(s);
                MuestraNombreArchivos.Text = NombreDelArchivo;
                string DestinoDeArchivo = System.IO.Path.Combine(DirectorioDestino, NombreDelArchivo);
                MuestrarutaArchivos.Text = DestinoDeArchivo;
                CopiarProgreso(s, DestinoDeArchivo, 1024 * 40, progressbar, MostrarEStado);
            }

            //recursiva
            // Condicion para copiar subdirectorios
            if (CopiarSubDirectorios)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(DirectorioDestino, subdir.Name);
                    //se pone contarprogreso en la recursiva para que no se reinicie el dato
                    DirectoryCopy(subdir.FullName, temppath, CopiarSubDirectorios, contarprogreso, progressbar, MostrarEStado, MuestrarutaArchivos, MuestraNombreArchivos);
                }
            }

        }

        public  bool CopiarProgreso(string rutaOrigen, string rutaDestino, int BufferSize, ProgressBar prg, Label lbl)
        {
            try
            {
                int segundos;
                double oldMB = 0.0F;
                double media = 0.0F;

                //Preparamos los filestreams. Uno para lectura y otro para escritura.
                FileStream ReadFile = new FileStream(rutaOrigen, FileMode.Open, FileAccess.Read);
                FileStream WriteFile = new FileStream(rutaDestino, FileMode.CreateNew, FileAccess.Write);

                int inicioLectura = 0;
                int tamañoBuffer = BufferSize;
                prg.Maximum = (Int32)ReadFile.Length;
                prg.Value = 0;
                byte[] buffer = new byte[tamañoBuffer];
                int result = 1;
                segundos = DateTime.Now.Second;

                while (result != 0)
                {
                    result = ReadFile.Read(buffer, 0, tamañoBuffer);
                    inicioLectura += tamañoBuffer;
                    prg.Value += result;
                    lbl.Text = "Copiados " + ConvertirByteEnMb(prg.Value).ToString() + " MB de " +
                                          ConvertirByteEnMb(prg.Maximum).ToString() + " MB";
                    lbl.Text += "         (" + ConvertirByteEnMb(media * 100).ToString() + " MB/seg)";

                    WriteFile.Write(buffer, 0, result);
                    if (Math.Abs(DateTime.Now.Second - segundos) < 1) //actualizamos los valores cada segundo
                    {
                        media = (media + (prg.Value - oldMB)) / 2;
                        segundos = DateTime.Now.Second;
                        oldMB = prg.Value;
                    }
                    Application.DoEvents();
                }

                ReadFile.Close();
                WriteFile.Close();
                ReadFile.Dispose();
                WriteFile.Dispose();

                lbl.Text = "Copia finalizada.";
                Application.DoEvents();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private  double ConvertirByteEnMb(double sizeBytes)
        {
            return Math.Round(Convert.ToDouble((sizeBytes / 1024) / 1024), 2);
        }
        /*
        private double ConvertToKb(double sizeBytes)
        {
            return Math.Round(Convert.ToDouble(sizeBytes / 1024), 2);
        }
        */

    }
}
