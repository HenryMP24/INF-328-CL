/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package fachada;

/**
 *
 * @author Henry
 */
//la clase operaciones funciona como FACHADA 
public class operaciones {
    private multiplicacion mul;
    private division div;
    private suma sum;
    private resta res;
    
    public operaciones(){
        this.sum=new suma();
        this.res=new resta();
        this.mul= new multiplicacion();
        this.div= new division();
    }
    public void operar(int n1, int n2){
        System.out.println("la Suma es: "+sum.sumar(n1, n2));
        System.out.println("la Resta es: "+res.restar(n1, n2));
        System.out.println("la multiplicacion es: "+mul.multiplicar(n1, n2));
        System.out.println("la division es:"+div.dividir(n1, n2));
    }
}
