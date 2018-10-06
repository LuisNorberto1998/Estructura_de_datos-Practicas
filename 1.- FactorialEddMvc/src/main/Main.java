package main;

import models.ModelFactorial;
import views.ViewFactorial;
import controllers.ControllerFactorial;

/**
 *
 * @author Norberto
 */
public class Main 
{

    private static ModelFactorial modelFactorial;
    private static ViewFactorial viewFactorial;
    private static ControllerFactorial controllerFactorial;

    public static void main(String[] args) 
    {
        modelFactorial = new ModelFactorial();
        viewFactorial = new ViewFactorial();
        controllerFactorial = new ControllerFactorial(modelFactorial, viewFactorial);
    }

}
