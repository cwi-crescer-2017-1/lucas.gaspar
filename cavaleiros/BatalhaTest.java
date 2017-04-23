import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class BatalhaTest {
    @Test
    public void categoriaSaint1MaiorQueSaint2() throws Exception {
        // Arrange
        Saint shaina = new SilverSaint("Shaina", "Serpente");
        Saint hyoga = new BronzeSaint("Hyoga", "Cisne");
        Batalha batalha = new Batalha(shaina, hyoga);
        shaina.getConstelacao().adicionarGolpe(new Golpe("Meteoro de Pégasus",10));
        hyoga.getConstelacao().adicionarGolpe(new Golpe("Meteoro de Pégasus",10));
        // Act
        batalha.iniciar();
        // Assert
        assertEquals(10, shaina.getVida(), 0.01);
        assertEquals(0, hyoga.getVida(), 0.01);
    }
    
    @Test
    public void categoriasIguaisSaint2PerdeVida() throws Exception {
        // Arrange
        Saint aldebaran = new GoldSaint("Aldebaran", "Touro");
        Saint mascaraMorte = new GoldSaint("Máscara da Morte", "Câncer");
        Batalha batalha = new Batalha(aldebaran, mascaraMorte);
        aldebaran.getConstelacao().adicionarGolpe(new Golpe("Meteoro de Pégasus",10));
        mascaraMorte.getConstelacao().adicionarGolpe(new Golpe("Meteoro de Pégasus",10));
        // Act
        batalha.iniciar();
        // Assert
        assertEquals(10, aldebaran.getVida(), 0.01);
        assertEquals(0, mascaraMorte.getVida(), 0.01);
    }
    
    @Test
    public void categoriaSaint2MaiorSaint1PerdeVida() throws Exception {
        // Arrange
        Saint ikki = new BronzeSaint("Ikki", "Fênix");
        Saint mascaraMorte = new GoldSaint("Máscara da Morte", "Câncer");
        Batalha batalha = new Batalha(ikki, mascaraMorte);
        ikki.getConstelacao().adicionarGolpe(new Golpe("Meteoro de Pégasus",10));
        mascaraMorte.getConstelacao().adicionarGolpe(new Golpe("Meteoro de Pégasus",10));
        // Act
        // Act
        batalha.iniciar();
        // Assert
        assertEquals(0, ikki.getVida(), 0.01);
        assertEquals(10, mascaraMorte.getVida(), 0.01);
    }
    
     @Test
    public void saintComArmaduraVestidaDaMaisDano() throws Exception {
        // Arrange
        Saint ikki = new BronzeSaint("Ikki", "Fênix");
        Saint mascaraMorte = new GoldSaint("Máscara da Morte", "Câncer");
        mascaraMorte.vestirArmadura();
        Batalha batalha = new Batalha(ikki, mascaraMorte);
        ikki.getConstelacao().adicionarGolpe(new Golpe("Meteoro de Pégasus",10));
        mascaraMorte.getConstelacao().adicionarGolpe(new Golpe("Meteoro de Pégasus",10));
        // Act
        // Act
        batalha.iniciar();
        // Assert
        assertEquals(0, ikki.getVida(), 0.01);
        assertEquals(80, mascaraMorte.getVida(), 0.01);
    }
    
    @Test
    public void saintPrataDaMaisDano() throws Exception {
        // Arrange
        Saint ikki = new BronzeSaint("Ikki", "Fênix");
        Saint mascaraMorte = new SilverSaint("Máscara da Morte", "Lagartixa");
        mascaraMorte.vestirArmadura();
        Batalha batalha = new Batalha(ikki, mascaraMorte);
        ikki.getConstelacao().adicionarGolpe(new Golpe("Meteoro de Pégasus",10));
        mascaraMorte.getConstelacao().adicionarGolpe(new Golpe("Meteoro de Pégasus",10));
        // Act
        // Act
        batalha.iniciar();
        // Assert
        assertEquals(0, ikki.getVida(), 0.01);
        assertEquals(70, mascaraMorte.getVida(), 0.01);
    }
    
}