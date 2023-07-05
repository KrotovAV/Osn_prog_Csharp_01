// See https://aka.ms/new-console-template for more information
//BP1-1-2-6 Рефакторинг - конвенция именования, DRY.mp4
//BP1-1-2-7 Рефакторинг - константы и enum.mp4
//BP1-1-2-8 Рефакторинг - выделение метода.mp4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using TestAttribute;
using ExplicitAttribute;
using Explicit;

// enum DayOfTheWeek // Объявление перечисления
// {
// 	Monday, // Это перечислитель. По умолчанию DayOfTheWeek.Monday = 0;
// 	Tuesday, // И это перечислитель. DayOfTheWeek.Tuesday = 1;
// 	Wednesday,
// 	Thursday,
// 	Friday,
// 	Saturday,
// 	Sunday
// }

// enum DayOfTheWeek_v2
// {
// 	Monday, // По умолчанию DayOfTheWeek.Monday = 0;
// 	Tuesday, // DayOfTheWeek.Tuesday = 1;
// 	Wednesday = 10, // DayOfTheWeek.Wednesday теперь равен 10, а не 2,
// 	Thursday, // а значение DayOfTheWeek.Thursday будет равно 11;
// 	Friday,
// 	Saturday,
// 	Sunday
// }

// Типы перечислений По умолчанию - int, но также можно использовать типы byte, sbyte, 
// short, ushort, int, uint, long и ulong. Пример объявления перечисления типа short

// enum DayOfTheWeek_v3 : short
// {
// 	Monday,
// 	Tuesday,
// 	Wednesday,
// 	Thursday,
// 	Friday,
// 	Saturday,
// 	Sunday
// }

// Для получения значения перечислителя, 
// необходимо выполнить приведение типа перечислителя к типу перечисления
// Console.WriteLine((int)DayOfTheWeek.Tuesday);

// Константы объявляются с помощью ключевого слова const.
// Объявлять константы можно внутри методов (там где объявляются переменные) и 
// внутри классов (где объявляются поля).

// Константа-поле всегда является статическим, при этом слово static писать не нужно.
// const double Pi = 3.14159;

static class LightsController
{
    static LightsForm form;

    // Выделяйте методы с говорящими названиями.
    // Названия аргументов метода должны снимать неоднозначности. 
    // Тут уточнили, что время в секундах.
    // Для переименования, нажмите правой кнопкой на имя, затем Refactor->Rename
    static void Wait(double timeInSeconds)
    {
        Thread.Sleep((int)(timeInSeconds * 1000));
    }

    // Основной принцип программирование: Don't Repeat Yourself. 
    // Не повторять один и тот же код дважды. 
    // Если при создании программы вы пользовались копированием и вставкой
    // из буфера обмена, то в коде необходимо прибраться, удалив повторяющиеся части.
    // Кроме того, старайтесь, чтобы каждый метод был размером не больше экрана.
    static void Control()
    {
        Wait(1);
        while (true)
        {
            form.LightOn(0);
            Wait(1);
            form.LightOn(1);
            Wait(1);
            form.LightOff(0);
            form.LightOff(1);
            form.LightOn(2);
            Wait(1);
            //Здесь мы заменили повторяющиеся строчки циклом
            for (int i = 0; i < 5; i++)
            {
                form.LightOff(2);
                Wait(0.25);
                form.LightOn(2);
                Wait(0.25);
            }
            form.LightOff(2);
            form.LightOn(1);
            Wait(1);
            form.LightOff(1);
        }
    }

    public class LightsForm : Form
    {
        bool[] lights = new bool[3];

        public LightsForm()
        {
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var d = Math.Min(ClientSize.Width, ClientSize.Height / 3);
            var colors = new[] { Color.Red, Color.Yellow, Color.Green };
            e.Graphics.Clear(Color.White);
            for (int i = 0; i < 3; i++)
                e.Graphics.FillEllipse(
                    new SolidBrush(lights[i] ? colors[i] : Color.White),
                    ClientSize.Width / 2 - d / 2,
                    i * ClientSize.Height / 3 + ClientSize.Height / 6 - d / 2,
                    d,
                    d);
        }

