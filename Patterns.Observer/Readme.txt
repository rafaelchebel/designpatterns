Observer 

Quando o acoplamento da nossa classe está crescendo, ou quando temos diversas ações diferentes a serem executadas após um determinado processo, podemos implementar o Observer.  

Ele permite que diversas ações sejam executadas de forma transparente à classe principal, reduzindo o acoplamento entre essas ações, facilitando a manutenção e evolução do código. 

 

Para começar, vamos encontrar algo em comum entre todas as ações que acontecem após a nota ser gerada: todas elas fazem algo com a Nota Fiscal logo após ela ser gerada. Podemos então criar uma interface para representar esse comportamento em comum. 

 

interface AcaoAposGerarNota  

{  

void Executa(NotaFiscal notaFiscal);  

}  

public class EnviadorDeEmail : AcaoAposGerarNota  

{  

public void Executa(NotaFiscal notaFiscal)  

{  

Console.WriteLine("enviando por e-mail");  

}  

}  

public class NotaFiscalDao : AcaoAposGerarNota  

{  

public void Executa(NotaFiscal notaFiscal)  

{  

Console.WriteLine("salvando no banco");  

}  

}  

public class EnviadorDeSms : AcaoAposGerarNota  

{  

public void Executa(NotaFiscal notaFiscal)  

{  

Console.WriteLine("enviando por sms");  

}  

}  

public class Impressora : AcaoAposGerarNota  

{  

public void Executa(NotaFiscal notaFiscal)  

{  

Console.WriteLine("imprimindo notaFiscal");  

}  

}  

Todas essas ações agora são AcaoAposGerarNota. Repare que, para o método constroi(), pouco importa qual ação está sendo executada. Ele simplesmente dispara uma ou mais ações. 

 

Exemplo: 

Imagina que você precise avisar 3 sistemas externos (auditoria, financeiro, e agências), assim que uma conta bancária receber um depósito. 

Em uma implementação procedural, todas essas atividades seriam invocadas logo após a operação de depósito, fazendo com que essa classe perca coesão, e fique complicada de ser entendida e mantida. 