grammar SSJ;

program: mostrar+ EOF;

mostrar: showCommand | 
conditionalCommand | 
declaration| loopCommand;

declaration: type TEXTO 
(IGUAL (STRING | NUMERO))?;

showCommand: 'show' PARENTESIS_IZQUIERDO 
VARIABLE PARENTESIS_DERECHO;

conditionalCommand: ifCommand block elseBlock?;

ifCommand: 'if' PARENTESIS_IZQUIERDO
expression PARENTESIS_DERECHO;

loopCommand: 
'for' PARENTESIS_IZQUIERDO 
declarationLoop 
';' conditionalLoop ';' 
operationLoop PARENTESIS_DERECHO
LLAVE_IZ mostrar* LLAVE_DR | 

'while' PARENTESIS_IZQUIERDO
conditionalLoop PARENTESIS_DERECHO
LLAVE_IZ mostrar* LLAVE_DR;

declarationLoop: declaration; 

conditionalLoop: 
VARIABLE OPERADOR_RELACIONAL VARIABLE; 

operationLoop: TEXTO (
(OPERADOR_ARITMETICO)* |
OPERADOR_ARITMETICO '=') NUMERO?;


elseBlock: 'else' block;

block: LLAVE_IZ (mostrar)* LLAVE_DR;

expression: factor (OPERADOR_RELACIONAL 
factor)*;

factor: term (OPERADOR_ARITMETICO term)*;


term: TEXTO | NUMERO | STRING | PARENTESIS_IZQUIERDO expression PARENTESIS_DERECHO;

type: 'int' | 'string';

// Symbols used
PARENTESIS_DERECHO: ')';
VARIABLE: (NUMERO|TEXTO|STRING);
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
