using System;
using System.Data;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CARSO.AppService.ServiceDataAccess;
using CARSO.LogLibrary.ServiceDataAccess;
using CARSO.LogLibrary.ServiceDataContainers;

namespace CARSO.AppService.ServiceDataContainers
{
    /// <summary>
    /// Registro de llamadas y respuestas a la Web API de Trálix
    /// </summary>
    [Serializable]
    [DataContract(IsReference = true)]
    public class RequestWebApi : IDataContainer
    {
        #region Properties
        /// <summary>
        /// Llave primeria del registro de la llamada a la web api de trálix
        /// </summary>
        [DataMember]
        public long idRequest { get; set; }
        /// <summary>
        /// Identificador del registro a procesar
        /// </summary>
        [DataMember]
        public string idTicket { get; set; }
        /// <summary>
        /// Identificador del recibo
        /// </summary>
        [DataMember]
        public long idRecibo { get; set; }
        /// <summary>
        /// URI del método de la API que se manda a invocar
        /// </summary>
        [DataMember]
        public string methodAddress { get; set; }
        /// <summary>
        /// JSON de la petición a la Web API
        /// </summary>
        [DataMember]
        public string dsRequest { get; set; }
        /// <summary>
        /// JSON de la respuesta de la Web API
        /// </summary>
        [DataMember]
        public string dsResponse { get; set; }
        /// <summary>
        /// fecha en la que se hizo la petición.
        /// </summary>
        [DataMember]
        public string feRequest { get; set; }
        /// <summary>
        /// fecha en que respondió el servicio
        /// </summary>
        [DataMember]
        public string feRespose { get; set; }
        /// <summary>
        /// Indica si el request fue exitoso o no
        /// </summary>
        [DataMember]
        public byte esExitoso { get; set; }
        #endregion Properties

        #region Constructors
        /// <summary>
        /// Constructor de la Clase Registro de llamadas y respuestas a la Web API de Trálix  
        /// </summary>
        public RequestWebApi()
        {
            this.idRequest = 0;
            this.idTicket = string.Empty;
            this.idRecibo = 0;
            this.methodAddress = string.Empty;
            this.dsRequest = string.Empty;
            this.dsResponse = string.Empty;
            this.feRequest = string.Empty;
            this.feRespose = string.Empty;
            this.esExitoso = 0;
        }
        #endregion Constructors

        #region Compare
        public int CompareTo(RequestWebApi rhs, RequestWebApi.RequestWebApiComparer.RequestWebApiTipoComparacion which)
        {
            switch (which)
            {
                case RequestWebApiComparer.RequestWebApiTipoComparacion.idRequest: return this.idRequest.CompareTo(rhs.idRequest);
                case RequestWebApiComparer.RequestWebApiTipoComparacion.idTicket: return this.idTicket.CompareTo(rhs.idTicket);
                case RequestWebApiComparer.RequestWebApiTipoComparacion.idRecibo: return this.idRecibo.CompareTo(rhs.idRecibo);
                case RequestWebApiComparer.RequestWebApiTipoComparacion.methodAddress: return this.methodAddress.CompareTo(rhs.methodAddress);
                case RequestWebApiComparer.RequestWebApiTipoComparacion.dsRequest: return this.dsRequest.CompareTo(rhs.dsRequest);
                case RequestWebApiComparer.RequestWebApiTipoComparacion.dsResponse: return this.dsResponse.CompareTo(rhs.dsResponse);
                case RequestWebApiComparer.RequestWebApiTipoComparacion.feRequest: return this.feRequest.CompareTo(rhs.feRequest);
                case RequestWebApiComparer.RequestWebApiTipoComparacion.feRespose: return this.feRespose.CompareTo(rhs.feRespose);
                case RequestWebApiComparer.RequestWebApiTipoComparacion.esExitoso: return this.esExitoso.CompareTo(rhs.esExitoso);
            }

            return 0;
        }

        public class RequestWebApiComparer : IComparer<RequestWebApi>
        {
            public enum RequestWebApiTipoComparacion
            {
                idRequest,
                idTicket,
                idRecibo,
                methodAddress,
                dsRequest,
                dsResponse,
                feRequest,
                feRespose,
                esExitoso,
                NULL
            }

            public RequestWebApiTipoComparacion WhichComparison { get; set; }

            public int Compare(RequestWebApi lhs, RequestWebApi rhs)
            {
                if (SortDirection == TipoOrdenamiento.Asc)
                    return lhs.CompareTo(rhs, WhichComparison);
                else
                    return rhs.CompareTo(lhs, WhichComparison);
            }

            public bool Equals(RequestWebApi lhs, RequestWebApi rhs)
            {
                return this.Compare(lhs, rhs) == 0;
            }

            public int GetHashCode(RequestWebApi e)
            {
                return e.GetHashCode();
            }

            public TipoOrdenamiento SortDirection { get; set; }
        }
        #endregion Compare

