using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4_5
{
    public partial class Form1 : Form
    {
        private QuestContex db = new QuestContex();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            db.QuestInfoModel.Load();
            dataGridView1.DataSource = db.QuestInfoModel.Local.ToBindingList();


        }

        private void button2_Click(object sender, EventArgs e)

        {

            if (label2.Text == "label2" || label2.Text == "")
            {
                MessageBox.Show("Виберіть квест");
                return;
            }
     

            int id = Convert.ToInt32(label2.Text);

            var freeTime = db.QuestInfoModel.Find(id);
            
            if (DateTime.Now > Convert.ToDateTime(freeTime.freeTimeTo) || DateTime.Now < Convert.ToDateTime(freeTime.freeTimeFrom))
            {
                MessageBox.Show("Cьогодні ви вже не вспіли забронювати квест \n " + freeTime.freeTimeFrom + "/" + freeTime.freeTimeTo);
                return;
            }
           
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введіть ім'я");
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Введіть прізвище");
            }
            if (textBox2.Text != "" || textBox3.Text != "")
            {


                var product = db.QuestInfoModel.Find(id);
                if (product == null) return;
                if (product.NumberOfMember < product.LimitMember)
                {
                    product.NumberOfMember += 1;
                    db.QuestInfoModel.AddOrUpdate(product);
                    db.SaveChanges();
                    dataGridView1.Refresh();
                    MessageBox.Show("Ви забронювали квест №" + Convert.ToString(id));
                    textBox1.Left = 10000;
                    textBox1.Top = 8888;
                    textBox3.Left = 8888;
                    textBox3.Top = 2885885;
                    label6.Text = "";
                    label7.Text = "";
                    label4.Text = "Виберіть квест";
                    label2.Text = "";
                    button2.Text = "Забронювати квест";
                }
                else
                {
                    MessageBox.Show("Вільних місць на цей квест немає");
                }


            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == String.Empty) return;
            var list = db.QuestInfoModel.ToList();

            int i = 1;
            foreach (var item in db.QuestInfoModel.ToList())
            {

                if (item.NameOfQuest == textBox2.Text)
                {
                    var product = db.QuestInfoModel.Find(item.Id);

                    label5.Text = "Навза квесту: " + product.NameOfQuest + "\nКількість учасників: " + Convert.ToString(product.NumberOfMember) + "/" + Convert.ToString(product.LimitMember);
                    button2.Text = "Забронювати квест №" + Convert.ToString(product.Id);
                    break;
                }

                if (i == list.Count)
                {
                    MessageBox.Show("Такого квесту немає");
                }
                i++;


            }





        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            var product = dataGridView1.CurrentRow.DataBoundItem as QuestInfo;
            if (product == null) return;
            button2.Text = "Забронювати квест №" + Convert.ToString(product.Id);
            label4.Text = "Щоб змінити квест виберіть імя квесту";
            label2.Text = Convert.ToString(product.Id);
            textBox1.Left = 90;
            textBox1.Top = 205;
            textBox3.Left = 90;
            textBox3.Top = 255;
            label6.Text = "Введіть ім'я";
            label7.Text = "Введіть прізвище";
        }
    }
}
