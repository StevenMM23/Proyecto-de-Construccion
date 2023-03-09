grammar SSJ;

program: mostrar+ EOF;

mostrar: showCommand | 
conditionalCommand | 
declaration| postDeclaration| loopCommand;

declaration: type VARIABLE 
(IGUAL (VARIABLE))? | postDeclaration;

postDeclaration: VARIABLE 
(IGUAL (VARIABLE))?;


showCommand: 'show' PARENTESIS_IZQUIERDO 
VARIABLE PARENTESIS_DERECHO;

conditionalCommand: ifCommand block elseBlock?;

ifCommand: 'if' PARENTESIS_IZQUIERDO
expression PARENTESIS_DERECHO;

loopCommand: 
'for' PARENTESIS_IZQUIERDO 
(declarationLoop | postDeclaration)   
';' conditionalLoop ';' 
operationLoop PARENTESIS_DERECHO
LLAVE_IZ mostrar* LLAVE_DR | 

'while' PARENTESIS_IZQUIERDO
conditionalLoop PARENTESIS_DERECHO
LLAVE_IZ mostrar* LLAVE_DR;

declarationLoop: (declaration | postDeclaration); 

conditionalLoop: 
VARIABLE OPERADOR_RELACIONAL? VARIABLE?; 

operationLoop: VARIABLE (
(OPERADOR_ARITMETICO)* |
OPERADOR_ARITMETICO '=') VARIABLE?;


elseBlock: 'else' block;

block: LLAVE_IZ (mostrar)* LLAVE_DR;

expression: factor (OPERADOR_RELACIONAL 
factor)*;

factor: term (OPERADOR_ARITMETICO term)*;


term: TEXTO | NUMERO | STRING | PARENTESIS_IZQUIERDO expression PARENTESIS_DERECHO;

type: 'int' | 'string';

// Symbols used
PARENTESIS_DERECHO: ')';
VARIABLE: (NUMERO|TEXTO|STRING) 
| (NUMERO|STRING);
PARENTESIS_IZQUIERDO: '(';
COMILLAS: '"';
LLAVE_IZ: '{';
LLAVE_DR: '}';
IGUAL: '=';
OPERADOR_RELACIONAL: '==' | '!=' | '>' | '<' | '>=' | '<=';
OPERADOR_ARITMETICO: '+' | '-' | '*' | '/' | '%';
NUMERO: [0-9]+;
STRING: '"' ~["]* '"';
TEXTO: [a-zA-Z_][a-zA-Z0-9_]*;
WS: [ \t\r\n] -> skip;
