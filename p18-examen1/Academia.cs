// esta es como la tienda 
//puede tener varias categorias como si fueran clientes

public class Academia {

    public string Nombre {get; set;}

    public string Propietario {get; set;}

    public string Domicilio {get; set;}

    public List <Categoria> Categorias {get; set;}

    //constructores para la creacion de la academia

    public Academia() => Categorias = new List<Categoria>();

    public Academia(string nombre, string propietario, string domicilio) : this() => (Nombre, Propietario, Domicilio) = (nombre, propietario, domicilio);

    //metodo para agregar categorias

    public void AgregarCategoria(Categoria categoria) => Categorias.Add(categoria);

    public override string ToString() => $"Nombre: {Nombre}\n Propietario: {Propietario}\n Domicilio: {Domicilio}";
}