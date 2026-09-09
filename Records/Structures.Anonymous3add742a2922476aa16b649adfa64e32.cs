namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (KnTdOiIpakeha2Sa36ZOMg)
///  <code>RC_77a3e11ff871cf6d38ddae5959446c0c</code> that represent
/// s <code>GetOrderData_ResponseRecord</code> <p>Description: </p>
/// </summary>
// Name: GetOrderData_ResponseRecord
public partial struct RC_77a3e11ff871cf6d38ddae5959446c0c : ITypedRecord<RC_77a3e11ff871cf6d38ddae5959446c0c> {
internal static readonly GlobalObjectKey IdGetOrderData_Response = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*H+Gjd3H4bc843a5ZWURsDA");

public ST_77e33f0a47d2ef32eb85177e44c9b70fStructure ssSTGetOrderData_Response;


public static implicit operator ST_77e33f0a47d2ef32eb85177e44c9b70fStructure( RC_77a3e11ff871cf6d38ddae5959446c0c r) {
return r.ssSTGetOrderData_Response;
}

public static implicit operator RC_77a3e11ff871cf6d38ddae5959446c0c (ST_77e33f0a47d2ef32eb85177e44c9b70fStructure r) {
RC_77a3e11ff871cf6d38ddae5959446c0c res = new RC_77a3e11ff871cf6d38ddae5959446c0c ();
res.ssSTGetOrderData_Response = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_77a3e11ff871cf6d38ddae5959446c0c() {
OptimizedAttributes = null;
ssSTGetOrderData_Response = new ST_77e33f0a47d2ef32eb85177e44c9b70fStructure();
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
    ssSTGetOrderData_Response.OptimizedAttributes = value[0];
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
ssSTGetOrderData_Response.Read( r, ref index);
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
public void ReadIM(RC_77a3e11ff871cf6d38ddae5959446c0c r) {
this = r;
}


public static bool operator == (RC_77a3e11ff871cf6d38ddae5959446c0c a, RC_77a3e11ff871cf6d38ddae5959446c0c b) {
if (a.ssSTGetOrderData_Response != b.ssSTGetOrderData_Response) return false;
return true;
}

public static bool operator != (RC_77a3e11ff871cf6d38ddae5959446c0c a, RC_77a3e11ff871cf6d38ddae5959446c0c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_77a3e11ff871cf6d38ddae5959446c0c)) return false;
return (this == (RC_77a3e11ff871cf6d38ddae5959446c0c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTGetOrderData_Response.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTGetOrderData_Response.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTGetOrderData_Response.InternalRecursiveSave();
}


public RC_77a3e11ff871cf6d38ddae5959446c0c Duplicate() {
RC_77a3e11ff871cf6d38ddae5959446c0c t;
t.ssSTGetOrderData_Response = (ST_77e33f0a47d2ef32eb85177e44c9b70fStructure)this.ssSTGetOrderData_Response.Duplicate();
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
if (head == "getorderdata_response") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".GetOrderData_Response")) variable.Value = ssSTGetOrderData_Response; else variable.Optimized = true;
variable.SetFieldName("getorderdata_response");
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
if (key == IdGetOrderData_Response) {
return ssSTGetOrderData_Response;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdGetOrderData_Response.Key.AsGuid) {
return ssSTGetOrderData_Response;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTGetOrderData_Response.FillFromOther((IRecord) other.AttributeGet(IdGetOrderData_Response));
}
} // RC_77a3e11ff871cf6d38ddae5959446c0c
/// <summary>
/// RecordList type <code>GetOrderData_ResponseRecordList</code> that represents a record list of
///  <code>GetOrderData_Response</code>
/// </summary>
public partial class RL_34f03a7c8e21e20b0d274f3367867a86 : GenericRecordList<RC_77a3e11ff871cf6d38ddae5959446c0c>, IEnumerable, IEnumerator {

protected override RC_77a3e11ff871cf6d38ddae5959446c0c GetElementDefaultValue() {
return new RC_77a3e11ff871cf6d38ddae5959446c0c();
}

public T[] ToArray<T>(Func<RC_77a3e11ff871cf6d38ddae5959446c0c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_34f03a7c8e21e20b0d274f3367867a86 recordList, Func<RC_77a3e11ff871cf6d38ddae5959446c0c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_34f03a7c8e21e20b0d274f3367867a86(RC_77a3e11ff871cf6d38ddae5959446c0c[] array) {
  RL_34f03a7c8e21e20b0d274f3367867a86 result = new RL_34f03a7c8e21e20b0d274f3367867a86();
result.InnerFromArray(array);
    return result;
}

public static RL_34f03a7c8e21e20b0d274f3367867a86 ToList<T>(T[] array, Func <T, RC_77a3e11ff871cf6d38ddae5959446c0c> converter) {
  RL_34f03a7c8e21e20b0d274f3367867a86 result = new RL_34f03a7c8e21e20b0d274f3367867a86();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_34f03a7c8e21e20b0d274f3367867a86 FromRestList<T>(RestList<T> restList, Func <T, RC_77a3e11ff871cf6d38ddae5959446c0c> converter) {
  RL_34f03a7c8e21e20b0d274f3367867a86 result = new RL_34f03a7c8e21e20b0d274f3367867a86();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_34f03a7c8e21e20b0d274f3367867a86() : base() {
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
protected override OSList<RC_77a3e11ff871cf6d38ddae5959446c0c> NewList() {
return new RL_34f03a7c8e21e20b0d274f3367867a86();
}


} // RL_34f03a7c8e21e20b0d274f3367867a86
}

