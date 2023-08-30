﻿namespace EficazFramework.SPED.Schemas.EFD_Reinf;

/// <exclude />
public partial class R2030eR2040InfoRecurso : EfdReinfBindableObject
{
    private TipoRepasseAssocDesp tpRepasseField;
    private string descRecursoField;
    private string vlrBrutoField;
    private string vlrRetApurField;

    /// <remarks/>
    [XmlElement(Order = 0)]
    public TipoRepasseAssocDesp tpRepasse
    {
        get => tpRepasseField;

        set
        {
            tpRepasseField = value;
            RaisePropertyChanged("tpRepasse");
        }
    }

    /// <remarks/>
    [XmlElement(Order = 1)]
    public string descRecurso
    {
        get => descRecursoField;

        set
        {
            descRecursoField = value;
            RaisePropertyChanged("descRecurso");
        }
    }

    /// <remarks/>
    [XmlElement(Order = 2)]
    public string vlrBruto
    {
        get => vlrBrutoField;

        set
        {
            vlrBrutoField = value;
            RaisePropertyChanged("vlrBruto");
        }
    }

    /// <remarks/>
    [XmlElement(Order = 3)]
    public string vlrRetApur
    {
        get => vlrRetApurField;

        set
        {
            vlrRetApurField = value;
            RaisePropertyChanged("vlrRetApur");
        }
    }
}

/// <exclude />
public partial class R2030eR2040ProcessoRelacionado : EfdReinfBindableObject
{
    private TipoProcesso tpProcField;
    private string nrProcField;
    private string codSuspField;
    private string vlrNRetField;

    /// <remarks/>
    [XmlElement(Order = 0)]
    public TipoProcesso tpProc
    {
        get => tpProcField;

        set
        {
            tpProcField = value;
            RaisePropertyChanged("tpProc");
        }
    }

    /// <remarks/>
    [XmlElement(Order = 1)]
    public string nrProc
    {
        get => nrProcField;

        set
        {
            nrProcField = value;
            RaisePropertyChanged("nrProc");
        }
    }

    /// <remarks/>
    [XmlElement(Order = 2)]
    public string codSusp
    {
        get => codSuspField;

        set
        {
            codSuspField = value;
            RaisePropertyChanged("codSusp");
        }
    }

    /// <remarks/>
    [XmlElement(Order = 3)]
    public string vlrNRet
    {
        get => vlrNRetField;

        set
        {
            vlrNRetField = value;
            RaisePropertyChanged("vlrNRet");
        }
    }
}
