import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class ListaSaintsTest
{
    @Test
    public void adicionarSaintAListaFunciona() throws Exception{
       Saint saga = new Saint("Saga", new Armadura(new Constelacao("Gêmeos"), Categoria.OURO));
       ListaSaints lista = new ListaSaints();
       lista.adicionarSaint(saga);
       assertEquals(saga, lista.todos().get(0));
    }
    
     @Test
    public void adicionarDoisSaintsAListaFunciona() throws Exception{
       Saint saga = new Saint("Saga", new Armadura(new Constelacao("Gêmeos"), Categoria.OURO));
       Saint pele = new Saint("Pelé", new Armadura(new Constelacao("Tartaruga"), Categoria.BRONZE));
       ListaSaints lista = new ListaSaints();
       lista.adicionarSaint(saga);
       lista.adicionarSaint(pele);
       assertEquals(saga, lista.todos().get(0));
       assertEquals(pele, lista.todos().get(1));
    }
    
    @Test
    public void getSaintPorIndiceRetornaOSaintCorretamente() throws Exception{
       Saint saga = new Saint("Saga", new Armadura(new Constelacao("Gêmeos"), Categoria.OURO));
       Saint pele = new Saint("Pelé", new Armadura(new Constelacao("Tartaruga"), Categoria.BRONZE));
       ListaSaints lista = new ListaSaints();
       lista.adicionarSaint(saga);
       lista.adicionarSaint(pele);
       assertEquals(pele, lista.getIndice(1));
    }
    
    @Test(expected=Exception.class)
    public void getSaintComIndiceInvalidoDaErro() throws Exception{
       Saint saga = new Saint("Saga", new Armadura(new Constelacao("Gêmeos"), Categoria.OURO));
       Saint pele = new Saint("Pelé", new Armadura(new Constelacao("Tartaruga"), Categoria.BRONZE));
       ListaSaints lista = new ListaSaints();
       lista.adicionarSaint(saga);
       lista.adicionarSaint(pele);
       assertEquals(pele, lista.getIndice(2));
    }
    
}
