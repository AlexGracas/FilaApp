﻿using FilaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaModel
{
    public class GeradorDePessoa
    {
        private static Random r = new Random();

        private static List<String> Nomes = new List<string>() { "Abel","Abelardo","Abílio","Abraão","Abrahão","Abrão","Ada","Adalberto","Adalgisa","Adão","Adela","Adelaide","Adelberto","Adèle","Adélia","Adelina","Ademar","Adhemar","Adolfo","Adolpho","Adrian","Adriana","Adriane","Adrianne","Adriano","Adriene","Adrienne","Afonso","Ágata","Agatha","Agenor","Agnaldo","Agnes","Agostinho","Aguinaldo","Aída","Aiko","Aílton","Aimée","Airton","Ajit","Akahana","Akako","Alaíde","Alana","Alane","Alanna","Alanne","Alba","Alberta","Albertina","Alberto","Alceu","Alcides","Alcione","Alcyone","Alda","Aldaberto","Aldine","Aldo","Alec","Alecsandra","Alegra","Alejandra","Aleksandra","Alessandra","Alessandro","Alex","Alexandra","Alexandre","Aléxis","Alfonso","Alfredo","Alice","Alicia","Alisha","Allegra","Aloísio","Alonso","Aluísio","Álvaro","Alzira","Amadeu","Amadeus","Amália","Amanda","Amar","Amauri","Amaury","Amedeo","Amélia","Amélie","América","Américo","Amílcar","Amisha","Amita","Amiti","Amy","Ana","Anaís","Anastácia","Anastasia","André","Andréa","Andréia","Andresa","Andressa","Andreza","Andrezza","Anete","Angel","Ângela","Angeli","Angélica","Angelina","Angelita","Ângelo","Aníbal","Anísio","Anita","Anna","Anne","Annete","Anoush","Anselmo","Antenor","Antonela","Antonella","Antônia","Antonieta","Antônio","Aparecida","Aquiles","Araci","Aracy","Areta","Aretha","Ariana","Ariane","Ariela","Ariella","Arielle","Arlene","Arlete","Armando","Arnaldo","Arthur","Artur","Asha","Assunção","Astrid","Astride","Ataúlfo","Augusta","Augustina","Augustine","Augusto","Aurélia","Aurélio","Auro","Aurora","Auxiliadora","Ayrton","Ayumi","Babette","Balbina","Balraj","Baltazar","Bárbara","Barbie","Barbra","Bartolomeu","Basílio","Beata","Beatrice","Beatrix","Beatriz","Bela","Belinda","Bella","Belle","Benedicta","Benedicto","Benedita","Benedito","Benício","Benito","Benjamim","Benjamin","Bento","Berenice","Bernadete","Bernadette","Bernarda","Bernardino","Bernardo","Berta","Bertha","Betânia","Bete","Beth","Betina","Bianca","Biatriz","Blanche","Bóris","Branca","Brenda","Breno","Briana","Brianne","Bridget","Brígida","Brigite","Brigitte","Brione","Bruna","Brunete","Bruno","Cacilda","Caetano","Caio","Calista","Calixta","Calixto","Camélia","Camellia","Cameron","Camila","Camile","Camilla","Camille","Camilo","Candice","Cândida","Cândido","Capitu","Carina","Carine","Carla","Carlo","Carlos","Carlota","Carmel","Carmela","Carmelita","Carmem","Carmen","Carmina","Carmo","Carol","Carola","Carolina","Caroline","Carolyn","Carolyne","Cassandra","Cássia","Cassiano","Cassilda","Cássio","Catarina","Caterina","Catherine","Cécile","Cecília","Celeste","Célia","Celina","Céline","Célio","Celso","Ceres","César","Chandra","Charles","Charlotte","Chelsea","Chiara","Chloé","Christal","Christian","Christiana","Christiane","Christina","Christopher","Chrystal","Cibele","Cícero","Cilene","Cinthia","Cíntia","Ciro","Clair","Claire","Clara","Clarice","Clarissa","Clarisse","Claudete","Claudette","Cláudia","Cláudio","Cleide","Clélia","Cleusa","Cloé","Clotilda","Clotilde","Clotildes","Conceição","Conrado","Consuelo","Cora","Cordélia","Corina","Cornélia","Cosette","Creusa","Creuza","Cristal","Cristiana","Cristiane","Cristiano","Cristina","Cristóvão","Cynthia","Cyntia","Dafne","Dagmar","Dagmara","Daiana","Daiane","Daisy","Dália","Dalila","Dalton","Dalva","Damião","Dana","Daniel","Daniela","Daniele","Daniella","Danielle","Danilo","Dante","Daphne","Dara","Darci","Darcy","Daria","Dario","Darlene","Davi","David","Daya","Débora","Deborah","Décio","Deepak","Deise","Delfina","Délia","Demi","Denice","Dênis","Denise","Desirée","Deva","Devi","Dhara","Diana","Diane","Diego","Diná","Dinah","Diogo","Dione","Dionise","Dipak","Dirce","Dirceu","Diva","Djalma","Djane","Dolores","Dominique","Donata","Dora","Doralice","Dóris","Dorotéa","Dorotéia","Dorothy","Dulce","Dulcinéa","Dulcineia","Éder","Edgar","Édison","Edite","Edith","Edmundo","Edna","Édson","Eduardo","Elaine","Elba","Elenice","Eleonor","Eleonora","Eliana","Eliane","Elias","Élio","Elis","Elisa","Elisabete","Elisabeth","Eliseu","Eliza","Elizabete","Elizabeth","Eloá","Eloah","Eloísa","Elsa","Elvira","Elvis","Elza","Elzira","Ema","Emanuel","Emanuela","Emanuele","Emanuelle","Émerson","Emília","Emílio","Emily","Emma","Enrico","Enrique","Enzo","Erasmo","Eric","Érica","Érico","Érika","Ériko","Ernesto","Esmeralda","Esperança","Estéfano","Estela","Ester","Estevão","Esther","Eugênia","Eugênio","Eunice","Eva","Evandro","Evangelina","Eve","Évelin","Evelina","Eveline","Evelyn","Fábia","Fabiana","Fabiano","Fábio","Fabíola","Fabrícia","Fabrício","Fabrizio","Fanny","Fátima","Fausta","Faustina","Fausto","Felícia","Felício","Felipa","Felipe","Félix","Ferdinando","Fernanda","Fernando","Fernão","Filipa","Filipe","Filippo","Filomena","Fiona","Flávia","Flávio","Flor","Flora","Franca","Frances","Francesca","Francesco","Francine","Francis","Francisca","Francisco","Françoise","Frederico","Frida","Gabriel","Gabriela","Gabriele","Gabriella","Gabrielle","Gaetano","Ganesh","Genji","George","Georgia","Georgiana","Georgina","Geralda","Geraldo","Germano","Gérson","Gertrude","Gertrudes","Gervásio","Giancarlo","Gilberto","Gilda","Gilmar","Gilmara","Gilson","Gina","Gioconda","Giorgio","Giovana","Giovanna","Giovanni","Gisela","Giselda","Gisele","Gisella","Giselle","Gita","Giulia","Gizelda","Gládis","Gladys","Gláuber","Glauce","Gláucia","Glauco","Glenda","Glória","Gonçalo","Gonzalo","Graça","Grace","Graziela","Gregório","Greice","Greta","Gretchen","Guálter","Guilherme","Guiomar","Gunther","Gustavo","Gyselle","Hadrián","Haidê","Haideé","Halima","Hamilton","Hannah","Haydê","Hebe","Hector","Heidi","Heitor","Helena","Helenice","Helga","Hélio","Heloísa","Henrique","Henriqueta","Henry","Herculano","Hilda","Hildegard","Homero","Horácio","Horishi","Hortênsia","Hugo","Humberto","Iara","Ícaro","Idalina","Ieda","Iemanjá","Ignácio","Igor","Ilsa","Inácio","Indra","Inês","Inez","Ingrid","Íngride","Iolanda","Ioná","Ione","Iracema","Irene","Irina","Íris","Isa","Isaac","Isabel","Isabela","Isabele","Isabella","Isabelle","Isadora","Isaías","Isaura","Isidora","Isidoro","Ísis","Ismael","Israel","Ítalo","Itamar","Iuri","Ivã","Ivan","Ivete","Ivette","Ivo","Ivone","Ivonne","Izabela","Jaci","Jacira","Jacó","Jacob","Jacqueline","Jacques","Jacy","Jacyra","Jade","Jaime","Jair","Jairo","Jamal","Jamil","Jamila","Janaína","Jandir","Jandira","Jandyr","Jandyra","Jane","Janete","Janice","Jaqueline","Jasmim","Jasmin","Jasmina","Jasmine","Jean","Jefferson","Jeni","Jenifer","Jennifer","Jenny","Jeremias","Jéssica","Jin","Joana","Joanna","João","Joaquim","Joaquina","Joel","Joelle","Jonas","Jonatan","Jônatas","Jonathan","Jordana","Jordão","Jorge","José","Josefina","Josephine","Josias","Joy","Juarez","Judite","Judith","Júlia","Juliana","Juliano","Julieta","Júlio","Júnior","Jussara","Justina","Justino","Kaila","Kaio","Kalil","Kalila","Kaori","Karen","Karim","Karina","Karine","Karla","Karoline","Kássia","Kate","Katerine","Katharina","Katherine","Kátia","Katya","Keiko","Keila","Keith","Kelly","Kelvin","Késia","Khalil","Kim","Kin","Kristal","Kyoko","Laércio","Laerte","Laila","Lailah","Laís","Laísa","Lana","Lara","Larisa","Larissa","Lateefah","Latifa","Latiffa","Laura","Lauro","Lavínia","Layla","Lázaro","Léa","Leandra","Leandro","Leda","Léia","Leila","Leilah","Lenora","Leon","Leona","Leonardo","Leônidas","Leonor","Leonora","Leopoldo","Letícia","Letizia","Li","Lia","Lídia","Lien","Lígia","Lila","Lília","Lilian","Liliana","Liliane","Lina","Linda","Lindsay","Linete","Linette","Lineu","Lisa","Lisandra","Lisandro","Lívia","Lívio","Liza","Lizandra","Lizandro","Lola","Lorelei","Lorena","Lorenzo","Loreta","Lourdes","Lourenço","Luana","Luca","Lucas","Luci","Lúcia","Luciana","Luciane","Luciano","Luciene","Lucila","Lúcio","Lucy","Ludemila","Ludmila","Luigi","Luís","Luísa","Luiz","Luiza","Luna","Lurdes","Luzia","Lydia","Lynn","Mabel","Madalena","Mafalda","Magali","Magda","Magdalena","Magno","Maia","Maiara","Maíra","Maísa","Maitê","Malika","Manoel","Manoela","Manu","Manuel","Manuela","Manuelle","Maomé","Mara","Marcel","Marcela","Marcele","Marcella","Marcello","Marcelo","Márcia","Márcio","Marco","Marcos","Margarida","Margarita","Margot","Maria","Mariah","Mariana","Mariângela","Marianne","Mariano","Marília","Marina","Mário","Marisa","Marise","Mariza","Marize","Marjorie","Marlene","Marli","Marly","Marta","Martha","Martim","Martina","Marvin","Mary","Masculino","Mateus","Matheus","Mathias","Matias","Matilda","Matilde","Maura","Maurício","Mauro","Maya","Mayara","Mayra","Maysa","Megan","Meire","Melinda","Melissa","Melvin","Messias","Micael","Michaela","Michaella","Michel","Michele","Michelle","Midori","Miguel","Mika","Mildred","Milena","Milton","Mingmei","Miranda","Miriam","Mírian","Mirna","Miyoko","Moema","Moira","Moisés","Mônica","Monique","Moysés","Mozart","Muriel","Murilo","Nádia","Nadine","Nadir","Nadya","Naila","Nailah","Nair","Najma","Nancy","Naomi","Napoleão","Nara","Narcisa","Narciso","Natacha","Natália","Natalie","Natanael","Nataniel","Natasha","Nathalia","Nathanael","Nayana","Nazaré","Nei","Neide","Nélson","Nereu","Nestor","Neusa","Ney","Nice","Nicholas","Nicolas","Nicolau","Nicole","Nika","Nilse","Nílson","Nilton","Nilza","Nina","Nisha","Nívea","Nívia","Noel","Noemi","Noêmia","Nora","Norah","Norberto","Norma","Nórton","Nuno","Octávia","Octávio","Odete","Odette","Odila","Ofélia","Olavo","Olga","Olímpia","Olímpio","Oliver","Olívia","Olívio","Omar","Onofre","Ophelia","Orfeu","Orlando","Oscar","Osmar","Osvaldo","Oswaldo","Otávia","Otávio","Oto","Otto","Pablo","Paco","Paloma","Pamela","Paola","Paolo","Pascoal","Pasqual","Patrícia","Patrício","Patrick","Paula","Paulina","Paulo","Pedro","Penélope","Perla","Peter","Phillip","Phillippe","Pierre","Pietro","Pilar","Plínio","Priscila","Priscilla","Quincas","Quitéria","Rachel","Rafael","Rafaela","Rafaella","Raimundo","Raísa","Raíssa","Raj","Rajesh","Rani","Raphael","Raquel","Raul","Rebeca","Rebecca","Regiane","Regina","Reinaldo","Renan","Renata","Renato","Reneé","Reynaldo","Ricardo","Richard","Rita","Roberta","Roberto","Robinson","Robson","Rodolfo","Rodrigo","Roger","Rogéria","Rogério","Rolando","Romeu","Rômulo","Rosa","Rosana","Rosane","Rosário","Rose","Roxana","Roxane","Rubem","Rubens","Rui","Rute","Ruth","Ruy","Sabrina","Sacha","Safira","Salim","Salma","Salomão","Salomé","Salvador","Sálvio","Samanta","Samantha","Samara","Samir","Samira","Samuel","Sandra","Sandro","Sara","Sarah","Sasha","Saulo","Scarlet","Sebastião","Selene","Selma","Serafim","Serafina","Serena","Sérgio","Severino","Severo","Shakira","Sharon","Sheila","Sheilla","Shen","Shirlei","Shirley","Sibele","Sidnei","Sidney","Silena","Silvana","Sílvia","Sílvio","Simão","Simone","Socorro","Sofia","Solange","Sônia","Sophia","Sophie","Soraia","Soraya","Stefano","Stella","Sueli","Suely","Susana","Syon","Tábata","Tabita","Taciana","Tadeu","Taís","Takashi","Tales","Talita","Tamara","Tancredo","Tânia","Tarcísio","Tarsila","Tarso","Tassiana","Tatiana","Tatiane","Ted","Telma","Telmo","Teo","Teodora","Teodoro","Teresa","Thaís","Thales","Thalita","Thelma","Theo","Theodoro","Theresa","Thiago","Thomas","Thomaz","Tiago","Tito","Tobias","Tomás","Tomaz","Tomé","Trudy","Ubaldo","Ugo","Ulisses","Úlrica","Ulrika","Umberto","Urbano","Úrsula","Vagner","Valdemar","Valdemir","Valdir","Valdo","Valdomiro","Valentim","Valentina","Valentino","Valéria","Valério","Valmir","Valquíria","Valter","Vanda","Vanderlei","Vanderley","Vando","Vanessa","Vânia","Vera","Veridiana","Verônica","Vicente","Victor","Victorio","Vidal","Vilma","Vinício","Vinícius","Violeta","Virgínia","Vítor","Vitória","Vitório","Vivian","Viviana","Viviane","Vivien","Vladimir","Wagner","Waldemar","Waldemir","Waldemiro","Waldir","Waldo","Waldomiro","Waldyr","Wallace","Walmir","Walquíria","Walter","Wanda","Wanderley","Wando","Wanessa","Wendy","Wesley","William","Wilma","Wilson","Wilton","Wladimir","Xavier","Xaviera","Yasmim","Yasmin","Yasmina","Yasmine","Yoko","Yolanda","Yoná","Yone","Yoshi","Yukio","Yumi","Yuri","Yvette","Yvone","Zacarias","Zara","Zélia","Zenaide","Zenon","Zilda","Zoe","Zuleica","Zuleika","Zulmira"};
        public static string GerarNome()
        {

            return Nomes[r.Next(Nomes.Count())] + " " + Nomes[r.Next(Nomes.Count())];
        }

        public static Pessoa GerarPessoa()
        {
            Pessoa p = new Pessoa();
            p.Nome = GerarNome();
            p.Nascimento = new DateTime(DateTime.Now.Year - r.Next(80), r.Next(12)+1, r.Next(27)+1) ;
            p.CPF = r.Next(999).ToString().PadLeft(3, '0') + "." +
                r.Next(999).ToString().PadLeft(3,'0') + "." +
                r.Next(999).ToString().PadLeft(3, '0') + "-" +
                r.Next(99).ToString().PadLeft(2, '0');
            p.Assento = GerarAssento();
            return p;
        }

        public static ISet<Pessoa> GerarLista(int quantidade)
        {
            var pessoas = new HashSet<Pessoa>();
            while (quantidade-- > 0)
            {
                pessoas.Add(GeradorDePessoa.GerarPessoa());
            }
            return pessoas;
        }

        public static Assento GerarAssento()
        {
            List<string> Colunas = new List<string>() { "A", "B", "C", "D", "E", "F" };
            Assento assento = new Assento
            {
                Coluna = Colunas[r.Next(6)],
                Fila = r.Next(33)
            };
            if(assento.Fila < 6 || assento.Fila == 15 || assento.Fila ==16)
            {
                assento.Especial = true;
            }
            else
            {
                assento.Especial = false;
            }
            return assento;
        }
    }
}
