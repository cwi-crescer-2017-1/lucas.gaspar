import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class SaintTest {
   @Test
   public void vestirArmaduraDeixaArmaduraVestida(){
       // AAA
       // 1. Arrange - Montagem dos dados de teste(cenário)
       Armadura escorpiao = new Armadura ("Escorpião");
       Saint Ryu = new Saint("Ryu", escorpiao);
       // 2. Act - Invocar a ação a ser testada
       Ryu.vestirArmadura();
       // 3. Assert - Verficação dos resultados de teste
       boolean resultado = Ryu.getArmaduraVestida();
       assertEquals(true, resultado);
   }

@Test
public void naoVestirArmaduraDeixaArmaduraNaoVestida(){
 	Armadura escorpiao = new Armadura ("Escorpião");
    Saint Ryu = new Saint("Ryu", escorpiao); 
	assertEquals(false, Ryu.getArmaduraVestida());
}

@Test
public void aoCriarSaintGeneroENaoInformado(){
    Armadura virgem = new Armadura("Virgem",Categoria.OURO);
	Saint Shaka = new Saint ("Shaka", virgem);
}

}
