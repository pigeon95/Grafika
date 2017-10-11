using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafikaZad2
{
    public static class PPMReader
    {
        //metoda do odczytu i wyświetleniu na bitmapie plików PPM P6
        public static Bitmap ReadBitmapFromPPM(string file)
        {
            //tworzymy instancję klasy BinaryReader(odczytujemy plik binarnie)
            //FileSrtream słóży do wskazania na interesujący nas plik i próbę otwarcia go
            var reader = new BinaryReader(new FileStream(file, FileMode.Open));
            //odczytamy tylko pliki z nagłówkiem P6
            //w przypadku próby odczytania innego formatu pliku wyskoczy nam wiadomość z błędem, ponieważ format pliku nie jest obsługiwany
            if (reader.ReadChar() != 'P' || reader.ReadChar() != '6')
            {
                MessageBox.Show("Nie można otworzyć pliku", "Błąd");
                return null;
            }

            //var allText = reader.ReadString();
            //var testSplit = allText.Split('\n', '\r');
            //var result = testSplit.Where(x => !x.Contains("# ")).ToArray();

            reader.ReadChar(); //Odczytujemy kolejną linię

            //zmienne łańcuchów na wysokości i szerokości
            string widths = "", heights = "";

            //zmienna tymczasowa
            char temp;

            //odczytywanie w pętlach wysokości i szerokości obrazu poprzez sumowanie każdego kolejnego znaku do zmiennej temp
            while ((temp = reader.ReadChar()) != ' ') //warunek while - jeśli znak występuje
                widths += temp;
            while ((temp = reader.ReadChar()) >= '0' && temp <= '9') //warunek while z zakresem
                heights += temp;

            //jeżeli wartość maksymalna koloru nie jest w ustalonej granicy 255, wyskoczy nam wiadomość z błędem
            if (reader.ReadChar() != '2' || reader.ReadChar() != '5' || reader.ReadChar() != '5')
            {
                MessageBox.Show("Nie można otworzyć pliku", "Błąd");
                return null;
            }
                
            reader.ReadChar(); //Odczytujemy resztę znaków do końca pliku

            //parsowanie znaków na int, aby móc potem odczytać je po pikselach
            int width = int.Parse(widths),
                height = int.Parse(heights);

            //tworzenie bitmapy, na której otworzy nam się obraz
            Bitmap bitmap = new Bitmap(width, height);
            //Sczytywanie po pikselach
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                    //ustawianie pikseli na bitmapie z pomocą RGB
                    bitmap.SetPixel(x, y, Color.FromArgb(reader.ReadByte(), reader.ReadByte(), reader.ReadByte()));
            return bitmap;
        }
    }
}
