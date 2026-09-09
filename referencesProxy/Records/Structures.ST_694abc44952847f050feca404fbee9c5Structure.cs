namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] ZMXFFIMF_OBT_TIP_CAMReq (0k7QuR77EUyNBLUfx6_hzw)
///  <code>ST_694abc44952847f050feca404fbee9c5Structure</code> that represent
/// s <code>ZMXFFIMF_OBT_TIP_CAMReq</code> <p>Description: ZMXFFIMF_OBT_TIP_CAMReq</p>
/// </summary>
// Name: ZMXFFIMF_OBT_TIP_CAMReq
public partial struct ST_694abc44952847f050feca404fbee9c5Structure : ITypedRecord<ST_694abc44952847f050feca404fbee9c5Structure> {
internal static readonly GlobalObjectKey IdPI_FCURR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*cbRaSDmHF0eu79cAhopVIg");
internal static readonly GlobalObjectKey IdPI_GDATU = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*96bYIhm+F0ihP3rfHajWVw");
internal static readonly GlobalObjectKey IdPI_KURST = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*kAVk3axcrEGcZuJ3p78l7g");
internal static readonly GlobalObjectKey IdPI_TCURR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*NmnOgE9srk64ppW7m73MQg");

public string ssPI_FCURR;

public string ssPI_GDATU;

public string ssPI_KURST;

public string ssPI_TCURR;


public BitArray OptimizedAttributes;

public ST_694abc44952847f050feca404fbee9c5Structure() {
OptimizedAttributes = null;
ssPI_FCURR = "";
ssPI_GDATU = "";
ssPI_KURST = "";
ssPI_TCURR = "";
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
ssPI_FCURR = r.ReadText(index++, "ZMXFFIMF_OBT_TIP_CAMReq.PI_FCURR", "");
ssPI_GDATU = r.ReadText(index++, "ZMXFFIMF_OBT_TIP_CAMReq.PI_GDATU", "");
ssPI_KURST = r.ReadText(index++, "ZMXFFIMF_OBT_TIP_CAMReq.PI_KURST", "");
ssPI_TCURR = r.ReadText(index++, "ZMXFFIMF_OBT_TIP_CAMReq.PI_TCURR", "");
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
public void ReadIM(ST_694abc44952847f050feca404fbee9c5Structure r) {
this = r;
}


public static bool operator == (ST_694abc44952847f050feca404fbee9c5Structure a, ST_694abc44952847f050feca404fbee9c5Structure b) {
if (a.ssPI_FCURR != b.ssPI_FCURR) return false;
if (a.ssPI_GDATU != b.ssPI_GDATU) return false;
if (a.ssPI_KURST != b.ssPI_KURST) return false;
if (a.ssPI_TCURR != b.ssPI_TCURR) return false;
return true;
}

public static bool operator != (ST_694abc44952847f050feca404fbee9c5Structure a, ST_694abc44952847f050feca404fbee9c5Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_694abc44952847f050feca404fbee9c5Structure)) return false;
return (this == (ST_694abc44952847f050feca404fbee9c5Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPI_FCURR.GetHashCode()
 ^ ssPI_GDATU.GetHashCode()
 ^ ssPI_KURST.GetHashCode()
 ^ ssPI_TCURR.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_694abc44952847f050feca404fbee9c5Structure Duplicate() {
ST_694abc44952847f050feca404fbee9c5Structure t;
t.ssPI_FCURR = this.ssPI_FCURR;
t.ssPI_GDATU = this.ssPI_GDATU;
t.ssPI_KURST = this.ssPI_KURST;
t.ssPI_TCURR = this.ssPI_TCURR;
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
if (head == "pi_fcurr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_FCURR")) variable.Value = ssPI_FCURR; else variable.Optimized = true;
} else if (head == "pi_gdatu") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_GDATU")) variable.Value = ssPI_GDATU; else variable.Optimized = true;
} else if (head == "pi_kurst") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_KURST")) variable.Value = ssPI_KURST; else variable.Optimized = true;
} else if (head == "pi_tcurr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_TCURR")) variable.Value = ssPI_TCURR; else variable.Optimized = true;
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
if (key == IdPI_FCURR) {
return ssPI_FCURR;
}
if (key == IdPI_GDATU) {
return ssPI_GDATU;
}
if (key == IdPI_KURST) {
return ssPI_KURST;
}
if (key == IdPI_TCURR) {
return ssPI_TCURR;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_FCURR.Key.AsGuid) {
return ssPI_FCURR;
}
if (attributeKey == IdPI_GDATU.Key.AsGuid) {
return ssPI_GDATU;
}
if (attributeKey == IdPI_KURST.Key.AsGuid) {
return ssPI_KURST;
}
if (attributeKey == IdPI_TCURR.Key.AsGuid) {
return ssPI_TCURR;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPI_FCURR = (string) other.AttributeGet(IdPI_FCURR);
ssPI_GDATU = (string) other.AttributeGet(IdPI_GDATU);
ssPI_KURST = (string) other.AttributeGet(IdPI_KURST);
ssPI_TCURR = (string) other.AttributeGet(IdPI_TCURR);
}
} // ST_694abc44952847f050feca404fbee9c5Structure
/// <summary>
/// RecordList type <code>ZMXFFIMF_OBT_TIP_CAMReqList</code> that represents a record list of
///  <code>ZMXFFIMF_OBT_TIP_CAMReq</code>
/// </summary>
public partial class RL_43857af1d46c708a8e87827221ea5d1b : GenericRecordList<ST_694abc44952847f050feca404fbee9c5Structure>, IEnumerable, IEnumerator {

protected override ST_694abc44952847f050feca404fbee9c5Structure GetElementDefaultValue() {
return new ST_694abc44952847f050feca404fbee9c5Structure();
}

public T[] ToArray<T>(Func<ST_694abc44952847f050feca404fbee9c5Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_43857af1d46c708a8e87827221ea5d1b recordList, Func<ST_694abc44952847f050feca404fbee9c5Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_43857af1d46c708a8e87827221ea5d1b(ST_694abc44952847f050feca404fbee9c5Structure[] array) {
  RL_43857af1d46c708a8e87827221ea5d1b result = new RL_43857af1d46c708a8e87827221ea5d1b();
result.InnerFromArray(array);
    return result;
}

public static RL_43857af1d46c708a8e87827221ea5d1b ToList<T>(T[] array, Func <T, ST_694abc44952847f050feca404fbee9c5Structure> converter) {
  RL_43857af1d46c708a8e87827221ea5d1b result = new RL_43857af1d46c708a8e87827221ea5d1b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_43857af1d46c708a8e87827221ea5d1b FromRestList<T>(RestList<T> restList, Func <T, ST_694abc44952847f050feca404fbee9c5Structure> converter) {
  RL_43857af1d46c708a8e87827221ea5d1b result = new RL_43857af1d46c708a8e87827221ea5d1b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_43857af1d46c708a8e87827221ea5d1b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_694abc44952847f050feca404fbee9c5Structure> NewList() {
return new RL_43857af1d46c708a8e87827221ea5d1b();
}


} // RL_43857af1d46c708a8e87827221ea5d1b
}

