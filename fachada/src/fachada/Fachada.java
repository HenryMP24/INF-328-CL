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
public class Fachada {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        operaciones op=new operaciones();
        op.operar(3, 3);
        
    }
    
}
