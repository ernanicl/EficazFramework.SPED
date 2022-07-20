#### [EficazFramework.SPED](EficazFrameworkSPED.md 'EficazFramework SPED')
### [EficazFramework.SPED.Schemas.EFD_Contribuicoes](EficazFramework.SPED.Schemas.EFD_Contribuicoes.md 'EficazFramework.SPED.Schemas.EFD_Contribuicoes')

## RegistroF560 Class

Consolidação das operações da pj submetida ao retime de tributação com base no lucro presumido - pis e cofins competência - aliquota em reais

### Remarks
### Properties

| # | Name | Type | |
| ---: | :--- | :---: | :--- |
| 02 | VrTotalRecAufCSTAliq | `Nullable<Double>` |  |
| 03 | CSTPis | `String` |  |
| 04 | VrDescontoExclBcCalculoPis | `Nullable<Double>` |  |
| 05 | VrBcPisQtde | `Nullable<Double>` |  |
| 06 | AliqPisQtde | `Nullable<Double>` |  |
| 07 | VrPis | `Nullable<Double>` |  |
| 08 | CSTCofins | `String` |  |
| 09 | VrDescontoExclBcCalculoCofins | `Nullable<Double>` |  |
| 10 | VrBcCofinsQtde | `Nullable<Double>` |  |
| 11 | AliqCofinsQtde | `Nullable<Double>` |  |
| 12 | VrCofins | `Nullable<Double>` |  |
| 13 | CodigoModDocFiscal | `String` |  |
| 14 | CFOP | `String` |  |
| 15 | CodigoContaContabil | `String` |  |
| 16 | InfoComplementar | `String` |  |
### Methods

| Name | Return Type | |
| :--- | :---: | :--- |
| EscreveLinha() | `String` |  |
| LeParametros(string[]) | `Void` |  |