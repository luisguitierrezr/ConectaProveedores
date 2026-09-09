namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (O33iOU8QO0qUsvMDaJQotQ)
///  <code>RC_77596ad92a148cdc1c9041931e7db72e</code> that represents <code>IdRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: IdRecord
public partial struct RC_77596ad92a148cdc1c9041931e7db72e : ITypedRecord<RC_77596ad92a148cdc1c9041931e7db72e> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2WpZdxQq3IwckEGTHn23Lg");

public long ssId;


public BitArray OptimizedAttributes;

public RC_77596ad92a148cdc1c9041931e7db72e() {
OptimizedAttributes = null;
ssId = 0L;
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
ssId = r.ReadEntityReferenceLongInteger(index++, "IdRecord.Id", 0L);
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
public void ReadIM(RC_77596ad92a148cdc1c9041931e7db72e r) {
this = r;
}


public static bool operator == (RC_77596ad92a148cdc1c9041931e7db72e a, RC_77596ad92a148cdc1c9041931e7db72e b) {
if (a.ssId != b.ssId) return false;
return true;
}

public static bool operator != (RC_77596ad92a148cdc1c9041931e7db72e a, RC_77596ad92a148cdc1c9041931e7db72e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_77596ad92a148cdc1c9041931e7db72e)) return false;
return (this == (RC_77596ad92a148cdc1c9041931e7db72e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_77596ad92a148cdc1c9041931e7db72e Duplicate() {
RC_77596ad92a148cdc1c9041931e7db72e t;
t.ssId = this.ssId;
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
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
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
if (key == IdId) {
return ssId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
}
} // RC_77596ad92a148cdc1c9041931e7db72e
/// <summary>
/// RecordList type <code>IdRecordList</code> that represents a record list of
///  <code>FolioIdentifier</code>
/// </summary>
public partial class RL_898e2ae93bd7a88073ace16e8010d5ee : GenericRecordList<RC_77596ad92a148cdc1c9041931e7db72e>, IEnumerable, IEnumerator {

protected override RC_77596ad92a148cdc1c9041931e7db72e GetElementDefaultValue() {
return new RC_77596ad92a148cdc1c9041931e7db72e();
}

public T[] ToArray<T>(Func<RC_77596ad92a148cdc1c9041931e7db72e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_898e2ae93bd7a88073ace16e8010d5ee recordList, Func<RC_77596ad92a148cdc1c9041931e7db72e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_898e2ae93bd7a88073ace16e8010d5ee(RC_77596ad92a148cdc1c9041931e7db72e[] array) {
  RL_898e2ae93bd7a88073ace16e8010d5ee result = new RL_898e2ae93bd7a88073ace16e8010d5ee();
result.InnerFromArray(array);
    return result;
}

public static RL_898e2ae93bd7a88073ace16e8010d5ee ToList<T>(T[] array, Func <T, RC_77596ad92a148cdc1c9041931e7db72e> converter) {
  RL_898e2ae93bd7a88073ace16e8010d5ee result = new RL_898e2ae93bd7a88073ace16e8010d5ee();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_898e2ae93bd7a88073ace16e8010d5ee FromRestList<T>(RestList<T> restList, Func <T, RC_77596ad92a148cdc1c9041931e7db72e> converter) {
  RL_898e2ae93bd7a88073ace16e8010d5ee result = new RL_898e2ae93bd7a88073ace16e8010d5ee();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_898e2ae93bd7a88073ace16e8010d5ee() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_77596ad92a148cdc1c9041931e7db72e> NewList() {
return new RL_898e2ae93bd7a88073ace16e8010d5ee();
}


} // RL_898e2ae93bd7a88073ace16e8010d5ee
}

