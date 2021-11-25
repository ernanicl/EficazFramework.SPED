﻿// ' ------------------------------------------------------------------------------
// '  <auto-generated>
// '    Generated by Xsd2Code. Version 3.6.0.0
// '    <NameSpace>EficazFramework.SPED.GNRE.Services.GNREData</NameSpace><Collection>ObservableCollection</Collection><codeType>VisualBasic</codeType><EnableDataBinding>True</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><PascalCase>False</PascalCase><BaseClassName>EntityBase</BaseClassName><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><InitializeFields>All</InitializeFields><GenerateAllTypes>True</GenerateAllTypes>
// '  </auto-generated>
// ' ------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace EficazFramework.SPED.Schemas.GNRE.V1
{
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.33440")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    [XmlRoot("TConsultaConfigUf", Namespace = "http://www.gnre.pe.gov.br", IsNullable = false)]
    public partial class ConsultaConfigUF : INotifyPropertyChanged
    {
        private Ambiente ambienteField;
        private UF ufField;
        private ConsultaConfigUfReceita receitaField;
        private static XmlSerializer sSerializer;

        public ConsultaConfigUF() : base()
        {
            receitaField = new ConsultaConfigUfReceita();
        }

        public Ambiente ambiente
        {
            get
            {
                return ambienteField;
            }

            set
            {
                if (ambienteField.Equals(value) != true)
                {
                    ambienteField = value;
                    OnPropertyChanged("ambiente");
                }
            }
        }

        public UF uf
        {
            get
            {
                return ufField;
            }

            set
            {
                if (ufField.Equals(value) != true)
                {
                    ufField = value;
                    OnPropertyChanged("uf");
                }
            }
        }

        public ConsultaConfigUfReceita receita
        {
            get
            {
                return receitaField;
            }

            set
            {
                if (receitaField is null || receitaField.Equals(value) != true)
                {
                    receitaField = value;
                    OnPropertyChanged("receita");
                }
            }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if (sSerializer is null)
                {
                    sSerializer = new XmlSerializer(typeof(ConsultaConfigUF));
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
        /// Serializes current TNfeProc object into an XML document
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize()
        {
            StreamReader streamReader = null;
            MemoryStream memoryStream = null;
            try
            {
                memoryStream = new MemoryStream();
                Serializer.Serialize(memoryStream, this);
                memoryStream.Seek(0L, SeekOrigin.Begin);
                streamReader = new StreamReader(memoryStream);
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
        public static bool CanDeserialize(string xml, ref ConsultaConfigUF obj, ref Exception exception)
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

        public static bool CanDeserialize(string xml, ref ConsultaConfigUF obj)
        {
            Exception exception = null;
            return CanDeserialize(xml, ref obj, ref exception);
        }

        public static ConsultaConfigUF Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                // stringReader.ReadToEnd() 'TESTING...
                return (ConsultaConfigUF)Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader));
            }
            // Return CType(Serializer.Deserialize(stringReader), ConsultaConfigUF)
            finally
            {
                if (stringReader != null)
                {
                    stringReader.Dispose();
                }
            }
        }

        public static ConsultaConfigUF Deserialize(Stream s)
        {
            return (ConsultaConfigUF)Serializer.Deserialize(s);
        }


        /// <summary>
        /// Serializes current TNfeProc object into file
        /// </summary>
        /// <param name="target">target stream of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool CanSaveToFile(Stream target, ref Exception exception)
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

        public virtual void SaveTo(Stream target)
        {
            if (target is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Save_NullStreamExceptionMessage);
            var streamWriter = new StreamWriter(target);
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

        public virtual async void SaveToAsync(Stream target)
        {
            if (target is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Save_NullStreamExceptionMessage);
            var streamWriter = new StreamWriter(target);
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
        public static bool CanLoadFrom(Stream source, ref ConsultaConfigUF obj, ref Exception exception)
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

        public static bool CanLoadFrom(Stream source, ref ConsultaConfigUF obj)
        {
            Exception exception = null;
            return CanLoadFrom(source, ref obj, ref exception);
        }

        public static ConsultaConfigUF LoadFrom(Stream source)
        {
            if (source is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Load_NullStreamExceptionMessage);
            StreamReader sr = null;
            try
            {
                // file = New System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read)
                sr = new StreamReader(source);
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

        public static async Task<ConsultaConfigUF> LoadFromAsync(Stream source)
        {
            if (source is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Load_NullStreamExceptionMessage);
            StreamReader sr = null;
            try
            {
                // file = New System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read)
                sr = new StreamReader(source);
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

        public static async Task<ConsultaConfigUF> LoadFromAsync(Stream source, bool close_stream = true)
        {
            if (source is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Load_NullStreamExceptionMessage);
            StreamReader sr = null;
            try
            {
                // file = New System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read)
                sr = new StreamReader(source);
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

    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.33440")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType("TConsultaConfigUfReceita", AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class ConsultaConfigUfReceita : INotifyPropertyChanged
    {
        private PTBrBoolean? courierField;
        private string valueField;
        private static XmlSerializer sSerializer;

        [XmlAttribute()]
        public PTBrBoolean courier
        {
            get
            {
                if (courierField.HasValue)
                {
                    return courierField.Value;
                }
                else
                {
                    return (PTBrBoolean)Conversions.ToInteger(default);
                }
            }

            set
            {
                if (courierField.Equals(value) != true)
                {
                    courierField = value;
                    OnPropertyChanged("courier");
                }
            }
        }

        [XmlIgnore()]
        public bool courierSpecified
        {
            get
            {
                return courierField.HasValue;
            }

            set
            {
                if (value == false)
                {
                    courierField = default;
                }
            }
        }

        [XmlText()]
        public string Value
        {
            get
            {
                return valueField;
            }

            set
            {
                if (valueField is null || valueField.Equals(value) != true)
                {
                    valueField = value;
                    OnPropertyChanged("Value");
                }
            }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if (sSerializer is null)
                {
                    sSerializer = new XmlSerializer(typeof(ConsultaConfigUfReceita));
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
        /// Serializes current TNfeProc object into an XML document
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize()
        {
            StreamReader streamReader = null;
            MemoryStream memoryStream = null;
            try
            {
                memoryStream = new MemoryStream();
                Serializer.Serialize(memoryStream, this);
                memoryStream.Seek(0L, SeekOrigin.Begin);
                streamReader = new StreamReader(memoryStream);
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
        public static bool CanDeserialize(string xml, ref ConsultaConfigUfReceita obj, ref Exception exception)
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

        public static bool CanDeserialize(string xml, ref ConsultaConfigUfReceita obj)
        {
            Exception exception = null;
            return CanDeserialize(xml, ref obj, ref exception);
        }

        public static ConsultaConfigUfReceita Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                // stringReader.ReadToEnd() 'TESTING...
                return (ConsultaConfigUfReceita)Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader));
            }
            // Return CType(Serializer.Deserialize(stringReader), ConsultaConfigUfReceita)
            finally
            {
                if (stringReader != null)
                {
                    stringReader.Dispose();
                }
            }
        }

        public static ConsultaConfigUfReceita Deserialize(Stream s)
        {
            return (ConsultaConfigUfReceita)Serializer.Deserialize(s);
        }


        /// <summary>
        /// Serializes current TNfeProc object into file
        /// </summary>
        /// <param name="target">target stream of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool CanSaveToFile(Stream target, ref Exception exception)
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

        public virtual void SaveTo(Stream target)
        {
            if (target is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Save_NullStreamExceptionMessage);
            var streamWriter = new StreamWriter(target);
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

        public virtual async void SaveToAsync(Stream target)
        {
            if (target is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Save_NullStreamExceptionMessage);
            var streamWriter = new StreamWriter(target);
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
        public static bool CanLoadFrom(Stream source, ref ConsultaConfigUfReceita obj, ref Exception exception)
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

        public static bool CanLoadFrom(Stream source, ref ConsultaConfigUfReceita obj)
        {
            Exception exception = null;
            return CanLoadFrom(source, ref obj, ref exception);
        }

        public static ConsultaConfigUfReceita LoadFrom(Stream source)
        {
            if (source is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Load_NullStreamExceptionMessage);
            StreamReader sr = null;
            try
            {
                // file = New System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read)
                sr = new StreamReader(source);
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

        public static async Task<ConsultaConfigUfReceita> LoadFromAsync(Stream source)
        {
            if (source is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Load_NullStreamExceptionMessage);
            StreamReader sr = null;
            try
            {
                // file = New System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read)
                sr = new StreamReader(source);
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

        public static async Task<ConsultaConfigUfReceita> LoadFromAsync(Stream source, bool close_stream = true)
        {
            if (source is null)
                throw new ArgumentException(Resources.Strings.Validation.Classes_Load_NullStreamExceptionMessage);
            StreamReader sr = null;
            try
            {
                // file = New System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read)
                sr = new StreamReader(source);
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