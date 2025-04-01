using ConsoleApplicationFoundational.Enums;

namespace ConsoleApplicationFoundational.Courses
{
    internal class WriteYourFirstCode : CourseBase
    {

        protected override void SetCourseId()
        {
            CourseId = Convert.ToInt32(CoursesEnum.WriteYourFirstCode);  
        }

        protected override void PrintCourseName()
        {
            GetCourseName();
        }

        protected override void ExecuteCourseLogic()
        {
            switch (GetCurrentModule(CourseId))
            {
                case 1:
                    ExecuteModule1();
                    break;
                case 2:
                    ExecuteModule2();
                    break;
                default:
                    Console.WriteLine("Module Not Found.");
                    break;
            }
        }

        //  Módulo 1 - Write Your First C# Code
        private void ExecuteModule1()
        {
            Console.Write("Hello, World!");
            Console.WriteLine("");

            Console.Write("Congratulations!");
            Console.Write("You wrote your first lines of code.");

            Console.WriteLine("");

            Console.WriteLine("Congratulations!");
            Console.WriteLine("You wrote your first lines of code.");

            // 1) Console.WriteLine X Console.Write() : Console.WriteLine Adiciona Uma Nova Linha Após Mostrar o Valor
            // 2) "" : Uma Cadeia de Caracteres Literal é Indicada Pelo Uso de " " 
            // 3) .  : O . Possui o Nome Técnico de Operador de Acesso a Membro
        }

         // Módulo 2 - Store And Retrieve Data Using Literal And Variable Values In C#
        private void ExecuteModule2()
        {
            // Caractere Literal
            Console.WriteLine('C');
        }

    }
}
