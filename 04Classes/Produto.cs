using System;
class Produto

{
    // Atributos da classe
    // Todo atributo privado só é acessivel dentro da própria class

    private   string nome;

    // Propriedades da class serve como filtro de acesso ao  atributos, tanto para acesar ou atribuir valores aos atributos da class

    public string Nome 
    {
        get
        {
            return nome;
        }
        set // Regra de acesso
        {
            if (value.Length > 1)
                nome = value;
            else
            throw new Exception("Nome do produto deve ter pelo menos dois caracteres.");  

            
        }
    }


    //private double preco; // Atributo
    //public double Preco  // Propriedade sem Regra de acesso
    //{
        //get {return preco;}
        //set {preco = value;}
    //}

    public double Preco { get; set; } // Atributos  automatico que gera os valores automaticamentecd
    
    public int Estoque { get; private set; }
}

// Revisão dos Atributos

// Atributos guardam valor na memoria enquanto as propriedades apenas nos da acesso direto aos atributos