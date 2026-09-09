namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ZVi23neoLUuUlCGIf_0UkQ)
///  <code>RC_7f1c9fb0e9d8bbf714e27d72e2b97691</code> that represents <code>KeyValueRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: KeyValueRecord
public partial struct RC_7f1c9fb0e9d8bbf714e27d72e2b97691 : ITypedRecord<RC_7f1c9fb0e9d8bbf714e27d72e2b97691> {
internal static readonly GlobalObjectKey IdKeyValue = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sJ8cf9jp97sU4n1y4rl2kQ");

public ST_714c559a98f1e1080cbf60de3228e843Structure ssSTKeyValue;


public static implicit operator ST_714c559a98f1e1080cbf60de3228e843Structure( RC_7f1c9fb0e9d8bbf714e27d72e2b97691 r) {
return r.ssSTKeyValue;
}

public static implicit operator RC_7f1c9fb0e9d8bbf714e27d72e2b97691 (ST_714c559a98f1e1080cbf60de3228e843Structure r) {
RC_7f1c9fb0e9d8bbf714e27d72e2b97691 res = new RC_7f1c9fb0e9d8bbf714e27d72e2b97691 ();
res.ssSTKeyValue = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_7f1c9fb0e9d8bbf714e27d72e2b97691() {
OptimizedAttributes = null;
ssSTKeyValue = new ST_714c559a98f1e1080cbf60de3228e843Structure();
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
    ssSTKeyValue.OptimizedAttributes = value[0];
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
ssSTKeyValue.Read( r, ref index);
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
public void ReadIM(RC_7f1c9fb0e9d8bbf714e27d72e2b97691 r) {
this = r;
}


public static bool operator == (RC_7f1c9fb0e9d8bbf714e27d72e2b97691 a, RC_7f1c9fb0e9d8bbf714e27d72e2b97691 b) {
if (a.ssSTKeyValue != b.ssSTKeyValue) return false;
return true;
}

public static bool operator != (RC_7f1c9fb0e9d8bbf714e27d72e2b97691 a, RC_7f1c9fb0e9d8bbf714e27d72e2b97691 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7f1c9fb0e9d8bbf714e27d72e2b97691)) return false;
return (this == (RC_7f1c9fb0e9d8bbf714e27d72e2b97691)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTKeyValue.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTKeyValue.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTKeyValue.InternalRecursiveSave();
}


public RC_7f1c9fb0e9d8bbf714e27d72e2b97691 Duplicate() {
RC_7f1c9fb0e9d8bbf714e27d72e2b97691 t;
t.ssSTKeyValue = (ST_714c559a98f1e1080cbf60de3228e843Structure)this.ssSTKeyValue.Duplicate();
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
if (head == "keyvalue") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".KeyValue")) variable.Value = ssSTKeyValue; else variable.Optimized = true;
variable.SetFieldName("keyvalue");
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
if (key == IdKeyValue) {
return ssSTKeyValue;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdKeyValue.Key.AsGuid) {
return ssSTKeyValue;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTKeyValue.FillFromOther((IRecord) other.AttributeGet(IdKeyValue));
}
} // RC_7f1c9fb0e9d8bbf714e27d72e2b97691
/// <summary>
/// RecordList type <code>KeyValueRecordList</code> that represents a record list of
///  <code>KeyValue</code>
/// </summary>
public partial class RL_8e4c9b320c4ad7d4450d6acbc369ad31 : GenericRecordList<RC_7f1c9fb0e9d8bbf714e27d72e2b97691>, IEnumerable, IEnumerator {

protected override RC_7f1c9fb0e9d8bbf714e27d72e2b97691 GetElementDefaultValue() {
return new RC_7f1c9fb0e9d8bbf714e27d72e2b97691();
}

public T[] ToArray<T>(Func<RC_7f1c9fb0e9d8bbf714e27d72e2b97691, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8e4c9b320c4ad7d4450d6acbc369ad31 recordList, Func<RC_7f1c9fb0e9d8bbf714e27d72e2b97691, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8e4c9b320c4ad7d4450d6acbc369ad31(RC_7f1c9fb0e9d8bbf714e27d72e2b97691[] array) {
  RL_8e4c9b320c4ad7d4450d6acbc369ad31 result = new RL_8e4c9b320c4ad7d4450d6acbc369ad31();
result.InnerFromArray(array);
    return result;
}

public static RL_8e4c9b320c4ad7d4450d6acbc369ad31 ToList<T>(T[] array, Func <T, RC_7f1c9fb0e9d8bbf714e27d72e2b97691> converter) {
  RL_8e4c9b320c4ad7d4450d6acbc369ad31 result = new RL_8e4c9b320c4ad7d4450d6acbc369ad31();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8e4c9b320c4ad7d4450d6acbc369ad31 FromRestList<T>(RestList<T> restList, Func <T, RC_7f1c9fb0e9d8bbf714e27d72e2b97691> converter) {
  RL_8e4c9b320c4ad7d4450d6acbc369ad31 result = new RL_8e4c9b320c4ad7d4450d6acbc369ad31();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8e4c9b320c4ad7d4450d6acbc369ad31() : base() {
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
protected override OSList<RC_7f1c9fb0e9d8bbf714e27d72e2b97691> NewList() {
return new RL_8e4c9b320c4ad7d4450d6acbc369ad31();
}


} // RL_8e4c9b320c4ad7d4450d6acbc369ad31
}

