using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace grafikaZad2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //metoda w buttonie umożliwia nam otwieranie plików JPEG
        private void readJPEG_Click(object sender, EventArgs e)
        {
            //użytkownik sam wybiera plik, który chce otworzyć za pomocą OpenFileDialog
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Otwórz obrazek";
            //możemy wypierać tylko pliki z rozszerzeniem JPEG
            dlg.Filter = "Image Files (*.jpeg)|*.jpeg";
            //jeżeli wybierzemy plik i będzie on zgodny z naszym formatem, umieszczamy obrazek w moim picturebox
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlg.FileName);
            }
            //dlg.Dispose();
        }

        //metoda w buttonie umożliwia nam otwieranie plików PPM P6
        private void readPPM_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Otwórz obrazek";
            dlg.Filter = "Image Files (*.ppm)|*.ppm";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //obraz otwieramy na bitmapie, która otworzy się w moim picturebox, korzystamy z metody PPMReader, służącej do odczytu plików PPM6
                pictureBox1.Image = PPMReader.ReadBitmapFromPPM(dlg.FileName);
            }
        }

        //mwtoda służąca do kompresji plików przy zapisie do JPEG
        //jest to metoda zaproponowana przez Microsoft
        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            //dekodujemy kodeki z pomocą pętli foreach, wybieramy po kolei elementy z tablicy codecs
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                //sprawdzenie poprawności dekodowania i formatu
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        //metoda zapisu do pliku JPEG z kompresją 100%
        private void saweImage100_Click(object sender, EventArgs e)
        {
            //użytkownik zapisuje obecny obraz z pictureboxa
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //wysokość i szerokość picturebox konwertujemy do INTa
                int width = Convert.ToInt32(pictureBox1.Width);
                int height = Convert.ToInt32(pictureBox1.Height);
                //pobieramy także parametry bitmapy
                Bitmap bmp = new Bitmap(width, height);

                //nasz obiekt picturebox korzysta z metody DrawToBitmap, aby pobrać cały obraz picturebox
                pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                
                //korzystamy z ekcodera JPG 
                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                //tworzymy obiekt Encoder na podstawie GUID  aby ustalić parametr jakości
                System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;

                //tworzymy obiekt EncodersParametrs, obiekt ten zawiera tablicę obiektów EncodersParametrs
                //w tym przypadku jednak w tablicy znajduje się tylko jeden obiekt
                EncoderParameters myEncoderParameters = new EncoderParameters(1);

                //ustalamy kompresję z poziomem 100% czyli 100L
                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 100L);
                myEncoderParameters.Param[0] = myEncoderParameter;
                //zapisujemy nasz obraz z bitmapy do wybranego przez użytkownika pliku z zapisanymi ustawieniami kompresji
                bmp.Save(dialog.FileName, jpgEncoder, myEncoderParameters);
            }
        }

        //metoda zapisu do pliku JPEG z kompresją 50%
        private void saveImage50_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(pictureBox1.Width);
                int height = Convert.ToInt32(pictureBox1.Height);
                Bitmap bmp = new Bitmap(width, height);
                pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));

                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;

                EncoderParameters myEncoderParameters = new EncoderParameters(1);

                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 50L);
                myEncoderParameters.Param[0] = myEncoderParameter;
                bmp.Save(dialog.FileName, jpgEncoder, myEncoderParameters);
            }
        }

        //metoda zapisu do pliku JPEG z kompresją 0%
        private void saveImage0_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(pictureBox1.Width);
                int height = Convert.ToInt32(pictureBox1.Height);
                Bitmap bmp = new Bitmap(width, height);
                pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));

                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;

                EncoderParameters myEncoderParameters = new EncoderParameters(1);

                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 0L);
                myEncoderParameters.Param[0] = myEncoderParameter;
                bmp.Save(dialog.FileName, jpgEncoder, myEncoderParameters);
            }
        }
    }
}
