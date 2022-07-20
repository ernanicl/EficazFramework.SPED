#### [EficazFramework.SPED](EficazFrameworkSPED.md 'EficazFramework SPED')
### [EficazFramework.SPED.Schemas.EFD_ICMS_IPI](EficazFramework.SPED.Schemas.EFD_ICMS_IPI.md 'EficazFramework.SPED.Schemas.EFD_ICMS_IPI')

## Registro1010 Class

Obrigatoriedade dos Registros do Bloco 1

### Remarks
### Properties

| # | Name | Type | |
| ---: | :--- | :---: | :--- |
| 02 | AverbacaoExportacao | `Boolean` | Ocorreu averbação (conclusão) de exportação no período? |
| 03 | CreditoICMSControladoSefaz | `Boolean` | Existem informações acerca de créditos de ICMS a serem controlados, definidos pela Sefaz? |
| 04 | ComCombustiveisPeriodo | `Boolean` | É comercio varejista de combustíveis com movimentação e/ou estoque no período? |
| 05 | UsinaAcucarAlcoolPeriodo | `Boolean` | Usinas de açúcar e/álcool – O estabelecimento é produtor de açúcar e/ou álcool carburante com movimentação e/ou estoque no período? |
| 06 | ValoresUF | `Boolean` | Sendo o registro obrigatório em sua Unidade de Federação, existem informações a serem prestadas neste registro? |
| 07 | DistrEnergiaOutraUF | `Boolean` | A empresa é distribuidora de energia e ocorreu fornecimento de energia elétrica para consumidores de outra UF? |
| 08 | VendasCartao | `Boolean` | Realizou vendas com Cartão de Crédito ou de débito? |
| 09 | EmissaoDocFiscalPapel | `Boolean` | Foram emitidos documentos fiscais em papel no período  em unidade da federação que exija o controle de utilização de documentos fiscais? |
| 10 | TransAereo | `Boolean` | A empresa prestou serviços de transporte aéreo de cargas e de passageiros? |
| 11 | GIAF1 | `Boolean` | Reg. 1960 - Possui informações GIAF1? |
| 12 | GIAF3 | `Boolean` | Reg. 1970 - Possui informações GIAF3? |
| 13 | GIAF4 | `Boolean` | Reg. 1980 - Possui informações GIAF4? |
| 14 | RessarcimentoOuComplementoICMS | `Boolean` | Possui informações consolidadas de saldos de restituição, ressarcimento e complementação do ICMS? |
### Methods

| Name | Return Type | |
| :--- | :---: | :--- |
| EscreveLinha() | `String` |  |
| LeParametros(string[]) | `Void` |  |