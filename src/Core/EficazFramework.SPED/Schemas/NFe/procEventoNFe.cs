﻿// ' ------------------------------------------------------------------------------
// '  <auto-generated>
// '    Generated by Xsd2Code. Version 3.6.0.0
// '    <NameSpace>EficazFramework.SPED.Schemas.NFe.ConsultaProtocolo</NameSpace><Collection>ObservableCollection</Collection><codeType>VisualBasic</codeType><EnableDataBinding>True</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><PascalCase>False</PascalCase><BaseClassName>EntityBase</BaseClassName><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><InitializeFields>All</InitializeFields><GenerateAllTypes>True</GenerateAllTypes>
// '  </auto-generated>
// ' ------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Xml.Serialization;
using EficazFramework.SPED.Utilities.XML;

namespace EficazFramework.SPED.Schemas.NFe
{

    /// <summary>
    /// Esta classe representa o retorno de Cancelamento da NF-e por meio de Evento.
    /// </summary>
    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.18033")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRoot("procEventoNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class ProcessoEvento : INotifyPropertyChanged, IXmlSpedDocument
    {

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public ProcessoEvento() : base()
        {
            // Me.retEventoField = New EventoRetorno
            // Me.eventoField = New Evento()
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private Evento eventoField; // TEvento
        private EventoRetorno retEventoField; // TRetEvento
        private VersaoServicoEvento versaoField;
        private static XmlSerializer sSerializer;

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [XmlElement("evento")]
        public Evento Evento
        {
            get
            {
                return eventoField;
            }

            set
            {
                if (eventoField is null || eventoField.Equals(value) != true)
                {
                    eventoField = value;
                    OnPropertyChanged("Evento");
                }
            }
        }

        [XmlElement("retEvento")]
        public EventoRetorno EventoRetorno
        {
            get
            {
                return retEventoField;
            }

            set
            {
                if (retEventoField is null || retEventoField.Equals(value) != true)
                {
                    retEventoField = value;
                    OnPropertyChanged("EventoRetorno");
                }
            }
        }

        [XmlAttribute(AttributeName = "versao")]
        public VersaoServicoEvento Versao
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
                    OnPropertyChanged("Versao");
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
                return XmlDocumentType.NFeEvent;
            }
        }

        [XmlIgnore()]
        public DateTime? DataEmissao
        {
            get
            {
                return Evento.InformacaoEvento.EventoData;
            }
        }

        [XmlIgnore()]
        public string Chave
        {
            get
            {
                // Return Me.Evento.InformacaoEvento.Id
                if (Evento.InformacaoEvento.Id != null)
                    return System.Text.RegularExpressions.Regex.Replace(Evento.InformacaoEvento.Id, "[^0-9]", "");
                else
                    return string.Empty;
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public event PropertyChangedEventHandler PropertyChanged;

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        /// <summary>
        /// Serializes current TNfeProc object into an XML document
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
        /// Deserializes workflow markup into an TNfeProc object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output TNfeProc object</param>
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
                // stringReader.ReadToEnd() 'TESTING...
                return (ProcessoEvento)Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader));
            }
            // Return CType(Serializer.Deserialize(stringReader), ProcessoEvento)
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
        public virtual bool CanSaveToFile(System.IO.Stream target, ref Exception exception)
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
        /// Deserializes xml markup from file into an TNfeProc object
        /// </summary>
        /// <param name="source">target stream of outupt xml file</param>
        /// <param name="obj">Output TNfeProc object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool CanLoadFrom(System.IO.Stream source, ref ProcessoEvento obj, ref Exception exception)
        {
            exception = null;
            obj = default;
            try
            {
                obj = LoadFrom(source);
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

        public static ProcessoEvento LoadFrom(System.IO.Stream source)
        {
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
                if (source != null)
                {
                    source.Dispose();
                }

                if (sr != null)
                {
                    sr.Dispose();
                }
            }
        }

        public static async Task<ProcessoEvento> LoadFromAsync(System.IO.Stream source)
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
                if (source != null)
                {
                    source.Dispose();
                }

                if (sr != null)
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
}