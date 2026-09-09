namespace ssConectaProveedores {
/// <summary>
/// [Structure] CurrentAccountFACT_PEN_PAGStruct (iB4ogOshh0OQSLkeguAYng)
///  <code>ST_6e58a6c07a695cdbbb36aed76c927a26Structure</code> that represent
/// s <code>CurrentAccountFACT_PEN_PAGStruct</code> <p>Description: Current Account Struct</p>
/// </summary>
// Name: CurrentAccountFACT_PEN_PAGStruct
public partial struct ST_6e58a6c07a695cdbbb36aed76c927a26Structure : ITypedRecord<ST_6e58a6c07a695cdbbb36aed76c927a26Structure> {
internal static readonly GlobalObjectKey IdXBLNR = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*a_BfGFQIgEusF1ifi1Lsww");
internal static readonly GlobalObjectKey IdZUONR = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*54kzFmquCUOX7lxbhl1XaA");
internal static readonly GlobalObjectKey IdZFBDT = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*woogPDOmqUywHof59SgB_g");
internal static readonly GlobalObjectKey IdZTERM = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hsBWJTmqwEWSwWbFyQW1cA");
internal static readonly GlobalObjectKey IdAUGDT = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DHMZfupOzESIun+kiH_MNQ");
internal static readonly GlobalObjectKey IdWRBTR = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5PqNGB8OwkeEvLkkeMgaaQ");
internal static readonly GlobalObjectKey IdWAERS = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*JevxcItoDUO5+_pF0gBdYA");
internal static readonly GlobalObjectKey IdWRBT2 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*scKkKDlKKkeXx2gv4o0jsg");
internal static readonly GlobalObjectKey IdWRBT3 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*U1CuDcw9EU+8sS3xMp2Zcg");
internal static readonly GlobalObjectKey IdUMSKZ = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*C5eYzkQRvUuGSxXK+7Vxsg");
internal static readonly GlobalObjectKey IdBLART = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*MyvTeP6ARESpC+3QhSosCQ");
internal static readonly GlobalObjectKey IdZLSCH = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_951GgcaHUOuOTyrNQ0zwQ");
internal static readonly GlobalObjectKey IdKURSF = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*UcMNJcMfNUWmL7iajmj6ug");
internal static readonly GlobalObjectKey IdUSNAM = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*SOXocRU15USQc_TyEtpijw");
internal static readonly GlobalObjectKey IdUSRID_LONG = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*kZtFp+AoyEmmCPd3nnjLTQ");

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

public ST_6e58a6c07a695cdbbb36aed76c927a26Structure() {
OptimizedAttributes = null;
ssXBLNR = "";
ssZUONR = "";
ssZFBDT = (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssZTERM = "";
ssAUGDT = (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssWRBTR = 0.0M;
ssWAERS = "";
ssWRBT2 = 0.0M;
ssWRBT3 = 0.0M;
ssUMSKZ = "";
ssBLART = "";
ssZLSCH = "";
ssKURSF = 0.0M;
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
ssXBLNR = r.ReadText(index++, "CurrentAccountFACT_PEN_PAGStruct.XBLNR", "");
ssZUONR = r.ReadText(index++, "CurrentAccountFACT_PEN_PAGStruct.ZUONR", "");
ssZFBDT = r.ReadDate(index++, "CurrentAccountFACT_PEN_PAGStruct.ZFBDT", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssZTERM = r.ReadText(index++, "CurrentAccountFACT_PEN_PAGStruct.ZTERM", "");
ssAUGDT = r.ReadDate(index++, "CurrentAccountFACT_PEN_PAGStruct.AUGDT", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssWRBTR = r.ReadDecimal(index++, "CurrentAccountFACT_PEN_PAGStruct.WRBTR", 0.0M);
ssWAERS = r.ReadText(index++, "CurrentAccountFACT_PEN_PAGStruct.WAERS", "");
ssWRBT2 = r.ReadDecimal(index++, "CurrentAccountFACT_PEN_PAGStruct.WRBT2", 0.0M);
ssWRBT3 = r.ReadDecimal(index++, "CurrentAccountFACT_PEN_PAGStruct.WRBT3", 0.0M);
ssUMSKZ = r.ReadText(index++, "CurrentAccountFACT_PEN_PAGStruct.UMSKZ", "");
ssBLART = r.ReadText(index++, "CurrentAccountFACT_PEN_PAGStruct.BLART", "");
ssZLSCH = r.ReadText(index++, "CurrentAccountFACT_PEN_PAGStruct.ZLSCH", "");
ssKURSF = r.ReadDecimal(index++, "CurrentAccountFACT_PEN_PAGStruct.KURSF", 0.0M);
ssUSNAM = r.ReadText(index++, "CurrentAccountFACT_PEN_PAGStruct.USNAM", "");
ssUSRID_LONG = r.ReadText(index++, "CurrentAccountFACT_PEN_PAGStruct.USRID_LONG", "");
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
public void ReadIM(ST_6e58a6c07a695cdbbb36aed76c927a26Structure r) {
this = r;
}


public static bool operator == (ST_6e58a6c07a695cdbbb36aed76c927a26Structure a, ST_6e58a6c07a695cdbbb36aed76c927a26Structure b) {
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

public static bool operator != (ST_6e58a6c07a695cdbbb36aed76c927a26Structure a, ST_6e58a6c07a695cdbbb36aed76c927a26Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_6e58a6c07a695cdbbb36aed76c927a26Structure)) return false;
return (this == (ST_6e58a6c07a695cdbbb36aed76c927a26Structure)o);
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


public ST_6e58a6c07a695cdbbb36aed76c927a26Structure Duplicate() {
ST_6e58a6c07a695cdbbb36aed76c927a26Structure t;
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
} // ST_6e58a6c07a695cdbbb36aed76c927a26Structure
/// <summary>
/// RecordList type <code>CurrentAccountFACT_PEN_PAGStructList</code> that represents a record list of
///  <code>CurrentAccountFACT_PEN_PAGStruct</code>
/// </summary>
public partial class RL_63f162121e2362744dd9f896d80895f7 : GenericRecordList<ST_6e58a6c07a695cdbbb36aed76c927a26Structure>, IEnumerable, IEnumerator {

protected override ST_6e58a6c07a695cdbbb36aed76c927a26Structure GetElementDefaultValue() {
return new ST_6e58a6c07a695cdbbb36aed76c927a26Structure();
}

public T[] ToArray<T>(Func<ST_6e58a6c07a695cdbbb36aed76c927a26Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_63f162121e2362744dd9f896d80895f7 recordList, Func<ST_6e58a6c07a695cdbbb36aed76c927a26Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_63f162121e2362744dd9f896d80895f7(ST_6e58a6c07a695cdbbb36aed76c927a26Structure[] array) {
  RL_63f162121e2362744dd9f896d80895f7 result = new RL_63f162121e2362744dd9f896d80895f7();
result.InnerFromArray(array);
    return result;
}

public static RL_63f162121e2362744dd9f896d80895f7 ToList<T>(T[] array, Func <T, ST_6e58a6c07a695cdbbb36aed76c927a26Structure> converter) {
  RL_63f162121e2362744dd9f896d80895f7 result = new RL_63f162121e2362744dd9f896d80895f7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_63f162121e2362744dd9f896d80895f7 FromRestList<T>(RestList<T> restList, Func <T, ST_6e58a6c07a695cdbbb36aed76c927a26Structure> converter) {
  RL_63f162121e2362744dd9f896d80895f7 result = new RL_63f162121e2362744dd9f896d80895f7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_63f162121e2362744dd9f896d80895f7() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_6e58a6c07a695cdbbb36aed76c927a26Structure> NewList() {
return new RL_63f162121e2362744dd9f896d80895f7();
}


} // RL_63f162121e2362744dd9f896d80895f7
}

