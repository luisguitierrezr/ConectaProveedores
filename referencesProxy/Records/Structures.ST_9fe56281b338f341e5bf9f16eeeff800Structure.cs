namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] TI_RETENCIONES_Out3 (unKyDMWFU0GZSzZ8lBB1jQ)
///  <code>ST_9fe56281b338f341e5bf9f16eeeff800Structure</code> that represent
/// s <code>TI_RETENCIONES_Out3</code> <p>Description: </p>
/// </summary>
// Name: TI_RETENCIONES_Out3
public partial struct ST_9fe56281b338f341e5bf9f16eeeff800Structure : ITypedRecord<ST_9fe56281b338f341e5bf9f16eeeff800Structure> {
internal static readonly GlobalObjectKey IdWITHT = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*J2eS_SnJDUqQ_EE11077iA");
internal static readonly GlobalObjectKey IdWT_WITHCD = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*RwsbsUT_KkOREav+y73LnA");
internal static readonly GlobalObjectKey IdWT_SUBJCT = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*iSSO8C1oSkuCeDqHI4Kgkg");

public string ssWITHT;

public string ssWT_WITHCD;

public string ssWT_SUBJCT;


public BitArray OptimizedAttributes;

public ST_9fe56281b338f341e5bf9f16eeeff800Structure() {
OptimizedAttributes = null;
ssWITHT = "";
ssWT_WITHCD = "";
ssWT_SUBJCT = "";
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
ssWITHT = r.ReadText(index++, "TI_RETENCIONES_Out3.WITHT", "");
ssWT_WITHCD = r.ReadText(index++, "TI_RETENCIONES_Out3.WT_WITHCD", "");
ssWT_SUBJCT = r.ReadText(index++, "TI_RETENCIONES_Out3.WT_SUBJCT", "");
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
public void ReadIM(ST_9fe56281b338f341e5bf9f16eeeff800Structure r) {
this = r;
}


public static bool operator == (ST_9fe56281b338f341e5bf9f16eeeff800Structure a, ST_9fe56281b338f341e5bf9f16eeeff800Structure b) {
if (a.ssWITHT != b.ssWITHT) return false;
if (a.ssWT_WITHCD != b.ssWT_WITHCD) return false;
if (a.ssWT_SUBJCT != b.ssWT_SUBJCT) return false;
return true;
}

public static bool operator != (ST_9fe56281b338f341e5bf9f16eeeff800Structure a, ST_9fe56281b338f341e5bf9f16eeeff800Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_9fe56281b338f341e5bf9f16eeeff800Structure)) return false;
return (this == (ST_9fe56281b338f341e5bf9f16eeeff800Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssWITHT.GetHashCode()
 ^ ssWT_WITHCD.GetHashCode()
 ^ ssWT_SUBJCT.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_9fe56281b338f341e5bf9f16eeeff800Structure Duplicate() {
ST_9fe56281b338f341e5bf9f16eeeff800Structure t;
t.ssWITHT = this.ssWITHT;
t.ssWT_WITHCD = this.ssWT_WITHCD;
t.ssWT_SUBJCT = this.ssWT_SUBJCT;
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
if (head == "witht") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WITHT")) variable.Value = ssWITHT; else variable.Optimized = true;
} else if (head == "wt_withcd") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WT_WITHCD")) variable.Value = ssWT_WITHCD; else variable.Optimized = true;
} else if (head == "wt_subjct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WT_SUBJCT")) variable.Value = ssWT_SUBJCT; else variable.Optimized = true;
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
if (key == IdWITHT) {
return ssWITHT;
}
if (key == IdWT_WITHCD) {
return ssWT_WITHCD;
}
if (key == IdWT_SUBJCT) {
return ssWT_SUBJCT;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdWITHT.Key.AsGuid) {
return ssWITHT;
}
if (attributeKey == IdWT_WITHCD.Key.AsGuid) {
return ssWT_WITHCD;
}
if (attributeKey == IdWT_SUBJCT.Key.AsGuid) {
return ssWT_SUBJCT;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssWITHT = (string) other.AttributeGet(IdWITHT);
ssWT_WITHCD = (string) other.AttributeGet(IdWT_WITHCD);
ssWT_SUBJCT = (string) other.AttributeGet(IdWT_SUBJCT);
}
} // ST_9fe56281b338f341e5bf9f16eeeff800Structure
/// <summary>
/// RecordList type <code>TI_RETENCIONES_Out3List</code> that represents a record list of
///  <code>TI_RETENCIONES_Out3</code>
/// </summary>
public partial class RL_9290b8f2ad0d5ad8e2511aa8b7a9f6fd : GenericRecordList<ST_9fe56281b338f341e5bf9f16eeeff800Structure>, IEnumerable, IEnumerator {

protected override ST_9fe56281b338f341e5bf9f16eeeff800Structure GetElementDefaultValue() {
return new ST_9fe56281b338f341e5bf9f16eeeff800Structure();
}

public T[] ToArray<T>(Func<ST_9fe56281b338f341e5bf9f16eeeff800Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9290b8f2ad0d5ad8e2511aa8b7a9f6fd recordList, Func<ST_9fe56281b338f341e5bf9f16eeeff800Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9290b8f2ad0d5ad8e2511aa8b7a9f6fd(ST_9fe56281b338f341e5bf9f16eeeff800Structure[] array) {
  RL_9290b8f2ad0d5ad8e2511aa8b7a9f6fd result = new RL_9290b8f2ad0d5ad8e2511aa8b7a9f6fd();
result.InnerFromArray(array);
    return result;
}

public static RL_9290b8f2ad0d5ad8e2511aa8b7a9f6fd ToList<T>(T[] array, Func <T, ST_9fe56281b338f341e5bf9f16eeeff800Structure> converter) {
  RL_9290b8f2ad0d5ad8e2511aa8b7a9f6fd result = new RL_9290b8f2ad0d5ad8e2511aa8b7a9f6fd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9290b8f2ad0d5ad8e2511aa8b7a9f6fd FromRestList<T>(RestList<T> restList, Func <T, ST_9fe56281b338f341e5bf9f16eeeff800Structure> converter) {
  RL_9290b8f2ad0d5ad8e2511aa8b7a9f6fd result = new RL_9290b8f2ad0d5ad8e2511aa8b7a9f6fd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9290b8f2ad0d5ad8e2511aa8b7a9f6fd() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_9fe56281b338f341e5bf9f16eeeff800Structure> NewList() {
return new RL_9290b8f2ad0d5ad8e2511aa8b7a9f6fd();
}


} // RL_9290b8f2ad0d5ad8e2511aa8b7a9f6fd
}

