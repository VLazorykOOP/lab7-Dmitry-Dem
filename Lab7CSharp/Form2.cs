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

namespace Lab7CharpTest
{
    enum Color_RGB
    {
        Red,
        Green,
        Blue
    }
    public partial class Form2 : Form
    {
        Color_RGB selected_RGB = Color_RGB.Red;
        public Form2()
        {
            InitializeComponent();
        }
        private void button_task1_Click(object sender, EventArgs e)
        {
            MainMenu c = new MainMenu();
            this.Hide();
            c.ShowDialog();
            this.Close();
        }
        private void button_open_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            // фильтр форматов файлов
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            // если в диалоге была нажата кнопка ОК
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // загружаем изображение
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    pictureBox2.Image = new Bitmap(ofd.FileName);
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch // в случае ошибки выводим MessageBox
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button_save_img_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null) // если изображение в pictureBox2 имеется
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Сохранить картинку как...";
                sfd.OverwritePrompt = true; // показывать ли "Перезаписать файл" если пользователь указывает имя файла, который уже существует
                sfd.CheckPathExists = true; // отображает ли диалоговое окно предупреждение, если пользователь указывает путь, который не существует
                                            // фильтр форматов файлов
                sfd.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                sfd.ShowHelp = true; // отображается ли кнопка Справка в диалоговом окне
                                     // если в диалоге была нажата кнопка ОК
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // сохраняем изображение
                        pictureBox2.Image.Save(sfd.FileName);
                    }
                    catch // в случае ошибки выводим MessageBox
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void button_set_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap input = new Bitmap(pictureBox1.Image);
                Bitmap output = new Bitmap(input.Width, input.Height);
                for (int j = 0; j < input.Height; j++)
                    for (int i = 0; i < input.Width; i++)
                    {
                        Color pixel = input.GetPixel(i, j);

                        int R = pixel.R;
                        int G = pixel.G;
                        int B = pixel.B;

                        switch (selected_RGB)
                        {
                            case Color_RGB.Red:
                                R = trackBar1.Value;
                                break;
                            case Color_RGB.Green:
                                G = trackBar1.Value;
                                break;
                            case Color_RGB.Blue:
                                B = trackBar1.Value;
                                break;
                            default:
                                break;
                        }

                        output.SetPixel(i, j, Color.FromArgb(pixel.A, R, G, B));
                    }
                pictureBox2.Image = output;
            }
        }
        private void radioButton_red_CheckedChanged(object sender, EventArgs e)
        {
            selected_RGB = Color_RGB.Red;
        }
        private void radioButton_green_CheckedChanged(object sender, EventArgs e)
        {
            selected_RGB = Color_RGB.Green;
        }
        private void radioButton_blue_CheckedChanged(object sender, EventArgs e)
        {
            selected_RGB = Color_RGB.Blue;
        }
    }
}
