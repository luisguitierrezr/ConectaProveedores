namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] ZMXFFIMF_OBT_TIP_CAMResp (XHT3td+a6E2twi41+ogoig)
///  <code>ST_72813e0dac5e52c872182de62adb7f2bStructure</code> that represent
/// s <code>ZMXFFIMF_OBT_TIP_CAMResp</code> <p>Description: ZMXFFIMF_OBT_TIP_CAMResp</p>
/// </summary>
// Name: ZMXFFIMF_OBT_TIP_CAMResp
public partial struct ST_72813e0dac5e52c872182de62adb7f2bStructure : ITypedRecord<ST_72813e0dac5e52c872182de62adb7f2bStructure> {
internal static readonly GlobalObjectKey IdPE_FCURR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*aj5KhW1DyUGdPYNogoFv3w");
internal static readonly GlobalObjectKey IdPE_GDATU = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*7GGLbmvx5E+uDOM9Gighug");
internal static readonly GlobalObjectKey IdPE_KURST = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*H8CcXAjUMEubGnp5W2XyhA");
internal static readonly GlobalObjectKey IdPE_MSG = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*V7U04j1EaEm+OE2HHPTDCg");
internal static readonly GlobalObjectKey IdPE_TCURR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*6mH0z_zZ+kKTYsJkwaJM7Q");
internal static readonly GlobalObjectKey IdPE_UKURS = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*Gy29u8wRj0OR_88ALB5sag");

public string ssPE_FCURR;

public string ssPE_GDATU;

public string ssPE_KURST;

public string ssPE_MSG;

public string ssPE_TCURR;

public decimal ssPE_UKURS;


public BitArray OptimizedAttributes;

public ST_72813e0dac5e52c872182de62adb7f2bStructure() {
OptimizedAttributes = null;
ssPE_FCURR = "";
ssPE_GDATU = "";
ssPE_KURST = "";
ssPE_MSG = "";
ssPE_TCURR = "";
ssPE_UKURS = 0.0M;
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
ssPE_FCURR = r.ReadText(index++, "ZMXFFIMF_OBT_TIP_CAMResp.PE_FCURR", "");
ssPE_GDATU = r.ReadText(index++, "ZMXFFIMF_OBT_TIP_CAMResp.PE_GDATU", "");
ssPE_KURST = r.ReadText(index++, "ZMXFFIMF_OBT_TIP_CAMResp.PE_KURST", "");
ssPE_MSG = r.ReadText(index++, "ZMXFFIMF_OBT_TIP_CAMResp.PE_MSG", "");
ssPE_TCURR = r.ReadText(index++, "ZMXFFIMF_OBT_TIP_CAMResp.PE_TCURR", "");
ssPE_UKURS = r.ReadDecimal(index++, "ZMXFFIMF_OBT_TIP_CAMResp.PE_UKURS", 0.0M);
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
public void ReadIM(ST_72813e0dac5e52c872182de62adb7f2bStructure r) {
this = r;
}


public static bool operator == (ST_72813e0dac5e52c872182de62adb7f2bStructure a, ST_72813e0dac5e52c872182de62adb7f2bStructure b) {
if (a.ssPE_FCURR != b.ssPE_FCURR) return false;
if (a.ssPE_GDATU != b.ssPE_GDATU) return false;
if (a.ssPE_KURST != b.ssPE_KURST) return false;
if (a.ssPE_MSG != b.ssPE_MSG) return false;
if (a.ssPE_TCURR != b.ssPE_TCURR) return false;
if (a.ssPE_UKURS != b.ssPE_UKURS) return false;
return true;
}

public static bool operator != (ST_72813e0dac5e52c872182de62adb7f2bStructure a, ST_72813e0dac5e52c872182de62adb7f2bStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_72813e0dac5e52c872182de62adb7f2bStructure)) return false;
return (this == (ST_72813e0dac5e52c872182de62adb7f2bStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPE_FCURR.GetHashCode()
 ^ ssPE_GDATU.GetHashCode()
 ^ ssPE_KURST.GetHashCode()
 ^ ssPE_MSG.GetHashCode()
 ^ ssPE_TCURR.GetHashCode()
 ^ ssPE_UKURS.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_72813e0dac5e52c872182de62adb7f2bStructure Duplicate() {
ST_72813e0dac5e52c872182de62adb7f2bStructure t;
t.ssPE_FCURR = this.ssPE_FCURR;
t.ssPE_GDATU = this.ssPE_GDATU;
t.ssPE_KURST = this.ssPE_KURST;
t.ssPE_MSG = this.ssPE_MSG;
t.ssPE_TCURR = this.ssPE_TCURR;
t.ssPE_UKURS = this.ssPE_UKURS;
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
if (head == "pe_fcurr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PE_FCURR")) variable.Value = ssPE_FCURR; else variable.Optimized = true;
} else if (head == "pe_gdatu") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PE_GDATU")) variable.Value = ssPE_GDATU; else variable.Optimized = true;
} else if (head == "pe_kurst") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PE_KURST")) variable.Value = ssPE_KURST; else variable.Optimized = true;
} else if (head == "pe_msg") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PE_MSG")) variable.Value = ssPE_MSG; else variable.Optimized = true;
} else if (head == "pe_tcurr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PE_TCURR")) variable.Value = ssPE_TCURR; else variable.Optimized = true;
} else if (head == "pe_ukurs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PE_UKURS")) variable.Value = ssPE_UKURS; else variable.Optimized = true;
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
if (key == IdPE_FCURR) {
return ssPE_FCURR;
}
if (key == IdPE_GDATU) {
return ssPE_GDATU;
}
if (key == IdPE_KURST) {
return ssPE_KURST;
}
if (key == IdPE_MSG) {
return ssPE_MSG;
}
if (key == IdPE_TCURR) {
return ssPE_TCURR;
}
if (key == IdPE_UKURS) {
return ssPE_UKURS;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPE_FCURR.Key.AsGuid) {
return ssPE_FCURR;
}
if (attributeKey == IdPE_GDATU.Key.AsGuid) {
return ssPE_GDATU;
}
if (attributeKey == IdPE_KURST.Key.AsGuid) {
return ssPE_KURST;
}
if (attributeKey == IdPE_MSG.Key.AsGuid) {
return ssPE_MSG;
}
if (attributeKey == IdPE_TCURR.Key.AsGuid) {
return ssPE_TCURR;
}
if (attributeKey == IdPE_UKURS.Key.AsGuid) {
return ssPE_UKURS;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPE_FCURR = (string) other.AttributeGet(IdPE_FCURR);
ssPE_GDATU = (string) other.AttributeGet(IdPE_GDATU);
ssPE_KURST = (string) other.AttributeGet(IdPE_KURST);
ssPE_MSG = (string) other.AttributeGet(IdPE_MSG);
ssPE_TCURR = (string) other.AttributeGet(IdPE_TCURR);
ssPE_UKURS = (decimal) other.AttributeGet(IdPE_UKURS);
}
} // ST_72813e0dac5e52c872182de62adb7f2bStructure
/// <summary>
/// RecordList type <code>ZMXFFIMF_OBT_TIP_CAMRespList</code> that represents a record list of
///  <code>ZMXFFIMF_OBT_TIP_CAMResp</code>
/// </summary>
public partial class RL_689baf6d4aad7a1dca9a4221fe6a721d : GenericRecordList<ST_72813e0dac5e52c872182de62adb7f2bStructure>, IEnumerable, IEnumerator {

protected override ST_72813e0dac5e52c872182de62adb7f2bStructure GetElementDefaultValue() {
return new ST_72813e0dac5e52c872182de62adb7f2bStructure();
}

public T[] ToArray<T>(Func<ST_72813e0dac5e52c872182de62adb7f2bStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_689baf6d4aad7a1dca9a4221fe6a721d recordList, Func<ST_72813e0dac5e52c872182de62adb7f2bStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_689baf6d4aad7a1dca9a4221fe6a721d(ST_72813e0dac5e52c872182de62adb7f2bStructure[] array) {
  RL_689baf6d4aad7a1dca9a4221fe6a721d result = new RL_689baf6d4aad7a1dca9a4221fe6a721d();
result.InnerFromArray(array);
    return result;
}

public static RL_689baf6d4aad7a1dca9a4221fe6a721d ToList<T>(T[] array, Func <T, ST_72813e0dac5e52c872182de62adb7f2bStructure> converter) {
  RL_689baf6d4aad7a1dca9a4221fe6a721d result = new RL_689baf6d4aad7a1dca9a4221fe6a721d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_689baf6d4aad7a1dca9a4221fe6a721d FromRestList<T>(RestList<T> restList, Func <T, ST_72813e0dac5e52c872182de62adb7f2bStructure> converter) {
  RL_689baf6d4aad7a1dca9a4221fe6a721d result = new RL_689baf6d4aad7a1dca9a4221fe6a721d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_689baf6d4aad7a1dca9a4221fe6a721d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_72813e0dac5e52c872182de62adb7f2bStructure> NewList() {
return new RL_689baf6d4aad7a1dca9a4221fe6a721d();
}


} // RL_689baf6d4aad7a1dca9a4221fe6a721d
}

