package controllers;

import java.awt.HeadlessException;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JOptionPane;
import models.ModelFactorial;
import views.ViewFactorial;

/**
 *
 * @author Norberto
 */
public class ControllerFactorial implements ActionListener {

    ModelFactorial modelFactorial;
    ViewFactorial viewFactorial;

    public ControllerFactorial(ModelFactorial modelFactorial, ViewFactorial viewFactorial) {
        this.modelFactorial = modelFactorial;
        this.viewFactorial = viewFactorial;
        this.viewFactorial.jbBorrar.addActionListener(this);
        this.viewFactorial.jbCalcular.addActionListener(this);
        initFactorial();
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == viewFactorial.jbCalcular) {
            btnCalcular();
        } else if (e.getSource() == viewFactorial.jbBorrar) {
            btnBorrar();
        }
    }

    public void btnCalcular() {
        try {
            long TInicio, TFin, tiempo; //Variables para determinar el tiempo de ejecución
            TInicio = System.currentTimeMillis();
            modelFactorial.setNumero(Double.parseDouble(viewFactorial.jtfNumero.getText()));
            Double factorialNumero = modelFactorial.getNumero();
            if (factorialNumero < 100 && factorialNumero > 0) {
                Double factorialResult = 1.0;

                for (int i = 1; i < factorialNumero; i++) {
                    factorialResult += factorialResult * i;
                    System.out.println(i);
                    System.out.println(factorialResult);

                }
                modelFactorial.setResultado(factorialResult);
                viewFactorial.jlResultado.setText(modelFactorial.getResultado().toString());
            } else if (factorialNumero == 0) {
                viewFactorial.jlResultado.setText("1");
            } else {
                JOptionPane.showMessageDialog(null, "Solo puedes obtener el factorial del '1 al 99'");
            }
            TFin = System.currentTimeMillis(); //Tomamos la hora en que finalizó el algoritmo y la almacenamos en la variable T
            tiempo = TFin - TInicio; //Calculamos los milisegundos de diferencia
            System.out.println("Tiempo de ejecución en milisegundos: " + tiempo); //Mostramos en pantalla el tiempo de ejecución en milisegundos

        } catch (HeadlessException | NumberFormatException e) {
            JOptionPane.showMessageDialog(null, "Solo se permiten números\n" + e);
        }
    }

    public void btnBorrar() {
        viewFactorial.jlResultado.setText("");
        viewFactorial.jtfNumero.setText("");
    }

    private void initFactorial() {
        viewFactorial.setTitle("Calculo de número facotorial");
        viewFactorial.setLocationRelativeTo(null);
        viewFactorial.setResizable(false);
        viewFactorial.setVisible(true);
    }

}
