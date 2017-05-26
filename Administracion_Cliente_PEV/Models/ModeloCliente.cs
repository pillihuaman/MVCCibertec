}using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PA.BusinessEntity.Base;

namespace Administracion_Cliente_PEV.Models
{
    using System.ComponentModel.DataAnnotations;
    public class ModeloCliente
    {
       
        public long IdCliente { get; set; }
        public string Usuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        [Required( ErrorMessage = "DNI Validado")]
        public string NumeroDocumento { get; set; }
        public string NumeroMovil { get; set; }

        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }

        public int IdRol { get; set; }
        public DateTime? FechaNacimiento { get; set; }

        #region PARTIAL

        public string Token { get; set; }
        public System.Guid Sesion { get; set; }
        public int IdEstado { get; set; }
        public string Rol { get; set; }
        public string Estado { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string FechaEmisionDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public bool Genero { get; set; }
        public bool RecibeBoletin { get; set; }
        public bool AceptaPolitica { get; set; }
        public string CodigoSeguimiento { get; set; }
        public long IdPedido { get; set; }
        public bool Error { get; set; }
        public string Respuesta { get; set; }
        public string Mensaje { get; set; }
        public bool EnvioPorStand { get; set; }
        public bool Entregado { get; set; }
        public int IdCanal { get; set; }
        public string Canal { get; set; }
        public string EstadoEntrega { get; set; }
        public string PedidoTipo { get; set; }
        public bool RecibeTarjeta { get; set; }
        public int? IdStand { get; set; }
        public string HorarioEntrega { get; set; }
        public string CodigoConfirmacionMovil { get; set; }
        public string CodigoConfirmacionEmail { get; set; }
        public bool Temporal { get; set; }
        public bool EsUsuarioUnibanca { get; set; }
        public bool TarjetaUnibanca { get; set; }

        #endregion

        public string Fijo { get; set; }
        public string Direccion { get; set; }
        public int IdTipoDocumento { get; set; }
        public int IdEstadoCivil { get; set; }
        public int IdTipoOperador { get; set; }
        public string Foto { get; set; }
        public int IdUsuarioUnibanca { get; set; }
        public string Html { get; set; }
        public long IdCuentaTarjeta { get; set; }

        public string NombreStand { get; set; }
        public Guid CodigoAfiliacion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Referencia { get; set; }

        public string Comentario { get; set; }

        public int IdEstadoPedido { get; set; }
        public string EstadoPedido { get; set; }
        public string EstadoSiguiente { get; set; }
        public bool EsTajetaUnibancaActiva { get; set; }
        public int IdEstadoUnibancaCuenta { get; set; }
        public string EstadoUnibancaCuenta { get; set; }
        public string NumeroTarjeta { get; set; }
        public int IdPerfil { get; set; }
        public DateTime FechaRegistroTarjeta { get; set; }

        public long IdCuenta { get; set; }

        public string Operador { get; set; }

        public string PerfilUsuario { get; set; }

        public string EntregadoPor { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public DateTime? FechaActivacion { get; set; }

        public DateTime? FechaEntrega { get; set; }

        public string UbicacionRegistro { get; set; }

        public string ModalidadEntrega { get; set; }

        public int IdTipoActivacion { get; set; }
    }
}