        public void LightOn(int lightColor)
        {
            lights[lightColor] = true;
            BeginInvoke(new Action(Invalidate));
        }

        public void LightOff(int lightColor)
        {
            lights[lightColor] = false;
            BeginInvoke(new Action(Invalidate));
        }

        [STAThread]
        [Test]
        [Explicit]
        public static void Main()
        {
            Application.EnableVisualStyles();
            form = new LightsForm();
            new Action(Control).BeginInvoke(null, null);
            Application.Run(form);
        }
    }
}

//Финальное решение

// enum Lights
// {
//     Red = 0,
//     Yellow = 1,
//     Green = 2
// }

// static class LightsController
// {
//     static LightsForm form;

//     // Выделяйте методы с говорящими названиями.
//     // Названия аргументов метода должны снимать неоднозначности. 
//     // Тут уточнили, что время в секундах.
//     // Для переименования, нажмите правой кнопкой на имя, затем Refactor->Rename
//     static void Wait(double timeInSeconds)
//     {
//         Thread.Sleep((int)(timeInSeconds * 1000));
//     }

//     static void LightOn(Lights color)
//     {
//         form.LightOn((int)color);
//     }

//     static void LightOff(Lights color)
//     {
//         form.LightOff((int)color);
//     }

//     // Вместо непонятных чисел, используйте именованные константы с осмысленными именами. 
//     // Так код будет понятнее
//     const int BlinkingCount = 5;
//     const double LightDuration = 1;
//     const double BlinkingTime = 0.25;

//     // Основной принцип программирования: Don't Repeat Yourself. 
//     // Не повторять один и тот же код дважды. 
//     // Если при создании программы вы нажимали Ctrl-C + Ctrl-V - в ней что-то не так.
//     static void SwitchTo(Lights color)
//     {
//         LightOff(Lights.Red);
//         LightOff(Lights.Yellow);
//         LightOff(Lights.Green);
//         LightOn(color);
//     }

//     private static void Blink()
//     {
//         // используйте циклы для повторяющихся действий
//         for (int i = 0; i < BlinkingCount; i++)
//         {
//             LightOff(Lights.Green);
//             Wait(BlinkingTime);
//             LightOn(Lights.Green);
//             Wait(BlinkingTime);
//         }
//     }
    
//     // Старайтесь, чтобы каждый метод был размером не больше экрана.
//     static void Control()
//     {
//         Wait(LightDuration);
//         while (true)
//         {
//             // Теперь в подсказке после открытия скобки видно, 
//             // что нужно передать цвет, причем только один из трех:
//             SwitchTo(Lights.Red);
//             Wait(LightDuration);
//             LightOn(Lights.Yellow);
//             Wait(LightDuration);
//             SwitchTo(Lights.Green);
//             Wait(LightDuration);
//             Blink();
//             SwitchTo(Lights.Yellow);
//             Wait(LightDuration);
//         }
//     }

//     public class LightsForm : Form
//     {
//         bool[] lights = new bool[3];

//         public LightsForm()
//         {
//             DoubleBuffered = true;
//         }

//         protected override void OnPaint(PaintEventArgs e)
//         {
//             var d = Math.Min(ClientSize.Width, ClientSize.Height / 3);
//             var colors = new[] { Color.Red, Color.Yellow, Color.Green };
//             e.Graphics.Clear(Color.White);
//             for (int i = 0; i < 3; i++)
//                 e.Graphics.FillEllipse(
//                     new SolidBrush(lights[i] ? colors[i] : Color.White),
//                     ClientSize.Width / 2 - d / 2,
//                     i * ClientSize.Height / 3 + ClientSize.Height / 6 - d / 2,
//                     d,
//                     d);
//         }

//         public void LightOn(int lightColor)
//         {
//             lights[lightColor] = true;
//             BeginInvoke(new Action(Invalidate));
//         }

//         public void LightOff(int lightColor)
//         {
//             lights[lightColor] = false;
//             BeginInvoke(new Action(Invalidate));
//         }

//         [STAThread]
//         [Test]
//         [Explicit]
//         public static void Main()
//         {
//             Application.EnableVisualStyles();
//             form = new LightsForm();
//             new Action(Control).BeginInvoke(null, null);
//             Application.Run(form);
//         }
//     }
// }