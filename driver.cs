using System;
using System.Collections;
using System.Collections.Generic;
namespace Less8
{
    enum nameList {Андрей, Алексей, Борис, Василий, Сергей, Петр, Дмитрий}
    enum sexList {мужской, женский }

    class driver
    {//поля
        
        private string surname ;
        private nameList name;
        private string otchestvo;
        private int age;
        private sexList sex;

        public string Surname { get => surname; set => surname = value; }
        public nameList Name { get => name; set => name = value; }
        public string Otchestvo { get => otchestvo; set => otchestvo = value; }
        public int Age { get => age; set => age = value; }
        public sexList Sex { get => sex; set => sex = value; }

        public driver(nameList name, string surname, string otchestvo, int age, sexList sex)
        {
            
            Surname = surname;
            Name = name;
            Otchestvo = otchestvo;
            Age = age;
            Sex = sex;
        }

        public override string ToString()
        {
            return $"Фамилия:{surname},\nИмя:{name},\nОтчество:{otchestvo},\nВозраст: {age},\nПол: {sex}";
        }
    }
}
