﻿using EficazFramework.SPED.Extensions;

namespace EficazFramework.SPED.Schemas.EFD_ICMS_IPI
{

    /// <summary>
    /// Encerramento do Bloco H
    /// </summary>
    /// <remarks></remarks>
    public class RegistroH990 : Primitives.Registro
    {
        public RegistroH990() : base("H990")
        {
        }

        public RegistroH990(string linha, string versao) : base(linha, versao)
        {
        }

        public override string EscreveLinha()
        {
            var writer = new System.Text.StringBuilder();
            writer.Append("|H990|"); // 1
            writer.Append(QuantidadeLinhas + "|"); // 2
            return writer.ToString();
        }

        public override void LeParametros(string[] data)
        {
            QuantidadeLinhas = data[2].ToNullableInteger();
        }

        public int? QuantidadeLinhas { get; set; }
    }
}