namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] PI_HEADER (0TIJn8+Lnkia2tRLs8qnbg)
///  <code>ST_f4885e4f480f4a52f6c05031eda6ef37Structure</code> that represents <code>PI_HEADER</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_HEADER
public partial struct ST_f4885e4f480f4a52f6c05031eda6ef37Structure : ITypedRecord<ST_f4885e4f480f4a52f6c05031eda6ef37Structure> {
internal static readonly GlobalObjectKey IdINVOICE_IND = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*GOkKWAnGokCHC9pnnJb0SA");
internal static readonly GlobalObjectKey IdDOC_TYPE = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*zqSpeqKoA0CIHt_gfZhFMQ");
internal static readonly GlobalObjectKey IdDOC_DATE = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*Fl6duH_ZzESpT_Y_taIO2g");
internal static readonly GlobalObjectKey IdPSTNG_DATE = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*eaoWgazIeEWLdjD_IHmJXg");
internal static readonly GlobalObjectKey IdREF_DOC_NO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*+cauX+Tz+UmDuljU4hEixg");
internal static readonly GlobalObjectKey IdCOMP_CODE = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*k4_JaIUW90CRM8gvbesxVA");
internal static readonly GlobalObjectKey IdGROSS_AMOUNT = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*Z8jz33ECx0aSW6BqyTl57Q");
internal static readonly GlobalObjectKey IdCALC_TAX_IND = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*I2D5ab+XrEqimtD1H0D2Dg");
internal static readonly GlobalObjectKey IdPMNTTRMS = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*F81HVh4TaUaSUfpiAt+qGA");
internal static readonly GlobalObjectKey IdBLINE_DATE = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*q5JiOn59ikeN9REWedOUJw");
internal static readonly GlobalObjectKey IdHEADER_TXT = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*lVJVCfOzuEelJuD534zuEg");
internal static readonly GlobalObjectKey IdALLOC_NMBR = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*UVYp7qHhWEOLPnQbcwXyog");
internal static readonly GlobalObjectKey IdBUS_AREA = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*n_Z0iB0ygk2n1AacSPqYyg");
internal static readonly GlobalObjectKey IdITEM_TEXT = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*lroWm+4xDkKFpX3eElLt+w");
internal static readonly GlobalObjectKey IdCURRENCY = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*NY7wZ89B60qpgK0bsTC2SQ");
internal static readonly GlobalObjectKey IdDEL_COSTS_TAXC = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*+ysdSJGP6k2H0pvTt8_zbA");
internal static readonly GlobalObjectKey IdPYMT_METH = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*Kej5iGrNFU6wQXsKewF7ww");
internal static readonly GlobalObjectKey IdEXCH_RATE = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*qz_dtcIAtkuONOEkfSPU_g");

public string ssINVOICE_IND;

public string ssDOC_TYPE;

public DateTime ssDOC_DATE;

public DateTime ssPSTNG_DATE;

public string ssREF_DOC_NO;

public string ssCOMP_CODE;

public decimal ssGROSS_AMOUNT;

public string ssCALC_TAX_IND;

public string ssPMNTTRMS;

public DateTime ssBLINE_DATE;

public string ssHEADER_TXT;

public string ssALLOC_NMBR;

public string ssBUS_AREA;

public string ssITEM_TEXT;

public string ssCURRENCY;

public string ssDEL_COSTS_TAXC;

public string ssPYMT_METH;

public decimal ssEXCH_RATE;


public BitArray OptimizedAttributes;

public ST_f4885e4f480f4a52f6c05031eda6ef37Structure() {
OptimizedAttributes = null;
ssINVOICE_IND = "";
ssDOC_TYPE = "";
ssDOC_DATE = (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssPSTNG_DATE = (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssREF_DOC_NO = "";
ssCOMP_CODE = "";
ssGROSS_AMOUNT = -79228162514264337593543950335m;
ssCALC_TAX_IND = "";
ssPMNTTRMS = "";
ssBLINE_DATE = (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssHEADER_TXT = "";
ssALLOC_NMBR = "";
ssBUS_AREA = "";
ssITEM_TEXT = "";
ssCURRENCY = "";
ssDEL_COSTS_TAXC = "";
ssPYMT_METH = "";
ssEXCH_RATE = -79228162514264337593543950335m;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssINVOICE_IND = r.ReadText(index++, "PI_HEADER.INVOICE_IND", "");
ssDOC_TYPE = r.ReadText(index++, "PI_HEADER.DOC_TYPE", "");
ssDOC_DATE = r.ReadDate(index++, "PI_HEADER.DOC_DATE", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssPSTNG_DATE = r.ReadDate(index++, "PI_HEADER.PSTNG_DATE", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssREF_DOC_NO = r.ReadText(index++, "PI_HEADER.REF_DOC_NO", "");
ssCOMP_CODE = r.ReadText(index++, "PI_HEADER.COMP_CODE", "");
ssGROSS_AMOUNT = r.ReadDecimal(index++, "PI_HEADER.GROSS_AMOUNT", 0.0M);
ssCALC_TAX_IND = r.ReadText(index++, "PI_HEADER.CALC_TAX_IND", "");
ssPMNTTRMS = r.ReadText(index++, "PI_HEADER.PMNTTRMS", "");
ssBLINE_DATE = r.ReadDate(index++, "PI_HEADER.BLINE_DATE", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssHEADER_TXT = r.ReadText(index++, "PI_HEADER.HEADER_TXT", "");
ssALLOC_NMBR = r.ReadText(index++, "PI_HEADER.ALLOC_NMBR", "");
ssBUS_AREA = r.ReadText(index++, "PI_HEADER.BUS_AREA", "");
ssITEM_TEXT = r.ReadText(index++, "PI_HEADER.ITEM_TEXT", "");
ssCURRENCY = r.ReadText(index++, "PI_HEADER.CURRENCY", "");
ssDEL_COSTS_TAXC = r.ReadText(index++, "PI_HEADER.DEL_COSTS_TAXC", "");
ssPYMT_METH = r.ReadText(index++, "PI_HEADER.PYMT_METH", "");
ssEXCH_RATE = r.ReadDecimal(index++, "PI_HEADER.EXCH_RATE", 0.0M);
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_f4885e4f480f4a52f6c05031eda6ef37Structure r) {
this = r;
}


public static bool operator == (ST_f4885e4f480f4a52f6c05031eda6ef37Structure a, ST_f4885e4f480f4a52f6c05031eda6ef37Structure b) {
if (a.ssINVOICE_IND != b.ssINVOICE_IND) return false;
if (a.ssDOC_TYPE != b.ssDOC_TYPE) return false;
if (a.ssDOC_DATE != b.ssDOC_DATE) return false;
if (a.ssPSTNG_DATE != b.ssPSTNG_DATE) return false;
if (a.ssREF_DOC_NO != b.ssREF_DOC_NO) return false;
if (a.ssCOMP_CODE != b.ssCOMP_CODE) return false;
if (a.ssGROSS_AMOUNT != b.ssGROSS_AMOUNT) return false;
if (a.ssCALC_TAX_IND != b.ssCALC_TAX_IND) return false;
if (a.ssPMNTTRMS != b.ssPMNTTRMS) return false;
if (a.ssBLINE_DATE != b.ssBLINE_DATE) return false;
if (a.ssHEADER_TXT != b.ssHEADER_TXT) return false;
if (a.ssALLOC_NMBR != b.ssALLOC_NMBR) return false;
if (a.ssBUS_AREA != b.ssBUS_AREA) return false;
if (a.ssITEM_TEXT != b.ssITEM_TEXT) return false;
if (a.ssCURRENCY != b.ssCURRENCY) return false;
if (a.ssDEL_COSTS_TAXC != b.ssDEL_COSTS_TAXC) return false;
if (a.ssPYMT_METH != b.ssPYMT_METH) return false;
if (a.ssEXCH_RATE != b.ssEXCH_RATE) return false;
return true;
}

public static bool operator != (ST_f4885e4f480f4a52f6c05031eda6ef37Structure a, ST_f4885e4f480f4a52f6c05031eda6ef37Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_f4885e4f480f4a52f6c05031eda6ef37Structure)) return false;
return (this == (ST_f4885e4f480f4a52f6c05031eda6ef37Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssINVOICE_IND.GetHashCode()
 ^ ssDOC_TYPE.GetHashCode()
 ^ ssDOC_DATE.GetHashCode()
 ^ ssPSTNG_DATE.GetHashCode()
 ^ ssREF_DOC_NO.GetHashCode()
 ^ ssCOMP_CODE.GetHashCode()
 ^ ssGROSS_AMOUNT.GetHashCode()
 ^ ssCALC_TAX_IND.GetHashCode()
 ^ ssPMNTTRMS.GetHashCode()
 ^ ssBLINE_DATE.GetHashCode()
 ^ ssHEADER_TXT.GetHashCode()
 ^ ssALLOC_NMBR.GetHashCode()
 ^ ssBUS_AREA.GetHashCode()
 ^ ssITEM_TEXT.GetHashCode()
 ^ ssCURRENCY.GetHashCode()
 ^ ssDEL_COSTS_TAXC.GetHashCode()
 ^ ssPYMT_METH.GetHashCode()
 ^ ssEXCH_RATE.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_f4885e4f480f4a52f6c05031eda6ef37Structure Duplicate() {
ST_f4885e4f480f4a52f6c05031eda6ef37Structure t;
t.ssINVOICE_IND = this.ssINVOICE_IND;
t.ssDOC_TYPE = this.ssDOC_TYPE;
t.ssDOC_DATE = this.ssDOC_DATE;
t.ssPSTNG_DATE = this.ssPSTNG_DATE;
t.ssREF_DOC_NO = this.ssREF_DOC_NO;
t.ssCOMP_CODE = this.ssCOMP_CODE;
t.ssGROSS_AMOUNT = this.ssGROSS_AMOUNT;
t.ssCALC_TAX_IND = this.ssCALC_TAX_IND;
t.ssPMNTTRMS = this.ssPMNTTRMS;
t.ssBLINE_DATE = this.ssBLINE_DATE;
t.ssHEADER_TXT = this.ssHEADER_TXT;
t.ssALLOC_NMBR = this.ssALLOC_NMBR;
t.ssBUS_AREA = this.ssBUS_AREA;
t.ssITEM_TEXT = this.ssITEM_TEXT;
t.ssCURRENCY = this.ssCURRENCY;
t.ssDEL_COSTS_TAXC = this.ssDEL_COSTS_TAXC;
t.ssPYMT_METH = this.ssPYMT_METH;
t.ssEXCH_RATE = this.ssEXCH_RATE;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "invoice_ind") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".INVOICE_IND")) variable.Value = ssINVOICE_IND; else variable.Optimized = true;
} else if (head == "doc_type") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DOC_TYPE")) variable.Value = ssDOC_TYPE; else variable.Optimized = true;
} else if (head == "doc_date") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DOC_DATE")) variable.Value = ssDOC_DATE; else variable.Optimized = true;
} else if (head == "pstng_date") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PSTNG_DATE")) variable.Value = ssPSTNG_DATE; else variable.Optimized = true;
} else if (head == "ref_doc_no") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".REF_DOC_NO")) variable.Value = ssREF_DOC_NO; else variable.Optimized = true;
} else if (head == "comp_code") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".COMP_CODE")) variable.Value = ssCOMP_CODE; else variable.Optimized = true;
} else if (head == "gross_amount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".GROSS_AMOUNT")) variable.Value = ssGROSS_AMOUNT; else variable.Optimized = true;
} else if (head == "calc_tax_ind") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CALC_TAX_IND")) variable.Value = ssCALC_TAX_IND; else variable.Optimized = true;
} else if (head == "pmnttrms") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PMNTTRMS")) variable.Value = ssPMNTTRMS; else variable.Optimized = true;
} else if (head == "bline_date") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BLINE_DATE")) variable.Value = ssBLINE_DATE; else variable.Optimized = true;
} else if (head == "header_txt") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HEADER_TXT")) variable.Value = ssHEADER_TXT; else variable.Optimized = true;
} else if (head == "alloc_nmbr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ALLOC_NMBR")) variable.Value = ssALLOC_NMBR; else variable.Optimized = true;
} else if (head == "bus_area") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BUS_AREA")) variable.Value = ssBUS_AREA; else variable.Optimized = true;
} else if (head == "item_text") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ITEM_TEXT")) variable.Value = ssITEM_TEXT; else variable.Optimized = true;
} else if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CURRENCY")) variable.Value = ssCURRENCY; else variable.Optimized = true;
} else if (head == "del_costs_taxc") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DEL_COSTS_TAXC")) variable.Value = ssDEL_COSTS_TAXC; else variable.Optimized = true;
} else if (head == "pymt_meth") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PYMT_METH")) variable.Value = ssPYMT_METH; else variable.Optimized = true;
} else if (head == "exch_rate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EXCH_RATE")) variable.Value = ssEXCH_RATE; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdINVOICE_IND) {
return ssINVOICE_IND;
}
if (key == IdDOC_TYPE) {
return ssDOC_TYPE;
}
if (key == IdDOC_DATE) {
return ssDOC_DATE;
}
if (key == IdPSTNG_DATE) {
return ssPSTNG_DATE;
}
if (key == IdREF_DOC_NO) {
return ssREF_DOC_NO;
}
if (key == IdCOMP_CODE) {
return ssCOMP_CODE;
}
if (key == IdGROSS_AMOUNT) {
return ssGROSS_AMOUNT;
}
if (key == IdCALC_TAX_IND) {
return ssCALC_TAX_IND;
}
if (key == IdPMNTTRMS) {
return ssPMNTTRMS;
}
if (key == IdBLINE_DATE) {
return ssBLINE_DATE;
}
if (key == IdHEADER_TXT) {
return ssHEADER_TXT;
}
if (key == IdALLOC_NMBR) {
return ssALLOC_NMBR;
}
if (key == IdBUS_AREA) {
return ssBUS_AREA;
}
if (key == IdITEM_TEXT) {
return ssITEM_TEXT;
}
if (key == IdCURRENCY) {
return ssCURRENCY;
}
if (key == IdDEL_COSTS_TAXC) {
return ssDEL_COSTS_TAXC;
}
if (key == IdPYMT_METH) {
return ssPYMT_METH;
}
if (key == IdEXCH_RATE) {
return ssEXCH_RATE;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdINVOICE_IND.Key.AsGuid) {
return ssINVOICE_IND;
}
if (attributeKey == IdDOC_TYPE.Key.AsGuid) {
return ssDOC_TYPE;
}
if (attributeKey == IdDOC_DATE.Key.AsGuid) {
return ssDOC_DATE;
}
if (attributeKey == IdPSTNG_DATE.Key.AsGuid) {
return ssPSTNG_DATE;
}
if (attributeKey == IdREF_DOC_NO.Key.AsGuid) {
return ssREF_DOC_NO;
}
if (attributeKey == IdCOMP_CODE.Key.AsGuid) {
return ssCOMP_CODE;
}
if (attributeKey == IdGROSS_AMOUNT.Key.AsGuid) {
return ssGROSS_AMOUNT;
}
if (attributeKey == IdCALC_TAX_IND.Key.AsGuid) {
return ssCALC_TAX_IND;
}
if (attributeKey == IdPMNTTRMS.Key.AsGuid) {
return ssPMNTTRMS;
}
if (attributeKey == IdBLINE_DATE.Key.AsGuid) {
return ssBLINE_DATE;
}
if (attributeKey == IdHEADER_TXT.Key.AsGuid) {
return ssHEADER_TXT;
}
if (attributeKey == IdALLOC_NMBR.Key.AsGuid) {
return ssALLOC_NMBR;
}
if (attributeKey == IdBUS_AREA.Key.AsGuid) {
return ssBUS_AREA;
}
if (attributeKey == IdITEM_TEXT.Key.AsGuid) {
return ssITEM_TEXT;
}
if (attributeKey == IdCURRENCY.Key.AsGuid) {
return ssCURRENCY;
}
if (attributeKey == IdDEL_COSTS_TAXC.Key.AsGuid) {
return ssDEL_COSTS_TAXC;
}
if (attributeKey == IdPYMT_METH.Key.AsGuid) {
return ssPYMT_METH;
}
if (attributeKey == IdEXCH_RATE.Key.AsGuid) {
return ssEXCH_RATE;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssINVOICE_IND = (string) other.AttributeGet(IdINVOICE_IND);
ssDOC_TYPE = (string) other.AttributeGet(IdDOC_TYPE);
ssDOC_DATE = (DateTime) other.AttributeGet(IdDOC_DATE);
ssPSTNG_DATE = (DateTime) other.AttributeGet(IdPSTNG_DATE);
ssREF_DOC_NO = (string) other.AttributeGet(IdREF_DOC_NO);
ssCOMP_CODE = (string) other.AttributeGet(IdCOMP_CODE);
ssGROSS_AMOUNT = (decimal) other.AttributeGet(IdGROSS_AMOUNT);
ssCALC_TAX_IND = (string) other.AttributeGet(IdCALC_TAX_IND);
ssPMNTTRMS = (string) other.AttributeGet(IdPMNTTRMS);
ssBLINE_DATE = (DateTime) other.AttributeGet(IdBLINE_DATE);
ssHEADER_TXT = (string) other.AttributeGet(IdHEADER_TXT);
ssALLOC_NMBR = (string) other.AttributeGet(IdALLOC_NMBR);
ssBUS_AREA = (string) other.AttributeGet(IdBUS_AREA);
ssITEM_TEXT = (string) other.AttributeGet(IdITEM_TEXT);
ssCURRENCY = (string) other.AttributeGet(IdCURRENCY);
ssDEL_COSTS_TAXC = (string) other.AttributeGet(IdDEL_COSTS_TAXC);
ssPYMT_METH = (string) other.AttributeGet(IdPYMT_METH);
ssEXCH_RATE = (decimal) other.AttributeGet(IdEXCH_RATE);
}
} // ST_f4885e4f480f4a52f6c05031eda6ef37Structure
/// <summary>
/// RecordList type <code>PI_HEADERList</code> that represents a record list of <code>PI_HEADER</code>
/// </summary>
public partial class RL_636786842277ab19653d556af7ad50a5 : GenericRecordList<ST_f4885e4f480f4a52f6c05031eda6ef37Structure>, IEnumerable, IEnumerator {

protected override ST_f4885e4f480f4a52f6c05031eda6ef37Structure GetElementDefaultValue() {
return new ST_f4885e4f480f4a52f6c05031eda6ef37Structure();
}

public T[] ToArray<T>(Func<ST_f4885e4f480f4a52f6c05031eda6ef37Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_636786842277ab19653d556af7ad50a5 recordList, Func<ST_f4885e4f480f4a52f6c05031eda6ef37Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_636786842277ab19653d556af7ad50a5(ST_f4885e4f480f4a52f6c05031eda6ef37Structure[] array) {
  RL_636786842277ab19653d556af7ad50a5 result = new RL_636786842277ab19653d556af7ad50a5();
result.InnerFromArray(array);
    return result;
}

public static RL_636786842277ab19653d556af7ad50a5 ToList<T>(T[] array, Func <T, ST_f4885e4f480f4a52f6c05031eda6ef37Structure> converter) {
  RL_636786842277ab19653d556af7ad50a5 result = new RL_636786842277ab19653d556af7ad50a5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_636786842277ab19653d556af7ad50a5 FromRestList<T>(RestList<T> restList, Func <T, ST_f4885e4f480f4a52f6c05031eda6ef37Structure> converter) {
  RL_636786842277ab19653d556af7ad50a5 result = new RL_636786842277ab19653d556af7ad50a5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_636786842277ab19653d556af7ad50a5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_f4885e4f480f4a52f6c05031eda6ef37Structure> NewList() {
return new RL_636786842277ab19653d556af7ad50a5();
}


} // RL_636786842277ab19653d556af7ad50a5
}

