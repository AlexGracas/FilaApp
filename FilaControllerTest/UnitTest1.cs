using System;
using System.Collections.Generic;
using FilaModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FilaControllerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodOrdenarFila()
        {
            ISet<Pessoa> pessoas = GeradorDePessoa.GerarLista(100);
            FilaController.FilaController filaController = new FilaController.FilaController(new FakeFilaView(), pessoas);
            filaController.OrdenarFila();
            foreach(var p in filaController.FilaPrioridade)
            {
                Assert.IsTrue((DateTime.Now.Year - p.Nascimento.Year) > 60);
            }
            foreach (var p in filaController.FilaDiamante)
            {
                Assert.IsTrue(p.Assento.Especial);
                Assert.IsFalse(filaController.FilaPrioridade.Contains(p));
            }
            foreach (var p in filaController.Fila1)
            {
                Assert.IsTrue(p.Assento.Coluna.CompareTo("A") == 0 ||
                    p.Assento.Coluna.CompareTo("F") == 0);
                Assert.IsFalse(filaController.FilaPrioridade.Contains(p));
                Assert.IsFalse(filaController.FilaDiamante.Contains(p));
            }
            foreach (var p in filaController.Fila2)
            {
                Assert.IsTrue(p.Assento.Coluna.CompareTo("B") == 0 ||
                    p.Assento.Coluna.CompareTo("E") == 0);
                Assert.IsFalse(filaController.FilaPrioridade.Contains(p));
                Assert.IsFalse(filaController.FilaDiamante.Contains(p));
                Assert.IsFalse(filaController.Fila1.Contains(p));
            }

            foreach (var p in filaController.Fila3)
            {
                Assert.IsTrue(p.Assento.Coluna.CompareTo("C") == 0 ||
                    p.Assento.Coluna.CompareTo("D") == 0);
                Assert.IsFalse(filaController.FilaPrioridade.Contains(p));
                Assert.IsFalse(filaController.FilaDiamante.Contains(p));
                Assert.IsFalse(filaController.Fila1.Contains(p));
                Assert.IsFalse(filaController.Fila2.Contains(p));
            }
        }
    }
}
