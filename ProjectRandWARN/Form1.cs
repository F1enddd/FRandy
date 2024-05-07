using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using WinFormAnimation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProjectRandWARN
{
    public partial class Form1 : Form
    {
        string[] ListChng;

        bool isChecked = false;
        private Single R;
        private string Res2 = "";
        List<float> DelNum = new List<float>();
        List<string> DelNum2 = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label3.Text = null;
            label2.Text = null;
            label5.Text = null;
            label4.Text = null;
            label6.Text = null;
            label7.Text = null;
            label8.Text = null;
            textBox2.TabIndex = 0;
            listBox2.Visible = true;
            siticoneShadowForm1.SetShadowForm(this);
            button3.Location = new Point(-103, 252);
            listBox1.Location = new Point(-74, 252);
            buttonclr3.Location = new Point(-103, 252);





        }


        async void label4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(R.ToString());

            Point newLocation = new Point(label4.Left, label4.Top);

            label5.Location = newLocation;
            label5.Text = "Copied!";
            label5.ForeColor = Color.FromArgb(53, 53, 53); //rgb(53, 53, 53)

            for (byte r = 53, g = 53, b = 53; r < 192 && g < 192 && b < 192; r += 13, g += 13, b += 13, await Task.Delay(7)) //rgb(192, 192, 192)
            {
                label5.ForeColor = Color.FromArgb(r, g, b);
            }
            await Task.Delay(100);

            for (byte r = 192, g = 192, b = 192; r >= 53 && g >= 53 && b >= 53; r -= 13, g -= 13, b -= 13, await Task.Delay(7)) //rgb(53, 53, 53)
            {
                label5.ForeColor = Color.FromArgb(r, g, b);
            }

            await Task.Delay(10);
            label5.Text = null;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.Font = new Font("Bahnschrift Condensed", 10, FontStyle.Underline);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = new Font("Bahnschrift Condensed", 9);
        }




        async void label7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Res2.ToString());

            Point newLocation = new Point(label7.Left, label7.Top);

            label8.Location = newLocation;
            label8.Text = "Copied!";
            label8.ForeColor = Color.FromArgb(53, 53, 53); //rgb(53, 53, 53)

            for (byte r = 53, g = 53, b = 53; r < 192 && g < 192 && b < 192; r += 13, g += 13, b += 13, await Task.Delay(7)) //rgb(192, 192, 192)
            {
                label8.ForeColor = Color.FromArgb(r, g, b);
            }
            await Task.Delay(100);

            for (byte r = 192, g = 192, b = 192; r >= 53 && g >= 53 && b >= 53; r -= 13, g -= 13, b -= 13, await Task.Delay(7)) //rgb(53, 53, 53)
            {
                label8.ForeColor = Color.FromArgb(r, g, b);
            }

            await Task.Delay(10);
            label8.Text = null;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.Font = new Font("Bahnschrift Condensed", 10, FontStyle.Underline);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.Font = new Font("Bahnschrift Condensed", 9);
        }

        async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            new Animator2D(
            new Path2D(223, 223, 110, 10, 150), FPSLimiterKnownValues.NoFPSLimit)
            .Play(label2, Animator2D.KnownProperties.Location);



            label4.Text = null;
            Random rnd = new Random();
            if ((!int.TryParse(textBox1.Text, out int X)) || (!int.TryParse(textBox2.Text, out int Y)))
            {
                label6.ForeColor = Color.Red;
                label6.Text = "Числа не введены";
            }
            else
            {
                if (X > Y)
                {
                    (textBox1.Text, textBox2.Text) = (textBox2.Text, textBox1.Text);
                    (X, Y) = (Y, X);
                }
                if (DelNum.Count >= Y - X + 1 && Enumerable.Range(X, Y - X + 1).All(num => DelNum.Contains(num)))
                {
                    label6.ForeColor = Color.Red;
                    label6.Text = "Все числа исключены";
                    label2.Text = null;
                    label4.Text = null;
                    label5.Text = null;
                }
                else
                {
                        R = (Single)rnd.Next(X, Y + 1);
                        while (DelNum.Contains(R))
                        {

                            R = (Single)rnd.Next(X, Y + 1);
                        }
                        if (R > 1000000)
                        {
                            label2.Font = new Font("Bahnschrift Condensed", 36);
                            if (R > 100000000)
                            {
                                label2.Font = new Font("Bahnschrift Condensed", 28);
                            }
                        }
                        else
                        {
                            label2.Font = new Font("Bahnschrift Condensed", 48);
                        }
                        if (CheckBox1.Checked)
                        {
                            DelNum.Add(R);
                            listBox1.Items.Add(R);
                        }
                        label2.Text = string.Format("{0}", R);
                        label2.ForeColor = Color.FromArgb(53, 53, 53); //rgb(53, 53, 53)


                        for (byte r = 53, g = 53, b = 53; r < 253 && g < 253 && b < 253; r += 10, g += 10, b += 10, await Task.Delay(5)) //rgb(192, 192, 192)
                        {
                            label2.ForeColor = Color.FromArgb(r, g, b);


                        }
                        await Task.Delay(50);
                        
                        Point PntLab4 = new Point(label2.Right - 6, label2.Top);

                        label4.ForeColor = Color.FromArgb(192, 192, 192);

                        label4.Location = PntLab4;

                        label4.Text = "Copy";
                        
                    
                }
            }
            button1.Enabled = true;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            string input = textBox2.Text;
            string result = string.Empty;

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    result += c;
                }
            }

            textBox2.Text = result;
            textBox2.SelectionStart = result.Length;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            string username = Environment.UserName;
            string directory = $@"C:\Users\{username}\Desktop";
            const string baseFileName = "Exception.txt";
            string filePath = System.IO.Path.Combine(directory, baseFileName);

            if (File.Exists(filePath))
            {
                int counter = 1;
                string fileName;
                do
                {
                    fileName = $"{System.IO.Path.GetFileNameWithoutExtension(baseFileName)}{counter++}{System.IO.Path.GetExtension(baseFileName)}";
                    filePath = System.IO.Path.Combine(directory, fileName);
                } while (File.Exists(filePath));
            }

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var item in listBox1.Items)
                {
                    writer.WriteLine(item);
                }
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        async void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if (checkBox2F.Checked)
            {
                var Elems = textBox3.Lines.Distinct();
                textBox3.Clear();

                foreach (string Elem in Elems)
                {
                    textBox3.AppendText(Elem + "\r\n");
                }
                
            }
            textBox3.Text = textBox3.Text.TrimEnd();
            

            
            var lines = textBox3.Lines.Where(line => !String.IsNullOrWhiteSpace(line)).Count();
            if (DelNum2.Count == lines && checkBox2F.Enabled)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Все элементы исключены";
                label3.Font = new Font("Bahnschrift Condensed", 24);
                label3.Location = new Point(233, 98);
                label7.Text = null;
                label8.Text = null;
            }
            else
            {
                new Font("Bahnschrift Condensed", 28, FontStyle.Underline);
                Random rnd = new Random();
                string[] ListRand = textBox3.Lines;
                label7.Text = null;
                if (textBox3.Text == "")
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "Список пуст";
                    label7.Text = null;
                    label3.Location = new Point(233, 98);
                }
                else
                {
                    Res2 = ListRand[rnd.Next(0, ListRand.Length)];
                    while (DelNum2.Contains(Res2))
                    {

                        Res2 = ListRand[rnd.Next(0, ListRand.Length)];
                    }
                    if (checkBox2F.Checked)
                    {
                        DelNum2.Add(Res2);
                        listBox2.Items.Add(Res2);
                    }

                    if (checkBox3.Checked)
                    {
                        listBox2.Items.Add(Res2);
                    }

                    new Animator2D(
                    new Path2D(389, 220, 110, 110, 150), FPSLimiterKnownValues.NoFPSLimit)
                    .Play(label3, Animator2D.KnownProperties.Location);
                    label3.ForeColor = Color.White;
                    label3.Text = Res2;
                    new Animator3D(
                    new Path3D(53, 253, 53, 253, 53, 253, 200), FPSLimiterKnownValues.NoFPSLimit)
                    .Play(label3, Animator3D.KnownProperties.ForeColor);

                    await Task.Delay(300);

                    Point PntLab7 = new Point(label3.Right - 5, 100);
                    

                    label7.Text = "Copy";

                    label7.ForeColor = Color.FromArgb(192, 192, 192);

                    label7.Location = PntLab7;
                }
            }
            button2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Выберите файл";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                textBox3.Text = File.ReadAllText(openFileDialog1.FileName);
            }
            else
            {
                textBox3.Text = "";
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            textBox3.Text = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string username = Environment.UserName;
            string directory = $@"C:\Users\{username}\Desktop";
            const string baseFileName = "Save.txt";
            string filePath = System.IO.Path.Combine(directory, baseFileName);

            if (File.Exists(filePath))
            {
                int counter = 1;
                string fileName;
                do
                {
                    fileName = $"{System.IO.Path.GetFileNameWithoutExtension(baseFileName)}{counter++}{System.IO.Path.GetExtension(baseFileName)}";
                    filePath = System.IO.Path.Combine(directory, fileName);
                } while (File.Exists(filePath));
            }

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var item in listBox2.Items)
                {
                    writer.WriteLine(item);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Form2 InfoForm = new Form2();
            InfoForm.Show();
            
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            DelNum2.Clear();
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            DelNum2.Clear();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            DelNum2.Clear();
            isChecked = checkBox3.Checked;
        }

        private void checkBox2F_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = checkBox2F.Checked;
            DelNum2.Clear();
            listBox2.Items.Clear();

        }

        private void checkBox2F_Click(object sender, EventArgs e)
        {
            DelNum2.Clear();
            listBox2.Items.Clear();
            if (checkBox2F.Checked && !isChecked)
            {
                checkBox2F.Checked = false;
            }
            else
            {
                checkBox2F.Checked = true;
                isChecked = false;
            }
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            DelNum2.Clear();
            listBox2.Items.Clear();
            if (checkBox3.Checked && !isChecked)
            {
                checkBox3.Checked = false;
            }
            else
            {
                checkBox3.Checked = true;
                isChecked = false;
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (siticoneCheckBox1.Checked)
            {
                if (e.KeyCode == Keys.Space)
                {
                    textBox3.AppendText(Environment.NewLine);
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void siticoneCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneCheckBox1.Checked)
            {
                ListChng = textBox3.Lines;
                textBox3.Text = textBox3.Text.Replace(" ","\r\n");
            }
            else
            {
                textBox3.Lines = ListChng;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Form2 InfoForm = new Form2();
            InfoForm.Show();
        }

        private void siticoneCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox1.Enabled = false;
            DelNum.Clear();
            if (CheckBox1.Checked)
            {
                new Animator2D(
                new Path2D(-105, 105, 252, 252, 150), FPSLimiterKnownValues.NoFPSLimit)
                .Play(button3, Animator2D.KnownProperties.Location);
                new Animator2D(
                new Path2D(-74, 26, 252, 252, 200), FPSLimiterKnownValues.NoFPSLimit)
                .Play(listBox1, Animator2D.KnownProperties.Location);
                new Animator2D(
                new Path2D(-105, 105, 294, 294, 150), FPSLimiterKnownValues.NoFPSLimit)
                .Play(buttonclr3, Animator2D.KnownProperties.Location);
                listBox1.Items.Clear();
            }
            else
            {
                new Animator2D(
                new Path2D(105, -105, 252, 252, 150), FPSLimiterKnownValues.NoFPSLimit)
                .Play(button3, Animator2D.KnownProperties.Location);
                listBox1.Items.Clear();
                new Animator2D(
                new Path2D(26, -74, 252, 252, 100), FPSLimiterKnownValues.NoFPSLimit)
                .Play(listBox1, Animator2D.KnownProperties.Location);
                listBox1.Items.Clear();
                new Animator2D(
                new Path2D(105, -105, 294, 294, 150), FPSLimiterKnownValues.NoFPSLimit)
                .Play(buttonclr3, Animator2D.KnownProperties.Location);
            }
            CheckBox1.Enabled = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.Handled = false;
                return;
            }
            if (e.Control && e.KeyCode == Keys.A)
            {
                e.Handled = false;
                return;
            }
            if (!char.IsDigit((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string result = string.Empty;

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    result += c;
                }
            }

            textBox1.Text = result;
            textBox1.SelectionStart = result.Length;
        }

        private void buttonclr3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.Handled = false;
                return;
            }
            if (e.Control && e.KeyCode == Keys.A)
            {
                e.Handled = false;
                return;
            }
            if (!char.IsDigit((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
