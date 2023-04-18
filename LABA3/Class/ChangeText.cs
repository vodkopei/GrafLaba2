namespace LABA3
{
    internal class ChangeText
    {
        public void textChangeY(System.Windows.Forms.TextBox textBox)
        {
            if (textBox.Text == "Y")
            {
                textBox.Text = "";
            }

            else if (textBox.Text == "")
            {
                textBox.Text = "Y";
            }

        }
        public void textChangeX(System.Windows.Forms.TextBox textBox)
        {
            if (textBox.Text == "X")
            {
                textBox.Text = "";
            }

            else if (textBox.Text == "")
            {
                textBox.Text = "X";
            }

        }
        public void textChangeKut(System.Windows.Forms.TextBox textBox)
        {
            if (textBox.Text == "Кут")
            {
                textBox.Text = "";
            }

            else if (textBox.Text == "")
            {
                textBox.Text = "Кут";
            }

        }
    }
}
