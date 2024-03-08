﻿using Microsoft.VisualBasic.CompilerServices;
using System.Collections.ObjectModel;

namespace EficazFramework.SPED.Schemas.CTe
{
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.18033")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "consSitCTe", Namespace = "http://www.portalfiscal.inf.br/cte")]
    [XmlRoot(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = true)]
    public partial class PedidoConsultaSituacaoCTe : INotifyPropertyChanged
    {
        private NFe.Ambiente tpAmbField;
        private string xServField;
        private string chCTeField;
        private VersaoServicoConsulta versaoField = VersaoServicoConsulta.Versao_2_00;
        private static XmlSerializer sSerializer;

        public PedidoConsultaSituacaoCTe() : base()
        {
            xServField = "CONSULTAR";
        }

        [XmlElement("tpAmb")]
        public NFe.Ambiente Ambiente
        {
            get
            {
                return tpAmbField;
            }

            set
            {
                if (tpAmbField.Equals(value) != true)
                {
                    tpAmbField = value;
                    OnPropertyChanged("NFe.Ambiente");
                }
            }
        }

        [XmlElement("xServ")]
        public string TipoServico
        {
            get
            {
                return xServField;
            }

            set
            {
                if (xServField is null || xServField.Equals(value) != true)
                {
                    xServField = value;
                    OnPropertyChanged("TipoServico");
                }
            }
        }

        [XmlElement("chCTe")]
        public string Chave
        {
            get
            {
                return chCTeField;
            }

            set
            {
                if (chCTeField is null || chCTeField.Equals(value) != true)
                {
                    chCTeField = value;
                    OnPropertyChanged("Chave");
                }
            }
        }

        [XmlAttribute(AttributeName = "versao")]
        public VersaoServicoConsulta versao
        {
            get
            {
                return versaoField;
            }

            set
            {
                if (versaoField.Equals(value) != true)
                {
                    versaoField = value;
                    OnPropertyChanged("versao");
                }
            }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if (sSerializer is null)
                {
                    sSerializer = new XmlSerializer(typeof(PedidoConsultaSituacaoCTe));
                }

                return sSerializer;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        /// <summary>
        /// Serializes current TEnvEvento object into an XML document
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize()
        {
            System.IO.StreamReader streamReader = null;
            System.IO.MemoryStream memoryStream = null;
            try
            {
                memoryStream = new System.IO.MemoryStream();
                Serializer.Serialize(memoryStream, this);
                memoryStream.Seek(0L, System.IO.SeekOrigin.Begin);
                streamReader = new System.IO.StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Dispose();
                }

                if (memoryStream != null)
                {
                    memoryStream.Dispose();
                }
            }
        }

        /// <summary>
        /// Semelhante À Function Serialize, porém já retorna o resultado
        /// em uma instância de XmlDocument, agilizando o processo de assinatura
        /// digital dos eventos.
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public virtual XDocument SerializeToXMLDocument()
        {
            string str = Serialize();
            if (!string.IsNullOrEmpty(str) | string.IsNullOrWhiteSpace(str))
            {
                var doc = XDocument.Load(Serialize());
                // doc.LoadXml(Me.Serialize)
                return doc;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Deserializes workflow markup into an TEnvEvento object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output TEnvEvento object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool CanDeserialize(string xml, ref PedidoConsultaSituacaoCTe obj, ref Exception exception)
        {
            exception = null;
            obj = default;
            try
            {
                obj = Deserialize(xml);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool CanDeserialize(string xml, ref PedidoConsultaSituacaoCTe obj)
        {
            Exception exception = null;
            return CanDeserialize(xml, ref obj, ref exception);
        }

        public static PedidoConsultaSituacaoCTe Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return (PedidoConsultaSituacaoCTe)Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader));
            }
            finally
            {
                if (stringReader != null)
                {
                    stringReader.Dispose();
                }
            }
        }

        public static PedidoConsultaSituacaoCTe Deserialize(System.IO.Stream s)
        {
            return (PedidoConsultaSituacaoCTe)Serializer.Deserialize(s);
        }


        /// <summary>
        /// Serializes current TNfeProc object into file
        /// </summary>
        /// <param name="target">target stream of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool CanSaveTo(System.IO.Stream target, ref Exception exception)
        {
            exception = null;
            try
            {
                SaveTo(target);
                return true;
            }
            catch (Exception e)
            {
                exception = e;
                return false;
            }
        }

        public virtual void SaveTo(System.IO.Stream target)
        {
            if (target is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Save_NullStreamExceptionMessage);
            var streamWriter = new System.IO.StreamWriter(target);
            try
            {
                string xmlString = Serialize();
                // Dim xmlFile As System.IO.FileInfo = New System.IO.FileInfo(fileName)
                // streamWriter = xmlFile.CreateText
                streamWriter.WriteLine(xmlString);
                streamWriter.Flush();
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Dispose();
                }
            }
        }

