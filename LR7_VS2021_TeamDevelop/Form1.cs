using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR7_VS2021_TeamDevelop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Летить, значить, Нива зі сталкерами Зоною. Aномалії оминає на щаленій швидкості. Зустрічних монстрів на бампер приймає. Влітає в блокпост, проходить його, мало не зіткнувшись із БТРом, i мчиться дорогою геть від Зони.\n\n" +
               "Пасажири у повній прострації... А водила спокійно так — однією рукою крутить кермо, у другій — тримає пляшку пива.І іноді від горла сьорбає.\n\n" +
               "Тут один сталкер трішки очухався:\n - Ну ти даєш! - Здивовано каже, - Ти де так водити навчився?\n\nА водила сміється:\n – Хех! Ось я раніше в Києві на маршрутці працював...",
               "Анекдот із Сталекра", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
