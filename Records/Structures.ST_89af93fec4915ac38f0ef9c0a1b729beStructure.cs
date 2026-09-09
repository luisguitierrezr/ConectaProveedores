namespace ssConectaProveedores {
/// <summary>
/// [Structure] CurrentAccountFAC_PAG_OutStruct (rnKTDQjOgEGMF5iIGXLZLw)
///  <code>ST_89af93fec4915ac38f0ef9c0a1b729beStructure</code> that represent
/// s <code>CurrentAccountFAC_PAG_OutStruct</code> <p>Description: </p>
/// </summary>
// Name: CurrentAccountFAC_PAG_OutStruct
public partial struct ST_89af93fec4915ac38f0ef9c0a1b729beStructure : ITypedRecord<ST_89af93fec4915ac38f0ef9c0a1b729beStructure> {
internal static readonly GlobalObjectKey IdKURSF = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*yrhMhBtrZECWSQhPurfP8w");
internal static readonly GlobalObjectKey IdAUGBL = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*oInPWqRZTE691OWrmdhPsA");
internal static readonly GlobalObjectKey IdWRBTR = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*oGYWryx7JEu64QMRKmJUjg");
internal static readonly GlobalObjectKey IdLIFNR = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nHvB4GgW2keHOkgV27kQLg");
internal static readonly GlobalObjectKey IdWRBT2 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Jxwx7xNoE0WlCaER6POIlg");
internal static readonly GlobalObjectKey IdWRBT3 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*A0gpUhWuO0uwIL_KgzM3ew");
internal static readonly GlobalObjectKey IdXBLNR = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*rQi_737jj0ePHlBGhwYPsQ");
internal static readonly GlobalObjectKey IdZUONR = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*rLYFJ17R3USWcQIUg629OQ");
internal static readonly GlobalObjectKey IdZFBDT = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ydJRwSTRZ0+otYlm_M1L4g");
internal static readonly GlobalObjectKey IdZTERM = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mqlpx7zb0UKgTOKArONZUQ");
internal static readonly GlobalObjectKey IdAUGDT = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*9zPTD1HHu0OfyKUj4vgJEA");
internal static readonly GlobalObjectKey IdWAERS = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*lEvQoZlsg0yyMp27w5OSJw");
internal static readonly GlobalObjectKey IdBLART = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*kpnb2k_hX0+O+SeLS3xjOw");
internal static readonly GlobalObjectKey IdZLSCH = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*pJfCqeQm_EKh6mdGhB6vLw");
internal static readonly GlobalObjectKey IdUSNAM = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*uWCOtrLn+kq5Vxiyj2IR7Q");
internal static readonly GlobalObjectKey IdUSRID_LONG = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qxnzVxDbz06Us6dKssBTYA");

public decimal ssKURSF;

public string ssAUGBL;

public decimal ssWRBTR;

public string ssLIFNR;

public decimal ssWRBT2;

public decimal ssWRBT3;

public string ssXBLNR;

public string ssZUONR;

public DateTime ssZFBDT;

public string ssZTERM;

public DateTime ssAUGDT;

public string ssWAERS;

public string ssBLART;

public string ssZLSCH;

public string ssUSNAM;

public string ssUSRID_LONG;


public BitArray OptimizedAttributes;

public ST_89af93fec4915ac38f0ef9c0a1b729beStructure() {
OptimizedAttributes = null;
ssKURSF = 0.0M;
ssAUGBL = "";
ssWRBTR = 0.0M;
ssLIFNR = "";
ssWRBT2 = 0.0M;
ssWRBT3 = 0.0M;
ssXBLNR = "";
ssZUONR = "";
ssZFBDT = (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssZTERM = "";
ssAUGDT = (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssWAERS = "";
ssBLART = "";
ssZLSCH = "";
ssUSNAM = "";
ssUSRID_LONG = "";
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
ssKURSF = r.ReadDecimal(index++, "CurrentAccountFAC_PAG_OutStruct.KURSF", 0.0M);
ssAUGBL = r.ReadText(index++, "CurrentAccountFAC_PAG_OutStruct.AUGBL", "");
ssWRBTR = r.ReadDecimal(index++, "CurrentAccountFAC_PAG_OutStruct.WRBTR", 0.0M);
ssLIFNR = r.ReadText(index++, "CurrentAccountFAC_PAG_OutStruct.LIFNR", "");
ssWRBT2 = r.ReadDecimal(index++, "CurrentAccountFAC_PAG_OutStruct.WRBT2", 0.0M);
ssWRBT3 = r.ReadDecimal(index++, "CurrentAccountFAC_PAG_OutStruct.WRBT3", 0.0M);
ssXBLNR = r.ReadText(index++, "CurrentAccountFAC_PAG_OutStruct.XBLNR", "");
ssZUONR = r.ReadText(index++, "CurrentAccountFAC_PAG_OutStruct.ZUONR", "");
ssZFBDT = r.ReadDate(index++, "CurrentAccountFAC_PAG_OutStruct.ZFBDT", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssZTERM = r.ReadText(index++, "CurrentAccountFAC_PAG_OutStruct.ZTERM", "");
ssAUGDT = r.ReadDate(index++, "CurrentAccountFAC_PAG_OutStruct.AUGDT", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssWAERS = r.ReadText(index++, "CurrentAccountFAC_PAG_OutStruct.WAERS", "");
ssBLART = r.ReadText(index++, "CurrentAccountFAC_PAG_OutStruct.BLART", "");
ssZLSCH = r.ReadText(index++, "CurrentAccountFAC_PAG_OutStruct.ZLSCH", "");
ssUSNAM = r.ReadText(index++, "CurrentAccountFAC_PAG_OutStruct.USNAM", "");
ssUSRID_LONG = r.ReadText(index++, "CurrentAccountFAC_PAG_OutStruct.USRID_LONG", "");
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
public void ReadIM(ST_89af93fec4915ac38f0ef9c0a1b729beStructure r) {
this = r;
}


public static bool operator == (ST_89af93fec4915ac38f0ef9c0a1b729beStructure a, ST_89af93fec4915ac38f0ef9c0a1b729beStructure b) {
if (a.ssKURSF != b.ssKURSF) return false;
if (a.ssAUGBL != b.ssAUGBL) return false;
if (a.ssWRBTR != b.ssWRBTR) return false;
if (a.ssLIFNR != b.ssLIFNR) return false;
if (a.ssWRBT2 != b.ssWRBT2) return false;
if (a.ssWRBT3 != b.ssWRBT3) return false;
if (a.ssXBLNR != b.ssXBLNR) return false;
if (a.ssZUONR != b.ssZUONR) return false;
if (a.ssZFBDT != b.ssZFBDT) return false;
if (a.ssZTERM != b.ssZTERM) return false;
if (a.ssAUGDT != b.ssAUGDT) return false;
if (a.ssWAERS != b.ssWAERS) return false;
if (a.ssBLART != b.ssBLART) return false;
if (a.ssZLSCH != b.ssZLSCH) return false;
if (a.ssUSNAM != b.ssUSNAM) return false;
if (a.ssUSRID_LONG != b.ssUSRID_LONG) return false;
return true;
}

public static bool operator != (ST_89af93fec4915ac38f0ef9c0a1b729beStructure a, ST_89af93fec4915ac38f0ef9c0a1b729beStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_89af93fec4915ac38f0ef9c0a1b729beStructure)) return false;
return (this == (ST_89af93fec4915ac38f0ef9c0a1b729beStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssKURSF.GetHashCode()
 ^ ssAUGBL.GetHashCode()
 ^ ssWRBTR.GetHashCode()
 ^ ssLIFNR.GetHashCode()
 ^ ssWRBT2.GetHashCode()
 ^ ssWRBT3.GetHashCode()
 ^ ssXBLNR.GetHashCode()
 ^ ssZUONR.GetHashCode()
 ^ ssZFBDT.GetHashCode()
 ^ ssZTERM.GetHashCode()
 ^ ssAUGDT.GetHashCode()
 ^ ssWAERS.GetHashCode()
 ^ ssBLART.GetHashCode()
 ^ ssZLSCH.GetHashCode()
 ^ ssUSNAM.GetHashCode()
 ^ ssUSRID_LONG.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_89af93fec4915ac38f0ef9c0a1b729beStructure Duplicate() {
ST_89af93fec4915ac38f0ef9c0a1b729beStructure t;
t.ssKURSF = this.ssKURSF;
t.ssAUGBL = this.ssAUGBL;
t.ssWRBTR = this.ssWRBTR;
t.ssLIFNR = this.ssLIFNR;
t.ssWRBT2 = this.ssWRBT2;
t.ssWRBT3 = this.ssWRBT3;
t.ssXBLNR = this.ssXBLNR;
t.ssZUONR = this.ssZUONR;
t.ssZFBDT = this.ssZFBDT;
t.ssZTERM = this.ssZTERM;
t.ssAUGDT = this.ssAUGDT;
t.ssWAERS = this.ssWAERS;
t.ssBLART = this.ssBLART;
t.ssZLSCH = this.ssZLSCH;
t.ssUSNAM = this.ssUSNAM;
t.ssUSRID_LONG = this.ssUSRID_LONG;
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
if (head == "kursf") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".KURSF")) variable.Value = ssKURSF; else variable.Optimized = true;
} else if (head == "augbl") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AUGBL")) variable.Value = ssAUGBL; else variable.Optimized = true;
} else if (head == "wrbtr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WRBTR")) variable.Value = ssWRBTR; else variable.Optimized = true;
} else if (head == "lifnr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LIFNR")) variable.Value = ssLIFNR; else variable.Optimized = true;
} else if (head == "wrbt2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WRBT2")) variable.Value = ssWRBT2; else variable.Optimized = true;
} else if (head == "wrbt3") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WRBT3")) variable.Value = ssWRBT3; else variable.Optimized = true;
} else if (head == "xblnr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".XBLNR")) variable.Value = ssXBLNR; else variable.Optimized = true;
} else if (head == "zuonr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZUONR")) variable.Value = ssZUONR; else variable.Optimized = true;
} else if (head == "zfbdt") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZFBDT")) variable.Value = ssZFBDT; else variable.Optimized = true;
} else if (head == "zterm") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZTERM")) variable.Value = ssZTERM; else variable.Optimized = true;
} else if (head == "augdt") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AUGDT")) variable.Value = ssAUGDT; else variable.Optimized = true;
} else if (head == "waers") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WAERS")) variable.Value = ssWAERS; else variable.Optimized = true;
} else if (head == "blart") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BLART")) variable.Value = ssBLART; else variable.Optimized = true;
} else if (head == "zlsch") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZLSCH")) variable.Value = ssZLSCH; else variable.Optimized = true;
} else if (head == "usnam") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".USNAM")) variable.Value = ssUSNAM; else variable.Optimized = true;
} else if (head == "usrid_long") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".USRID_LONG")) variable.Value = ssUSRID_LONG; else variable.Optimized = true;
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
if (key == IdKURSF) {
return ssKURSF;
}
if (key == IdAUGBL) {
return ssAUGBL;
}
if (key == IdWRBTR) {
return ssWRBTR;
}
if (key == IdLIFNR) {
return ssLIFNR;
}
if (key == IdWRBT2) {
return ssWRBT2;
}
if (key == IdWRBT3) {
return ssWRBT3;
}
if (key == IdXBLNR) {
return ssXBLNR;
}
if (key == IdZUONR) {
return ssZUONR;
}
if (key == IdZFBDT) {
return ssZFBDT;
}
if (key == IdZTERM) {
return ssZTERM;
}
if (key == IdAUGDT) {
return ssAUGDT;
}
if (key == IdWAERS) {
return ssWAERS;
}
if (key == IdBLART) {
return ssBLART;
}
if (key == IdZLSCH) {
return ssZLSCH;
}
if (key == IdUSNAM) {
return ssUSNAM;
}
if (key == IdUSRID_LONG) {
return ssUSRID_LONG;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdKURSF.Key.AsGuid) {
return ssKURSF;
}
if (attributeKey == IdAUGBL.Key.AsGuid) {
return ssAUGBL;
}
if (attributeKey == IdWRBTR.Key.AsGuid) {
return ssWRBTR;
}
if (attributeKey == IdLIFNR.Key.AsGuid) {
return ssLIFNR;
}
if (attributeKey == IdWRBT2.Key.AsGuid) {
return ssWRBT2;
}
if (attributeKey == IdWRBT3.Key.AsGuid) {
return ssWRBT3;
}
if (attributeKey == IdXBLNR.Key.AsGuid) {
return ssXBLNR;
}
if (attributeKey == IdZUONR.Key.AsGuid) {
return ssZUONR;
}
if (attributeKey == IdZFBDT.Key.AsGuid) {
return ssZFBDT;
}
if (attributeKey == IdZTERM.Key.AsGuid) {
return ssZTERM;
}
if (attributeKey == IdAUGDT.Key.AsGuid) {
return ssAUGDT;
}
if (attributeKey == IdWAERS.Key.AsGuid) {
return ssWAERS;
}
if (attributeKey == IdBLART.Key.AsGuid) {
return ssBLART;
}
if (attributeKey == IdZLSCH.Key.AsGuid) {
return ssZLSCH;
}
if (attributeKey == IdUSNAM.Key.AsGuid) {
return ssUSNAM;
}
if (attributeKey == IdUSRID_LONG.Key.AsGuid) {
return ssUSRID_LONG;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssKURSF = (decimal) other.AttributeGet(IdKURSF);
ssAUGBL = (string) other.AttributeGet(IdAUGBL);
ssWRBTR = (decimal) other.AttributeGet(IdWRBTR);
ssLIFNR = (string) other.AttributeGet(IdLIFNR);
ssWRBT2 = (decimal) other.AttributeGet(IdWRBT2);
ssWRBT3 = (decimal) other.AttributeGet(IdWRBT3);
ssXBLNR = (string) other.AttributeGet(IdXBLNR);
ssZUONR = (string) other.AttributeGet(IdZUONR);
ssZFBDT = (DateTime) other.AttributeGet(IdZFBDT);
ssZTERM = (string) other.AttributeGet(IdZTERM);
ssAUGDT = (DateTime) other.AttributeGet(IdAUGDT);
ssWAERS = (string) other.AttributeGet(IdWAERS);
ssBLART = (string) other.AttributeGet(IdBLART);
ssZLSCH = (string) other.AttributeGet(IdZLSCH);
ssUSNAM = (string) other.AttributeGet(IdUSNAM);
ssUSRID_LONG = (string) other.AttributeGet(IdUSRID_LONG);
}
} // ST_89af93fec4915ac38f0ef9c0a1b729beStructure
/// <summary>
/// RecordList type <code>CurrentAccountFAC_PAG_OutStructList</code> that represents a record list of
///  <code>CurrentAccountFAC_PAG_OutStruct</code>
/// </summary>
public partial class RL_cdf1999ec7b32c2eb5fd2f2dd542197b : GenericRecordList<ST_89af93fec4915ac38f0ef9c0a1b729beStructure>, IEnumerable, IEnumerator {

protected override ST_89af93fec4915ac38f0ef9c0a1b729beStructure GetElementDefaultValue() {
return new ST_89af93fec4915ac38f0ef9c0a1b729beStructure();
}

public T[] ToArray<T>(Func<ST_89af93fec4915ac38f0ef9c0a1b729beStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cdf1999ec7b32c2eb5fd2f2dd542197b recordList, Func<ST_89af93fec4915ac38f0ef9c0a1b729beStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cdf1999ec7b32c2eb5fd2f2dd542197b(ST_89af93fec4915ac38f0ef9c0a1b729beStructure[] array) {
  RL_cdf1999ec7b32c2eb5fd2f2dd542197b result = new RL_cdf1999ec7b32c2eb5fd2f2dd542197b();
result.InnerFromArray(array);
    return result;
}

public static RL_cdf1999ec7b32c2eb5fd2f2dd542197b ToList<T>(T[] array, Func <T, ST_89af93fec4915ac38f0ef9c0a1b729beStructure> converter) {
  RL_cdf1999ec7b32c2eb5fd2f2dd542197b result = new RL_cdf1999ec7b32c2eb5fd2f2dd542197b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cdf1999ec7b32c2eb5fd2f2dd542197b FromRestList<T>(RestList<T> restList, Func <T, ST_89af93fec4915ac38f0ef9c0a1b729beStructure> converter) {
  RL_cdf1999ec7b32c2eb5fd2f2dd542197b result = new RL_cdf1999ec7b32c2eb5fd2f2dd542197b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cdf1999ec7b32c2eb5fd2f2dd542197b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_89af93fec4915ac38f0ef9c0a1b729beStructure> NewList() {
return new RL_cdf1999ec7b32c2eb5fd2f2dd542197b();
}


} // RL_cdf1999ec7b32c2eb5fd2f2dd542197b
}

