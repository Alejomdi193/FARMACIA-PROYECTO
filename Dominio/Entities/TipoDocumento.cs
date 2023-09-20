namespace Dominio.Entities;
    public class TipoDocumento: BaseEntity
    {
        public string Nombre { get; set; }

        public ICollection<Documento> Documentos {get; set;}


}
