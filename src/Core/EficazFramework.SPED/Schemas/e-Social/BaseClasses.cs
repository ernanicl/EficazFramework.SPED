﻿using System.IO;

namespace EficazFramework.SPED.Schemas.eSocial;

/// <exclude/>
public abstract class ESocialBindableObject : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    protected void RaisePropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}

/// <summary>
/// Abstração padrão para implementação em todos os eventos da escrituração.
/// </summary>
[XmlRoot("eSocial")]
public abstract class Evento : ESocialBindableObject, IXmlSignableDocument
{
    internal const string root = "eSocial";

    /// <summary>
    /// <see cref="EficazFramework.SPED.Schemas.EFD_Reinf.Versao"/> do schema para leitura / escrita
    /// </summary>
    [XmlIgnore]
    public Versao Versao { get; set; } = Versao.v_S_01_02_00;

    // Base Members
    private XmlSerializer sSerializer;

    /// <summary>
    /// Retorna uma nova instância de XmlSerializer(T) onde T representa a classe que está herdando <see cref="Evento"/>
    /// </summary>
    public abstract XmlSerializer DefineSerializer();

    /// <summary>
    /// Gera uma ID única para o Evento a ser enviado para o portal do SPED.
    /// Cada tipo de evento da EFD-Reinf possui sua forma de geração.
    /// </summary>
    public abstract void GeraEventoID();

    /// <summary>
    /// Retorna o CNPJ do Contribuinte titular do evento.
    /// </summary>
    public abstract string ContribuinteCNPJ();



    // IXmlSignableDocument Members

    /// <summary>
    /// Especifica qual Tag do XML do evento deve ser assinada por Certificado Digital
    /// </summary>
    public abstract string TagToSign { get; }

    /// <summary>
    /// Retorna a ID do evento, criada pelo método <see cref="GeraEventoID"/>
    /// </summary>
    public abstract string TagId { get; }

    /// <summary>
    /// Informa se a Uri de referência da Tag assinada deve ser vazia, ou se deve ser formada conforme especificações do Manual Técnico.
    /// </summary>
    public abstract bool EmptyURI { get; }

    /// <summary>
    /// Informa se o XML deve ser assinado utilizando criptografia SHA256.
    /// </summary>
    public abstract bool SignAsSHA256 { get; }



    // Implemented Members

    /// <summary>
    /// Substitui o método ToString() de object para retornar o resultado do método <see cref="Serialize"/>
    /// </summary>
    public override string ToString() =>
        Write();

    /// <summary>
    /// Serializa o evento da EFD-Reinf para a representação em string do conteúdo do XML.
    /// </summary>
    /// <returns>string XML value</returns>
    public string Write()
    {
        System.IO.StreamReader streamReader = null;
        System.IO.MemoryStream memoryStream = null;
        try
        {
            memoryStream = new System.IO.MemoryStream();
            sSerializer = DefineSerializer();
            using (var xmlwriter = XmlWriter.Create(memoryStream, new XmlWriterSettings()
            {
                Indent = true,

            }))
            {
                sSerializer.Serialize(xmlwriter, this);
            }
            memoryStream.Seek(0L, System.IO.SeekOrigin.Begin);
            streamReader = new System.IO.StreamReader(memoryStream);
            return streamReader.ReadToEnd();
        }
        finally
        {
            streamReader?.Dispose();
            memoryStream?.Dispose();
        }
    }

    /// <summary>
    /// Efetua a leitura do evento em XML e retorna uma instância do Evento/> 
    /// </summary>
    public Evento Read(string xmlContent)
    {
        sSerializer = DefineSerializer();
        return Read(new MemoryStream(System.Text.Encoding.UTF8.GetBytes(xmlContent))) as Evento;
    }

    /// <summary>
    /// Efetua a leitura do evento em XML e retorna uma instância do Evento/> 
    /// </summary>
    public Evento Read(System.IO.Stream xmlStream)
    {
        sSerializer = DefineSerializer();
        var result = sSerializer.Deserialize(xmlStream);
        return result as Evento;
    }

}


/// <summary>
/// # e-SOCIAL<br/>
/// ## Publico Alvo<br/>
///  - Pessoas Físicas e Jurídicas;<br/>
/// ## Guia<br/>
/// O eSocial estabelece a forma com que passam a ser prestadas as informações trabalhistas, previdenciárias, tributárias e fiscais relativas à contratação e utilização de mão de obra onerosa, com ou sem vínculo empregatício, e de produção rural.Portanto, não se trata de uma nova obrigação tributária acessória, mas uma nova forma de cumprir obrigações trabalhistas, previdenciárias e tributárias já existentes.Com isso, ele não altera as legislações específicas de cada área, mas apenas cria uma forma única e mais simplificada de atendê-las.<br/>
/// ## Objetivo<br/>
/// Tem por objetivo desenvolver um sistema de coleta de informações trabalhistas, previdenciárias e tributárias, armazenando-as em um Ambiente Nacional Virtual, a fim de possibilitar aos órgãos participantes do projeto, na medida da pertinência temática de cada um, a utilização de tais informações para fins trabalhistas, previdenciários, fiscais e para a apuração de tributos e da contribuição para o FGTS.<br/>
/// ## Links Úteis<br/>
/// - [Página do Projeto](https://www.gov.br/esocial/pt-br)<br/>
/// - [Manual de Orientação](https://www.gov.br/esocial/pt-br/documentacao-tecnica/manuais/mos-s-1-2-consolidada-ate-a-no-s-1-2-052023-com-marcacoes.pdf)<br/>
/// - [Portal do e-Social](https://login.esocial.gov.br/Login.aspx)<br/>
/// - [Documentação Técnica](https://www.gov.br/esocial/pt-br/documentacao-tecnica/documentacao-tecnica)<br/>
/// - [Layout, v.S-1.2](https://www.gov.br/esocial/pt-br/documentacao-tecnica/leiautes-esocial-v-s-1-2-cons-nt-02-2024-rev-29-02-2024/index.html)<br/>
/// - [Schemas XSD, v.S-1.2](https://www.gov.br/esocial/pt-br/documentacao-tecnica/manuais/2024-01-04_esquemas_xsd_v_s_01_02_00.zip/)<br/>
/// - [Perguntas e Respostas](https://www.gov.br/esocial/pt-br/empresas/perguntas-frequentes/perguntas-frequentes)<br/>
/// ## Implementação<br/>
/// </summary>
internal class NamespaceDoc { }