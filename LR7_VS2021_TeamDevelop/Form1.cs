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
            MessageBox.Show("*Анекдот Мельничука*", "Вніманіє анекдот!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void button22_Click(object sender, EventArgs e)
        {
            new FormKukharuk().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Отак після 25 років шлюбу намагаєшся організувати романтику, запалиш свічки… Прийде Він і питає: – хто вмер?", "Анекдот", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("За законом геометрії якщо чоловік 4 рази піде ліворуч, то прийде додому.", "Увага анекдот", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Хочешь жить умей вертеться", "Сообщение");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вийшли з сином погуляти, він і каже:\n– Яке небо сьогодні блакитне, як заставка Windows!","Заставка Windows",MessageBoxButtons.OK,MessageBoxIcon.Hand);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сколько программистов надо, чтобы вкрутить одну лампочку? – Ни одного.\nВ этом случае отсутствие света – проблема на стороне железа.","Шутеечка", MessageBoxButtons.OK ,MessageBoxIcon.Information);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Летить, значить, Нива зі сталкерами Зоною. Aномалії оминає на щаленій швидкості. Зустрічних монстрів на бампер приймає. Влітає в блокпост, проходить його, мало не зіткнувшись із БТРом, i мчиться дорогою геть від Зони.\n\n" +
               "Пасажири у повній прострації... А водила спокійно так — однією рукою крутить кермо, у другій — тримає пляшку пива.І іноді від горла сьорбає.\n\n" +
               "Тут один сталкер трішки очухався:\n - Ну ти даєш! - Здивовано каже, - Ти де так водити навчився?\n\nА водила сміється:\n – Хех! Ось я раніше в Києві на маршрутці працював...",
               "Анекдот із Сталекра", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Скільки вартує кіло гречки, якщо козир чирва!", "Шутеечка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hahahahahahha", "Шутеечка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
