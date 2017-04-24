import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class GolpearTest{
    @Test
    public void saintCorretoRecebeDanoAoChamarAClasse() throws Exception {
        Saint june = new GoldSaint("June", "Libra");
        Saint marin = new SilverSaint("Marin", "Águia");
        june.vestirArmadura();
        june.getConstelacao().adicionarGolpe(new Golpe("Meteoro de Pégasus",10));
        Movimento g1 = new Golpear(june, marin);
        g1.executar();
        assertEquals(60, marin.getVida(), 0.01);
        assertEquals(100, june.getVida(), 0.01);
    }
    
    @Test
    public void saintDamenosDanoSemArmaduraVestida() throws Exception {
        Saint june = new GoldSaint("June", "Libra");
        Saint marin = new SilverSaint("Marin", "Águia");
        june.getConstelacao().adicionarGolpe(new Golpe("Meteoro de Pégasus",10));
        Movimento g1 = new Golpear(june, marin);
        g1.executar();
        assertEquals(90, marin.getVida(), 0.01);
        assertEquals(100, june.getVida(), 0.01);
    }
    
    
}
