import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class BatalhaTest {
    @Test
    public void categoriaSaint1MaiorQueSaint2() {
        // Arrange
        Saint shaina = new Saint("Shaina", new Armadura("Serpente", Categoria.PRATA));
        Saint hyoga = new Saint("Hyoga", new Armadura("Cisne", Categoria.BRONZE));
        Batalha batalha = new Batalha(shaina, hyoga);
        // Act
        batalha.iniciar();
        // Assert
        assertEquals(100, shaina.getVida(), 0.01);
        assertEquals(90, hyoga.getVida(), 0.01);
    }
    
    @Test
    public void categoriasIguaisSaint2PerdeVida() {
        // Arrange
        Saint aldebaran = new Saint("Aldebaran", new Armadura("Touro", Categoria.OURO));
        Saint mascaraMorte = new Saint("Máscara da Morte", new Armadura("Câncer", Categoria.OURO));
        Batalha batalha = new Batalha(aldebaran, mascaraMorte);
        // Act
        batalha.iniciar();
        // Assert
        assertEquals(100, aldebaran.getVida(), 0.01);
        assertEquals(90, mascaraMorte.getVida(), 0.01);
    }
    
    @Test
    public void categoriaSaint2MaiorSaint1PerdeVida() {
        // Arrange
        Saint ikki = new Saint("Ikki", new Armadura("Fênix", Categoria.BRONZE));
        Saint mascaraMorte = new Saint("Máscara da Morte", new Armadura("Câncer", Categoria.OURO));
        Batalha batalha = new Batalha(ikki, mascaraMorte);
        // Act
        batalha.iniciar();
        // Assert
        assertEquals(90, ikki.getVida(), 0.01);
        assertEquals(100, mascaraMorte.getVida(), 0.01);
    }
}