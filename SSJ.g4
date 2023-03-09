 grammar SSJ;


program: mostrar EOF;

mostrar: showCommand;

showCommand: 'show' PARENTESIS_IZQUIERDO
 (showString|showInt|showVariables)  PARENTESIS_DERECHO;

showString: COMILLAS TEXTO* COMILLAS;

showInt: NUMERO;

showVariables: TEXTO;

PARENTESIS_DERECHO: ')';
PARENTESIS_IZQUIERDO: '(';
COMILLAS: '"';
LLAVE_IZ: '{';
LLAVE_DR: '}';
NUMERO: [0-9]+;
TEXTO: [A-Za-z]+;

WS: [ \t\r\n] -> skip;