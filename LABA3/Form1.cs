using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LABA3
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private PointF[] objectPoints;
        private Pen objectPen;
        private Matrix objectTransform;
        ChangeText changeText = new ChangeText();
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxReflectAxis.Items.Add("X");
            comboBoxReflectAxis.Items.Add("Y");
            graphics.TranslateTransform(260, 260);
        }
        public Form1()
        {
            InitializeComponent();

            textBoxScaleX.Text = "X";
            textBoxScaleY.Text = "Y";
            textBoxRotateAngle.Text = "Кут";
            textBoxTranslateX.Text = "X";
            textBoxTranslateY.Text = "Y";
            comboBoxReflectAxis.Text = "";
            textBoxScaleX1.Text = "X";
            textBoxScaleY1.Text = "Y";
            textBoxRotateAngle1.Text = "Кут";
            textBoxTranslateX1.Text = "X";
            textBoxTranslateY1.Text = "Y";

            graphics = this.CreateGraphics();
            objectPoints = new PointF[5];
            objectPoints[0] = new PointF(0, 0);
            objectPoints[1] = new PointF(100, 0);
            objectPoints[2] = new PointF(120, 50);
            objectPoints[3] = new PointF(100, 100);
            objectPoints[4] = new PointF(0, 100);
            objectPen = new Pen(Color.Red, 2);

            // ініціалізація матриці перетворення
            objectTransform = new Matrix();
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // малюємо об'єкт
            graphics.DrawPolygon(objectPen, objectPoints);
        }

        private void ApplyTransformation()
        {
            // застосовуємо матрицю перетворення до кожної точки об'єкту
            objectTransform.TransformPoints(objectPoints);
            // оновлюємо матрицю перетворення
            objectTransform.Reset();
        }

        private void buttonScale_Click(object sender, EventArgs e)
        {
            // стиснення/розтягування за заданими коефіцієнтами по осі X та Y
            float scaleX = float.Parse(textBoxScaleX.Text);
            float scaleY = float.Parse(textBoxScaleY.Text);
            objectTransform.Scale(scaleX, scaleY);
            ApplyTransformation();
            this.Refresh();
        }
        private void buttonRotate_Click(object sender, EventArgs e)
        {
            // поворот на заданий кут (в градусах)
            float angle = float.Parse(textBoxRotateAngle.Text);
            objectTransform.Rotate(angle);
            ApplyTransformation();
            this.Refresh();
        }

        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            // паралельне перенесення на задані відстані по осі X та Y
            float translateX = float.Parse(textBoxTranslateX.Text);
            float translateY = float.Parse(textBoxTranslateY.Text);
            objectTransform.Translate(translateX, translateY);
            ApplyTransformation();
            this.Refresh();
        }

        private void buttonReflect_Click(object sender, EventArgs e)
        {
            // відображення відносно заданої вісі (X або Y)
            string reflectionAxis = comboBoxReflectAxis.SelectedItem.ToString();
            if (reflectionAxis == "X")
            {
                objectTransform.Scale(1, -1);
            }
            else if (reflectionAxis == "Y")
            {
                objectTransform.Scale(-1, 1);
            }
            ApplyTransformation();
            this.Refresh();
        }

        private void Reset(object sender, EventArgs e)
        {

            textBoxScaleX.Text = "X";
            textBoxScaleY.Text = "Y";
            textBoxRotateAngle.Text = "Кут";
            textBoxTranslateX.Text = "X";
            textBoxTranslateY.Text = "Y";
            comboBoxReflectAxis.Text = "";
            textBoxScaleX1.Text = "X";
            textBoxScaleY1.Text = "Y";
            textBoxRotateAngle1.Text = "Кут";
            textBoxTranslateX1.Text = "X";
            textBoxTranslateY1.Text = "Y";

            objectPoints[0] = new PointF(0, 0);
            objectPoints[1] = new PointF(100, 0);
            objectPoints[2] = new PointF(120, 50);
            objectPoints[3] = new PointF(100, 100);
            objectPoints[4] = new PointF(0, 100);
            this.Refresh();
        }

        private void All_At_once(object sender, EventArgs e)
        {
            float scaleX1 = float.Parse(textBoxScaleX1.Text);
            float scaleY1 = float.Parse(textBoxScaleY1.Text);
            float translateX1 = float.Parse(textBoxTranslateX1.Text);
            float translateY1 = float.Parse(textBoxTranslateY1.Text);
            float angle = float.Parse(textBoxRotateAngle1.Text);
            objectTransform.Translate(translateX1, translateY1);
            objectTransform.Rotate(angle);
            objectTransform.Scale(scaleX1, scaleY1);
            ApplyTransformation();
            this.Refresh();
        }

        private void textBoxTranslateX1_Enter(object sender, EventArgs e)
        {
            changeText.textChangeX(textBoxTranslateX1);
        }

        private void textBoxTranslateX1_Leave(object sender, EventArgs e)
        {
            changeText.textChangeX(textBoxTranslateX1);
        }

        private void textBoxTranslateY1_Enter(object sender, EventArgs e)
        {
            changeText.textChangeY(textBoxTranslateY1);
        }

        private void textBoxTranslateY1_Leave(object sender, EventArgs e)
        {
            changeText.textChangeY(textBoxTranslateY1);
        }


        private void textBoxTranslateX_Enter(object sender, EventArgs e)
        {
            changeText.textChangeX(textBoxTranslateX);
        }

        private void textBoxTranslateX_Leave(object sender, EventArgs e)
        {
            changeText.textChangeX(textBoxTranslateX);
        }

        private void textBoxTranslateY_Enter(object sender, EventArgs e)
        {
            changeText.textChangeY(textBoxTranslateY);
        }

        private void textBoxTranslateY_Leave(object sender, EventArgs e)
        {
            changeText.textChangeY(textBoxTranslateY);
        }

        private void textBoxRotateAngle1_Enter(object sender, EventArgs e)
        {
            changeText.textChangeKut(textBoxRotateAngle1);
        }

        private void textBoxRotateAngle1_Leave(object sender, EventArgs e)
        {
            changeText.textChangeKut(textBoxRotateAngle1);
        }

        private void textBoxScaleX1_Enter(object sender, EventArgs e)
        {
            changeText.textChangeX(textBoxScaleX1);
        }

        private void textBoxScaleX1_Leave(object sender, EventArgs e)
        {
            changeText.textChangeX(textBoxScaleX1);
        }

        private void textBoxScaleY1_Enter(object sender, EventArgs e)
        {
            changeText.textChangeY(textBoxScaleY1);
        }

        private void textBoxScaleY1_Leave(object sender, EventArgs e)
        {
            changeText.textChangeY(textBoxScaleY1);
        }

        private void textBoxScaleX_Enter(object sender, EventArgs e)
        {
            changeText.textChangeX(textBoxScaleX);
        }

        private void textBoxScaleX_Leave(object sender, EventArgs e)
        {
            changeText.textChangeX(textBoxScaleX);
        }

        private void textBoxScaleY_Enter(object sender, EventArgs e)
        {
            changeText.textChangeY(textBoxScaleY);
        }

        private void textBoxScaleY_Leave(object sender, EventArgs e)
        {
            changeText.textChangeY(textBoxScaleY);
        }

        private void textBoxRotateAngle_Enter(object sender, EventArgs e)
        {
            changeText.textChangeKut(textBoxRotateAngle);
        }

        private void textBoxRotateAngle_Leave(object sender, EventArgs e)
        {
            changeText.textChangeKut(textBoxRotateAngle);
        }

        private void textBoxRotateAngle1_TextChanged(object sender, EventArgs e) {}
        private void textBoxScaleY_TextChanged(object sender, EventArgs e) { }
    }
}
