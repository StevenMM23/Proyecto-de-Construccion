grammar SSJ;

program: mostrar+ EOF;

mostrar: showCommand | 
conditionalCommand | 
declaration| postDeclaration|
loopCommand;

declaration: type  TEXTO
asignation?;

asignation: IGUAL VARIABLE;
postDeclaration: TEXTO 
asignation;


showCommand: 'show' PARENTESIS_IZQUIERDO 
VARIABLE PARENTESIS_DERECHO;

conditionalCommand: ifCommand
block elseBlock?;

ifCommand: 'if' PARENTESIS_IZQUIERDO
expression PARENTESIS_DERECHO;

loopCommand: 
'for' PARENTESIS_IZQUIERDO 
(declaration | postDeclaration)   
';' conditionalLoop ';' 
operationLoop PARENTESIS_DERECHO
LLAVE_IZ mostrar* LLAVE_DR | 

'while' PARENTESIS_IZQUIERDO
conditionalLoop PARENTESIS_DERECHO
LLAVE_IZ mostrar* LLAVE_DR;


conditionalLoop: 
TEXTO OPERADOR_RELACIONAL VARIABLE; 

operationLoop: TEXTO (
(OPERADOR_ARITMETICO)* |
OPERADOR_ARITMETICO '=') VARIABLE?;


elseBlock: 'else' block;

block: LLAVE_IZ
(mostrar)* LLAVE_DR;

expression: factor
(OPERADOR_RELACIONAL 
factor)*;

factor: term 
(OPERADOR_ARITMETICO term)*;


term: TEXTO |
NUMERO | STRING | 
PARENTESIS_IZQUIERDO 
expression PARENTESIS_DERECHO;

type: 'int' | 'string';

// Symbols used
PARENTESIS_DERECHO: ')';
VARIABLE: (NUMERO|STRING);
PARENTESIS_IZQUIERDO: '(';
COMILLAS: '"';
LLAVE_IZ: '{';
LLAVE_DR: '}';
IGUAL: '=';
OPERADOR_RELACIONAL: '==' | '!=' | '>' | '<' | '>=' | '<=';
OPERADOR_ARITMETICO: '+' | '-' | '*' | '/' | '%';

NUMERO: [0-9]+;
STRING: '"' ~["]*TEXTO '"';
TEXTO: [a-zA-Z_][a-zA-Z0-9_]*;
WS: [ \t\r\n] -> skip;
