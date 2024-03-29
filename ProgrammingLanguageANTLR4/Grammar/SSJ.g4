grammar SSJ;

program: mostrar* EOF;

mostrar:
	showCommand
	| conditionalCommand
	| declaration
	| postDeclaration
	| loopCommand;

declaration:
	type VARIABLE (IGUAL VARIABLE)? arithmeticOperations*;

postDeclaration:
	VARIABLE (IGUAL VARIABLE)? arithmeticOperations*;

arithmeticOperations: (OPERADOR_ARITMETICO VARIABLE);

showCommand:
	'show' PARENTESIS_IZQUIERDO VARIABLE PARENTESIS_DERECHO;

conditionalCommand: ifCommand block elseBlock?;

ifCommand:
	'if' PARENTESIS_IZQUIERDO (ifConditional ('&&' | '||')?)* PARENTESIS_DERECHO;

ifConditional:
	VARIABLE OPERADOR_RELACIONAL VARIABLE												# relationalIf
	| VARIABLE arithmeticOperations OPERADOR_RELACIONAL VARIABLE arithmeticOperations?	# aritmeticoIf
		;

loopCommand:
	'for' PARENTESIS_IZQUIERDO (declaration | postDeclaration) ';' conditionalLoop ';' operationLoop
		PARENTESIS_DERECHO LLAVE_IZ mostrar* LLAVE_DR												# for
	| 'while' PARENTESIS_IZQUIERDO conditionalLoop PARENTESIS_DERECHO LLAVE_IZ mostrar* LLAVE_DR	#
		while;

conditionalLoop:
	VARIABLE (OPERADOR_RELACIONAL VARIABLE)?											# relationalLoop
	| VARIABLE arithmeticOperations* OPERADOR_RELACIONAL VARIABLE arithmeticOperations*	#
		aritmeticoLoop;

operationLoop:
	VARIABLE (
		OPERADOR_ARITMETICO*
		| OPERADOR_ARITMETICO IGUAL VARIABLE?
	);

elseBlock: 'else' block;

block: LLAVE_IZ (mostrar)* LLAVE_DR;

type: 'int' | 'string';

// Symbols used
PARENTESIS_DERECHO: ')';
VARIABLE: (NUMERO | TEXTO | STRING) | (NUMERO | STRING);
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
