using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class itens
{
    public string nome { get; set;}
    public string Class { get; set; }
    public string rank { get; set; }
    public int valor { get; set; }
    public int raridade { get; set;}
    public int dano { get; set;}
    public string informacao { get; set;}

//Falas Do Npc
     
    public virtual void MostrarDetalhes()
    {

        Console.WriteLine("--------========--------========");
        Console.Write("Detalhes do item escolhido:");
        Console.WriteLine();
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Classe: " + Class);
        Console.WriteLine("rank: " + rank);
        Console.WriteLine("Valor:" + valor);
        Console.WriteLine("Raridade:" + raridade);
        Console.WriteLine("Dano" + dano);
        Console.WriteLine("Vejamos.." + informacao);
        Console.WriteLine("--------========--------========");
    }
}
     
    class laminas : itens
    {
    public override void MostrarDetalhes()
    {    
        base.MostrarDetalhes();    
    }
}
 
    class Armas : itens
    {
    public override void MostrarDetalhes()
    {       
        base.MostrarDetalhes();       
    }
}

    class utilizaveis : itens
    {
    public override void MostrarDetalhes()
    {
        base.MostrarDetalhes(); 
    }
}
        //descrição dos item da loja
    class Loja
    {
        static void Main()
        {
            laminas laminas1 = new laminas()
            {
                nome = "Cursed Dual Katana",
                Class = "Samurai",
                rank = "Mitico",
                valor = 100,
                raridade = 89,
                dano = 25,
                informacao = "Afiada e Poderosa com ataques rapidos",
            };


            laminas laminas2 = new laminas()
            {
                nome = "Midnight Blade",
                Class = "Cavaleiro",
                rank = "Lendário",
                valor = 88,
                raridade = 66,
                dano = 12,
                informacao = "Essa aqui prende e não solta mais o inimigo",
            };

            laminas laminas3 = new laminas()
            {
                nome = "Hallow Scythe",
                Class = "Ceifador(a)",
                rank = "Secreto",
                valor = 0,
                raridade = 100,
                dano = 30,
                informacao = "Uma bela foice eu diria chega dá medo, Você é necromante?",

            };

            Armas armas1 = new Armas()
            {
                nome = "Serpent Bow",
                Class = "Arqueiro(a)",
                rank = "Lendário",
                valor = 46,
                raridade = 20,
                dano = 50,
                informacao = "Arco venenoso e com balas teleguiadas incrivel!",
            };

            Armas armas2 = new Armas()
            {
                nome = "Kabucha",
                Class = "Atirador(a)",
                rank = "Épico",
                valor = 50,
                raridade = 25,
                dano = 8,
                informacao = "QUE PASA?Não use isso perto da cidade!",
            };

            Armas armas3 = new Armas()
            {
                nome = "Bizarre Rifle",
                Class = "Sniper",
                rank = "Èpico/Secreto",
                valor = 78,
                raridade = 66,
                dano = 22,
                informacao = "Arma capaz de seguir até os mortos , porém é muito pesada vc tanka?",
            };

            utilizaveis ut1 = new utilizaveis()
            {
                nome = "Leviathan Shield",
                Class = "Escudo",
                rank = "Secreto",
                valor = 0,
                raridade = 100,
                dano = 0,
                informacao = "Defesa quase absoluta com 30% de defesa contra inimigos e 90% contra feras",
            };

            utilizaveis ut2 = new utilizaveis()
            {
                nome = "Dark Coat",
                Class = "Capa",
                rank = "Secreto",
                valor = 0,
                raridade = 100,
                dano = 15,
                informacao = "Item Limitado com uma maldição, quem usa nem sempre fica vivo!",
            };
        
             bool voltarMenu1;
             bool voltarMenu2;

             int x = 0;
              
             voltarMenu1 = false;
             
             do 
             {
             //Cadastro e Loja
             Console.Clear();
             Console.WriteLine("1 - Loja");
             Console.WriteLine("2 - Perfil *(incompleto)* ");
            
             int menu = int.Parse(Console.ReadLine());
             //Loja Aonde você vai conversar com um npc
             switch (menu)
             {
                case 1:
                 Console.Clear();
                 Console.WriteLine("===============================================");
                 Console.WriteLine("QUE PASA? Equipamentos Disponiveis a baixo do seu gosto!");
                 Console.WriteLine();
                 Console.WriteLine("== ============ ==  Loja  == =============== ==");
                 Console.WriteLine("===============================================");
                 Console.WriteLine("1 - Cursed Dual Katana");
                 Console.WriteLine("2 - Midnight Blade");
                 Console.WriteLine("3 - Hallow Scythe");
                 Console.WriteLine("4 - Serpent Bow");
                 Console.WriteLine("5 - Kabucha");
                 Console.WriteLine("6 - Bizarre Rifle");
                 Console.WriteLine("7 - Leviathan shield");
                 Console.WriteLine("8 - Dark Coat");
                 Console.WriteLine();
                 Console.WriteLine("9 - Voltar ao menu");
                 Console.WriteLine("===============================================");
                 int menu2 = int.Parse(Console.ReadLine());
                 itens equipamentos = null;
                 switch (menu2)
                 {
                      case 1:
                     equipamentos = laminas1;
                     break;
                     case 2:
                     equipamentos = laminas2;
                     break;
                     case 3:
                     equipamentos = laminas3;
                      break;
                     case 4:
                     equipamentos = armas1;
                     break;
                     case 5:              
                     equipamentos = armas2;
                     break;                
                     case 6:               
                     equipamentos = armas3;
                     break;              
                      case 7:              
                     equipamentos = ut1;
                     break;               
                     case 8:               
                     equipamentos = ut2;
                     break;
                     case 9:
                     voltarMenu1 = true;
                     break;
                     case 0:
                     int menu3 = int.Parse(Console.ReadLine());
                         switch(menu3)
                        {
                           case 1:
                           voltarMenu1 = true;
                           break;
                        }
                     break;
                     
                     default:
                     Console.WriteLine("QUE PASA? Opção invalida manito!");
                     return;
                
              }
              equipamentos.MostrarDetalhes();
              
              break;
              
              //Parte do perfil
               case 2:
               Console.WriteLine(" Perfil Imcompleto :c ");             
               break;
               case 3:
               voltarMenu1 = true;
               break;
               case 4:
               break;
             

              
            
            }
              } while (voltarMenu1);
        } 
     }  
    
