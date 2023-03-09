 grammar SSJ;


program: mostrar+ EOF;

mostrar: showCommand | 
conditionalCommand | declaration;


declaration: type TEXTO | 
type TEXTO IGUAL (STRING|NUMERO);

showCommand: 'show' 
PARENTESIS_IZQUIERDO 
(TEXTO|NUMERO|STRING)
PARENTESIS_DERECHO;


conditionalCommand: (ifCommad|elseCommand) 
PARENTESIS_IZQUIERDO (showVariables) 
PARENTESIS_DERECHO;


//CONDITIONS UTILS 
ifCommad: 'if';
elseCommand: 'else';

sentenceCommand: LLAVE_IZ (showCommand)*
LLAVE_DR;



//SHOWCOMAND UTILS 

showString: COMILLAS TEXTO* COMILLAS;

showInt: NUMERO;

showVariables: TEXTO;


type: 'int' | 'string' ;
//SIMBOLOS UTILIZADOS
PARENTESIS_DERECHO: ')';
PARENTESIS_IZQUIERDO: '(';
COMILLAS: '"';
LLAVE_IZ: '{';
LLAVE_DR: '}';
//OPERADORES DE ASIGNACION
IGUAL : '=';
//Generales
NUMERO: [0-9]+;
STRING: '"' ~["]* '"';
TEXTO: [a-zA-Z_][a-zA-Z0-9_]*;
WS: [ \t\r\n] -> skip;