        #region IDataContainer Members
        /// <summary>
        /// Asigna al objeto los valores de la base de datos
        /// </summary>
        /// <param name="reader">Resultado de la consulta de la base de datos</param>
        public void LoadDataFrom(IDataReader reader)
        {
            if (!reader.Read()) return;
            if (!Convert.IsDBNull(reader["idRequest"])) this.idRequest = Int64.Parse(reader["idRequest"].ToString());
            if (!Convert.IsDBNull(reader["idTicket"])) this.idTicket = reader["idTicket"].ToString();
            if (!Convert.IsDBNull(reader["idRecibo"])) this.idRecibo = Int64.Parse(reader["idRecibo"].ToString());
            if (!Convert.IsDBNull(reader["methodAddress"])) this.methodAddress = reader["methodAddress"] as string;
            if (!Convert.IsDBNull(reader["dsRequest"])) this.dsRequest = reader["dsRequest"] as string;
            if (!Convert.IsDBNull(reader["dsResponse"])) this.dsResponse = reader["dsResponse"] as string;
            if (!Convert.IsDBNull(reader["feRequest"])) this.feRequest = DateTime.Parse(reader["feRequest"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
            if (!Convert.IsDBNull(reader["feRespose"])) this.feRespose = DateTime.Parse(reader["feRespose"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
            if (!Convert.IsDBNull(reader["esExitoso"])) this.esExitoso = Convert.ToByte(Convert.ToBoolean(reader["esExitoso"]) ? 1 : 0);
        }

        /// <summary>
        /// Asigna los valores del objeto a los parámetros del stored procedure
        /// </summary>
        /// <param name="pars">Colección de parámetros</param>

        public void SetDataTo(IDataParameterCollection pars)
        {
            if (this.idRequest != 0) DataUtil.SetValue(pars, "@idRequest", this.idRequest);
            if (this.idTicket != string.Empty) DataUtil.SetValue(pars, "@idTicket", this.idTicket);
            if (this.idRecibo != 0) DataUtil.SetValue(pars, "@idRecibo", this.idRecibo);
            if (this.methodAddress != string.Empty) DataUtil.SetValue(pars, "@methodAddress", this.methodAddress);
            if (this.dsRequest != string.Empty) DataUtil.SetValue(pars, "@dsRequest", this.dsRequest);
            if (this.dsResponse != string.Empty) DataUtil.SetValue(pars, "@dsResponse", this.dsResponse);
            if (this.feRequest != string.Empty) DataUtil.SetValue(pars, "@feRequest", this.feRequest);
            if (this.feRespose != string.Empty) DataUtil.SetValue(pars, "@feRespose", this.feRespose);
            if (this.esExitoso != 0) DataUtil.SetValue(pars, "@esExitoso", this.esExitoso);

            DataUtil.SetReturnedValue(pars, "@return_value");
        }
        #endregion IDataContainer Members
    }

    /// <summary>
    /// Colección de objetos de tipo de RequestWebApi 
    /// </summary>
    [Serializable]
    [DataContract]
    public class RequestWebApiList : IDataContainer
    {

        #region Properties
        /// <summary>
        /// Colección con elementos de un catálogo
        /// </summary>
        [DataMember]
        public List<RequestWebApi> lstRequestWebApi { get; set; }
        #endregion Properties

        #region Constructors
        public RequestWebApiList()
        {
            lstRequestWebApi = new List<RequestWebApi>();
        }
        #endregion Constructors

        #region IDataContainer Members
        /// <summary>
        /// Asigna al objeto los valores de la base de datos
        /// </summary>
        /// <param name="reader">Resultado de la consulta de la base de datos</param>
        public void LoadDataFrom(IDataReader reader)
        {
            while (reader.Read())
            {
                RequestWebApi oRequestWebApi = new RequestWebApi();

                if (!Convert.IsDBNull(reader["idRequest"])) oRequestWebApi.idRequest = Int64.Parse(reader["idRequest"].ToString());
                if (!Convert.IsDBNull(reader["idTicket"])) oRequestWebApi.idTicket = reader["idTicket"].ToString();
                if (!Convert.IsDBNull(reader["idRecibo"])) oRequestWebApi.idRecibo = Int64.Parse(reader["idRecibo"].ToString());
                if (!Convert.IsDBNull(reader["methodAddress"])) oRequestWebApi.methodAddress = reader["methodAddress"] as string;
                if (!Convert.IsDBNull(reader["dsRequest"])) oRequestWebApi.dsRequest = reader["dsRequest"] as string;
                if (!Convert.IsDBNull(reader["dsResponse"])) oRequestWebApi.dsResponse = reader["dsResponse"] as string;
                if (!Convert.IsDBNull(reader["feRequest"])) oRequestWebApi.feRequest = DateTime.Parse(reader["feRequest"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                if (!Convert.IsDBNull(reader["feRespose"])) oRequestWebApi.feRespose = DateTime.Parse(reader["feRespose"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                if (!Convert.IsDBNull(reader["esExitoso"])) oRequestWebApi.esExitoso = Convert.ToByte(Convert.ToBoolean(reader["esExitoso"]) ? 1 : 0);

                this.lstRequestWebApi.Add(oRequestWebApi);
            }
        }

        /// <summary>
        /// Asigna los valores del objeto a los parámetros del stored procedure
        /// </summary>
        /// <param name="pars">Colección de parámetros</param>
        public void SetDataTo(System.Data.IDataParameterCollection pars) { }
        #endregion IDataContainer Members
    }
}