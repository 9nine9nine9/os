: LETTER-A
  8 *				\ Get line number
     2DUP % 00011000 DRAW-CHAR
  1+ 2DUP % 00111100 DRAW-CHAR
  1+ 2DUP % 01100110 DRAW-CHAR
  1+ 2DUP % 01100110 DRAW-CHAR
  1+ 2DUP % 01111110 DRAW-CHAR
  1+ 2DUP % 01100110 DRAW-CHAR
  1+ 2DUP % 01100110 DRAW-CHAR
  1+ 2DUP % 00000000 DRAW-CHAR DROP ;

: LETTER-O
  8 *				\ Get line number
     2DUP % 00111100 DRAW-CHAR
  1+ 2DUP % 01100110 DRAW-CHAR
  1+ 2DUP % 11000011 DRAW-CHAR
  1+ 2DUP % 11000011 DRAW-CHAR
  1+ 2DUP % 11000011 DRAW-CHAR
  1+ 2DUP % 01100110 DRAW-CHAR
  1+ 2DUP % 00111100 DRAW-CHAR
  1+ 2DUP % 00000000 DRAW-CHAR DROP ;

: LETTER-P
  8 *				\ Get line number
     2DUP % 11111100 DRAW-CHAR
  1+ 2DUP % 01100110 DRAW-CHAR
  1+ 2DUP % 01100110 DRAW-CHAR
  1+ 2DUP % 01111100 DRAW-CHAR
  1+ 2DUP % 01100000 DRAW-CHAR
  1+ 2DUP % 01100000 DRAW-CHAR
  1+ 2DUP % 11110000 DRAW-CHAR
  1+ 2DUP % 00000000 DRAW-CHAR DROP ;

: LETTER-Q
  8 *				\ Get line number
     2DUP % 00111100 DRAW-CHAR
  1+ 2DUP % 01100110 DRAW-CHAR
  1+ 2DUP % 11000011 DRAW-CHAR
  1+ 2DUP % 11011011 DRAW-CHAR
  1+ 2DUP % 11011011 DRAW-CHAR
  1+ 2DUP % 01101100 DRAW-CHAR
  1+ 2DUP % 00110110 DRAW-CHAR
  1+ 2DUP % 00000011 DRAW-CHAR DROP ;

: LETTER-S
  8 *				\ Get line number
     2DUP % 00111100 DRAW-CHAR
  1+ 2DUP % 01100110 DRAW-CHAR
  1+ 2DUP % 01100000 DRAW-CHAR
  1+ 2DUP % 00111100 DRAW-CHAR
  1+ 2DUP % 00000110 DRAW-CHAR
  1+ 2DUP % 01100110 DRAW-CHAR
  1+ 2DUP % 00111100 DRAW-CHAR
  1+ 2DUP % 00000000 DRAW-CHAR DROP ;

: LETTER-T
  8 *				\ Get line number
     2DUP % 11111111 DRAW-CHAR
  1+ 2DUP % 10011001 DRAW-CHAR
  1+ 2DUP % 00011000 DRAW-CHAR
  1+ 2DUP % 00011000 DRAW-CHAR
  1+ 2DUP % 00011000 DRAW-CHAR
  1+ 2DUP % 00011000 DRAW-CHAR
  1+ 2DUP % 00111100 DRAW-CHAR
  1+ 2DUP % 00000000 DRAW-CHAR DROP ;

: PUNCT-!
  8 *				\ Get line number
     2DUP % 00011000 DRAW-CHAR
  1+ 2DUP % 00111100 DRAW-CHAR
  1+ 2DUP % 00111100 DRAW-CHAR
  1+ 2DUP % 00011000 DRAW-CHAR
  1+ 2DUP % 00011000 DRAW-CHAR
  1+ 2DUP % 00000000 DRAW-CHAR
  1+ 2DUP % 00011000 DRAW-CHAR
  1+ 2DUP % 00000000 DRAW-CHAR DROP ;
