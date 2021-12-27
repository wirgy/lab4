using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        List<Vehicle> vehicleList = new List<Vehicle>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            // если список пуст, то напишем что пусто и выйдем из функции
            if (this.vehicleList.Count == 0)
            {
                RichTxtInfo.Text = "Автомат пуст!";
                return;
            }

            int index = 0;
            if(index<=vehicleList.Count)
            {
                var Vehicle = this.vehicleList[index];
                this.vehicleList.RemoveAt(index);
                RichTxtInfo.Text = Vehicle.GetInfo();
                if (index < vehicleList.Count)
                    show_queue(index);
                else
                    queue.Text = "";
                index++;
            }

            ShowInfo();
        }
        private void ShowInfo()
        {
            // заведем счетчики под каждый тип
            int bicyclesCount = 0;
            int carsCount = 0;
            int aircraftCount = 0;

            // пройдемся по всему списку
            foreach (var vehicle in this.vehicleList)
            {
                if (vehicle is Bicycles) 
                {
                    bicyclesCount += 1;
                }
                else if (vehicle is Cars)
                {
                    carsCount += 1;
                }
                else if (vehicle is Plane)
                {
                    aircraftCount += 1;
                }
            }

            // а ну и вывести все это надо на форму
            txtInfo.Text = "Вел.\tАвто\tСамолет"; 
            txtInfo.Text += "\r\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", bicyclesCount, carsCount, aircraftCount);
        }

        public void show_queue(int index)
        {
            var Vehicle = vehicleList[index];
            string type=Convert.ToString(Vehicle.GetType());
            queue.Text = type;

            if (type == "Lab4.Bicycles")
                queue.Text = string.Format("Следующий элемент - {0}", "Велосипед");
            else if (type == "Lab4.Cars")
                queue.Text = string.Format("Следующий элемент - {0}", "Автомобиль");
            else
                queue.Text = string.Format("Следующий элемент - {0}", "Самолёт");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.vehicleList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) // генерирую случайное число от 0 до 2 (остаток от деления на 3)
                {
                    case 0: // если 0, то велосипед
                        this.vehicleList.Add(Bicycles.Generate());
                        break;
                    case 1: // если 1 то автомобиль
                        this.vehicleList.Add(Cars.Generate());
                        break;
                    case 2: // если 2 то самолёт
                        this.vehicleList.Add(Plane.Generate());
                        break;
                        // появление других чисел маловероятно
                }
            }
            ShowInfo();
        }
    }
}
