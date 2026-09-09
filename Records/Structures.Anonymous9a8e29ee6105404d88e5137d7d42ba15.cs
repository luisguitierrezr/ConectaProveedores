namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (7imOmgVhTUCI5RN9fUK6FQ)
///  <code>RC_27f9dcc2de814d2d04d4d18f5b8c424b</code> that represent
/// s <code>OrderItemEntriesRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderItemEntriesRecord
public partial struct RC_27f9dcc2de814d2d04d4d18f5b8c424b : ITypedRecord<RC_27f9dcc2de814d2d04d4d18f5b8c424b> {
internal static readonly GlobalObjectKey IdOrderItemEntries = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*wtz5J4HeLU0E1NGPW4xCSw");

public EN_0eb2cf39b93366f50855e537f6b98500EntityRecord ssENOrderItemEntries;


public static implicit operator EN_0eb2cf39b93366f50855e537f6b98500EntityRecord( RC_27f9dcc2de814d2d04d4d18f5b8c424b r) {
return r.ssENOrderItemEntries;
}

public static implicit operator RC_27f9dcc2de814d2d04d4d18f5b8c424b (EN_0eb2cf39b93366f50855e537f6b98500EntityRecord r) {
RC_27f9dcc2de814d2d04d4d18f5b8c424b res = new RC_27f9dcc2de814d2d04d4d18f5b8c424b ();
res.ssENOrderItemEntries = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrderItemEntries.ChangedAttributes = value;
}
get {
    return ssENOrderItemEntries.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_27f9dcc2de814d2d04d4d18f5b8c424b() {
OptimizedAttributes = null;
ssENOrderItemEntries = new EN_0eb2cf39b93366f50855e537f6b98500EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderItemEntries.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrderItemEntries.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrderItemEntries.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderItemEntries.Read( r, ref index);
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
public void ReadIM(RC_27f9dcc2de814d2d04d4d18f5b8c424b r) {
this = r;
}


public static bool operator == (RC_27f9dcc2de814d2d04d4d18f5b8c424b a, RC_27f9dcc2de814d2d04d4d18f5b8c424b b) {
if (a.ssENOrderItemEntries != b.ssENOrderItemEntries) return false;
return true;
}

public static bool operator != (RC_27f9dcc2de814d2d04d4d18f5b8c424b a, RC_27f9dcc2de814d2d04d4d18f5b8c424b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_27f9dcc2de814d2d04d4d18f5b8c424b)) return false;
return (this == (RC_27f9dcc2de814d2d04d4d18f5b8c424b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderItemEntries.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderItemEntries.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderItemEntries.InternalRecursiveSave();
}


public RC_27f9dcc2de814d2d04d4d18f5b8c424b Duplicate() {
RC_27f9dcc2de814d2d04d4d18f5b8c424b t;
t.ssENOrderItemEntries = (EN_0eb2cf39b93366f50855e537f6b98500EntityRecord)this.ssENOrderItemEntries.Duplicate();
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
if (head == "orderitementries") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderItemEntries")) variable.Value = ssENOrderItemEntries; else variable.Optimized = true;
variable.SetFieldName("orderitementries");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrderItemEntries.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrderItemEntries.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrderItemEntries) {
return ssENOrderItemEntries;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderItemEntries.Key.AsGuid) {
return ssENOrderItemEntries;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderItemEntries.FillFromOther((IRecord) other.AttributeGet(IdOrderItemEntries));
}
} // RC_27f9dcc2de814d2d04d4d18f5b8c424b
/// <summary>
/// RecordList type <code>OrderItemEntriesRecordList</code> that represents a record list of
///  <code>OrderItemEntries</code>
/// </summary>
public partial class RL_1560940f84afb17b822113e1812ea380 : GenericRecordList<RC_27f9dcc2de814d2d04d4d18f5b8c424b>, IEnumerable, IEnumerator {

protected override RC_27f9dcc2de814d2d04d4d18f5b8c424b GetElementDefaultValue() {
return new RC_27f9dcc2de814d2d04d4d18f5b8c424b();
}

public T[] ToArray<T>(Func<RC_27f9dcc2de814d2d04d4d18f5b8c424b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1560940f84afb17b822113e1812ea380 recordList, Func<RC_27f9dcc2de814d2d04d4d18f5b8c424b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1560940f84afb17b822113e1812ea380(RC_27f9dcc2de814d2d04d4d18f5b8c424b[] array) {
  RL_1560940f84afb17b822113e1812ea380 result = new RL_1560940f84afb17b822113e1812ea380();
result.InnerFromArray(array);
    return result;
}

public static RL_1560940f84afb17b822113e1812ea380 ToList<T>(T[] array, Func <T, RC_27f9dcc2de814d2d04d4d18f5b8c424b> converter) {
  RL_1560940f84afb17b822113e1812ea380 result = new RL_1560940f84afb17b822113e1812ea380();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1560940f84afb17b822113e1812ea380 FromRestList<T>(RestList<T> restList, Func <T, RC_27f9dcc2de814d2d04d4d18f5b8c424b> converter) {
  RL_1560940f84afb17b822113e1812ea380 result = new RL_1560940f84afb17b822113e1812ea380();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1560940f84afb17b822113e1812ea380() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_27f9dcc2de814d2d04d4d18f5b8c424b> NewList() {
return new RL_1560940f84afb17b822113e1812ea380();
}


} // RL_1560940f84afb17b822113e1812ea380
}

