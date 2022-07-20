#### [EficazFramework.SPED](EficazFrameworkSPED.md 'EficazFramework SPED')
### [EficazFramework.SPED.Schemas.GNRE](EficazFramework.SPED.Schemas.GNRE.md 'EficazFramework.SPED.Schemas.GNRE')

## CabecalhoMensagem Class
### Properties

| # | Name | Type | |
| ---: | :--- | :---: | :--- |
| 02 | versaoDados | `String` |  |
| 03 | RootNamespace | `String` |  |
### Methods

| Name | Return Type | |
| :--- | :---: | :--- |
| Serialize() | `String` | Serializes current TNfeProc object into an XML document |
| CanDeserialize(string, CabecalhoMensagem, Exception) | `Boolean` | Deserializes workflow markup into an TNfeProc object |
| CanDeserialize(string, CabecalhoMensagem) | `Boolean` |  |
| Deserialize(string) | `CabecalhoMensagem` |  |
| Deserialize(Stream) | `CabecalhoMensagem` |  |
| CanSaveToFile(Stream, Exception) | `Boolean` | Serializes current TNfeProc object into file |
| SaveTo(Stream) | `Void` |  |
| SaveToAsync(Stream) | `Void` |  |
| CanLoadFrom(Stream, CabecalhoMensagem, Exception) | `Boolean` | Deserializes xml markup from file into an TNfeProc object |
| CanLoadFrom(Stream, CabecalhoMensagem) | `Boolean` |  |
| LoadFrom(Stream) | `CabecalhoMensagem` |  |
| LoadFromAsync(Stream) | `Task<CabecalhoMensagem>` |  |