namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] EM_COSMOZ_Request (L9ZgCKdHhkys7m1nTiQAdw)
///  <code>ST_471afc38d91cd307b39846c7ca5ddb86Structure</code> that represent
/// s <code>EM_COSMOZ_Request</code> <p>Description: EM_COSMOZ_Request</p>
/// </summary>
// Name: EM_COSMOZ_Request
public partial struct ST_471afc38d91cd307b39846c7ca5ddb86Structure : ITypedRecord<ST_471afc38d91cd307b39846c7ca5ddb86Structure> {
internal static readonly GlobalObjectKey IdEM_COSMOZ_Request_Struct = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*aQxHZEQGOEmhqVPUHdurnQ");

public ST_54b441362fa983751bf9575ed6b668beStructure ssEM_COSMOZ_Request_Struct;


public BitArray OptimizedAttributes;

public ST_471afc38d91cd307b39846c7ca5ddb86Structure() {
OptimizedAttributes = null;
ssEM_COSMOZ_Request_Struct = new ST_54b441362fa983751bf9575ed6b668beStructure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssEM_COSMOZ_Request_Struct.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
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
public void ReadIM(ST_471afc38d91cd307b39846c7ca5ddb86Structure r) {
this = r;
}


public static bool operator == (ST_471afc38d91cd307b39846c7ca5ddb86Structure a, ST_471afc38d91cd307b39846c7ca5ddb86Structure b) {
if (a.ssEM_COSMOZ_Request_Struct != b.ssEM_COSMOZ_Request_Struct) return false;
return true;
}

public static bool operator != (ST_471afc38d91cd307b39846c7ca5ddb86Structure a, ST_471afc38d91cd307b39846c7ca5ddb86Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_471afc38d91cd307b39846c7ca5ddb86Structure)) return false;
return (this == (ST_471afc38d91cd307b39846c7ca5ddb86Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssEM_COSMOZ_Request_Struct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssEM_COSMOZ_Request_Struct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssEM_COSMOZ_Request_Struct.InternalRecursiveSave();
}


public ST_471afc38d91cd307b39846c7ca5ddb86Structure Duplicate() {
ST_471afc38d91cd307b39846c7ca5ddb86Structure t;
t.ssEM_COSMOZ_Request_Struct = (ST_54b441362fa983751bf9575ed6b668beStructure)this.ssEM_COSMOZ_Request_Struct.Duplicate();
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
if (head == "em_cosmoz_request_struct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_COSMOZ_Request_Struct")) variable.Value = ssEM_COSMOZ_Request_Struct; else variable.Optimized = true;
variable.SetFieldName("em_cosmoz_request_struct");
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
if (key == IdEM_COSMOZ_Request_Struct) {
return ssEM_COSMOZ_Request_Struct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_COSMOZ_Request_Struct.Key.AsGuid) {
return ssEM_COSMOZ_Request_Struct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssEM_COSMOZ_Request_Struct.FillFromOther((IRecord) other.AttributeGet(IdEM_COSMOZ_Request_Struct));
}
} // ST_471afc38d91cd307b39846c7ca5ddb86Structure
/// <summary>
/// RecordList type <code>EM_COSMOZ_RequestList</code> that represents a record list of
///  <code>EM_COSMOZ_Request</code>
/// </summary>
public partial class RL_3401e1dd2e4608eb54569dd3038b8697 : GenericRecordList<ST_471afc38d91cd307b39846c7ca5ddb86Structure>, IEnumerable, IEnumerator {

protected override ST_471afc38d91cd307b39846c7ca5ddb86Structure GetElementDefaultValue() {
return new ST_471afc38d91cd307b39846c7ca5ddb86Structure();
}

public T[] ToArray<T>(Func<ST_471afc38d91cd307b39846c7ca5ddb86Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3401e1dd2e4608eb54569dd3038b8697 recordList, Func<ST_471afc38d91cd307b39846c7ca5ddb86Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3401e1dd2e4608eb54569dd3038b8697(ST_471afc38d91cd307b39846c7ca5ddb86Structure[] array) {
  RL_3401e1dd2e4608eb54569dd3038b8697 result = new RL_3401e1dd2e4608eb54569dd3038b8697();
result.InnerFromArray(array);
    return result;
}

public static RL_3401e1dd2e4608eb54569dd3038b8697 ToList<T>(T[] array, Func <T, ST_471afc38d91cd307b39846c7ca5ddb86Structure> converter) {
  RL_3401e1dd2e4608eb54569dd3038b8697 result = new RL_3401e1dd2e4608eb54569dd3038b8697();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3401e1dd2e4608eb54569dd3038b8697 FromRestList<T>(RestList<T> restList, Func <T, ST_471afc38d91cd307b39846c7ca5ddb86Structure> converter) {
  RL_3401e1dd2e4608eb54569dd3038b8697 result = new RL_3401e1dd2e4608eb54569dd3038b8697();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3401e1dd2e4608eb54569dd3038b8697() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_471afc38d91cd307b39846c7ca5ddb86Structure> NewList() {
return new RL_3401e1dd2e4608eb54569dd3038b8697();
}


} // RL_3401e1dd2e4608eb54569dd3038b8697
}

