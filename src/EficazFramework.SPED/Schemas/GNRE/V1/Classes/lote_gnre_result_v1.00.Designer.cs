﻿// ' ------------------------------------------------------------------------------
// '  <auto-generated>
// '    Generated by Xsd2Code. Version 3.6.0.0
// '    <NameSpace>EficazFramework.SPED</NameSpace><Collection>ObservableCollection</Collection><codeType>VisualBasic</codeType><EnableDataBinding>True</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><PascalCase>False</PascalCase><BaseClassName>EntityBase</BaseClassName><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><InitializeFields>All</InitializeFields><GenerateAllTypes>True</GenerateAllTypes>
// '  </auto-generated>
// ' ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace EficazFramework.SPED.Schemas.GNRE.V1
{
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.33440")]
    [Serializable()]
    [DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    [System.Xml.Serialization.XmlRoot("TResultLote_GNRE", Namespace = "http://www.gnre.pe.gov.br", IsNullable = false)]
    public partial class ResultadoLote : INotifyPropertyChanged
    {
        private Ambiente ambienteField;
        private string numeroReciboField;
        private ResultadoLoteProcessamento situacaoProcessField;
        private string resultadoField;
        private List<ResultadoGuiaGNRE> _resultadoClasses = new List<ResultadoGuiaGNRE>();
        private static System.Xml.Serialization.XmlSerializer sSerializer;

        public ResultadoLote() : base()
        {
            situacaoProcessField = new ResultadoLoteProcessamento();
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

        public string numeroRecibo
        {
            get
            {
                return numeroReciboField;
            }

            set
            {
                if (numeroReciboField is null || numeroReciboField.Equals(value) != true)
                {
                    numeroReciboField = value;
                    OnPropertyChanged("numeroRecibo");
                }
            }
        }

        public ResultadoLoteProcessamento situacaoProcess
        {
            get
            {
                return situacaoProcessField;
            }

            set
            {
                if (situacaoProcessField is null || situacaoProcessField.Equals(value) != true)
                {
                    situacaoProcessField = value;
                    OnPropertyChanged("situacaoProcess");
                }
            }
        }

        public string resultado
        {
            get
            {
                return resultadoField;
            }

            set
            {
                if (resultadoField is null || resultadoField.Equals(value) != true)
                {
                    resultadoField = value;
                    OnPropertyChanged("resultado");
                    if (!(string.IsNullOrEmpty(value) | string.IsNullOrWhiteSpace(value)))
                    {
                        FormataResultado();
                    }
                }
            }
        }

        public List<ResultadoGuiaGNRE> ResultadoFormatado
        {
            get
            {
                return _resultadoClasses;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if (sSerializer is null)
                {
                    sSerializer = new System.Xml.Serialization.XmlSerializer(typeof(ResultadoLote));
                }

                return sSerializer;
            }
        }

        public void FormataResultado()
        {
            _resultadoClasses.Clear();
            string[] linhas = null;
            try
            {
                linhas = resultado.Split(Constants.vbLf);
            }
            catch (Exception)
            {
            }

            // Dim i As Integer = 0
            int int_test = 0;
            foreach (string linha in linhas)
            {
                // If i = 0 Then Continue For
                if (linha.Substring(0, 1) == "1")
                {
                    var aprovado = new ResultadoGuiaAprovadaGNRE();
                    aprovado.Identificador = 1;
                    if (int.TryParse(linha.Substring(1, 4), out int_test))
                        aprovado.NumeroSequencial = Conversions.ToInteger(linha.Substring(1, 4));
                    if (int.TryParse(linha.Substring(5, 1), out int_test))
                        aprovado.SituacaoGuia = (SituacaoGuia)Conversions.ToInteger(Conversions.ToInteger(linha.Substring(5, 1)));
                    aprovado.UFFavorecida = linha.Substring(6, 2);
                    aprovado.CodigoReceita = linha.Substring(8, 6);
                    if (int.TryParse(linha.Substring(14, 1), out int_test))
                        aprovado.EmitenteTipoDocmento = (PersonalidadeJuridicaRetorno)Conversions.ToInteger(Conversions.ToInteger(linha.Substring(14, 1)));
                    aprovado.EmitenteDocumento = linha.Substring(15, 16).Trim();
                    aprovado.EmitenteRazaoSocial = linha.Substring(31, 60).Trim();
                    aprovado.EmitenteEndereco = linha.Substring(91, 60).Trim();
                    aprovado.EmitenteMunicipio = linha.Substring(151, 50).Trim();
                    aprovado.EmitenteUF = linha.Substring(201, 2);
                    aprovado.EmitenteCEP = linha.Substring(203, 8).Trim();
                    aprovado.EmitenteTelefone = linha.Substring(211, 11).Trim();
                    if (int.TryParse(linha.Substring(222, 1), out int_test))
                        aprovado.DestinatarioTipoDocumento = (PersonalidadeJuridicaRetorno)Conversions.ToInteger(Conversions.ToInteger(linha.Substring(222, 1)));
                    aprovado.DestinatarioDocumento = linha.Substring(223, 16).Trim();
                    aprovado.DestinatarioMunicipio = linha.Substring(239, 50).Trim();
                    aprovado.Produto = linha.Substring(289, 255).Trim();
                    if (int.TryParse(linha.Substring(544, 18), out int_test))
                        aprovado.NumeroDocumento = Conversions.ToInteger(linha.Substring(544, 18));
                    aprovado.Convenio = linha.Substring(562, 30).Trim();
                    aprovado.InformacoesComplementares = linha.Substring(592, 300).Trim();
                    try
                    {
                        aprovado.DataVencimento = new DateTime(Conversions.ToInteger(linha.Substring(896, 4)), Conversions.ToInteger(linha.Substring(894, 2)), Conversions.ToInteger(linha.Substring(892, 2)));
                    }
                    catch (Exception)
                    {
                    }

                    try
                    {
                        aprovado.DataLimitePagamento = new DateTime(Conversions.ToInteger(linha.Substring(904, 4)), Conversions.ToInteger(linha.Substring(902, 2)), Conversions.ToInteger(linha.Substring(900, 2)));
                    }
                    catch (Exception)
                    {
                    }

                    string @ref = linha.Substring(908, 1);
                    if (int.TryParse(@ref, out int_test))
                    {
                        aprovado.PeriodoReferencia = (ReferenciaPeriodo)Conversions.ToInteger(Conversions.ToInteger(@ref));
                    }
                    else
                    {
                        aprovado.PeriodoReferencia = ReferenciaPeriodo.Mensal;
                    }

                    try
                    {
                        aprovado.MesAnoReferencia = new DateTime(Conversions.ToInteger(linha.Substring(911, 4)), Conversions.ToInteger(linha.Substring(909, 2)), 1);
                    }
                    catch (Exception)
                    {
                    }

                    if (int.TryParse(linha.Substring(915, 3), out int_test))
                        aprovado.Parcela = Conversions.ToShort(linha.Substring(915, 3));
                    if (int.TryParse(Conversions.ToInteger(linha.Substring(918, 15)).ToString(), out int_test))
                        aprovado.ValorPrincipal = Conversions.ToInteger(linha.Substring(918, 15)) / 100d;
                    if (int.TryParse(Conversions.ToInteger(linha.Substring(933, 15)).ToString(), out int_test))
                        aprovado.AtualizacaoMonetaria = Conversions.ToInteger(linha.Substring(933, 15)) / 100d;
                    if (int.TryParse(linha.Substring(948, 15), out int_test))
                        aprovado.Juros = Conversions.ToInteger(linha.Substring(948, 15)) / 100d;
                    if (int.TryParse(linha.Substring(963, 15), out int_test))
                        aprovado.Multa = Conversions.ToInteger(linha.Substring(963, 15)) / 100d;
                    aprovado.RepresentacaoNumerica = linha.Substring(978, 48).Trim();
                    aprovado.CodigoDeBarras = linha.Substring(1026, 44).Trim();
                    if (int.TryParse(linha.Substring(1070, 1), out int_test))
                        aprovado.QuantidadeVias = Conversions.ToInteger(linha.Substring(1070, 1));
                    aprovado.NumeroControle = linha.Substring(1071, 16).Trim();
                    aprovado.IdentificadorGuia = linha.Substring(1087, 10).Trim();
                    string contg = linha.Substring(1097, 1);
                    if (int.TryParse(contg, out int_test))
                    {
                        aprovado.SituacaoContingencia = (Contingencia)Conversions.ToInteger(Conversions.ToInteger(contg));
                    }
                    else
                    {
                        aprovado.SituacaoContingencia = Contingencia.UF;
                    }

                    aprovado.Reservado = linha.Substring(1098, 126).Trim();
                    _resultadoClasses.Add(aprovado);
                }
                else if (linha.Substring(0, 1) == "2")
                {
                    var recusado = new ResultadoGuiaRecusadaGNRE();
                    recusado.Identificador = 2;
                    if (int.TryParse(linha.Substring(1, 4), out int_test))
                        recusado.NumeroSequencial = Conversions.ToInteger(linha.Substring(1, 4));
                    recusado.NomeCampo = linha.Substring(5, 30).Trim();
                    recusado.CodigoRecusa = linha.Substring(35, 3).Trim();
                    recusado.MotivoRecusa = linha.Substring(38, 355).Trim();

                    // removendo a linha anterior, já que na recusa a linha com identificador "1" também é informada...
                    ResultadoGuiaAprovadaGNRE guiaDisgracada = null;
                    try
                    {
                        guiaDisgracada = (ResultadoGuiaAprovadaGNRE)(from r in _resultadoClasses
                                                                     where r.NumeroSequencial == recusado.NumeroSequencial
                                                                     select r).FirstOrDefault();
                        if (guiaDisgracada is null)
                        {
                            guiaDisgracada = (ResultadoGuiaAprovadaGNRE)_resultadoClasses.LastOrDefault();
                        }

                        if (guiaDisgracada != null)
                        {
                            _resultadoClasses.Remove(guiaDisgracada);
                        }
                    }
                    catch (Exception)
                    {
                    }

                    _resultadoClasses.Add(recusado);
                }
                // i += 1
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
        public static bool CanDeserialize(string xml, ref ResultadoLote obj, ref Exception exception)
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

        public static bool CanDeserialize(string xml, ref ResultadoLote obj)
        {
            Exception exception = null;
            return CanDeserialize(xml, ref obj, ref exception);
        }

        public static ResultadoLote Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                // stringReader.ReadToEnd() 'TESTING...
                return (ResultadoLote)Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader));
            }
            // Return CType(Serializer.Deserialize(stringReader), ResultadoLote)
            finally
            {
                if (stringReader != null)
                {
                    stringReader.Dispose();
                }
            }
        }

        public static ResultadoLote Deserialize(Stream s)
        {
            return (ResultadoLote)Serializer.Deserialize(s);
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
        public static bool CanLoadFrom(Stream source, ref ResultadoLote obj, ref Exception exception)
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

        public static bool CanLoadFrom(Stream source, ref ResultadoLote obj)
        {
            Exception exception = null;
            return CanLoadFrom(source, ref obj, ref exception);
        }

        public static ResultadoLote LoadFrom(Stream source)
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

        public static async Task<ResultadoLote> LoadFromAsync(Stream source)
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

        public static async Task<ResultadoLote> LoadFromAsync(Stream source, bool close_stream = true)
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
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class ResultadoLoteProcessamento : INotifyPropertyChanged
    {
        private string codigoField;
        private string descricaoField;
        private static System.Xml.Serialization.XmlSerializer sSerializer;

        public string codigo
        {
            get
            {
                return codigoField;
            }

            set
            {
                if (codigoField is null || codigoField.Equals(value) != true)
                {
                    codigoField = value;
                    OnPropertyChanged("codigo");
                }
            }
        }

        public string descricao
        {
            get
            {
                return descricaoField;
            }

            set
            {
                if (descricaoField is null || descricaoField.Equals(value) != true)
                {
                    descricaoField = value;
                    OnPropertyChanged("descricao");
                }
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if (sSerializer is null)
                {
                    sSerializer = new System.Xml.Serialization.XmlSerializer(typeof(ResultadoLoteProcessamento));
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
        public static bool CanDeserialize(string xml, ref ResultadoLoteProcessamento obj, ref Exception exception)
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

        public static bool CanDeserialize(string xml, ref ResultadoLoteProcessamento obj)
        {
            Exception exception = null;
            return CanDeserialize(xml, ref obj, ref exception);
        }

        public static ResultadoLoteProcessamento Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                // stringReader.ReadToEnd() 'TESTING...
                return (ResultadoLoteProcessamento)Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader));
            }
            // Return CType(Serializer.Deserialize(stringReader), ResultadoLoteProcessamento)
            finally
            {
                if (stringReader != null)
                {
                    stringReader.Dispose();
                }
            }
        }

        public static ResultadoLoteProcessamento Deserialize(Stream s)
        {
            return (ResultadoLoteProcessamento)Serializer.Deserialize(s);
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
        public static bool CanLoadFrom(Stream source, ref ResultadoLoteProcessamento obj, ref Exception exception)
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

        public static bool CanLoadFrom(Stream source, ref ResultadoLoteProcessamento obj)
        {
            Exception exception = null;
            return CanLoadFrom(source, ref obj, ref exception);
        }

        public static ResultadoLoteProcessamento LoadFrom(Stream source)
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

        public static async Task<ResultadoLoteProcessamento> LoadFromAsync(Stream source)
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

        public static async Task<ResultadoLoteProcessamento> LoadFromAsync(Stream source, bool close_stream = true)
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

    public abstract class ResultadoGuiaGNRE
    {
        public int? Identificador { get; set; }
        public int? NumeroSequencial { get; set; }
    }

    public class ResultadoGuiaAprovadaGNRE : ResultadoGuiaGNRE, INotifyPropertyChanged
    {
        public SituacaoGuia SituacaoGuia { get; set; }
        public string UFFavorecida { get; set; }
        public string CodigoReceita { get; set; }
        public PersonalidadeJuridicaRetorno EmitenteTipoDocmento { get; set; }
        public string EmitenteDocumento { get; set; }
        public string EmitenteRazaoSocial { get; set; }
        public string EmitenteEndereco { get; set; }
        public string EmitenteMunicipio { get; set; }
        public string EmitenteUF { get; set; }
        public string EmitenteCEP { get; set; }
        public string EmitenteTelefone { get; set; }
        public PersonalidadeJuridicaRetorno DestinatarioTipoDocumento { get; set; }
        public object DestinatarioDocumento { get; set; }
        public string DestinatarioMunicipio { get; set; }
        public string Produto { get; set; }
        public int? NumeroDocumento { get; set; }
        public string Convenio { get; set; }
        // processar #@# como quebra de linha
        public string InformacoesComplementares { get; set; }
        public DateTime? DataVencimento { get; set; }
        public DateTime? DataLimitePagamento { get; set; }
        public ReferenciaPeriodo PeriodoReferencia { get; set; }
        public DateTime? MesAnoReferencia { get; set; }
        public short? Parcela { get; set; }
        public double? ValorPrincipal { get; set; }
        public double? AtualizacaoMonetaria { get; set; }
        public double? Juros { get; set; }
        public double? Multa { get; set; }
        public string RepresentacaoNumerica { get; set; }
        public string CodigoDeBarras { get; set; }

        private int? _qtdadeVias;
        public int? QuantidadeVias
        {
            get
            {
                return _qtdadeVias;
            }

            set
            {
                _qtdadeVias = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuantidadeVias"));
            }
        }

        public string NumeroControle { get; set; }
        public string IdentificadorGuia { get; set; }
        public Contingencia SituacaoContingencia { get; set; }
        public string Reservado { get; set; }

        public double? ValorRecolher
        {
            get
            {
                return ValorPrincipal + AtualizacaoMonetaria + Juros + Multa;
            }
        }

        public string CodigoBarrasFormatado
        {
            get
            {
                if (RepresentacaoNumerica != null)
                {
                    if (RepresentacaoNumerica.Length == 48)
                    {
                        return RepresentacaoNumerica.Substring(0, 11) + " " + RepresentacaoNumerica.Substring(11, 1) + " " + RepresentacaoNumerica.Substring(12, 11) + " " + RepresentacaoNumerica.Substring(23, 1) + " " + RepresentacaoNumerica.Substring(24, 11) + " " + RepresentacaoNumerica.Substring(35, 1) + " " + RepresentacaoNumerica.Substring(36, 11) + " " + RepresentacaoNumerica.Substring(47, 1);
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        // Private _i2of5 As String
        public string CodigoBarrasCodificado { get; set; }
        // Get
        // 'If Me.CodigoDeBarras IsNot Nothing Then
        // '    Dim code As New BarcodeLib.Barcode(Me.CodigoDeBarras, BarcodeLib.TYPE.Interleaved2of5)
        // '    code.Width = CInt(480)
        // '    code.Height = CInt(50)
        // '    code.Encode(BarcodeLib.TYPE.Interleaved2of5, Me.CodigoDeBarras)
        // '    Return code.EncodedValue
        // 'Else
        // '    Return Nothing
        // 'End If
        // Return _i2of5
        // End Get
        // Set(value As String)
        // _i2of5 = value
        // End Set
        // End Property

        public object CodigoBarrasByte { get; set; }
        public string AutenticacaoBancaria { get; set; }
        public DateTime? DataPagamento { get; set; }
        public double? ValorPago { get; set; }

        // Public Sub Encode()
        // Dim code As New BarcodeLib.Barcode(Me.CodigoDeBarras, BarcodeLib.TYPE.Interleaved2of5)
        // code.Width = CInt(1384)
        // code.Height = CInt(50)
        // code.Alignment = BarcodeLib.AlignmentPositions.CENTER
        // code.Encode(BarcodeLib.TYPE.Interleaved2of5, Me.CodigoDeBarras)
        // Me.CodigoBarrasByte = Text.Encoding.ASCII.GetBytes(code.EncodedValue)
        // Debug.WriteLine(Me.CodigoBarrasByte)
        // RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("CodigoBarrasByte"))
        // End Sub

        // Public ReadOnly Property CodigoBarrasCodificadoByte() As Byte()
        // Get
        // If Me.CodigoDeBarras IsNot Nothing Then
        // 'Dim code As New BarcodeLib.Barcode(Me.RepresentacaoNumerica, BarcodeLib.TYPE.Interleaved2of5)
        // Dim code As New BarcodeLib.Barcode(Me.CodigoDeBarras, BarcodeLib.TYPE.Interleaved2of5)
        // code.Width = CInt(1384)
        // code.Height = CInt(50)
        // code.Alignment = BarcodeLib.AlignmentPositions.CENTER
        // code.Encode(BarcodeLib.TYPE.Interleaved2of5, Me.CodigoDeBarras)
        // Return code.GetImageData(BarcodeLib.SaveTypes.BMP)
        // Else
        // Return Nothing
        // End If
        // End Get
        // End Property

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class ResultadoGuiaRecusadaGNRE : ResultadoGuiaGNRE
    {
        public string NomeCampo { get; set; }
        public string CodigoRecusa { get; set; }
        public string MotivoRecusa { get; set; }
    }
}