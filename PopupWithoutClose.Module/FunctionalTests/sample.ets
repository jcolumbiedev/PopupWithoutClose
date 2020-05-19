;#DropDB PopupWithoutCloseEasyTest

#Application PopupWithoutCloseWin
#Application PopupWithoutCloseWeb
#IfDef PopupWithoutCloseWin

*Action About...
 
*Action OK

#EndIf

#IfDef PopupWithoutCloseWeb
!Action Navigation(My Details)
#EndIf
