using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexicalAnalyzer
{
    public class TokenDefinition
    {
        //RESERVED WORDS
        public class ReservedWords
        {
            //INCOMPLETE
            public List<string> rw_condloop = new List<string> { "for", "if", "else", "do", "while", "switch", "case", "default"};
            public List<string> rw_datatype = new List<string> { "string", "boolean", "char", "float", "int", "byte", "void", "const", "null" };
            public List<string> rw_booleanlit = new List<string> { "true", "false" };
            public List<string> rw_controlstat = new List<string> { "break", "continue", "goto", "return" };
            
        }
        //RESERVE WORDS DELIMITERS
        public class ReservedWordsDelimiters
        {
            //INCOMPLETE
            public List<char> whitespace = new List<char> { '\t', ' ', '\n'};
            public List<char> Delim2 = new List<char> { '\t', ' ', '\n', '.', '&', '|', '!', '~', ')' };
        }

        //RESERVED SYMBOLS
        public class ReservedSymbols
        {
            public List<string> rs_whitespace = new List<string> { ":" };
            public List<string> assignmentop = new List<string> { "=", "+=", "-=", "*=", "/=", "%=" };
            public List<string> arithmeticop = new List<string> { "+", "-", "*", "/", "%" };
            public List<string> relationalop = new List<string> { "==", "!=", "<", ">", "<=",  ">=" };
            public List<string> logicalop = new List<string> { "&&", "||", "!" };
            public List<string> bitwiselogop = new List<string> { "&", "||", "^" , "~" };
           
        }
        //RESERVED SYMBOLS DELIMITERS
        public class ReservedSymbolsDelims
        {
            public List<char> whitespace = new List<char> { '\t', ' ', '\n' };
            public List<char> Delim1 = new List<char> { '\t', ' ', '\n', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', };
        }

        //LITERALS
        public class Literals
        {
            public List<char> number = new List<char> { '-','~', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9','.' };
        }
        //LITERALS DELIMITER
        public class LiteralsDelims
        {
            public List<char> delim_txt = new List<char> { '\t', ' ', '\n', ';', ',', ')', '.', ':' };
            public List<char> delim_num = new List<char> { '\t', '+', '-', '*', '/', '.', ' ', ':', '\n', ';', '&', '|', ')', '%', ']' };
        }

        //IDENTIFIERS
        public class Identifier
        {
            public List<char> digit = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            public List<char> lowercaseletters = new List<char> { 'a','b','c','d','e','f','g','h','i','j','k','l','m',
                                                       'n','o','p','q','r','s','t','u','v','w','x','y','z' };
            public List<char> uppercaseletters = new List<char> {'A','B','C','D','E','F','G','H','I','J','K','L','M',
                                                      'N','O','P','Q','R','S','T','U','V','W','X','Y','Z' };
            public List<char> underscore = new List<char> { '_' };
            public List<char> hyphen = new List<char> { '-' };
            public List<char> id = new List<char>();
        }
        //IDENTIFIER DELIMITERS
        public class IdentifierDelims
        {
           
        }
    }
}
