using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForHW_9
{
    /*1.	Создать два проекта в решении: библиотека классов и консольное приложение. 
 Подключить библиотеку в консольное приложение.
Добавить Класс Person в библиотеку и добавить класс со статическим методом который 
принимает в качестве параметра переменную типа Person и возвращает строку, 
состоящую из нескольких свойств класса Person. Вызвать в консольном  приложении метод 
используя полное пространство имен при обращении к нему.
2.	Создать класс со строковыми и числовыми константами в отдельном файле. 
В консольном приложении вывести эти константы на экран.
*/
    public static class View
    {
        public static void ShowPerson(Person person)
        {
            Console.Write(person.firstName + ' ');
            Console.Write(person.lastName + ' ');
            Console.Write(person.dateOfBirth);
            Console.Write(' ' + person.sex + ' ');
        }
    }
}
