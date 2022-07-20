#### [EficazFramework.SPED](EficazFrameworkSPED.md 'EficazFramework SPED')
### [EficazFramework.SPED.Schemas.CTe](EficazFramework.SPED.Schemas.CTe.md 'EficazFramework.SPED.Schemas.CTe')

## Evento Class
### Properties

| # | Name | Type | |
| ---: | :--- | :---: | :--- |
| 02 | infEvento | `TEventoInfEvento` |  |
| 03 | Signature | `SignatureType` |  |
| 04 | versao | `String` |  |
| 05 | DocumentType | `XMLDocumentType` |  |
| 06 | DataEmissao | `Nullable<DateTime>` |  |
| 07 | Chave | `String` |  |
### Methods

| Name | Return Type | |
| :--- | :---: | :--- |
| OnPropertyChanged(string) | `Void` |  |
| Serialize() | `String` | Serializes current TEnvEvento object into an XML document |
| SerializeToXMLDocument() | `XDocument` | Semelhante À Function Serialize, porém já retorna o resultado            em uma instância de XmlDocument, agilizando o processo de assinatura            digital dos eventos. |
| CanDeserialize(string, Evento, Exception) | `Boolean` | Deserializes workflow markup into an TEnvEvento object |
| CanDeserialize(string, Evento) | `Boolean` |  |
| Deserialize(string) | `Evento` |  |
| Deserialize(Stream) | `Evento` |  |
| CanSaveTo(Stream, Exception) | `Boolean` | Serializes current TNfeProc object into file |
| SaveTo(Stream) | `Void` |  |
| SaveToAsync(Stream) | `Void` |  |
| CanLoadFrom(Stream, Evento, Exception) | `Boolean` | Deserializes xml markup from file into an TEnvEvento object |
| CanLoadFrom(Stream, Evento) | `Boolean` |  |
| LoadFrom(Stream, bool) | `Evento` |  |
| LoadFromAsync(Stream, bool) | `Task<Evento>` |  |