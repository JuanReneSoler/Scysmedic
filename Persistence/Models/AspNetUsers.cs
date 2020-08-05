using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaims>();
            AspNetUserLogins = new HashSet<AspNetUserLogins>();
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
            AspNetUserTokens = new HashSet<AspNetUserTokens>();
            Citas = new HashSet<Citas>();
            Compra = new HashSet<Compra>();
            FarmaciaUser = new HashSet<FarmaciaUser>();
            HospitalUser = new HashSet<HospitalUser>();
            LaboratorioUser = new HashSet<LaboratorioUser>();
            Receta = new HashSet<Receta>();
            Resultado = new HashSet<Resultado>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }

        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual ICollection<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual ICollection<Citas> Citas { get; set; }
        public virtual ICollection<Compra> Compra { get; set; }
        public virtual ICollection<FarmaciaUser> FarmaciaUser { get; set; }
        public virtual ICollection<HospitalUser> HospitalUser { get; set; }
        public virtual ICollection<LaboratorioUser> LaboratorioUser { get; set; }
        public virtual ICollection<Receta> Receta { get; set; }
        public virtual ICollection<Resultado> Resultado { get; set; }
    }
}
