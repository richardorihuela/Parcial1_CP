/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.calculadora;

/**
 *
 * @author Pi
 */
public class Pila {
    private int n;
    private int tope;
    private String pila[] = new String[100];

    public Pila(int n) {
        this.n = n;
        tope =0;
    }
    public boolean estaVacia(){
        return tope ==0;
    }
    public boolean estaLlena(){
        return tope ==n;
    }
    public boolean apilar(String dato){
        if (estaLlena()){
            return false;
        }
        pila[tope]=dato;
        tope++;
        return true;
    }
    public String desapilar(){
        if(estaVacia()){
            return null;
        } 
        tope--;
        return pila[tope];
    }
    public String elementotope(){
        return pila[tope-1];
    }
}
