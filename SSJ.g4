grammar SSJ;

program: mostrar+ EOF;

mostrar: showCommand | conditionalCommand | declaration;

declaration: type TEXTO (IGUAL (STRING | NUMERO))?;

showCommand: 'show' PARENTESIS_IZQUIERDO (TEXTO | NUMERO | STRING) PARENTESIS_DERECHO;

conditionalCommand: ifCommand block elseBlock?;

ifCommand: 'if' PARENTESIS_IZQUIERDO expression PARENTESIS_DERECHO;

elseBlock: 'else' block;

block: LLAVE_IZ (mostrar)* LLAVE_DR;

expression:
    factor (OPERADOR_RELACIONAL factor)*;

factor:
    PARENTESIS_IZQUIERDO expression PARENTESIS_DERECHO |
    TEXTO OPERADOR_RELACIONAL (STRING | NUMERO | TEXTO) |
    NUMERO OPERADOR_RELACIONAL factor;

type: 'int' | 'string';

// Symbols used
PARENTESIS_DERECHO: ')';
PARENTESIS_IZQUIERDO: '(';
COMILLAS: '"';
LLAVE_IZ: '{';
LLAVE_DR: '}';
IGUAL: '=';
OPERADOR_RELACIONAL: '==' | '!=' | '>' | '<' | '>=' | '<=' | '&&';
NUMERO: [0-9]+;
STRING: '"' ~["]* '"';
TEXTO: [a-zA-Z_][a-zA-Z0-9_]*;
WS: [ \t\r\n] -> skip;
