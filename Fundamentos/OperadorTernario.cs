﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 6.0;
            var bomComportamento = true;
            string resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";

            Console.WriteLine(resultado);
        }
    }
}
