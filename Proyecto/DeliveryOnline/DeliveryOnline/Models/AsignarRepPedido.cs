///////////////////////////////////////////////////////////
//  AsignarRepPedido.cs
//  Implementation of the Class AsignarRepPedido
//  Generated by Enterprise Architect
//  Created on:      29-Set.-2017 12:43:21
//  Original author: Enrique
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using DeliveryOnline.Models;
namespace DeliveryOnline.Models {
	public class AsignarRepPedido {

		private DateTime dFechaHoraEntrega;
		private DateTime dFechaHoraSalida;
		private int nEstado;
		public DeliveryOnline.Models.Pedido m_Pedido;
		public DeliveryOnline.Models.Repartidor m_Repartidor;

		public AsignarRepPedido(){

		}

		~AsignarRepPedido(){

		}

		public int Estado{
			get{
				return nEstado;
			}
			set{
				nEstado = value;
			}
		}

		public DateTime FechaHoraEntrega{
			get{
				return dFechaHoraEntrega;
			}
			set{
				dFechaHoraEntrega = value;
			}
		}

		public DateTime FechaHoraSalida{
			get{
				return dFechaHoraSalida;
			}
			set{
				dFechaHoraSalida = value;
			}
		}

	}//end AsignarRepPedido

}//end namespace Models