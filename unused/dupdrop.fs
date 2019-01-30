
\ TOS = HL, SP = C

( x -- x x )
code dup
  C dec,
  H A ld,
  A [C] ld,
  C dec,
  L A ld,
  A [C] ld,
end-code

( x -- )
code drop
  [C] A ld,
  A L ld,
  C inc,
  [C] A ld,
  A H ld,
  C inc,
end-code



H A ld,
A [C] ld,
\ eql
: ->A-> A ld, A ;
H ->A-> [C] ld,
