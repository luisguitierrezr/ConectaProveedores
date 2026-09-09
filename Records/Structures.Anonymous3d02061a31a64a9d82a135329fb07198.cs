namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (GgYCPaYxnUqCoTUyn7BxmA)
///  <code>RC_9f2ace8f61f1c245fb0b20b98c1f76f7</code> that represent
/// s <code>OrderListTableStructureRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderListTableStructureRecord
public partial struct RC_9f2ace8f61f1c245fb0b20b98c1f76f7 : ITypedRecord<RC_9f2ace8f61f1c245fb0b20b98c1f76f7> {
internal static readonly GlobalObjectKey IdOrderListTableStructure = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*j84qn_FhRcL7CyC5jB929w");

public ST_00c299856fb2c1322ea33527b24c9dd0Structure ssSTOrderListTableStructure;


public static implicit operator ST_00c299856fb2c1322ea33527b24c9dd0Structure( RC_9f2ace8f61f1c245fb0b20b98c1f76f7 r) {
return r.ssSTOrderListTableStructure;
}

public static implicit operator RC_9f2ace8f61f1c245fb0b20b98c1f76f7 (ST_00c299856fb2c1322ea33527b24c9dd0Structure r) {
RC_9f2ace8f61f1c245fb0b20b98c1f76f7 res = new RC_9f2ace8f61f1c245fb0b20b98c1f76f7 ();
res.ssSTOrderListTableStructure = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_9f2ace8f61f1c245fb0b20b98c1f76f7() {
OptimizedAttributes = null;
ssSTOrderListTableStructure = new ST_00c299856fb2c1322ea33527b24c9dd0Structure();
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
    ssSTOrderListTableStructure.OptimizedAttributes = value[0];
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
ssSTOrderListTableStructure.Read( r, ref index);
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
public void ReadIM(RC_9f2ace8f61f1c245fb0b20b98c1f76f7 r) {
this = r;
}


public static bool operator == (RC_9f2ace8f61f1c245fb0b20b98c1f76f7 a, RC_9f2ace8f61f1c245fb0b20b98c1f76f7 b) {
if (a.ssSTOrderListTableStructure != b.ssSTOrderListTableStructure) return false;
return true;
}

public static bool operator != (RC_9f2ace8f61f1c245fb0b20b98c1f76f7 a, RC_9f2ace8f61f1c245fb0b20b98c1f76f7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9f2ace8f61f1c245fb0b20b98c1f76f7)) return false;
return (this == (RC_9f2ace8f61f1c245fb0b20b98c1f76f7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOrderListTableStructure.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOrderListTableStructure.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOrderListTableStructure.InternalRecursiveSave();
}


public RC_9f2ace8f61f1c245fb0b20b98c1f76f7 Duplicate() {
RC_9f2ace8f61f1c245fb0b20b98c1f76f7 t;
t.ssSTOrderListTableStructure = (ST_00c299856fb2c1322ea33527b24c9dd0Structure)this.ssSTOrderListTableStructure.Duplicate();
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
if (head == "orderlisttablestructure") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderListTableStructure")) variable.Value = ssSTOrderListTableStructure; else variable.Optimized = true;
variable.SetFieldName("orderlisttablestructure");
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
if (key == IdOrderListTableStructure) {
return ssSTOrderListTableStructure;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderListTableStructure.Key.AsGuid) {
return ssSTOrderListTableStructure;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOrderListTableStructure.FillFromOther((IRecord) other.AttributeGet(IdOrderListTableStructure));
}
} // RC_9f2ace8f61f1c245fb0b20b98c1f76f7
/// <summary>
/// RecordList type <code>OrderListTableStructureRecordList</code> that represents a record list of
///  <code>OrderListTableStructure</code>
/// </summary>
public partial class RL_0c813488b403b979a8e7ceb41f0d5473 : GenericRecordList<RC_9f2ace8f61f1c245fb0b20b98c1f76f7>, IEnumerable, IEnumerator {

protected override RC_9f2ace8f61f1c245fb0b20b98c1f76f7 GetElementDefaultValue() {
return new RC_9f2ace8f61f1c245fb0b20b98c1f76f7();
}

public T[] ToArray<T>(Func<RC_9f2ace8f61f1c245fb0b20b98c1f76f7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0c813488b403b979a8e7ceb41f0d5473 recordList, Func<RC_9f2ace8f61f1c245fb0b20b98c1f76f7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0c813488b403b979a8e7ceb41f0d5473(RC_9f2ace8f61f1c245fb0b20b98c1f76f7[] array) {
  RL_0c813488b403b979a8e7ceb41f0d5473 result = new RL_0c813488b403b979a8e7ceb41f0d5473();
result.InnerFromArray(array);
    return result;
}

public static RL_0c813488b403b979a8e7ceb41f0d5473 ToList<T>(T[] array, Func <T, RC_9f2ace8f61f1c245fb0b20b98c1f76f7> converter) {
  RL_0c813488b403b979a8e7ceb41f0d5473 result = new RL_0c813488b403b979a8e7ceb41f0d5473();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0c813488b403b979a8e7ceb41f0d5473 FromRestList<T>(RestList<T> restList, Func <T, RC_9f2ace8f61f1c245fb0b20b98c1f76f7> converter) {
  RL_0c813488b403b979a8e7ceb41f0d5473 result = new RL_0c813488b403b979a8e7ceb41f0d5473();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0c813488b403b979a8e7ceb41f0d5473() : base() {
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
protected override OSList<RC_9f2ace8f61f1c245fb0b20b98c1f76f7> NewList() {
return new RL_0c813488b403b979a8e7ceb41f0d5473();
}


} // RL_0c813488b403b979a8e7ceb41f0d5473
}

