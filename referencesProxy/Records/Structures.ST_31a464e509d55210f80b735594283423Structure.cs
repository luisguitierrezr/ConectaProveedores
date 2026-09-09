namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] ZMXFFIMF_0250_FI_CREATE_RELATResp (z50VNghRekq57ciOZOL4fA)
///  <code>ST_31a464e509d55210f80b735594283423Structure</code> that represent
/// s <code>ZMXFFIMF_0250_FI_CREATE_RELATResp</code> <p>Description:
///  ZMXFFIMF_0250_FI_CREATE_RELATResp</p>
/// </summary>
// Name: ZMXFFIMF_0250_FI_CREATE_RELATResp
public partial struct ST_31a464e509d55210f80b735594283423Structure : ITypedRecord<ST_31a464e509d55210f80b735594283423Structure> {
internal static readonly GlobalObjectKey IdEV_ERROR_MESSAGE = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*a4eKaMZJCEyC4z+xQxDYdg");

public string ssEV_ERROR_MESSAGE;


public BitArray OptimizedAttributes;

public ST_31a464e509d55210f80b735594283423Structure() {
OptimizedAttributes = null;
ssEV_ERROR_MESSAGE = "";
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
ssEV_ERROR_MESSAGE = r.ReadText(index++, "ZMXFFIMF_0250_FI_CREATE_RELATResp.EV_ERROR_MESSAGE", "");
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
public void ReadIM(ST_31a464e509d55210f80b735594283423Structure r) {
this = r;
}


public static bool operator == (ST_31a464e509d55210f80b735594283423Structure a, ST_31a464e509d55210f80b735594283423Structure b) {
if (a.ssEV_ERROR_MESSAGE != b.ssEV_ERROR_MESSAGE) return false;
return true;
}

public static bool operator != (ST_31a464e509d55210f80b735594283423Structure a, ST_31a464e509d55210f80b735594283423Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_31a464e509d55210f80b735594283423Structure)) return false;
return (this == (ST_31a464e509d55210f80b735594283423Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssEV_ERROR_MESSAGE.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_31a464e509d55210f80b735594283423Structure Duplicate() {
ST_31a464e509d55210f80b735594283423Structure t;
t.ssEV_ERROR_MESSAGE = this.ssEV_ERROR_MESSAGE;
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
if (head == "ev_error_message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EV_ERROR_MESSAGE")) variable.Value = ssEV_ERROR_MESSAGE; else variable.Optimized = true;
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
if (key == IdEV_ERROR_MESSAGE) {
return ssEV_ERROR_MESSAGE;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEV_ERROR_MESSAGE.Key.AsGuid) {
return ssEV_ERROR_MESSAGE;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssEV_ERROR_MESSAGE = (string) other.AttributeGet(IdEV_ERROR_MESSAGE);
}
} // ST_31a464e509d55210f80b735594283423Structure
/// <summary>
/// RecordList type <code>ZMXFFIMF_0250_FI_CREATE_RELATRespList</code> that represents a record list of
///  <code>ZMXFFIMF_0250_FI_CREATE_RELATResp</code>
/// </summary>
public partial class RL_658985b125c685be0f5d2239039c58fc : GenericRecordList<ST_31a464e509d55210f80b735594283423Structure>, IEnumerable, IEnumerator {

protected override ST_31a464e509d55210f80b735594283423Structure GetElementDefaultValue() {
return new ST_31a464e509d55210f80b735594283423Structure();
}

public T[] ToArray<T>(Func<ST_31a464e509d55210f80b735594283423Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_658985b125c685be0f5d2239039c58fc recordList, Func<ST_31a464e509d55210f80b735594283423Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_658985b125c685be0f5d2239039c58fc(ST_31a464e509d55210f80b735594283423Structure[] array) {
  RL_658985b125c685be0f5d2239039c58fc result = new RL_658985b125c685be0f5d2239039c58fc();
result.InnerFromArray(array);
    return result;
}

public static RL_658985b125c685be0f5d2239039c58fc ToList<T>(T[] array, Func <T, ST_31a464e509d55210f80b735594283423Structure> converter) {
  RL_658985b125c685be0f5d2239039c58fc result = new RL_658985b125c685be0f5d2239039c58fc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_658985b125c685be0f5d2239039c58fc FromRestList<T>(RestList<T> restList, Func <T, ST_31a464e509d55210f80b735594283423Structure> converter) {
  RL_658985b125c685be0f5d2239039c58fc result = new RL_658985b125c685be0f5d2239039c58fc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_658985b125c685be0f5d2239039c58fc() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_31a464e509d55210f80b735594283423Structure> NewList() {
return new RL_658985b125c685be0f5d2239039c58fc();
}


} // RL_658985b125c685be0f5d2239039c58fc
}

