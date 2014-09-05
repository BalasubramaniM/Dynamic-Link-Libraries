using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelperClass.Symbols; // Namespace to make use of Symbols class

namespace HClasses.HelperClasses
{
    public class SymbolsClass
    {
        public void SymbolsFunction()
        {
           Symbols.NextLine;        // Returns One line space
           Symbols.Ampersand;       // Returns "&"
           Symbols.Asterisk;        // Returns "*"
           Symbols.At;              // Returns "@"
           Symbols.Cap;             // Returns "^"
           Symbols.Comma;           // Returns ","
           Symbols.Divide;          // Returns "%"
           Symbols.Dollar;          // Returns "$"
           Symbols.Equal;           // Returns "="
           Symbols.FBracketClose;   // Returns "{"
           Symbols.FBracketOpen;    // Returns "}"
           Symbols.Minus;           // Returns "-"
           Symbols.PBracketClose;   // Returns "("
           Symbols.PBracketOpen;    // Returns ")"
           Symbols.Pipe;            // Returns "|"
           Symbols.Plus;            // Returns "+"
           Symbols.Rupee;           // Returns "Rupee symbol"
           Symbols.SBracketClose;   // Returns "["
           Symbols.SBracketOpen;    // Returns "]"
           Symbols.SlashB;          // Returns "\"
           Symbols.SlashF;          // Returns "/"
           Symbols.Space;           // Returns " "
        }
    }
}
