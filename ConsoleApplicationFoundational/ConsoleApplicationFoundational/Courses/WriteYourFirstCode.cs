using ConsoleApplicationFoundational.Enums;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                case 3:
                    ExecuteModule3();
                    break;
                case 4:
                    ExecuteModule4();
                    break;
                default:
                    Console.WriteLine("Module Not Implemented.");
                    break;
            }
        }

        //  Módulo 1 - Write Your First C# Code
        private void ExecuteModule1()
        {
            Console.Write("Congratulations!");
            Console.Write("You wrote your first lines of code.");

            Console.WriteLine("----------------------------------");

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

            // Cadeia de Caractere Literal
            Console.WriteLine("Hello World!");

            // Literais Inteiro
            Console.WriteLine(123);

            // Literais de Ponto Flutuante

            /*
                Tipo Float    Precisão
                -----------------------------
                float      ~6-9   Digitos
                double     ~15-17 Digitos
                decimal    ~28-29 Digitos
            */

            // F: Sufixo Literal
            Console.WriteLine(0.25F);

            // Caso Nenhum Sufixo Seja Adicionado Por Padrão o Tipo Será double
            Console.WriteLine(2.625D);

            // Os Sufixos Literais Podem Ser Letras Maiúsculas/Minúsculas
            Console.WriteLine(12.39816m);

            // Literais Booleanos
            Console.WriteLine(true);
            Console.WriteLine(false);

            // Convenções: 

            // 1) CamelCase
            // 2) string 1firstName; (Inválido) 
            // 3) string $firstName; (Inválido)
            // 4) private string _firstName; (Válido)
            // 5) string strFirstName; (Não Segue a Covenção)
            // 6) string FirstName; (Não Segue a Covenção)

            string firstName;
            // = Operador de Atribuição
            // A Compilação no C# Ocorre da Direita Para a Esquerda. É Identificado Valor devAtribuicao e Depoois Comparado Com o Tipo de Dados da Variavel, Caso o Valor Incondizente Uma Excecao e Dispoarada
            firstName = "Bob";
            Console.WriteLine(firstName);

            ////Error CS0029: Cannot implicitly convert type 'string' to 'int'
            // int errorAtributionType = "Bob";
            // Console.WriteLine(errorAtributionType);

            ////Error CS0131: The left-hand side of an assignment must be a variable, property or indexer
            // string errorAtributionOrder;
            // "Bob" = errorAtributionOrder;

            Console.WriteLine(firstName);
            firstName = "Liem";
            Console.WriteLine(firstName);

            ////Error CS0165: Use of unassigned local variable 'firstName'
            // string errorVarNotInicialized;
            // Console.WriteLine(errorVarNotInicialized);

            // var: Variáveis de Tipo Implícito
            // A Palavra-Chave var lnforma ao Compilador C# Que o Tipo de Dados é Implícito Pelo Valor Atribuído.
            var message = "Tipo Implícito";
            Console.WriteLine(message);


            //// Error CS0029: Cannot implicitly convert type 'decimal' to 'string'
            //// Definido o Tipo Implícito o Mesmo Não Pode Ser Alterado
            // message = 10.703m;

            //// Error CS0818: Implicitly-typed variables must be initialized
            // var errorVariableNotInicialized;

            firstName = "Bob";
            var quantityInboxMessage = 3;
            var celsiusTemperature = 34.4;

            Console.Write("Hello, ");
            Console.Write(firstName);
            Console.Write("! You have ");
            Console.Write(quantityInboxMessage);
            Console.Write(" messages in your inbox. The temperature is ");
            Console.Write(celsiusTemperature);
            Console.Write(" celsius.");
        }

        private void ExecuteModule3()
        {
            // \: Caractere de Escape
            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine("Hello \"World\"!");

            // \: Utiliza-se \\ Para Escapar a Barra Simples (\)
            Console.WriteLine("c:\\source\\repos");

            /*
             * Cadeia de Caractere Literal Verbatim (@) 
             * Mantém os Whitespace e \ Sem a Necessidade de Utilizar \ Para 
             * Escapar os Caracteres
             */
            Console.WriteLine(@"    c:\source\repos    
                                            (this is where your code goes)");

            /*
             * Caracteres de Escape Unicode
             * 
             * Observação: ConsoleApps Não Possuem Suporte Para Caracteres Unicode. Desta Forma, Exibem o Símbolo de ? Quando Não Possuem Suporte.
             * É Importante Checar se o Tipo de Codificação Suporta o Caractere Unicode (UTF-8/UTF-16/UTF-32)
             */
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

            // Concatenação de Cadeia de Caracteres
            string firstName = "Bob";
            string greeting = "Hello";
            // Evitar Usar Variáveis de Intermediárias Para Concatenação
            string message = greeting + " " + firstName + "!";
            Console.WriteLine(message);
            Console.WriteLine(greeting + " " + firstName + "!");

            // Interpolação de Cadeia de Caracteres
            // Características:
            // 1) Leitura Facilitada
            // 2) Mais Facíl de Combinar Diversas Cadeias de Caractere Literal
            Console.WriteLine($"{greeting} {firstName}!");
            string projectName = "ACME";
            Console.WriteLine($@"C:\Output\{projectName}\Data");

            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            Console.WriteLine($@"{russianMessage}
                                  c:\Exercise\{projectName}\data.txt");
            Console.WriteLine(@$"View English Output:
                                  c:\Exercise\{projectName}\data.txt");
        }

        private void ExecuteModule4()
        {
            // Sobrecarga de Operador: Quando o Mesmo Símbolo é Utilizado Mais de 1x Para Operações Distintas.
            // Se o Operador + Estiver Entre os Dois Valores Inteiros 1 + 2, o Compilador Verifica o Tipo da Variável e Realiza a Operação Desejada.
            int firstNumber = 12;
            int secondNumber = 7;
            Console.WriteLine(firstNumber + secondNumber);

            // Quando o Operador + é Utilizado Entre Diferentes Tipos de Dados, o Compilador Entende 
            // que a Operação Realizada é uma Concatenação, Assim Convertendo Implicitamente o Tipo Int em String
            string firstName = "Bob";
            int widgetsSold = 7;
            Console.WriteLine(firstName + " Sold " + widgetsSold + 7 + " Widgets.");

            // 1) ( ): Operador de Ordem de Operações - Informa Explicitamente ao Compilador a Ordem de Execução da Operação.
            Console.WriteLine(firstName + " Sold " + (widgetsSold + 7) + " Widgets.");

            int sum = 7 + 5;
            int difference = 7 - 5;
            int product = 7 * 5;
            int quotient = 7 / 5;

            Console.WriteLine("Sum        (7 + 5) = " + sum);
            Console.WriteLine("Difference (7 - 5) = " + difference);
            Console.WriteLine("Product    (7 * 5) = " + product);
            Console.WriteLine("Quotient   (7 / 5) = " + quotient);

            // Para Obter Valores Decimais de uma Divisão ao Menos um dos Números.
            decimal decimalQuotient1 = 7.0m / 5; 
            Console.WriteLine($"1 - Decimal Quotient    (7.0m / 5int) = {decimalQuotient1}");
            decimal decimalQuotient2 = 7.0m / 5.0m;
            Console.WriteLine($"2 - Decimal Quotient    (7.0m / 5.0m) = {decimalQuotient2}");
            decimal decimalQuotient3 = 7 / 5;
            Console.WriteLine($"3 - Decimal Quotient          (7 / 5) = {decimalQuotient3}");
            // 2) ( ): Operador de Conversão - Informa ao Compilador a Tratar Temporariamente o Tipo Dados Convertido Como um Tipo Diferente.
            decimal decimalQuotient4 = (decimal)7 / 5;
            Console.WriteLine($"4 - Decimal Quotient ((decimal)7 / 5) = {decimalQuotient4}");


            Console.WriteLine($"Modulus Of (200 / 5) = {200 % 5}");
            Console.WriteLine($"Modulus Of (  7 / 5) = {7 % 5}");

            // C# Segue a Ordem PEMDAS Para Operações Aritméticas
            int value1 = 3 + 4 * 5;
            int value2 = (3 + 4) * 5;
            Console.WriteLine($"3 + 4 * 5 = {value1}");
            Console.WriteLine($"(3 + 4) * 5 = {value2}");

            // +=: Atribuição de Adição
            int value3 = 0;      // Valor Atual => 0.
            Console.WriteLine($"int value3 = 0 => {value3}");
            value3 = value3 + 5; // Valor Atual => 5.
            Console.WriteLine($"value3 = value3 + 5 => {value3}");
            value3 += 5;         // Valor Atual => 10.
            Console.WriteLine($"value3 += 5 => {value3}");

            // ++ / --
            int value4 = 0;
            value4 = value4 + 1;
            Console.WriteLine(" int value4 = 0;\n value4 = value4 + 1; (First Increment) = " + value4);

            value4 += 1;
            Console.WriteLine(" value4 += 1; (Second Increment) = " + value4);

         
            Console.WriteLine(" value4++; (Third Increment) = " + value4);

            value4 = value4 - 1;
            Console.WriteLine(" value4 = value4 - 1; (First Decrement) = " + value4);

            value4 -= 1;
            Console.WriteLine(" value4 -= 1; (Second Decrement) = " + value4);

            value4--;
            Console.WriteLine(" value4--; (Third Decrement) = " + value4);

            // Incremento/Decremento - Antes e Depois
            int value5 = 1;
            value5++;
            Console.WriteLine("First: " + value5);
            // Recupera o Valor => Exibe o Valor => Incrementa o Valor
            Console.WriteLine($"Second: {value5++}");
            Console.WriteLine("Third: " + value5);
            // Incrementa o Valor => Recupera o Valor => Exibe o Valor
            Console.WriteLine("Fourth:" + ++value5);

            int value6 = 1;
            while (value6 < 131072)
            {
                // Atribuição de Multiplicação
                value6 *= 2;
                Console.WriteLine(value6);  
            }

            int fahrenheitTemperature = 94;
            decimal celsiusTemperature = (fahrenheitTemperature - 32) * (5m / 9);

            Console.WriteLine($"The Temperature is {celsiusTemperature} Celsius.");
            Console.WriteLine($"Windows"+ 1 + 1 );
        }
    }
}
