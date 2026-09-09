namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] T_FACT_PEN_PAG_In (kqdOevIJd0eTKfhvfoZfZA)
///  <code>ST_0310bb62d750573571d23e0cd61c55b3Structure</code> that represent
/// s <code>T_FACT_PEN_PAG_In</code> <p>Description: </p>
/// </summary>
// Name: T_FACT_PEN_PAG_In
public partial struct ST_0310bb62d750573571d23e0cd61c55b3Structure : ITypedRecord<ST_0310bb62d750573571d23e0cd61c55b3Structure> {
internal static readonly GlobalObjectKey IdXBLNR = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*GdfYnv9xukOvAD1uEuNuSw");
internal static readonly GlobalObjectKey IdZUONR = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*6XaTBy6_vUOUJ2ZjtmGvWw");
internal static readonly GlobalObjectKey IdZFBDT = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*5EonhuJGKUyYxfPUHM67Bg");
internal static readonly GlobalObjectKey IdZTERM = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*7_Elvovg4k2mctEip0exAA");
internal static readonly GlobalObjectKey IdAUGDT = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*scJ0RPpHAU+Kgyl_7JYr1w");
internal static readonly GlobalObjectKey IdWRBTR = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*5NedIkTLlUa6dNdENZ+PsA");
internal static readonly GlobalObjectKey IdWAERS = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*5tmUSBF2R0+e0oyhCVUuQw");
internal static readonly GlobalObjectKey IdWRBT2 = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*CeYG07FCOk6_aJ9f53oZ_A");
internal static readonly GlobalObjectKey IdWRBT3 = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*5_2Urt2mRke_Rgp6hgpeMw");
internal static readonly GlobalObjectKey IdUMSKZ = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*jXjwE6VZUUGX_BnyG9EnTQ");
internal static readonly GlobalObjectKey IdBLART = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*lpRyOPUKyU2pVi_82ZmF5Q");
internal static readonly GlobalObjectKey IdZLSCH = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*dB0EOVyIAUOVI5XMiLBRmA");
internal static readonly GlobalObjectKey IdKURSF = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*Wt5A6tjsF0Oeds5g0rd4TA");
internal static readonly GlobalObjectKey IdUSNAM = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*mu++WIrf2UiKrwyTS70KbA");
internal static readonly GlobalObjectKey IdUSRID_LONG = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*JL2L3sVTQkSw3t87htArsA");

public string ssXBLNR;

public string ssZUONR;

public DateTime ssZFBDT;

public string ssZTERM;

public DateTime ssAUGDT;

public decimal ssWRBTR;

public string ssWAERS;

public decimal ssWRBT2;

public decimal ssWRBT3;

public string ssUMSKZ;

public string ssBLART;

public string ssZLSCH;

public decimal ssKURSF;

public string ssUSNAM;

public string ssUSRID_LONG;


public BitArray OptimizedAttributes;

public ST_0310bb62d750573571d23e0cd61c55b3Structure() {
OptimizedAttributes = null;
ssXBLNR = "";
ssZUONR = "";
ssZFBDT = (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssZTERM = "";
ssAUGDT = (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssWRBTR = -79228162514264337593543950335m;
ssWAERS = "";
ssWRBT2 = -79228162514264337593543950335m;
ssWRBT3 = -79228162514264337593543950335m;
ssUMSKZ = "";
ssBLART = "";
ssZLSCH = "";
ssKURSF = -79228162514264337593543950335m;
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
ssXBLNR = r.ReadText(index++, "T_FACT_PEN_PAG_In.XBLNR", "");
ssZUONR = r.ReadText(index++, "T_FACT_PEN_PAG_In.ZUONR", "");
ssZFBDT = r.ReadDate(index++, "T_FACT_PEN_PAG_In.ZFBDT", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssZTERM = r.ReadText(index++, "T_FACT_PEN_PAG_In.ZTERM", "");
ssAUGDT = r.ReadDate(index++, "T_FACT_PEN_PAG_In.AUGDT", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssWRBTR = r.ReadDecimal(index++, "T_FACT_PEN_PAG_In.WRBTR", 0.0M);
ssWAERS = r.ReadText(index++, "T_FACT_PEN_PAG_In.WAERS", "");
ssWRBT2 = r.ReadDecimal(index++, "T_FACT_PEN_PAG_In.WRBT2", 0.0M);
ssWRBT3 = r.ReadDecimal(index++, "T_FACT_PEN_PAG_In.WRBT3", 0.0M);
ssUMSKZ = r.ReadText(index++, "T_FACT_PEN_PAG_In.UMSKZ", "");
ssBLART = r.ReadText(index++, "T_FACT_PEN_PAG_In.BLART", "");
ssZLSCH = r.ReadText(index++, "T_FACT_PEN_PAG_In.ZLSCH", "");
ssKURSF = r.ReadDecimal(index++, "T_FACT_PEN_PAG_In.KURSF", 0.0M);
ssUSNAM = r.ReadText(index++, "T_FACT_PEN_PAG_In.USNAM", "");
ssUSRID_LONG = r.ReadText(index++, "T_FACT_PEN_PAG_In.USRID_LONG", "");
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
public void ReadIM(ST_0310bb62d750573571d23e0cd61c55b3Structure r) {
this = r;
}


public static bool operator == (ST_0310bb62d750573571d23e0cd61c55b3Structure a, ST_0310bb62d750573571d23e0cd61c55b3Structure b) {
if (a.ssXBLNR != b.ssXBLNR) return false;
if (a.ssZUONR != b.ssZUONR) return false;
if (a.ssZFBDT != b.ssZFBDT) return false;
if (a.ssZTERM != b.ssZTERM) return false;
if (a.ssAUGDT != b.ssAUGDT) return false;
if (a.ssWRBTR != b.ssWRBTR) return false;
if (a.ssWAERS != b.ssWAERS) return false;
if (a.ssWRBT2 != b.ssWRBT2) return false;
if (a.ssWRBT3 != b.ssWRBT3) return false;
if (a.ssUMSKZ != b.ssUMSKZ) return false;
if (a.ssBLART != b.ssBLART) return false;
if (a.ssZLSCH != b.ssZLSCH) return false;
if (a.ssKURSF != b.ssKURSF) return false;
if (a.ssUSNAM != b.ssUSNAM) return false;
if (a.ssUSRID_LONG != b.ssUSRID_LONG) return false;
return true;
}

public static bool operator != (ST_0310bb62d750573571d23e0cd61c55b3Structure a, ST_0310bb62d750573571d23e0cd61c55b3Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_0310bb62d750573571d23e0cd61c55b3Structure)) return false;
return (this == (ST_0310bb62d750573571d23e0cd61c55b3Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssXBLNR.GetHashCode()
 ^ ssZUONR.GetHashCode()
 ^ ssZFBDT.GetHashCode()
 ^ ssZTERM.GetHashCode()
 ^ ssAUGDT.GetHashCode()
 ^ ssWRBTR.GetHashCode()
 ^ ssWAERS.GetHashCode()
 ^ ssWRBT2.GetHashCode()
 ^ ssWRBT3.GetHashCode()
 ^ ssUMSKZ.GetHashCode()
 ^ ssBLART.GetHashCode()
 ^ ssZLSCH.GetHashCode()
 ^ ssKURSF.GetHashCode()
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


public ST_0310bb62d750573571d23e0cd61c55b3Structure Duplicate() {
ST_0310bb62d750573571d23e0cd61c55b3Structure t;
t.ssXBLNR = this.ssXBLNR;
t.ssZUONR = this.ssZUONR;
t.ssZFBDT = this.ssZFBDT;
t.ssZTERM = this.ssZTERM;
t.ssAUGDT = this.ssAUGDT;
t.ssWRBTR = this.ssWRBTR;
t.ssWAERS = this.ssWAERS;
t.ssWRBT2 = this.ssWRBT2;
t.ssWRBT3 = this.ssWRBT3;
t.ssUMSKZ = this.ssUMSKZ;
t.ssBLART = this.ssBLART;
t.ssZLSCH = this.ssZLSCH;
t.ssKURSF = this.ssKURSF;
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
if (head == "xblnr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".XBLNR")) variable.Value = ssXBLNR; else variable.Optimized = true;
} else if (head == "zuonr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZUONR")) variable.Value = ssZUONR; else variable.Optimized = true;
} else if (head == "zfbdt") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZFBDT")) variable.Value = ssZFBDT; else variable.Optimized = true;
} else if (head == "zterm") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZTERM")) variable.Value = ssZTERM; else variable.Optimized = true;
} else if (head == "augdt") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AUGDT")) variable.Value = ssAUGDT; else variable.Optimized = true;
} else if (head == "wrbtr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WRBTR")) variable.Value = ssWRBTR; else variable.Optimized = true;
} else if (head == "waers") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WAERS")) variable.Value = ssWAERS; else variable.Optimized = true;
} else if (head == "wrbt2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WRBT2")) variable.Value = ssWRBT2; else variable.Optimized = true;
} else if (head == "wrbt3") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WRBT3")) variable.Value = ssWRBT3; else variable.Optimized = true;
} else if (head == "umskz") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UMSKZ")) variable.Value = ssUMSKZ; else variable.Optimized = true;
} else if (head == "blart") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BLART")) variable.Value = ssBLART; else variable.Optimized = true;
} else if (head == "zlsch") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZLSCH")) variable.Value = ssZLSCH; else variable.Optimized = true;
} else if (head == "kursf") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".KURSF")) variable.Value = ssKURSF; else variable.Optimized = true;
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
if (key == IdWRBTR) {
return ssWRBTR;
}
if (key == IdWAERS) {
return ssWAERS;
}
if (key == IdWRBT2) {
return ssWRBT2;
}
if (key == IdWRBT3) {
return ssWRBT3;
}
if (key == IdUMSKZ) {
return ssUMSKZ;
}
if (key == IdBLART) {
return ssBLART;
}
if (key == IdZLSCH) {
return ssZLSCH;
}
if (key == IdKURSF) {
return ssKURSF;
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
if (attributeKey == IdWRBTR.Key.AsGuid) {
return ssWRBTR;
}
if (attributeKey == IdWAERS.Key.AsGuid) {
return ssWAERS;
}
if (attributeKey == IdWRBT2.Key.AsGuid) {
return ssWRBT2;
}
if (attributeKey == IdWRBT3.Key.AsGuid) {
return ssWRBT3;
}
if (attributeKey == IdUMSKZ.Key.AsGuid) {
return ssUMSKZ;
}
if (attributeKey == IdBLART.Key.AsGuid) {
return ssBLART;
}
if (attributeKey == IdZLSCH.Key.AsGuid) {
return ssZLSCH;
}
if (attributeKey == IdKURSF.Key.AsGuid) {
return ssKURSF;
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
ssXBLNR = (string) other.AttributeGet(IdXBLNR);
ssZUONR = (string) other.AttributeGet(IdZUONR);
ssZFBDT = (DateTime) other.AttributeGet(IdZFBDT);
ssZTERM = (string) other.AttributeGet(IdZTERM);
ssAUGDT = (DateTime) other.AttributeGet(IdAUGDT);
ssWRBTR = (decimal) other.AttributeGet(IdWRBTR);
ssWAERS = (string) other.AttributeGet(IdWAERS);
ssWRBT2 = (decimal) other.AttributeGet(IdWRBT2);
ssWRBT3 = (decimal) other.AttributeGet(IdWRBT3);
ssUMSKZ = (string) other.AttributeGet(IdUMSKZ);
ssBLART = (string) other.AttributeGet(IdBLART);
ssZLSCH = (string) other.AttributeGet(IdZLSCH);
ssKURSF = (decimal) other.AttributeGet(IdKURSF);
ssUSNAM = (string) other.AttributeGet(IdUSNAM);
ssUSRID_LONG = (string) other.AttributeGet(IdUSRID_LONG);
}
} // ST_0310bb62d750573571d23e0cd61c55b3Structure
/// <summary>
/// RecordList type <code>T_FACT_PEN_PAG_InList</code> that represents a record list of
///  <code>T_FACT_PEN_PAG_In</code>
/// </summary>
public partial class RL_544a92ac2b1a23d422d8e47df2b48a91 : GenericRecordList<ST_0310bb62d750573571d23e0cd61c55b3Structure>, IEnumerable, IEnumerator {

protected override ST_0310bb62d750573571d23e0cd61c55b3Structure GetElementDefaultValue() {
return new ST_0310bb62d750573571d23e0cd61c55b3Structure();
}

public T[] ToArray<T>(Func<ST_0310bb62d750573571d23e0cd61c55b3Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_544a92ac2b1a23d422d8e47df2b48a91 recordList, Func<ST_0310bb62d750573571d23e0cd61c55b3Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_544a92ac2b1a23d422d8e47df2b48a91(ST_0310bb62d750573571d23e0cd61c55b3Structure[] array) {
  RL_544a92ac2b1a23d422d8e47df2b48a91 result = new RL_544a92ac2b1a23d422d8e47df2b48a91();
result.InnerFromArray(array);
    return result;
}

public static RL_544a92ac2b1a23d422d8e47df2b48a91 ToList<T>(T[] array, Func <T, ST_0310bb62d750573571d23e0cd61c55b3Structure> converter) {
  RL_544a92ac2b1a23d422d8e47df2b48a91 result = new RL_544a92ac2b1a23d422d8e47df2b48a91();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_544a92ac2b1a23d422d8e47df2b48a91 FromRestList<T>(RestList<T> restList, Func <T, ST_0310bb62d750573571d23e0cd61c55b3Structure> converter) {
  RL_544a92ac2b1a23d422d8e47df2b48a91 result = new RL_544a92ac2b1a23d422d8e47df2b48a91();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_544a92ac2b1a23d422d8e47df2b48a91() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_0310bb62d750573571d23e0cd61c55b3Structure> NewList() {
return new RL_544a92ac2b1a23d422d8e47df2b48a91();
}


} // RL_544a92ac2b1a23d422d8e47df2b48a91
}

