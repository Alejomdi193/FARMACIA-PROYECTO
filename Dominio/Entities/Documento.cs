
namespace Dominio.Entities;

    public class Documento : BaseEntity
    {
        public int Numero { get; set; }

        public int IdTipoDocumentoFk { get; set; }

        public TipoDocumento TipoDocumento {get; set;}
    }
