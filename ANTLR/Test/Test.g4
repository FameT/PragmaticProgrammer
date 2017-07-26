// Define a grammar called Test
grammar Test;
options
{
	language = CSharp;
}
@parser::namespace { Generated }
@lexer::namespace  { Generated }
r  : 'hello' ID ;         // match keyword hello followed by an identifier
ID : [a-z]+ ;             // match lower-case identifiers
WS : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines