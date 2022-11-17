using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static aritmeticaParser;

namespace AritmeticaParser
{
    internal class Aritmetica : aritmeticaBaseVisitor<int>
    { 
        public override int VisitAritmetica([NotNull] AritmeticaContext context)
        {
            Console.WriteLine($"Visitando Aritmética: {context.GetText()}");
            return base.VisitAritmetica(context);
        }

        public override int VisitExpresion([NotNull] ExpresionContext context)
        {
            Console.WriteLine($"Visitando Aritmética: {context.GetText()}");
            return base.VisitExpresion(context);
        }

        public override int VisitFactor([NotNull] FactorContext context)
        {
            Console.WriteLine($"Visitando Aritmética: {context.GetText()}");
            return base.VisitFactor(context);
        }

        public override int VisitTermino([NotNull] TerminoContext context)
        {
            Console.WriteLine($"Visitando Aritmética: {context.GetText()}");
            return base.VisitTermino(context);
        }
    }
}
