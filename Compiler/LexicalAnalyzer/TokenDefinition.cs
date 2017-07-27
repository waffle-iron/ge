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
            public List<string> rw_loopingstat = new List<string> { "for", "if", "else", "do", "while" };
            public List<string> rw_datatype = new List<string> { "String", "boolean", "char", "float", "int", "byte", "void" };
            public List<string> rw_booleanlit = new List<string> { "True", "False" };
        }
        //RESERVE WORDS DELIMITERS
        public class ReservedWordsDelimiters
        {
            //INCOMPLETE
            public List<char> whitespace = new List<char> { '\t', ' ', '\n' };
        }

        //RESERVED SYMBOLS
        public class ReservedSymbols
        {
            public List<string> rs_whitespace = new List<string> { ":" };
        }
        //RESERVED SYMBOLS DELIMITERS
        public class ReservedSymbolsDelims
        {
            public List<char> whitespace = new List<char> { '\t', ' ', '\n' };
        }

        //LITERALS
        public class Literals
        {
            public List<char> nums = new List<char> { '~', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
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
            public List<char> delim_digit = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            public List<char> delim_lowcaseletters = new List<char> { 'a','b','c','d','e','f','g','h','i','j','k','l','m',
                                                       'n','o','p','q','r','s','t','u','v','w','x','y','z' };
            public List<char> delim_uppercaseletters = new List<char> {'A','B','C','D','E','F','G','H','I','J','K','L','M',
                                                      'N','O','P','Q','R','S','T','U','V','W','X','Y','Z' };
            public List<char> delim_undscore = new List<char> { '_' };
            public List<char> delim_hyphen = new List<char> { '-' };
            public List<char> id = new List<char>();
        }
        //IDENTIFIER DELIMITERS
        public class IdentifierDelims
        {
           
        }
    }
}
