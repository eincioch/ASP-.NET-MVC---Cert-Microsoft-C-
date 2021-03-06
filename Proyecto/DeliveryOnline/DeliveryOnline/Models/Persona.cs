///////////////////////////////////////////////////////////
//  Usuario.cs
//  Implementation of the Class Persona
//  Generated by Enterprise Architect
//  Created on:      30-Set.-2017 12:37:43
//  Original author: Enrique Incio Ch
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using DeliveryOnline.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace DeliveryOnline.Models {

    [Table("Persona", Schema = "Persona")]
    public class Persona {

		private string cApellidos;
		private string cDireccion;
		private string cEmail;
		private string cFonoCelular;
		private string cNombre;
		private string cPassword;
		private string cUsuario;
		private int Id = 0;

        public int ClienteId { get; set; }

        //Define una propiedad de navegaci�n para la colecci�n de objetos TipoCliente.
        public virtual DeliveryOnline.Models.TipoCliente TipoCliente { get; set; } //m_TipoCliente { get; set; }

        //public DeliveryOnline.Models.TiendaUsuario m_TiendaUsuario;
                
        public virtual ICollection<Tienda> Tiendas { get; set; }


        ~Persona(){

		}

        [Required]
        [Column("Nombres", TypeName = "Varchar")]
        [DisplayName("Nombres")]
        [ConcurrencyCheck, MaxLength(100, ErrorMessage = "Nombre debe tener 100 caracteres o menos"), MinLength(5)]
        public string Nombre
        {
            get
            {
                return cNombre;
            }
            set
            {
                cNombre = value;
            }
        }

        [Required]
        [Column("Apellidos", TypeName = "Varchar")]
        [ConcurrencyCheck, MaxLength(100, ErrorMessage = "Apellidos debe tener 100 caracteres o menos"), MinLength(5)]
        public string Apellidos{
			get{
				return cApellidos;
			}
			set{
				cApellidos = value;
			}
		}

        [Key()]
        [Column("CodigoId")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoId{
			get{
				return Id;
			}
			set{
				Id = value;
			}
		}

        [Required]
        [Column("Direccion", TypeName = "Varchar")]
        [ConcurrencyCheck, MaxLength(100, ErrorMessage = "Direccion debe tener 100 caracteres o menos"), MinLength(5)]
        public string Direccion{
			get{
				return cDireccion;
			}
			set{
				cDireccion = value;
			}
		}

        [Required]
        [Column("Email", TypeName = "Varchar")]
        [ConcurrencyCheck, MaxLength(80, ErrorMessage = "Email debe tener 80 caracteres o menos"), MinLength(5)]
        [DataType(DataType.EmailAddress,ErrorMessage ="E-mail no es valido")]
		public string Email{
			get{
				return cEmail;
			}
			set{
				cEmail = value;
			}
		}

        [Required]
        [Column("Celular", TypeName = "Varchar")]
        public string FonoCelular{
			get{
				return cFonoCelular;
			}
			set{
				cFonoCelular = value;
			}
		}

        [Required]
        [Column("Usuario", TypeName = "Varchar")]
        [DisplayName("Nombre Usuario")]
        [ConcurrencyCheck, MaxLength(15, ErrorMessage = "Usuario debe tener 15 caracteres o menos"), MinLength(5)]
        public string Usuario
        {
            get
            {
                return cUsuario;
            }
            set
            {
                cUsuario = value;
            }
        }

        [Required]
        [StringLength(100, ErrorMessage = "El {0} al menos debe ser {2} caracteres largos.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password{
			get{
				return cPassword;
			}
			set{
                cPassword = value;
			}
		}

	}//end Persona

}//end namespace Models