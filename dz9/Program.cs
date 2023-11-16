using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Organizer organizer = new Organizer();
            Team russia = new Team();
            russia.AddPlayer("настя расслабонова");
            russia.AddPlayer("камиля большегрувова");
            russia.AddPlayer("владик армрестлеров");
            russia.AddPlayer("даня армрестлеров");
            russia.AddPlayer("стёпа ятебялюблю");
            russia.AddPlayer("лиза даслушаюяшаманаигимнроссиева");
            russia.AddPlayer("темир данкович");
            russia.AddPlayer("гайсар хорошев");
            russia.AddPlayer("дарья тяжелолюксова");
            russia.AddPlayer("амир гебешков");
            russia.AddPlayer("динар неходитнаисториев");
            russia.AddPlayer("ирина сишарповна");
            russia.AddPlayer("виктор бандеров");
            russia.AddPlayer("диана паролева");
            russia.AddPlayer("гульназ умничка");

            Team kazakhstan = new Team();
            kazakhstan.AddPlayer("даниэль м");
            kazakhstan.AddPlayer("адзен отчислилова");
            kazakhstan.AddPlayer("илюша матаналов");
            kazakhstan.AddPlayer("егор стобалловпопрогов");
            kazakhstan.AddPlayer("карим полторакомнатов");
            kazakhstan.AddPlayer("маратик супчиков");
            kazakhstan.AddPlayer("тимурик предпринимателев");
            kazakhstan.AddPlayer("игорь самокрутов");
            kazakhstan.AddPlayer("андрюша прохоров");
            kazakhstan.AddPlayer("борис силаев");
            kazakhstan.AddPlayer("мурад эдвардович");
            kazakhstan.AddPlayer("егор алгемов");
            kazakhstan.AddPlayer("наиль дваразаподрядотвечалнаисториев");
            kazakhstan.AddPlayer("данил ");
            kazakhstan.AddPlayer("алия ктотытакая");

            Team france = new Team();
            france.AddPlayer("олежа актёров");
            france.AddPlayer("рома жидков");
            france.AddPlayer("сашка землякЧЕЛЯБАРУЛИТ");
            france.AddPlayer("юлия общагова");
            france.AddPlayer("лёшка алгемов");
            france.AddPlayer("наиль барабанов");
            france.AddPlayer("лейсан винтажева");
            france.AddPlayer("адель каримов");
            france.AddPlayer("карим аделев");
            france.AddPlayer("алиса баскетболова");
            france.AddPlayer("лиза вожатова");
            france.AddPlayer("кирилл");
            france.AddPlayer("вадим");
            france.AddPlayer("андрей");
            france.AddPlayer("данил");

            Team china = new Team();
            china.AddPlayer("диана дель рей");
            china.AddPlayer("айгуль аэстетиковна");
            china.AddPlayer("самат добровечеров");
            china.AddPlayer("фархат микроволновков");
            china.AddPlayer("рустам хазрэт");
            china.AddPlayer("валера смоегоэтажаев");
            china.AddPlayer("алина ралиноазизовна");
            china.AddPlayer("мердан");
            china.AddPlayer("игнат");
            china.AddPlayer("влад организаторов");
            china.AddPlayer("катюша мизулина");
            china.AddPlayer("марат ганиев");
            china.AddPlayer("дина латыпова");
            china.AddPlayer("влад кофезатристарублеев");
            china.AddPlayer("адель добристоловов");

            organizer.AddNewPostmen();
            organizer.AddNewFishing();
            organizer.AddNewBeach();
            organizer.AddNewMouseTrap();
            organizer.AddNewSea();
            organizer.AddNewSlide();

            Sea sea = new Sea();
            sea.Play();

            Fishing fishing = new Fishing();
            fishing.Play();

            MouseTrap trap = new MouseTrap();
            trap.Play();

            Slide slide = new Slide();
            slide.Play();

            Beach beach = new Beach();
            beach.Play();

            Postmen postmen = new Postmen();
            postmen.Play();
        }
    }
}
