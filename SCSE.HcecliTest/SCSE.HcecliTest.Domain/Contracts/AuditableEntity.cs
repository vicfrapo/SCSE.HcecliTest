using SCSE.HcecliTest.Domain.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace SCSE.HcecliTest.Domain.Contracts
{
    public abstract class AuditableEntity<TId> : IAuditableEntity<TId>
    {
        [NotMapped]
        public TId Id { get; set; }
        [NotMapped]
        public string CreatedBy { get; set; }
        [NotMapped]
        public DateTime CreatedOn { get; set; }
        [NotMapped]
        public string LastModifiedBy { get; set; }
        [NotMapped]
        public DateTime? LastModifiedOn { get; set; }
    }
}
