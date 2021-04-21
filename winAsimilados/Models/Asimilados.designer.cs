﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace winAsimilados.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Asimilados")]
	public partial class AsimiladosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public AsimiladosDataContext() : 
				base(global::winAsimilados.Properties.Settings.Default.AsimiladosConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AsimiladosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AsimiladosDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AsimiladosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AsimiladosDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ResumenNomina> ResumenNomina
		{
			get
			{
				return this.GetTable<ResumenNomina>();
			}
		}
		
		public System.Data.Linq.Table<Nomina> Nomina
		{
			get
			{
				return this.GetTable<Nomina>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ResumenNomina")]
	public partial class ResumenNomina
	{
		
		private int _ID;
		
		private string _ResumenNominaID;
		
		private System.Nullable<int> _ResumenNominaTotalEmpleados;
		
		private System.Nullable<decimal> _ResumenNominaTotalIngresos;
		
		private System.Nullable<decimal> _ResumenNominaTotalIngresosBruto;
		
		private System.Nullable<decimal> _ResumenNominaTotalISR;
		
		private System.Nullable<System.DateTime> _ResumenNominaFechaPago;
		
		private System.Nullable<System.DateTime> _ResumenNominaFechaInicioPeri;
		
		private System.Nullable<System.DateTime> _ResumenNominaFechaFinPeri;
		
		private System.Nullable<System.DateTime> _ResumenNominaFechaCreacion;
		
		private string _ResumenNominaEstatus;
		
		private string _ResumenNominaEstatusSAT;
		
		private string _ResumenNominaPeriodo;
		
		private string _ResumenNominaEmpresaNombre;
		
		private string _ResumenNominaRFCEmpresa;
		
		private string _ResumenNominaUsuarioCreacion;
		
		private string _ResumenNominaUsuarioCierrePeriodo;
		
		private System.Nullable<System.DateTime> _ResumenNominaUsuarioFechaCierre;
		
		private string _ResumenNominaNominaEmpresaID;
		
		public ResumenNomina()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResumenNominaID", DbType="VarChar(MAX)")]
		public string ResumenNominaID
		{
			get
			{
				return this._ResumenNominaID;
			}
			set
			{
				if ((this._ResumenNominaID != value))
				{
					this._ResumenNominaID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResumenNominaTotalEmpleados", DbType="Int")]
		public System.Nullable<int> ResumenNominaTotalEmpleados
		{
			get
			{
				return this._ResumenNominaTotalEmpleados;
			}
			set
			{
				if ((this._ResumenNominaTotalEmpleados != value))
				{
					this._ResumenNominaTotalEmpleados = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResumenNominaTotalIngresos", DbType="Money")]
		public System.Nullable<decimal> ResumenNominaTotalIngresos
		{
			get
			{
				return this._ResumenNominaTotalIngresos;
			}
			set
			{
				if ((this._ResumenNominaTotalIngresos != value))
				{
					this._ResumenNominaTotalIngresos = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResumenNominaTotalIngresosBruto", DbType="Money")]
		public System.Nullable<decimal> ResumenNominaTotalIngresosBruto
		{
			get
			{
				return this._ResumenNominaTotalIngresosBruto;
			}
			set
			{
				if ((this._ResumenNominaTotalIngresosBruto != value))
				{
					this._ResumenNominaTotalIngresosBruto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResumenNominaTotalISR", DbType="Money")]
		public System.Nullable<decimal> ResumenNominaTotalISR
		{
			get
			{
				return this._ResumenNominaTotalISR;
			}
			set
			{
				if ((this._ResumenNominaTotalISR != value))
				{
					this._ResumenNominaTotalISR = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResumenNominaFechaPago", DbType="DateTime")]
		public System.Nullable<System.DateTime> ResumenNominaFechaPago
		{
			get
			{
				return this._ResumenNominaFechaPago;
			}
			set
			{
				if ((this._ResumenNominaFechaPago != value))
				{
					this._ResumenNominaFechaPago = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResumenNominaFechaInicioPeri", DbType="DateTime")]
		public System.Nullable<System.DateTime> ResumenNominaFechaInicioPeri
		{
			get
			{
				return this._ResumenNominaFechaInicioPeri;
			}
			set
			{
				if ((this._ResumenNominaFechaInicioPeri != value))
				{
					this._ResumenNominaFechaInicioPeri = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResumenNominaFechaFinPeri", DbType="DateTime")]
		public System.Nullable<System.DateTime> ResumenNominaFechaFinPeri
		{
			get
			{
				return this._ResumenNominaFechaFinPeri;
			}
			set
			{
				if ((this._ResumenNominaFechaFinPeri != value))
				{
					this._ResumenNominaFechaFinPeri = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResumenNominaFechaCreacion", DbType="DateTime")]
		public System.Nullable<System.DateTime> ResumenNominaFechaCreacion
		{
			get
			{
				return this._ResumenNominaFechaCreacion;
			}
			set
			{
				if ((this._ResumenNominaFechaCreacion != value))
				{
					this._ResumenNominaFechaCreacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResumenNominaEstatus", DbType="VarChar(100)")]
		public string ResumenNominaEstatus
		{
			get
			{
				return this._ResumenNominaEstatus;
			}
			set
			{
				if ((this._ResumenNominaEstatus != value))
				{
					this._ResumenNominaEstatus = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResumenNominaEstatusSAT", DbType="VarChar(100)")]
		public string ResumenNominaEstatusSAT
		{
			get
			{
				return this._ResumenNominaEstatusSAT;
			}
			set
			{
				if ((this._ResumenNominaEstatusSAT != value))
				{
					this._ResumenNominaEstatusSAT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResumenNominaPeriodo", DbType="VarChar(100)")]
		public string ResumenNominaPeriodo
		{
			get
			{
				return this._ResumenNominaPeriodo;
			}
			set
			{
				if ((this._ResumenNominaPeriodo != value))
				{
					this._ResumenNominaPeriodo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResumenNominaEmpresaNombre", DbType="VarChar(MAX)")]
		public string ResumenNominaEmpresaNombre
		{
			get
			{
				return this._ResumenNominaEmpresaNombre;
			}
			set
			{
				if ((this._ResumenNominaEmpresaNombre != value))
				{
					this._ResumenNominaEmpresaNombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResumenNominaRFCEmpresa", DbType="VarChar(20)")]
		public string ResumenNominaRFCEmpresa
		{
			get
			{
				return this._ResumenNominaRFCEmpresa;
			}
			set
			{
				if ((this._ResumenNominaRFCEmpresa != value))
				{
					this._ResumenNominaRFCEmpresa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResumenNominaUsuarioCreacion", DbType="VarChar(100)")]
		public string ResumenNominaUsuarioCreacion
		{
			get
			{
				return this._ResumenNominaUsuarioCreacion;
			}
			set
			{
				if ((this._ResumenNominaUsuarioCreacion != value))
				{
					this._ResumenNominaUsuarioCreacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResumenNominaUsuarioCierrePeriodo", DbType="VarChar(100)")]
		public string ResumenNominaUsuarioCierrePeriodo
		{
			get
			{
				return this._ResumenNominaUsuarioCierrePeriodo;
			}
			set
			{
				if ((this._ResumenNominaUsuarioCierrePeriodo != value))
				{
					this._ResumenNominaUsuarioCierrePeriodo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResumenNominaUsuarioFechaCierre", DbType="DateTime")]
		public System.Nullable<System.DateTime> ResumenNominaUsuarioFechaCierre
		{
			get
			{
				return this._ResumenNominaUsuarioFechaCierre;
			}
			set
			{
				if ((this._ResumenNominaUsuarioFechaCierre != value))
				{
					this._ResumenNominaUsuarioFechaCierre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResumenNominaNominaEmpresaID", DbType="VarChar(100)")]
		public string ResumenNominaNominaEmpresaID
		{
			get
			{
				return this._ResumenNominaNominaEmpresaID;
			}
			set
			{
				if ((this._ResumenNominaNominaEmpresaID != value))
				{
					this._ResumenNominaNominaEmpresaID = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Nomina")]
	public partial class Nomina
	{
		
		private int _nominaID;
		
		private System.Nullable<int> _nominanumEmpl;
		
		private string _nominanombreEmpleado;
		
		private string _nominaRFCEmpleado;
		
		private string _nominaPeriodidicadPago;
		
		private System.Nullable<decimal> _nominaIngresos;
		
		private System.Nullable<decimal> _nominaIngresosBruto;
		
		private System.Nullable<decimal> _nominaISR;
		
		private System.Nullable<System.DateTime> _nominaFechaPago;
		
		private System.Nullable<System.DateTime> _nominaFechaIniPeri;
		
		private System.Nullable<System.DateTime> _nominaFechaFinPero;
		
		private System.Nullable<System.DateTime> _nominaFechaCreacion;
		
		private string _nominaEstatus;
		
		private string _nominaEstatusSAT;
		
		private string _nominaPeriodo;
		
		private string _nominaEmpresa;
		
		private string _nominaRFCEmpresa;
		
		private string _nominaIDEmp;
		
		private string _nominaDescripciponError;
		
		private string _nominaEmpresaNominaID;
		
		private string _nominaUsuario;
		
		private string _nominaUsuarioCierrePeriodo;
		
		private System.Nullable<System.DateTime> _nominaFechaCierrePeriodo;
		
		private string _ResumenNominaID;
		
		private string _nominaUUID;
		
		private string _nominaFolio;
		
		public Nomina()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominaID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int nominaID
		{
			get
			{
				return this._nominaID;
			}
			set
			{
				if ((this._nominaID != value))
				{
					this._nominaID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominanumEmpl", DbType="Int")]
		public System.Nullable<int> nominanumEmpl
		{
			get
			{
				return this._nominanumEmpl;
			}
			set
			{
				if ((this._nominanumEmpl != value))
				{
					this._nominanumEmpl = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominanombreEmpleado", DbType="VarChar(500)")]
		public string nominanombreEmpleado
		{
			get
			{
				return this._nominanombreEmpleado;
			}
			set
			{
				if ((this._nominanombreEmpleado != value))
				{
					this._nominanombreEmpleado = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominaRFCEmpleado", DbType="VarChar(500)")]
		public string nominaRFCEmpleado
		{
			get
			{
				return this._nominaRFCEmpleado;
			}
			set
			{
				if ((this._nominaRFCEmpleado != value))
				{
					this._nominaRFCEmpleado = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominaPeriodidicadPago", DbType="VarChar(20)")]
		public string nominaPeriodidicadPago
		{
			get
			{
				return this._nominaPeriodidicadPago;
			}
			set
			{
				if ((this._nominaPeriodidicadPago != value))
				{
					this._nominaPeriodidicadPago = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominaIngresos", DbType="Money")]
		public System.Nullable<decimal> nominaIngresos
		{
			get
			{
				return this._nominaIngresos;
			}
			set
			{
				if ((this._nominaIngresos != value))
				{
					this._nominaIngresos = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominaIngresosBruto", DbType="Money")]
		public System.Nullable<decimal> nominaIngresosBruto
		{
			get
			{
				return this._nominaIngresosBruto;
			}
			set
			{
				if ((this._nominaIngresosBruto != value))
				{
					this._nominaIngresosBruto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominaISR", DbType="Money")]
		public System.Nullable<decimal> nominaISR
		{
			get
			{
				return this._nominaISR;
			}
			set
			{
				if ((this._nominaISR != value))
				{
					this._nominaISR = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominaFechaPago", DbType="DateTime")]
		public System.Nullable<System.DateTime> nominaFechaPago
		{
			get
			{
				return this._nominaFechaPago;
			}
			set
			{
				if ((this._nominaFechaPago != value))
				{
					this._nominaFechaPago = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominaFechaIniPeri", DbType="DateTime")]
		public System.Nullable<System.DateTime> nominaFechaIniPeri
		{
			get
			{
				return this._nominaFechaIniPeri;
			}
			set
			{
				if ((this._nominaFechaIniPeri != value))
				{
					this._nominaFechaIniPeri = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominaFechaFinPero", DbType="DateTime")]
		public System.Nullable<System.DateTime> nominaFechaFinPero
		{
			get
			{
				return this._nominaFechaFinPero;
			}
			set
			{
				if ((this._nominaFechaFinPero != value))
				{
					this._nominaFechaFinPero = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominaFechaCreacion", DbType="DateTime")]
		public System.Nullable<System.DateTime> nominaFechaCreacion
		{
			get
			{
				return this._nominaFechaCreacion;
			}
			set
			{
				if ((this._nominaFechaCreacion != value))
				{
					this._nominaFechaCreacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominaEstatus", DbType="VarChar(100)")]
		public string nominaEstatus
		{
			get
			{
				return this._nominaEstatus;
			}
			set
			{
				if ((this._nominaEstatus != value))
				{
					this._nominaEstatus = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominaEstatusSAT", DbType="VarChar(100)")]
		public string nominaEstatusSAT
		{
			get
			{
				return this._nominaEstatusSAT;
			}
			set
			{
				if ((this._nominaEstatusSAT != value))
				{
					this._nominaEstatusSAT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominaPeriodo", DbType="VarChar(10)")]
		public string nominaPeriodo
		{
			get
			{
				return this._nominaPeriodo;
			}
			set
			{
				if ((this._nominaPeriodo != value))
				{
					this._nominaPeriodo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominaEmpresa", DbType="VarChar(MAX)")]
		public string nominaEmpresa
		{
			get
			{
				return this._nominaEmpresa;
			}
			set
			{
				if ((this._nominaEmpresa != value))
				{
					this._nominaEmpresa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominaRFCEmpresa", DbType="VarChar(20)")]
		public string nominaRFCEmpresa
		{
			get
			{
				return this._nominaRFCEmpresa;
			}
			set
			{
				if ((this._nominaRFCEmpresa != value))
				{
					this._nominaRFCEmpresa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominaIDEmp", DbType="VarChar(100)")]
		public string nominaIDEmp
		{
			get
			{
				return this._nominaIDEmp;
			}
			set
			{
				if ((this._nominaIDEmp != value))
				{
					this._nominaIDEmp = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominaDescripciponError", DbType="VarChar(MAX)")]
		public string nominaDescripciponError
		{
			get
			{
				return this._nominaDescripciponError;
			}
			set
			{
				if ((this._nominaDescripciponError != value))
				{
					this._nominaDescripciponError = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominaEmpresaNominaID", DbType="VarChar(20)")]
		public string nominaEmpresaNominaID
		{
			get
			{
				return this._nominaEmpresaNominaID;
			}
			set
			{
				if ((this._nominaEmpresaNominaID != value))
				{
					this._nominaEmpresaNominaID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominaUsuario", DbType="VarChar(100)")]
		public string nominaUsuario
		{
			get
			{
				return this._nominaUsuario;
			}
			set
			{
				if ((this._nominaUsuario != value))
				{
					this._nominaUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominaUsuarioCierrePeriodo", DbType="VarChar(100)")]
		public string nominaUsuarioCierrePeriodo
		{
			get
			{
				return this._nominaUsuarioCierrePeriodo;
			}
			set
			{
				if ((this._nominaUsuarioCierrePeriodo != value))
				{
					this._nominaUsuarioCierrePeriodo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominaFechaCierrePeriodo", DbType="DateTime")]
		public System.Nullable<System.DateTime> nominaFechaCierrePeriodo
		{
			get
			{
				return this._nominaFechaCierrePeriodo;
			}
			set
			{
				if ((this._nominaFechaCierrePeriodo != value))
				{
					this._nominaFechaCierrePeriodo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResumenNominaID", DbType="VarChar(MAX)")]
		public string ResumenNominaID
		{
			get
			{
				return this._ResumenNominaID;
			}
			set
			{
				if ((this._ResumenNominaID != value))
				{
					this._ResumenNominaID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominaUUID", DbType="VarChar(MAX)")]
		public string nominaUUID
		{
			get
			{
				return this._nominaUUID;
			}
			set
			{
				if ((this._nominaUUID != value))
				{
					this._nominaUUID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominaFolio", DbType="VarChar(10)")]
		public string nominaFolio
		{
			get
			{
				return this._nominaFolio;
			}
			set
			{
				if ((this._nominaFolio != value))
				{
					this._nominaFolio = value;
				}
			}
		}
	}
}
#pragma warning restore 1591