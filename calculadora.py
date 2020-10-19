# -*- coding: utf-8 -*-
"""
Created on Fri Oct 16 15:16:17 2020

@author: Henry
"""

from tkinter import *
ventana =Tk()
ventana.title("calculadora")
i=0
#entrada datos
e_texto=Entry(ventana, font=("Calibri 20"))
e_texto.grid(row=0, column=0, columnspan=4, padx=5, pady=5)
#funcion
def click_buton(valor):
    global i
    e_texto.insert(i, valor)
    i+=1

def borrar():
    e_texto.delete(0,END)
    i=0   
def operaciones():
    ecuacion=e_texto.get()
    #con la funcion eval resolvemos los ejercicios
    resultado =eval(ecuacion)
    e_texto.delete(0,END)
    e_texto.insert(0,resultado)
    i=0
#botones
boton1=Button(ventana, text="1",width=5, height=2, command=lambda:click_buton(1))
boton2=Button(ventana, text="2",width=5, height=2, command=lambda:click_buton(2))
boton3=Button(ventana, text="3",width=5, height=2, command=lambda:click_buton(3))
boton4=Button(ventana, text="4",width=5, height=2, command=lambda:click_buton(4))
boton5=Button(ventana, text="5",width=5, height=2, command=lambda:click_buton(5))
boton6=Button(ventana, text="6",width=5, height=2, command=lambda:click_buton(6))
boton7=Button(ventana, text="7",width=5, height=2, command=lambda:click_buton(7))
boton8=Button(ventana, text="8",width=5, height=2, command=lambda:click_buton(8))
boton9=Button(ventana, text="9",width=5, height=2, command=lambda:click_buton(9))
boton0=Button(ventana, text="0",width=15, height=2, command=lambda:click_buton(0))

boton_bo=Button(ventana, text="C",width=5, height=2, command=lambda:borrar())
boton_par1=Button(ventana, text="(",width=5, height=2, command=lambda:click_buton("("))
boton_par2=Button(ventana, text=")",width=5, height=2, command=lambda:click_buton(")"))
boton_sum=Button(ventana, text="+",width=5, height=2, command=lambda:click_buton("+"))
boton_res=Button(ventana, text="-",width=5, height=2, command=lambda:click_buton("-"))
boton_mul=Button(ventana, text="*",width=5, height=2, command=lambda:click_buton("*"))
boton_div=Button(ventana, text="/",width=5, height=2, command=lambda:click_buton("/"))
boton_igual=Button(ventana, text="=",width=15, height=2, command=lambda:operaciones())

#posicionar botones
boton_bo.grid(row= 1, column= 0,padx=5, pady=5)
boton_par1.grid(row=1 , column= 1,padx=5, pady=5)
boton_par2.grid(row=1 , column= 2,padx=5, pady=5)
boton_div.grid(row= 1, column= 3,padx=5, pady=5)

boton7.grid(row= 2, column= 0,padx=5, pady=5)
boton8.grid(row=2 , column= 1,padx=5, pady=5)
boton9.grid(row=2 , column= 2,padx=5, pady=5)
boton_mul.grid(row= 2, column= 3,padx=5, pady=5)

boton4.grid(row= 3, column= 0,padx=5, pady=5)
boton5.grid(row=3 , column= 1,padx=5, pady=5)
boton6.grid(row=3 , column= 2,padx=5, pady=5)
boton_res.grid(row= 3, column= 3,padx=5, pady=5)

boton1.grid(row= 4, column= 0,padx=5, pady=5)
boton2.grid(row=4 , column= 1,padx=5, pady=5)
boton3.grid(row=4 , column= 2,padx=5, pady=5)
boton_sum.grid(row= 4, column= 3,padx=5, pady=5)

boton0.grid(row= 5, column= 0,padx=5, columnspan=2, pady=5)
boton_igual.grid(row=5 , column= 2, columnspan=2 ,padx=5, pady=5)

ventana.mainloop()