        public virtual async void SaveToAsync(System.IO.Stream target)
        {
            if (target is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Save_NullStreamExceptionMessage);
            var streamWriter = new System.IO.StreamWriter(target);
            try
            {
                string xmlString = Serialize();
                await streamWriter.WriteLineAsync(xmlString);
                await streamWriter.FlushAsync();
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Dispose();
                }
            }
        }


        /// <summary>
        /// Deserializes xml markup from file into an TEnvEvento object
        /// </summary>
        /// <param name="source">target stream of outupt xml file</param>
        /// <param name="obj">Output TEnvEvento object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool CanLoadFrom(System.IO.Stream source, ref PedidoConsultaSituacaoCTe obj, ref Exception exception)
        {
            exception = null;
            obj = default;
            try
            {
                obj = LoadFrom(source, false);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool CanLoadFrom(System.IO.Stream source, ref PedidoConsultaSituacaoCTe obj)
        {
            Exception exception = null;
            return CanLoadFrom(source, ref obj, ref exception);
        }

        public static PedidoConsultaSituacaoCTe LoadFrom(System.IO.Stream source, bool close_stream = true)
        {
            // Dim file As System.IO.FileStream = Nothing
            if (source is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Load_NullStreamExceptionMessage);
            System.IO.StreamReader sr = null;
            try
            {
                // file = New System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read)
                sr = new System.IO.StreamReader(source);
                string xmlString = sr.ReadToEnd();
                // sr.Close()
                // file.Close()
                return Deserialize(xmlString);
            }
            finally
            {
                if (sr != null & close_stream == true)
                {
                    sr.Dispose();
                }
            }
        }

        public static async Task<PedidoConsultaSituacaoCTe> LoadFromAsync(System.IO.Stream source, bool close_stream = true)
        {
            if (source is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Load_NullStreamExceptionMessage);
            System.IO.StreamReader sr = null;
            try
            {
                // file = New System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read)
                sr = new System.IO.StreamReader(source);
                string xmlString = await sr.ReadToEndAsync();
                // sr.Close()
                // file.Close()
                return Deserialize(xmlString);
            }
            finally
            {
                if (sr != null & close_stream == true)
                {
                    sr.Dispose();
                }
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }

    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.18033")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "retConsSitCTe", Namespace = "http://www.portalfiscal.inf.br/cte")]
    [XmlRoot(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = true)]
    public partial class RetornoConsultaSituacaoCTe : INotifyPropertyChanged
    {
        private NFe.Ambiente tpAmbField;
        private string verAplicField;
        private string cStatField;
        private string xMotivoField;
        private NFe.OrgaoIBGE cUFField;
        private object itemField;
        private ObservableCollection<ProcessoEvento> procEventoCTeField;
        private string versaoField;
        private static XmlSerializer sSerializer;

        public RetornoConsultaSituacaoCTe() : base()
        {
            procEventoCTeField = new ObservableCollection<ProcessoEvento>();
        }

        public NFe.Ambiente tpAmb
        {
            get
            {
                return tpAmbField;
            }

            set
            {
                if (tpAmbField.Equals(value) != true)
                {
                    tpAmbField = value;
                    OnPropertyChanged("tpAmb");
                }
            }
        }

        public string verAplic
        {
            get
            {
                return verAplicField;
            }

            set
            {
                if (verAplicField is null || verAplicField.Equals(value) != true)
                {
                    verAplicField = value;
                    OnPropertyChanged("verAplic");
                }
            }
        }

        [XmlElement("cStat")]
        public string RetornoCodigo
        {
            get
            {
                return cStatField;
            }

            set
            {
                if (cStatField is null || cStatField.Equals(value) != true)
                {
                    cStatField = value;
                    OnPropertyChanged("RetornoCodigo");
                }
            }
        }

        [XmlElement("xMotivo")]
        public string RetornoDescricao
        {
            get
            {
                return xMotivoField;
            }

            set
            {
                if (xMotivoField is null || xMotivoField.Equals(value) != true)
                {
                    xMotivoField = value;
                    OnPropertyChanged("RetornoDescricao");
                }
            }
        }

        [XmlElement("cUF")]
        public NFe.OrgaoIBGE UF
        {
            get
            {
                return cUFField;
            }

            set
            {
                if (cUFField.Equals(value) != true)
                {
                    cUFField = value;
                    OnPropertyChanged("UF");
                }
            }
        }

        public object Item
        {
            get
            {
                return itemField;
            }

            set
            {
                if (itemField is null || itemField.Equals(value) != true)
                {
                    itemField = value;
                    OnPropertyChanged("Item");
                }
            }
        }

        public ObservableCollection<ProcessoEvento> procEventoCTe
        {
            get
            {
                return procEventoCTeField;
            }

            set
            {
                if (procEventoCTeField is null || procEventoCTeField.Equals(value) != true)
                {
                    procEventoCTeField = value;
                    OnPropertyChanged("procEventoCTe");
                }
            }
        }

        public string versao
        {
            get
            {
                return versaoField;
            }

            set
            {
                if (versaoField is null || versaoField.Equals(value) != true)
                {
                    versaoField = value;
                    OnPropertyChanged("versao");
                }
            }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if (sSerializer is null)
                {
                    sSerializer = new XmlSerializer(typeof(RetornoConsultaSituacaoCTe));
                }

                return sSerializer;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        /// <summary>
        /// Serializes current TEnvEvento object into an XML document
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize()
        {
            System.IO.StreamReader streamReader = null;
            System.IO.MemoryStream memoryStream = null;
            try
            {
                memoryStream = new System.IO.MemoryStream();
                Serializer.Serialize(memoryStream, this);
                memoryStream.Seek(0L, System.IO.SeekOrigin.Begin);
                streamReader = new System.IO.StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Dispose();
                }

                if (memoryStream != null)
                {
                    memoryStream.Dispose();
                }
            }
        }

        /// <summary>
        /// Semelhante À Function Serialize, porém já retorna o resultado
        /// em uma instância de XmlDocument, agilizando o processo de assinatura
        /// digital dos eventos.
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public virtual XDocument SerializeToXMLDocument()
        {
            string str = Serialize();
            if (!string.IsNullOrEmpty(str) | string.IsNullOrWhiteSpace(str))
            {
                var doc = XDocument.Load(Serialize());
                // doc.LoadXml(Me.Serialize)
                return doc;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Deserializes workflow markup into an TEnvEvento object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output TEnvEvento object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool CanDeserialize(string xml, ref RetornoConsultaSituacaoCTe obj, ref Exception exception)
        {
            exception = null;
            obj = default;
            try
            {
                obj = Deserialize(xml);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool CanDeserialize(string xml, ref RetornoConsultaSituacaoCTe obj)
        {
            Exception exception = null;
            return CanDeserialize(xml, ref obj, ref exception);
        }

        public static RetornoConsultaSituacaoCTe Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return (RetornoConsultaSituacaoCTe)Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader));
            }
            finally
            {
                if (stringReader != null)
                {
                    stringReader.Dispose();
                }
            }
        }

        public static RetornoConsultaSituacaoCTe Deserialize(System.IO.Stream s)
        {
            return (RetornoConsultaSituacaoCTe)Serializer.Deserialize(s);
        }


        /// <summary>
        /// Serializes current TNfeProc object into file
        /// </summary>
        /// <param name="target">target stream of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool CanSaveTo(System.IO.Stream target, ref Exception exception)
        {
            exception = null;
            try
            {
                SaveTo(target);
                return true;
            }
            catch (Exception e)
            {
                exception = e;
                return false;
            }
        }

        public virtual void SaveTo(System.IO.Stream target)
        {
            if (target is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Save_NullStreamExceptionMessage);
            var streamWriter = new System.IO.StreamWriter(target);
            try
            {
                string xmlString = Serialize();
                // Dim xmlFile As System.IO.FileInfo = New System.IO.FileInfo(fileName)
                // streamWriter = xmlFile.CreateText
                streamWriter.WriteLine(xmlString);
                streamWriter.Flush();
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Dispose();
                }
            }
        }

        public virtual async void SaveToAsync(System.IO.Stream target)
        {
            if (target is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Save_NullStreamExceptionMessage);
            var streamWriter = new System.IO.StreamWriter(target);
            try
            {
                string xmlString = Serialize();
                await streamWriter.WriteLineAsync(xmlString);
                await streamWriter.FlushAsync();
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Dispose();
                }
            }
        }


        /// <summary>
        /// Deserializes xml markup from file into an TEnvEvento object
        /// </summary>
        /// <param name="source">target stream of outupt xml file</param>
        /// <param name="obj">Output TEnvEvento object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool CanLoadFrom(System.IO.Stream source, ref RetornoConsultaSituacaoCTe obj, ref Exception exception)
        {
            exception = null;
            obj = default;
            try
            {
                obj = LoadFrom(source, false);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool CanLoadFrom(System.IO.Stream source, ref RetornoConsultaSituacaoCTe obj)
        {
            Exception exception = null;
            return CanLoadFrom(source, ref obj, ref exception);
        }

        public static RetornoConsultaSituacaoCTe LoadFrom(System.IO.Stream source, bool close_stream = true)
        {
            // Dim file As System.IO.FileStream = Nothing
            if (source is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Load_NullStreamExceptionMessage);
            System.IO.StreamReader sr = null;
            try
            {
                // file = New System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read)
                sr = new System.IO.StreamReader(source);
                string xmlString = sr.ReadToEnd();
                // sr.Close()
                // file.Close()
                return Deserialize(xmlString);
            }
            finally
            {
                if (sr != null & close_stream == true)
                {
                    sr.Dispose();
                }
            }
        }

        public static async Task<RetornoConsultaSituacaoCTe> LoadFromAsync(System.IO.Stream source, bool close_stream = true)
        {
            if (source is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Load_NullStreamExceptionMessage);
            System.IO.StreamReader sr = null;
            try
            {
                // file = New System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read)
                sr = new System.IO.StreamReader(source);
                string xmlString = await sr.ReadToEndAsync();
                // sr.Close()
                // file.Close()
                return Deserialize(xmlString);
            }
            finally
            {
                if (sr != null & close_stream == true)
                {
                    sr.Dispose();
                }
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }

    public partial class TProtCTe : INotifyPropertyChanged
    {
        private TProtCTeInfProt infProtField;
        private SignatureType signatureField;
        private string versaoField;
        private static XmlSerializer sSerializer;

        public TProtCTe() : base()
        {
            signatureField = new SignatureType();
            infProtField = new TProtCTeInfProt();
        }

        public TProtCTeInfProt infProt
        {
            get
            {
                return infProtField;
            }

            set
            {
                if (infProtField is null || infProtField.Equals(value) != true)
                {
                    infProtField = value;
                    OnPropertyChanged("infProt");
                }
            }
        }

        public SignatureType Signature
        {
            get
            {
                return signatureField;
            }

            set
            {
                if (signatureField is null || signatureField.Equals(value) != true)
                {
                    signatureField = value;
                    OnPropertyChanged("Signature");
                }
            }
        }

        public string versao
        {
            get
            {
                return versaoField;
            }

            set
            {
                if (versaoField is null || versaoField.Equals(value) != true)
                {
                    versaoField = value;
                    OnPropertyChanged("versao");
                }
            }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if (sSerializer is null)
                {
                    sSerializer = new XmlSerializer(typeof(TProtCTe));
                }

                return sSerializer;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        /// <summary>
        /// Serializes current TEnvEvento object into an XML document
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize()
        {
            System.IO.StreamReader streamReader = null;
            System.IO.MemoryStream memoryStream = null;
            try
            {
                memoryStream = new System.IO.MemoryStream();
                Serializer.Serialize(memoryStream, this);
                memoryStream.Seek(0L, System.IO.SeekOrigin.Begin);
                streamReader = new System.IO.StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Dispose();
                }

                if (memoryStream != null)
                {
                    memoryStream.Dispose();
                }
            }
        }

        /// <summary>
        /// Semelhante À Function Serialize, porém já retorna o resultado
        /// em uma instância de XmlDocument, agilizando o processo de assinatura
        /// digital dos eventos.
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public virtual XDocument SerializeToXMLDocument()
        {
            string str = Serialize();
            if (!string.IsNullOrEmpty(str) | string.IsNullOrWhiteSpace(str))
            {
                var doc = XDocument.Load(Serialize());
                // doc.LoadXml(Me.Serialize)
                return doc;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Deserializes workflow markup into an TEnvEvento object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output TEnvEvento object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool CanDeserialize(string xml, ref TProtCTe obj, ref Exception exception)
        {
            exception = null;
            obj = default;
            try
            {
                obj = Deserialize(xml);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool CanDeserialize(string xml, ref TProtCTe obj)
        {
            Exception exception = null;
            return CanDeserialize(xml, ref obj, ref exception);
        }

        public static TProtCTe Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return (TProtCTe)Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader));
            }
            finally
            {
                if (stringReader != null)
                {
                    stringReader.Dispose();
                }
            }
        }

        public static TProtCTe Deserialize(System.IO.Stream s)
        {
            return (TProtCTe)Serializer.Deserialize(s);
        }


        /// <summary>
        /// Serializes current TNfeProc object into file
        /// </summary>
        /// <param name="target">target stream of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool CanSaveTo(System.IO.Stream target, ref Exception exception)
        {
            exception = null;
            try
            {
                SaveTo(target);
                return true;
            }
            catch (Exception e)
            {
                exception = e;
                return false;
            }
        }

        public virtual void SaveTo(System.IO.Stream target)
        {
            if (target is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Save_NullStreamExceptionMessage);
            var streamWriter = new System.IO.StreamWriter(target);
            try
            {
                string xmlString = Serialize();
                // Dim xmlFile As System.IO.FileInfo = New System.IO.FileInfo(fileName)
                // streamWriter = xmlFile.CreateText
                streamWriter.WriteLine(xmlString);
                streamWriter.Flush();
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Dispose();
                }
            }
        }

        public virtual async void SaveToAsync(System.IO.Stream target)
        {
            if (target is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Save_NullStreamExceptionMessage);
            var streamWriter = new System.IO.StreamWriter(target);
            try
            {
                string xmlString = Serialize();
                await streamWriter.WriteLineAsync(xmlString);
                await streamWriter.FlushAsync();
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Dispose();
                }
            }
        }


        /// <summary>
        /// Deserializes xml markup from file into an TEnvEvento object
        /// </summary>
        /// <param name="source">target stream of outupt xml file</param>
        /// <param name="obj">Output TEnvEvento object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool CanLoadFrom(System.IO.Stream source, ref TProtCTe obj, ref Exception exception)
        {
            exception = null;
            obj = default;
            try
            {
                obj = LoadFrom(source, false);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool CanLoadFrom(System.IO.Stream source, ref TProtCTe obj)
        {
            Exception exception = null;
            return CanLoadFrom(source, ref obj, ref exception);
        }

        public static TProtCTe LoadFrom(System.IO.Stream source, bool close_stream = true)
        {
            // Dim file As System.IO.FileStream = Nothing
            if (source is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Load_NullStreamExceptionMessage);
            System.IO.StreamReader sr = null;
            try
            {
                // file = New System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read)
                sr = new System.IO.StreamReader(source);
                string xmlString = sr.ReadToEnd();
                // sr.Close()
                // file.Close()
                return Deserialize(xmlString);
            }
            finally
            {
                if (sr != null & close_stream == true)
                {
                    sr.Dispose();
                }
            }
        }

        public static async Task<TProtCTe> LoadFromAsync(System.IO.Stream source, bool close_stream = true)
        {
            if (source is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Load_NullStreamExceptionMessage);
            System.IO.StreamReader sr = null;
            try
            {
                // file = New System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read)
                sr = new System.IO.StreamReader(source);
                string xmlString = await sr.ReadToEndAsync();
                // sr.Close()
                // file.Close()
                return Deserialize(xmlString);
            }
            finally
            {
                if (sr != null & close_stream == true)
                {
                    sr.Dispose();
                }
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }

    public partial class TRetCancCTe : INotifyPropertyChanged
    {
        private TRetCancCTeInfCanc infCancField;
        private SignatureType signatureField;
        private string versaoField;
        private static XmlSerializer sSerializer;

        public TRetCancCTe() : base()
        {
            signatureField = new SignatureType();
            infCancField = new TRetCancCTeInfCanc();
        }

        public TRetCancCTeInfCanc infCanc
        {
            get
            {
                return infCancField;
            }

            set
            {
                if (infCancField is null || infCancField.Equals(value) != true)
                {
                    infCancField = value;
                    OnPropertyChanged("infCanc");
                }
            }
        }

        public SignatureType Signature
        {
            get
            {
                return signatureField;
            }

            set
            {
                if (signatureField is null || signatureField.Equals(value) != true)
                {
                    signatureField = value;
                    OnPropertyChanged("Signature");
                }
            }
        }

        public string versao
        {
            get
            {
                return versaoField;
            }

            set
            {
                if (versaoField is null || versaoField.Equals(value) != true)
                {
                    versaoField = value;
                    OnPropertyChanged("versao");
                }
            }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if (sSerializer is null)
                {
                    sSerializer = new XmlSerializer(typeof(TRetCancCTe));
                }

                return sSerializer;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public partial class TRetCancCTeInfCanc : INotifyPropertyChanged
    {
        private NFe.Ambiente tpAmbField;
        private NFe.OrgaoIBGE cUFField;
        private string verAplicField;
        private string cStatField;
        private string xMotivoField;
        private string chCTeField;
        private DateTime? dhRecbtoField;
        private string nProtField;
        private string idField;
        private static XmlSerializer sSerializer;

        public NFe.Ambiente tpAmb
        {
            get
            {
                return tpAmbField;
            }

            set
            {
                if (tpAmbField.Equals(value) != true)
                {
                    tpAmbField = value;
                    OnPropertyChanged("tpAmb");
                }
            }
        }

        public NFe.OrgaoIBGE cUF
        {
            get
            {
                return cUFField;
            }

            set
            {
                if (cUFField.Equals(value) != true)
                {
                    cUFField = value;
                    OnPropertyChanged("cUF");
                }
            }
        }

        public string verAplic
        {
            get
            {
                return verAplicField;
            }

            set
            {
                if (verAplicField is null || verAplicField.Equals(value) != true)
                {
                    verAplicField = value;
                    OnPropertyChanged("verAplic");
                }
            }
        }

        public string cStat
        {
            get
            {
                return cStatField;
            }

            set
            {
                if (cStatField is null || cStatField.Equals(value) != true)
                {
                    cStatField = value;
                    OnPropertyChanged("cStat");
                }
            }
        }

        public string xMotivo
        {
            get
            {
                return xMotivoField;
            }

            set
            {
                if (xMotivoField is null || xMotivoField.Equals(value) != true)
                {
                    xMotivoField = value;
                    OnPropertyChanged("xMotivo");
                }
            }
        }

        public string chCTe
        {
            get
            {
                return chCTeField;
            }

            set
            {
                if (chCTeField is null || chCTeField.Equals(value) != true)
                {
                    chCTeField = value;
                    OnPropertyChanged("chCTe");
                }
            }
        }

        public DateTime dhRecbto
        {
            get
            {
                if (dhRecbtoField.HasValue)
                {
                    return dhRecbtoField.Value;
                }
                else
                {
                    return Conversions.ToDate(default);
                }
            }

            set
            {
                if (dhRecbtoField.Equals(value) != true)
                {
                    dhRecbtoField = value;
                    OnPropertyChanged("dhRecbto");
                }
            }
        }

        [XmlIgnore()]
        public bool dhRecbtoSpecified
        {
            get
            {
                return dhRecbtoField.HasValue;
            }

            set
            {
                if (value == false)
                {
                    dhRecbtoField = default;
                }
            }
        }

        public string nProt
        {
            get
            {
                return nProtField;
            }

            set
            {
                if (nProtField is null || nProtField.Equals(value) != true)
                {
                    nProtField = value;
                    OnPropertyChanged("nProt");
                }
            }
        }

        public string Id
        {
            get
            {
                return idField;
            }

            set
            {
                if (idField is null || idField.Equals(value) != true)
                {
                    idField = value;
                    OnPropertyChanged("Id");
                }
            }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if (sSerializer is null)
                {
                    sSerializer = new XmlSerializer(typeof(TRetCancCTeInfCanc));
                }

                return sSerializer;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.18033")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "procEventoCTe", Namespace = "http://www.portalfiscal.inf.br/cte")]
    [XmlRoot(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = true)]
    public partial class ProcessoEvento : INotifyPropertyChanged, IXmlSpedDocument
    {
        private Evento eventoCTeField;
        private RetornoEvento retEventoCTeField;
        private string versaoField;
        private static XmlSerializer sSerializer;

        public ProcessoEvento() : base()
        {
            retEventoCTeField = new RetornoEvento();
            eventoCTeField = new Evento();
        }

        public Evento eventoCTe
        {
            get
            {
                return eventoCTeField;
            }

            set
            {
                if (eventoCTeField is null || eventoCTeField.Equals(value) != true)
                {
                    eventoCTeField = value;
                    OnPropertyChanged("eventoCTe");
                }
            }
        }

        public RetornoEvento retEventoCTe
        {
            get
            {
                return retEventoCTeField;
            }

            set
            {
                if (retEventoCTeField is null || retEventoCTeField.Equals(value) != true)
                {
                    retEventoCTeField = value;
                    OnPropertyChanged("retEventoCTe");
                }
            }
        }

        public string versao
        {
            get
            {
                return versaoField;
            }

            set
            {
                if (versaoField is null || versaoField.Equals(value) != true)
                {
                    versaoField = value;
                    OnPropertyChanged("versao");
                }
            }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if (sSerializer is null)
                {
                    sSerializer = new XmlSerializer(typeof(ProcessoEvento));
                }

                return sSerializer;
            }
        }

        public XmlDocumentType DocumentType
        {
            get
            {
                return XmlDocumentType.CTeEvent;
            }
        }

        [XmlIgnore()]
        public DateTime? DataEmissao
        {
            get
            {
                return eventoCTe.infEvento.dhEvento;
            }
        }

        [XmlIgnore()]
        public string Chave
        {
            get
            {
                // Return Me.eventoCTe.infEvento.Id
                if (eventoCTe.infEvento.Id != null)
                    return System.Text.RegularExpressions.Regex.Replace(eventoCTe.infEvento.Id, "[^0-9]", "");
                else
                    return string.Empty;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        /// <summary>
        /// Serializes current TEnvEvento object into an XML document
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize()
        {
            System.IO.StreamReader streamReader = null;
            System.IO.MemoryStream memoryStream = null;
            try
            {
                memoryStream = new System.IO.MemoryStream();
                Serializer.Serialize(memoryStream, this);
                memoryStream.Seek(0L, System.IO.SeekOrigin.Begin);
                streamReader = new System.IO.StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Dispose();
                }

                if (memoryStream != null)
                {
                    memoryStream.Dispose();
                }
            }
        }

        /// <summary>
        /// Semelhante À Function Serialize, porém já retorna o resultado
        /// em uma instância de XmlDocument, agilizando o processo de assinatura
        /// digital dos eventos.
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public virtual XDocument SerializeToXMLDocument()
        {
            string str = Serialize();
            if (!string.IsNullOrEmpty(str) | string.IsNullOrWhiteSpace(str))
            {
                var doc = XDocument.Load(Serialize());
                // doc.LoadXml(Me.Serialize)
                return doc;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Deserializes workflow markup into an TEnvEvento object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output TEnvEvento object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool CanDeserialize(string xml, ref ProcessoEvento obj, ref Exception exception)
        {
            exception = null;
            obj = default;
            try
            {
                obj = Deserialize(xml);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool CanDeserialize(string xml, ref ProcessoEvento obj)
        {
            Exception exception = null;
            return CanDeserialize(xml, ref obj, ref exception);
        }

        public static ProcessoEvento Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return (ProcessoEvento)Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader));
            }
            finally
            {
                if (stringReader != null)
                {
                    stringReader.Dispose();
                }
            }
        }

        public static ProcessoEvento Deserialize(System.IO.Stream s)
        {
            return (ProcessoEvento)Serializer.Deserialize(s);
        }


        /// <summary>
        /// Serializes current TNfeProc object into file
        /// </summary>
        /// <param name="target">target stream of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool CanSaveTo(System.IO.Stream target, ref Exception exception)
        {
            exception = null;
            try
            {
                SaveTo(target);
                return true;
            }
            catch (Exception e)
            {
                exception = e;
                return false;
            }
        }

        public virtual void SaveTo(System.IO.Stream target)
        {
            if (target is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Save_NullStreamExceptionMessage);
            var streamWriter = new System.IO.StreamWriter(target);
            try
            {
                string xmlString = Serialize();
                // Dim xmlFile As System.IO.FileInfo = New System.IO.FileInfo(fileName)
                // streamWriter = xmlFile.CreateText
                streamWriter.WriteLine(xmlString);
                streamWriter.Flush();
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Dispose();
                }
            }
        }

        public virtual async void SaveToAsync(System.IO.Stream target)
        {
            if (target is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Save_NullStreamExceptionMessage);
            var streamWriter = new System.IO.StreamWriter(target);
            try
            {
                string xmlString = Serialize();
                await streamWriter.WriteLineAsync(xmlString);
                await streamWriter.FlushAsync();
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Dispose();
                }
            }
        }


        /// <summary>
        /// Deserializes xml markup from file into an TEnvEvento object
        /// </summary>
        /// <param name="source">target stream of outupt xml file</param>
        /// <param name="obj">Output TEnvEvento object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool CanLoadFrom(System.IO.Stream source, ref ProcessoEvento obj, ref Exception exception)
        {
            exception = null;
            obj = default;
            try
            {
                obj = LoadFrom(source, false);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool CanLoadFrom(System.IO.Stream source, ref ProcessoEvento obj)
        {
            Exception exception = null;
            return CanLoadFrom(source, ref obj, ref exception);
        }

        public static ProcessoEvento LoadFrom(System.IO.Stream source, bool close_stream = true)
        {
            // Dim file As System.IO.FileStream = Nothing
            if (source is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Load_NullStreamExceptionMessage);
            System.IO.StreamReader sr = null;
            try
            {
                // file = New System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read)
                sr = new System.IO.StreamReader(source);
                string xmlString = sr.ReadToEnd();
                // sr.Close()
                // file.Close()
                return Deserialize(xmlString);
            }
            finally
            {
                if (sr != null & close_stream == true)
                {
                    sr.Dispose();
                }
            }
        }

        public static async Task<ProcessoEvento> LoadFromAsync(System.IO.Stream source, bool close_stream = true)
        {
            if (source is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Load_NullStreamExceptionMessage);
            System.IO.StreamReader sr = null;
            try
            {
                // file = New System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read)
                sr = new System.IO.StreamReader(source);
                string xmlString = await sr.ReadToEndAsync();
                // sr.Close()
                // file.Close()
                return Deserialize(xmlString);
            }
            finally
            {
                if (sr != null & close_stream == true)
                {
                    sr.Dispose();
                }
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }

    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.18033")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "eventoCTe", Namespace = "http://www.portalfiscal.inf.br/cte")]
    [XmlRoot(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = true)]
    public partial class Evento : INotifyPropertyChanged, IXmlSpedDocument
    {
        private TEventoInfEvento infEventoField;
        private SignatureType signatureField;
        private string versaoField;
        private static XmlSerializer sSerializer;

        public Evento() : base()
        {
            signatureField = new SignatureType();
            infEventoField = new TEventoInfEvento();
        }

        public TEventoInfEvento infEvento
        {
            get
            {
                return infEventoField;
            }

            set
            {
                if (infEventoField is null || infEventoField.Equals(value) != true)
                {
                    infEventoField = value;
                    OnPropertyChanged("infEvento");
                }
            }
        }

        public SignatureType Signature
        {
            get
            {
                return signatureField;
            }

            set
            {
                if (signatureField is null || signatureField.Equals(value) != true)
                {
                    signatureField = value;
                    OnPropertyChanged("Signature");
                }
            }
        }

        public string versao
        {
            get
            {
                return versaoField;
            }

            set
            {
                if (versaoField is null || versaoField.Equals(value) != true)
                {
                    versaoField = value;
                    OnPropertyChanged("versao");
                }
            }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if (sSerializer is null)
                {
                    sSerializer = new XmlSerializer(typeof(Evento));
                }

                return sSerializer;
            }
        }

        public XmlDocumentType DocumentType
        {
            get
            {
                return XmlDocumentType.CTeEvent2;
            }
        }

        public DateTime? DataEmissao
        {
            get
            {
                return infEvento.dhEvento;
            }
        }

        public string Chave
        {
            get
            {
                return infEvento.chCTe;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        /// <summary>
        /// Serializes current TEnvEvento object into an XML document
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize()
        {
            System.IO.StreamReader streamReader = null;
            System.IO.MemoryStream memoryStream = null;
            try
            {
                memoryStream = new System.IO.MemoryStream();
                Serializer.Serialize(memoryStream, this);
                memoryStream.Seek(0L, System.IO.SeekOrigin.Begin);
                streamReader = new System.IO.StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Dispose();
                }

                if (memoryStream != null)
                {
                    memoryStream.Dispose();
                }
            }
        }

        /// <summary>
        /// Semelhante À Function Serialize, porém já retorna o resultado
        /// em uma instância de XmlDocument, agilizando o processo de assinatura
        /// digital dos eventos.
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public virtual XDocument SerializeToXMLDocument()
        {
            string str = Serialize();
            if (!string.IsNullOrEmpty(str) | string.IsNullOrWhiteSpace(str))
            {
                var doc = XDocument.Load(Serialize());
                // doc.LoadXml(Me.Serialize)
                return doc;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Deserializes workflow markup into an TEnvEvento object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output TEnvEvento object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool CanDeserialize(string xml, ref Evento obj, ref Exception exception)
        {
            exception = null;
            obj = default;
            try
            {
                obj = Deserialize(xml);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool CanDeserialize(string xml, ref Evento obj)
        {
            Exception exception = null;
            return CanDeserialize(xml, ref obj, ref exception);
        }

        public static Evento Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return (Evento)Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader));
            }
            finally
            {
                if (stringReader != null)
                {
                    stringReader.Dispose();
                }
            }
        }

        public static Evento Deserialize(System.IO.Stream s)
        {
            return (Evento)Serializer.Deserialize(s);
        }


        /// <summary>
        /// Serializes current TNfeProc object into file
        /// </summary>
        /// <param name="target">target stream of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool CanSaveTo(System.IO.Stream target, ref Exception exception)
        {
            exception = null;
            try
            {
                SaveTo(target);
                return true;
            }
            catch (Exception e)
            {
                exception = e;
                return false;
            }
        }

        public virtual void SaveTo(System.IO.Stream target)
        {
            if (target is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Save_NullStreamExceptionMessage);
            var streamWriter = new System.IO.StreamWriter(target);
            try
            {
                string xmlString = Serialize();
                // Dim xmlFile As System.IO.FileInfo = New System.IO.FileInfo(fileName)
                // streamWriter = xmlFile.CreateText
                streamWriter.WriteLine(xmlString);
                streamWriter.Flush();
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Dispose();
                }
            }
        }

        public virtual async void SaveToAsync(System.IO.Stream target)
        {
            if (target is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Save_NullStreamExceptionMessage);
            var streamWriter = new System.IO.StreamWriter(target);
            try
            {
                string xmlString = Serialize();
                await streamWriter.WriteLineAsync(xmlString);
                await streamWriter.FlushAsync();
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Dispose();
                }
            }
        }


        /// <summary>
        /// Deserializes xml markup from file into an TEnvEvento object
        /// </summary>
        /// <param name="source">target stream of outupt xml file</param>
        /// <param name="obj">Output TEnvEvento object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool CanLoadFrom(System.IO.Stream source, ref Evento obj, ref Exception exception)
        {
            exception = null;
            obj = default;
            try
            {
                obj = LoadFrom(source, false);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool CanLoadFrom(System.IO.Stream source, ref Evento obj)
        {
            Exception exception = null;
            return CanLoadFrom(source, ref obj, ref exception);
        }

        public static Evento LoadFrom(System.IO.Stream source, bool close_stream = true)
        {
            // Dim file As System.IO.FileStream = Nothing
            if (source is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Load_NullStreamExceptionMessage);
            System.IO.StreamReader sr = null;
            try
            {
                // file = New System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read)
                sr = new System.IO.StreamReader(source);
                string xmlString = sr.ReadToEnd();
                // sr.Close()
                // file.Close()
                return Deserialize(xmlString);
            }
            finally
            {
                if (sr != null & close_stream == true)
                {
                    sr.Dispose();
                }
            }
        }

        public static async Task<Evento> LoadFromAsync(System.IO.Stream source, bool close_stream = true)
        {
            if (source is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Load_NullStreamExceptionMessage);
            System.IO.StreamReader sr = null;
            try
            {
                // file = New System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read)
                sr = new System.IO.StreamReader(source);
                string xmlString = await sr.ReadToEndAsync();
                // sr.Close()
                // file.Close()
                return Deserialize(xmlString);
            }
            finally
            {
                if (sr != null & close_stream == true)
                {
                    sr.Dispose();
                }
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }

    public partial class TEventoInfEvento : INotifyPropertyChanged
    {
        private NFe.OrgaoIBGE cOrgaoField;
        private NFe.Ambiente tpAmbField;
        private string cNPJField;
        private string chCTeField;
        private DateTime? dhEventoField;
        private string tpEventoField;
        private string nSeqEventoField;
        private TEventoInfEventoDetEvento detEventoField;
        private string idField;
        private static XmlSerializer sSerializer;

        public TEventoInfEvento() : base()
        {
            detEventoField = new TEventoInfEventoDetEvento();
        }

        public NFe.OrgaoIBGE cOrgao
        {
            get
            {
                return cOrgaoField;
            }

            set
            {
                if (cOrgaoField.Equals(value) != true)
                {
                    cOrgaoField = value;
                    OnPropertyChanged("cOrgao");
                }
            }
        }

        public NFe.Ambiente tpAmb
        {
            get
            {
                return tpAmbField;
            }

            set
            {
                if (tpAmbField.Equals(value) != true)
                {
                    tpAmbField = value;
                    OnPropertyChanged("tpAmb");
                }
            }
        }

        public string CNPJ
        {
            get
            {
                return cNPJField;
            }

            set
            {
                if (cNPJField is null || cNPJField.Equals(value) != true)
                {
                    cNPJField = value;
                    OnPropertyChanged("CNPJ");
                }
            }
        }

        public string chCTe
        {
            get
            {
                return chCTeField;
            }

            set
            {
                if (chCTeField is null || chCTeField.Equals(value) != true)
                {
                    chCTeField = value;
                    OnPropertyChanged("chCTe");
                }
            }
        }

        public DateTime? dhEvento
        {
            get
            {
                return dhEventoField;
            }

            set
            {
                if (dhEventoField is null || dhEventoField.Equals(value) != true)
                {
                    dhEventoField = value;
                    OnPropertyChanged("dhEvento");
                }
            }
        }

        public string tpEvento
        {
            get
            {
                return tpEventoField;
            }

            set
            {
                if (tpEventoField is null || tpEventoField.Equals(value) != true)
                {
                    tpEventoField = value;
                    OnPropertyChanged("tpEvento");
                }
            }
        }

        public string nSeqEvento
        {
            get
            {
                return nSeqEventoField;
            }

            set
            {
                if (nSeqEventoField is null || nSeqEventoField.Equals(value) != true)
                {
                    nSeqEventoField = value;
                    OnPropertyChanged("nSeqEvento");
                }
            }
        }

        public TEventoInfEventoDetEvento detEvento
        {
            get
            {
                return detEventoField;
            }

            set
            {
                if (detEventoField is null || detEventoField.Equals(value) != true)
                {
                    detEventoField = value;
                    OnPropertyChanged("detEvento");
                }
            }
        }

        public string Id
        {
            get
            {
                return idField;
            }

            set
            {
                if (idField is null || idField.Equals(value) != true)
                {
                    idField = value;
                    OnPropertyChanged("Id");
                }
            }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if (sSerializer is null)
                {
                    sSerializer = new XmlSerializer(typeof(TEventoInfEvento));
                }

                return sSerializer;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public partial class TEventoInfEventoDetEvento : INotifyPropertyChanged
    {
        private XElement anyField; // System.Xml.XmlElement
        private string versaoEventoField;
        private static XmlSerializer sSerializer;

        [XmlAnyElement()]
        public XElement Any // System.Xml.XmlElement
        {
            get
            {
                return anyField;
            }

            set // System.Xml.XmlElement)
            {
                if (anyField is null || anyField.Equals(value) != true)
                {
                    anyField = value;
                    OnPropertyChanged("Any");
                }
            }
        }

        public string versaoEvento
        {
            get
            {
                return versaoEventoField;
            }

            set
            {
                if (versaoEventoField is null || versaoEventoField.Equals(value) != true)
                {
                    versaoEventoField = value;
                    OnPropertyChanged("versaoEvento");
                }
            }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if (sSerializer is null)
                {
                    sSerializer = new XmlSerializer(typeof(TEventoInfEventoDetEvento));
                }

                return sSerializer;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public partial class RetornoEvento : INotifyPropertyChanged
    {
        private TRetEventoInfEvento infEventoField;
        private SignatureType signatureField;
        private string versaoField;
        private static XmlSerializer sSerializer;

        public RetornoEvento() : base()
        {
            signatureField = new SignatureType();
            infEventoField = new TRetEventoInfEvento();
        }

        public TRetEventoInfEvento infEvento
        {
            get
            {
                return infEventoField;
            }

            set
            {
                if (infEventoField is null || infEventoField.Equals(value) != true)
                {
                    infEventoField = value;
                    OnPropertyChanged("infEvento");
                }
            }
        }

        public SignatureType Signature
        {
            get
            {
                return signatureField;
            }

            set
            {
                if (signatureField is null || signatureField.Equals(value) != true)
                {
                    signatureField = value;
                    OnPropertyChanged("Signature");
                }
            }
        }

        public string versao
        {
            get
            {
                return versaoField;
            }

            set
            {
                if (versaoField is null || versaoField.Equals(value) != true)
                {
                    versaoField = value;
                    OnPropertyChanged("versao");
                }
            }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if (sSerializer is null)
                {
                    sSerializer = new XmlSerializer(typeof(RetornoEvento));
                }

                return sSerializer;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        /// <summary>
        /// Serializes current TEnvEvento object into an XML document
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize()
        {
            System.IO.StreamReader streamReader = null;
            System.IO.MemoryStream memoryStream = null;
            try
            {
                memoryStream = new System.IO.MemoryStream();
                Serializer.Serialize(memoryStream, this);
                memoryStream.Seek(0L, System.IO.SeekOrigin.Begin);
                streamReader = new System.IO.StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Dispose();
                }

                if (memoryStream != null)
                {
                    memoryStream.Dispose();
                }
            }
        }

        /// <summary>
        /// Semelhante À Function Serialize, porém já retorna o resultado
        /// em uma instância de XmlDocument, agilizando o processo de assinatura
        /// digital dos eventos.
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public virtual XDocument SerializeToXMLDocument()
        {
            string str = Serialize();
            if (!string.IsNullOrEmpty(str) | string.IsNullOrWhiteSpace(str))
            {
                var doc = XDocument.Load(Serialize());
                // doc.LoadXml(Me.Serialize)
                return doc;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Deserializes workflow markup into an TEnvEvento object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output TEnvEvento object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool CanDeserialize(string xml, ref RetornoEvento obj, ref Exception exception)
        {
            exception = null;
            obj = default;
            try
            {
                obj = Deserialize(xml);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool CanDeserialize(string xml, ref RetornoEvento obj)
        {
            Exception exception = null;
            return CanDeserialize(xml, ref obj, ref exception);
        }

        public static RetornoEvento Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return (RetornoEvento)Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader));
            }
            finally
            {
                if (stringReader != null)
                {
                    stringReader.Dispose();
                }
            }
        }

        public static RetornoEvento Deserialize(System.IO.Stream s)
        {
            return (RetornoEvento)Serializer.Deserialize(s);
        }


        /// <summary>
        /// Serializes current TNfeProc object into file
        /// </summary>
        /// <param name="target">target stream of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool CanSaveTo(System.IO.Stream target, ref Exception exception)
        {
            exception = null;
            try
            {
                SaveTo(target);
                return true;
            }
            catch (Exception e)
            {
                exception = e;
                return false;
            }
        }

        public virtual void SaveTo(System.IO.Stream target)
        {
            if (target is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Save_NullStreamExceptionMessage);
            var streamWriter = new System.IO.StreamWriter(target);
            try
            {
                string xmlString = Serialize();
                // Dim xmlFile As System.IO.FileInfo = New System.IO.FileInfo(fileName)
                // streamWriter = xmlFile.CreateText
                streamWriter.WriteLine(xmlString);
                streamWriter.Flush();
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Dispose();
                }
            }
        }

        public virtual async void SaveToAsync(System.IO.Stream target)
        {
            if (target is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Save_NullStreamExceptionMessage);
            var streamWriter = new System.IO.StreamWriter(target);
            try
            {
                string xmlString = Serialize();
                await streamWriter.WriteLineAsync(xmlString);
                await streamWriter.FlushAsync();
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Dispose();
                }
            }
        }


        /// <summary>
        /// Deserializes xml markup from file into an TEnvEvento object
        /// </summary>
        /// <param name="source">target stream of outupt xml file</param>
        /// <param name="obj">Output TEnvEvento object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool CanLoadFrom(System.IO.Stream source, ref RetornoEvento obj, ref Exception exception)
        {
            exception = null;
            obj = default;
            try
            {
                obj = LoadFrom(source, false);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool CanLoadFrom(System.IO.Stream source, ref RetornoEvento obj)
        {
            Exception exception = null;
            return CanLoadFrom(source, ref obj, ref exception);
        }

        public static RetornoEvento LoadFrom(System.IO.Stream source, bool close_stream = true)
        {
            // Dim file As System.IO.FileStream = Nothing
            if (source is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Load_NullStreamExceptionMessage);
            System.IO.StreamReader sr = null;
            try
            {
                // file = New System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read)
                sr = new System.IO.StreamReader(source);
                string xmlString = sr.ReadToEnd();
                // sr.Close()
                // file.Close()
                return Deserialize(xmlString);
            }
            finally
            {
                if (sr != null & close_stream == true)
                {
                    sr.Dispose();
                }
            }
        }

        public static async Task<RetornoEvento> LoadFromAsync(System.IO.Stream source, bool close_stream = true)
        {
            if (source is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Load_NullStreamExceptionMessage);
            System.IO.StreamReader sr = null;
            try
            {
                // file = New System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read)
                sr = new System.IO.StreamReader(source);
                string xmlString = await sr.ReadToEndAsync();
                // sr.Close()
                // file.Close()
                return Deserialize(xmlString);
            }
            finally
            {
                if (sr != null & close_stream == true)
                {
                    sr.Dispose();
                }
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }

    public partial class TRetEventoInfEvento : INotifyPropertyChanged
    {
        private NFe.Ambiente tpAmbField;
        private string verAplicField;
        private NFe.OrgaoIBGE cOrgaoField;
        private string cStatField;
        private string xMotivoField;
        private string chCTeField;
        private string tpEventoField;
        private string xEventoField;
        private string nSeqEventoField;
        private string dhRegEventoField;
        private string nProtField;
        private string idField;
        private static XmlSerializer sSerializer;

        public NFe.Ambiente tpAmb
        {
            get
            {
                return tpAmbField;
            }

            set
            {
                if (tpAmbField.Equals(value) != true)
                {
                    tpAmbField = value;
                    OnPropertyChanged("tpAmb");
                }
            }
        }

        public string verAplic
        {
            get
            {
                return verAplicField;
            }

            set
            {
                if (verAplicField is null || verAplicField.Equals(value) != true)
                {
                    verAplicField = value;
                    OnPropertyChanged("verAplic");
                }
            }
        }

        public NFe.OrgaoIBGE cOrgao
        {
            get
            {
                return cOrgaoField;
            }

            set
            {
                if (cOrgaoField.Equals(value) != true)
                {
                    cOrgaoField = value;
                    OnPropertyChanged("cOrgao");
                }
            }
        }

        public string cStat
        {
            get
            {
                return cStatField;
            }

            set
            {
                if (cStatField is null || cStatField.Equals(value) != true)
                {
                    cStatField = value;
                    OnPropertyChanged("cStat");
                }
            }
        }

        public string xMotivo
        {
            get
            {
                return xMotivoField;
            }

            set
            {
                if (xMotivoField is null || xMotivoField.Equals(value) != true)
                {
                    xMotivoField = value;
                    OnPropertyChanged("xMotivo");
                }
            }
        }

        public string chCTe
        {
            get
            {
                return chCTeField;
            }

            set
            {
                if (chCTeField is null || chCTeField.Equals(value) != true)
                {
                    chCTeField = value;
                    OnPropertyChanged("chCTe");
                }
            }
        }

        public string tpEvento
        {
            get
            {
                return tpEventoField;
            }

            set
            {
                if (tpEventoField is null || tpEventoField.Equals(value) != true)
                {
                    tpEventoField = value;
                    OnPropertyChanged("tpEvento");
                }
            }
        }

        public string xEvento
        {
            get
            {
                return xEventoField;
            }

            set
            {
                if (xEventoField is null || xEventoField.Equals(value) != true)
                {
                    xEventoField = value;
                    OnPropertyChanged("xEvento");
                }
            }
        }

        public string nSeqEvento
        {
            get
            {
                return nSeqEventoField;
            }

            set
            {
                if (nSeqEventoField is null || nSeqEventoField.Equals(value) != true)
                {
                    nSeqEventoField = value;
                    OnPropertyChanged("nSeqEvento");
                }
            }
        }

        public string dhRegEvento
        {
            get
            {
                return dhRegEventoField;
            }

            set
            {
                if (dhRegEventoField is null || dhRegEventoField.Equals(value) != true)
                {
                    dhRegEventoField = value;
                    OnPropertyChanged("dhRegEvento");
                }
            }
        }

        public string nProt
        {
            get
            {
                return nProtField;
            }

            set
            {
                if (nProtField is null || nProtField.Equals(value) != true)
                {
                    nProtField = value;
                    OnPropertyChanged("nProt");
                }
            }
        }

        public string Id
        {
            get
            {
                return idField;
            }

            set
            {
                if (idField is null || idField.Equals(value) != true)
                {
                    idField = value;
                    OnPropertyChanged("Id");
                }
            }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if (sSerializer is null)
                {
                    sSerializer = new XmlSerializer(typeof(TRetEventoInfEvento));
                }

                return sSerializer;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}