using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09_Task_03
{
    internal class Animal
    {
        private string nameOfAnimal, habitat_area, sound;
        private int weight, height, birthYear;
        public Animal()
        {
            this.nameOfAnimal = "";
            this.habitat_area = "";
            this.sound = "";
            this.weight = 0;
            this.height = 0;
        }
        public void set_Name(string name)
        {
            this.nameOfAnimal = name;
        }
        public void set_Area(string area)
        {
            this.habitat_area = area;
        }
        public void set_Sound(string sound)
        {
            this.sound = sound;
        }
        public void set_Height(int height)
        {
            this.height = height;
        }
        public void set_Weight(int weight)
        {
            this.weight = weight;
        }
        public void set_Year(int year)
        {
            this.birthYear = year;
        }
        public void set_Year()
        {
            this.birthYear = 2021;
        }
        public string get_Name()
        {
            return this.nameOfAnimal;
        }
        public string get_Area()
        {
            return this.habitat_area;
        }
        public string get_Sound()
        {
            return this.sound;
        }
        public int get_Height()
        {
            return this.height;
        }
        public int get_Weight()
        {
            return this.weight;
        }
        public int get_Age()
        {
            int age = 2021 - this.birthYear;
            return age;
        }
        public string get_Info()
        {
            string info = "Name:" + "\t" + get_Name() + "\n" + "Habitat:" + "\t" + get_Area() + "\n" + "Height:" + "\t" + get_Height() + "\n" + "Weight:" + "\t" + get_Weight() + "\n" + "Age:" + "\t" + get_Age() + "\n";
            return info;
        }
        public void change_Weight(int pounds)
        {
            this.weight = pounds;
        }
        public virtual string vocalize()
        {
            return "sound";
        }
    }
}
