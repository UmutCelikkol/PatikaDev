namespace OOP_interface;
// bir sinif sadece bir abstract siniftan miras alabilir
// bir abstract sinif birden fazla abstract siniftan miras alabilir
public abstract class Otomobil 
{
    public int KacTekerlektenOlusur(){
        return 4;
    }

    public virtual Renk StandartRengiNe(){
        return Renk.Beyaz;
    }
    public abstract Marka HangiMarkaninAraci(); // Miras verdigi siniflarda cagirip govdelerini orada yazabilmek icin abstract metod verdik

}